' About Form
' Displays the information about the program's creation.

Public Class AboutForm

    Public Overrides Sub OKButton_Click(sender As Object, e As EventArgs)
        MyBase.OKButton_Click(sender, e)

        ' Override "OK" button to hide form.
        Hide()

    End Sub
End Class