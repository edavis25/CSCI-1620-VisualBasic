' Eric A Davis
' Lab 8B - Hands On (pg.347)
' CSCI-1610 Visual Basic 
' Autumn 2015

Public Class eadfrmmain

    ' ***DECLARATIONS for global-Level ***

    ' Create a Structure for CoffeeSale
    Structure CoffeeSale
        Dim TypeString As String
        Dim QuantityString As String
        Dim PriceDecimal As Decimal
    End Structure

    ' Variables/Arrays
    Private TransactionCoffeeSale(20) As CoffeeSale                     '<--- Array for storing the info of each user selection (max of 20 orders)
    Private NumberTransactionsInteger As Integer
    Private PriceDecimal(,) As Decimal =
        {{2.6, 2.9, 3.25}, {4.9, 5.6, 6.1}, {8.75, 9.75, 11.25}}        '<--- Array for the prices of coffee. Each group represents the prices for given weight
    '    {1/4lb prices}     {1/2lb prices}      {1lb prices}             "(,)" means array is multidimensional

    Private SelectedButtonString As String



    '---- "Clear" Button ---->
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' "Clear" Button click event. Clears price textbox, clears the selection from coffee type combo box, and then selects
        ' the quarter pound radio button for default.

        PriceTextBox.Text = ""
        CoffeeTypeComboBox.SelectedIndex = -1
        QuarterPoundRadioButton.Checked = True
    End Sub


    ' ---- "Exit" Button ---->
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' "Exit" Button click event. Display a message box asking the user if they want to print the report. If print dialog response
        ' is Yes, call the print button click event. Exit program after the user makes either selection.

        Dim ResponseDialogResult As DialogResult

        ResponseDialogResult = MessageBox.Show("Print the report?", "Terminate the Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ResponseDialogResult = DialogResult.Yes Then
            PrintButton_Click(sender, e)
        End If

        Close()
    End Sub


    ' ---- "Find Price" Button ---->
    Private Sub FindPriceButton_Click(sender As Object, e As EventArgs) Handles FindPriceButton.Click
        ' "Find Price" button click event. Bulk of the programs function. First IF test allows only 20 transactions before displaying error message. Set the column integer
        ' local variable equal to the selection in the coffee type combo box. Second IF test checks the selection from coffee type combo box and then sets corresponding 
        ' local variable for row placement and the global level QuantityString that is part of each CoffeeSale. After getting the row and column placement of the user selection
        ' find the correct price from arrays, display it in price text box, and then assign is to the TransactionCoffeeSale array the records all sales. (use the number of transactions
        ' integer to place the sale information into the TransactionCoffeeSale array.


        Dim RowInteger, ColumnInteger As Integer
        Dim SalePriceDecimal As Decimal


        ' 1st IF test allows only 20 transactions.
        If NumberTransactionsInteger < 20 Then
            ColumnInteger = CoffeeTypeComboBox.SelectedIndex        '<---Sets the column placement of the user selected coffee type.

            ' IF test to make sure user has selected coffee type.
            If ColumnInteger <> -1 Then

                ' Case comparison looks at the name given to global SelectedButtonString variable that is assigned in the radio button check changed event.
                ' Sets appropriate local Row position variable and the string amount for the QuantityString property in the created CoffeeSale.
                Select Case SelectedButtonString
                    Case "QuarterPoundRadioButton"          '<---"Quarter Pound" selected
                        RowInteger = 0
                        TransactionCoffeeSale(NumberTransactionsInteger).QuantityString = "Quarter Pound"       '<---Set string for the quantity in the sales array. Use sale integer to determine placement in array.
                    Case "HalfPoundRadioButton"             '<---"Half Pound" selected
                        RowInteger = 1
                        TransactionCoffeeSale(NumberTransactionsInteger).QuantityString = "Half Pound"
                    Case "FullPoundRadioButton"             '<---"Full Pound" selected
                        RowInteger = 2
                        TransactionCoffeeSale(NumberTransactionsInteger).QuantityString = "Full Pound"
                    Case Else
                        ' No selection made so use default quarter pound
                        RowInteger = 0
                        TransactionCoffeeSale(NumberTransactionsInteger).QuantityString = "Quarter Pound"
                End Select

                ' Get Price from global PriceDecimal array using Row/Column integers
                SalePriceDecimal = PriceDecimal(RowInteger, ColumnInteger)

                ' Display price in Price Text Box
                PriceTextBox.Text = SalePriceDecimal.ToString("C")

                ' Save the transaction's coffee type and price to the Coffee Sale array
                TransactionCoffeeSale(NumberTransactionsInteger).TypeString = CoffeeTypeComboBox.Text
                TransactionCoffeeSale(NumberTransactionsInteger).PriceDecimal = SalePriceDecimal

                ' Increment the number of transactions counter
                NumberTransactionsInteger = NumberTransactionsInteger + 1

            Else
                ' ELSE for IF checking the user selection in the coffee combo box.
                MessageBox.Show("Please select a coffee type", "Coffee Type Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Else
            ' ELSE for IF checking max transactions < 20
            MessageBox.Show("Sorry, maximum of 20 transactions allowed.", "Maximum Transactions Reached", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub


    ' ---- Radio Button Check Changed ---->
    Private Sub QuarterPoundRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles QuarterPoundRadioButton.CheckedChanged, HalfPoundRadioButton.CheckedChanged, FullPoundRadioButton.CheckedChanged
        ' Check Changed event handls ALL THREE of the radio buttons. Set the global SelectButtonString variable equal to the selected radio button.

        SelectedButtonString = CType(sender, RadioButton).Name

    End Sub


    ' ---- "Print" Button ---->
    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        ' "Print" button click event. Set and call the Print Preview Dialog

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub


    ' ---- Print Document Print Page Event ---->
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Create and setup the document to print and display in the preview. Loops through the Coffee Sales array.

        Dim PrintFont As New Font("Arial", 12)
        Dim HeadingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim Column1HorizontalLocationSingle As Single = e.MarginBounds.Left
        Dim Column2HorizontalLocationSingle As Single = 300
        Dim Column3HorizontalLocationSingle As Single
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim PrintLineString As String
        Dim FontSizeF As New SizeF                      '<--- Used to measure the font for alignment
        Dim FormattedPriceString As String


        ' Setup and Create the HEADER
        PrintLineString = "R 'n R Coffee Sales"
        e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black, Column2HorizontalLocationSingle, VerticalPrintLocationSingle)

        VerticalPrintLocationSingle += LineHeightSingle
        PrintLineString = "By: Eric A Davis"
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, Column2HorizontalLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle * 2      '<--- Skip a line

        ' Loop thru transactions to retrieve data to print
        For Each IndividualCoffeeSale As CoffeeSale In TransactionCoffeeSale

            'IF test makes sure not to print any blank values
            If IndividualCoffeeSale.QuantityString <> "" Then

                ' Setup and display Quantity
                e.Graphics.DrawString(IndividualCoffeeSale.QuantityString, PrintFont, Brushes.Black, Column1HorizontalLocationSingle, VerticalPrintLocationSingle)

                ' Setup and display Type
                e.Graphics.DrawString(IndividualCoffeeSale.TypeString, PrintFont, Brushes.Black, Column2HorizontalLocationSingle, VerticalPrintLocationSingle)

                ' Setup and display Price. Align to the right.
                FormattedPriceString = FormatNumber(IndividualCoffeeSale.PriceDecimal)

                FontSizeF = e.Graphics.MeasureString(FormattedPriceString, PrintFont)       '<--- Measures the Price String for alignment
                Column3HorizontalLocationSingle = 550 - FontSizeF.Width                     '<--- Subtract the width string from the column position
                e.Graphics.DrawString(FormattedPriceString, PrintFont, Brushes.Black, Column3HorizontalLocationSingle, VerticalPrintLocationSingle)

                ' Increment Y for the next line with a double space.
                VerticalPrintLocationSingle += LineHeightSingle * 2

            End If
        Next
    End Sub


End Class


