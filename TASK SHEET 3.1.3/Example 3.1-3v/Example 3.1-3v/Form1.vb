Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2 As Single

        num1 = TextBox1.Text
        num2 = Math.Round(num1, 2)

        Label1.Text = num2
    End Sub
End Class
