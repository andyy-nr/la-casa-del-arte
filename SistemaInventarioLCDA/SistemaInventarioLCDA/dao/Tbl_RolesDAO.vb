Imports System.Data.SqlClient
Imports Microsoft.Reporting.Map.WebForms.BingMaps

Public Class Tbl_RolesDAO

    Dim strConn As String = My.Settings.StrConexion

    Public Function MostrarRoles() As DataSet
        Dim ds As New DataSet
        Try
            Dim tsql As String = "SELECT Rol.id_rol as N'CÓDIGO' ,Rol.nombreRol as N'ROL', Rol.descripcionRol as N'DESCRIPCION', Permiso.permiso as N'PERMISO' FROM  RolPermiso INNER JOIN
                  Rol ON Rol.id_rol = RolPermiso.id_rol INNER JOIN
                  Permiso ON RolPermiso.id_permiso = Permiso.id_permiso"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)

        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener el registro de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")

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
            cmd.Parameters.AddWithValue("@descripcionRol", validarValorDBNull(rol.DescripcionRol))
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


    Public Function validarValorDBNull(ByVal valor As Object) As Object
        If valor Is Nothing Then
            Return DBNull.Value
        Else
            Return valor
        End If
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

End Class
