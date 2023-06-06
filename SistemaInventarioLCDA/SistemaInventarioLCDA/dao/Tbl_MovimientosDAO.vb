Imports System.Data.SqlClient
Public Class Tbl_MovimientosDAO
    Dim strConn As String = My.Settings.StrConexion

    Public Function MostrarMovimientos() As DataSet
        Dim ds As New DataSet

        Try
            Dim tsql As String = "SELECT id_movimiento AS N'CÓDIGO', 
                                         Producto.nombreProd AS N'PRODUCTO', 
                                         Usuario.primer_nombre + '' + Usuario.primer_apellido AS N'USUARIO', 
                                         CASE WHEN tipo_movimiento = 1 THEN 'Entrada' ELSE 'Salida' END AS N'TIPO MOVIMIENTO', 
                                         fecha_movimiento As N'FECHA', 
                                         cantidadProd AS 'CANTIDAD DE PRODUCTO', 
                                         descripcionMov AS N'DESCRIPCIÓN MOVIMIENTO' 
                                         FROM Movimiento INNER JOIN Producto ON Producto.id_producto = Movimiento.id_producto 
                                         INNER JOIN Usuario ON Usuario.usuario_id = Movimiento.usuario_id"
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
            Dim tsql As String = "SELECT Producto.id_producto, Categoría.nombreCatg, Marca.nombreMarca, Producto.nombreProd, Producto.precio_unitario, Producto.descripcionProd, Producto.inventario_inicial, Producto.cantidad_disponible
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

    Public Function agregarMovimiento(ByVal movimiento As Tbl_Movimientos) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "INSERT INTO Movimiento (id_producto, usuario_id, tipo_movimiento, fecha_movimiento, cantidadProd, descripcionMov) Values (@id_producto, @usuario_id, @tipo_movimiento, @fecha_movimiento, @cantidadProd, @descripcionMov)"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@id_producto", movimiento.Id_producto)
            cmd.Parameters.AddWithValue("@usuario_id", movimiento.Usuario_id)
            cmd.Parameters.AddWithValue("@tipo_movimiento", movimiento.Tipo_movimiento)
            cmd.Parameters.AddWithValue("@cantidadProd", movimiento.CantidadProd)
            cmd.Parameters.AddWithValue("@fecha_movimiento", movimiento.Fecha_movimiento)
            cmd.Parameters.AddWithValue("@descripcionMov", movimiento.DescripcionMov)
            cmd.Connection = conn
            cmd.Connection.Open()

            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            cmd.Connection.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error al agregar el movimiento a la base de datos ESTOY EN EL DAO" & ex.Message, MsgBoxStyle.Critical, "Error")
            resp = False
        End Try
        Return resp
    End Function

    Public Function buscarXcodigo(ByVal codigo As Integer) As DataSet
        Dim ds As New DataSet

        Try
            Dim tsql As String = "SELECT id_movimiento AS N'CÓDIGO', 
                                         Producto.nombreProd AS N'PRODUCTO', 
                                         Usuario.primer_nombre + '' + Usuario.primer_apellido AS N'USUARIO', 
                                         CASE WHEN tipo_movimiento = 1 THEN 'Entrada' ELSE 'Salida' END AS N'TIPO MOVIMIENTO', 
                                         fecha_movimiento As N'FECHA', 
                                         cantidadProd AS 'CANTIDAD DE PRODUCTO', 
                                         descripcionMov AS N'DESCRIPCIÓN MOVIMIENTO' 
                                         FROM Movimiento INNER JOIN Producto ON Producto.id_producto = Movimiento.id_producto 
                                         INNER JOIN Usuario ON Usuario.usuario_id = Movimiento.usuario_id
										 WHERE Movimiento.id_movimiento = @id_movimiento"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@id_movimiento", codigo)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener el registro de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function

    Public Function buscarXproducto(ByVal producto As String) As DataSet
        Dim ds As New DataSet

        Try
            Dim tsql As String = "SELECT id_movimiento AS N'CÓDIGO', 
                                         Producto.nombreProd AS N'PRODUCTO', 
                                         Usuario.primer_nombre + '' + Usuario.primer_apellido AS N'USUARIO', 
                                         CASE WHEN tipo_movimiento = 1 THEN 'Entrada' ELSE 'Salida' END AS N'TIPO MOVIMIENTO', 
                                         fecha_movimiento As N'FECHA', 
                                         cantidadProd AS 'CANTIDAD DE PRODUCTO', 
                                         descripcionMov AS N'DESCRIPCIÓN MOVIMIENTO' 
                                         FROM Movimiento INNER JOIN Producto ON Producto.id_producto = Movimiento.id_producto 
                                         INNER JOIN Usuario ON Usuario.usuario_id = Movimiento.usuario_id
										 WHERE Producto.nombreProd = @nombreProd"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombreProd", producto)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener el registro de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function

    Public Function buscarXentrada() As DataSet
        Dim ds As New DataSet

        Try
            Dim tsql As String = "SELECT id_movimiento AS N'CÓDIGO', 
                                         Producto.nombreProd AS N'PRODUCTO', 
                                         Usuario.primer_nombre + '' + Usuario.primer_apellido AS N'USUARIO', 
                                         CASE WHEN tipo_movimiento = 1 THEN 'Entrada' ELSE 'Salida' END AS N'TIPO MOVIMIENTO', 
                                         fecha_movimiento As N'FECHA', 
                                         cantidadProd AS 'CANTIDAD DE PRODUCTO', 
                                         descripcionMov AS N'DESCRIPCIÓN MOVIMIENTO' 
                                         FROM Movimiento INNER JOIN Producto ON Producto.id_producto = Movimiento.id_producto 
                                         INNER JOIN Usuario ON Usuario.usuario_id = Movimiento.usuario_id
										 WHERE Movimiento.tipo_movimiento = 1"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener el registro de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function

    Public Function buscarXsalida() As DataSet
        Dim ds As New DataSet

        Try
            Dim tsql As String = "SELECT id_movimiento AS N'CÓDIGO', 
                                         Producto.nombreProd AS N'PRODUCTO', 
                                         Usuario.primer_nombre + '' + Usuario.primer_apellido AS N'USUARIO', 
                                         CASE WHEN tipo_movimiento = 1 THEN 'Entrada' ELSE 'Salida' END AS N'TIPO MOVIMIENTO', 
                                         fecha_movimiento As N'FECHA', 
                                         cantidadProd AS 'CANTIDAD DE PRODUCTO', 
                                         descripcionMov AS N'DESCRIPCIÓN MOVIMIENTO' 
                                         FROM Movimiento INNER JOIN Producto ON Producto.id_producto = Movimiento.id_producto 
                                         INNER JOIN Usuario ON Usuario.usuario_id = Movimiento.usuario_id
										 WHERE Movimiento.tipo_movimiento = 0"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener el registro de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function

    Public Function buscarXFecha(ByVal fecha As Integer) As DataSet
        Dim ds As New DataSet

        Try
            Dim tsql As String = "SELECT id_movimiento AS N'CÓDIGO', 
                                         Producto.nombreProd AS N'PRODUCTO', 
                                         Usuario.primer_nombre + '' + Usuario.primer_apellido AS N'USUARIO', 
                                         CASE WHEN tipo_movimiento = 1 THEN 'Entrada' ELSE 'Salida' END AS N'TIPO MOVIMIENTO', 
                                         fecha_movimiento As N'FECHA', 
                                         cantidadProd AS 'CANTIDAD DE PRODUCTO', 
                                         descripcionMov AS N'DESCRIPCIÓN MOVIMIENTO' 
                                         FROM Movimiento INNER JOIN Producto ON Producto.id_producto = Movimiento.id_producto 
                                         INNER JOIN Usuario ON Usuario.usuario_id = Movimiento.usuario_id
										 WHERE  (MONTH(Movimiento.fecha_movimiento) = @fecha)"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@fecha", fecha)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener el registro de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function

End Class
