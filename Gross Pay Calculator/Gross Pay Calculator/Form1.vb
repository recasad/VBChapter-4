Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Declare variables
        Dim intHours As Integer   'Hours worked
        Dim decPayRate As Decimal  ' Hourly Pay Rate
        Dim decGrossPay As Decimal  ' Gross Pay

        ' Clear any previously displayed message.
        lblStatus.Text = String.Empty

        ' Get the Hours worked.
        If Integer.TryParse(txtHours.Text, intHours) Then
            ' Get the hourly pay rate.
            If Decimal.TryParse(txtPayRate.Text, decPayRate) Then
                'Calculate the gross pay.
                decGrossPay = intHours * decPayRate

                'Display the gross pay.
                lblGrossPay.Text = decGrossPay.ToString("C")
            Else
                ' Display pay rate error message.
                lblStatus.Text = "Enter a valid value for hourly pay rate."
            End If
        Else
            ' Display hours worked error message.
            lblStatus.Text = "Enter a valid integer for hours worked."
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Clear the TextBoxes and Labels
        txtHours.Clear()
        txtPayRate.Clear()
        lblGrossPay.Text = String.Empty
        lblStatus.Text = String.Empty

        ' Set focus to txtHours
        txtHours.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
