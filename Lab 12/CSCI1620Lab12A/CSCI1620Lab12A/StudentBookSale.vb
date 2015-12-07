' STUDENT BOOK SALE Class.
' This class is used to calculate the price of the user's book sale if they DO receive a discount.


Public Class StudentBookSale
    Inherits BookSale

    ' *** DECLARATIONS ***
    Const DISCOUNT_RATE_DECIMAL As Decimal = 0.15
    Private DiscountDecimal As Decimal

    Private Shared DiscountTotalDecimal As Decimal



    ' *** CONSTRUCTOR ***
    Sub New(ByVal Title As String, ByVal Quantity As Integer, ByVal Price As Decimal)

        ' Call the base-class constructor and pass property values.
        MyBase.New(Title, Quantity, Price)

    End Sub



    ' ----- DISCOUNT TOTAL property ----->
    Shared ReadOnly Property DiscountTotal() As Decimal
        Get
            Return DiscountTotalDecimal
        End Get
    End Property



    ' ----- Calculate EXTENDED PRICE method ----->
    Protected Overrides Sub CalculateExtendedPrice()
        MyBase.CalculateExtendedPrice()
        ' Calculate the extended price and add totals. This overrides the procedure in the BookSale class of the same name.

        DiscountDecimal = (Quantity * Price) * DISCOUNT_RATE_DECIMAL
        ExtendedPrice = (Quantity * Price) - DiscountDecimal
        DiscountTotalDecimal += DiscountDecimal
    End Sub
End Class
