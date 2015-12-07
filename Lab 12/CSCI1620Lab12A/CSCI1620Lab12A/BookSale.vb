' BOOK SALE Class.
' This class is used to calculate the price of the user's book sale if they do NOT receive a discount.

Public Class BookSale

    ' *** DECLARATIONS ***
    Private TitleString As String
    Private QuantityInteger As Integer
    Private PriceDecimal, ExtendedPriceDecimal As Decimal

    Private Shared SalesTotalDecimal As Decimal
    Private Shared SalesCountInteger As Integer



    ' *** CONSTRUCTOR ***
    Public Sub New(ByVal TitleIn As String, ByVal QuantityIn As Integer, ByVal PriceIn As Decimal)
        ' Assign the different property values. Assigns the input parameters to the properties by using their property procedures.

        Title = TitleIn
        Quantity = QuantityIn
        Price = PriceIn
        CalculateExtendedPrice()
        AddToTotals()
    End Sub



    ' ----- TITLE property ----->
    Property Title() As String
        Get
            Return TitleString
        End Get

        Set(value As String)
            TitleString = value
        End Set
    End Property



    ' ----- QUANTITY property ----->
    Property Quantity() As Integer
        Get
            Return QuantityInteger
        End Get

        Set(value As Integer)
            If value >= 0 Then
                QuantityInteger = value
            End If
        End Set
    End Property



    ' ----- PRICE property ----->
    Property Price() As Decimal
        Get
            Return PriceDecimal
        End Get

        Set(value As Decimal)
            If value >= 0 Then
                PriceDecimal = value
            End If
        End Set
    End Property



    ' ----- EXTENDED PRICE property ----->
    Property ExtendedPrice() As Decimal
        Get
            Return ExtendedPriceDecimal
        End Get

        Set(value As Decimal)
            If value >= 0 Then
                ExtendedPriceDecimal = value
            End If
        End Set
    End Property



    ' ----- SALES TOTAL property ----->
    Shared ReadOnly Property SalesTotal() As Decimal
        Get
            Return SalesTotalDecimal
        End Get
    End Property



    ' ----- SALES COUNT property ----->
    Shared ReadOnly Property SalesCount() As Integer
        Get
            Return SalesCountInteger
        End Get
    End Property



    ' ----- ADD Sales TOTALS To Accumulators Method ----->
    Protected Sub AddToTotals()
        ' This method adds the totals to the accumulators.

        SalesTotalDecimal += ExtendedPriceDecimal
        SalesCountInteger += 1
    End Sub



    ' ----- Calculate EXTENDED PRICE method ----->
    Protected Overridable Sub CalculateExtendedPrice()
        ' Calculate the total price of the book sale.

        ExtendedPriceDecimal = PriceDecimal * QuantityInteger
    End Sub


End Class
