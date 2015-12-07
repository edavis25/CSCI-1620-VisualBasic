' Eric A Davis
' CSCI 1620 Lab 13A - Hands On Example (pg. 550)
' CSCI 1620 - Visual Basic
' Autumn 2015


Public Class eadfrmmain

    ' *** DECLARATIONS ***

    Private TotalSalesDecimal, BookSalesDecimal, PeriodicalSalesDecimal, FoodSalesDecimal As Decimal
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
                ' Food Sales Try (Final Try)
                Try
                    FoodSalesDecimal = Decimal.Parse(FoodTextBox.Text)


                    ' CALCULATIONS. Set total sales decimal and the draw chart flag to true.
                    TotalSalesDecimal = BookSalesDecimal + PeriodicalSalesDecimal + FoodSalesDecimal
                    DrawChartBoolean = True


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
        Dim yCenterInteger As Integer = 190
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
