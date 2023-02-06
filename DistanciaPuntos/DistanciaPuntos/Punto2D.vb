Public Class Punto2D
    Inherits Punto
    Protected _y As Decimal

    Public Property y() As Decimal
        Get
            Return _y
        End Get
        Set(value As Decimal)
            _y = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        _y = 0
    End Sub

    Public Sub New(x As Decimal, y As Decimal)
        MyBase.New(x)
        _y = y
    End Sub

    Public Overloads Function CalcularDistancia(a As Punto2D)
        Return Math.Sqrt(Math.Pow(_x - a.x, 2) + Math.Pow(_y - a.y, 2))
    End Function
End Class
