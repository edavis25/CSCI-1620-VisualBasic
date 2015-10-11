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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.SalesTaxTextBox = New System.Windows.Forms.TextBox()
        Me.LaborTextBox = New System.Windows.Forms.TextBox()
        Me.PartsTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TotalTextBox)
        Me.GroupBox1.Controls.Add(Me.SalesTaxTextBox)
        Me.GroupBox1.Controls.Add(Me.LaborTextBox)
        Me.GroupBox1.Controls.Add(Me.PartsTextBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(205, 146)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totals From All Sales"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(86, 102)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.ReadOnly = True
        Me.TotalTextBox.Size = New System.Drawing.Size(89, 20)
        Me.TotalTextBox.TabIndex = 7
        Me.TotalTextBox.TabStop = False
        '
        'SalesTaxTextBox
        '
        Me.SalesTaxTextBox.Location = New System.Drawing.Point(86, 80)
        Me.SalesTaxTextBox.Name = "SalesTaxTextBox"
        Me.SalesTaxTextBox.ReadOnly = True
        Me.SalesTaxTextBox.Size = New System.Drawing.Size(89, 20)
        Me.SalesTaxTextBox.TabIndex = 6
        Me.SalesTaxTextBox.TabStop = False
        '
        'LaborTextBox
        '
        Me.LaborTextBox.Location = New System.Drawing.Point(86, 58)
        Me.LaborTextBox.Name = "LaborTextBox"
        Me.LaborTextBox.ReadOnly = True
        Me.LaborTextBox.Size = New System.Drawing.Size(89, 20)
        Me.LaborTextBox.TabIndex = 5
        Me.LaborTextBox.TabStop = False
        '
        'PartsTextBox
        '
        Me.PartsTextBox.Location = New System.Drawing.Point(86, 36)
        Me.PartsTextBox.Name = "PartsTextBox"
        Me.PartsTextBox.ReadOnly = True
        Me.PartsTextBox.Size = New System.Drawing.Size(89, 20)
        Me.PartsTextBox.TabIndex = 4
        Me.PartsTextBox.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sales Tax"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Labor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Parts"
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(68, 164)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(88, 25)
        Me.OkButton.TabIndex = 1
        Me.OkButton.Text = "&Ok"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(233, 199)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SummaryForm"
        Me.Text = "Summary - Pat's Auto Repair"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SalesTaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LaborTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PartsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OkButton As System.Windows.Forms.Button
End Class
