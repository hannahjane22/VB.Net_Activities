Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim height, weight, bmi As Single

        height = TextBox1.Text
        weight = TextBox2.Text
        bmi = (weight) / (height ^ 2)

        TextBox3.Text = bmi
    End Sub
End Class
