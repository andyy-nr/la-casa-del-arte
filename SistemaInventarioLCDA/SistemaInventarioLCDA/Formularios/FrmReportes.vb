Public Class FrmReportes
    Private Sub FrmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()
    End Sub



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



    'Ajustar tamaño del formulario a la pantalla.
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Size = Screen.PrimaryScreen.WorkingArea.Size
        Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub
End Class