Public Class SummaryForm
    ' Summary Form for Lab 6A
    ' Displays summary (averaged information) from the orders entered.


    Private Sub SummaryForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        TotalSalesTextBox.Text = eadfrmmain.GrandTotalDecimal.ToString("C")
        AverageSalesTextBox.Text = eadfrmmain.AverageDecimal.ToString("C")
        NumberOfCustomersTextBox.Text = eadfrmmain.CustomerCountInteger.ToString()
    End Sub


    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        ' Close the summary form.
        Hide()
    End Sub
End Class