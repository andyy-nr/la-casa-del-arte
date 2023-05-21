Public Class Tbl_Movimientos
    Private _id_movimiento As Integer
    Private _id_producto As String
    Private _usuario_id As Integer
    Private _tipo_movimiento As Boolean
    Private _fecha_movimiento As DateTime
    Private _cantidadProd As Integer
    Private _descripcionMov As String

    Public Sub New()

    End Sub

    Public Sub New(id_movimiento As Integer, id_producto As String, usuario_id As Integer, tipo_movimiento As Boolean, fecha_movimiento As Date, cantidadProd As Integer, descripcionMov As String)
        _id_movimiento = id_movimiento
        _id_producto = id_producto
        _usuario_id = usuario_id
        _tipo_movimiento = tipo_movimiento
        _fecha_movimiento = fecha_movimiento
        _cantidadProd = cantidadProd
        _descripcionMov = descripcionMov
    End Sub

    Public Property Id_movimiento As Integer
        Get
            Return _id_movimiento
        End Get
        Set(value As Integer)
            _id_movimiento = value
        End Set
    End Property

    Public Property Id_producto As String
        Get
            Return _id_producto
        End Get
        Set(value As String)
            _id_producto = value
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

    Public Property Tipo_movimiento As Boolean
        Get
            Return _tipo_movimiento
        End Get
        Set(value As Boolean)
            _tipo_movimiento = value
        End Set
    End Property

    Public Property Fecha_movimiento As Date
        Get
            Return _fecha_movimiento
        End Get
        Set(value As Date)
            _fecha_movimiento = value
        End Set
    End Property

    Public Property CantidadProd As Integer
        Get
            Return _cantidadProd
        End Get
        Set(value As Integer)
            _cantidadProd = value
        End Set
    End Property

    Public Property DescripcionMov As String
        Get
            Return _descripcionMov
        End Get
        Set(value As String)
            _descripcionMov = value
        End Set
    End Property
End Class
