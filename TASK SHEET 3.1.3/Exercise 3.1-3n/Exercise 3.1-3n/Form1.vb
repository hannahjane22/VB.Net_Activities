Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myPhrase As String

        myPhrase = Microsoft.VisualBasic.InputBox("Enter your phrase")
        Label1.Text = Mid(myPhrase, 2, 6)
    End Sub
End Class
