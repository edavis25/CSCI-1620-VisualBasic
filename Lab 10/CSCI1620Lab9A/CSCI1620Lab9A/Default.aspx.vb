' Eric A Davis
' Lab 9A - Hands On Programming (pg. 386)
' CSCI 1620 - Visual Basic
' Autumn 2015


Public Class _Default
    Inherits System.Web.UI.Page

    ' ***** GLOBAL LEVEL DECLARATIONS *****
    Private DiscountTotalDecimal As Decimal
    Const DISCOUNT_RATE_DECIMAL As Decimal = 0.15D



    Protected Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ' "Submit" button click event. This procedure will try and catch the Quantity and Price text box inputs and then
        ' calculate and display the values for the sale.

        ' ***DECLARATIONS ***
        Dim QuantityInteger As Integer
        Dim PriceDecimal, ExtendedPriceDecimal, DiscountDecimal, DiscountedPriceDecimal As Decimal



        ' Set Error Message Lable to empty
        ErrorMessageLabel.Text = String.Empty

        ' Try/Catch for the Quantity and Price inputs together.
        Try
            QuantityInteger = Integer.Parse(QuantityTextBox.Text)
            PriceDecimal = Decimal.Parse(PriceTextBox.Text)

            ' Calculate the values for the sale
            ExtendedPriceDecimal = QuantityInteger * PriceDecimal
            DiscountDecimal = ExtendedPriceDecimal * DISCOUNT_RATE_DECIMAL
            DiscountedPriceDecimal = ExtendedPriceDecimal - DiscountDecimal

            ' Add to the accumulator for total discounts
            DiscountTotalDecimal = DiscountTotalDecimal + DiscountDecimal

            ' Save the DiscountTotal variable to the hidden field.
            DiscountTotalHiddenField.Value = DiscountTotalDecimal.ToString()

            ' Format and Display the Results in the Textboxes
            ExtendedPriceTextBox.Text = ExtendedPriceDecimal.ToString("C")
            DiscountTextBox.Text = DiscountDecimal.ToString("C")
            DiscountedPriceTextBox.Text = DiscountedPriceDecimal.ToString("C")


        Catch InputException As Exception
            ' Catches bad input into the Quantity/Price textboxes. Display error in the message label
            ErrorMessageLabel.Text = "Unable to calculate. Check for numeric values."
        End Try

    End Sub


    Protected Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' "Clear" button click event. This procedure will clear any data from all of the fields.

        QuantityTextBox.Text = ""
        TitleTextBox.Text = ""
        PriceTextBox.Text = ""
        ExtendedPriceTextBox.Text = ""
        DiscountTextBox.Text = ""
        DiscountedPriceTextBox.Text = ""
        DiscountTotalLabel.Text = ""
        ErrorMessageLabel.Text = ""
    End Sub


    Protected Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        ' "Summary" button click event. This procedure will show the total discounts given with the DiscountTotalLabel.

        DiscountTotalLabel.Text = "Total Discounts: " & DiscountTotalDecimal.ToString("C")
    End Sub


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Checks for an existing value in the discount total and adds it the total decimal accumulator.

        With DiscountTotalHiddenField

            ' IF test to add the value in the hidden field to the total discounts if exists
            If IsPostBack And .Value <> "" Then
                DiscountTotalDecimal = Decimal.Parse(.Value)
            End If

        End With
    End Sub
End Class