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



    'Botones
    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click
        FrmPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub CebMostrarPwdL_CheckedChanged(sender As Object, e As EventArgs) Handles CebMostrarPwdL.CheckedChanged
        If CebMostrarPwdL.Checked = True Then
            TxtPwdL.UseSystemPasswordChar = False
        Else
            TxtPwdL.UseSystemPasswordChar = True
        End If
    End Sub

End Class