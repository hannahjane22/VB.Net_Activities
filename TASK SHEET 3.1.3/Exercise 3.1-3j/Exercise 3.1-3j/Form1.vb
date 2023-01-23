Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim counter, sum As Integer

        For counter = 100 To 1 Step -5
            sum -= counter
            ListBox1.Items.Add(counter)
        Next
    End Sub
End Class
