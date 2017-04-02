<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SummaryForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumofBalBox = New System.Windows.Forms.TextBox()
        Me.NumofGenBox = New System.Windows.Forms.TextBox()
        Me.NumofMezBox = New System.Windows.Forms.TextBox()
        Me.NumofOrcBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TotTicBox = New System.Windows.Forms.TextBox()
        Me.TotPriceBox = New System.Windows.Forms.Label()
        Me.TotCostBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales Summary"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total of Balcony Tickets Sold:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total of General Tickets Sold: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total of Mezzanine Tickets Sold:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total of Orchestra Tickets Sold: "
        '
        'NumofBalBox
        '
        Me.NumofBalBox.Location = New System.Drawing.Point(178, 101)
        Me.NumofBalBox.Name = "NumofBalBox"
        Me.NumofBalBox.ReadOnly = True
        Me.NumofBalBox.Size = New System.Drawing.Size(100, 20)
        Me.NumofBalBox.TabIndex = 5
        Me.NumofBalBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.NumofBalBox, "Total number of balcony tickets sold")
        '
        'NumofGenBox
        '
        Me.NumofGenBox.Location = New System.Drawing.Point(178, 127)
        Me.NumofGenBox.Name = "NumofGenBox"
        Me.NumofGenBox.ReadOnly = True
        Me.NumofGenBox.Size = New System.Drawing.Size(100, 20)
        Me.NumofGenBox.TabIndex = 6
        Me.NumofGenBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.NumofGenBox, "Total number of general tickets sold")
        '
        'NumofMezBox
        '
        Me.NumofMezBox.Location = New System.Drawing.Point(178, 159)
        Me.NumofMezBox.Name = "NumofMezBox"
        Me.NumofMezBox.ReadOnly = True
        Me.NumofMezBox.Size = New System.Drawing.Size(100, 20)
        Me.NumofMezBox.TabIndex = 7
        Me.NumofMezBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.NumofMezBox, "Total number of mezzanine tickets sold")
        '
        'NumofOrcBox
        '
        Me.NumofOrcBox.Location = New System.Drawing.Point(178, 190)
        Me.NumofOrcBox.Name = "NumofOrcBox"
        Me.NumofOrcBox.ReadOnly = True
        Me.NumofOrcBox.Size = New System.Drawing.Size(100, 20)
        Me.NumofOrcBox.TabIndex = 8
        Me.NumofOrcBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.NumofOrcBox, "Total number of orchestra tickets sold")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(77, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Total Tickets Sold:"
        '
        'TotTicBox
        '
        Me.TotTicBox.Location = New System.Drawing.Point(97, 257)
        Me.TotTicBox.Name = "TotTicBox"
        Me.TotTicBox.ReadOnly = True
        Me.TotTicBox.Size = New System.Drawing.Size(100, 20)
        Me.TotTicBox.TabIndex = 10
        Me.TotTicBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.TotTicBox, "Total tickets sold")
        '
        'TotPriceBox
        '
        Me.TotPriceBox.AutoSize = True
        Me.TotPriceBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotPriceBox.Location = New System.Drawing.Point(53, 291)
        Me.TotPriceBox.Name = "TotPriceBox"
        Me.TotPriceBox.Size = New System.Drawing.Size(204, 20)
        Me.TotPriceBox.TabIndex = 11
        Me.TotPriceBox.Text = "Total Cost of All Tickets:"
        '
        'TotCostBox
        '
        Me.TotCostBox.Location = New System.Drawing.Point(97, 324)
        Me.TotCostBox.Name = "TotCostBox"
        Me.TotCostBox.ReadOnly = True
        Me.TotCostBox.Size = New System.Drawing.Size(100, 20)
        Me.TotCostBox.TabIndex = 12
        Me.TotCostBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.TotCostBox, "Total cost of all tickets purchased")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(305, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.PrintSummaryToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "&Print Preview"
        '
        'PrintSummaryToolStripMenuItem
        '
        Me.PrintSummaryToolStripMenuItem.Name = "PrintSummaryToolStripMenuItem"
        Me.PrintSummaryToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.PrintSummaryToolStripMenuItem.Text = "Print &Summary"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
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
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 415)
        Me.Controls.Add(Me.TotCostBox)
        Me.Controls.Add(Me.TotPriceBox)
        Me.Controls.Add(Me.TotTicBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NumofOrcBox)
        Me.Controls.Add(Me.NumofMezBox)
        Me.Controls.Add(Me.NumofGenBox)
        Me.Controls.Add(Me.NumofBalBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SummaryForm"
        Me.Text = "Summary Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NumofBalBox As System.Windows.Forms.TextBox
    Friend WithEvents NumofGenBox As System.Windows.Forms.TextBox
    Friend WithEvents NumofMezBox As System.Windows.Forms.TextBox
    Friend WithEvents NumofOrcBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TotTicBox As System.Windows.Forms.TextBox
    Friend WithEvents TotPriceBox As System.Windows.Forms.Label
    Friend WithEvents TotCostBox As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
