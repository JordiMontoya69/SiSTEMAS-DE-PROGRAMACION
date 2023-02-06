Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim P1 As New Punto3D(tbX1.Text, tbY1.Text, tbZ1.Text)

        tbResultado.Text = P1.CalcularDistancia(New Punto3D(tbX2.Text, tbY2.Text, tbZ2.Text))
    End Sub

End Class
