Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rgb1, rgb2, rgb3 As Integer

        rgb1 = TextBox1.Text
        rgb2 = TextBox2.Text
        rgb3 = TextBox3.Text

        Me.BackColor = Color.FromArgb(rgb1, rgb2, rgb3)
    End Sub
End Class
