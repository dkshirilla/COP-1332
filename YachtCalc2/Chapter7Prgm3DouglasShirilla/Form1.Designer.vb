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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintYachtTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservationFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearForNextCharterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddYachtTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveYachtTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayCountOfYachtTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveYachtTypeListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YachttypeBox = New System.Windows.Forms.ComboBox()
        Me.YachtSizeList = New System.Windows.Forms.ComboBox()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.HoursTextBox = New System.Windows.Forms.TextBox()
        Me.PartyTextBox = New System.Windows.Forms.TextBox()
        Me.CostTextBox = New System.Windows.Forms.TextBox()
        Me.HoursLabel = New System.Windows.Forms.Label()
        Me.CostLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(542, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintSummaryToolStripMenuItem, Me.PrintYachtTypesToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ReservationFormToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrintSummaryToolStripMenuItem
        '
        Me.PrintSummaryToolStripMenuItem.Name = "PrintSummaryToolStripMenuItem"
        Me.PrintSummaryToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.PrintSummaryToolStripMenuItem.Text = "Print &Summary"
        '
        'PrintYachtTypesToolStripMenuItem
        '
        Me.PrintYachtTypesToolStripMenuItem.Name = "PrintYachtTypesToolStripMenuItem"
        Me.PrintYachtTypesToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.PrintYachtTypesToolStripMenuItem.Text = "Print &Yacht Types"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ReservationFormToolStripMenuItem
        '
        Me.ReservationFormToolStripMenuItem.Name = "ReservationFormToolStripMenuItem"
        Me.ReservationFormToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ReservationFormToolStripMenuItem.Text = "&Reservation Form"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearForNextCharterToolStripMenuItem, Me.ToolStripSeparator1, Me.AddYachtTypeToolStripMenuItem, Me.RemoveYachtTypeToolStripMenuItem, Me.DisplayCountOfYachtTypeToolStripMenuItem, Me.SaveYachtTypeListToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ClearForNextCharterToolStripMenuItem
        '
        Me.ClearForNextCharterToolStripMenuItem.Name = "ClearForNextCharterToolStripMenuItem"
        Me.ClearForNextCharterToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ClearForNextCharterToolStripMenuItem.Text = "Clear for &Next Charter"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(221, 6)
        '
        'AddYachtTypeToolStripMenuItem
        '
        Me.AddYachtTypeToolStripMenuItem.Name = "AddYachtTypeToolStripMenuItem"
        Me.AddYachtTypeToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.AddYachtTypeToolStripMenuItem.Text = "Add &Yacht Type"
        '
        'RemoveYachtTypeToolStripMenuItem
        '
        Me.RemoveYachtTypeToolStripMenuItem.Name = "RemoveYachtTypeToolStripMenuItem"
        Me.RemoveYachtTypeToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.RemoveYachtTypeToolStripMenuItem.Text = "&Remove Yacht Type"
        '
        'DisplayCountOfYachtTypeToolStripMenuItem
        '
        Me.DisplayCountOfYachtTypeToolStripMenuItem.Name = "DisplayCountOfYachtTypeToolStripMenuItem"
        Me.DisplayCountOfYachtTypeToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.DisplayCountOfYachtTypeToolStripMenuItem.Text = "Display &Count of Yacht Type"
        '
        'SaveYachtTypeListToolStripMenuItem
        '
        Me.SaveYachtTypeListToolStripMenuItem.Name = "SaveYachtTypeListToolStripMenuItem"
        Me.SaveYachtTypeListToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.SaveYachtTypeListToolStripMenuItem.Text = "Sa&ve Yacht Type List"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutFormToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutFormToolStripMenuItem
        '
        Me.AboutFormToolStripMenuItem.Name = "AboutFormToolStripMenuItem"
        Me.AboutFormToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.AboutFormToolStripMenuItem.Text = "&About form"
        '
        'YachttypeBox
        '
        Me.YachttypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.YachttypeBox.FormattingEnabled = True
        Me.YachttypeBox.Location = New System.Drawing.Point(367, 59)
        Me.YachttypeBox.Name = "YachttypeBox"
        Me.YachttypeBox.Size = New System.Drawing.Size(121, 150)
        Me.YachttypeBox.Sorted = True
        Me.YachttypeBox.TabIndex = 3
        '
        'YachtSizeList
        '
        Me.YachtSizeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YachtSizeList.FormattingEnabled = True
        Me.YachtSizeList.Items.AddRange(New Object() {"22", "24", "30", "32", "36", "38", "45"})
        Me.YachtSizeList.Location = New System.Drawing.Point(213, 59)
        Me.YachtSizeList.Name = "YachtSizeList"
        Me.YachtSizeList.Size = New System.Drawing.Size(121, 21)
        Me.YachtSizeList.TabIndex = 2
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(150, 212)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 4
        Me.OKButton.Text = "&OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'HoursTextBox
        '
        Me.HoursTextBox.Location = New System.Drawing.Point(104, 133)
        Me.HoursTextBox.Name = "HoursTextBox"
        Me.HoursTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HoursTextBox.TabIndex = 1
        '
        'PartyTextBox
        '
        Me.PartyTextBox.Location = New System.Drawing.Point(104, 99)
        Me.PartyTextBox.Name = "PartyTextBox"
        Me.PartyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PartyTextBox.TabIndex = 0
        '
        'CostTextBox
        '
        Me.CostTextBox.Location = New System.Drawing.Point(104, 169)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.ReadOnly = True
        Me.CostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CostTextBox.TabIndex = 6
        Me.CostTextBox.TabStop = False
        '
        'HoursLabel
        '
        Me.HoursLabel.AutoSize = True
        Me.HoursLabel.Location = New System.Drawing.Point(60, 133)
        Me.HoursLabel.Name = "HoursLabel"
        Me.HoursLabel.Size = New System.Drawing.Size(38, 13)
        Me.HoursLabel.TabIndex = 7
        Me.HoursLabel.Text = "Hours:"
        '
        'CostLabel
        '
        Me.CostLabel.AutoSize = True
        Me.CostLabel.Location = New System.Drawing.Point(40, 172)
        Me.CostLabel.Name = "CostLabel"
        Me.CostLabel.Size = New System.Drawing.Size(58, 13)
        Me.CostLabel.TabIndex = 8
        Me.CostLabel.Text = "Total Cost:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Responsible Party:"
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(367, 212)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
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
        'PrintDocument2
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Hint:To save, go to edit tab"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 261)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CostLabel)
        Me.Controls.Add(Me.HoursLabel)
        Me.Controls.Add(Me.CostTextBox)
        Me.Controls.Add(Me.PartyTextBox)
        Me.Controls.Add(Me.HoursTextBox)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.YachtSizeList)
        Me.Controls.Add(Me.YachttypeBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintSummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintYachtTypesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearForNextCharterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AddYachtTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveYachtTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayCountOfYachtTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YachttypeBox As ComboBox
    Friend WithEvents YachtSizeList As ComboBox
    Friend WithEvents OKButton As Button
    Friend WithEvents HoursTextBox As TextBox
    Friend WithEvents PartyTextBox As TextBox
    Friend WithEvents CostTextBox As TextBox
    Friend WithEvents HoursLabel As Label
    Friend WithEvents CostLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ClearButton As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDocument2 As System.Drawing.Printing.PrintDocument
    Friend WithEvents SaveYachtTypeListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReservationFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
