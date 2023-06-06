Imports Microsoft.Reporting.WinForms
Imports System.Windows

Module Modulo1
    Sub VerReporte(ByVal t As DataTable, ByVal nombreDs As String, ByVal nombreRpt As String)

        Try
            Dim rpt As New ReportDataSource(nombreDs, t)
            With New FrmReportes
                .ReportViewer1.LocalReport.DataSources.Clear()
                .ReportViewer1.LocalReport.DataSources.Add(rpt)
                .ReportViewer1.LocalReport.ReportPath = nombreRpt
                .ReportViewer1.Refresh()
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar el reporte")
        End Try
    End Sub
End Module
