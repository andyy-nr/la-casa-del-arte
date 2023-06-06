Imports System.Text.RegularExpressions
Public Class FrmUsuarios

    'Instancia de un objeto de la clase Usuario como atributo del formulario movimiento
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



    'Ajustar tamaño del formulario a la pantalla.
    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        Size = Screen.PrimaryScreen.WorkingArea.Size
        Location = Screen.PrimaryScreen.WorkingArea.Location
        LlenarComboxRol()
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


    Private Sub PibMinimizar_Click(sender As Object, e As EventArgs) Handles PibMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
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

    Private Sub CebMostrarPwd_CheckedChanged(sender As Object, e As EventArgs)
        If CebMostrarPwd.Checked = True Then
            TxtPwd.UseSystemPasswordChar = False
        Else
            TxtPwd.UseSystemPasswordChar = True
        End If
    End Sub
    'Validaciones
    'Función que valida los campos obligatorios del formulario
    Private Function validarCampos() As Boolean
        Dim camposLlenados = False

        If (TxtNombre1.Text <> "" And TxtApellido1.Text <> "" And CbRoles.Text <> "Seleccione un rol..." And TxtNombreUsuario.Text <> "" And TxtTelefono.Text <> "" And TxtCedula.Text <> "" And TxtPwd.Text <> "") Then
            If DtpFechaNac.Checked Then
                camposLlenados = True
            End If
        End If

        Return camposLlenados
    End Function

    Private Function validarCamposEditar() As Boolean
        Dim camposLlenados = False

        If (TxtNombre1.Text <> "" And TxtApellido1.Text <> "" And CbRoles.Text <> "Seleccione un rol..." And TxtNombreUsuario.Text <> "" And TxtTelefono.Text <> "" And TxtCedula.Text <> "") Then
            If DtpFechaNac.Checked Then
                camposLlenados = True
            End If
        End If

        Return camposLlenados
    End Function

    'Función para validar los campos no obligatorios del formulario
    Private Function validarCamposNull(ByVal campo As String, txt As TextBox) As String
        If String.IsNullOrEmpty(txt.Text.Trim) Then
            campo = ""
        Else
            campo = txt.Text
        End If
        Return campo
    End Function

    'Función para validar la contraseña

    Private Function validarContraseña(ByVal contraseña As String) As Boolean
        Dim resp As Boolean = False
        Dim cont As Integer = 0
        Dim patron As String = "[^a-zA-Z0-9]" 'coincide con cualquier carácter que no sea una letra (mayúscula o minúscula) ni un número.
        Dim regex As New Regex(patron) 'Funcion del espacio de nombres System.Text.RegularExpressions 
        'para crear una expresión regular que busca caracteres que no sean letras ni números

        If Len(contraseña) < 8 Then
            MsgBox("La contraseña debe tener al menos 8 caracteres", MsgBoxStyle.Exclamation, "Advertencia")
            Return False
        End If

        For Each c As Char In contraseña
            If Char.IsLetter(c) Then
                cont = cont + 1
                Exit For
            End If
        Next

        For Each c As Char In contraseña
            If Char.IsNumber(c) Then
                cont = cont + 1
                Exit For
            End If
        Next

        If regex.IsMatch(contraseña) Then
            cont = cont + 1
        End If

        If cont = 3 Then
            resp = True
        Else
            MsgBox("La contraseña debe contener letras, números y caracteres especiales", MsgBoxStyle.Exclamation, "Advertencia")
            resp = False
        End If

        Return resp
    End Function


    'Función para validar que el DataGridView tenga datos
    Private Function validarRegistros() As Boolean
        Dim resp = False
        If (DgvUsuarios.Rows.Count = 0) Then
            MsgBox("No hay registros guardados, porfavor agregue registros", MsgBoxStyle.Exclamation, "Advertencia")
            TxtNombre1.Focus()
            Return False
            Exit Function
        Else
            resp = True
        End If
        Return True
    End Function

    'Datos

    'Función para rellenar la tabla de usuarios 
    Sub LlenarTabla()
        Dim usuariosDAO As New Tbl_UsuariosDAO
        DgvUsuarios.DataSource = usuariosDAO.MostrarUsuarios().Tables(0)
        DgvUsuarios.Refresh()
        GbUsuarios.Text = "Usuarios Almacenados: " & DgvUsuarios.RowCount
    End Sub

    'Función para rellenar el comboBox de roles

    Dim rolesDAO As New Tbl_RolesDAO()

    Sub LlenarComboxRol()
        Dim ds As New DataSet
        ds = rolesDAO.MostrarRolesComboBox()
        CbRoles.DataSource = ds.Tables(0)
        CbRoles.DisplayMember = "ROL" 'Nombre del alias
        CbRoles.ValueMember = "CÓDIGO" 'Nombre del alias 
        CbRoles.Text = "Seleccione un rol..."
    End Sub

    'Función para limpiar los campos del formulario
    Private Sub Limpiar()
        TxtNombre1.Clear()
        TxtNombre2.Clear()
        TxtApellido1.Clear()
        TxtApellido2.Clear()
        DtpFechaNac.Text = DateTime.Today.ToString()
        TxtTelefono.Clear()
        TxtCedula.Clear()
        TxtCodUser.Clear()
        TxtNombreUsuario.Clear()
        CbRoles.Text = "Seleccione un rol..."
        TxtPwd.Clear()
        TxtPwdNew.Clear()
        BtnAgregarU.Enabled = True
        LblPwd.Visible = True
        LblPwdActual.Visible = False
        LblPwdNew.Visible = False
        TxtPwdNew.Visible = False
        CebMostrarPwdNew.Visible = False
        TxtNombre1.Focus()
    End Sub

    'Función para rellenar los campos del formulario al seleccionar una fila del DataGripViewer
    Private Sub DgvUsuarios_MouseClick(sender As Object, e As MouseEventArgs) Handles DgvUsuarios.MouseClick
        Try
            If (validarRegistros()) Then
                Dim usuarioDAO As New Tbl_UsuariosDAO()
                Dim dt As New DataTable
                Dim usuario_id As Integer
                Dim fila As Integer = DgvUsuarios.CurrentRow.Index
                TxtCodUser.Text = DgvUsuarios.Rows(fila).Cells(0).Value
                CbRoles.Text = DgvUsuarios.Rows(fila).Cells(1).Value
                usuario_id = Integer.Parse(TxtCodUser.Text)
                dt = usuarioDAO.obtenerNombre(usuario_id)

                If dt.Rows.Count > 0 Then
                    Dim filaDos As DataRow = dt.Rows(0)
                    TxtNombre1.Text = filaDos("primer_nombre").ToString()
                    TxtNombre2.Text = filaDos("segundo_nombre").ToString()
                    TxtApellido1.Text = filaDos("primer_apellido").ToString()
                    TxtApellido2.Text = filaDos("segundo_apellido").ToString()
                End If

                TxtNombreUsuario.Text = DgvUsuarios.Rows(fila).Cells(3).Value
                TxtTelefono.Text = DgvUsuarios.Rows(fila).Cells(4).Value
                DtpFechaNac.Text = DgvUsuarios.Rows(fila).Cells(5).Value
                TxtCedula.Text = DgvUsuarios.Rows(fila).Cells(6).Value
                'TxtPwd.Text = usuarioDAO.obtenerContraseña(usuario_id) Permiso Exclusivo para el Administrador
                TxtPwd.Text = ""

                BtnAgregarU.Enabled = False
                LblPwd.Visible = False
                LblPwdActual.Visible = True
                LblPwdNew.Visible = True
                TxtPwdNew.Visible = True
                CebMostrarPwdNew.Visible = True
            End If
        Catch ex As Exception
            MsgBox("Ocurrio al cargar los datos del usuario seleccionado" & ex.Message, MsgBoxStyle.Critical, "Usuarios")
        End Try
    End Sub



    'CRUD de Usuarios

    'Botón para agregar un nuevo usuario
    Private Sub BtnAgregarU_Click(sender As Object, e As EventArgs) Handles BtnAgregarU.Click
        Try
            If Not validarCampos() Then
                MsgBox("Datos obligatorios del usuario incompletos.", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If


            Dim usuario = New Tbl_Usuarios() 'Entidad/Tabla de Usuarios
            Dim usuarioDAO As New Tbl_UsuariosDAO() 'DAO de Usuarios

            usuario.Id_rol = CbRoles.SelectedValue
            usuario.Primer_nombre = TxtNombre1.Text.Trim
            usuario.Segundo_nombre = validarCamposNull(usuario.Segundo_nombre, TxtNombre2)
            usuario.Primer_apellido = TxtApellido1.Text.Trim
            usuario.Segundo_apellido = validarCamposNull(usuario.Segundo_apellido, TxtApellido2)
            usuario.Nombre_usuario = TxtNombreUsuario.Text.Trim
            usuario.Telefono = TxtTelefono.Text.Trim
            usuario.Fecha_nac = DtpFechaNac.Value
            usuario.Cedula = TxtCedula.Text.Trim
            usuario.Contraseña = TxtPwd.Text.Trim

            If usuarioDAO.validarUsuario(usuario) Then
                MsgBox("El nombre de usuario " & usuario.Nombre_usuario + " no esta disponible", MsgBoxStyle.Exclamation, "Advertencia")
                TxtNombreUsuario.Clear()
                TxtNombreUsuario.Focus()
                Exit Sub
            End If

            If Not validarContraseña(usuario.Contraseña) Then
                TxtPwd.Clear()
                TxtPwd.Focus()
                Exit Sub
            End If

            Dim resp = usuarioDAO.agregarUsuario(usuario)
            If (resp) Then
                MsgBox("Registro guardado exitosamente.", MsgBoxStyle.Information, "Usuarios")
                LlenarTabla()
                Limpiar()
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("Error al intentar agregar el usuario..." & ex.Message, MsgBoxStyle.Critical, "Usuarios")
        End Try
    End Sub

    'Función para mostrar la contraseña
    Private Sub CebMostrarPwd_CheckedChanged_1(sender As Object, e As EventArgs) Handles CebMostrarPwd.CheckedChanged
        If CebMostrarPwd.Checked = True Then
            TxtPwd.UseSystemPasswordChar = False
        Else
            TxtPwd.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CebMostrarPwdNew_CheckedChanged(sender As Object, e As EventArgs) Handles CebMostrarPwdNew.CheckedChanged
        If CebMostrarPwdNew.Checked = True Then
            TxtPwdNew.UseSystemPasswordChar = False
        Else
            TxtPwdNew.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BtnEditarU_Click(sender As Object, e As EventArgs) Handles BtnEditarU.Click

        Try
            If Not validarCamposEditar() Then
                MsgBox("No ha seleccionado ningún registro", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If
            Dim codUsuario As Integer = Integer.Parse(TxtCodUser.Text)

            Dim usuarioDAO As New Tbl_UsuariosDAO()
            Dim usuario As New Tbl_Usuarios

            usuario.Usuario_id = TxtCodUser.Text
            usuario.Id_rol = CbRoles.SelectedValue
            usuario.Primer_nombre = TxtNombre1.Text.Trim
            usuario.Segundo_nombre = validarCamposNull(usuario.Segundo_nombre, TxtNombre2)
            usuario.Primer_apellido = TxtApellido1.Text.Trim
            usuario.Segundo_apellido = validarCamposNull(usuario.Segundo_apellido, TxtApellido2)
            usuario.Nombre_usuario = TxtNombreUsuario.Text.Trim
            usuario.Telefono = TxtTelefono.Text.Trim
            usuario.Fecha_nac = DtpFechaNac.Value
            usuario.Cedula = TxtCedula.Text.Trim

            If Not (usuario.Nombre_usuario = usuarioDAO.obtenerNomUsuario(usuario.Usuario_id)) Then
                If usuarioDAO.validarUsuario(usuario) Then
                    MsgBox("El nombre de usuario " & usuario.Nombre_usuario + " no esta disponible", MsgBoxStyle.Exclamation, "Advertencia")
                    TxtNombreUsuario.Clear()
                    TxtNombreUsuario.Focus()
                    Exit Sub
                End If
            End If

            If (TxtPwd.Text <> "" And TxtPwdNew.Text <> "") Then

                Dim contraActual As String = usuarioDAO.obtenerContraseña(codUsuario)
                Dim contraEscrita As String = TxtPwd.Text.Trim
                Dim contraNueva As String = TxtPwdNew.Text.Trim
                If (contraActual = contraEscrita) Then
                    If validarContraseña(contraNueva) Then
                        If usuarioDAO.editarContraseña(codUsuario, contraNueva) Then
                            MsgBox("La contraseña se editó correctamente", MsgBoxStyle.Information, "Usuario")
                        End If
                    Else
                        TxtPwdNew.Clear()
                        TxtPwdNew.Focus()
                        Exit Sub
                    End If
                Else
                    MsgBox("Ha escrito incorrectamente la contraseña actual", MsgBoxStyle.Exclamation, "Usuario")
                    TxtPwd.Clear()
                    TxtPwdNew.Clear()
                    TxtPwd.Focus()
                    Exit Sub
                End If
            End If

            Dim resp = usuarioDAO.EditarUsuario(usuario)
            If (resp) Then
                MsgBox("Usuario editado exitosamente.", MsgBoxStyle.Information, "Usuario")

                'En caso de que el usuario actual haya sido editado
                If UsuarioSistema.UsuarioID = Integer.Parse(TxtCodUser.Text) Then
                    Dim rol_permiso_Dao As New Tbl_rol_permisoDAO()
                    Dim user As New Usuario()
                    user = usuarioDAO.cargarUsuarioActual(UsuarioSistema.UsuarioID)
                    user.ListaPermisos = rol_permiso_Dao.obtenerIdPermisoXIdRol(user.IdRol)
                    Me.UsuarioSistema = user
                    FrmPrincipal.UsuarioSistema = user
                    FrmPrincipal.cargarEtiquetas()
                End If
            Else
                MsgBox("Error al intentar editar el Usuario", MsgBoxStyle.Critical, "Usuario")
            End If
            Limpiar()
            LlenarTabla()

        Catch ex As Exception
            MsgBox("Error al intentar editar el usuario..." & ex.Message, MsgBoxStyle.Critical, "Usuarios")
        End Try
    End Sub

    Private Sub BtnEliminarU_Click(sender As Object, e As EventArgs) Handles BtnEliminarU.Click
        Try
            If Not validarCamposEditar() Then
                MsgBox("No ha seleccionado nigún registro", MsgBoxStyle.Exclamation, "Advertencia")
                Exit Sub
            End If
            Dim codUser As Integer = Integer.Parse(TxtCodUser.Text.Trim())
            Dim usuarioDAO As New Tbl_UsuariosDAO()
            Dim usuario As New Tbl_Usuarios
            usuario = usuarioDAO.buscarUsuario(codUser)

            If (usuario.Usuario_id = 0) Then
                MsgBox("El usuario no existe. ", MsgBoxStyle.Exclamation, "Permisos")
                Exit Sub
            End If

            Dim resp As VariantType
            resp = (MsgBox("Desea eliminar el usuario: " & usuario.Nombre_usuario, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Permisos"))
            If (resp = vbNo) Then
                MsgBox("Tarea cancelada", MsgBoxStyle.Information, "Usuarios")
                Limpiar()
                Exit Sub
            End If

            Dim eliminado = usuarioDAO.eliminarUsuario(usuario.Usuario_id)
            If (eliminado) Then
                MsgBox("Usuario eliminado exitosamente", MsgBoxStyle.Information, "Permisos")
                LlenarTabla()
                Dim nombreUsu As String = TxtNombreUsuario.Text.Trim
                If nombreUsu = UsuarioSistema.NombreUsuario Then
                    Me.Close()
                    FrmPrincipal.Close()
                    FrmLogin.Show()
                End If
                Limpiar()
            Else
                Limpiar()
            End If


        Catch ex As Exception
            MsgBox("Error al intentar eliminar el registro... " & ex.Message, MsgBoxStyle.Critical, "Usuarios")
        End Try
    End Sub

    Private Sub BtnBuscarUsuario_Click(sender As Object, e As EventArgs) Handles BtnBuscarUsuario.Click
        Try
            Dim buscar As String = TxtBuscarUsuario.Text.Trim()
            Dim ds As New DataSet
            ds = FiltrarUsuario(buscar)
            DgvUsuarios.DataSource = ds.Tables(0)
            DgvUsuarios.Refresh()
            GbUsuarios.Text = "Usuarios Almacenados: " & DgvUsuarios.RowCount

            If TxtBuscarUsuario.Text = "" Then
                MsgBox("No hay registros que buscar.", MsgBoxStyle.Information, "Categorias")
                LlenarTabla()
            End If
        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener el registro de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function FiltrarUsuario(ByVal buscar As String) As DataSet
        Dim usuarioDAO As New Tbl_UsuariosDAO()
        Dim ds As New DataSet
        Select Case CmbFiltrarUsuarios.SelectedIndex
            Case 0
                ds = usuarioDAO.usuarioNombreCompleto(buscar)
            Case 1
                ds = usuarioDAO.usuarioNombre(buscar)
            Case 2
                ds = usuarioDAO.usuarioApellido(buscar)
            Case 3
                ds = usuarioDAO.usuarioNombreUsuario(buscar)
            Case 4
                ds = usuarioDAO.usuarioPorRol(buscar)
        End Select
        Return ds
    End Function

    Private Sub TxtBuscarUsuario_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarUsuario.TextChanged
        If TxtBuscarUsuario.Text = "" Then
            CmbFiltrarUsuarios.Text = "Filtrar Usuarios"
            LlenarTabla()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        LlenarTabla()
    End Sub

    'Botón para limpiar los campos del formulario
    Private Sub BtnLimpiarU_Click(sender As Object, e As EventArgs) Handles BtnLimpiarU.Click
        Limpiar()
    End Sub

End Class