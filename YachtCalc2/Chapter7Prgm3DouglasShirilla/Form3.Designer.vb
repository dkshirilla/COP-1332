<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResForm
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
        Me.PartyLabel = New System.Windows.Forms.Label()
        Me.HoursLabel = New System.Windows.Forms.Label()
        Me.YachtSizeLabel = New System.Windows.Forms.Label()
        Me.YachtTypeLabel = New System.Windows.Forms.Label()
        Me.CostLabel = New System.Windows.Forms.Label()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.TextParBox = New System.Windows.Forms.TextBox()
        Me.TextHoursBox = New System.Windows.Forms.TextBox()
        Me.TextSizeBox = New System.Windows.Forms.TextBox()
        Me.TextTypeBox = New System.Windows.Forms.TextBox()
        Me.TextCostBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'PartyLabel
        '
        Me.PartyLabel.AutoSize = True
        Me.PartyLabel.Location = New System.Drawing.Point(12, 31)
        Me.PartyLabel.Name = "PartyLabel"
        Me.PartyLabel.Size = New System.Drawing.Size(34, 13)
        Me.PartyLabel.TabIndex = 0
        Me.PartyLabel.Text = "Party:"
        '
        'HoursLabel
        '
        Me.HoursLabel.AutoSize = True
        Me.HoursLabel.Location = New System.Drawing.Point(12, 58)
        Me.HoursLabel.Name = "HoursLabel"
        Me.HoursLabel.Size = New System.Drawing.Size(38, 13)
        Me.HoursLabel.TabIndex = 1
        Me.HoursLabel.Text = "Hours:"
        '
        'YachtSizeLabel
        '
        Me.YachtSizeLabel.AutoSize = True
        Me.YachtSizeLabel.Location = New System.Drawing.Point(12, 87)
        Me.YachtSizeLabel.Name = "YachtSizeLabel"
        Me.YachtSizeLabel.Size = New System.Drawing.Size(61, 13)
        Me.YachtSizeLabel.TabIndex = 2
        Me.YachtSizeLabel.Text = "Yacht Size:"
        '
        'YachtTypeLabel
        '
        Me.YachtTypeLabel.AutoSize = True
        Me.YachtTypeLabel.Location = New System.Drawing.Point(12, 116)
        Me.YachtTypeLabel.Name = "YachtTypeLabel"
        Me.YachtTypeLabel.Size = New System.Drawing.Size(65, 13)
        Me.YachtTypeLabel.TabIndex = 3
        Me.YachtTypeLabel.Text = "Yacht Type:"
        '
        'CostLabel
        '
        Me.CostLabel.AutoSize = True
        Me.CostLabel.Location = New System.Drawing.Point(12, 145)
        Me.CostLabel.Name = "CostLabel"
        Me.CostLabel.Size = New System.Drawing.Size(31, 13)
        Me.CostLabel.TabIndex = 4
        Me.CostLabel.Text = "Cost:"
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(34, 211)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(75, 23)
        Me.NextButton.TabIndex = 0
        Me.NextButton.Text = "Ne&xt"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(168, 211)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "Ex&it"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'TextParBox
        '
        Me.TextParBox.Location = New System.Drawing.Point(80, 31)
        Me.TextParBox.Name = "TextParBox"
        Me.TextParBox.ReadOnly = True
        Me.TextParBox.Size = New System.Drawing.Size(100, 20)
        Me.TextParBox.TabIndex = 7
        Me.TextParBox.TabStop = False
        '
        'TextHoursBox
        '
        Me.TextHoursBox.Location = New System.Drawing.Point(80, 58)
        Me.TextHoursBox.Name = "TextHoursBox"
        Me.TextHoursBox.ReadOnly = True
        Me.TextHoursBox.Size = New System.Drawing.Size(100, 20)
        Me.TextHoursBox.TabIndex = 8
        Me.TextHoursBox.TabStop = False
        '
        'TextSizeBox
        '
        Me.TextSizeBox.Location = New System.Drawing.Point(80, 87)
        Me.TextSizeBox.Name = "TextSizeBox"
        Me.TextSizeBox.ReadOnly = True
        Me.TextSizeBox.Size = New System.Drawing.Size(100, 20)
        Me.TextSizeBox.TabIndex = 9
        Me.TextSizeBox.TabStop = False
        '
        'TextTypeBox
        '
        Me.TextTypeBox.Location = New System.Drawing.Point(80, 114)
        Me.TextTypeBox.Name = "TextTypeBox"
        Me.TextTypeBox.ReadOnly = True
        Me.TextTypeBox.Size = New System.Drawing.Size(100, 20)
        Me.TextTypeBox.TabIndex = 10
        Me.TextTypeBox.TabStop = False
        '
        'TextCostBox
        '
        Me.TextCostBox.Location = New System.Drawing.Point(80, 145)
        Me.TextCostBox.Name = "TextCostBox"
        Me.TextCostBox.ReadOnly = True
        Me.TextCostBox.Size = New System.Drawing.Size(100, 20)
        Me.TextCostBox.TabIndex = 11
        Me.TextCostBox.TabStop = False
        '
        'ResForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.TextCostBox)
        Me.Controls.Add(Me.TextTypeBox)
        Me.Controls.Add(Me.TextSizeBox)
        Me.Controls.Add(Me.TextHoursBox)
        Me.Controls.Add(Me.TextParBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.CostLabel)
        Me.Controls.Add(Me.YachtTypeLabel)
        Me.Controls.Add(Me.YachtSizeLabel)
        Me.Controls.Add(Me.HoursLabel)
        Me.Controls.Add(Me.PartyLabel)
        Me.Name = "ResForm"
        Me.Text = "Reservation Database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PartyLabel As System.Windows.Forms.Label
    Friend WithEvents HoursLabel As System.Windows.Forms.Label
    Friend WithEvents YachtSizeLabel As System.Windows.Forms.Label
    Friend WithEvents YachtTypeLabel As System.Windows.Forms.Label
    Friend WithEvents CostLabel As System.Windows.Forms.Label
    Friend WithEvents NextButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents TextParBox As System.Windows.Forms.TextBox
    Friend WithEvents TextHoursBox As System.Windows.Forms.TextBox
    Friend WithEvents TextSizeBox As System.Windows.Forms.TextBox
    Friend WithEvents TextTypeBox As System.Windows.Forms.TextBox
    Friend WithEvents TextCostBox As System.Windows.Forms.TextBox
End Class
