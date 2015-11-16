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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DepartureComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DestinationComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DistanceTextBox = New System.Windows.Forms.TextBox()
        Me.DistanceButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "De&parture"
        '
        'DepartureComboBox
        '
        Me.DepartureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartureComboBox.FormattingEnabled = True
        Me.DepartureComboBox.Items.AddRange(New Object() {"Boston", "Chicago", "Dallas", "Las Vegas", "Los Angeles", "Miami", "New Orleans", "Toronto", "Vancouver", "Washington DC"})
        Me.DepartureComboBox.Location = New System.Drawing.Point(30, 37)
        Me.DepartureComboBox.Name = "DepartureComboBox"
        Me.DepartureComboBox.Size = New System.Drawing.Size(101, 21)
        Me.DepartureComboBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(174, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "De&stination"
        '
        'DestinationComboBox
        '
        Me.DestinationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DestinationComboBox.FormattingEnabled = True
        Me.DestinationComboBox.Items.AddRange(New Object() {"Boston", "Chicago", "Dallas", "Las Vegas", "Los Angeles", "Miami", "New Orleans", "Toronto", "Vancouver", "Washington DC"})
        Me.DestinationComboBox.Location = New System.Drawing.Point(166, 37)
        Me.DestinationComboBox.Name = "DestinationComboBox"
        Me.DestinationComboBox.Size = New System.Drawing.Size(101, 21)
        Me.DestinationComboBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Distance in Miles:"
        '
        'DistanceTextBox
        '
        Me.DistanceTextBox.Location = New System.Drawing.Point(166, 79)
        Me.DistanceTextBox.Name = "DistanceTextBox"
        Me.DistanceTextBox.ReadOnly = True
        Me.DistanceTextBox.Size = New System.Drawing.Size(76, 20)
        Me.DistanceTextBox.TabIndex = 5
        Me.DistanceTextBox.TabStop = False
        '
        'DistanceButton
        '
        Me.DistanceButton.Location = New System.Drawing.Point(30, 122)
        Me.DistanceButton.Name = "DistanceButton"
        Me.DistanceButton.Size = New System.Drawing.Size(75, 23)
        Me.DistanceButton.TabIndex = 6
        Me.DistanceButton.Text = "&Distance"
        Me.DistanceButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(111, 122)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 7
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(192, 122)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'eadfrmmain
        '
        Me.AcceptButton = Me.DistanceButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(297, 161)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DistanceButton)
        Me.Controls.Add(Me.DistanceTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DestinationComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DepartureComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "eadfrmmain"
        Me.Text = "Driving Distance Lookup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DepartureComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DestinationComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DistanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DistanceButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button

End Class
