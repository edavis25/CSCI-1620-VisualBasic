Public Class eadfrmmain

    Private Sub VehicleBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VehicleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VBAutoDataSet)

    End Sub


    Private Sub VehicleBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VehicleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VBAutoDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VBAutoDataSet.Vehicle' table. You can move, or remove it, as needed.
        Me.VehicleTableAdapter.Fill(Me.VBAutoDataSet.Vehicle)

    End Sub


    ' The following 2 procedures use the code given to close the application.
    ' This is necessary because the data set will not close automatically without this code.
    Private Sub VehicleBindingSource_Disposed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VehicleBindingSource.Disposed
        Me.Dispose()

    End Sub

    Private Sub Form1_closing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.VehicleBindingSource.Dispose()
    End Sub
End Class
