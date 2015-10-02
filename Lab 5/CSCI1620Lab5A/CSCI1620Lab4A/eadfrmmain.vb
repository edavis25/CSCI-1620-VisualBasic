' Eric Davis
' Lab 4A - Chapter 4 Hands-On
' CSCI 1620 - Autumn 2015

Public Class eadfrmmain

    ' Global Level Declarations for the Constants
    'These specify the pricing for Tax and each type of coffee
    Const TAX_RATE_DECIMAL As Decimal = 0.08D
    Const CAPPUCCINO_PRICE_DECIMAL As Decimal = 2D
    Const ESPRESSO_PRICE_DECIMAL As Decimal = 2.25D
    Const LATTE_PRICE_DECIMAL As Decimal = 1.75D
    Const ICED_PRICE_DECIMAL As Decimal = 2.5D

    ' Global Level Declarations for the Variables
    ' Accumulators + Counters for the summary info
    Private SubtotalDecimal, TotalDecimal, GrandTotalDecimal As Decimal
    Private CustomerCountInteger As Integer


    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click, CalculateSelectionToolStripMenuItem.Click
        ' Code for clicking "Calculate" button. Finds drink price, calculates subtotal, tax , etc.
        ' This button also enables "Clear" and "New Order" buttons as well as disables "Takeout" checkbox.

        ' *** Local Level Variables:    
        Dim PriceDecimal, TaxDecimal, ItemAmountDecimal As Decimal
        Dim QuantityInteger As Integer


        ' If statement to find the price of selected drink and assign it to variable.
        ' Show error message and redirect focus if user has not selected a coffee.
        If CappuccinoRadioButton.Checked Then
            PriceDecimal = CAPPUCCINO_PRICE_DECIMAL
        ElseIf EspressoRadioButton.Checked Then
            PriceDecimal = ESPRESSO_PRICE_DECIMAL
        ElseIf LatteRadioButton.Checked Then
            PriceDecimal = LATTE_PRICE_DECIMAL
        ElseIf IcedLatteRadioButton.Checked Then
            PriceDecimal = ICED_PRICE_DECIMAL
        ElseIf IcedCappuccinoRadioButton.Checked Then
            PriceDecimal = ICED_PRICE_DECIMAL
        Else
            MessageBox.Show("Please select a type of coffee.", "Coffee Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With QuantityTextBox
                .Focus()
                .SelectAll()
            End With
            Exit Sub
        End If


        ' Error check "Quantity" user input, convert to numeric integer. 
        Try
            QuantityInteger = Integer.Parse(QuantityTextBox.Text)

            ' Perform calculations on quantity input. Sets values for "ItemAmountDecimal" & "SubtotalDecimal"
            ItemAmountDecimal = QuantityInteger * PriceDecimal
            SubtotalDecimal = SubtotalDecimal + ItemAmountDecimal

            ' Call method for tax calculation and determine amount of Tax
            TaxDecimal = FindTax(SubtotalDecimal)

            ' Calculate and set value for "TotalDecimal".
            TotalDecimal = SubtotalDecimal + TaxDecimal

            ' Format and display output in "Item Amount", "Sub Total", "Tax", and "Total Due" text boxes.
            ItemAmountTextBox.Text = ItemAmountDecimal.ToString("C")
            SubTotalTextBox.Text = SubtotalDecimal.ToString("N")
            TaxTextBox.Text = TaxDecimal.ToString("N")
            TotalTextBox.Text = TotalDecimal.ToString("C")

            ' Enable the "Clear" and "New Order" Buttons.
            ClearButton.Enabled = True
            ClearItemToolStripMenuItem.Enabled = True
            NewOrderToolStripMenuItem.Enabled = True
            ' Disable "Tax Check Box"
            TaxCheckBox.Enabled = False

        Catch QuantityException As FormatException
            MessageBox.Show("Quantity must be a whole number.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With QuantityTextBox
                .Focus()
                .SelectAll()
            End With
        End Try
    End Sub

    Private Function FindTax(ByVal AmountDecimal As Decimal) As Decimal
        ' Function to take an amount given and then calculate the amount of tax
        ' If test checks and add Tax if necessary.

        If TaxCheckBox.Checked Then
            AmountDecimal = AmountDecimal * TAX_RATE_DECIMAL
        Else
            AmountDecimal = 0
        End If

        Return (AmountDecimal)
    End Function

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearItemToolStripMenuItem.Click
        'Clear the user's input quantity data and coffee selection.
        'Does NOT clear the subtotal and total amounts.
        ItemAmountTextBox.Clear()
        CappuccinoRadioButton.Checked = False
        EspressoRadioButton.Checked = False
        LatteRadioButton.Checked = False
        IcedLatteRadioButton.Checked = False
        IcedCappuccinoRadioButton.Checked = False
        With QuantityTextBox
            .Clear()
            .Focus()
        End With
    End Sub

    Private Sub NewOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewOrderToolStripMenuItem.Click
        ' Clears the current order totals and adds that data to the accumulators and grand total variables.

        ' *** Local Level Variables:
        Dim ReturnDialogResult As DialogResult
        Dim MessageString As String

        ' Show message box to confirm the request to clear the current order
        MessageString = "Clear the current order figures?"
        ReturnDialogResult = MessageBox.Show(MessageString, "Clear Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        ' If test the user's answer from above message box. If "Yes" execute the "New Order" code
        If ReturnDialogResult = Windows.Forms.DialogResult.Yes Then
            ' Clear the current order data. Calls "Clear Button" to perform this
            ClearButton_Click(sender, e)
            SubTotalTextBox.Clear()
            TaxTextBox.Clear()
            TotalTextBox.Clear()

            ' If test to make sure there is data to add to accumulators.
            ' Add data to the global accumulators and counters.
            If SubtotalDecimal <> 0 Then
                GrandTotalDecimal = GrandTotalDecimal + TotalDecimal
                CustomerCountInteger += 1
                ' Clears the previous single order totals to prepare for the next order
                SubtotalDecimal = 0
                TotalDecimal = 0
            End If

            ' Enable and uncheck "TaxCheckBox"
            With TaxCheckBox
                .Enabled = True
                .Checked = False
            End With
            ' Disable "ClearButton", "ClearItemToolStripMenuItem", and "NewOrderToolStripMenuItem"
            ClearButton.Enabled = False
            ClearItemToolStripMenuItem.Enabled = False
            NewOrderToolStripMenuItem.Enabled = False

        End If
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        ' Calculate and Display the total results from all orderes entered by the user.

        ' *** Local Level Variables:
        Dim AverageDecimal As Decimal
        Dim MessageString As String

        ' If test to make sure last order gets added to total
        If TotalDecimal <> 0 Then
            NewOrderToolStripMenuItem_Click(sender, e)
        End If

        ' If test to make sure there are more than 0 customer orders.
        ' Get average price of the orders
        If CustomerCountInteger > 0 Then
            AverageDecimal = GrandTotalDecimal / CustomerCountInteger

            ' Concatenate and place prompts and data into "MessageString" variable.
            ' Just puts all this clutter into one variable to display with the following message box.
            MessageString = "Number of Orders:  " & CustomerCountInteger.ToString() _
                & Environment.NewLine & Environment.NewLine _
                & "Total Sales:  " & GrandTotalDecimal.ToString("C") _
                & Environment.NewLine & Environment.NewLine _
                & "Average Sale:  " & AverageDecimal.ToString("C")

            ' Show the Message Box with summary information. Uses above Message String
            MessageBox.Show(MessageString, "Coffee Sales Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageString = "No sales data to summarize."
            MessageBox.Show(MessageString, "Coffee Sales Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        ' Allows user to change the font of the summary totals.
        ' FontDialog1 can be seen in component tray
        With FontDialog1
            .Font = SubTotalTextBox.Font
            .ShowDialog()
            SubTotalTextBox.Font = .Font
            TaxTextBox.Font = .Font
            TotalTextBox.Font = .Font
        End With
    End Sub

    Private Sub CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CToolStripMenuItem.Click
        ' Allows user to select new color for the summary totals
        ' ColorDialog1 box can be seen in component tray
        With ColorDialog1
            .Color = SubTotalTextBox.ForeColor
            .ShowDialog()
            SubTotalTextBox.ForeColor = .Color
            TaxTextBox.ForeColor = .Color
            TotalTextBox.ForeColor = .Color
        End With
        SubTotalTextBox.BackColor = SubTotalTextBox.BackColor    '<-- This is the extra code given to make
        TaxTextBox.BackColor = TaxTextBox.BackColor              ' the color change work w/ read-only textbox. 
        TotalTextBox.BackColor = TotalTextBox.BackColor
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' Display an About message box.  
        ' Sets the text into a variable for cleanliness.
        Dim MessageString As String

        MessageString = "R 'n R Billing" & Environment.NewLine & Environment.NewLine & _
            "Programmed By: Eric A Davis"
        MessageBox.Show(MessageString, "About R 'n R Billing", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
