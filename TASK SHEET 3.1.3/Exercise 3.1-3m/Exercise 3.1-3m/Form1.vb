Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, sum As Integer

        ListBox1.Items.Add("n" & vbTab & "sum")
        ListBox1.Items.Add("---------------------")

        Do
            n += 1
            sum += 1
            ListBox1.Items.Add(n & vbTab & sum)

            If n = 100 Then
                Exit Do
            End If
        Loop
    End Sub
End Class
