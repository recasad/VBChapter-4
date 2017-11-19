Public Class Form1
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
        ' Variables to hold input data.
        Dim strRelative As String
        Dim strSeasons As String
        Dim strHoliday As String
        Dim strFigure As String
        Dim strStory As String

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
        End If

        ' Create message box for story and link story.
        MessageBox.Show(("All ") & txtNameRepeated.Text & (" wanted for ") & strHoliday & (" was the ") & txtAdjectiveRepeated.Text(" ") & txtNounOneRepeated.Text("."))
    End Sub
End Class
