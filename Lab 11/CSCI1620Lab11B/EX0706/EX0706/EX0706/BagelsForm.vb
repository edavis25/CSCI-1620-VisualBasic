'Project:     Exercise 7.6
'Programmer:  Theresa Berry
'Date:        August 2010
'Description: This project maintains a list of bagel types. 
'             The user can add to the list, remove items from the list, display the
'             number of items in the list, and clear the list. 
'             The user can also print the list of bagel types.
'             The user can not add duplicate items to the list.
'Folder:      EX0706
'Form:        BagelsForm

Option Strict On

Public Class BagelsForm

    Private Sub PrintBagelListToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintBagelListToolStripMenuItem1.Click
        'Print preview the bagel list

        PrintPreviewDialog1.Document = PrintBagelsPrintDocument
        PrintPreviewDialog1.ShowDialog()

        'Print the bagel list on the printer
        'printBagelsPrintDocument.Print()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Close the project

        Me.Close()
    End Sub

    Private Sub AddBagelTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBagelTypeToolStripMenuItem.Click
        'Add the bagel type to the list if is not already there.
        Dim ItemFoundBoolean As Boolean
        Dim ItemIndexInteger As Integer

        With BagelTypesComboBox
            'Test for blank input
            If .Text <> "" Then
                'Make sure item is not already in the list
                Do Until ItemFoundBoolean Or ItemIndexInteger = .Items.Count
                    If .Text.ToUpper = .Items(ItemIndexInteger).ToString.ToUpper() Then
                        ItemFoundBoolean = True
                        Exit Do
                    Else
                        ItemIndexInteger += 1
                    End If
                Loop
                If ItemFoundBoolean Then
                    MessageBox.Show("Duplicate item.", "Add failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    'If it's not in the list, add it.
                    .Items.Add(.Text)
                    .Text = ""
                End If
            Else
                MessageBox.Show("Please enter a new type of bagel", "Input Needed", _
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            .Focus()
        End With
    End Sub

    Private Sub RemoveBagelTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveBagelTypeToolStripMenuItem.Click
        'Remove the selected bagel type

        With BagelTypesComboBox
            If .SelectedIndex <> -1 Then
                .Items.RemoveAt(.SelectedIndex)
            Else
                MessageBox.Show("Select the Bagel type you would like to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End With
    End Sub

    Private Sub ClearBagelListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearBagelListToolStripMenuItem.Click
        'Clear the bagel list
        Dim ClearListDialogResult As DialogResult

        ClearListDialogResult = MessageBox.Show("Clear the bagel list?", "Clear List", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ClearListDialogResult = DialogResult.Yes Then
            BagelTypesComboBox.Items.Clear()
        End If
    End Sub

    Private Sub DisplayBagelTypeCountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayBagelTypeCountToolStripMenuItem.Click
        'Display the number of bagel types

        MessageBox.Show("There are " & BagelTypesComboBox.Items.Count & " bagels in the list.", "Bagel Count", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'Display the About box

        AboutBox1.ShowDialog()
    End Sub

    Private Sub printBagelsPrintDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintBagelsPrintDocument.PrintPage
        'Set up the printer output
        Dim PrintFont As New Font("Arial", 12)
        Dim IndexInteger As Integer
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim PrintLineString As String

        Using HeadingFont As New Font("Arial", 14)
            PrintLineString = "Bradley's Bagels"
            e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
            VerticalPrintLocationSingle += LineHeightSingle * 2
            PrintLineString = "Programmer: A. Programmer"
            e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
            VerticalPrintLocationSingle += LineHeightSingle * 2
            PrintLineString = "Bagel Types: "
            e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
            VerticalPrintLocationSingle += LineHeightSingle
        End Using

        Do Until IndexInteger = BagelTypesComboBox.Items.Count
            PrintLineString = BagelTypesComboBox.Items(IndexInteger).ToString()
            e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
            IndexInteger += 1
            VerticalPrintLocationSingle += LineHeightSingle
        Loop
    End Sub
End Class

