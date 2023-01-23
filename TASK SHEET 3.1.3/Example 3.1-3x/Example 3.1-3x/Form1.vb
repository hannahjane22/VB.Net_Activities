Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Text = Format(8972.234, "0.0")
        TextBox2.Text = Format(8972.2345, "0.00")
        TextBox3.Text = Format(6648972.265, "#,##0.00")
        TextBox4.Text = Format(6648972.265, "$#,##0.00")
        TextBox5.Text = Format(0.56324, "0%")

    End Sub
End Class
