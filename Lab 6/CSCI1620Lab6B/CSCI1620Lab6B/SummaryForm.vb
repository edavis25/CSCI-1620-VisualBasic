' SUMMARY FORM

Public Class SummaryForm

    Private Sub SummaryForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ' Display Data for the Summary Form

        PartsTextBox.Text = JobInformationForm.PartsGrandTotal.ToString("C")
        LaborTextBox.Text = JobInformationForm.LaborGrandTotal.ToString("C")
        SalesTaxTextBox.Text = JobInformationForm.TaxGrandTotal.ToString("C")
        TotalTextBox.Text = JobInformationForm.GrandTotal.ToString("C")
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        Hide()
    End Sub
End Class