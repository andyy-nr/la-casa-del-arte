Public Class Tbl_Productos
    Private _id_producto As String
    Private _id_categoria As Integer
    Private _id_marca As Integer
    Private _nombreProd As String
    Private _precio_unitario As Decimal
    Private _descripcionProd As String
    Private _inventario_inicial As Integer
    Private _cantidad_disponible As Integer
    Private _estado As Boolean

    Public Sub New()

    End Sub

    Public Sub New(id_producto As String, id_categoria As Integer, id_marca As Integer, nombreProd As String, precio_unitario As Decimal, descripcionProd As String, inventario_inicial As Integer, cantidad_disponible As Integer, estado As Boolean)
        _id_producto = id_producto
        _id_categoria = id_categoria
        _id_marca = id_marca
        _nombreProd = nombreProd
        _precio_unitario = precio_unitario
        _descripcionProd = descripcionProd
        _inventario_inicial = inventario_inicial
        _cantidad_disponible = cantidad_disponible
        _estado = estado
    End Sub

    Public Property Id_producto As String
        Get
            Return _id_producto
        End Get
        Set(value As String)
            _id_producto = value
        End Set
    End Property

    Public Property Id_categoria As Integer
        Get
            Return _id_categoria
        End Get
        Set(value As Integer)
            _id_categoria = value
        End Set
    End Property

    Public Property Id_marca As Integer
        Get
            Return _id_marca
        End Get
        Set(value As Integer)
            _id_marca = value
        End Set
    End Property

    Public Property NombreProd As String
        Get
            Return _nombreProd
        End Get
        Set(value As String)
            _nombreProd = value
        End Set
    End Property

    Public Property Precio_unitario As Decimal
        Get
            Return _precio_unitario
        End Get
        Set(value As Decimal)
            _precio_unitario = value
        End Set
    End Property

    Public Property DescripcionProd As String
        Get
            Return _descripcionProd
        End Get
        Set(value As String)
            _descripcionProd = value
        End Set
    End Property

    Public Property Inventario_inicial As Integer
        Get
            Return _inventario_inicial
        End Get
        Set(value As Integer)
            _inventario_inicial = value
        End Set
    End Property

    Public Property Cantidad_disponible As Integer
        Get
            Return _cantidad_disponible
        End Get
        Set(value As Integer)
            _cantidad_disponible = value
        End Set
    End Property

    Public Property Estado As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
        End Set
    End Property
End Class
