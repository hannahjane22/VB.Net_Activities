Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Text = Format(Now, "M")
        TextBox2.Text = Format(Now, "MM")
        TextBox3.Text = Format(Now, "MMM")
        TextBox4.Text = Format(Now, "MMMM")
        TextBox5.Text = Format(Now, "dd/MM/yy")
        TextBox6.Text = Format(Now, "MMM, d, yyyy")
        TextBox7.Text = Format(Now, "h:mm:ss tt")
        TextBox8.Text = Format(Now, "MM/dd/yyyy h:mm:ss tt")

    End Sub
End Class
