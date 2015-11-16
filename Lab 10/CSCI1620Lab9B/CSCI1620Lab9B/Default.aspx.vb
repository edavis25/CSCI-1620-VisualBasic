' Eric A Davis
' CSCI-1620 Lab 9B - Exercise 9.1 (pg. 395)
' CSCI-1620 Visual Basic
' Autumn 2015

' DESCRIPTION:
' Exercise 9.1 recreates the rental car program from Lab 3B (Exercise 3.7 on page 152). This is a simple calculator 
' for a car rental company charging $15 per day and $0.12 per mile. Only required fields are odometer readings and days rented.


Public Class _Default
    Inherits System.Web.UI.Page

    ' ***** Global DECLARATIONS *****
    Const COST_PER_DAY As Decimal = 15
    Const COST_PER_MILE As Decimal = 0.12



    Protected Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        ' "Calculate" button click event. This procedure will Try/Catch the input values and then calculate and display the data.

        ' *** DECLARATIONS ***
        Dim DaysRentedInteger As Integer
        Dim BeginningOdometerDecimal, EndingOdometerDecimal, MilesDrivenDecimal, TotalPriceDecimal As Decimal


        ' Set the ErrorMessageLabel to blank
        ErrorMessageLabel.Text = String.Empty

        ' Try/Catch the input values.
        Try
            BeginningOdometerDecimal = Decimal.Parse(BeginningOdometerTextBox.Text)
            EndingOdometerDecimal = Decimal.Parse(EndingOdometerTextBox.Text)
            DaysRentedInteger = Integer.Parse(DaysRentedTextBox.Text)

            ' Calculate Miles Driven and Total Price
            MilesDrivenDecimal = EndingOdometerDecimal - BeginningOdometerDecimal
            TotalPriceDecimal = (MilesDrivenDecimal * COST_PER_MILE) + (DaysRentedInteger * COST_PER_DAY)

            ' Format and Display values for Miles Driven/Total Price textboxes.
            MilesDrivenDecimal = Decimal.Round(MilesDrivenDecimal, 1)
            MilesDrivenTextBox.Text = MilesDrivenDecimal.ToString()
            TotalPriceTextBox.Text = TotalPriceDecimal.ToString("C")


        Catch GenericException As Exception
            ' Catch any exceptions for the data being parsed. Beginning/Ending Odometers must be decimal.
            ' Days rented must be integer. Display error in the ErrorMessageLabel.
            ErrorMessageLabel.Text = "Error. Check for numeric values."
        End Try

    End Sub

  
    Protected Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' "Clear" button click event. This procedure will clear all of the fields.

        ErrorMessageLabel.Text = String.Empty
        NameTextBox.Text = ""
        AddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipTextBox.Text = ""
        BeginningOdometerTextBox.Text = ""
        EndingOdometerTextBox.Text = ""
        DaysRentedTextBox.Text = ""
        MilesDrivenTextBox.Text = ""
        TotalPriceTextBox.Text = ""

    End Sub
End Class