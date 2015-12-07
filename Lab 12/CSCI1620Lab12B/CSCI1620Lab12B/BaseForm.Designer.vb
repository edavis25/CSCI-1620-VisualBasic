<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaseForm
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
        Me.WhiteLineLabel = New System.Windows.Forms.Label()
        Me.BlueLineLabel = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(34, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Top Pay for Top Salespersons!"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(15, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 10)
        Me.Label2.TabIndex = 1
        '
        'WhiteLineLabel
        '
        Me.WhiteLineLabel.BackColor = System.Drawing.Color.White
        Me.WhiteLineLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WhiteLineLabel.Location = New System.Drawing.Point(45, 75)
        Me.WhiteLineLabel.Name = "WhiteLineLabel"
        Me.WhiteLineLabel.Size = New System.Drawing.Size(250, 10)
        Me.WhiteLineLabel.TabIndex = 2
        '
        'BlueLineLabel
        '
        Me.BlueLineLabel.BackColor = System.Drawing.Color.Blue
        Me.BlueLineLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BlueLineLabel.Location = New System.Drawing.Point(75, 80)
        Me.BlueLineLabel.Name = "BlueLineLabel"
        Me.BlueLineLabel.Size = New System.Drawing.Size(250, 10)
        Me.BlueLineLabel.TabIndex = 3
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(124, 237)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 4
        Me.OKButton.Text = "&OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'BaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 297)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.BlueLineLabel)
        Me.Controls.Add(Me.WhiteLineLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BaseForm"
        Me.Text = "BaseForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents WhiteLineLabel As System.Windows.Forms.Label
    Friend WithEvents BlueLineLabel As System.Windows.Forms.Label
    Friend WithEvents OKButton As System.Windows.Forms.Button
End Class
