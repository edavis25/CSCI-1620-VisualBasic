' Eric A Davis
' Chapter 11 Lab A - Hands on Programming Example (pg. 458)
' CSCI 1620 - Visual Basic
' Autumn 2015

' DESCRIPTION:
' This is a remake of Lab 7A. The printing functions have been removed and instead this program
' will focus on Reading/Writing the selected flavors to an external file.



Imports System.IO     '<-- Imports the .NET I/O system for reading/writing to the file.


Public Class eadfrmmain

    ' *** GLOBAL DECLARATIONS ***

    Private IsDirtyBoolean As Boolean
    'Is Dirty meaning that the list has changed and not been saved.



    ' -----FORM LOAD CODE ----->
    Private Sub eadfrmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form Load code. This will Try/Catch to make sure a file for the program exists. If it does
        ' not exist then user will be asked to create a file. Load the data from the file into the CoffeeComboBox.

        ' *** DECLARATIONS ***
        Dim ResponseDialogResult As DialogResult
        Dim CoffeeFlavorString As String


        ' Try/Catch looking for file's existance. Tries to open the file.
        Try
            Dim FlavorsStreamReader As StreamReader = New StreamReader("Coffees.txt")

            ' Loop to read the file into the Coffee Combo Box list.
            Do Until FlavorsStreamReader.Peek = -1
                CoffeeFlavorString = FlavorsStreamReader.ReadLine()
                CoffeeComboBox.Items.Add(CoffeeFlavorString)
            Loop

            ' Close the file
            FlavorsStreamReader.Close()

        Catch ex As Exception
            ' Handles exception if the file does not exist. Ask user if they want to create one,
            ' if a file does not exist & user doesn't create one then close the program.
            ResponseDialogResult = MessageBox.Show("Create a new file?", "File Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If ResponseDialogResult = Windows.Forms.DialogResult.No Then
                Close()
            End If
        End Try
    End Sub



    ' ----- FORM CLOSING CODE ----->
    Private Sub eadfrmmain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' If the list has changed (IsDirty = True) then ask the user if they want to save the list when they
        ' try to close the program.

        ' *** DECLARATIONS ***
        Dim ResponseDialogResult As DialogResult
        Dim MessageString As String = "Coffee list has changed. Save the list?"


        ' If test to check if the list has changed.
        If IsDirtyBoolean Then
            ResponseDialogResult = MessageBox.Show(MessageString, "Coffee List Changed", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            'If test on the Yes/No user response. Calls the Save Flavor List menu item.
            If ResponseDialogResult = Windows.Forms.DialogResult.Yes Then
                SaveFlavorListToolStripMenuItem_Click(sender, e)
            End If
        End If
    End Sub



    ' ----- "SAVE FLAVOR LIST" MENU ITEM ----->
    Private Sub SaveFlavorListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveFlavorListToolStripMenuItem.Click
        ' "Save Flavor List" menu item click event. Opens file, saves list, then closes file.

        ' *** DECLARATIONS ***
        Dim NumberItemsInteger As Integer

        ' Open the File
        Dim FlavorsStreamWriter As StreamWriter = New StreamWriter("Coffees.txt", False)

        ' Save the items to the file
        NumberItemsInteger = CoffeeComboBox.Items.Count - 1

        ' Loop to Write the Items from the ComboBox into the file
        For IndexInteger As Integer = 0 To NumberItemsInteger
            FlavorsStreamWriter.WriteLine(CoffeeComboBox.Items(IndexInteger))
        Next IndexInteger

        ' Close the file
        FlavorsStreamWriter.Close()
        IsDirtyBoolean = False
    End Sub



    ' -----CODE FOR "EDIT" MENU ITEM ----->
    Private Sub AddCoffeeFlavorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCoffeeFlavorToolStripMenuItem.Click
        ' Action for the "Add Coffee Flavor" menu item. This item takes user entry in the drop down combo box 
        ' and adds the user entry to the list.

        With CoffeeComboBox

            ' Test to make sure user input is not blank.
            If .Text <> "" Then

                ' Check for Duplicate user entry into the Coffee Flavor dropdown box with a loop.
                Dim ItemFoundBoolean As Boolean
                Dim ItemIndexInteger As Integer

                Do Until (ItemFoundBoolean = True) Or (ItemIndexInteger = .Items.Count)
                    If .Text.ToUpper = .Items(ItemIndexInteger).ToString().ToUpper Then
                        ItemFoundBoolean = True
                        Exit Do
                    Else
                        ItemIndexInteger += 1
                    End If
                Loop

                ' IF test to handle a duplicate entry. ELSE if no duplicate is found, add item to list.
                If ItemFoundBoolean = True Then
                    MessageBox.Show("Duplicate Item.", "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    .Items.Add(.Text)   '<-- Long form = CoffeeComboBox.Items.Add(CoffeeComboBox.Text)
                    .Text = ""          '<-- Clears out the CoffeeComboBox
                    IsDirtyBoolean = True
                End If

            Else
                ' Else for the IF checking the CoffeeFlavor for blank entry.
                MessageBox.Show("Please enter a coffee flavor to add", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            ' Focus given back to CoffeeComboBox regardless.
            .Focus()

        End With
    End Sub

    Private Sub RemoveCoffeeFlavorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveCoffeeFlavorToolStripMenuItem.Click
        ' "Remove Coffee Flavor" event. This code will check to make sure the default -1 is not selected (meaning nothing selected) and display
        ' an error message if there is nothing selected (if the index is -1, nothing is selected). After checking the index it will remove
        ' whatever coffee flavor index has been selected.

        With CoffeeComboBox
            If .SelectedIndex <> -1 Then
                .Items.RemoveAt(.SelectedIndex)
                IsDirtyBoolean = True
            Else
                MessageBox.Show("Please select a coffee flavor to remove", "No Coffee Flavor Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                .Focus()
            End If
        End With
    End Sub

    Private Sub DisplayCoffeeCountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayCoffeeCountToolStripMenuItem.Click
        ' "Display Coffee Count" event. Create a variable to hold all the string message and then display a count of how many items 
        ' are currently in the Coffee Combo Box.

        Dim MessageString As String

        MessageString = "The number of coffee types is: " & CoffeeComboBox.Items.Count

        MessageBox.Show(MessageString, "R 'n R Coffee Type Count", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ClearCoffeeListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearCoffeeListToolStripMenuItem.Click
        ' "Clear Coffee List" event will clear all of the items inside of the Coffee Flavor ComboBox. Ask the user beforehand if they are
        ' sure they want to clear list and then store that result into a variable to check with an IF test.

        Dim ClearAllDialogResult As DialogResult

        ClearAllDialogResult = MessageBox.Show("Are you sure you want to clear all the flavors from the list?", "Clear Coffee List?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If ClearAllDialogResult = DialogResult.Yes Then
            CoffeeComboBox.Items.Clear()
            IsDirtyBoolean = True
        End If
    End Sub



    ' -----CODE FOR "HELP" MENU ITEM ----->
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' Displays the generic About Form with info from the assembly information.

        AboutBox1.ShowDialog()
    End Sub



    ' ----- CODE FOR "EXIT" MENU ITEM ----->
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' Exit menu item click event.
        Close()
    End Sub


End Class
