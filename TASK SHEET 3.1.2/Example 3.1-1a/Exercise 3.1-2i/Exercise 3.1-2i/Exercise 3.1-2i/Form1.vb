Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim text1 As String

        text1 = TextBox1.Text
        TextBox2.Text = Microsoft.VisualBasic.Left(text1, 4)
    End Sub
End Class
