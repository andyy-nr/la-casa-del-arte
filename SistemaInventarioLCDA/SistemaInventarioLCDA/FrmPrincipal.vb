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



    'Botones
    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        FrmUsuario.Show()
    End Sub

    Private Sub BtnProductos_Click(sender As Object, e As EventArgs) Handles BtnProductos.Click
        FrmProductos.Show()
    End Sub

    Private Sub BtnMovimientos_Click(sender As Object, e As EventArgs) Handles BtnMovimientos.Click
        If PanMovimientos.Visible = False Then
            PanMovimientos.Visible = True
        Else
            PanMovimientos.Visible = False
        End If
    End Sub

End Class
