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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CostButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.NumofTicBox = New System.Windows.Forms.TextBox()
        Me.SeatLocationList = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TotCurCostText = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CostButton
        '
        Me.CostButton.Location = New System.Drawing.Point(195, 198)
        Me.CostButton.Name = "CostButton"
        Me.CostButton.Size = New System.Drawing.Size(75, 23)
        Me.CostButton.TabIndex = 1
        Me.CostButton.Text = "&Purchase"
        Me.ToolTip1.SetToolTip(Me.CostButton, "Calculate current cost for sale")
        Me.CostButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(195, 293)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit Program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(184, 162)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.ReadOnly = True
        Me.PriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PriceTextBox.TabIndex = 5
        Me.PriceTextBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PriceTextBox, "Current Cost of Sale")
        '
        'NumofTicBox
        '
        Me.NumofTicBox.Location = New System.Drawing.Point(184, 114)
        Me.NumofTicBox.Name = "NumofTicBox"
        Me.NumofTicBox.Size = New System.Drawing.Size(100, 20)
        Me.NumofTicBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.NumofTicBox, "Enter Number of Tickets to Purchase here")
        '
        'SeatLocationList
        '
        Me.SeatLocationList.FormattingEnabled = True
        Me.SeatLocationList.Items.AddRange(New Object() {"Balcony", "General", "Mezzanine", "Orchestra"})
        Me.SeatLocationList.Location = New System.Drawing.Point(330, 92)
        Me.SeatLocationList.Name = "SeatLocationList"
        Me.SeatLocationList.Size = New System.Drawing.Size(57, 95)
        Me.SeatLocationList.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.SeatLocationList, "Make seat selection here")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(138, 134)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ticket Price Schedule"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Orchestra Seats: $40.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mezzanine Seats: $27.50"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "General Seats: $15.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Balcony Seats: $10"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(331, 26)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Concert Ticket Cost Calculator"
        Me.ToolTip1.SetToolTip(Me.Label5, "THE TITLE OF THE PROGRAM")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(313, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Seat Location"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(213, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 19)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Cost:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(168, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Number of Tickets:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.EditToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(457, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SummaryFormToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.EditToolStripMenuItem.Text = "F&ile"
        Me.EditToolStripMenuItem.ToolTipText = "Find the summary form here"
        '
        'SummaryFormToolStripMenuItem
        '
        Me.SummaryFormToolStripMenuItem.Name = "SummaryFormToolStripMenuItem"
        Me.SummaryFormToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SummaryFormToolStripMenuItem.Text = "&Summary Form"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem1, Me.ClearAllToolStripMenuItem1})
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem1.Text = "&Edit"
        Me.EditToolStripMenuItem1.ToolTipText = "find clearing options here"
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(118, 22)
        Me.ClearToolStripMenuItem1.Text = "&Clear"
        Me.ClearToolStripMenuItem1.ToolTipText = "clear current information here"
        '
        'ClearAllToolStripMenuItem1
        '
        Me.ClearAllToolStripMenuItem1.Name = "ClearAllToolStripMenuItem1"
        Me.ClearAllToolStripMenuItem1.Size = New System.Drawing.Size(118, 22)
        Me.ClearAllToolStripMenuItem1.Text = "Clear &All"
        Me.ClearAllToolStripMenuItem1.ToolTipText = "clear all information that has been input"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutBoxToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "Ab&out"
        '
        'AboutBoxToolStripMenuItem
        '
        Me.AboutBoxToolStripMenuItem.Name = "AboutBoxToolStripMenuItem"
        Me.AboutBoxToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.AboutBoxToolStripMenuItem.Text = "About B&ox"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(188, 233)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Total Cost:"
        '
        'TotCurCostText
        '
        Me.TotCurCostText.Location = New System.Drawing.Point(184, 256)
        Me.TotCurCostText.Name = "TotCurCostText"
        Me.TotCurCostText.ReadOnly = True
        Me.TotCurCostText.Size = New System.Drawing.Size(100, 20)
        Me.TotCurCostText.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 328)
        Me.Controls.Add(Me.TotCurCostText)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SeatLocationList)
        Me.Controls.Add(Me.NumofTicBox)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.CostButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Concert Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CostButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents NumofTicBox As TextBox
    Friend WithEvents SeatLocationList As ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents SummaryFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutBoxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TotCurCostText As System.Windows.Forms.TextBox
End Class
