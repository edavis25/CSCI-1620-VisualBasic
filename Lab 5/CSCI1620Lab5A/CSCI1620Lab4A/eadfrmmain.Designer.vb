<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eadfrmmain
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.IcedCappuccinoRadioButton = New System.Windows.Forms.RadioButton()
        Me.IcedLatteRadioButton = New System.Windows.Forms.RadioButton()
        Me.LatteRadioButton = New System.Windows.Forms.RadioButton()
        Me.EspressoRadioButton = New System.Windows.Forms.RadioButton()
        Me.CappuccinoRadioButton = New System.Windows.Forms.RadioButton()
        Me.ItemAmountTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.TaxCheckBox = New System.Windows.Forms.CheckBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TaxTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SubTotalTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateSelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.ItemAmountTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ClearButton)
        Me.GroupBox1.Controls.Add(Me.CalculateButton)
        Me.GroupBox1.Controls.Add(Me.TaxCheckBox)
        Me.GroupBox1.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 178)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.IcedCappuccinoRadioButton)
        Me.GroupBox2.Controls.Add(Me.IcedLatteRadioButton)
        Me.GroupBox2.Controls.Add(Me.LatteRadioButton)
        Me.GroupBox2.Controls.Add(Me.EspressoRadioButton)
        Me.GroupBox2.Controls.Add(Me.CappuccinoRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(203, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(142, 136)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Coffee Selections"
        Me.ToolTip1.SetToolTip(Me.GroupBox2, "Select a Type of Coffee")
        '
        'IcedCappuccinoRadioButton
        '
        Me.IcedCappuccinoRadioButton.AutoSize = True
        Me.IcedCappuccinoRadioButton.Location = New System.Drawing.Point(6, 111)
        Me.IcedCappuccinoRadioButton.Name = "IcedCappuccinoRadioButton"
        Me.IcedCappuccinoRadioButton.Size = New System.Drawing.Size(106, 17)
        Me.IcedCappuccinoRadioButton.TabIndex = 4
        Me.IcedCappuccinoRadioButton.TabStop = True
        Me.IcedCappuccinoRadioButton.Text = "Iced Ca&ppuccino"
        Me.IcedCappuccinoRadioButton.UseVisualStyleBackColor = True
        '
        'IcedLatteRadioButton
        '
        Me.IcedLatteRadioButton.AutoSize = True
        Me.IcedLatteRadioButton.Location = New System.Drawing.Point(6, 88)
        Me.IcedLatteRadioButton.Name = "IcedLatteRadioButton"
        Me.IcedLatteRadioButton.Size = New System.Drawing.Size(73, 17)
        Me.IcedLatteRadioButton.TabIndex = 3
        Me.IcedLatteRadioButton.TabStop = True
        Me.IcedLatteRadioButton.Text = "&Iced Latte"
        Me.IcedLatteRadioButton.UseVisualStyleBackColor = True
        '
        'LatteRadioButton
        '
        Me.LatteRadioButton.AutoSize = True
        Me.LatteRadioButton.Location = New System.Drawing.Point(6, 65)
        Me.LatteRadioButton.Name = "LatteRadioButton"
        Me.LatteRadioButton.Size = New System.Drawing.Size(49, 17)
        Me.LatteRadioButton.TabIndex = 2
        Me.LatteRadioButton.TabStop = True
        Me.LatteRadioButton.Text = "La&tte"
        Me.LatteRadioButton.UseVisualStyleBackColor = True
        '
        'EspressoRadioButton
        '
        Me.EspressoRadioButton.AutoSize = True
        Me.EspressoRadioButton.Location = New System.Drawing.Point(6, 42)
        Me.EspressoRadioButton.Name = "EspressoRadioButton"
        Me.EspressoRadioButton.Size = New System.Drawing.Size(68, 17)
        Me.EspressoRadioButton.TabIndex = 1
        Me.EspressoRadioButton.TabStop = True
        Me.EspressoRadioButton.Text = "Espress&o"
        Me.EspressoRadioButton.UseVisualStyleBackColor = True
        '
        'CappuccinoRadioButton
        '
        Me.CappuccinoRadioButton.AutoSize = True
        Me.CappuccinoRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.CappuccinoRadioButton.Name = "CappuccinoRadioButton"
        Me.CappuccinoRadioButton.Size = New System.Drawing.Size(82, 17)
        Me.CappuccinoRadioButton.TabIndex = 0
        Me.CappuccinoRadioButton.TabStop = True
        Me.CappuccinoRadioButton.Text = "C&appuccino"
        Me.CappuccinoRadioButton.UseVisualStyleBackColor = True
        '
        'ItemAmountTextBox
        '
        Me.ItemAmountTextBox.Location = New System.Drawing.Point(97, 138)
        Me.ItemAmountTextBox.Name = "ItemAmountTextBox"
        Me.ItemAmountTextBox.ReadOnly = True
        Me.ItemAmountTextBox.Size = New System.Drawing.Size(68, 20)
        Me.ItemAmountTextBox.TabIndex = 6
        Me.ItemAmountTextBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ItemAmountTextBox, "Cost of Item Selected")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Item Amount"
        '
        'ClearButton
        '
        Me.ClearButton.Enabled = False
        Me.ClearButton.Location = New System.Drawing.Point(90, 78)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 41)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "C&lear for Next Item"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clears Order Selection")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(9, 78)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 41)
        Me.CalculateButton.TabIndex = 3
        Me.CalculateButton.Text = "&Calculate Selection"
        Me.ToolTip1.SetToolTip(Me.CalculateButton, "Calculate Price of Current Selection")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'TaxCheckBox
        '
        Me.TaxCheckBox.AutoSize = True
        Me.TaxCheckBox.Location = New System.Drawing.Point(41, 51)
        Me.TaxCheckBox.Name = "TaxCheckBox"
        Me.TaxCheckBox.Size = New System.Drawing.Size(72, 17)
        Me.TaxCheckBox.TabIndex = 2
        Me.TaxCheckBox.Text = "Ta&keout?"
        Me.ToolTip1.SetToolTip(Me.TaxCheckBox, "Check For Takeout Orders")
        Me.TaxCheckBox.UseVisualStyleBackColor = True
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(77, 22)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(39, 20)
        Me.QuantityTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.QuantityTextBox, "Enter Number of Items Ordered")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Quantity"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TotalTextBox)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TaxTextBox)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.SubTotalTextBox)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 208)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(362, 118)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(117, 77)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.ReadOnly = True
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalTextBox.TabIndex = 5
        Me.TotalTextBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.TotalTextBox, "Total Cost of Order")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total Due"
        '
        'TaxTextBox
        '
        Me.TaxTextBox.Location = New System.Drawing.Point(117, 53)
        Me.TaxTextBox.Name = "TaxTextBox"
        Me.TaxTextBox.ReadOnly = True
        Me.TaxTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TaxTextBox.TabIndex = 3
        Me.TaxTextBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.TaxTextBox, "Tax For Order")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tax (If Takeout)"
        '
        'SubTotalTextBox
        '
        Me.SubTotalTextBox.Location = New System.Drawing.Point(117, 28)
        Me.SubTotalTextBox.Name = "SubTotalTextBox"
        Me.SubTotalTextBox.ReadOnly = True
        Me.SubTotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SubTotalTextBox.TabIndex = 1
        Me.SubTotalTextBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.SubTotalTextBox, "Subtotal For Current Order")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "SubTotal"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(387, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewOrderToolStripMenuItem, Me.SummaryToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewOrderToolStripMenuItem
        '
        Me.NewOrderToolStripMenuItem.Enabled = False
        Me.NewOrderToolStripMenuItem.Name = "NewOrderToolStripMenuItem"
        Me.NewOrderToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.NewOrderToolStripMenuItem.Text = "&New Order"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.SummaryToolStripMenuItem.Text = "&Summary"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(128, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateSelectionToolStripMenuItem, Me.ClearItemToolStripMenuItem, Me.ToolStripSeparator2, Me.FontToolStripMenuItem, Me.CToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'CalculateSelectionToolStripMenuItem
        '
        Me.CalculateSelectionToolStripMenuItem.Name = "CalculateSelectionToolStripMenuItem"
        Me.CalculateSelectionToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.CalculateSelectionToolStripMenuItem.Text = "&Calculate Selection"
        '
        'ClearItemToolStripMenuItem
        '
        Me.ClearItemToolStripMenuItem.Enabled = False
        Me.ClearItemToolStripMenuItem.Name = "ClearItemToolStripMenuItem"
        Me.ClearItemToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ClearItemToolStripMenuItem.Text = "Clear &Item"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(171, 6)
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.FontToolStripMenuItem.Text = "&Font..."
        '
        'CToolStripMenuItem
        '
        Me.CToolStripMenuItem.Name = "CToolStripMenuItem"
        Me.CToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.CToolStripMenuItem.Text = "C&olor..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'eadfrmmain
        '
        Me.AcceptButton = Me.CalculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 344)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "eadfrmmain"
        Me.Text = "R 'n R - For Reading 'n Refreshment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents IcedCappuccinoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents IcedLatteRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents LatteRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents EspressoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CappuccinoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ItemAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents TaxCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SubTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculateSelectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
