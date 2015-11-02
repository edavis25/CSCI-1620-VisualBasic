' Eric A Davis
' CSCI-1620 Lab 8B
' CSCI-1620 - Visual Basic
' Autumn 2015



Public Class eadfrmmain

    Private DistanceTable(,) As Integer =
        {{0, 1004, 1753, 2752, 3017, 1520, 1507, 609, 3155, 448},
          {1004, 0, 921, 1780, 2048, 1397, 919, 515, 2176, 709},
          {1753, 921, 0, 1230, 1399, 1343, 517, 1435, 2234, 1307},
          {2752, 1780, 1230, 0, 272, 2570, 1732, 2251, 1322, 2420},
          {3017, 2048, 1399, 272, 0, 2716, 1858, 2523, 1278, 2646},
          {1520, 1397, 1343, 2570, 2716, 0, 860, 1494, 3447, 1057},
          {1507, 919, 517, 1732, 1858, 860, 0, 1307, 2734, 1099},
          {609, 515, 1435, 2251, 2523, 1494, 1307, 0, 2820, 571},
          {3155, 2176, 2234, 1322, 1278, 3447, 2734, 2820, 0, 2887},
          {448, 709, 1307, 2420, 2646, 1057, 1099, 571, 2887, 0}}


    Private Sub DistanceButton_Click(sender As Object, e As EventArgs) Handles DistanceButton.Click
        ' "Distance" button click event. This code will set the user choices from the combo boxes into local variables to then lookup
        ' the correct distance in the DistanceTable array. Use IF tests to make sure the user has selected something and then display
        ' the result of the table lookup in the Distance textbox.

        Dim DepartureCityIndex
        Dim DestinationCityIndex
        Dim DistanceBetweenCities As Integer


        ' First IF tests the Departure ComboBox for an input
        If DepartureComboBox.SelectedIndex <> -1 Then

            ' Second IF tests the Destination ComboBox for an input
            If DestinationComboBox.SelectedIndex <> -1 Then

                ' Set Local Variables to indexes specified by user choices in the combo boxes
                DepartureCityIndex = DepartureComboBox.SelectedIndex
                DestinationCityIndex = DestinationComboBox.SelectedIndex

                ' Lookup the mileage and set it to a variable
                DistanceBetweenCities = DistanceTable(DepartureCityIndex, DestinationCityIndex)

                ' Format and Display the distance
                DistanceTextBox.Text = DistanceBetweenCities.ToString

            Else
                ' ELSE handles no destination city selection
                MessageBox.Show("Please select a destination city", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                DestinationComboBox.Focus()
            End If

        Else
            ' ELSE handles no departure city selection
            MessageBox.Show("Please select a departure city", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            DepartureComboBox.Focus()
        End If

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' "Clear" button click event. Clear the textbox, the 2 comboboxes, and set focus to DepartureCityComboBox

        DistanceTextBox.Clear()
        DepartureComboBox.SelectedIndex = -1
        DestinationComboBox.SelectedIndex = -1

        DepartureComboBox.Focus()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' "Exit" button click event...nuff said...

        Close()
    End Sub
End Class
