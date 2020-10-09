Public Class Entidad
    Private _boleta As Integer
    Private _remision As String
    Private _placa As String
    Private _subtotal As Double
    Private _descuento As Double
    Private _total As Double

    Public Property boleta As Integer
        Get
            Return _boleta
        End Get
        Set(value As Integer)
            _boleta = value
        End Set
    End Property
    Public Property remision As String
        Get
            Return _remision
        End Get
        Set(value As String)
            _remision = value
        End Set
    End Property
    Public Property placa As String
        Get
            Return _placa
        End Get
        Set(value As String)
            _placa = value
        End Set
    End Property
    Public Property subtotal As Double
        Get
            Return _subtotal
        End Get
        Set(value As Double)
            _subtotal = value
        End Set
    End Property
    Public Property descuento As Double
        Get
            Return _descuento
        End Get
        Set(value As Double)
            _descuento = value
        End Set
    End Property
    Public Property total As Double
        Get
            Return _total
        End Get
        Set(value As Double)
            _total = value
        End Set
    End Property
End Class
