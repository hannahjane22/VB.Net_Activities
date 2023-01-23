Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myNumber, myAge As String

        myNumber = TextBox2.Text
        myAge = TextBox1.Text

        If myNumber > 100 And myAge > 60 Then
            Label1.Text = "Congratulation! You win a lucky prize."
        Else
            Label1.Text = "Sorry! You did not win any prize."
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
