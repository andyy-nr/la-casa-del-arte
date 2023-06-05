Imports System.Data.SqlClient
Public Class Tbl_MarcasDAO
    Dim strConn As String = My.Settings.StrConexion

    Public Function MostrarMarcas() As DataSet
        Dim ds As New DataSet

        Try
            Dim tsql As String = "Select id_marca As N'CÓDIGO', nombreMarca As N'MARCA', descripcionMarca As N'DESCRIPCIÓN' From Marca WHERE estado <> 0"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener los registros de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return ds
    End Function


    Public Function AgregarMarca(ByVal marca As Tbl_Marcas) As Boolean
        Dim resultado As Boolean = False

        Try
            Dim tsql As String = "INSERT INTO Marca(nombreMarca, descripcionMarca)
                                    VALUES(@nombreMarca, @descripcionMarca)"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@nombreMarca", marca.NombreMarca)
            cmd.Parameters.AddWithValue("@descripcionMarca", marca.DescripcionMarca)
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

    Public Function validarMarca(ByVal marca As Tbl_Marcas) As Boolean
        Dim resultado = False
        Try
            Dim dt As New DataTable
            Dim conn As New SqlConnection(strConn)
            Dim tsql As String = "SELECT * FROM Marca WHERE nombreMarca = @nombreMarca AND estado <> 0"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombreMarca", marca.NombreMarca)
            da.Fill(dt)
            If (dt.Rows.Count > 0) Then Return True
        Catch ex As Exception
            MsgBox("Ocurrió un error al validar la existencia de la marca", MsgBoxStyle.Critical, "Error")
        End Try
        Return resultado
    End Function

    Public Function EditarMarca(ByVal marca As Tbl_Marcas) As Boolean
        Dim resp As Boolean = False
        Dim tsql As String = "UPDATE Marca SET nombreMarca = @nombreMarca, descripcionMarca = @descripcionMarca 
				            	WHERE id_marca = @id_marca "
        Dim conn As New SqlConnection(strConn)
        conn.Open()
        Dim cmd As New SqlCommand(tsql, conn)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@id_marca", marca.Id_marca)
        cmd.Parameters.AddWithValue("@nombreMarca", marca.NombreMarca)
        cmd.Parameters.AddWithValue("@descripcionMarca", marca.DescripcionMarca)

        If (cmd.ExecuteNonQuery <> 0) Then
            resp = True
        End If
        conn.Close()
        Return resp

    End Function

    Public Function BuscarMarca(ByVal id_marca As Integer) As Tbl_Marcas
        Dim marca As New Tbl_Marcas
        Try
            Dim tsql As String = "SELECT * FROM Marca WHERE id_marca = @id_marca"
            Dim conn As New SqlConnection(strConn)
            Dim tbl As New DataTable
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@id_marca", id_marca)
            da.Fill(tbl)

            If tbl.Rows.Count > 0 Then

                marca.Id_marca = tbl.Rows(0).Item("id_marca")
                marca.NombreMarca = tbl.Rows(0).Item("nombreMarca")
                marca.DescripcionMarca = tbl.Rows(0).Item("descripcionMarca")
                marca.Estado = tbl.Rows(0).Item("estado")

            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error al buscar la marca" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return marca
    End Function


    Public Function EliminarMarca(ByVal id_marca As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "UPDATE Marca SET estado = 0 WHERE id_marca = @id_marca "
            Dim conn As New SqlConnection(strConn)
            conn.Open()
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@id_marca", id_marca)
            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Error al intentar eliminar la marca", MsgBoxStyle.Critical, "Error")
            resp = False
        End Try
        Return resp
    End Function

    Public Function BuscarXNombreM(ByVal nombreMarca As String) As DataSet
        Dim ds As New DataSet
        Try
            Dim tsql As String = "SELECT id_marca as N'CÓDIGO', 
                                         nombreMarca as N'MARCA', 
                                         descripcionMarca as N'DESCRIPCIÓN' FROM Marca WHERE nombreMarca like @nombreMarca "
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombreMarca", nombreMarca)
            da.Fill(ds)
        Catch ex As Exception

        End Try
        Return ds
    End Function

End Class