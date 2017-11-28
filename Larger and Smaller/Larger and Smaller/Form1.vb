Public Class Form1

    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
        ' Dim integer input as integer.
        Dim intA As Integer
        Dim intB As Integer

        ' Check if integers, and display greater/smaller/equal messages.
        If Integer.TryParse(txtIntegerA.Text, intA) Then
            If Integer.TryParse(txtIntegerB.Text, intB) Then
                If intA > intB Then
                    lblResult.Text = "Integer A is greatest."
                ElseIf intB > intA Then
                    lblResult.Text = "Integer B is greatest."
                ElseIf intA = intB Then
                    lblResult.Text = "Integers are equal."
                End If
            Else
                lblResult.Text = "Please input a numerical integer."
            End If
        Else
            lblResult.Text = "Please input a numerical integer."
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the textboxes and label.
        txtIntegerA.Clear()
        txtIntegerB.Clear()
        lblResult.Text = String.Empty
        txtIntegerA.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
