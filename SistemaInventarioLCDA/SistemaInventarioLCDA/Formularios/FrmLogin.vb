Public Class FrmLogin
    'Movimiento de Ventana
    Dim ex As Integer, ey As Integer
    Dim Arrastre As Boolean
    Private Sub PanSuperiorL_MouseDown(sender As Object, e As MouseEventArgs) Handles PanSuperiorL.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub PanSuperiorL_MouseMove(sender As Object, e As MouseEventArgs) Handles PanSuperiorL.MouseMove
        If Arrastre Then
            Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - ex, MousePosition.Y - Me.Location.Y - ey))
        End If
    End Sub

    Private Sub PanSuperiorL_MouseUp(sender As Object, e As MouseEventArgs) Handles PanSuperiorL.MouseUp
        Arrastre = False
    End Sub



    'Cajas de Texto
    Private Sub TxtUserL_Enter(sender As Object, e As EventArgs) Handles TxtUserL.Enter
        If TxtUserL.Text = "USUARIO" Then
            TxtUserL.Text = ""
            TxtUserL.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtUserL_Leave(sender As Object, e As EventArgs) Handles TxtUserL.Leave
        If TxtUserL.Text = "" Then
            TxtUserL.Text = "USUARIO"
            TxtUserL.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub TxtPwdL_Enter(sender As Object, e As EventArgs) Handles TxtPwdL.Enter
        If TxtPwdL.Text = "CONTRASEÑA" Then
            TxtPwdL.Text = ""
            TxtPwdL.ForeColor = Color.Black
            TxtPwdL.UseSystemPasswordChar = True
        End If
    End Sub


    Private Sub TxtPwdL_Leave(sender As Object, e As EventArgs) Handles TxtPwdL.Leave
        If TxtPwdL.Text = "" Then
            TxtPwdL.Text = "CONTRASEÑA"
            TxtPwdL.ForeColor = Color.DimGray
            TxtPwdL.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub limpiarCampos()
        TxtUserL.Clear()
        TxtPwdL.Clear()
        TxtUserL.Focus()
        CebMostrarPwdL.Checked = False
    End Sub

    'Botones
    Private Sub PibCerrar_Click(sender As Object, e As EventArgs) Handles PibCerrar.Click
        Close()
    End Sub

    Private Sub PibMinimizar_Click(sender As Object, e As EventArgs) Handles PibMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Dim login As New Tbl_UsuariosDAO

    'Botón para entrar al menú principal
    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click
        'Comprobación de si el usuario y la contraseña ingresada existen en la base de datos
        Dim user As String = TxtUserL.Text.Trim
        Dim pwd As String = TxtPwdL.Text.Trim
        Dim usuarioLogin As New Usuario
        Dim usuarioDAO As New Tbl_UsuariosDAO()
        Dim rolPermisoDAO As New Tbl_rol_permisoDAO()

        If TxtUserL.Text = "USUARIO" Or TxtPwdL.Text = "CONTRASEÑA" Then
            MsgBox("Por favor ingrese los datos completos.", MsgBoxStyle.Exclamation, "Advertencia")
        Else
            If login.validarLogin(user, pwd) Then
                usuarioLogin = usuarioDAO.usuarioSistema(user)
                usuarioLogin.ListaPermisos = rolPermisoDAO.obtenerIdPermisoXIdRol(usuarioLogin.IdRol)
                limpiarCampos()
                FrmPrincipal.UsuarioSistema = usuarioLogin
                MsgBox("Bienvenido al Sistema de Inventario La Casa Del Arte", MsgBoxStyle.Information, "Inicio de Sesión")
                Me.Hide()
                FrmPrincipal.Show()
            Else
                MsgBox("Usuario y Contraseña Incorrectas.", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub

    'Botón para salir del programa
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub CebMostrarPwdL_CheckedChanged(sender As Object, e As EventArgs) Handles CebMostrarPwdL.CheckedChanged
        If CebMostrarPwdL.Checked = True Then
            TxtPwdL.UseSystemPasswordChar = False
        Else
            TxtPwdL.UseSystemPasswordChar = True
        End If
    End Sub

End Class