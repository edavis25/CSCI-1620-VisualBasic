Public Class AboutForm

    ' ----- "OK" CLICK EVENT ----->

    Public Overrides Sub OKButton_Click(sender As Object, e As EventArgs)
        MyBase.OKButton_Click(sender, e)

        Close()

    End Sub
End Class