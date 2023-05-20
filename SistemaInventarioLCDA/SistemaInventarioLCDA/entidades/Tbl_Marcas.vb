Public Class Tbl_Marcas
    Private _id_marca As Integer
    Private _nombreMarca As String
    Private _descripcionMarca As String
    Private _estado As Boolean

    Public Sub New()

    End Sub

    Public Sub New(id_marca As Integer, nombreMarca As String, descripcionMarca As String, estado As Boolean)
        _id_marca = id_marca
        _nombreMarca = nombreMarca
        _descripcionMarca = descripcionMarca
        _estado = estado
    End Sub

    Public Property Id_marca As Integer
        Get
            Return _id_marca
        End Get
        Set(value As Integer)
            _id_marca = value
        End Set
    End Property

    Public Property NombreMarca As String
        Get
            Return _nombreMarca
        End Get
        Set(value As String)
            _nombreMarca = value
        End Set
    End Property

    Public Property DescripcionMarca As String
        Get
            Return _descripcionMarca
        End Get
        Set(value As String)
            _descripcionMarca = value
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
