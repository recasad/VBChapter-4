Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim dblBLT As Double = 5.99
        Dim dblHam As Double = 4.99
        Dim dblTurkey As Double = 6.99
        Dim dblVeggie As Double = 7.5
        Dim dblChips As Double = 1.5
        Dim dblOnionRings As Double = 2.5
        Dim dblPickle As Double = 1
        Dim dblCookies As Double = 1.5
        Dim dblTomato As Double = 0.5
        Dim dblLettuce As Double = 0.25
        Dim dblMayo As Double = 0.5
        Dim dblBacon As Double = 1
        Dim Total As Double

        If radBLT.Checked = True Then
            lblOrder.Text = "You selected BLT"
            picSandwich.Visible = True
            Total = dblBLT + Total
        ElseIf radHam.Checked = True Then
            lblOrder.Text = "You selected Ham and American Cheese"
            picSandwich.Visible = True
            Total = dblHam + Total
        ElseIf radTurkey.Checked = True Then
            lblOrder.Text = "You selected Turkey and Cranberry"
            Total = dblTurkey + Total
            picSandwich.Visible = True
        ElseIf radVeggie.Checked = True Then
            lblOrder.Text = "You selected Veggie"
            picSandwich.Visible = True
            Total = dblVeggie + Total
        End If

        If chkTomato.Checked = True Then
            lblOrder.Text &= ", and Tomato"
            Total = dblTomato + Total
        End If
        If chkLettuce.Checked = True Then
            lblOrder.Text &= ", and Lettuce"
            Total = dblLettuce + Total
        End If
        If chkMayo.Checked = True Then
            lblOrder.Text &= ", and Mayo"
            Total = dblMayo + Total
        End If
        If chkBacon.Checked = True Then
            lblOrder.Text &= ", and Bacon"
            Total = dblBacon + Total
        End If

        If radChips.Checked = True Then
            lblOrder.Text &= ", and Chips."
            picChips.Visible = True
            picOnionRing.Visible = False
            picCookie.Visible = False
            picPickles.Visible = False
            Total = dblChips + Total
        ElseIf radOnionRings.Checked = True Then
            lblOrder.Text &= ", and Onion Rings."
            picOnionRing.Visible = True
            picCookie.Visible = False
            picPickles.Visible = False
            picChips.Visible = False
            Total = dblOnionRings + Total
        ElseIf radPickle.Checked = True Then
            lblOrder.Text &= ", and a Pickle."
            picPickles.Visible = True
            picChips.Visible = False
            picCookie.Visible = False
            picOnionRing.Visible = False
            Total = dblPickle + Total
        ElseIf radCookies.Checked = True Then
            lblOrder.Text &= ", and Cookies."
            picCookie.Visible = True
            picChips.Visible = False
            picPickles.Visible = False
            picOnionRing.Visible = False
            Total = dblCookies + Total
        End If
        lblTotal.Text = Total.ToString("c")
    End Sub
End Class
