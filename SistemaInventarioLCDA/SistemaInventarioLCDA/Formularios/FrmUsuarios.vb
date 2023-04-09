Public Class FrmUsuarios
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
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Size = Screen.PrimaryScreen.WorkingArea.Size
        Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub



    'Botones
    Private Sub PibCerrar_Click(sender As Object, e As EventArgs) Handles PibCerrar.Click
        'Application.Exit()
        Close()
    End Sub


    Private Sub PibMinimizar_Click(sender As Object, e As EventArgs) Handles PibMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CebMostrarPwd_CheckedChanged(sender As Object, e As EventArgs) Handles CebMostrarPwd.CheckedChanged
        If CebMostrarPwd.Checked = True Then
            TxtPwd.UseSystemPasswordChar = False
        Else
            TxtPwd.UseSystemPasswordChar = True
        End If
    End Sub

End Class