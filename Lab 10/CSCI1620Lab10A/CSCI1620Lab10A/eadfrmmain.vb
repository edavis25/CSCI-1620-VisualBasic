Public Class eadfrmmain

    Private Sub BooksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BooksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RnrBooksDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RnrBooksDataSet.Books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.RnrBooksDataSet.Books)

    End Sub



    ' The following 2 procedures use the code given to close out of the program.
    ' This is necessary because the data set will not close itself automatically.

    Private Sub BooksBindingSource_Disposed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BooksBindingSource.Disposed
        Me.Dispose()
    End Sub

    Private Sub Form1_closing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.BooksBindingSource.Dispose()
    End Sub

End Class
