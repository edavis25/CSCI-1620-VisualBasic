' Summary Form
' Displays the summary data from all of the user entered book sales.

Public Class SummaryForm

    Public Overrides Sub OKButton_Click(sender As Object, e As EventArgs)
        MyBase.OKButton_Click(sender, e)

        ' Override "OK" button to hide form.
        Hide()

    End Sub


    Private Sub SummaryForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' Display all of the summary information on the form.

        SalesTotalTextBox.Text = BookSale.SalesTotal.ToString("C")
        SalesCountTextBox.Text = BookSale.SalesCount.ToString()
        DiscountTotalTextBox.Text = StudentBookSale.DiscountTotal.ToString("C")
    End Sub
End Class