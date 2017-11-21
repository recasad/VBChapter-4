Public Class Form1

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Select Case CInt(txtDecimal.Text)
            Case 1
                lblNumerals.Text = "I"
            Case 2
                lblNumerals.Text = "II"
            Case 3
                lblNumerals.Text = "III"
            Case 4
                lblNumerals.Text = "IV"
            Case 5
                lblNumerals.Text = "V"
            Case 6
                lblNumerals.Text = "VI"
            Case 7
                lblNumerals.Text = "VII"
            Case 8
                lblNumerals.Text = "VIII"
            Case 9
                lblNumerals.Text = "IX"
            Case 10
                lblNumerals.Text = "X"
            Case Else
                lblNumerals.Text = "Please input a valid number"
        End Select
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class
