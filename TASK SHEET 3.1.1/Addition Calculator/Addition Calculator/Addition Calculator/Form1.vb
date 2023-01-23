Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, product As Single

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        product = num1 + num2

        TextBox3.Text = product
    End Sub
End Class
