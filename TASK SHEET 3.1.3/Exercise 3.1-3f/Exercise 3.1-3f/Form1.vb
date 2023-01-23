Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mark As Single

        mark = TextBox1.Text

        Select Case mark
            Case 0 To 49
                Label1.Text = "Need to work harder."
            Case 50 To 59
                Label1.Text = "Average"
            Case 60 To 69
                Label1.Text = "Above Average"
            Case 70 To 84
                Label1.Text = "Good"
            Case 85 To 100
                Label1.Text = "Excelence"
            Case Else
                Label1.Text = "Wrong entry. Please reenter mark."
        End Select
    End Sub
End Class
