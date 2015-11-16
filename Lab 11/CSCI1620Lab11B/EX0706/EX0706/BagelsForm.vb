' Eric A Davis
' Lab 11B - Exercise 11.3 (pg. 465)
' CSCI 1620 - Visual Basic
' Autumn 2015   



' DESCRIPTION:
' This project Reads/Writes data from a text file to and from a combo box. The design
' and most of the code is a direct copy of the given base project.

Option Strict On

Imports System.IO

Public Class BagelsForm

    ' *** GLOBAL LEVEL DECLARATIONS ***
    Private HasChangedBoolean As Boolean


    Private Sub BagelsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load event for the main form. Try/Catch to make sure a file exists for the program to
        ' Read/Write from. If doesn't exist, ask user to create. Loads data into the combo box.

        ' ***DECLARATIONS***
        Dim ResponseDialogResult As DialogResult
        Dim BagelTypeString As String


        ' Try/Catch to open the file.
        Try
            ' Open the file.
            Dim BagelStreamReader As StreamReader = New StreamReader("Bagels.txt")

            ' Loop to read the data and insert into combo box.
            Do Until BagelStreamReader.Peek = -1

                BagelTypeString = BagelStreamReader.ReadLine
                BagelTypesComboBox.Items.Add(BagelTypeString)

            Loop

            ' Close the file.
            BagelStreamReader.Close()

        Catch ex As Exception
            ' Handles exception for missing text file. Asks the user if they would like to create
            ' a new file. If not, then close the program.

            ResponseDialogResult = MessageBox.Show("Create a new file?", "File Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' If user selects no, exit program.
            If ResponseDialogResult = Windows.Forms.DialogResult.No Then
                Close()
            End If

        End Try

    End Sub


    Private Sub SaveBagelListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveBagelListToolStripMenuItem.Click
        ' "Save Bagel List" click event. This will save the data input into the combo box to the text file. 
        ' Open file -> Write items to file -> Close the file.

        ' *** DECLARATIONS ***
        Dim NumberItemsInteger As Integer

        ' Open the file
        Dim BagelStreamWriter As New StreamWriter("Bagels.txt", False)

        ' Use a loop to write the items to the file
        NumberItemsInteger = BagelTypesComboBox.Items.Count - 1

        For IndexInteger = 0 To NumberItemsInteger
            BagelStreamWriter.WriteLine(BagelTypesComboBox.Items(IndexInteger))
        Next IndexInteger

        ' Close the file
        BagelStreamWriter.Close()
        HasChangedBoolean = False
    End Sub


    Private Sub BagelsForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Form closing event. If the list has changed (HasChangedBoolean = True) then ask the user if they would
        ' like to save when they exit the program. If data needs saved, call the SaveListItems menu item click event.

        ' *** DECLARATIONS ***
        Dim ResponseDialogResult As DialogResult
        Dim MessageString As String = "Bagel list has changed. Would you like to save the list?"


        ' If test checking to see if list has changed
        If HasChangedBoolean = True Then
            ResponseDialogResult = MessageBox.Show(MessageString, "List Has Changed", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' If the user wants to save the file (chose "Yes")
            If ResponseDialogResult = Windows.Forms.DialogResult.Yes Then
                SaveBagelListToolStripMenuItem_Click(sender, e)
            End If
        End If


    End Sub



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
                    HasChangedBoolean = True
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
                HasChangedBoolean = True
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
            HasChangedBoolean = True
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

