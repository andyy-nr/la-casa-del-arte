Imports System.Data.SqlClient
Public Class Tbl_ProductosDAO
    Dim strConn As String = My.Settings.StrConexion

    Public Function MostrarProductos() As DataSet
        Dim ds As New DataSet

        Try
            Dim tsql As String = "SELECT Producto.id_producto As N'CÓDIGO', Categoría.nombreCatg As N'CATEGORÍA', Marca.nombreMarca As N'MARCA', Producto.nombreProd As N'PRODUCTO', Producto.precio_unitario As N'PRECIO', Producto.descripcionProd As N'DESCRIPCIÓN', Producto.inventario_inicial As N'INVENTARIO INICIAL', Producto.cantidad_disponible As N'UNIDADES DISPONIBLES'
                                    FROM     Producto INNER JOIN
                                        Categoría ON Producto.id_categoria = Categoría.id_categoria INNER JOIN
                                        Marca ON Producto.id_marca = Marca.id_marca
									WHERE Producto.estado <> 0"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener los registros de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return ds
    End Function


    Public Function AgregarProducto(ByVal producto As Tbl_Productos) As Boolean
        Dim resultado As Boolean = False

        Try
            Dim tsql As String = "INSERT INTO Producto(id_producto, id_categoria, id_marca, nombreProd, precio_unitario, descripcionProd, inventario_inicial, cantidad_disponible) 
                                    VALUES(@id_producto, @id_categoria, @id_marca, @nombreProd, @precio_unitario, @descripcionProd, @inventario_inicial, @cantidad_disponible)"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@id_producto", producto.Id_producto)
            cmd.Parameters.AddWithValue("@id_categoria", producto.Id_categoria)
            cmd.Parameters.AddWithValue("@id_marca", producto.Id_marca)
            cmd.Parameters.AddWithValue("@nombreProd", producto.NombreProd)
            cmd.Parameters.AddWithValue("@precio_unitario", producto.Precio_unitario)
            cmd.Parameters.AddWithValue("@descripcionProd", producto.DescripcionProd)
            cmd.Parameters.AddWithValue("@inventario_inicial", producto.Inventario_inicial)
            cmd.Parameters.AddWithValue("@cantidad_disponible", producto.Cantidad_disponible)
            cmd.Connection = conn
            cmd.Connection.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                resultado = True
            End If
            cmd.Connection.Close()

        Catch ex As Exception
            resultado = False
        End Try
        Return resultado
    End Function


    Public Function BuscarProducto(ByVal id_producto As String) As Tbl_Productos
        Dim producto As New Tbl_Productos
        Try
            Dim tsql As String = "Select * from Producto where id_producto = @id_producto"
            Dim conn As New SqlConnection(strConn)
            Dim tbl As New DataTable
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@id_producto", id_producto)
            da.Fill(tbl)

            If tbl.Rows.Count > 0 Then

                producto.Id_producto = tbl.Rows(0).Item("id_producto")
                producto.Id_categoria = tbl.Rows(0).Item("id_categoria")
                producto.Id_marca = tbl.Rows(0).Item("id_marca")
                producto.NombreProd = tbl.Rows(0).Item("nombreProd")
                producto.Precio_unitario = tbl.Rows(0).Item("precio_unitario")
                producto.DescripcionProd = tbl.Rows(0).Item("descripcionProd")
                producto.Inventario_inicial = tbl.Rows(0).Item("inventario_inicial")
                producto.Cantidad_disponible = tbl.Rows(0).Item("cantidad_disponible")
                producto.Estado = tbl.Rows(0).Item("estado")

            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error al buscar el producto" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return producto
    End Function


    Public Function EliminarProducto(ByVal id_producto As String) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "UPDATE Producto SET estado = 0 WHERE id_producto = @id_producto"
            Dim conn As New SqlConnection(strConn)
            conn.Open()
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@id_producto", id_producto)
            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Error al intentar eliminar el producto", MsgBoxStyle.Critical, "Error")
            resp = False
        End Try
        Return resp
    End Function


    Public Function EditarProducto(ByVal producto As Tbl_Productos) As Boolean
        Dim resp As Boolean = False
        Dim tsql As String = "Update Producto SET id_producto=@id_producto, id_categoria=@id_categoria,id_marca=@id_marca, nombreProd=@nombreProd, precio_unitario=@precio_unitario, 
                                 descripcionProd=@descripcionProd, inventario_inicial=@inventario_inicial, cantidad_disponible=@cantidad_disponible
                                    WHERE id_producto = @id_producto"
        Dim conn As New SqlConnection(strConn)
        conn.Open()
        Dim cmd As New SqlCommand(tsql, conn)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@id_producto", producto.Id_producto)
        cmd.Parameters.AddWithValue("@id_categoria", producto.Id_categoria)
        cmd.Parameters.AddWithValue("@id_marca", producto.Id_marca)
        cmd.Parameters.AddWithValue("@nombreProd", producto.NombreProd)
        cmd.Parameters.AddWithValue("@precio_unitario", producto.Precio_unitario)
        cmd.Parameters.AddWithValue("@descripcionProd", producto.DescripcionProd)
        cmd.Parameters.AddWithValue("@inventario_inicial", producto.Inventario_inicial)
        cmd.Parameters.AddWithValue("@cantidad_disponible", producto.Cantidad_disponible)


        If (cmd.ExecuteNonQuery <> 0) Then
            resp = True
        End If
        conn.Close()
        Return resp

    End Function


    Public Function BuscarXNombre(ByVal nombreProducto As String) As DataSet
        Dim ds As New DataSet
        Try
            Dim tsql As String = "SELECT Producto.id_producto As N'CÓDIGO', Categoría.nombreCatg As N'CATEGORÍA', Marca.nombreMarca As N'MARCA', Producto.nombreProd As N'PRODUCTO', Producto.precio_unitario As N'PRECIO', Producto.descripcionProd As N'DESCRIPCIÓN', Producto.inventario_inicial As N'INVENTARIO INICIAL', Producto.cantidad_disponible As N'UNIDADES DISPONIBLES'
                                    FROM     Producto INNER JOIN
                                        Categoría ON Producto.id_categoria = Categoría.id_categoria INNER JOIN
                                        Marca ON Producto.id_marca = Marca.id_marca
									WHERE nombreProd like @nombreProd"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombreProd", nombreProducto)
            da.Fill(ds)
        Catch ex As Exception

        End Try
        Return ds
    End Function


    Public Function validarProducto(ByVal producto As Tbl_Productos) As Boolean
        Dim resultado = False
        Try
            Dim dt As New DataTable
            Dim conn As New SqlConnection(strConn)
            Dim tsql As String = "SELECT * FROM Producto WHERE id_producto = @id_producto AND estado <> 0"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@id_producto", producto.Id_producto)
            da.Fill(dt)
            If (dt.Rows.Count > 0) Then Return True
        Catch ex As Exception
            MsgBox("Ocurrio un error al validar la existencia del producto", MsgBoxStyle.Critical, "Error")
        End Try
        Return resultado
    End Function

    Public Function restarUnidades(ByVal cantidadProd As Integer, ByVal id_producto As String) As Boolean
        Dim resp As Boolean = False
        Try

            Dim tsql As String = "UPDATE Producto SET cantidad_disponible = cantidad_disponible - @cantidadProd WHERE id_producto = @id_producto"
            Dim conn As New SqlConnection(strConn)
            conn.Open()
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@id_producto", id_producto)
            cmd.Parameters.AddWithValue("@cantidadProd", cantidadProd)

            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            conn.Close()
            Return resp
        Catch ex As Exception
            MsgBox("Ocurrio un error al restar el inventario del producto", MsgBoxStyle.Critical, "Error")
        End Try
        Return resp
    End Function

    Public Function sumarUnidades(ByVal cantidadProd As Integer, ByVal id_producto As String) As Boolean
        Dim resp As Boolean = False
        Try

            Dim tsql As String = "UPDATE Producto SET cantidad_disponible = cantidad_disponible + @cantidadProd WHERE id_producto = @id_producto"
            Dim conn As New SqlConnection(strConn)
            conn.Open()
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@id_producto", id_producto)
            cmd.Parameters.AddWithValue("@cantidadProd", cantidadProd)

            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            conn.Close()
            Return resp
        Catch ex As Exception
            MsgBox("Ocurrio un error al sumar unidades al inventario del producto", MsgBoxStyle.Critical, "Error")
        End Try
        Return resp
    End Function

    Public Function validarProductoNombre(ByVal producto As Tbl_Productos) As Boolean
        Dim resp = False
        Dim dt As New DataTable
        Try
            Dim tsql As String = "SELECT * FROM Producto WHERE nombreProd = @nombreProd AND estado <> 0"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombreProd", producto.NombreProd)
            da.Fill(dt)
            If (dt.Rows.Count > 0) Then
                Return True
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error al validar el nombre del producto", MsgBoxStyle.Critical, "Error")
        End Try
        Return resp
    End Function

End Class
