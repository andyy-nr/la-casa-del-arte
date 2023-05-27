Public Class FrmPermiso
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
    Private Sub FrmPermisos_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Ajustar tamaño del formulario a la pantalla.
        Size = Screen.PrimaryScreen.WorkingArea.Size
        Location = Screen.PrimaryScreen.WorkingArea.Location
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
    'Función para rellenar el DGV de Permisos
    Sub LlenarTabla()
        Dim permisoDAO As New Tbl_PermisoDAO
        DgvPermisos.DataSource = permisoDAO.MostrarPermisos().Tables(0)
        DgvPermisos.Refresh()
        GbPermisos.Text = "Permisos Registrados: " & DgvPermisos.RowCount

    End Sub

    Private Sub Limpiar()
        TxtIdPermiso.Clear()
        TxtNomPermiso.Clear()
        TxtDescPerm.Clear()
        TxtNomPermiso.Focus()
        BtnAgregarPermiso.Enabled = True

    End Sub

    'Validaciones 
    'Funcion que valida los campos obligatorios del formulario
    Private Function validarCampos() As Boolean
        Dim camposLlenados = False

        If (TxtNomPermiso.Text <> "") Then
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
        If (DgvPermisos.Rows.Count = 0) Then
            MsgBox("No hay registros guardados, porfavor agregue registros", MsgBoxStyle.Exclamation, "Advertencia")
            TxtNomPermiso.Focus()
            Return False
            Exit Function
        Else
            resp = True
        End If
        Return True
    End Function



    'Botones CRUD (Create, Read, Update, Delete)

    'Botón para agregar un permiso
    Private Sub BtnAgregarPermiso_Click(sender As Object, e As EventArgs) Handles BtnAgregarPermiso.Click
        Try
            If Not validarCampos() Then
                MsgBox("Datos obligatorios del permiso incompletos.", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If

            Dim permiso = New Tbl_Permiso() 'Entidad/Tabla de Permisos
            Dim permisoDao As New Tbl_PermisoDAO 'DAO de Permisos

            permiso.Permiso = TxtNomPermiso.Text.Trim()
            permiso.DescripcionPermiso = validarCamposNull(permiso.DescripcionPermiso, TxtDescPerm)

            If permisoDao.validarPermiso(permiso) Then
                MsgBox("El permiso ingresado ya existe", MsgBoxStyle.Exclamation, "Advertencia")
                Limpiar()
                Exit Sub
            End If

            Dim resp = permisoDao.agregarPermiso(permiso)
            If (resp) Then
                MsgBox("Registro guardado exitosamente", MsgBoxStyle.Information, "Permiso")
            Else
                MsgBox("Error al guardar el registro", MsgBoxStyle.Critical, "Permiso")

            End If

            Limpiar()
            LlenarTabla()

        Catch ex As Exception
            MsgBox("Error al intentar guardar el registro..." & ex.Message, MsgBoxStyle.Critical, "Permisos")
        End Try
    End Sub

    'Botón para limpiar campos
    Private Sub BtnLimpiarPermiso_Click(sender As Object, e As EventArgs) Handles BtnLimpiarPermiso.Click
        Limpiar()
    End Sub

    'Funcion para comprobar que el DataGridView tenga Datos
    Private Sub DgvPermisos_MouseClick(sender As Object, e As MouseEventArgs) Handles DgvPermisos.MouseClick

        If (validarRegistros()) Then
            Dim fila As Integer = DgvPermisos.CurrentRow.Index
            TxtIdPermiso.Text = DgvPermisos.Rows(fila).Cells(0).Value
            TxtNomPermiso.Text = DgvPermisos.Rows(fila).Cells(1).Value
            TxtDescPerm.Text = DgvPermisos.Rows(fila).Cells(2).Value.ToString()
            BtnAgregarPermiso.Enabled = False

        End If

    End Sub


    'Botón para editar un permiso
    Private Sub BtnEditarPermiso_Click(sender As Object, e As EventArgs) Handles BtnEditarPermiso.Click
        Try
            If Not validarCampos() Then
                MsgBox("No ha seleccionado ningún registro", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If

            Dim permisoDao As New Tbl_PermisoDAO()
            Dim permiso As New Tbl_Permiso

            permiso.Id_permiso = TxtIdPermiso.Text
            permiso.Permiso = TxtNomPermiso.Text.Trim()
            permiso.DescripcionPermiso = validarCamposNull(permiso.DescripcionPermiso, TxtDescPerm)

            Dim resp = permisoDao.EditarPermiso(permiso)
            If (resp) Then
                MsgBox("Permiso editado exitosamente.", MsgBoxStyle.Information, "Permiso")
            Else
                MsgBox("Error al intentar editar el permiso", MsgBoxStyle.Critical, "Permiso")
            End If

            Limpiar()
            LlenarTabla()
        Catch ex As Exception
            MsgBox("Error al intentar editar el registro..." & ex.Message, MsgBoxStyle.Critical, "Permisos")
        End Try

    End Sub

    'Botón para eliminar un permiso
    Private Sub BtnEliminarPermiso_Click(sender As Object, e As EventArgs) Handles BtnEliminarPermiso.Click
        Try
            If Not validarCampos() Then
                MsgBox("No ha seleccionado ningún registro", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If
            Dim Id_permiso As Integer = Integer.Parse(TxtIdPermiso.Text.Trim())
            Dim rolPermisoDAO As New Tbl_rol_permisoDAO()
            If Not rolPermisoDAO.validarUnion(Id_permiso) Then
                Dim permisoDao As New Tbl_PermisoDAO()
                Dim permiso As New Tbl_Permiso
                permiso = permisoDao.BuscarPermiso(Id_permiso)

                If (permiso.Id_permiso = 0) Then
                    MsgBox("El permiso no existe. ", MsgBoxStyle.Exclamation, "Permisos")
                    Exit Sub
                End If
                Dim resp As VariantType
                resp = (MsgBox("Desea eliminar el permiso: " & permiso.Permiso, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Permisos"))
                If (resp = vbNo) Then
                    MsgBox("Tarea cancelada", MsgBoxStyle.Information, "Permisos")
                    Limpiar()
                    Exit Sub
                End If

                Dim eliminado = permisoDao.EliminarPermiso(permiso.Id_permiso)
                If (eliminado) Then
                    MsgBox("Permiso eliminado exitosamente", MsgBoxStyle.Information, "Permisos")
                    LlenarTabla()
                    Limpiar()

                Else
                    'MsgBox("Error al intenar eliminar el permiso", MsgBoxStyle.Critical, "Permisos")
                    Limpiar()
                End If
            Else
                MsgBox("No es posible eliminar el permiso porque esta relacionado con un rol.", MsgBoxStyle.Critical, "Permisos")
                Limpiar()
            End If


        Catch ex As Exception
            MsgBox("Error al intentar eliminar el registro... " & ex.Message, MsgBoxStyle.Critical, "Permisos")
        End Try
    End Sub

    'Botón para buscar por nombre de permiso
    Private Sub TxtBuscarPermiso_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarPermiso.TextChanged
        If TxtBuscarPermiso.Text = "" Then
            LlenarTabla()
        End If
    End Sub

    Private Sub BtnBuscarPermiso_Click(sender As Object, e As EventArgs) Handles BtnBuscarPermiso.Click
        Dim ds As New DataSet
        Dim dao As New Tbl_PermisoDAO()

        ds = dao.BuscarXNombre(TxtBuscarPermiso.Text.Trim)
        DgvPermisos.DataSource = ds.Tables(0)
        DgvPermisos.Refresh()

        If TxtBuscarPermiso.Text = "" Then
            MsgBox("No hay registros que buscar.", MsgBoxStyle.Information, "Permiso")
            LlenarTabla()
        End If
    End Sub







End Class