Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim grade As String

        grade = TextBox1.Text

        Select Case grade
            Case "A"
                Label1.Text = "High Distinction"
            Case "B"
                Label1.Text = "Distinction"
            Case "C"
                Label1.Text = "Credit"
            Case "D"
                Label1.Text = "Pass"
            Case "D"
                Label1.Text = "Fail"
        End Select
    End Sub
End Class
