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

    Public Function CargarProducto(ByVal id_producto As String) As DataTable
        Dim dt As New DataTable

        Try
            Dim tsql As String = "SELECT Producto.id_producto, Categoría.nombreCatg, Marca.nombreMarca, Producto.nombreProd, Producto.precio_unitario, Producto.descripcionProd, Producto.unidadesProd
                                       FROM     Producto INNER JOIN
                                            Categoría ON Producto.id_categoria = Categoría.id_categoria INNER JOIN
                                            Marca ON Producto.id_marca = Marca.id_marca
                                       WHERE id_producto = @id_producto"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@id_producto", id_producto)
            da.Fill(dt)
        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener los registros de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return dt
    End Function

End Class
