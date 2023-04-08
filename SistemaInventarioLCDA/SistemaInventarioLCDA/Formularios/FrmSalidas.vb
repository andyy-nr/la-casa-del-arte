Public Class FrmSalidas
    'Ajustar tamaño del formulario a la pantalla.
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Size = Screen.PrimaryScreen.WorkingArea.Size
        Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub

End Class