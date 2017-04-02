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
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.CountryListBox = New System.Windows.Forms.GroupBox()
        Me.RebelRadio = New System.Windows.Forms.RadioButton()
        Me.RussiaRadio = New System.Windows.Forms.RadioButton()
        Me.IrelandRadio = New System.Windows.Forms.RadioButton()
        Me.PolandRadio = New System.Windows.Forms.RadioButton()
        Me.UnitedStatesRadio = New System.Windows.Forms.RadioButton()
        Me.DisplayBox = New System.Windows.Forms.GroupBox()
        Me.ProgrammerBox = New System.Windows.Forms.CheckBox()
        Me.CountryNameBox = New System.Windows.Forms.CheckBox()
        Me.TitleBox = New System.Windows.Forms.CheckBox()
        Me.ProgNameLabel = New System.Windows.Forms.Label()
        Me.ProgmrBox = New System.Windows.Forms.GroupBox()
        Me.ApplyAllButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.CountryTitleBox = New System.Windows.Forms.GroupBox()
        Me.CountryNameLabel = New System.Windows.Forms.Label()
        Me.FlagPictureBox = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.CountryListBox.SuspendLayout()
        Me.DisplayBox.SuspendLayout()
        Me.ProgmrBox.SuspendLayout()
        Me.CountryTitleBox.SuspendLayout()
        CType(Me.FlagPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(199, 9)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(125, 24)
        Me.TitleLabel.TabIndex = 1
        Me.TitleLabel.Text = "Flag Viewer"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CountryListBox
        '
        Me.CountryListBox.Controls.Add(Me.RebelRadio)
        Me.CountryListBox.Controls.Add(Me.RussiaRadio)
        Me.CountryListBox.Controls.Add(Me.IrelandRadio)
        Me.CountryListBox.Controls.Add(Me.PolandRadio)
        Me.CountryListBox.Controls.Add(Me.UnitedStatesRadio)
        Me.CountryListBox.Location = New System.Drawing.Point(24, 50)
        Me.CountryListBox.Name = "CountryListBox"
        Me.CountryListBox.Size = New System.Drawing.Size(111, 141)
        Me.CountryListBox.TabIndex = 0
        Me.CountryListBox.TabStop = False
        Me.CountryListBox.Text = "Country"
        '
        'RebelRadio
        '
        Me.RebelRadio.AutoSize = True
        Me.RebelRadio.Location = New System.Drawing.Point(7, 112)
        Me.RebelRadio.Name = "RebelRadio"
        Me.RebelRadio.Size = New System.Drawing.Size(93, 17)
        Me.RebelRadio.TabIndex = 4
        Me.RebelRadio.TabStop = True
        Me.RebelRadio.Text = "R&ebel Alliance"
        Me.ToolTip1.SetToolTip(Me.RebelRadio, "Display the Rebel Flag")
        Me.RebelRadio.UseVisualStyleBackColor = True
        '
        'RussiaRadio
        '
        Me.RussiaRadio.AutoSize = True
        Me.RussiaRadio.Location = New System.Drawing.Point(7, 89)
        Me.RussiaRadio.Name = "RussiaRadio"
        Me.RussiaRadio.Size = New System.Drawing.Size(57, 17)
        Me.RussiaRadio.TabIndex = 3
        Me.RussiaRadio.TabStop = True
        Me.RussiaRadio.Text = "&Russia"
        Me.ToolTip1.SetToolTip(Me.RussiaRadio, "Display Russia")
        Me.RussiaRadio.UseVisualStyleBackColor = True
        '
        'IrelandRadio
        '
        Me.IrelandRadio.AutoSize = True
        Me.IrelandRadio.Location = New System.Drawing.Point(7, 66)
        Me.IrelandRadio.Name = "IrelandRadio"
        Me.IrelandRadio.Size = New System.Drawing.Size(57, 17)
        Me.IrelandRadio.TabIndex = 2
        Me.IrelandRadio.TabStop = True
        Me.IrelandRadio.Text = "&Ireland"
        Me.ToolTip1.SetToolTip(Me.IrelandRadio, "Display Ireland")
        Me.IrelandRadio.UseVisualStyleBackColor = True
        '
        'PolandRadio
        '
        Me.PolandRadio.AutoSize = True
        Me.PolandRadio.Location = New System.Drawing.Point(7, 43)
        Me.PolandRadio.Name = "PolandRadio"
        Me.PolandRadio.Size = New System.Drawing.Size(58, 17)
        Me.PolandRadio.TabIndex = 1
        Me.PolandRadio.TabStop = True
        Me.PolandRadio.Text = "P&oland"
        Me.ToolTip1.SetToolTip(Me.PolandRadio, "Display Poland")
        Me.PolandRadio.UseVisualStyleBackColor = True
        '
        'UnitedStatesRadio
        '
        Me.UnitedStatesRadio.AutoSize = True
        Me.UnitedStatesRadio.Location = New System.Drawing.Point(7, 20)
        Me.UnitedStatesRadio.Name = "UnitedStatesRadio"
        Me.UnitedStatesRadio.Size = New System.Drawing.Size(89, 17)
        Me.UnitedStatesRadio.TabIndex = 0
        Me.UnitedStatesRadio.TabStop = True
        Me.UnitedStatesRadio.Text = "United &States"
        Me.ToolTip1.SetToolTip(Me.UnitedStatesRadio, "Display United States")
        Me.UnitedStatesRadio.UseVisualStyleBackColor = True
        '
        'DisplayBox
        '
        Me.DisplayBox.Controls.Add(Me.ProgrammerBox)
        Me.DisplayBox.Controls.Add(Me.CountryNameBox)
        Me.DisplayBox.Controls.Add(Me.TitleBox)
        Me.DisplayBox.Location = New System.Drawing.Point(394, 50)
        Me.DisplayBox.Name = "DisplayBox"
        Me.DisplayBox.Size = New System.Drawing.Size(113, 104)
        Me.DisplayBox.TabIndex = 2
        Me.DisplayBox.TabStop = False
        Me.DisplayBox.Text = "Display"
        '
        'ProgrammerBox
        '
        Me.ProgrammerBox.AutoSize = True
        Me.ProgrammerBox.Checked = True
        Me.ProgrammerBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ProgrammerBox.Location = New System.Drawing.Point(7, 67)
        Me.ProgrammerBox.Name = "ProgrammerBox"
        Me.ProgrammerBox.Size = New System.Drawing.Size(82, 17)
        Me.ProgrammerBox.TabIndex = 3
        Me.ProgrammerBox.Text = "Progra&mmer"
        Me.ToolTip1.SetToolTip(Me.ProgrammerBox, "Display Programmer Name")
        Me.ProgrammerBox.UseVisualStyleBackColor = True
        '
        'CountryNameBox
        '
        Me.CountryNameBox.AutoSize = True
        Me.CountryNameBox.Checked = True
        Me.CountryNameBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CountryNameBox.Location = New System.Drawing.Point(7, 43)
        Me.CountryNameBox.Name = "CountryNameBox"
        Me.CountryNameBox.Size = New System.Drawing.Size(93, 17)
        Me.CountryNameBox.TabIndex = 2
        Me.CountryNameBox.Text = "Country &Name"
        Me.ToolTip1.SetToolTip(Me.CountryNameBox, "Display Country Name")
        Me.CountryNameBox.UseVisualStyleBackColor = True
        '
        'TitleBox
        '
        Me.TitleBox.AutoSize = True
        Me.TitleBox.Checked = True
        Me.TitleBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TitleBox.Location = New System.Drawing.Point(7, 20)
        Me.TitleBox.Name = "TitleBox"
        Me.TitleBox.Size = New System.Drawing.Size(46, 17)
        Me.TitleBox.TabIndex = 1
        Me.TitleBox.Text = "&Title"
        Me.ToolTip1.SetToolTip(Me.TitleBox, "Display Title of Form")
        Me.TitleBox.UseVisualStyleBackColor = True
        '
        'ProgNameLabel
        '
        Me.ProgNameLabel.AutoSize = True
        Me.ProgNameLabel.Location = New System.Drawing.Point(5, 16)
        Me.ProgNameLabel.Name = "ProgNameLabel"
        Me.ProgNameLabel.Size = New System.Drawing.Size(158, 13)
        Me.ProgNameLabel.TabIndex = 0
        Me.ProgNameLabel.Text = "Programmed by: Douglas Shirilla"
        Me.ToolTip1.SetToolTip(Me.ProgNameLabel, "Made by:")
        '
        'ProgmrBox
        '
        Me.ProgmrBox.Controls.Add(Me.ProgNameLabel)
        Me.ProgmrBox.Location = New System.Drawing.Point(24, 208)
        Me.ProgmrBox.Name = "ProgmrBox"
        Me.ProgmrBox.Size = New System.Drawing.Size(169, 40)
        Me.ProgmrBox.TabIndex = 4
        Me.ProgmrBox.TabStop = False
        '
        'ApplyAllButton
        '
        Me.ApplyAllButton.Location = New System.Drawing.Point(394, 186)
        Me.ApplyAllButton.Name = "ApplyAllButton"
        Me.ApplyAllButton.Size = New System.Drawing.Size(134, 23)
        Me.ApplyAllButton.TabIndex = 4
        Me.ApplyAllButton.Text = "&Apply All Display Options"
        Me.ToolTip1.SetToolTip(Me.ApplyAllButton, "Check All Display Boxes")
        Me.ApplyAllButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(249, 234)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 9
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit and close program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'CountryTitleBox
        '
        Me.CountryTitleBox.Controls.Add(Me.CountryNameLabel)
        Me.CountryTitleBox.Location = New System.Drawing.Point(179, 174)
        Me.CountryTitleBox.Name = "CountryTitleBox"
        Me.CountryTitleBox.Size = New System.Drawing.Size(194, 28)
        Me.CountryTitleBox.TabIndex = 3
        Me.CountryTitleBox.TabStop = False
        '
        'CountryNameLabel
        '
        Me.CountryNameLabel.AutoSize = True
        Me.CountryNameLabel.Location = New System.Drawing.Point(57, 12)
        Me.CountryNameLabel.Name = "CountryNameLabel"
        Me.CountryNameLabel.Size = New System.Drawing.Size(0, 13)
        Me.CountryNameLabel.TabIndex = 0
        '
        'FlagPictureBox
        '
        Me.FlagPictureBox.Location = New System.Drawing.Point(191, 58)
        Me.FlagPictureBox.Name = "FlagPictureBox"
        Me.FlagPictureBox.Size = New System.Drawing.Size(149, 98)
        Me.FlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FlagPictureBox.TabIndex = 8
        Me.FlagPictureBox.TabStop = False
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(394, 219)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(134, 23)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "C&lear All Display Options"
        Me.ClearButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear all display options")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(249, 205)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 6
        Me.PrintButton.Text = "&Print"
        Me.ToolTip1.SetToolTip(Me.PrintButton, "unavailble on visual studio 2015")
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 269)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.FlagPictureBox)
        Me.Controls.Add(Me.CountryTitleBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ApplyAllButton)
        Me.Controls.Add(Me.ProgmrBox)
        Me.Controls.Add(Me.DisplayBox)
        Me.Controls.Add(Me.CountryListBox)
        Me.Controls.Add(Me.TitleLabel)
        Me.Name = "Form1"
        Me.Text = "Flag Display"
        Me.CountryListBox.ResumeLayout(False)
        Me.CountryListBox.PerformLayout()
        Me.DisplayBox.ResumeLayout(False)
        Me.DisplayBox.PerformLayout()
        Me.ProgmrBox.ResumeLayout(False)
        Me.ProgmrBox.PerformLayout()
        Me.CountryTitleBox.ResumeLayout(False)
        Me.CountryTitleBox.PerformLayout()
        CType(Me.FlagPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents CountryListBox As GroupBox
    Friend WithEvents RebelRadio As RadioButton
    Friend WithEvents RussiaRadio As RadioButton
    Friend WithEvents IrelandRadio As RadioButton
    Friend WithEvents PolandRadio As RadioButton
    Friend WithEvents UnitedStatesRadio As RadioButton
    Friend WithEvents DisplayBox As GroupBox
    Friend WithEvents ProgrammerBox As CheckBox
    Friend WithEvents CountryNameBox As CheckBox
    Friend WithEvents TitleBox As CheckBox
    Friend WithEvents ProgNameLabel As Label
    Friend WithEvents ProgmrBox As GroupBox
    Friend WithEvents ApplyAllButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents CountryTitleBox As GroupBox
    Friend WithEvents CountryNameLabel As Label
    Friend WithEvents FlagPictureBox As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
End Class
