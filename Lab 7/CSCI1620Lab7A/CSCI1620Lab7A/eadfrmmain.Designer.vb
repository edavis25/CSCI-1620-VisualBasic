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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(eadfrmmain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSelectedFlavorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviewSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintAllFlavorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviewAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCoffeeFlavorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveCoffeeFlavorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearCoffeeListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayCoffeeCountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SyrupListBox = New System.Windows.Forms.ListBox()
        Me.CoffeeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintAllPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintSelectedPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(345, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintSelectedFlavorsToolStripMenuItem, Me.PrintAllFlavorsToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrintSelectedFlavorsToolStripMenuItem
        '
        Me.PrintSelectedFlavorsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintSelectedToolStripMenuItem, Me.PreviewSelectedToolStripMenuItem})
        Me.PrintSelectedFlavorsToolStripMenuItem.Name = "PrintSelectedFlavorsToolStripMenuItem"
        Me.PrintSelectedFlavorsToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.PrintSelectedFlavorsToolStripMenuItem.Text = "Print &Selected Flavors"
        '
        'PrintSelectedToolStripMenuItem
        '
        Me.PrintSelectedToolStripMenuItem.Name = "PrintSelectedToolStripMenuItem"
        Me.PrintSelectedToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.PrintSelectedToolStripMenuItem.Text = "&Print Selected"
        '
        'PreviewSelectedToolStripMenuItem
        '
        Me.PreviewSelectedToolStripMenuItem.Name = "PreviewSelectedToolStripMenuItem"
        Me.PreviewSelectedToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.PreviewSelectedToolStripMenuItem.Text = "Pre&view Selected"
        '
        'PrintAllFlavorsToolStripMenuItem
        '
        Me.PrintAllFlavorsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintAllToolStripMenuItem, Me.PreviewAllToolStripMenuItem})
        Me.PrintAllFlavorsToolStripMenuItem.Name = "PrintAllFlavorsToolStripMenuItem"
        Me.PrintAllFlavorsToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.PrintAllFlavorsToolStripMenuItem.Text = "Print &All Flavors"
        '
        'PrintAllToolStripMenuItem
        '
        Me.PrintAllToolStripMenuItem.Name = "PrintAllToolStripMenuItem"
        Me.PrintAllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintAllToolStripMenuItem.Text = "&Print All"
        '
        'PreviewAllToolStripMenuItem
        '
        Me.PreviewAllToolStripMenuItem.Name = "PreviewAllToolStripMenuItem"
        Me.PreviewAllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PreviewAllToolStripMenuItem.Text = "Pre&view All"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(183, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCoffeeFlavorToolStripMenuItem, Me.RemoveCoffeeFlavorToolStripMenuItem, Me.ClearCoffeeListToolStripMenuItem, Me.DisplayCoffeeCountToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'AddCoffeeFlavorToolStripMenuItem
        '
        Me.AddCoffeeFlavorToolStripMenuItem.Name = "AddCoffeeFlavorToolStripMenuItem"
        Me.AddCoffeeFlavorToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.AddCoffeeFlavorToolStripMenuItem.Text = "&Add Coffee Flavor"
        '
        'RemoveCoffeeFlavorToolStripMenuItem
        '
        Me.RemoveCoffeeFlavorToolStripMenuItem.Name = "RemoveCoffeeFlavorToolStripMenuItem"
        Me.RemoveCoffeeFlavorToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.RemoveCoffeeFlavorToolStripMenuItem.Text = "&Remove Coffee Flavor"
        '
        'ClearCoffeeListToolStripMenuItem
        '
        Me.ClearCoffeeListToolStripMenuItem.Name = "ClearCoffeeListToolStripMenuItem"
        Me.ClearCoffeeListToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ClearCoffeeListToolStripMenuItem.Text = "&Clear Coffee List"
        '
        'DisplayCoffeeCountToolStripMenuItem
        '
        Me.DisplayCoffeeCountToolStripMenuItem.Name = "DisplayCoffeeCountToolStripMenuItem"
        Me.DisplayCoffeeCountToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.DisplayCoffeeCountToolStripMenuItem.Text = "&Display Coffee Count"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SyrupListBox)
        Me.GroupBox1.Controls.Add(Me.CoffeeComboBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 132)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Coffee and Syrup"
        '
        'SyrupListBox
        '
        Me.SyrupListBox.FormattingEnabled = True
        Me.SyrupListBox.Items.AddRange(New Object() {"(None)", "Chocolate", "Hazelnut", "Irish Cream", "Orange"})
        Me.SyrupListBox.Location = New System.Drawing.Point(215, 49)
        Me.SyrupListBox.Name = "SyrupListBox"
        Me.SyrupListBox.Size = New System.Drawing.Size(86, 69)
        Me.SyrupListBox.Sorted = True
        Me.SyrupListBox.TabIndex = 3
        '
        'CoffeeComboBox
        '
        Me.CoffeeComboBox.FormattingEnabled = True
        Me.CoffeeComboBox.Items.AddRange(New Object() {"Chocolate Almond", "Espresso Roast", "Jamaica Blue Mountain", "Kona Blend", "Vanilla Nut"})
        Me.CoffeeComboBox.Location = New System.Drawing.Point(30, 52)
        Me.CoffeeComboBox.Name = "CoffeeComboBox"
        Me.CoffeeComboBox.Size = New System.Drawing.Size(145, 21)
        Me.CoffeeComboBox.Sorted = True
        Me.CoffeeComboBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(212, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Syrup Flavor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Coffee Flavor"
        '
        'PrintAllPrintDocument
        '
        '
        'PrintSelectedPrintDocument
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'eadfrmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 184)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "eadfrmmain"
        Me.Text = "R 'n R for Reading 'n Refreshment"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSelectedFlavorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreviewSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintAllFlavorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreviewAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddCoffeeFlavorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveCoffeeFlavorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearCoffeeListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayCoffeeCountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SyrupListBox As System.Windows.Forms.ListBox
    Friend WithEvents CoffeeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrintAllPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintSelectedPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog

End Class
