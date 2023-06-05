Imports System.Data.SqlClient
Public Class Tbl_CategoriasDAO
    Dim strConn As String = My.Settings.StrConexion

    Public Function MostrarCategorias() As DataSet
        Dim ds As New DataSet

        Try
            Dim tsql As String = "Select id_categoria As N'CÓDIGO', nombreCatg As N'CATEGORÍA', descripcionCatg As N'DESCRIPCIÓN' From Categoría WHERE estado <> 0"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener los registros de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return ds
    End Function

    Public Function AgregarCategoria(ByVal categoria As Tbl_Categorias) As Boolean
        Dim resultado As Boolean = False

        Try
            Dim tsql As String = "INSERT INTO Categoría(nombreCatg, descripcionCatg)
                                    VALUES(@nombreCatg, @descripcionCatg)"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@nombreCatg", categoria.NombreCatg)
            cmd.Parameters.AddWithValue("@descripcionCatg", categoria.DescripcionCatg)
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

    Public Function validarCategoria(ByVal categoria As Tbl_Categorias) As Boolean
        Dim resultado = False
        Try
            Dim dt As New DataTable
            Dim conn As New SqlConnection(strConn)
            Dim tsql As String = "SELECT * FROM Categoría WHERE nombreCatg = @nombreCatg AND estado <> 0"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombreCatg", categoria.NombreCatg)
            da.Fill(dt)
            If (dt.Rows.Count > 0) Then Return True
        Catch ex As Exception
            MsgBox("Ocurrió un error al validar la existencia de la categoria", MsgBoxStyle.Critical, "Error")
        End Try
        Return resultado
    End Function

    Public Function EditarCategoria(ByVal categoria As Tbl_Categorias) As Boolean
        Dim resp As Boolean = False
        Dim tsql As String = "UPDATE Categoría SET nombreCatg = @nombreCatg, descripcionCatg = @descripcionCatg
				            	WHERE id_categoria = @id_categoria "
        Dim conn As New SqlConnection(strConn)
        conn.Open()
        Dim cmd As New SqlCommand(tsql, conn)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@id_categoria", categoria.Id_categoria)
        cmd.Parameters.AddWithValue("@nombreCatg", categoria.NombreCatg)
        cmd.Parameters.AddWithValue("@descripcionCatg", categoria.DescripcionCatg)

        If (cmd.ExecuteNonQuery <> 0) Then
            resp = True
        End If
        conn.Close()
        Return resp

    End Function

    Public Function BuscarCategoria(ByVal id_categoria As Integer) As Tbl_Categorias
        Dim categoria As New Tbl_Categorias
        Try
            Dim tsql As String = "SELECT * FROM Categoría WHERE id_categoria = @id_categoria"
            Dim conn As New SqlConnection(strConn)
            Dim tbl As New DataTable
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@id_categoria", id_categoria)
            da.Fill(tbl)

            If tbl.Rows.Count > 0 Then

                categoria.Id_categoria = tbl.Rows(0).Item("id_categoria")
                categoria.NombreCatg = tbl.Rows(0).Item("nombreCatg")
                categoria.DescripcionCatg = tbl.Rows(0).Item("descripcionCatg")
                categoria.Estado = tbl.Rows(0).Item("estado")

            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error al buscar la categoria" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return categoria
    End Function


    Public Function EliminarCategoria(ByVal id_categoria As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "UPDATE Categoría SET estado = 0 WHERE id_categoria = @id_categoria "
            Dim conn As New SqlConnection(strConn)
            conn.Open()
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@id_categoria", id_categoria)
            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Error al intentar eliminar la categoria", MsgBoxStyle.Critical, "Error")
            resp = False
        End Try
        Return resp
    End Function

    Public Function BuscarXNombreC(ByVal nombreCatg As String) As DataSet
        Dim ds As New DataSet
        Try
            Dim tsql As String = "SELECT id_categoria as N'CÓDIGO', 
                                         nombreCatg as N'CATEGORÍA', 
                                         descripcionCatg as N'DESCRIPCIÓN' FROM Categoría WHERE nombreCatg like @nombreCatg "
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombreCatg", nombreCatg)
            da.Fill(ds)
        Catch ex As Exception

        End Try
        Return ds
    End Function


End Class
