<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.SummaryGroupBox = New System.Windows.Forms.GroupBox()
        Me.TotalNumGroupsTextBox = New System.Windows.Forms.TextBox()
        Me.AvgChargTextBox = New System.Windows.Forms.TextBox()
        Me.TotalChargesGroupsTextBox = New System.Windows.Forms.TextBox()
        Me.TotalNumGropsLabel = New System.Windows.Forms.Label()
        Me.AvgChargLabel = New System.Windows.Forms.Label()
        Me.TotalChargesSumLabel = New System.Windows.Forms.Label()
        Me.GroupNameTextBox = New System.Windows.Forms.TextBox()
        Me.MinutesUsedTextBox = New System.Windows.Forms.TextBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.CurrentGroupBox = New System.Windows.Forms.GroupBox()
        Me.MinutesUsedLabel = New System.Windows.Forms.Label()
        Me.GroupNameLabel = New System.Windows.Forms.Label()
        Me.ChargesGroupBox = New System.Windows.Forms.GroupBox()
        Me.CurrentChargesTextBox = New System.Windows.Forms.TextBox()
        Me.CurrentChargesLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SummaryGroupBox.SuspendLayout()
        Me.CurrentGroupBox.SuspendLayout()
        Me.ChargesGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SummaryGroupBox
        '
        Me.SummaryGroupBox.Controls.Add(Me.TotalNumGroupsTextBox)
        Me.SummaryGroupBox.Controls.Add(Me.AvgChargTextBox)
        Me.SummaryGroupBox.Controls.Add(Me.TotalChargesGroupsTextBox)
        Me.SummaryGroupBox.Controls.Add(Me.TotalNumGropsLabel)
        Me.SummaryGroupBox.Controls.Add(Me.AvgChargLabel)
        Me.SummaryGroupBox.Controls.Add(Me.TotalChargesSumLabel)
        Me.SummaryGroupBox.Location = New System.Drawing.Point(60, 274)
        Me.SummaryGroupBox.Name = "SummaryGroupBox"
        Me.SummaryGroupBox.Size = New System.Drawing.Size(360, 139)
        Me.SummaryGroupBox.TabIndex = 0
        Me.SummaryGroupBox.TabStop = False
        Me.SummaryGroupBox.Text = "Summary"
        '
        'TotalNumGroupsTextBox
        '
        Me.TotalNumGroupsTextBox.Location = New System.Drawing.Point(209, 102)
        Me.TotalNumGroupsTextBox.Name = "TotalNumGroupsTextBox"
        Me.TotalNumGroupsTextBox.ReadOnly = True
        Me.TotalNumGroupsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalNumGroupsTextBox.TabIndex = 5
        Me.TotalNumGroupsTextBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.TotalNumGroupsTextBox, "total number of groups entered")
        '
        'AvgChargTextBox
        '
        Me.AvgChargTextBox.Location = New System.Drawing.Point(209, 65)
        Me.AvgChargTextBox.Name = "AvgChargTextBox"
        Me.AvgChargTextBox.ReadOnly = True
        Me.AvgChargTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AvgChargTextBox.TabIndex = 4
        Me.AvgChargTextBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.AvgChargTextBox, "shows average charge price")
        '
        'TotalChargesGroupsTextBox
        '
        Me.TotalChargesGroupsTextBox.Location = New System.Drawing.Point(209, 39)
        Me.TotalChargesGroupsTextBox.Name = "TotalChargesGroupsTextBox"
        Me.TotalChargesGroupsTextBox.ReadOnly = True
        Me.TotalChargesGroupsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalChargesGroupsTextBox.TabIndex = 3
        Me.TotalChargesGroupsTextBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.TotalChargesGroupsTextBox, "shows all charges added together")
        '
        'TotalNumGropsLabel
        '
        Me.TotalNumGropsLabel.AutoSize = True
        Me.TotalNumGropsLabel.Location = New System.Drawing.Point(35, 102)
        Me.TotalNumGropsLabel.Name = "TotalNumGropsLabel"
        Me.TotalNumGropsLabel.Size = New System.Drawing.Size(123, 13)
        Me.TotalNumGropsLabel.TabIndex = 2
        Me.TotalNumGropsLabel.Text = "Total Number of Groups:"
        '
        'AvgChargLabel
        '
        Me.AvgChargLabel.AutoSize = True
        Me.AvgChargLabel.Location = New System.Drawing.Point(35, 68)
        Me.AvgChargLabel.Name = "AvgChargLabel"
        Me.AvgChargLabel.Size = New System.Drawing.Size(87, 13)
        Me.AvgChargLabel.TabIndex = 1
        Me.AvgChargLabel.Text = "Average Charge:"
        '
        'TotalChargesSumLabel
        '
        Me.TotalChargesSumLabel.AutoSize = True
        Me.TotalChargesSumLabel.Location = New System.Drawing.Point(35, 37)
        Me.TotalChargesSumLabel.Name = "TotalChargesSumLabel"
        Me.TotalChargesSumLabel.Size = New System.Drawing.Size(142, 13)
        Me.TotalChargesSumLabel.TabIndex = 0
        Me.TotalChargesSumLabel.Text = "Total Charges for All Groups:"
        '
        'GroupNameTextBox
        '
        Me.GroupNameTextBox.Location = New System.Drawing.Point(88, 22)
        Me.GroupNameTextBox.Name = "GroupNameTextBox"
        Me.GroupNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GroupNameTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.GroupNameTextBox, "enter the group name")
        '
        'MinutesUsedTextBox
        '
        Me.MinutesUsedTextBox.Location = New System.Drawing.Point(87, 62)
        Me.MinutesUsedTextBox.Name = "MinutesUsedTextBox"
        Me.MinutesUsedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MinutesUsedTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.MinutesUsedTextBox, "enter minutes used")
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(227, 40)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 3
        Me.CalculateButton.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.CalculateButton, "Perform Calculations")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(60, 419)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "Clea&r"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear all data")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(206, 419)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 5
        Me.PrintButton.Text = "&Print"
        Me.ToolTip1.SetToolTip(Me.PrintButton, "not availble in 2015")
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(345, 419)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "&Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "close the program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(162, 22)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(132, 24)
        Me.TitleLabel.TabIndex = 7
        Me.TitleLabel.Text = "Doug's Studio "
        '
        'CurrentGroupBox
        '
        Me.CurrentGroupBox.Controls.Add(Me.MinutesUsedLabel)
        Me.CurrentGroupBox.Controls.Add(Me.GroupNameLabel)
        Me.CurrentGroupBox.Controls.Add(Me.MinutesUsedTextBox)
        Me.CurrentGroupBox.Controls.Add(Me.GroupNameTextBox)
        Me.CurrentGroupBox.Controls.Add(Me.CalculateButton)
        Me.CurrentGroupBox.Location = New System.Drawing.Point(57, 62)
        Me.CurrentGroupBox.Name = "CurrentGroupBox"
        Me.CurrentGroupBox.Size = New System.Drawing.Size(360, 100)
        Me.CurrentGroupBox.TabIndex = 8
        Me.CurrentGroupBox.TabStop = False
        '
        'MinutesUsedLabel
        '
        Me.MinutesUsedLabel.AutoSize = True
        Me.MinutesUsedLabel.Location = New System.Drawing.Point(6, 65)
        Me.MinutesUsedLabel.Name = "MinutesUsedLabel"
        Me.MinutesUsedLabel.Size = New System.Drawing.Size(72, 13)
        Me.MinutesUsedLabel.TabIndex = 4
        Me.MinutesUsedLabel.Text = "Minutes Used"
        '
        'GroupNameLabel
        '
        Me.GroupNameLabel.AutoSize = True
        Me.GroupNameLabel.Location = New System.Drawing.Point(7, 25)
        Me.GroupNameLabel.Name = "GroupNameLabel"
        Me.GroupNameLabel.Size = New System.Drawing.Size(67, 13)
        Me.GroupNameLabel.TabIndex = 3
        Me.GroupNameLabel.Text = "Group Name"
        '
        'ChargesGroupBox
        '
        Me.ChargesGroupBox.Controls.Add(Me.CurrentChargesTextBox)
        Me.ChargesGroupBox.Controls.Add(Me.CurrentChargesLabel)
        Me.ChargesGroupBox.Location = New System.Drawing.Point(145, 168)
        Me.ChargesGroupBox.Name = "ChargesGroupBox"
        Me.ChargesGroupBox.Size = New System.Drawing.Size(174, 100)
        Me.ChargesGroupBox.TabIndex = 9
        Me.ChargesGroupBox.TabStop = False
        '
        'CurrentChargesTextBox
        '
        Me.CurrentChargesTextBox.Location = New System.Drawing.Point(21, 45)
        Me.CurrentChargesTextBox.Name = "CurrentChargesTextBox"
        Me.CurrentChargesTextBox.ReadOnly = True
        Me.CurrentChargesTextBox.Size = New System.Drawing.Size(115, 20)
        Me.CurrentChargesTextBox.TabIndex = 1
        Me.CurrentChargesTextBox.TabStop = False
        Me.CurrentChargesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.CurrentChargesTextBox, "displays current group charges")
        '
        'CurrentChargesLabel
        '
        Me.CurrentChargesLabel.AutoSize = True
        Me.CurrentChargesLabel.Location = New System.Drawing.Point(18, 16)
        Me.CurrentChargesLabel.Name = "CurrentChargesLabel"
        Me.CurrentChargesLabel.Size = New System.Drawing.Size(118, 13)
        Me.CurrentChargesLabel.TabIndex = 0
        Me.CurrentChargesLabel.Text = "Current Group Charges:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 454)
        Me.Controls.Add(Me.ChargesGroupBox)
        Me.Controls.Add(Me.CurrentGroupBox)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SummaryGroupBox)
        Me.Name = "Form1"
        Me.Text = "Recording Studio Charges"
        Me.SummaryGroupBox.ResumeLayout(False)
        Me.SummaryGroupBox.PerformLayout()
        Me.CurrentGroupBox.ResumeLayout(False)
        Me.CurrentGroupBox.PerformLayout()
        Me.ChargesGroupBox.ResumeLayout(False)
        Me.ChargesGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SummaryGroupBox As GroupBox
    Friend WithEvents GroupNameTextBox As TextBox
    Friend WithEvents MinutesUsedTextBox As TextBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents TitleLabel As Label
    Friend WithEvents CurrentGroupBox As GroupBox
    Friend WithEvents MinutesUsedLabel As Label
    Friend WithEvents GroupNameLabel As Label
    Friend WithEvents ChargesGroupBox As GroupBox
    Friend WithEvents CurrentChargesTextBox As TextBox
    Friend WithEvents CurrentChargesLabel As Label
    Friend WithEvents TotalNumGroupsTextBox As TextBox
    Friend WithEvents AvgChargTextBox As TextBox
    Friend WithEvents TotalChargesGroupsTextBox As TextBox
    Friend WithEvents TotalNumGropsLabel As Label
    Friend WithEvents AvgChargLabel As Label
    Friend WithEvents TotalChargesSumLabel As Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
