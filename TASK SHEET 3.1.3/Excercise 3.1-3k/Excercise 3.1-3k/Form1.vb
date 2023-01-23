Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer

        For n = 1 To 10
            If n > 6 Then
                Exit For
            End If
            If n <= 6 Then
                ListBox1.Items.Add(n)
            End If
        Next

    End Sub
End Class
