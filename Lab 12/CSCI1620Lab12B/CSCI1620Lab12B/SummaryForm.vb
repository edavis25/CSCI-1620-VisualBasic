Public Class SummaryForm

    ' ----- "OK" CLICK EVENT ----->
    Public Overrides Sub OKButton_Click(sender As Object, e As EventArgs)
        MyBase.OKButton_Click(sender, e)

        Hide()

    End Sub



    ' ----- ACTIVATED EVENT ----->
    Private Sub SummaryForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' Display the summary information once form has been activated.

        TotalSalesTextBox.Text = SalesPerson.TotalSales.ToString("N2")
        TotalCommissionTextBox.Text = SalesPerson.TotalCommission.ToString("N2")
        TotalPayTextBox.Text = SalesPerson.TotalPay.ToString("C")
    End Sub
End Class