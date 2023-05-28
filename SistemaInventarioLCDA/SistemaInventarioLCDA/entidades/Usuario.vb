Public Class Usuario
    Private _usuarioID As Integer
    Private _idRol As Integer
    Private _nombreRol As String
    Private _nombreCompleto As String
    Private _nombreUsuario As String
    Private _listaPermisos As List(Of Integer)

    Public Sub New()

    End Sub

    Public Sub New(usuarioID As Integer, idRol As Integer, nombreRol As String, nombreCompleto As String, nombreUsuario As String, listaPermisos As List(Of Integer))
        _usuarioID = usuarioID
        _idRol = idRol
        _nombreRol = nombreRol
        _nombreCompleto = nombreCompleto
        _nombreUsuario = nombreUsuario
        _listaPermisos = listaPermisos
    End Sub

    Public Property UsuarioID As Integer
        Get
            Return _usuarioID
        End Get
        Set(value As Integer)
            _usuarioID = value
        End Set
    End Property

    Public Property IdRol As Integer
        Get
            Return _idRol
        End Get
        Set(value As Integer)
            _idRol = value
        End Set
    End Property

    Public Property NombreRol As String
        Get
            Return _nombreRol
        End Get
        Set(value As String)
            _nombreRol = value
        End Set
    End Property

    Public Property NombreCompleto As String
        Get
            Return _nombreCompleto
        End Get
        Set(value As String)
            _nombreCompleto = value
        End Set
    End Property

    Public Property NombreUsuario As String
        Get
            Return _nombreUsuario
        End Get
        Set(value As String)
            _nombreUsuario = value
        End Set
    End Property

    Public Property ListaPermisos As List(Of Integer)
        Get
            Return _listaPermisos
        End Get
        Set(value As List(Of Integer))
            _listaPermisos = value
        End Set
    End Property
End Class
