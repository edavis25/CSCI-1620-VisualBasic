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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(eadfrmmain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSubjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.BookTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.FictionRadioButton = New System.Windows.Forms.RadioButton()
        Me.NonFictionRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubjectComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ShelfNumberListBox = New System.Windows.Forms.ListBox()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.PrintAllSubjectsPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintSelectedPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.BookTypeGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(279, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintSubjectsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrintSubjectsToolStripMenuItem
        '
        Me.PrintSubjectsToolStripMenuItem.Name = "PrintSubjectsToolStripMenuItem"
        Me.PrintSubjectsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintSubjectsToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.PrintSubjectsToolStripMenuItem.Text = "&Print Subjects"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
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
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Author"
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.Location = New System.Drawing.Point(116, 36)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(127, 20)
        Me.AuthorTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.AuthorTextBox, "Enter author's name")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "&Title"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Location = New System.Drawing.Point(116, 61)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(127, 20)
        Me.TitleTextBox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.TitleTextBox, "Enter title of the book")
        '
        'BookTypeGroupBox
        '
        Me.BookTypeGroupBox.Controls.Add(Me.NonFictionRadioButton)
        Me.BookTypeGroupBox.Controls.Add(Me.FictionRadioButton)
        Me.BookTypeGroupBox.Location = New System.Drawing.Point(12, 101)
        Me.BookTypeGroupBox.Name = "BookTypeGroupBox"
        Me.BookTypeGroupBox.Size = New System.Drawing.Size(95, 74)
        Me.BookTypeGroupBox.TabIndex = 5
        Me.BookTypeGroupBox.TabStop = False
        Me.BookTypeGroupBox.Text = "Type"
        Me.ToolTip1.SetToolTip(Me.BookTypeGroupBox, "Select type of book")
        '
        'FictionRadioButton
        '
        Me.FictionRadioButton.AutoSize = True
        Me.FictionRadioButton.Location = New System.Drawing.Point(7, 20)
        Me.FictionRadioButton.Name = "FictionRadioButton"
        Me.FictionRadioButton.Size = New System.Drawing.Size(56, 17)
        Me.FictionRadioButton.TabIndex = 0
        Me.FictionRadioButton.TabStop = True
        Me.FictionRadioButton.Text = "Fiction"
        Me.FictionRadioButton.UseVisualStyleBackColor = True
        '
        'NonFictionRadioButton
        '
        Me.NonFictionRadioButton.AutoSize = True
        Me.NonFictionRadioButton.Location = New System.Drawing.Point(7, 43)
        Me.NonFictionRadioButton.Name = "NonFictionRadioButton"
        Me.NonFictionRadioButton.Size = New System.Drawing.Size(73, 17)
        Me.NonFictionRadioButton.TabIndex = 1
        Me.NonFictionRadioButton.TabStop = True
        Me.NonFictionRadioButton.Text = "Nonfiction"
        Me.NonFictionRadioButton.UseVisualStyleBackColor = True
        '
        'SubjectComboBox
        '
        Me.SubjectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SubjectComboBox.FormattingEnabled = True
        Me.SubjectComboBox.Items.AddRange(New Object() {"Best-Seller", "Business", "Education", "Fantasy", "Humor", "Mystery", "Philosophy", "Religion", "Romance", "Science Fiction", "Self-Help"})
        Me.SubjectComboBox.Location = New System.Drawing.Point(143, 121)
        Me.SubjectComboBox.Name = "SubjectComboBox"
        Me.SubjectComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SubjectComboBox.Sorted = True
        Me.SubjectComboBox.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.SubjectComboBox, "Select subject of the book")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(140, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "&Subject"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(140, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Shelf N&umber"
        '
        'ShelfNumberListBox
        '
        Me.ShelfNumberListBox.FormattingEnabled = True
        Me.ShelfNumberListBox.Items.AddRange(New Object() {"RC-1111", "RC-1112", "RC-1113", "RC-1114"})
        Me.ShelfNumberListBox.Location = New System.Drawing.Point(143, 178)
        Me.ShelfNumberListBox.Name = "ShelfNumberListBox"
        Me.ShelfNumberListBox.Size = New System.Drawing.Size(68, 56)
        Me.ShelfNumberListBox.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.ShelfNumberListBox, "Select the book's shelf number")
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(43, 259)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(88, 23)
        Me.PrintButton.TabIndex = 10
        Me.PrintButton.Text = "&Print"
        Me.ToolTip1.SetToolTip(Me.PrintButton, "Preview selected book information")
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(155, 259)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(88, 23)
        Me.OKButton.TabIndex = 11
        Me.OKButton.Text = "&OK"
        Me.ToolTip1.SetToolTip(Me.OKButton, "Clear all input fields")
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'PrintAllSubjectsPrintDocument
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
        'PrintSelectedPrintDocument
        '
        '
        'eadfrmmain
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 294)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ShelfNumberListBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SubjectComboBox)
        Me.Controls.Add(Me.BookTypeGroupBox)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AuthorTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "eadfrmmain"
        Me.Text = "R 'n R - For Reading 'n Refreshment"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.BookTypeGroupBox.ResumeLayout(False)
        Me.BookTypeGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSubjectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AuthorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BookTypeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents NonFictionRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents FictionRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SubjectComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ShelfNumberListBox As System.Windows.Forms.ListBox
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents PrintAllSubjectsPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintSelectedPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
