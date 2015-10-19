Public Class eadfrmmain

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
        End If
    End Sub



    ' -----CODE FOR "HELP" MENU ITEM ----->
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' Displays the generic About Form with info from the assembly information.

        AboutBox1.ShowDialog()
    End Sub



    ' -----CODE FOR PRINT SELECTED ITEMS ----->
    Private Sub PreviewSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreviewSelectedToolStripMenuItem.Click
        ' "Print Selected Flavors Preview" event. When the user clicks the preview, assign the correct print document to PrintPreviewDialog1
        ' and then simply show the dialog. IF test both user inputs to make sure there is data selected.

        ' Check syrup listbox. If nothing selected (-1) automatically select "(None)" option with index = 0
        If SyrupListBox.SelectedIndex = -1 Then
            SyrupListBox.SelectedIndex = 0
        End If

        ' Check Coffee Flavor combobox. If something is selected (NOT equals -1) then print PREVIEW. ELSE show error message.
        If CoffeeComboBox.SelectedIndex <> -1 Then
            PrintPreviewDialog1.Document = PrintSelectedPrintDocument
            PrintPreviewDialog1.ShowDialog()
        Else
            MessageBox.Show("Please select a coffee flavor.", "No Coffee Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub PrintSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintSelectedToolStripMenuItem.Click
        ' "Print Selected" event. Controls the print directly click. IF test both users inputs to make sure data is selected.

        ' Check syrup listbox. If nothing selected (-1) automatically select "(None)" option with index = 0
        If SyrupListBox.SelectedIndex = -1 Then
            SyrupListBox.SelectedIndex = 0
        End If

        ' Check Coffee Flavor combobox. IF something is selected (NOT EQUALS -1) then PRINT. ELSE show error message.
        If CoffeeComboBox.SelectedIndex <> -1 Then
            PrintSelectedPrintDocument.Print()
        Else
            MessageBox.Show("Please select a coffee flavor.", "No Coffee Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub PrintSelectedPrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintSelectedPrintDocument.PrintPage
        ' Sets up the "Print Selected" print document for use in both print and print preview. This code formats the page for the printer.

        ' Variables to set font, set location, and create line spacing.
        Dim PrintFont As New Font("Arial", 12)
        Dim HeadingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2    '<---Use this variable to increment Y coordinate for each new line. Gets height & adds 2 pixels.
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim PrintLineString As String        '<--- Assign what needs printed to this variable.

        ' EX: e.Graphics.DrawString(*DATA TO DISPLAY*, *FONT*, *COLOR*, *X LOCATION*, *Y LOCATION*)   <---Ignore * and replace with variables.

        ' Setup and display the HEADER. Set variable to display and then send it, X&Y location, font, and font color. (Not in that order)
        PrintLineString = "Print Selected Item"         '<---Set data
        e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)   '<---Display Data

        PrintLineString = "By Eric A Davis"
        VerticalPrintLocationSingle += LineHeightSingle     '<---Increment the Y coordinate to setup for the next line on page
        e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)

        ' Setup and display the BODY. Display whatever is selected in the CoffeeComboBox and SyrupBox
        VerticalPrintLocationSingle += LineHeightSingle * 2     '<--- Multiply by 2 to create a space between header/body
        PrintLineString = "Coffee: " & CoffeeComboBox.Text & "     Syrup: " & SyrupListBox.Text
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
    End Sub



    ' ----- CODE FOR PRINT ALL ITEMS ----->
    Private Sub PreviewAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreviewAllToolStripMenuItem.Click
        ' "Print All Flavors Preview" event. Assign Print All Document to Print Preview Dialog and call.

        PrintPreviewDialog1.Document = PrintAllPrintDocument
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintAllToolStripMenuItem.Click
        ' "Print All" event. Prints all of the flavors without showing print preview.

        PrintAllPrintDocument.Print()
    End Sub

    Private Sub PrintAllPrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintAllPrintDocument.PrintPage
        ' Sets up the "Print All" print document for use in both print and print preview. This code formats the page for the printer.
        ' Uses a loop to cycle through all the items in the lists.

        ' Variables to set font, set location, and create line spacing.
        Dim PrintFont As New Font("Arial", 12)
        Dim HeadingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2    '<---Use this variable to increment Y coordinate for each new line. Gets height & adds 2 pixels.
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim PrintLineString As String        '<--- Assign what needs printed to this variable.

        ' EX: e.Graphics.DrawString(*DATA TO DISPLAY*, *FONT*, *COLOR*, *X LOCATION*, *Y LOCATION*)   <---Ignore * and replace with variables.

        ' Setup and display the HEADER.
        e.Graphics.DrawString("Flavors", HeadingFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)

        ' Loop to setup and display contents of Coffee Flavor combobox. The loop will execute equal to the number of items in the combobox
        ' by using: .Items.Count - 1 (subtract one because index starts at 0). Each execution of the loop will format the Y line position,
        ' set index position to the string variable, display, and then increment ListIndexInteger
        For ListIndexInteger As Integer = 0 To CoffeeComboBox.Items.Count - 1
            VerticalPrintLocationSingle += LineHeightSingle
            PrintLineString = CoffeeComboBox.Items(ListIndexInteger).ToString()
            e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        Next ListIndexInteger
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' Exit menu item click event.
        Close()
    End Sub
End Class
