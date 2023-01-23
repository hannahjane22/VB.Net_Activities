Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mark As String
        Dim grade As String
        mark = TextBox1.Text

        If mark >= 80 Then
            grade = "A"
            Label1.Text = grade
        ElseIf mark >= 60 And mark < 80 Then
            grade = "B"
            Label1.Text = grade
        ElseIf mark >= 40 And mark < 60 Then
            grade = "C"
            Label1.Text = grade
        Else
            grade = "D"
            Label1.Text = grade
        End If

    End Sub
End Class
