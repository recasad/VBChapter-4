Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intTime1 As Integer
        Dim intTime2 As Integer
        Dim intTime3 As Integer

        If Integer.TryParse(txtTime1.Text, intTime1) &
            Integer.TryParse(txtTime2.Text, intTime2) Then
            If Integer.TryParse(txtTime3.Text, intTime3) Then
                If intTime1 < intTime2 & intTime1 < intTime3 Then
                    lblFirst.Text = txtName1.Text
                    If intTime2 < intTime3 Then
                        lblSecond.Text = txtName2.Text
                        lblThird.Text = txtName3.Text
                    ElseIf intTime3 < intTime2 Then
                        lblSecond.Text = txtName3.Text
                        lblThird.Text = txtName2.Text
                    End If
                End If
                If intTime2 < intTime1 & intTime2 < intTime3 Then
                    lblFirst.Text = txtName2.Text
                    If intTime1 < intTime3 Then
                        lblSecond.Text = txtName1.Text
                        lblThird.Text = txtName3.Text
                    ElseIf intTime3 < intTime1 Then
                        lblSecond.Text = txtName3.Text
                        lblSecond.Text = txtName1.Text
                    End If
                End If
                If intTime3 < intTime2 & intTime3 < intTime1 Then
                    lblFirst.Text = txtName3.Text
                    If intTime1 < intTime2 Then
                        lblSecond.Text = txtName1.Text
                        lblThird.Text = txtName2.Text
                    ElseIf intTime2 < intTime1 Then
                        lblSecond.Text = txtName2.Text
                        lblSecond.Text = txtName1.Text
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the TextBoxes.
        txtName1.Clear()
        txtName2.Clear()
        txtName3.Clear()
        txtTime1.Clear()
        txtTime2.Clear()
        txtTime3.Clear()
        lblFirst.Text = String.Empty
        lblSecond.Text = String.Empty
        lblThird.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
