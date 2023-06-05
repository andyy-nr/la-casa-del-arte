Imports System.Data.SqlClient


Public Class Tbl_RolesDAO

    Dim strConn As String = My.Settings.StrConexion

    Public Function MostrarRoles() As DataSet
        Dim ds As New DataSet
        Try
            Dim tsql As String = "SELECT Rol.id_rol as N'CÓDIGO', 
                                         Rol.nombreRol as N'ROL', 
                                         Rol.descripcionRol as N'DESCRIPCION', 
                                         Permiso.permiso as N'PERMISO' 
                                         FROM  RolPermiso INNER JOIN
                                         Rol ON Rol.id_rol = RolPermiso.id_rol INNER JOIN
                                         Permiso ON RolPermiso.id_permiso = Permiso.id_permiso
										 WHERE Rol.estado <> 0"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)

        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener el registro de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")

        End Try
        Return ds
    End Function

    Public Function MostrarRolesComboBox() As DataSet
        Dim ds As New DataSet
        Try
            Dim tsql As String = "SELECT id_rol as N'CÓDIGO', 
                                         nombreRol as N'ROL'  
                                         FROM  Rol"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)

        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener el registro de roles de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")

        End Try
        Return ds
    End Function

    Public Function agregarRol(ByVal rol As Tbl_Roles) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "INSERT INTO ROL (nombreRol, descripcionRol) VALUES (@nombreRol, @descripcionRol)"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@nombreRol", rol.NombreRol)
            cmd.Parameters.AddWithValue("@descripcionRol", rol.DescripcionRol)
            cmd.Connection = conn
            cmd.Connection.Open()

            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            cmd.Connection.Close()

        Catch ex As Exception

        End Try
        Return resp
    End Function


    Public Function validarRol(ByVal rol As Tbl_Roles) As Boolean
        Dim result = False
        Try
            Dim dt As New DataTable
            Dim conn As New SqlConnection(strConn)
            Dim tsql As String = "SELECT * FROM Rol WHERE nombreRol = @nombreRol"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombreRol", rol.NombreRol)
            da.Fill(dt)
            If (dt.Rows.Count > 0) Then
                Return True
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error al validar la existencia del rol", MsgBoxStyle.Critical, "Error")
        End Try
        Return result
    End Function

    Public Function codigoRol() As Integer
        Dim result = False
        Dim cod As Integer = 0
        Try
            Dim dt As New DataTable
            Dim conn As New SqlConnection(strConn)
            Dim tsql As String = "SELECT TOP 1 id_rol FROM Rol ORDER BY id_rol DESC"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                cod = dt.Rows(0).Item("id_rol")
            End If

        Catch ex As Exception

        End Try
        Return cod
    End Function

    Public Function BuscarRol(ByVal id_rol As Integer) As Tbl_Roles
        Dim roles As New Tbl_Roles
        Try
            Dim tsql As String = "select * from Rol where id_rol = @id_rol"
            Dim conn As New SqlConnection(strConn)
            Dim tbl As New DataTable
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@id_rol", id_rol)
            da.Fill(tbl)

            If tbl.Rows.Count > 0 Then

                roles.Id_rol = tbl.Rows(0).Item("id_rol")
                roles.NombreRol = tbl.Rows(0).Item("nombreRol")
                roles.DescripcionRol = tbl.Rows(0).Item("descripcionRol")
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error buscar el permiso" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return roles

    End Function

    Public Function eliminarRol(ByVal id_rol As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "UPDATE Rol SET estado = 0 WHERE id_rol = @id_rol"
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
            MsgBox("Ocurrio un error al intentar eliminar el rol", MsgBoxStyle.Critical, "Error")
            resp = False
        End Try
        Return resp
    End Function

    Public Function editarRol(ByVal rol As Tbl_Roles) As Boolean
        Dim resp As Boolean = False
        Dim tsql = "UPDATE rol set nombreRol = @nombreRol, descripcionRol = @descripcionRol WHERE id_rol = @id_rol"
        Dim conn As New SqlConnection(strConn)
        conn.Open()
        Dim cmd As New SqlCommand(tsql, conn)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@id_rol", rol.Id_rol)
        cmd.Parameters.AddWithValue("@nombreRol", rol.NombreRol)
        cmd.Parameters.AddWithValue("@descripcionRol", rol.DescripcionRol)

        If (cmd.ExecuteNonQuery <> 0) Then
            resp = True
        End If
        conn.Close()

        Return resp

    End Function

    Public Function BuscarXNombre(ByVal rol As String) As DataSet
        Dim ds As New DataSet
        Try
            Dim tsql As String = "SELECT Rol.id_rol as N'CÓDIGO' ,
                                         Rol.nombreRol as N'ROL', 
                                         Rol.descripcionRol as N'DESCRIPCION', 
                                         Permiso.permiso as N'PERMISO' 
                                         FROM  RolPermiso INNER JOIN
                                         Rol ON Rol.id_rol = RolPermiso.id_rol INNER JOIN
                                         Permiso ON RolPermiso.id_permiso = Permiso.id_permiso 
                                         WHERE Rol.nombreRol = @rol"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@rol", rol)
            da.Fill(ds)

        Catch ex As Exception

        End Try
        Return ds
    End Function


End Class
