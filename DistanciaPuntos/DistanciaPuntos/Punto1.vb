Public Class Punto1
    Inherits Punto

    Public Sub New(x As Double, y As Double)
        Me.X = x
        Me.Y = y
    End Sub

    Public Function DistanciaPunto2(x As Double, y As Double)
        Return Math.Sqrt(((Math.Pow(x - Me.X, 2)) + (Math.Pow(y - Me.Y, 2))))
    End Function
End Class
