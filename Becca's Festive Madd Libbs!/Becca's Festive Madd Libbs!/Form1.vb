Public Class MadLibsForm
    Private Sub btnNameExamples_Click(sender As Object, e As EventArgs) Handles btnNameExamples.Click
        lblExamples.Text = "Ex. Sally, Chase, Renee, Ben, Chris, Luke, Santa, Tim, James"
    End Sub

    Private Sub btnNounExamples_Click(sender As Object, e As EventArgs) Handles btnNounExamples.Click
        lblExamples.Text = "Ex. car, bike, cat, cup, phone, sword, candy, door"
    End Sub

    Private Sub btnPluralNounExamples_Click(sender As Object, e As EventArgs) Handles btnPluralNounExamples.Click
        lblExamples.Text = "Ex. dogs, cans, books, jeans, eggs, folders, chairs, states"
    End Sub

    Private Sub btnAdjectiveExamples_Click(sender As Object, e As EventArgs) Handles btnAdjectiveExamples.Click
        lblExamples.Text = "Ex. fuzzy, red, ugly, uncomforitable, funny, slimey, raw, blue, smelly, cold, green"
    End Sub

    Private Sub btnAdverbExamples_Click(sender As Object, e As EventArgs) Handles btnAdverbExamples.Click
        lblExamples.Text = "Ex. quickly, sadly, happily, slowly, creatively, dangerously"
    End Sub

    Private Sub btnPastTenseVerbExamples_Click(sender As Object, e As EventArgs) Handles btnPastTenseVerbExamples.Click
        lblExamples.Text = "Ex. sat, ran, flew, ate, cried, drove, took, drank"
    End Sub

    Private Sub btnMakeMyStory_Click(sender As Object, e As EventArgs) Handles btnMakeMyStory.Click
        ' Create an instance of the StoryForm.
        Dim frmStory As New Story

        ' Variables to hold input data.
        Dim strRelative As String
        Dim strSeasons As String
        Dim strHoliday As String
        Dim strFigure As String

        ' Determine which Relative Radio Button is selected.
        If radMother.Checked = True Then
            strRelative = "mother"
        ElseIf radFather.Checked = True Then
            strRelative = "father"
        ElseIf radSister.Checked = True Then
            strRelative = "sister"
        ElseIf radBrother.Checked = True Then
            strRelative = "brother"
        ElseIf radAunt.Checked = True Then
            strRelative = "Aunt"
        ElseIf radUncle.Checked = True Then
            strRelative = "Uncle"
        Else
            MessageBox.Show("Please select a relative.")
        End If

        ' Determine which Season Radio Button is selected
        If radSpring.Checked = True Then
            strSeasons = "Spring"
        ElseIf radSummer.Checked = True Then
            strSeasons = "Summer"
        ElseIf radFall.Checked = True Then
            strSeasons = "Fall"
        ElseIf radWinter.Checked = True Then
            strSeasons = "Winter"
        Else
            MessageBox.Show("Please select a season.")
        End If

        'Determine which Holiday Radio Button is selected
        If radChristmas.Checked = True Then
            strHoliday = "Christmas"
            strFigure = "Santa"
        ElseIf radEaster.Checked = True Then
            strHoliday = "Easter"
            strFigure = "The Easter Bunny"
        ElseIf radHannukah.Checked = True Then
            strHoliday = "Hannukah"
            strFigure = "The Giant Talking Dreidle"
        ElseIf radNewYearsEve.Checked = True Then
            strHoliday = "New Years Eve"
            strFigure = "The Hope of a New Year"
        ElseIf radStPatricksDay.Checked = True Then
            strHoliday = "St. Patrick's Day"
            strFigure = "The Giant Golden Leprechaun"
        ElseIf radThanksgiving.Checked = True Then
            strHoliday = "Thanksgiving"
            strFigure = "The Great Turkey"
        Else
            MessageBox.Show("Please select a holiday.")
        End If

        ' Display Title and Story Information.
        frmStory.lblTitle.Text = txtNameRepeated.Text & "'s Holiday Adventure!!"
        frmStory.lblStory.Text = txtNameRepeated.Text &
            " wanted the " & txtAdjectiveRepeated.Text &
            " " & txtNounOneRepeated.Text & " for " &
            strHoliday & " since " & strSeasons & " " & txtYearA.Text &
            " when " & strRelative & " " & txtNameA.Text &
            " " & txtPastTenseVerbA.Text & " in with a " &
            txtNounOneRepeated.Text &
            ". After putting it on all of the " & txtNumberA.Text &
            " spots on their " & strHoliday & " list, " &
            txtNameRepeated.Text & " set out " & txtNumberB.Text &
            " " & txtPluralNounA.Text & " for " &
            strFigure & " and went to their " &
            txtAdjectiveA.Text & " bed to sleep. " &
            txtNumberC.Text & " hours later " &
            txtNameRepeated.Text & " awakes, " &
            txtAdverbA.Text & " running downstairs to see what lay under the family " &
            txtNounTwoRepeated.Text & ". Alas, " & txtNameRepeated.Text &
            "'s " & txtAdjectiveRepeated.Text & " " &
            txtNounOneRepeated.Text &
            " was nowhere to be found, and all that lay under the " &
            txtNounTwoRepeated.Text & " was a " &
            txtAdjectiveB.Text & " " & txtNounB.Text &
            ". As " & txtNameRepeated.Text & " " & txtPastTenseVerbB.Text &
            " and cried, out came their " & strRelative &
            " holding two " & txtAdjectiveRepeated.Text &
            " " & txtNounOneRepeated.Text & "s! " &
            txtNameRepeated.Text & " was overjoyed and " &
            strHoliday & " was saved."

        If txtAdjectiveA.Text = ("") Or txtAdjectiveB.Text = ("") Or txtAdjectiveRepeated.Text = ("") Or
            txtAdverbA.Text = ("") Or txtNameA.Text = ("") Or txtNameRepeated.Text = ("") Or
            txtNounB.Text = ("") Or txtNounOneRepeated.Text = ("") Or txtNounTwoRepeated.Text = ("") Or
            txtNumberA.Text = ("") Or txtNumberB.Text = ("") Or txtNumberC.Text = ("") Or txtPastTenseVerbA.Text = ("") Or
            txtPastTenseVerbB.Text = ("") Or txtPluralNounA.Text = ("") Or txtYearA.Text = ("") Then
            lblExamples.Text = "Please fill all boxes."
        Else
            frmStory.Show()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear textboxes and reset focus.
        txtAdjectiveA.Clear()
        txtAdjectiveB.Clear()
        txtAdjectiveRepeated.Clear()
        txtAdverbA.Clear()
        txtNameA.Clear()
        txtNameRepeated.Clear()
        txtNounB.Clear()
        txtNounOneRepeated.Clear()
        txtNounTwoRepeated.Clear()
        txtNumberA.Clear()
        txtNumberB.Clear()
        txtNumberC.Clear()
        txtPastTenseVerbA.Clear()
        txtPastTenseVerbB.Clear()
        txtPluralNounA.Clear()
        txtYearA.Clear()

        txtNameRepeated.Focus()

        ' Clear help label.
        lblExamples.Text = String.Empty

        ' Set Radio Buttons
        radSpring.Select()
        radMother.Select()
        radChristmas.Select()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form.
        Me.Close()
    End Sub
End Class
