' Eric A Davis
' CSCI 1620 Lab 13B - 13.7 (pg. 557)
' CSCI 1620 - Visual Basic
' Autumn 2015

' DESCRIPTION:
' Adding 2 new categories: 1) Drinks and 2) Gifts to the program created for Lab 13A. Code has been copied and modified
' from Lab 13A to add the 2 new categories.

Public Class eadfrmmain

    ' *** DECLARATIONS ***

    Private TotalSalesDecimal, BookSalesDecimal, PeriodicalSalesDecimal, FoodSalesDecimal, DrinkSalesDecimal, GiftSalesDecimal As Decimal
    Private DrawChartBoolean As Boolean = False



    ' ----- "DISPLAY CHART" BUTTON CLICK EVENT ----->
    Private Sub DisplayChartButton_Click(sender As Object, e As EventArgs) Handles DisplayChartButton.Click
        ' This code displays a pie chart showing the relative sales by each of the departments. Includes a separate Try/Catch for
        ' each of the input boxes. After passing Try/Catch set the flag to draw chart to true. (ie. DrawChartBoolean = True). Also
        ' calculate the total sales amount for use in the math that paints the sections of the graph.


        ' Book Sales Try
        Try
            BookSalesDecimal = Decimal.Parse(BooksTextBox.Text)
            ' Periodicals Sales Try
            Try
                PeriodicalSalesDecimal = Decimal.Parse(PeriodicalsTextBox.Text)
                ' Food Sales Try
                Try
                    FoodSalesDecimal = Decimal.Parse(FoodTextBox.Text)
                    ' Drinks Sales Try
                    Try
                        DrinkSalesDecimal = Decimal.Parse(DrinksTextBox.Text)
                        'Gift Sales Try (Final Try)
                        Try
                            GiftSalesDecimal = Decimal.Parse(GiftsTextBox.Text)


                            ' CALCULATIONS. Set total sales decimal and the draw chart flag to true.
                            TotalSalesDecimal = BookSalesDecimal + PeriodicalSalesDecimal + FoodSalesDecimal + DrinkSalesDecimal + GiftSalesDecimal
                            DrawChartBoolean = True


                        Catch GiftSalesException As Exception
                            ' Catch Gift Sales exception
                            MessageBox.Show("Invalid Gift Sales", "Invalid Data Entry")
                            GiftsTextBox.Focus()
                            GiftsTextBox.SelectAll()
                        End Try

                    Catch DrinkSalesException As Exception
                        ' Catch Drink Sales exception
                        MessageBox.Show("Invalid Drink Sales", "Invalid Data Entry")
                        DrinksTextBox.Focus()
                        DrinksTextBox.SelectAll()
                    End Try

                Catch ex As Exception
                    ' Catch Food Sales exception
                    MessageBox.Show("Invalid Food Sales", "Invalid Data Entry")
                    FoodTextBox.Focus()
                    FoodTextBox.SelectAll()
                End Try

            Catch PeriodicalSalesException As Exception
                ' Catch Periodical Sales exception.
                MessageBox.Show("Invalid Periodicals Sales", "Invalid Data Entry")
                PeriodicalsTextBox.Focus()
                PeriodicalsTextBox.SelectAll()
            End Try

        Catch BookSalesException As Exception
            ' Catch Book Sales exception
            MessageBox.Show("Invalid Book Sales", "Invalid Data Entry")
            BooksTextBox.Focus()
            BooksTextBox.SelectAll()
        End Try


        ' Refresh to force the paint form event to trigger
        Refresh()

    End Sub



    ' ----- FORM PAINT EVENT ----->
    Private Sub eadfrmmain_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        ' This is the form's paint event. It paints the graph and sets the legend visible. This should only occur
        ' if the draw chart flag is set to true and total sales > 0

        Dim xCenterInteger As Integer = 110
        Dim yCenterInteger As Integer = 235
        Dim ClearBrush As New SolidBrush(eadfrmmain.DefaultBackColor)


        If DrawChartBoolean = True Then


            If TotalSalesDecimal <> 0 Then

                ' Set Legend Visible
                LegendGroupBox.Visible = True


                ' BOOK SALES : Find end of portion of 360 degrees
                Dim EndBookSalesInteger As Integer = Convert.ToInt32(BookSalesDecimal / TotalSalesDecimal * 360)
                ' Draw section of graph
                e.Graphics.FillPie(Brushes.Blue, xCenterInteger, yCenterInteger, 75, 75, 0, EndBookSalesInteger)

                ' PERIODICAL SALES : Find end of portion of 360 degrees
                Dim EndPeriodicalSalesInteger As Integer = Convert.ToInt32(PeriodicalSalesDecimal / TotalSalesDecimal * 360)
                ' Draw section of graph
                e.Graphics.FillPie(Brushes.Goldenrod, xCenterInteger, yCenterInteger, 75, 75, EndBookSalesInteger, EndPeriodicalSalesInteger)

                ' FOOD SALES : Find end of portion of 360 degrees
                Dim EndFoodSalesInteger As Integer = Convert.ToInt32(FoodSalesDecimal / TotalSalesDecimal * 360)
                ' Draw section of graph (Add the 2 other recently created sales integer variables together for correct placement)
                e.Graphics.FillPie(Brushes.Red, xCenterInteger, yCenterInteger, 75, 75, EndPeriodicalSalesInteger + EndBookSalesInteger, EndFoodSalesInteger)

                ' DRINK SALES : Find end portion of 360 degrees
                Dim EndDrinkSalesInteger As Integer = Convert.ToInt32(DrinkSalesDecimal / TotalSalesDecimal * 360)
                ' Draw section of graph. Add all other recently created variables to gether to get the placement for this section.
                e.Graphics.FillPie(Brushes.Green, xCenterInteger, yCenterInteger, 75, 75, EndFoodSalesInteger + EndPeriodicalSalesInteger + EndBookSalesInteger, EndDrinkSalesInteger)

                ' GIFT SALES : Find end portion of 360 degrees
                Dim EndGiftSalesInteger As Integer = Convert.ToInt32(GiftSalesDecimal / TotalSalesDecimal * 360)
                ' Draw section of graph. Add all other recently created variables to gether to get the placement for this section.
                e.Graphics.FillPie(Brushes.Purple, xCenterInteger, yCenterInteger, 75, 75, EndDrinkSalesInteger + EndFoodSalesInteger + EndPeriodicalSalesInteger + EndBookSalesInteger, EndGiftSalesInteger)

            End If


        Else
            'Else if DrawChartBoolean = False Then clear the chart
            e.Graphics.FillEllipse(ClearBrush, xCenterInteger, yCenterInteger, 75, 75)
            LegendGroupBox.Visible = False
        End If
    End Sub



    ' ----- "CLEAR" BUTTON CLICK EVENT ----->
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' Clears the forms, chart, legend, and sets DrawChartBoolean to false. Refresh form.

        BooksTextBox.Clear()
        BooksTextBox.Focus()
        PeriodicalsTextBox.Clear()
        FoodTextBox.Clear()
        DrinksTextBox.Clear()
        GiftsTextBox.Clear()
        LegendGroupBox.Visible = False
        DrawChartBoolean = False

        Refresh()

    End Sub



    ' ----- "EXIT" BUTTON CLICK EVENT ----->
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' Exit and close the program

        Close()
    End Sub
End Class
