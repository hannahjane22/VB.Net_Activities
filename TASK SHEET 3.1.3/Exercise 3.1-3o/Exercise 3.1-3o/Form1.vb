﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myWord As String

        myWord = TextBox1.Text
        Label1.Text = Microsoft.VisualBasic.Right(myWord, 4)

    End Sub
End Class
