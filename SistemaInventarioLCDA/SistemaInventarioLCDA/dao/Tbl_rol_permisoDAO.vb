﻿Imports System.Data.SqlClient


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

        End Try
        Return resp
    End Function

    Public Function obtenerPermiso(ByVal id_rol As Integer) As DataTable
        Dim dt As New DataTable
        Dim tsql As String = "Select Permiso.permiso from RolPermiso INNER JOIN Permiso On Permiso.id_permiso = RolPermiso.id_permiso where id_rol = @id_rol"
        Dim conn As New SqlConnection(strConn)
        Dim da As New SqlDataAdapter(tsql, conn)
        da.SelectCommand.Parameters.AddWithValue("@id_rol", id_rol)
        da.Fill(dt)

        Return dt
    End Function



End Class
