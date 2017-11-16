Public Class Form1

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim intStartIndex As Integer
        Dim intFoundIndex As Integer

        If IsNumeric(txtStartIndex.Text) Then
            If txtToFind.Text.Length > 0 Then
                intStartIndex = CInt(txtStartIndex.Text)
                intFoundIndex = lblString.Text.IndexOf(txtToFind.Text, intStartIndex)
            End If
            If intFoundIndex = -1 Then
                lblResults.Text = "The string was not found fool."
            Else
                lblResults.Text = "The string was found at index " & intFoundIndex
            End If
        Else
            MessageBox.Show("Enter a string to search for.")
        End If
    End Sub
End Class
