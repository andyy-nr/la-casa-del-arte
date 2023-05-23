Public Class Tbl_Roles

    Private _id_rol As Integer
    Private _nombreRol As String
    Private _descripcionRol As String
    Private _estadoPermiso As Boolean

    Public Sub New()

    End Sub
    Public Sub New(id_rol As Integer, nombreRol As String, descripcionRol As String, estadoPermiso As Boolean)
        _id_rol = id_rol
        _nombreRol = nombreRol
        _descripcionRol = descripcionRol
        _estadoPermiso = estadoPermiso
    End Sub

    Public Property Id_rol As Integer
        Get
            Return _id_rol
        End Get
        Set(value As Integer)
            _id_rol = value
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

    Public Property DescripcionRol As String
        Get
            Return _descripcionRol
        End Get
        Set(value As String)
            _descripcionRol = value
        End Set
    End Property

    Public Property EstadoPermiso As Boolean
        Get
            Return _estadoPermiso
        End Get
        Set(value As Boolean)
            _estadoPermiso = value
        End Set
    End Property
End Class
