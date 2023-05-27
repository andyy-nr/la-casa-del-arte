Imports System.Data.SqlClient
Public Class Tbl_UsuariosDAO

    Dim strConn As String = My.Settings.StrConexion

    Public Function validarValorDBNull(ByVal valor As Object) As Object
        If valor Is Nothing Then
            Return DBNull.Value
        Else
            Return valor
        End If
    End Function

    Public Function validarUsuario(ByVal usuario As Tbl_Usuarios) As Boolean
        Dim resp = False
        Dim dt As New DataTable
        Try
            Dim tsql As String = "SELECT * FROM Usuario WHERE nombre_usuario = @nombre_usuario"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombre_usuario", usuario.Nombre_usuario)
            da.Fill(dt)
            If (dt.Rows.Count > 0) Then
                Return True
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error al validar el nombre de usuario", MsgBoxStyle.Critical, "Error")
        End Try
        Return resp
    End Function

    Public Function MostrarUsuarios() As DataSet
        Dim ds As New DataSet
        Try
            Dim tsql As String = "SELECT Usuario.usuario_id as N'CÓDIGO', Rol.nombreRol as N'ROL',
                                                 Usuario.primer_nombre + N' ' + ISNULL(Usuario.segundo_nombre, '') + N' ' + 
                                                 Usuario.primer_apellido  + N' ' + 
                                                 ISNULL(Usuario.segundo_apellido, '') as N'NOMBRE COMPLETO',
                                                 Usuario.nombre_usuario as N'NOMBRE DE USUARIO',
                                                 Usuario.telefono as N'TELÉFONO',
                                                 convert(nvarchar(10),Usuario.fecha_nac, 103) as N'FECHA DE NACIMIENTO',
                                                 Usuario.cedula as N'CÉDULA'
                                                 FROM Usuario INNER JOIN Rol On Usuario.id_rol = Rol.id_rol"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)

        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener el registro de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function

    Public Function agregarUsuario(ByVal usuario As Tbl_Usuarios) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "INSERT INTO Usuario(id_rol, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, 
                               nombre_usuario, telefono, fecha_nac, cedula, contraseña) 
                               VALUES (@id_rol, @primer_nombre, @segundo_nombre, @primer_apellido, @segundo_apellido, 
                               @nombre_usuario, @telefono, @fecha_nac, @cedula, @contraseña)"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Parameters.AddWithValue("@id_rol", usuario.Id_rol)
            cmd.Parameters.AddWithValue("@primer_nombre", usuario.Primer_nombre)
            cmd.Parameters.AddWithValue("@segundo_nombre", validarValorDBNull(usuario.Segundo_nombre))
            cmd.Parameters.AddWithValue("@primer_apellido", usuario.Primer_apellido)
            cmd.Parameters.AddWithValue("@segundo_apellido", validarValorDBNull(usuario.Segundo_apellido))
            cmd.Parameters.AddWithValue("@nombre_usuario", usuario.Nombre_usuario)
            cmd.Parameters.AddWithValue("@telefono", usuario.Telefono)
            cmd.Parameters.AddWithValue("@fecha_nac", usuario.Fecha_nac)
            cmd.Parameters.AddWithValue("@cedula", usuario.Cedula)
            cmd.Parameters.AddWithValue("@contraseña", usuario.Contraseña)
            cmd.Connection = conn
            cmd.Connection.Open()

            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            cmd.Connection.Close()
        Catch ex As Exception
            MsgBox("Ocurrió un error al agregar el usuario a la base de datos" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return resp
    End Function

    Public Function obtenerNombre(ByVal usuario_id As Integer) As DataTable
        Dim dt As New DataTable
        Try
            Dim tsql As String = "SELECT primer_nombre, ISNULL(segundo_nombre, N' ') as segundo_nombre , 
                             primer_apellido, ISNULL(segundo_apellido, N' ') as segundo_apellido 
                             FROM USUARIO 
                             WHERE usuario_id = @usuario_id"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@usuario_id", usuario_id)
            da.Fill(dt)
        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener los nombre del usuario de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return dt

    End Function

    Public Function obtenerContraseña(ByVal usuario_id As Integer) As String
        Dim contraseña As String = " "
        Dim dt As New DataTable
        Try
            Dim tsql = "SELECT contraseña FROM Usuario WHERE usuario_id = @usuario_id"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@usuario_id", usuario_id)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim filaDos As DataRow = dt.Rows(0)
                contraseña = filaDos("contraseña").ToString()
                Return contraseña
            End If

        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener un dato del usuario de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return contraseña
    End Function

    Public Function validarLogin(ByVal nombre_usuario As String, ByVal contraseña As String) As Boolean
        Dim resp = False
        Dim dt As New DataTable
        Try
            Dim tsql As String = "SELECT nombre_usuario, contraseña
                                    FROM     Usuario
                                    WHERE nombre_usuario = @nombre_usuario AND contraseña = @contraseña"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombre_usuario", nombre_usuario)
            da.SelectCommand.Parameters.AddWithValue("@contraseña", contraseña)
            da.Fill(dt)
            If (dt.Rows.Count > 0) Then
                Return True
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error al validar el usuario y contraseña", MsgBoxStyle.Critical, "Error")
        End Try
        Return resp
    End Function

    Public Function EditarUsuario(ByVal usuario As Tbl_Usuarios) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "UPDATE Usuario set id_rol = @id_rol, 
                                                 primer_nombre = @primer_nombre, 
				                                 segundo_nombre = @segundo_nombre, 
				                                 primer_apellido = @primer_apellido, 
				                                 segundo_apellido = @segundo_apellido, 
				                                 nombre_usuario = @nombre_usuario, 
				                                 telefono = @telefono,
                                                 fecha_nac = @fecha_nac,
				                                 cedula = @cedula 
                                                 WHERE usuario_id = @usuario_id"
            Dim conn As New SqlConnection(strConn)
            conn.Open()
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@usuario_id", usuario.Usuario_id)
            cmd.Parameters.AddWithValue("@id_rol", usuario.Id_rol)
            cmd.Parameters.AddWithValue("@primer_nombre", usuario.Primer_nombre)
            cmd.Parameters.AddWithValue("@segundo_nombre", validarValorDBNull(usuario.Segundo_nombre))
            cmd.Parameters.AddWithValue("@primer_apellido", usuario.Primer_apellido)
            cmd.Parameters.AddWithValue("@segundo_apellido", validarValorDBNull(usuario.Segundo_apellido))
            cmd.Parameters.AddWithValue("@nombre_usuario", usuario.Nombre_usuario)
            cmd.Parameters.AddWithValue("@telefono", usuario.Telefono)
            cmd.Parameters.AddWithValue("@fecha_nac", usuario.Fecha_nac)
            cmd.Parameters.AddWithValue("@cedula", usuario.Cedula)

            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            conn.Close()
        Catch ex As Exception

        End Try
        Return resp
    End Function

    Public Function editarContraseña(ByVal usuario_id As Integer, ByVal contraseña As String) As Boolean
        Dim resp As Boolean = False
        Dim tsql As String = "UPDATE Usuario set contraseña = @contraseña  
                                                 WHERE usuario_id = @usuario_id"
        Dim conn As New SqlConnection(strConn)
        conn.Open()
        Dim cmd As New SqlCommand(tsql, conn)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@usuario_id", usuario_id)
        cmd.Parameters.AddWithValue("@contraseña", contraseña)
        If (cmd.ExecuteNonQuery <> 0) Then
            resp = True
        End If
        conn.Close()
        Return resp
    End Function
End Class
