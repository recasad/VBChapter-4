Public Class Form1

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If txtPassword.Text = "donenumber9" Then
            MessageBox.Show("Hello World!")
        Else
            MessageBox.Show("Incorrect Password. Please Try Again.")
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
