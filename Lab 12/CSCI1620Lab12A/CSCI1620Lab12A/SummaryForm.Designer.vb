<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
    Inherits CSCI1620Lab12A.BaseForm

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
        Me.SalesTotalTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SalesCountTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DiscountTotalTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(103, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sales Total:"
        '
        'SalesTotalTextBox
        '
        Me.SalesTotalTextBox.Location = New System.Drawing.Point(172, 112)
        Me.SalesTotalTextBox.Name = "SalesTotalTextBox"
        Me.SalesTotalTextBox.ReadOnly = True
        Me.SalesTotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SalesTotalTextBox.TabIndex = 6
        Me.SalesTotalTextBox.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Sales Count:"
        '
        'SalesCountTextBox
        '
        Me.SalesCountTextBox.Location = New System.Drawing.Point(172, 144)
        Me.SalesCountTextBox.Name = "SalesCountTextBox"
        Me.SalesCountTextBox.ReadOnly = True
        Me.SalesCountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SalesCountTextBox.TabIndex = 8
        Me.SalesCountTextBox.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Total Student Discounts:"
        '
        'DiscountTotalTextBox
        '
        Me.DiscountTotalTextBox.Location = New System.Drawing.Point(172, 174)
        Me.DiscountTotalTextBox.Name = "DiscountTotalTextBox"
        Me.DiscountTotalTextBox.ReadOnly = True
        Me.DiscountTotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DiscountTotalTextBox.TabIndex = 10
        Me.DiscountTotalTextBox.TabStop = False
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 333)
        Me.Controls.Add(Me.DiscountTotalTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SalesCountTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SalesTotalTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Name = "SummaryForm"
        Me.Text = "Summary"
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.SalesTotalTextBox, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.SalesCountTextBox, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.DiscountTotalTextBox, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SalesTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SalesCountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DiscountTotalTextBox As System.Windows.Forms.TextBox
End Class
