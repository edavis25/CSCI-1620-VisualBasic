' Eric A Davis
' CSCI 1620 Lab 12B - Exercise 12.5 (pg 520)
' CSCI 1620 - Visual Basic
' Autumn 2015


Public Class eadfrmmain

    ' *** DECLARATIONS ***
    Private TheSalesPerson As SalesPerson



    '----- LOAD EVENT ----->
    Private Sub eadfrmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hide the OK button and the White + Blue lines from the main form.

        OKButton.Visible = False
        WhiteLineLabel.Visible = False
        BlueLineLabel.Visible = False

    End Sub



    ' ----- "PAY" CLICK EVENT ----->
    Private Sub PayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayToolStripMenuItem.Click
        ' Code for "Pay" menu item click event. Calculate the pay and commission using the Sales Person class. 
        ' Try/Catch for bad input data. Format and display the data into the textboxes.

        Try
            TheSalesPerson = New SalesPerson(NameTextBox.Text, Decimal.Parse(SalesTextBox.Text))

            AmountPaidTextBox.Text = TheSalesPerson.Pay.ToString("N2")
            CommissionTextBox.Text = TheSalesPerson.Commission.ToString("N2")


        Catch ex As Exception
            ' Catch any exceptions including bad input data.
            MessageBox.Show("Please enter name and sales amount. Sales amount must be numeric.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub



    ' ----- "SUMMARY" CLICK EVENT ----->
    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        ' Show the summary form. If no data has been entered, show an error message instead.

        If SalesPerson.TotalSales <> 0 Then
            SummaryForm.ShowDialog()

        Else
            MessageBox.Show("No sales data to summarize.", "No Sales Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub



    ' ----- "EXIT" CLICK EVENT ----->
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' Close and exit the program

        Close()

    End Sub



    ' ----- "CLEAR" CLICK EVENT ----->
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ' Clear the text boxes on the main form and reset focus to Name text box.

        SalesTextBox.Clear()
        AmountPaidTextBox.Clear()
        CommissionTextBox.Clear()
        With NameTextBox
            .Clear()
            .Focus()
        End With
    End Sub



    ' ----- "ABOUT" CLICK EVENT ----->
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' Show the about Form
        AboutForm.ShowDialog()

    End Sub



    ' ----- "FONT" CLICK EVENT ----->
    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        ' Allow user to change font of the output text boxes.
        With FontDialog1
            .Font = AmountPaidTextBox.Font
            .ShowDialog()
            AmountPaidTextBox.Font = .Font
            CommissionTextBox.Font = .Font
        End With
    End Sub



    ' ----- "COLOR" CLICK EVENT ----->
    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        ' Allow user to change the color of the output text boxes
        With ColorDialog1
            .Color = AmountPaidTextBox.ForeColor
            .ShowDialog()
            AmountPaidTextBox.ForeColor = .Color
            CommissionTextBox.ForeColor = .Color
        End With

        AmountPaidTextBox.BackColor = AmountPaidTextBox.BackColor
        CommissionTextBox.BackColor = CommissionTextBox.BackColor
    End Sub
End Class
