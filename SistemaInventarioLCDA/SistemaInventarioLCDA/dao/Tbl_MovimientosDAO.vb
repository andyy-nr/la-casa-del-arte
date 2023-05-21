Imports System.Data.SqlClient
Public Class Tbl_MovimientosDAO
    Dim strConn As String = My.Settings.StrConexion

    Public Function MostrarMovimientos() As DataSet
        Dim ds As New DataSet

        Try
            Dim tsql As String = ""
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener los registros de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return ds
    End Function
End Class
