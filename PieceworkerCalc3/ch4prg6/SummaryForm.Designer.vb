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
        Me.SummaryFormBox = New System.Windows.Forms.GroupBox()
        Me.numofworktextbox = New System.Windows.Forms.TextBox()
        Me.AvgPayBox = New System.Windows.Forms.TextBox()
        Me.TotalPayText = New System.Windows.Forms.TextBox()
        Me.TotalPiecesBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CloseSummaryButton = New System.Windows.Forms.Button()
        Me.SummaryFormBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SummaryFormBox
        '
        Me.SummaryFormBox.Controls.Add(Me.numofworktextbox)
        Me.SummaryFormBox.Controls.Add(Me.AvgPayBox)
        Me.SummaryFormBox.Controls.Add(Me.TotalPayText)
        Me.SummaryFormBox.Controls.Add(Me.TotalPiecesBox)
        Me.SummaryFormBox.Controls.Add(Me.Label4)
        Me.SummaryFormBox.Controls.Add(Me.Label3)
        Me.SummaryFormBox.Controls.Add(Me.Label2)
        Me.SummaryFormBox.Controls.Add(Me.Label1)
        Me.SummaryFormBox.Location = New System.Drawing.Point(91, 40)
        Me.SummaryFormBox.Name = "SummaryFormBox"
        Me.SummaryFormBox.Size = New System.Drawing.Size(217, 203)
        Me.SummaryFormBox.TabIndex = 0
        Me.SummaryFormBox.TabStop = False
        Me.SummaryFormBox.Text = "Summary"
        '
        'numofworktextbox
        '
        Me.numofworktextbox.Location = New System.Drawing.Point(95, 138)
        Me.numofworktextbox.Name = "numofworktextbox"
        Me.numofworktextbox.ReadOnly = True
        Me.numofworktextbox.Size = New System.Drawing.Size(100, 20)
        Me.numofworktextbox.TabIndex = 7
        Me.numofworktextbox.TabStop = False
        '
        'AvgPayBox
        '
        Me.AvgPayBox.Location = New System.Drawing.Point(95, 107)
        Me.AvgPayBox.Name = "AvgPayBox"
        Me.AvgPayBox.ReadOnly = True
        Me.AvgPayBox.Size = New System.Drawing.Size(100, 20)
        Me.AvgPayBox.TabIndex = 6
        Me.AvgPayBox.TabStop = False
        '
        'TotalPayText
        '
        Me.TotalPayText.Location = New System.Drawing.Point(95, 80)
        Me.TotalPayText.Name = "TotalPayText"
        Me.TotalPayText.ReadOnly = True
        Me.TotalPayText.Size = New System.Drawing.Size(100, 20)
        Me.TotalPayText.TabIndex = 5
        Me.TotalPayText.TabStop = False
        '
        'TotalPiecesBox
        '
        Me.TotalPiecesBox.Location = New System.Drawing.Point(95, 47)
        Me.TotalPiecesBox.Name = "TotalPiecesBox"
        Me.TotalPiecesBox.ReadOnly = True
        Me.TotalPiecesBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalPiecesBox.TabIndex = 4
        Me.TotalPiecesBox.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-3, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Number of Workers:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Average Pay:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Pay:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Pieces:"
        '
        'CloseSummaryButton
        '
        Me.CloseSummaryButton.Location = New System.Drawing.Point(154, 266)
        Me.CloseSummaryButton.Name = "CloseSummaryButton"
        Me.CloseSummaryButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseSummaryButton.TabIndex = 1
        Me.CloseSummaryButton.Text = "Close"
        Me.CloseSummaryButton.UseVisualStyleBackColor = True
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 317)
        Me.Controls.Add(Me.CloseSummaryButton)
        Me.Controls.Add(Me.SummaryFormBox)
        Me.Name = "SummaryForm"
        Me.Text = "SummaryForm"
        Me.SummaryFormBox.ResumeLayout(False)
        Me.SummaryFormBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SummaryFormBox As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents numofworktextbox As TextBox
    Friend WithEvents AvgPayBox As TextBox
    Friend WithEvents TotalPayText As TextBox
    Friend WithEvents TotalPiecesBox As TextBox
    Friend WithEvents CloseSummaryButton As System.Windows.Forms.Button
End Class
