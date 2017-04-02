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
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.PiecesCompletedBox = New System.Windows.Forms.TextBox()
        Me.WorkerNameLabel = New System.Windows.Forms.Label()
        Me.PiecesCompletedLabel = New System.Windows.Forms.Label()
        Me.AmountEarnedBox = New System.Windows.Forms.GroupBox()
        Me.DollarsEarnedBox = New System.Windows.Forms.TextBox()
        Me.WorkerInfoBox = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatePayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.AmountEarnedBox.SuspendLayout()
        Me.WorkerInfoBox.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(128, 35)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.NameTextBox, "enter name of worker here")
        '
        'PiecesCompletedBox
        '
        Me.PiecesCompletedBox.Location = New System.Drawing.Point(128, 79)
        Me.PiecesCompletedBox.Name = "PiecesCompletedBox"
        Me.PiecesCompletedBox.Size = New System.Drawing.Size(100, 20)
        Me.PiecesCompletedBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.PiecesCompletedBox, "enter amount of pieces completed")
        '
        'WorkerNameLabel
        '
        Me.WorkerNameLabel.AutoSize = True
        Me.WorkerNameLabel.Location = New System.Drawing.Point(26, 38)
        Me.WorkerNameLabel.Name = "WorkerNameLabel"
        Me.WorkerNameLabel.Size = New System.Drawing.Size(38, 13)
        Me.WorkerNameLabel.TabIndex = 1
        Me.WorkerNameLabel.Text = "Name:"
        Me.ToolTip1.SetToolTip(Me.WorkerNameLabel, "Name of worker")
        '
        'PiecesCompletedLabel
        '
        Me.PiecesCompletedLabel.AutoSize = True
        Me.PiecesCompletedLabel.Location = New System.Drawing.Point(26, 79)
        Me.PiecesCompletedLabel.Name = "PiecesCompletedLabel"
        Me.PiecesCompletedLabel.Size = New System.Drawing.Size(95, 13)
        Me.PiecesCompletedLabel.TabIndex = 2
        Me.PiecesCompletedLabel.Text = "Pieces Completed:"
        Me.ToolTip1.SetToolTip(Me.PiecesCompletedLabel, "amount of pieces completed")
        '
        'AmountEarnedBox
        '
        Me.AmountEarnedBox.Controls.Add(Me.DollarsEarnedBox)
        Me.AmountEarnedBox.Location = New System.Drawing.Point(80, 159)
        Me.AmountEarnedBox.Name = "AmountEarnedBox"
        Me.AmountEarnedBox.Size = New System.Drawing.Size(148, 55)
        Me.AmountEarnedBox.TabIndex = 3
        Me.AmountEarnedBox.TabStop = False
        Me.AmountEarnedBox.Text = "Dollars Earned"
        '
        'DollarsEarnedBox
        '
        Me.DollarsEarnedBox.Location = New System.Drawing.Point(27, 19)
        Me.DollarsEarnedBox.Name = "DollarsEarnedBox"
        Me.DollarsEarnedBox.ReadOnly = True
        Me.DollarsEarnedBox.Size = New System.Drawing.Size(100, 20)
        Me.DollarsEarnedBox.TabIndex = 0
        Me.DollarsEarnedBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.DollarsEarnedBox, "amount earned by current worker")
        '
        'WorkerInfoBox
        '
        Me.WorkerInfoBox.Controls.Add(Me.WorkerNameLabel)
        Me.WorkerInfoBox.Controls.Add(Me.PiecesCompletedLabel)
        Me.WorkerInfoBox.Controls.Add(Me.PiecesCompletedBox)
        Me.WorkerInfoBox.Controls.Add(Me.NameTextBox)
        Me.WorkerInfoBox.Location = New System.Drawing.Point(12, 22)
        Me.WorkerInfoBox.Name = "WorkerInfoBox"
        Me.WorkerInfoBox.Size = New System.Drawing.Size(281, 131)
        Me.WorkerInfoBox.TabIndex = 1
        Me.WorkerInfoBox.TabStop = False
        Me.WorkerInfoBox.Text = "Worker Info"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(234, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Print"
        Me.ToolTip1.SetToolTip(Me.Button1, "Not availble, sorry")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(329, 24)
        Me.MenuStrip2.TabIndex = 8
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatePayToolStripMenuItem, Me.SummaryToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        Me.FileToolStripMenuItem.ToolTipText = "calculation, summary, and exit"
        '
        'CalculatePayToolStripMenuItem
        '
        Me.CalculatePayToolStripMenuItem.Name = "CalculatePayToolStripMenuItem"
        Me.CalculatePayToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CalculatePayToolStripMenuItem.Text = "&Calculate Pay"
        Me.CalculatePayToolStripMenuItem.ToolTipText = "calculate pay for current employees"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SummaryToolStripMenuItem.Text = "&Summary"
        Me.SummaryToolStripMenuItem.ToolTipText = "display a summary box of information entered"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        Me.ExitToolStripMenuItem.ToolTipText = "exit program"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ClearAllToolStripMenuItem, Me.ToolStripSeparator1, Me.FontToolStripMenuItem, Me.ColorToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        Me.EditToolStripMenuItem.ToolTipText = "edit format of form"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ClearToolStripMenuItem.Text = "C&lear"
        Me.ClearToolStripMenuItem.ToolTipText = "clear current information"
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ClearAllToolStripMenuItem.Text = "Clear &All"
        Me.ClearAllToolStripMenuItem.ToolTipText = "clear entire form"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(115, 6)
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.FontToolStripMenuItem.Text = "&Font"
        Me.FontToolStripMenuItem.ToolTipText = "change display font of current information"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ColorToolStripMenuItem.Text = "&Color"
        Me.ColorToolStripMenuItem.ToolTipText = "change background color for current information"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        Me.HelpToolStripMenuItem.ToolTipText = "about box"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        Me.AboutToolStripMenuItem.ToolTipText = "display about box"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 231)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.WorkerInfoBox)
        Me.Controls.Add(Me.AmountEarnedBox)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "Form1"
        Me.Text = "Piecework Form"
        Me.AmountEarnedBox.ResumeLayout(False)
        Me.AmountEarnedBox.PerformLayout()
        Me.WorkerInfoBox.ResumeLayout(False)
        Me.WorkerInfoBox.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents PiecesCompletedBox As TextBox
    Friend WithEvents WorkerNameLabel As Label
    Friend WithEvents PiecesCompletedLabel As Label
    Friend WithEvents AmountEarnedBox As GroupBox
    Friend WithEvents DollarsEarnedBox As TextBox
    Friend WithEvents WorkerInfoBox As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculatePayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents ClearAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
