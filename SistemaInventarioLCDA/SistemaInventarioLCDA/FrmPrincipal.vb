Public Class FrmPrincipal


    'Movimientos de Ventana.
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




    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Ajustar tamaño del formulario a la pantalla.
        Size = Screen.PrimaryScreen.WorkingArea.Size
        Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

    'Animaciones del menú.
    Private Sub TmrOcultar_Tick(sender As Object, e As EventArgs) Handles TmrOcultar.Tick
        If PanMenu.Width <= 60 Then
            TmrOcultar.Enabled = False
        Else
            PanMenu.Width = PanMenu.Width - 20
        End If
    End Sub

    Private Sub TmrMostrar_Tick(sender As Object, e As EventArgs) Handles TmrMostrar.Tick
        If PanMenu.Width >= 220 Then
            TmrMostrar.Enabled = False
        Else
            PanMenu.Width = PanMenu.Width + 20
        End If
    End Sub

    Private Sub PibMenu_Click(sender As Object, e As EventArgs) Handles PibMenu.Click
        If PanMenu.Width = 220 Then
            TmrOcultar.Enabled = True
        ElseIf PanMenu.Width = 60 Then
            TmrMostrar.Enabled = True
        End If
    End Sub

    Private Sub TmrHoraFecha_Tick(sender As Object, e As EventArgs) Handles TmrHoraFecha.Tick
        LblHora.Text = DateTime.Now.ToString("hh:mm")
        LblFecha.Text = DateTime.Now.ToShortDateString
    End Sub



    'Botones
    Private Sub PibCerrar_Click(sender As Object, e As EventArgs) Handles PibCerrar.Click
        Dim Respuesta = MsgBox("¿Estas seguro de que deseas salir del programa?", MsgBoxStyle.OkCancel, "Salir")
        If Respuesta = vbOK Then
            Application.Exit()
        End If
    End Sub

    Private Sub PibMinimizar_Click(sender As Object, e As EventArgs) Handles PibMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PibMaximizar_Click(sender As Object, e As EventArgs) Handles PibMaximizar.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        FrmUsuarios.Show()
    End Sub

    Private Sub BtnProductos_Click(sender As Object, e As EventArgs) Handles BtnProductos.Click
        FrmProductos.Show()
    End Sub

    Private Sub BtnReportes_Click(sender As Object, e As EventArgs) Handles BtnReportes.Click
        FrmReportes.Show()
    End Sub

    Private Sub BtnCategorias_Click(sender As Object, e As EventArgs) Handles BtnCategorias.Click
        FrmCategoria.Show()
    End Sub

    Private Sub BtnRoles_Click(sender As Object, e As EventArgs) Handles BtnRoles.Click
        FrmRoles.Show()
    End Sub

    Private Sub BtnMarca_Click(sender As Object, e As EventArgs) Handles BtnMarca.Click
        FrmMarcas.Show()
    End Sub

    Private Sub BtnPermisos_Click(sender As Object, e As EventArgs) Handles BtnPermisos.Click
        FrmPermiso.Show()
    End Sub

    Private Sub BtnMovimientos_Click(sender As Object, e As EventArgs) Handles BtnMovimientos.Click
        FrmMovimiento.Show()
    End Sub


    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs) Handles BtnCerrarSesion.Click
        Dim Respuesta = MsgBox("¿Estas seguro que deseas cerrar sesión?", MsgBoxStyle.OkCancel, "Cerrar Sesión")
        If Respuesta = vbOK Then
            Me.Close()
            FrmLogin.Show()
        End If
    End Sub


End Class
