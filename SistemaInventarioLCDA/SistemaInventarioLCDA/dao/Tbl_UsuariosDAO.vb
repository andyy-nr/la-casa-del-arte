Imports System.Data.SqlClient
Public Class Tbl_UsuariosDAO

    Dim strConn As String = My.Settings.StrConexion

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
    Public Function cargarUsuarioActual(ByVal usuario_id As Integer) As Usuario
        Dim user As New Usuario
        Dim dt As New DataTable
        Try
            Dim tsql As String = "SELECT Usuario.usuario_id, 
                                         Usuario.id_rol,
                                         Rol.nombreRol as N'ROL', 
                                         Usuario.primer_nombre + ' ' + primer_apellido As 'NOMBRE', nombre_usuario 
                                         FROM Usuario 
                                         INNER JOIN ROL 
                                         ON Usuario.id_rol = Rol.id_rol 
                                         WHERE usuario_id = @usuario_id"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("usuario_id", usuario_id)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim fila As DataRow = dt.Rows(0)
                user.UsuarioID = Integer.Parse(fila("usuario_id").ToString)
                user.IdRol = Integer.Parse(fila("id_rol").ToString())
                user.NombreRol = fila("ROL").ToString()
                user.NombreCompleto = fila("NOMBRE").ToString()
                user.NombreUsuario = fila("nombre_usuario").ToString
            End If

        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener los datos del usuario en el sistema de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return user
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
                                                 FROM Usuario INNER JOIN Rol On Usuario.id_rol = Rol.id_rol
												 WHERE Usuario.estado <> 0"
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
            cmd.Parameters.AddWithValue("@segundo_nombre", usuario.Segundo_nombre)
            cmd.Parameters.AddWithValue("@primer_apellido", usuario.Primer_apellido)
            cmd.Parameters.AddWithValue("@segundo_apellido", usuario.Segundo_apellido)
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
                                    WHERE nombre_usuario = @nombre_usuario AND contraseña = @contraseña And estado <> 0"
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
            cmd.Parameters.AddWithValue("@segundo_nombre", usuario.Segundo_nombre)
            cmd.Parameters.AddWithValue("@primer_apellido", usuario.Primer_apellido)
            cmd.Parameters.AddWithValue("@segundo_apellido", usuario.Segundo_apellido)
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

    Public Function obtenerNomUsuario(ByVal usuario_id As Integer) As String
        Dim nombre_usuario As String = " "
        Dim dt As New DataTable
        Try
            Dim tsql = "SELECT nombre_usuario FROM Usuario WHERE usuario_id = @usuario_id"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@usuario_id", usuario_id)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim filaDos As DataRow = dt.Rows(0)
                nombre_usuario = filaDos("nombre_usuario").ToString()
                Return nombre_usuario
            End If

        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener un dato del usuario de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return nombre_usuario
    End Function

    Public Function buscarUsuario(ByVal usuario_id) As Tbl_Usuarios
        Dim usuario As New Tbl_Usuarios
        Try
            Dim tsql As String = "SELECT * FROM Usuario WHERE usuario_id = @usuario_id"
            Dim conn As New SqlConnection(strConn)
            Dim tbl As New DataTable
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@usuario_id", usuario_id)
            da.Fill(tbl)

            If tbl.Rows.Count > 0 Then

                usuario.Usuario_id = tbl.Rows(0).Item("usuario_id")
                usuario.Id_rol = tbl.Rows(0).Item("id_rol")
                usuario.Primer_nombre = tbl.Rows(0).Item("primer_nombre")
                usuario.Segundo_nombre = tbl.Rows(0).Item("segundo_nombre")
                usuario.Primer_apellido = tbl.Rows(0).Item("primer_apellido")
                usuario.Segundo_apellido = tbl.Rows(0).Item("segundo_apellido")
                usuario.Nombre_usuario = tbl.Rows(0).Item("nombre_usuario")
                usuario.Telefono = tbl.Rows(0).Item("telefono")
                usuario.Fecha_nac = tbl.Rows(0).Item("fecha_nac")
                usuario.Cedula = tbl.Rows(0).Item("cedula")
                usuario.Contraseña = tbl.Rows(0).Item("contraseña")
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error al buscar el usuario" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return usuario
    End Function

    Public Function eliminarUsuario(ByVal usuario_id As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "UPDATE Usuario SET estado = 0 WHERE usuario_id = @usuario_id"
            Dim conn As New SqlConnection(strConn)
            conn.Open()
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@usuario_id", usuario_id)
            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar eliminar el usuario" & ex.Message, MsgBoxStyle.Critical, "Error")
            resp = False

        End Try
        Return resp
    End Function

    Public Function usuarioSistema(ByVal nombre_usuario As String) As Usuario
        Dim user As New Usuario
        Dim dt As New DataTable
        Try
            Dim tsql As String = "SELECT Usuario.usuario_id, Usuario.id_rol,Rol.nombreRol as N'ROL', Usuario.primer_nombre + ' ' + primer_apellido As 'NOMBRE', nombre_usuario FROM Usuario INNER JOIN ROL ON Usuario.id_rol = Rol.id_rol WHERE nombre_usuario = @nombre_usuario"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("nombre_usuario", nombre_usuario)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim fila As DataRow = dt.Rows(0)
                user.UsuarioID = Integer.Parse(fila("usuario_id").ToString())
                user.IdRol = Integer.Parse(fila("id_rol").ToString())
                user.NombreRol = fila("ROL").ToString()
                user.NombreCompleto = fila("NOMBRE").ToString()
                user.NombreUsuario = fila("nombre_usuario").ToString
            End If

        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener los datos del usuario en el sistema de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return user
    End Function

    Public Function usuarioNombreCompleto(ByVal nombre_completo As String) As DataSet
        Dim ds As New DataSet

        Try
            Dim espacio As String() = nombre_completo.Split(" "c)
            Dim primer_nombre As String = espacio(0)
            Dim segundo_nombre As String = espacio(1)
            Dim primer_apellido As String = espacio(2)
            Dim segundo_apellido As String = espacio(3)

            Dim tsql As String = "SELECT Usuario.usuario_id as N'CÓDIGO', Rol.nombreRol as N'ROL',
                                                 Usuario.primer_nombre + N' ' + ISNULL(Usuario.segundo_nombre, '') + N' ' + 
                                                 Usuario.primer_apellido  + N' ' + 
                                                 ISNULL(Usuario.segundo_apellido, '') as N'NOMBRE COMPLETO',
                                                 Usuario.nombre_usuario as N'NOMBRE DE USUARIO',
                                                 Usuario.telefono as N'TELÉFONO',
                                                 convert(nvarchar(10),Usuario.fecha_nac, 103) as N'FECHA DE NACIMIENTO',
                                                 Usuario.cedula as N'CÉDULA'
                                                 FROM Usuario INNER JOIN Rol On Usuario.id_rol = Rol.id_rol
                                                 WHERE Usuario.primer_nombre = @primer_nombre 
                                                 AND Usuario.segundo_nombre = @segundo_nombre 
                                                 And Usuario.primer_apellido = @primer_apellido And Usuario.segundo_apellido = @segundo_apellido"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@primer_nombre", primer_nombre)
            da.SelectCommand.Parameters.AddWithValue("@segundo_nombre", segundo_nombre)
            da.SelectCommand.Parameters.AddWithValue("@primer_apellido", primer_apellido)
            da.SelectCommand.Parameters.AddWithValue("@segundo_apellido", segundo_apellido)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener el registro de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds

    End Function

    Public Function usuarioPorRol(ByVal rol As String) As DataSet
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
                                                 FROM Usuario INNER JOIN Rol On Usuario.id_rol = Rol.id_rol
												 WHERE Rol.nombreRol = N'Vendedor'"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombreRol", rol)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener el registro de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds

    End Function

    Public Function usuarioNombre(ByVal nombre As String) As DataSet
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
                                         FROM Usuario INNER JOIN Rol On Usuario.id_rol = Rol.id_rol
                                         WHERE Usuario.primer_nombre = @nombre OR Usuario.segundo_nombre = @nombre
                                         OR Usuario.primer_apellido = @nombre OR Usuario.segundo_apellido = @nombre"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombre", nombre)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener el registro de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function

    Public Function usuarioApellido(ByVal apellido As String) As DataSet
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
                                     FROM Usuario INNER JOIN Rol On Usuario.id_rol = Rol.id_rol
                                     WHERE Usuario.primer_apellido = @apellido 
                                     OR Usuario.segundo_apellido = @apellido"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@apellido", apellido)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener el registro de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return ds
    End Function

    Public Function usuarioNombreUsuario(ByVal nombreUsuario As String) As DataSet
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
                                     FROM Usuario INNER JOIN Rol On Usuario.id_rol = Rol.id_rol
                                     WHERE Usuario.nombre_usuario = @nombreUsuario"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombreUsuario", nombreUsuario)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ocurrió un error al obtener el registro de la BD" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return ds
    End Function

End Class
