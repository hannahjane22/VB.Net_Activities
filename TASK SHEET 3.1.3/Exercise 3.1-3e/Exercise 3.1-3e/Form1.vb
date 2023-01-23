Public Class Examination_marks
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mark As Single

        mark = TextBox1.Text

        Select Case mark
            Case Is >= 85
                Label1.Text = "Excellence"
            Case Is >= 70
                Label1.Text = "Good"
            Case Is >= 60
                Label1.Text = "Above Average"
            Case Is >= 60
                Label1.Text = "Average"
            Case Else
                Label1.Text = "Need o work harder."
        End Select
    End Sub
End Class
