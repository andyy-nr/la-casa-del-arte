Public Class Tbl_Permiso
    Private _id_permiso As Integer
    Private _permiso As String
    Private _descripcionPermiso As String
    Private _estadoPermiso As Boolean

    Public Sub New()


    End Sub

    Public Sub New(id_permiso As Integer, permiso As String, descripcionPermiso As String, estadoPermiso As Boolean)
        _id_permiso = id_permiso
        _permiso = permiso
        _descripcionPermiso = descripcionPermiso
        _estadoPermiso = estadoPermiso
    End Sub

    Public Property Id_permiso As Integer
        Get
            Return _id_permiso
        End Get
        Set(value As Integer)
            _id_permiso = value
        End Set
    End Property

    Public Property Permiso As String
        Get
            Return _permiso
        End Get
        Set(value As String)
            _permiso = value
        End Set
    End Property

    Public Property DescripcionPermiso As String
        Get
            Return _descripcionPermiso
        End Get
        Set(value As String)
            _descripcionPermiso = value
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
