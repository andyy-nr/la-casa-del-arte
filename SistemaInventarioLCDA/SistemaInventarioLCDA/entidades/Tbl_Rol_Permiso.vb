Public Class Tbl_Rol_Permiso

    Private _id_rol_permiso As Integer
    Private _id_permiso As Integer
    Private _id_rol As Integer

    Public Sub New()

    End Sub

    Public Sub New(id_rol_permiso As Integer, id_permiso As Integer, id_rol As Integer)
        _id_rol_permiso = id_rol_permiso
        _id_permiso = id_permiso
        _id_rol = id_rol
    End Sub

    Public Property Id_rol_permiso As Integer
        Get
            Return _id_rol_permiso
        End Get
        Set(value As Integer)
            _id_rol_permiso = value
        End Set
    End Property

    Public Property Id_permiso As Integer
        Get
            Return _id_permiso
        End Get
        Set(value As Integer)
            _id_permiso = value
        End Set
    End Property

    Public Property Id_rol As Integer
        Get
            Return _id_rol
        End Get
        Set(value As Integer)
            _id_rol = value
        End Set
    End Property
End Class
