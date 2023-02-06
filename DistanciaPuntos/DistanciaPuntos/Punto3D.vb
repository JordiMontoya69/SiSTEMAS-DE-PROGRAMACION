Public Class Punto3D
    Inherits Punto2D

    Protected _z As Decimal

    Public Property z() As Decimal
        Get
            Return _z
        End Get
        Set(value As Decimal)
            _z = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        _z = 0
    End Sub

    Public Sub New(x As Decimal, y As Decimal, z As Decimal)
        MyBase.New(x, y)
        _z = z
    End Sub

    Public Overloads Function CalcularDistancia(a As Punto3D)
        Return Math.Sqrt(Math.Pow(_x - a.x, 2) + Math.Pow(_y - a.y, 2) + Math.Pow(_z - a.z, 2))
    End Function
End Class
