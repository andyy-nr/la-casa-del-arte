Public Class Tbl_Usuarios
    Private _usuario_id As Integer
    Private _id_rol As Integer
    Private _primer_nombre As String
    Private _segundo_nombre As String
    Private _primer_apellido As String
    Private _segundo_apellido As String
    Private _nombre_usuario As String
    Private _telefono As String
    Private _fecha_nac As DateTime
    Private _cedula As String
    Private _contraseña As String

    Public Sub New()

    End Sub

    Public Sub New(usuario_id As Integer, id_rol As Integer, primer_nombre As String, segundo_nombre As String, primer_apellido As String, segundo_apellido As String, nombre_usuario As String, telefono As String, fecha_nac As Date, cedula As String, contraseña As String)
        _usuario_id = usuario_id
        _id_rol = id_rol
        _primer_nombre = primer_nombre
        _segundo_nombre = segundo_nombre
        _primer_apellido = primer_apellido
        _segundo_apellido = segundo_apellido
        _nombre_usuario = nombre_usuario
        _telefono = telefono
        _fecha_nac = fecha_nac
        _cedula = cedula
        _contraseña = contraseña
    End Sub

    Public Property Id_rol As Integer
        Get
            Return _id_rol
        End Get
        Set(value As Integer)
            _id_rol = value
        End Set
    End Property

    Public Property Primer_nombre As String
        Get
            Return _primer_nombre
        End Get
        Set(value As String)
            _primer_nombre = value
        End Set
    End Property

    Public Property Segundo_nombre As String
        Get
            Return _segundo_nombre
        End Get
        Set(value As String)
            _segundo_nombre = value
        End Set
    End Property

    Public Property Primer_apellido As String
        Get
            Return _primer_apellido
        End Get
        Set(value As String)
            _primer_apellido = value
        End Set
    End Property

    Public Property Segundo_apellido As String
        Get
            Return _segundo_apellido
        End Get
        Set(value As String)
            _segundo_apellido = value
        End Set
    End Property

    Public Property Nombre_usuario As String
        Get
            Return _nombre_usuario
        End Get
        Set(value As String)
            _nombre_usuario = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public Property Fecha_nac As Date
        Get
            Return _fecha_nac
        End Get
        Set(value As Date)
            _fecha_nac = value
        End Set
    End Property

    Public Property Cedula As String
        Get
            Return _cedula
        End Get
        Set(value As String)
            _cedula = value
        End Set
    End Property

    Public Property Contraseña As String
        Get
            Return _contraseña
        End Get
        Set(value As String)
            _contraseña = value
        End Set
    End Property

    Public Property Usuario_id As Integer
        Get
            Return _usuario_id
        End Get
        Set(value As Integer)
            _usuario_id = value
        End Set
    End Property
End Class
