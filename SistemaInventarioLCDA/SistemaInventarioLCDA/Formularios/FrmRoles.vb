Public Class FrmRoles

    Dim permiso As New Tbl_PermisoDAO
    'Movimiento de Ventana
    Dim ex As Integer, ey As Integer
    Dim Arrastre As Boolean

    Private Sub PanSuperior_MouseDown(sender As Object, e As MouseEventArgs) Handles PanSuperior.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub PanSuperior_MouseMove(sender As Object, e As MouseEventArgs) Handles PanSuperior.MouseMove
        If Arrastre Then
            Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - ex, MousePosition.Y - Me.Location.Y - ey))
        End If
    End Sub

    Private Sub PanSuperior_MouseUp(sender As Object, e As MouseEventArgs) Handles PanSuperior.MouseUp
        Arrastre = False
    End Sub



    'Funcion para cargar los datos en el formulario
    Private Sub FrmRoles_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Ajustar tamaño del formulario a la pantalla.
        Size = Screen.PrimaryScreen.WorkingArea.Size
        Location = Screen.PrimaryScreen.WorkingArea.Location
        llenarClbPermiso()
        LlenarTabla()

    End Sub



    'Botones
    Private Sub PibCerrar_Click(sender As Object, e As EventArgs) Handles PibCerrar.Click
        Dim Respuesta = MsgBox("¿Esta seguro de que desea regresar? Cualquier información no guardada se perderá", MsgBoxStyle.OkCancel, "Cerrar")
        If Respuesta = vbOK Then
            Me.Close()
            FrmPrincipal.Visible = True
        End If
    End Sub

    Private Sub PibRetornar_Click(sender As Object, e As EventArgs) Handles PibRetornar.Click
        Dim Respuesta = MsgBox("¿Esta seguro de que desea regresar? Cualquier información no guardada se perdera", MsgBoxStyle.OkCancel, "Cerrar")
        If Respuesta = vbOK Then
            Me.Close()
            FrmPrincipal.Visible = True
        End If
    End Sub

    Private Sub PibMaximizar_Click(sender As Object, e As EventArgs) Handles PibMaximizar.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PibMinimizar_Click(sender As Object, e As EventArgs) Handles PibMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Datos 
    'Función para rellenar el DGV de Roles
    Sub LlenarTabla()
        Dim rolesDAO As New Tbl_RolesDAO
        DgvRoles.DataSource = rolesDAO.MostrarRoles.Tables(0)
        DgvRoles.Refresh()
        GbRoles.Text = "Roles Almacenados: " & DgvRoles.RowCount
    End Sub


    Private Sub Limpiar()
        TxtIdRol.Clear()
        TxtDescRol.Clear()
        TxtNomRol.Clear()
        For i As Integer = 0 To ClbPermisos.Items.Count - 1
            ClbPermisos.SetItemChecked(i, False)
        Next i
        TxtNomRol.Focus()
        BtnAgregarRol.Enabled = True

    End Sub



    'Función para llenar los datos en el CheckListBox
    Sub llenarClbPermiso()

        Dim ds As New DataSet()
        ds = permiso.MostrarPermisos()
        ClbPermisos.DataSource = ds.Tables(0)
        ClbPermisos.DisplayMember = "Permiso"
        ClbPermisos.ValueMember = "Código"

    End Sub



    'Validaciones
    'Funcion que valida los campos obligatorios del formulario

    Private Function validarCampos() As Boolean
        Dim camposLlenados = False

        If (TxtNomRol.Text <> "") Then
            camposLlenados = True
        End If
        Return camposLlenados
    End Function

    'Funcion para validar los campos no obligatorios del formulario
    Private Function validarCamposNull(ByVal campo As String, txt As TextBox) As String
        If String.IsNullOrEmpty(txt.Text.ToString().Trim) Then
            campo = Nothing
        Else
            campo = txt.Text
        End If
        Return campo

    End Function

    'Valida que el DataGridView tenga datos que mostrar
    Private Function validarRegistros() As Boolean
        Dim resp = False
        If (DgvRoles.Rows.Count = 0) Then
            MsgBox("No hay registros guardados, porfavor agregue registros", MsgBoxStyle.Exclamation, "Advertencia")
            TxtNomRol.Focus()
            Return False
            Exit Function
        Else
            resp = True
        End If
        Return True
    End Function

    Private Sub DgvRoles_MouseClick(sender As Object, e As MouseEventArgs) Handles DgvRoles.MouseClick
        If (validarRegistros()) Then
            Dim fila As Integer = DgvRoles.CurrentRow.Index
            TxtIdRol.Text = DgvRoles.Rows(fila).Cells(0).Value
            TxtNomRol.Text = DgvRoles.Rows(fila).Cells(1).Value
            TxtDescRol.Text = DgvRoles.Rows(fila).Cells(2).Value
            BtnAgregarRol.Enabled = False
            Dim valor As String = DgvRoles.Rows(fila).Cells(3).Value
            ' ClbPermisos.SetItemChecked(6, True)
            ' Buscar el índice del item correspondiente al valor
            Dim index As Integer = ClbPermisos.FindString(valor)
            ' Marcar el item si se encuentra
            If index >= 0 Then
                ClbPermisos.SetItemChecked(index, True)
            End If
        End If
    End Sub

    'Botones CRUD (Create, Read, Update, Delete)

    'Botón para agregar un permiso

    Private Sub BtnAgregarRol_Click(sender As Object, e As EventArgs) Handles BtnAgregarRol.Click
        Dim codRol As Integer
        Dim codPerm As Integer

        If Not validarCampos() Then
            MsgBox("Datos obligatorios del rol incompletos.", MsgBoxStyle.Exclamation, "Advertencia")
            Exit Sub
        End If

        Dim rol = New Tbl_Roles() 'Entidad/Tabla de Roles
        Dim rolDAO As New Tbl_RolesDAO 'DAO de Roles
        Dim rolPermiso = New Tbl_Rol_Permiso() 'Entidad/Tabla de Roles
        Dim rolPermisoDAO As New Tbl_rol_permisoDAO() 'DAO de Rol Permiso

        rol.NombreRol = TxtNomRol.Text.Trim()
        rol.DescripcionRol = validarCamposNull(rol.DescripcionRol, TxtDescRol)
        If rolDAO.validarRol(rol) Then
            MsgBox("El rol ingresado ya existe", MsgBoxStyle.Exclamation, "Advertencia")
            Limpiar()
            Exit Sub
        End If

        Dim resp = rolDAO.agregarRol(rol)
        If (resp) Then
            For Each item As Object In ClbPermisos.CheckedItems

                Dim drvitem As DataRowView = TryCast(item, DataRowView)

                codRol = rolDAO.codigoRol()
                codPerm = drvitem("Código")

                rolPermiso.Id_permiso = codPerm
                rolPermiso.Id_rol = codRol

                Dim respDos = rolPermisoDAO.agregarRolPermiso(rolPermiso)
            Next item

            If (resp) Then
                MsgBox("Registro guardado exitosamente.", MsgBoxStyle.Information, "Roles")
                LlenarTabla()
                Limpiar()
            Else
                MsgBox("Error al guardar el registro.", MsgBoxStyle.Critical, "Roles")
                Limpiar()

            End If

        Else
            MsgBox("Error al guardar el registro Hola", MsgBoxStyle.Critical, "Permiso")
            Limpiar()
        End If

    End Sub

    'Limpiar campos
    Private Sub BtnLimpiarRol_Click(sender As Object, e As EventArgs) Handles BtnLimpiarRol.Click
        Limpiar()
    End Sub

End Class