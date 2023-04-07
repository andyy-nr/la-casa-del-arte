Public Class FrmCategorias
    Private Sub BtnInicio_Click(sender As Object, e As EventArgs) Handles BtnInicio.Click
        Dim Respuesta = MsgBox("¿Esta seguro de que desea cerrar? Cualquier información no guardada se perdera", MsgBoxStyle.OkCancel, "Cerrar")
        If Respuesta = vbOK Then
            Me.Close()
            FrmPrincipal.Visible = True
        End If
    End Sub
End Class