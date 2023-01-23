Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim text1, text2, text3, text4, text5, text6 As String

        text1 = "Welcome"
        text2 = " to"
        text3 = " Visual"
        text4 = " Basic"
        text5 = " 2022"

        text6 = text1 + text2 + text3 + text4 + text5
        Label1.Text = text6
    End Sub
End Class
