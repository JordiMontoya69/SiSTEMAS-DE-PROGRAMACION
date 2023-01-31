Public Class Punto
    Private _x As Double
    Private _y As Double

    Protected Property X As Double
        Get
            Return _x
        End Get
        Set(value As Double)
            _x = value
        End Set
    End Property

    Protected Property Y As Double
        Get
            Return _y
        End Get
        Set(value As Double)
            _y = value
        End Set
    End Property
End Class
