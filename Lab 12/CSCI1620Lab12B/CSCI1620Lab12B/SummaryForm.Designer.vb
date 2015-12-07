<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
    Inherits CSCI1620Lab12B.BaseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TotalSalesTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TotalCommissionTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TotalPayTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total Sales:"
        '
        'TotalSalesTextBox
        '
        Me.TotalSalesTextBox.Location = New System.Drawing.Point(132, 117)
        Me.TotalSalesTextBox.Name = "TotalSalesTextBox"
        Me.TotalSalesTextBox.ReadOnly = True
        Me.TotalSalesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalSalesTextBox.TabIndex = 6
        Me.TotalSalesTextBox.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total Commission:"
        '
        'TotalCommissionTextBox
        '
        Me.TotalCommissionTextBox.Location = New System.Drawing.Point(132, 143)
        Me.TotalCommissionTextBox.Name = "TotalCommissionTextBox"
        Me.TotalCommissionTextBox.ReadOnly = True
        Me.TotalCommissionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalCommissionTextBox.TabIndex = 8
        Me.TotalCommissionTextBox.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Total Pay:"
        '
        'TotalPayTextBox
        '
        Me.TotalPayTextBox.Location = New System.Drawing.Point(132, 169)
        Me.TotalPayTextBox.Name = "TotalPayTextBox"
        Me.TotalPayTextBox.ReadOnly = True
        Me.TotalPayTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalPayTextBox.TabIndex = 10
        Me.TotalPayTextBox.TabStop = False
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 297)
        Me.Controls.Add(Me.TotalPayTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TotalCommissionTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TotalSalesTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Name = "SummaryForm"
        Me.Text = "Summary"
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TotalSalesTextBox, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TotalCommissionTextBox, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TotalPayTextBox, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TotalSalesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TotalCommissionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TotalPayTextBox As System.Windows.Forms.TextBox
End Class
