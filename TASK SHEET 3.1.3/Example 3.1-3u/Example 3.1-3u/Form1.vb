Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer

        Randomize()

        num = Int(Rnd() * 6) + 1
        Label1.Text = num
    End Sub
End Class
