Imports System.Data.SqlClient
Imports System.Xml

Public Class Tbl_rol_permisoDAO
    Dim strConn As String = My.Settings.StrConexion
    Public Function agregarRolPermiso(ByVal rolPermiso As Tbl_Rol_Permiso) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "INSERT INTO RolPermiso (id_permiso, id_rol) Values (@id_permiso, @id_rol)"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@id_permiso", rolPermiso.Id_permiso)
            cmd.Parameters.AddWithValue("@id_rol", rolPermiso.Id_rol)
            cmd.Connection = conn
            cmd.Connection.Open()

            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            cmd.Connection.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar asociar el rol con los permisos", MsgBoxStyle.Critical, "Error")
            resp = False
        End Try
        Return resp
    End Function

    Public Function obtenerPermiso(ByVal id_rol As Integer) As List(Of String)
        Dim permisos As New List(Of String)()
        Dim tsql As String = "SELECT Permiso.permiso FROM RolPermiso INNER JOIN Permiso ON Permiso.id_permiso = RolPermiso.id_permiso WHERE id_rol = @id_rol"

        Using conn As New SqlConnection(strConn)
            Using cmd As New SqlCommand(tsql, conn)
                cmd.Parameters.AddWithValue("@id_rol", id_rol)
                conn.Open()

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        permisos.Add(reader("permiso").ToString())
                    End While
                End Using
            End Using
        End Using

        Return permisos
    End Function


    Public Function validarUnion(ByVal id_permiso As Integer) As Boolean
        Dim resp As Boolean = False
        Dim dt As New DataTable
        Try
            Dim tsql As String = "SELECT * FROM RolPermiso Where id_permiso = @id_permiso"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@id_permiso", id_permiso)
            da.Fill(dt)
            If (dt.Rows.Count > 0) Then
                Return True
            End If

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar validar la union del permiso con un rol", MsgBoxStyle.Critical, "Error")
            resp = False
        End Try
        Return resp
    End Function

    Public Function eliminarRolPermiso(ByVal id_rol As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "DELETE FROM RolPermiso WHERE id_rol = @id_rol"
            Dim conn As New SqlConnection(strConn)
            conn.Open()
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@id_rol", id_rol)
            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar eliminar la unión del rol con el permiso", MsgBoxStyle.Critical, "Error")
            resp = False
        End Try
        Return resp
    End Function

End Class
