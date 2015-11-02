' Eric A Davis
' Lab 7B - Exercise 7.2 (Pg. 320)
' CSCI-1620 Autumn 2015


Public Class eadfrmmain

    ' Variable to hold type of book. Fiction / NonFiction
    Private BookTypeString As String

    Private Sub PrintSubjectsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintSubjectsToolStripMenuItem.Click
        ' "Print Subjects" click event. This will show a print preview of all of the subjects when
        ' the user selects "Print Subjects" from the file menu.

        PrintPreviewDialog1.Document = PrintAllSubjectsPrintDocument
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintAllSubjectsPrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintAllSubjectsPrintDocument.PrintPage
        ' Setup the "Print Subjects" printdocument. This is the print document that is used with the 
        ' "Print Subjects" click event in the  File menu strip.

        Dim PrintFont As New Font("Arial", 12)
        Dim HeadingFont As New Font("Arial", 14, FontStyle.Bold Or FontStyle.Underline)  '<--- "Or" combines those 2 styles for some reason
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim PrintLineString As String

        ' Header
        PrintLineString = "Programmed By: Eric A Davis"
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle * 2  '<---Skips a line
        PrintLineString = "Book Subjects"
        e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += 2   '<---Move line 2 pixels

        ' Body
        For ListIndexInteger As Integer = 0 To SubjectComboBox.Items.Count - 1
            VerticalPrintLocationSingle += LineHeightSingle   '<---Move line down one for each item
            PrintLineString = SubjectComboBox.Items(ListIndexInteger).ToString()
            e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        Next ListIndexInteger

    End Sub

    Private Sub FictionRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FictionRadioButton.CheckedChanged
        ' "Fiction" RadioButton checked event. If checked, then set book type to fiction.

        If FictionRadioButton.Checked = True Then
            BookTypeString = "Fiction"
        End If
    End Sub

    Private Sub NonFictionRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles NonFictionRadioButton.CheckedChanged
        ' "NonFiction" RadioButton checked event. If checked, set the book type to nonfiction.

        If NonFictionRadioButton.Checked = True Then
            BookTypeString = "Nonfiction"
        End If
    End Sub

    Private Sub PrintSelectedPrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintSelectedPrintDocument.PrintPage
        ' Setup the "Print Selected" printdocument. This is the print document that is used with the 
        ' "Print" button click event on the main form of the menu.

        Dim PrintFont As New Font("Arial", 12)
        Dim HeadingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim PrintLineString As String

        ' Header
        PrintLineString = "Summer Reading"
        e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle * 2

        PrintLineString = "Programmed By: Eric A Davis"
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle * 2

        ' Body
        PrintLineString = "Author: " & AuthorTextBox.Text
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle

        PrintLineString = "Title: " & TitleTextBox.Text
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle

        PrintLineString = "Book Type: " & BookTypeString
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle

        PrintLineString = "Subject: " & SubjectComboBox.SelectedItem
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle

        PrintLineString = "Shelf Number: " & ShelfNumberListBox.SelectedItem
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle

    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        ' "Print" button click event. When user clicks the "Print" button on the main form, assign the Print Selected Print Document
        ' to the print preview dialog and display. Uses a bunch of nested IF tests to make sure the user has input all the data. 
        ' If something is missing, display error message for whatever it is and focus on the problem.

        If AuthorTextBox.Text <> "" Then

            If TitleTextBox.Text <> "" Then

                If FictionRadioButton.Checked Or NonFictionRadioButton.Checked Then

                    If SubjectComboBox.SelectedIndex <> -1 Then

                        If ShelfNumberListBox.SelectedIndex <> -1 Then

                            ' Finally set the print preview dialog with all given information.
                            PrintPreviewDialog1.Document = PrintSelectedPrintDocument
                            PrintPreviewDialog1.ShowDialog()

                        Else
                            MessageBox.Show("Please select a shelf number", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            ShelfNumberListBox.Focus()
                        End If

                    Else
                        MessageBox.Show("Please select a subject", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        SubjectComboBox.Focus()
                    End If

                Else
                    MessageBox.Show("Please select fiction or nonfiction", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    BookTypeGroupBox.Focus()
                End If

            Else
                MessageBox.Show("Please enter a book title", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TitleTextBox.Focus()
            End If

        Else
            MessageBox.Show("Please enter a name for author", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            AuthorTextBox.Focus()
        End If

    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        ' "OK" button click even clears the inputs and then resets focus to the top. Should be the forms default accept.

        ShelfNumberListBox.SelectedIndex = -1
        SubjectComboBox.SelectedIndex = -1
        FictionRadioButton.Checked = False
        NonFictionRadioButton.Checked = False
        TitleTextBox.Clear()
        AuthorTextBox.Clear()
        AuthorTextBox.Focus()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' Show the about form
        AboutBox1.ShowDialog()
    End Sub
End Class
