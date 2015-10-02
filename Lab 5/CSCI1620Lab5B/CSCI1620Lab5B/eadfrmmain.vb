' Eric Davis
' Lab 5B - Exercise 5.3 (Pg. 245-246)
' CSCI 1620 - Autumn 2015

' Description:
'   Commission calculator. If the salesperson hits a predetermined quota,
'   they receive commission on their sales. This commission is added to a base
'   pay given regardless of meeting the quota.

Public Class eadfrmmain

    ' *** DECLARATIONS ***
    ' CONSTANTS
    Const COMMISSION_RATE As Decimal = 0.15
    Const QUOTA As Decimal = 1000
    Const BASE_PAY As Decimal = 250

    ' VARIABLES / ACCUMULATORS
    Private GrandTotalSales, GrandTotalPay, GrandTotalCommission As Decimal

    
    Private Sub PayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayToolStripMenuItem.Click
        ' Calculate pay for employees based on the weekly sales entered by the user into the textbox.
        ' *** DECLARATIONS ***
        Dim WeeklySalesDecimal, CommissionDecimal, TotalPayDecimal As Decimal

        ' Parse and Try/Catch user input for Weekly Sales textbox
        Try
            WeeklySalesDecimal = Decimal.Parse(WeeklySalesTextBox.Text)

            ' Call function to get commission amount
            CommissionDecimal = GetCommission(WeeklySalesDecimal)

            ' Calculate Total Pay
            TotalPayDecimal = BASE_PAY + CommissionDecimal

            ' Display Results in the output textboxes. If no commission earned then display NOTHING
            If CommissionDecimal = 0 Then
                CommissionTextBox.Clear()
            Else
                CommissionTextBox.Text = CommissionDecimal.ToString("N")
            End If
            TotalPayTextBox.Text = TotalPayDecimal.ToString("N")

            ' Add data to the Accumulators
            GrandTotalCommission = GrandTotalCommission + CommissionDecimal
            GrandTotalPay = GrandTotalPay + TotalPayDecimal
            GrandTotalSales = GrandTotalSales + WeeklySalesDecimal


        Catch WeeklySalesException As Exception
            ' Catches any errors from user entry into the Weekly Sales textbox.
            MessageBox.Show("Weekly sales entry must be a numeric.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With WeeklySalesTextBox
                .Focus()
                .SelectAll()
            End With
        End Try
    End Sub

    Private Function GetCommission(ByVal Amount As Decimal) As Decimal
        ' Function to check and see if salesperson is eligible for commission. If
        ' so, calculate and return commission - otherwise return 0.
        If Amount >= QUOTA Then
            Amount = Amount * COMMISSION_RATE
            Return Amount
        Else
            Amount = 0
            Return Amount
        End If
    End Function

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        ' Display the Totals from the accumulators for Total Sales, Total Commissions, and Total Paid for All Salespersons
        Dim MessageString As String

        ' Create variable for the text that goes into message box text for cleanliness.
        MessageString = "Total Sales: " & GrandTotalSales.ToString("C") & Environment.NewLine & _
            "Total Commission Paid: " & GrandTotalCommission.ToString("C") & Environment.NewLine & _
            "Total Pay For All Salespersons: " & GrandTotalPay.ToString("C")

        'If test makes sure there is sales data to summarize and displays error message if not.
        If GrandTotalSales <> 0 Then
            MessageBox.Show(MessageString, "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No sales data to summarize.", "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ' Clear all values in each one of the textboxes and focus on the Salesperson Name textbox
        WeeklySalesTextBox.Clear()
        TotalPayTextBox.Clear()
        CommissionTextBox.Clear()
        With NameTextBox
            .Clear()
            .Focus()
        End With

    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        ' Allows user to change the font of the output Text Boxes
        With FontDialog1
            .Font = TotalPayTextBox.Font
            .ShowDialog()
            TotalPayTextBox.Font = .Font
            CommissionTextBox.Font = .Font
        End With
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        ' Allows user to change the color of the output Text Boxes
        With ColorDialog1
            .Color = TotalPayTextBox.ForeColor
            .ShowDialog()
            TotalPayTextBox.ForeColor = .Color
            CommissionTextBox.ForeColor = .Color
        End With
        TotalPayTextBox.BackColor = TotalPayTextBox.BackColor
        CommissionTextBox.BackColor = CommissionTextBox.BackColor
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' Display an About message box with details about programmer.
        '  Uses a variable for the message to keep the code cleaner and easier to read.
        Dim MessageString As String

        MessageString = "Commission Calculator" & Environment.NewLine & "Programmed By: Eric A Davis"

        MessageBox.Show(MessageString, "About Commission Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
