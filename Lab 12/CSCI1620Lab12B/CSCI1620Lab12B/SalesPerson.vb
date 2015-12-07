' SALES PERSON Class
' This will handle all the calcualtions to then be passed and displayed on the forms.


Public Class SalesPerson

    ' *** DECLARATIONS ***
    Protected Const BASE_PAY As Decimal = 250
    Protected Const COMMISSION_RATE As Decimal = 0.15
    Protected Const QUOTA As Decimal = 1000

    Private NameString As String
    Private SalesDecimal, PayDecimal As Decimal
    Private CommissionDecimal As Decimal

    Private Shared TotalPayDecimal, TotalSalesDecimal, TotalCommissionDecimal As Decimal



    ' *** CONSTRUCTOR ***
    Sub New(ByVal NameIn As String, ByVal SalesIn As Decimal)
        ' Set the Name and Sales amount from the user inputs.

        Name = NameIn
        Sales = SalesIn
        FindPay()
    End Sub



    ' ----- NAME Property ----->
    Property Name() As String
        Get
            Return NameString
        End Get

        Set(value As String)
            NameString = value
        End Set
    End Property

    ' ----- SALES Property ----->
    Property Sales() As Decimal
        Get
            Return SalesDecimal
        End Get

        Set(value As Decimal)
            If value >= 0 Then
                SalesDecimal = value
            End If
        End Set
    End Property

    ' ----- COMMISSION Property ----->
    ReadOnly Property Commission() As Decimal
        Get
            Return CommissionDecimal
        End Get
    End Property

    ' ----- PAY Property ----->
    ReadOnly Property Pay() As Decimal
        Get
            Return PayDecimal
        End Get
    End Property

    ' ----- TOTAL SALES Property ----->
    Shared ReadOnly Property TotalSales() As Decimal
        Get
            Return TotalSalesDecimal
        End Get
    End Property

    ' ----- TOTAL PAY Property ----->
    Shared ReadOnly Property TotalPay() As Decimal
        Get
            Return TotalPayDecimal
        End Get
    End Property

    ' ----- TOTAL COMMISSION Property ----->
    Shared ReadOnly Property TotalCommission() As Decimal
        Get
            Return TotalCommissionDecimal
        End Get
    End Property




    ' ----- FIND PAY ----->
    Private Sub FindPay()
        ' Calculates and returns the amount of pay earned. 

        CommissionDecimal = CalculateCommission(SalesDecimal)  '<--- Send SalesDecimal to the CalculateCommission Function
        PayDecimal = CommissionDecimal + BASE_PAY

        ' Increment the accumulators (Total Pay & Total Sales)
        TotalPayDecimal += PayDecimal
        TotalSalesDecimal += SalesDecimal
    End Sub



    ' ----- CALCULATE COMMISSION ----->
    Private Function CalculateCommission(ByVal SalesDecimal As Decimal) As Decimal
        ' Calculate and return the amount of commission earned. Commission earned when sales >= quota.
        Dim CommissionAmountDecimal As Decimal


        If SalesDecimal >= QUOTA Then
            ' Calculate Commission
            CommissionAmountDecimal = SalesDecimal * COMMISSION_RATE

            ' Add amount to the total commission paid accumulator
            TotalCommissionDecimal += CommissionAmountDecimal

            ' Return the Result
            Return CommissionAmountDecimal

        Else
            ' Else No Commission Earned (Sales < Quota). $0 commission.
            Return 0
        End If

    End Function

End Class
