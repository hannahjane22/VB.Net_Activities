Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim counter As Integer

        Do While counter <= 1000
            ListBox1.Items.Add(counter)
            counter += 1
        Loop
    End Sub
End Class
