Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim P1 As New Punto1(tbX1.Text, tbY1.Text)

        tbResultado.Text = P1.DistanciaPunto2(tbX2.Text, tbY2.Text)
    End Sub
End Class
