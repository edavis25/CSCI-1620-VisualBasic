Public Class eadfrmmain

    '*** DECLARATIONS ***
    Private TheBookSale As BookSale   '<--- Declares Book Sale object
    Private TheStudentBookSale As StudentBookSale



    ' ----- FORM LOAD EVENT ----->
    Private Sub eadfrmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load Event hides the "OK" button on the main form that was inherited from the base form.

        OKButton.Visible = False

    End Sub



    ' ----- "CALCULATE SALE" CLICK EVENT ----->
    Private Sub CalculateSaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateSaleToolStripMenuItem.Click
        ' "Calculate Sale" menu item click event. This code will instantiate the objects and set the properties. Everything is placed within a 
        ' Try/Catch to handle any exceptions. IF test on the StudentCheckBox determines if we should instantiate the BookSale or the StudentBookSale object.

        Try

            If StudentCheckBox.Checked Then
                ' Instantiate StudentBookSale object to apply the discount.
                TheStudentBookSale = New StudentBookSale(TitleTextBox.Text, Integer.Parse(QuantityTextBox.Text), Decimal.Parse(PriceTextBox.Text))

                ' Calculate and format results (with discount)
                ExtendedPriceTextBox.Text = TheStudentBookSale.ExtendedPrice.ToString("N")

            Else
                ' Instantiate BookSale object to calculate without a discount.
                TheBookSale = New BookSale(TitleTextBox.Text, Integer.Parse(QuantityTextBox.Text), Decimal.Parse(PriceTextBox.Text))

                ' Calculate and format results (no discount)
                ExtendedPriceTextBox.Text = TheBookSale.ExtendedPrice.ToString("N")
            End If

        Catch ex As Exception
            ' Catch any exceptions for the input data
            MessageBox.Show("Error in quantity or price field. Data must be numeric", "R 'n R Book Sales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub



    ' ----- "SUMMARY" CLICK EVENT ----->
    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        ' Display the "Summary" form.

        SummaryForm.ShowDialog()
    End Sub



    ' ----- "CLEAR" CLICK EVENT ----->
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ' Clear all the screen controls. Revert focus to Title Text Box.
        QuantityTextBox.Clear()
        PriceTextBox.Clear()
        ExtendedPriceTextBox.Clear()
        StudentCheckBox.Checked = False
        With TitleTextBox
            .Clear()
            .Focus()
        End With

    End Sub



    ' ----- "EXIT" CLICK EVENT ----->
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' Closes the project.
        Close()
    End Sub



    ' ----- "ABOUT" CLICK EVENT ----->
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub
End Class
