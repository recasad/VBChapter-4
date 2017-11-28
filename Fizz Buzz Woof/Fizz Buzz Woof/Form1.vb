Public Class Form1
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim intNumber As Integer = txtNumber.Text
        Dim intCount As Integer = 1

        Do Until intCount = (intNumber + 1)
            If intCount Mod 3 = 0 Then
                If intCount Mod 5 = 0 Then
                    If intCount Mod 7 = 0 Then
                        lstResults.Items.Add("Fizz Buzz Woof")
                    Else
                        lstResults.Items.Add("Fizz Buzz")
                    End If
                Else
                    lstResults.Items.Add("Fizz")
                End If
            ElseIf intCount Mod 7 = 0 Then
                If intCount Mod 5 = 0 Then
                    lstResults.Items.Add("Buzz Woof")
                ElseIf intCount Mod 3 = 0 Then
                    lstResults.Items.Add("Fizz Woof")
                Else
                    lstResults.Items.Add("Woof")
                End If
            ElseIf intCount Mod 5 = 0 Then
                lstResults.Items.Add("Buzz")
            Else
                lstResults.Items.Add(intCount)
            End If
            intCount += 1
        Loop

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstResults.Items.Clear()
        txtNumber.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
