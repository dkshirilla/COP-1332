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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SummaryForm))
        Me.NumofChartLabel = New System.Windows.Forms.Label()
        Me.TotalRevenueLabel = New System.Windows.Forms.Label()
        Me.AvgHoursLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumofChartBox = New System.Windows.Forms.TextBox()
        Me.TotalRevBox = New System.Windows.Forms.TextBox()
        Me.AvgHoursBox = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintPreviewSum = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDialog2 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'NumofChartLabel
        '
        Me.NumofChartLabel.AutoSize = True
        Me.NumofChartLabel.Location = New System.Drawing.Point(13, 78)
        Me.NumofChartLabel.Name = "NumofChartLabel"
        Me.NumofChartLabel.Size = New System.Drawing.Size(101, 13)
        Me.NumofChartLabel.TabIndex = 0
        Me.NumofChartLabel.Text = "Number of Charters:"
        '
        'TotalRevenueLabel
        '
        Me.TotalRevenueLabel.AutoSize = True
        Me.TotalRevenueLabel.Location = New System.Drawing.Point(13, 108)
        Me.TotalRevenueLabel.Name = "TotalRevenueLabel"
        Me.TotalRevenueLabel.Size = New System.Drawing.Size(81, 13)
        Me.TotalRevenueLabel.TabIndex = 1
        Me.TotalRevenueLabel.Text = "Total Revenue:"
        '
        'AvgHoursLabel
        '
        Me.AvgHoursLabel.AutoSize = True
        Me.AvgHoursLabel.Location = New System.Drawing.Point(13, 137)
        Me.AvgHoursLabel.Name = "AvgHoursLabel"
        Me.AvgHoursLabel.Size = New System.Drawing.Size(130, 13)
        Me.AvgHoursLabel.TabIndex = 2
        Me.AvgHoursLabel.Text = "Average Hours Chartered:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Programmer: Douglas Shirilla"
        '
        'NumofChartBox
        '
        Me.NumofChartBox.Location = New System.Drawing.Point(140, 75)
        Me.NumofChartBox.Name = "NumofChartBox"
        Me.NumofChartBox.ReadOnly = True
        Me.NumofChartBox.Size = New System.Drawing.Size(100, 20)
        Me.NumofChartBox.TabIndex = 4
        Me.NumofChartBox.TabStop = False
        '
        'TotalRevBox
        '
        Me.TotalRevBox.Location = New System.Drawing.Point(140, 108)
        Me.TotalRevBox.Name = "TotalRevBox"
        Me.TotalRevBox.ReadOnly = True
        Me.TotalRevBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalRevBox.TabIndex = 5
        Me.TotalRevBox.TabStop = False
        '
        'AvgHoursBox
        '
        Me.AvgHoursBox.Location = New System.Drawing.Point(140, 134)
        Me.AvgHoursBox.Name = "AvgHoursBox"
        Me.AvgHoursBox.ReadOnly = True
        Me.AvgHoursBox.Size = New System.Drawing.Size(100, 20)
        Me.AvgHoursBox.TabIndex = 6
        Me.AvgHoursBox.TabStop = False
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
        'PrintPreviewSum
        '
        Me.PrintPreviewSum.Location = New System.Drawing.Point(70, 197)
        Me.PrintPreviewSum.Name = "PrintPreviewSum"
        Me.PrintPreviewSum.Size = New System.Drawing.Size(137, 23)
        Me.PrintPreviewSum.TabIndex = 7
        Me.PrintPreviewSum.Text = "Print"
        Me.PrintPreviewSum.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDialog2
        '
        Me.PrintDialog2.UseEXDialog = True
        '
        'PrintDocument2
        '
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.PrintPreviewSum)
        Me.Controls.Add(Me.AvgHoursBox)
        Me.Controls.Add(Me.TotalRevBox)
        Me.Controls.Add(Me.NumofChartBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AvgHoursLabel)
        Me.Controls.Add(Me.TotalRevenueLabel)
        Me.Controls.Add(Me.NumofChartLabel)
        Me.Name = "SummaryForm"
        Me.Text = "Summary Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NumofChartLabel As Label
    Friend WithEvents TotalRevenueLabel As Label
    Friend WithEvents AvgHoursLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NumofChartBox As TextBox
    Friend WithEvents TotalRevBox As TextBox
    Friend WithEvents AvgHoursBox As TextBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintPreviewSum As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDialog2 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument2 As System.Drawing.Printing.PrintDocument
End Class
