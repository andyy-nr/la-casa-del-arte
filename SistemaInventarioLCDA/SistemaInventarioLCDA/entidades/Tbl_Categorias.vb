Public Class Tbl_Categorias
    Private _id_categoria As Integer
    Private _nombreCatg As String
    Private _descripcionCatg As String
    Private _estado As Boolean

    Public Sub New()

    End Sub

    Public Sub New(id_categoria As Integer, nombreCatg As String, descripcionCatg As String, estado As Boolean)
        _id_categoria = id_categoria
        _nombreCatg = nombreCatg
        _descripcionCatg = descripcionCatg
        _estado = estado
    End Sub

    Public Property Id_categoria As Integer
        Get
            Return _id_categoria
        End Get
        Set(value As Integer)
            _id_categoria = value
        End Set
    End Property

    Public Property NombreCatg As String
        Get
            Return _nombreCatg
        End Get
        Set(value As String)
            _nombreCatg = value
        End Set
    End Property

    Public Property DescripcionCatg As String
        Get
            Return _descripcionCatg
        End Get
        Set(value As String)
            _descripcionCatg = value
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
