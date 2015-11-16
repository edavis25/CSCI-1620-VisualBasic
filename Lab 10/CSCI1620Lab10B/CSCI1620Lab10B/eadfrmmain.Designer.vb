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
        Dim InventoryIDLabel As System.Windows.Forms.Label
        Dim ManufacturerLabel As System.Windows.Forms.Label
        Dim ModelNameLabel As System.Windows.Forms.Label
        Dim YearLabel As System.Windows.Forms.Label
        Dim VehicleIDLabel As System.Windows.Forms.Label
        Dim CostValueLabel As System.Windows.Forms.Label
        Me.VBAutoDataSet = New CSCI1620Lab10B.VBAutoDataSet()
        Me.VehicleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehicleTableAdapter = New CSCI1620Lab10B.VBAutoDataSetTableAdapters.VehicleTableAdapter()
        Me.TableAdapterManager = New CSCI1620Lab10B.VBAutoDataSetTableAdapters.TableAdapterManager()
        Me.InventoryIDComboBox = New System.Windows.Forms.ComboBox()
        Me.ManufacturerTextBox = New System.Windows.Forms.TextBox()
        Me.ModelNameTextBox = New System.Windows.Forms.TextBox()
        Me.YearTextBox = New System.Windows.Forms.TextBox()
        Me.VehicleIDTextBox = New System.Windows.Forms.TextBox()
        Me.CostValueTextBox = New System.Windows.Forms.TextBox()
        InventoryIDLabel = New System.Windows.Forms.Label()
        ManufacturerLabel = New System.Windows.Forms.Label()
        ModelNameLabel = New System.Windows.Forms.Label()
        YearLabel = New System.Windows.Forms.Label()
        VehicleIDLabel = New System.Windows.Forms.Label()
        CostValueLabel = New System.Windows.Forms.Label()
        CType(Me.VBAutoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InventoryIDLabel
        '
        InventoryIDLabel.AutoSize = True
        InventoryIDLabel.Location = New System.Drawing.Point(25, 24)
        InventoryIDLabel.Name = "InventoryIDLabel"
        InventoryIDLabel.Size = New System.Drawing.Size(68, 13)
        InventoryIDLabel.TabIndex = 1
        InventoryIDLabel.Text = "Inventory ID:"
        '
        'ManufacturerLabel
        '
        ManufacturerLabel.AutoSize = True
        ManufacturerLabel.Location = New System.Drawing.Point(25, 75)
        ManufacturerLabel.Name = "ManufacturerLabel"
        ManufacturerLabel.Size = New System.Drawing.Size(73, 13)
        ManufacturerLabel.TabIndex = 3
        ManufacturerLabel.Text = "Manufacturer:"
        '
        'ModelNameLabel
        '
        ModelNameLabel.AutoSize = True
        ModelNameLabel.Location = New System.Drawing.Point(25, 101)
        ModelNameLabel.Name = "ModelNameLabel"
        ModelNameLabel.Size = New System.Drawing.Size(70, 13)
        ModelNameLabel.TabIndex = 5
        ModelNameLabel.Text = "Model Name:"
        '
        'YearLabel
        '
        YearLabel.AutoSize = True
        YearLabel.Location = New System.Drawing.Point(25, 127)
        YearLabel.Name = "YearLabel"
        YearLabel.Size = New System.Drawing.Size(32, 13)
        YearLabel.TabIndex = 7
        YearLabel.Text = "Year:"
        '
        'VehicleIDLabel
        '
        VehicleIDLabel.AutoSize = True
        VehicleIDLabel.Location = New System.Drawing.Point(25, 153)
        VehicleIDLabel.Name = "VehicleIDLabel"
        VehicleIDLabel.Size = New System.Drawing.Size(59, 13)
        VehicleIDLabel.TabIndex = 9
        VehicleIDLabel.Text = "Vehicle ID:"
        '
        'CostValueLabel
        '
        CostValueLabel.AutoSize = True
        CostValueLabel.Location = New System.Drawing.Point(25, 179)
        CostValueLabel.Name = "CostValueLabel"
        CostValueLabel.Size = New System.Drawing.Size(61, 13)
        CostValueLabel.TabIndex = 11
        CostValueLabel.Text = "Cost Value:"
        '
        'VBAutoDataSet
        '
        Me.VBAutoDataSet.DataSetName = "VBAutoDataSet"
        Me.VBAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VehicleBindingSource
        '
        Me.VehicleBindingSource.DataMember = "Vehicle"
        Me.VehicleBindingSource.DataSource = Me.VBAutoDataSet
        '
        'VehicleTableAdapter
        '
        Me.VehicleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = CSCI1620Lab10B.VBAutoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VehicleTableAdapter = Me.VehicleTableAdapter
        '
        'InventoryIDComboBox
        '
        Me.InventoryIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehicleBindingSource, "InventoryID", True))
        Me.InventoryIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VehicleBindingSource, "InventoryID", True))
        Me.InventoryIDComboBox.DataSource = Me.VehicleBindingSource
        Me.InventoryIDComboBox.DisplayMember = "InventoryID"
        Me.InventoryIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.InventoryIDComboBox.FormattingEnabled = True
        Me.InventoryIDComboBox.Location = New System.Drawing.Point(104, 21)
        Me.InventoryIDComboBox.Name = "InventoryIDComboBox"
        Me.InventoryIDComboBox.Size = New System.Drawing.Size(89, 21)
        Me.InventoryIDComboBox.TabIndex = 2
        '
        'ManufacturerTextBox
        '
        Me.ManufacturerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehicleBindingSource, "Manufacturer", True))
        Me.ManufacturerTextBox.Location = New System.Drawing.Point(104, 72)
        Me.ManufacturerTextBox.Name = "ManufacturerTextBox"
        Me.ManufacturerTextBox.ReadOnly = True
        Me.ManufacturerTextBox.Size = New System.Drawing.Size(121, 20)
        Me.ManufacturerTextBox.TabIndex = 4
        '
        'ModelNameTextBox
        '
        Me.ModelNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehicleBindingSource, "ModelName", True))
        Me.ModelNameTextBox.Location = New System.Drawing.Point(104, 98)
        Me.ModelNameTextBox.Name = "ModelNameTextBox"
        Me.ModelNameTextBox.ReadOnly = True
        Me.ModelNameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.ModelNameTextBox.TabIndex = 6
        '
        'YearTextBox
        '
        Me.YearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehicleBindingSource, "Year", True))
        Me.YearTextBox.Location = New System.Drawing.Point(104, 124)
        Me.YearTextBox.Name = "YearTextBox"
        Me.YearTextBox.ReadOnly = True
        Me.YearTextBox.Size = New System.Drawing.Size(121, 20)
        Me.YearTextBox.TabIndex = 8
        '
        'VehicleIDTextBox
        '
        Me.VehicleIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehicleBindingSource, "VehicleID", True))
        Me.VehicleIDTextBox.Location = New System.Drawing.Point(104, 150)
        Me.VehicleIDTextBox.Name = "VehicleIDTextBox"
        Me.VehicleIDTextBox.ReadOnly = True
        Me.VehicleIDTextBox.Size = New System.Drawing.Size(121, 20)
        Me.VehicleIDTextBox.TabIndex = 10
        '
        'CostValueTextBox
        '
        Me.CostValueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehicleBindingSource, "CostValue", True))
        Me.CostValueTextBox.Location = New System.Drawing.Point(104, 176)
        Me.CostValueTextBox.Name = "CostValueTextBox"
        Me.CostValueTextBox.ReadOnly = True
        Me.CostValueTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CostValueTextBox.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 221)
        Me.Controls.Add(InventoryIDLabel)
        Me.Controls.Add(Me.InventoryIDComboBox)
        Me.Controls.Add(ManufacturerLabel)
        Me.Controls.Add(Me.ManufacturerTextBox)
        Me.Controls.Add(ModelNameLabel)
        Me.Controls.Add(Me.ModelNameTextBox)
        Me.Controls.Add(YearLabel)
        Me.Controls.Add(Me.YearTextBox)
        Me.Controls.Add(VehicleIDLabel)
        Me.Controls.Add(Me.VehicleIDTextBox)
        Me.Controls.Add(CostValueLabel)
        Me.Controls.Add(Me.CostValueTextBox)
        Me.Name = "Form1"
        Me.Text = "VB Auto Center"
        CType(Me.VBAutoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VBAutoDataSet As CSCI1620Lab10B.VBAutoDataSet
    Friend WithEvents VehicleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VehicleTableAdapter As CSCI1620Lab10B.VBAutoDataSetTableAdapters.VehicleTableAdapter
    Friend WithEvents TableAdapterManager As CSCI1620Lab10B.VBAutoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InventoryIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ManufacturerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ModelNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents YearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VehicleIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostValueTextBox As System.Windows.Forms.TextBox

End Class
