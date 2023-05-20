Imports System.Data.SqlClient
Public Class Tbl_CategoriasDAO
    Dim strConn As String = My.Settings.StrConexion

    Public Function MostrarCategorias() As DataSet
        Dim ds As New DataSet

        Try
            Dim tsql As String = "Select id_categoria As N'CÓDIGO', nombreCatg As N'CATEGORÍA', descripcionCatg As N'DESCRIPCIÓN' From Categoría"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener los registros de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return ds
    End Function
End Class
