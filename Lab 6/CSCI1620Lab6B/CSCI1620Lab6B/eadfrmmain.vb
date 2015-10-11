' CSCI-1620 - Lab 6B
' Eric Davis
' CSCI-1620 Autumn 2015

' DESCRIPTION:
' Calculator that takes inputs for cost of parts and hours of labor for single jobs and applies them to a total sales summary.
' Parts are charged tax and labor hour is 

Public Class eadfrmmain


   
    Private Sub JobInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JobInformationToolStripMenuItem.Click
        ' Display Job Information form. In the example program this MUST be responded to. (aka showdialog)
        JobInformationForm.ShowDialog()
    End Sub


    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        ' Display Summary form only if GrandTotal is greater than 0. In the example program this can be sent to background (aka show)
        If JobInformationForm.GrandTotal > 0 Then
            SummaryForm.Show()
        Else
            MessageBox.Show("No Sales Data To Summarize", "No Sales Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

   
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' Display generic About form for the product info found in Assembly Information.
        AboutBox1.ShowDialog()
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class
