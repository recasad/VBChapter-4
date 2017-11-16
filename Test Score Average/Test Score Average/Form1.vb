Public Class Form1

    Private Sub btnCalculateAverage_Click(sender As Object, e As EventArgs) Handles btnCalculateAverage.Click
        ' Variables to hold scores and the average score.
        Dim dblScore1 As Double
        Dim dblScore2 As Double
        Dim dblScore3 As Double
        Dim dblAverage As Double

        ' Constants
        Const NUM_SCORES As Integer = 3
        Const dblHigh_SCORE As Double = 95.0

        Try
            ' Copy the TextBox scores into the variables.
            dblScore1 = CDbl(txtScore1.Text)
            dblScore2 = CDbl(txtScore2.Text)
            dblScore3 = CDbl(txtScore3.Text)

            ' Calculate the average score.
            dblAverage = (dblScore1 + dblScore2 + dblScore3) / NUM_SCORES

            ' Display the average, rounded to 2 decimal places.
            lblAverage.Text = dblAverage.ToString("n2")

            'Display the letter grade
            If dblAverage < 60 Then
                lblGrade.Text = "F"
            ElseIf dblAverage < 70 Then
                lblGrade.Text = "D"
            ElseIf dblAverage < 80 Then
                lblGrade.Text = "C"
            ElseIf dblAverage < 90 Then
                lblGrade.Text = "B"
            ElseIf dblAverage < 100 Then
                lblGrade.Text = "A"
            End If

            ' If the score is high, compliment the student.
            If dblAverage > dblHigh_SCORE Then
                lblEncouragement.Text = "Congratulations! Great Job!"
            Else
                lblEncouragement.Text = "Keep Trying!"
            End If

        Catch ex As Exception
            lblEncouragement.Text = "Scores Must be numeric"
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear TextBoxes and Labels
        txtScore1.Clear()
        txtScore2.Clear()
        txtScore3.Clear()
        lblAverage.Text = String.Empty
        lblEncouragement.Text = String.Empty
        lblGrade.Text = String.Empty

        ' Reset FOcus
        txtScore1.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form
        Me.Close()
    End Sub
End Class
