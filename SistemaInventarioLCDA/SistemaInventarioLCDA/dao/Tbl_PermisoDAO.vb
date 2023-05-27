Imports System.Data.SqlClient


Public Class Tbl_PermisoDAO
    Dim strConn As String = My.Settings.StrConexion

    Public Function MostrarPermisos() As DataSet
        Dim ds As New DataSet
        Try
            Dim tsql As String = "Select id_permiso as N'CÓDIGO', permiso as N'PERMISO', descripcion as N'DESCRIPCIÓN' from Permiso"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)

        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener el registro de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")

        End Try
        Return ds
    End Function

    Public Function agregarPermiso(ByVal permiso As Tbl_Permiso) As Boolean
        Dim resultado As Boolean = False

        Try
            Dim tsql As String = "INSERT INTO Permiso(permiso, descripcion) VALUES (@permiso, @descripcion)"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@permiso", permiso.Permiso)
            cmd.Parameters.AddWithValue("@descripcion", validarValorDBNull(permiso.DescripcionPermiso))
            cmd.Connection = conn
            cmd.Connection.Open()

            If (cmd.ExecuteNonQuery <> 0) Then
                resultado = True
            End If
            cmd.Connection.Close()
        Catch ex As Exception

        End Try
        Return resultado
    End Function

    Public Function EditarPermiso(ByVal permiso As Tbl_Permiso) As Boolean
        Dim resp As Boolean = False
        Dim tsql = "UPDATE Permiso set permiso = @permiso, descripcion = @descripcion WHERE id_permiso = @id_permiso"
        Dim conn As New SqlConnection(strConn)
        conn.Open()
        Dim cmd As New SqlCommand(tsql, conn)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@id_permiso", permiso.Id_permiso)
        cmd.Parameters.AddWithValue("@permiso", permiso.Permiso)
        cmd.Parameters.AddWithValue("@descripcion", validarValorDBNull(permiso.DescripcionPermiso))

        If (cmd.ExecuteNonQuery <> 0) Then
            resp = True
        End If
        conn.Close()

        Return resp
    End Function

    Public Function validarPermiso(ByVal permiso As Tbl_Permiso) As Boolean
        Dim result = False
        Try
            Dim dt As New DataTable
            Dim conn As New SqlConnection(strConn)
            Dim tsql As String = "SELECT * FROM Permiso WHERE permiso = @permiso"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@permiso", permiso.Permiso)
            da.Fill(dt)
            If (dt.Rows.Count > 0) Then
                Return True
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error al validar la existencia del permiso", MsgBoxStyle.Critical, "Error")
        End Try
        Return result
    End Function


    Public Function validarValorDBNull(ByVal valor As Object) As Object
        If valor Is Nothing Then
            Return DBNull.Value
        Else
            Return valor
        End If

    End Function

    Public Function BuscarPermiso(ByVal id_permiso As Integer) As Tbl_Permiso
        Dim permiso As New Tbl_Permiso
        Try
            Dim tsql As String = "SELECT * FROM Permiso WHERE id_permiso = @id_permiso"
            Dim conn As New SqlConnection(strConn)
            Dim tbl As New DataTable
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@id_permiso", id_permiso)
            da.Fill(tbl)

            If tbl.Rows.Count > 0 Then
                permiso.Id_permiso = tbl.Rows(0).Item("id_permiso")
                permiso.Permiso = tbl.Rows(0).Item("permiso")
                permiso.DescripcionPermiso = tbl.Rows(0).Item("descripcion")

            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error buscar el permiso" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return permiso

    End Function

    Public Function EliminarPermiso(ByVal id_permiso As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "DELETE FROM Permiso WHERE id_permiso = @id_permiso"
            Dim conn As New SqlConnection(strConn)
            conn.Open()
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@id_permiso", id_permiso)
            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar eliminar el permiso" & ex.Message, MsgBoxStyle.Critical, "Error")
            resp = False
        End Try
        Return resp
    End Function

    Public Function BuscarXNombre(ByVal permiso As String) As DataSet
        Dim ds As New DataSet
        Try
            Dim tsql As String = "SELECT id_permiso as N'CÓDIGO', 
                                         permiso as N'PERMISO', 
                                         descripcion as N'DESCRIPCIÓN' FROM Permiso WHERE permiso like @permiso "
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@permiso", permiso)
            da.Fill(ds)

        Catch ex As Exception

        End Try
        Return ds
    End Function


End Class
