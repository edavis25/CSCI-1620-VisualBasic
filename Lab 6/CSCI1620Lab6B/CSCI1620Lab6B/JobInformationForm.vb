' JOB INFORMATION FORM:
' This form contains the variables and calculations for the project.

Public Class JobInformationForm

    ' *****FORM/GLOBAL LEVEL DECLARATIONS*****
    ' Constants:
    Const TAX_RATE As Decimal = 0.08
    Const COST_PER_HOUR As Decimal = 50

    ' Variables and Accumulators
    Friend PartsGrandTotal, LaborGrandTotal, TaxGrandTotal, GrandTotal As Decimal

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        ' Performs calculations for User Input values of Parts Cost and Labor Cost and adds them
        ' to the accumulators. Try/Catch the user input for error handling

        '***LOCAL DECLARATIONS***
        Dim PartsCharges, LaborHours, TaxAmount, LaborCost As Decimal

        ' Check Parts Charges user input
        Try
            PartsCharges = Decimal.Parse(PartsChargesTextBox.Text)

            ' Check Labor Hours user input
            Try
                LaborHours = Decimal.Parse(LaborHoursTextBox.Text)

                ' Find Tax and Labor Cost
                TaxAmount = PartsCharges * TAX_RATE
                LaborCost = LaborHours * COST_PER_HOUR

                ' Add Data to Accumulators
                PartsGrandTotal = PartsGrandTotal + PartsCharges
                LaborGrandTotal = LaborGrandTotal + LaborCost
                TaxGrandTotal = TaxGrandTotal + TaxAmount
                GrandTotal = GrandTotal + PartsCharges + LaborCost + TaxAmount

            Catch ex As Exception
                'Handle LaborHourse Exception and redirect focus.
                MessageBox.Show("Please enter numeric value for labor hours", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With LaborHoursTextBox
                    .Focus()
                    .SelectAll()
                End With
            End Try

        Catch PartsChargesException As Exception
            ' Handle PartsCharges Exception and redirect focus.
            MessageBox.Show("Please enter numeric value for cost of parts", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With PartsChargesTextBox
                .Focus()
                .SelectAll()
            End With
        End Try


    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' Clear all user input values for the Job Information Form text boxes
        CustomerNameTextBox.Clear()
        PartsChargesTextBox.Clear()
        LaborHoursTextBox.Clear()
        With JobNumberTextBox
            .Clear()
            .Focus()
        End With
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Hide()
    End Sub
End Class