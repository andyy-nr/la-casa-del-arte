Public Class FrmRoles

    Dim permiso As New Tbl_PermisoDAO

    'Instancia de un objeto de la clase Usuario como atributo del formulario Roles
    Private _usuarioSistema As New Usuario()
    Public Property UsuarioSistema As Usuario
        Get
            Return _usuarioSistema
        End Get
        Set(value As Usuario)
            _usuarioSistema = value
        End Set
    End Property

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
            FrmPrincipal.UsuarioSistema = UsuarioSistema
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

        If (TxtNomRol.Text <> "") And ClbPermisos.CheckedItems.Count > 0 Then
            camposLlenados = True
        End If
        Return camposLlenados
    End Function

    'Funcion para validar los campos no obligatorios del formulario
    Private Function validarCamposNull(ByVal campo As String, txt As TextBox) As String
        If String.IsNullOrEmpty(txt.Text.Trim) Then
            campo = ""
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
        Limpiar()
        If (validarRegistros()) Then
            Dim idRol As Integer
            Dim permisos As New List(Of String)()
            Dim rolPermisoDAO As New Tbl_rol_permisoDAO()
            Dim fila As Integer = DgvRoles.CurrentRow.Index
            idRol = DgvRoles.Rows(fila).Cells(0).Value
            TxtIdRol.Text = DgvRoles.Rows(fila).Cells(0).Value
            TxtNomRol.Text = DgvRoles.Rows(fila).Cells(1).Value
            TxtDescRol.Text = DgvRoles.Rows(fila).Cells(2).Value.ToString()
            BtnAgregarRol.Enabled = False
            permisos = rolPermisoDAO.obtenerPermiso(idRol)
            For Each per In permisos
                Dim index As Integer = ClbPermisos.FindString(per)
                If index >= 0 Then
                    ClbPermisos.SetItemChecked(index, True)
                End If
            Next

        End If
    End Sub

    'Botones CRUD (Create, Read, Update, Delete)

    'Botón para agregar un permiso

    Private Sub BtnAgregarRol_Click(sender As Object, e As EventArgs) Handles BtnAgregarRol.Click
        Dim codRol As Integer
        Dim codPerm As Integer

        Try
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
                MsgBox("Error al guardar el registro", MsgBoxStyle.Critical, "Permiso")
                Limpiar()
            End If
        Catch ex As Exception
            MsgBox("Error al intentar editar el registro..." & ex.Message, MsgBoxStyle.Critical, "Roles")
        End Try

    End Sub

    Private Sub BtnEliminarRol_Click(sender As Object, e As EventArgs) Handles BtnEliminarRol.Click
        Try
            If Not validarCampos() Then
                MsgBox("No ha seleccionado ningún registro", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If
            Dim id_rol As Integer = TxtIdRol.Text.Trim()
            Dim rolPermisoDAO As New Tbl_rol_permisoDAO()
            If rolPermisoDAO.eliminarRolPermiso(id_rol) Then
                Dim rolDAO As New Tbl_RolesDAO()
                Dim rol As New Tbl_Roles
                rol = rolDAO.BuscarRol(id_rol)

                If (rol.Id_rol = 0) Then
                    MsgBox("El rol no existe", MsgBoxStyle.Exclamation, "Roles")
                    Exit Sub
                End If
                Dim resp As VariantType
                resp = (MsgBox("Desea eliminar el rol: " & rol.NombreRol, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Roles"))
                If (resp = vbNo) Then
                    MsgBox("Tarea cancelada", MsgBoxStyle.Information, "Roles")
                    Limpiar()
                    Exit Sub
                End If
                Dim eliminado = rolDAO.eliminarRol(rol.Id_rol)
                If (eliminado) Then
                    MsgBox("Rol eliminado exitosamente", MsgBoxStyle.Information, "Roles")
                    LlenarTabla()
                    Limpiar()
                Else
                    Limpiar()
                End If
            Else
                MsgBox("Ocurrio un error al intentar eliminar la union del rol con los permisos", MsgBoxStyle.Critical, "Roles")
                Limpiar()
            End If
        Catch ex As Exception
            MsgBox("Error al intentar editar el registro..." & ex.Message, MsgBoxStyle.Critical, "Roles")
        End Try
    End Sub

    Private Sub BtnEditarRol_Click(sender As Object, e As EventArgs) Handles BtnEditarRol.Click
        Try
            If Not validarCampos() Then
                MsgBox("No ha seleccionado ningún registro", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If
            Dim codPerm As Integer
            Dim rolPermiso As New Tbl_Rol_Permiso
            Dim rolPermisoDAO As New Tbl_rol_permisoDAO()
            Dim codRol As Integer

            codRol = TxtIdRol.Text.Trim
            Dim respDos = rolPermisoDAO.eliminarRolPermiso(codRol)
            For Each item As Object In ClbPermisos.CheckedItems

                Dim drvitem As DataRowView = TryCast(item, DataRowView)
                codPerm = drvitem("Código")

                rolPermiso.Id_rol = codRol
                rolPermiso.Id_permiso = codPerm

                If respDos = True Then
                    Dim respTres = rolPermisoDAO.agregarRolPermiso(rolPermiso)
                End If
            Next item

            Dim rol As New Tbl_Roles
            Dim rolDAO As New Tbl_RolesDAO()

            rol.Id_rol = TxtIdRol.Text
            rol.NombreRol = TxtNomRol.Text.Trim
            rol.DescripcionRol = validarCamposNull(rol.DescripcionRol, TxtDescRol)

            Dim resp = rolDAO.editarRol(rol)

            If (resp) Then
                MsgBox("Rol editado exitosamente.", MsgBoxStyle.Information, "Roles")

                'En caso de que el rol editado se el rol del Usuario Actual
                If UsuarioSistema.IdRol = rol.Id_rol Then
                    Dim usuarioDAO As New Tbl_UsuariosDAO()
                    Dim rol_permiso_Dao As New Tbl_rol_permisoDAO()
                    Dim user As New Usuario()
                    user = usuarioDAO.cargarUsuarioActual(UsuarioSistema.UsuarioID)
                    user.ListaPermisos = rol_permiso_Dao.obtenerIdPermisoXIdRol(user.IdRol)
                    Me.UsuarioSistema = user
                    FrmPrincipal.UsuarioSistema = user
                    FrmPrincipal.cargarEtiquetas()
                    FrmPrincipal.cargarPermisos()
                End If
            Else
                MsgBox("Error al intentar editar el rol", MsgBoxStyle.Critical, "Roles")
            End If

            Limpiar()
            LlenarTabla()


        Catch ex As Exception
            MsgBox("Error al intentar editar el registro..." & ex.Message, MsgBoxStyle.Critical, "Roles")
        End Try
    End Sub

    Private Sub BtnBuscarRol_Click(sender As Object, e As EventArgs) Handles BtnBuscarRol.Click
        Dim ds As New DataSet
        Dim dao As New Tbl_RolesDAO()

        ds = dao.BuscarXNombre(TxtBuscarRol.Text.Trim)
        DgvRoles.DataSource = ds.Tables(0)
        DgvRoles.Refresh()

        If TxtBuscarRol.Text = "" Then
            MsgBox("No hay registros que buscar.", MsgBoxStyle.Information, "Roles")
            LlenarTabla()
        End If
    End Sub

    Private Sub TxtBuscarRol_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarRol.TextChanged
        If TxtBuscarRol.Text = "" Then
            LlenarTabla()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        LlenarTabla()
    End Sub

    'Limpiar campos
    Private Sub BtnLimpiarRol_Click(sender As Object, e As EventArgs) Handles BtnLimpiarRol.Click
        Limpiar()
    End Sub

End Class