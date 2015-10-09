<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
    Inherits System.Windows.Forms.Form

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TotalSalesTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AverageSalesTextBox = New System.Windows.Forms.TextBox()
        Me.NumberOfCustomersTextBox = New System.Windows.Forms.TextBox()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "R 'n R for Reading and Refreshment Billing Summary"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Sales:"
        '
        'TotalSalesTextBox
        '
        Me.TotalSalesTextBox.Location = New System.Drawing.Point(208, 69)
        Me.TotalSalesTextBox.Name = "TotalSalesTextBox"
        Me.TotalSalesTextBox.ReadOnly = True
        Me.TotalSalesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalSalesTextBox.TabIndex = 2
        Me.TotalSalesTextBox.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Average Sales:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(81, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Number of Customers:"
        '
        'AverageSalesTextBox
        '
        Me.AverageSalesTextBox.Location = New System.Drawing.Point(208, 94)
        Me.AverageSalesTextBox.Name = "AverageSalesTextBox"
        Me.AverageSalesTextBox.ReadOnly = True
        Me.AverageSalesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AverageSalesTextBox.TabIndex = 5
        Me.AverageSalesTextBox.TabStop = False
        '
        'NumberOfCustomersTextBox
        '
        Me.NumberOfCustomersTextBox.Location = New System.Drawing.Point(208, 120)
        Me.NumberOfCustomersTextBox.Name = "NumberOfCustomersTextBox"
        Me.NumberOfCustomersTextBox.ReadOnly = True
        Me.NumberOfCustomersTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumberOfCustomersTextBox.TabIndex = 6
        Me.NumberOfCustomersTextBox.TabStop = False
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(233, 169)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 7
        Me.CloseButton.Text = "&Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'SummaryForm
        '
        Me.AcceptButton = Me.CloseButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 204)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.NumberOfCustomersTextBox)
        Me.Controls.Add(Me.AverageSalesTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TotalSalesTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SummaryForm"
        Me.Text = "R 'n R Billing Summary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TotalSalesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AverageSalesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumberOfCustomersTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CloseButton As System.Windows.Forms.Button
End Class
