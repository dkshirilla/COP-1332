<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.EnglishButton = New System.Windows.Forms.Button()
        Me.SpanishButton = New System.Windows.Forms.Button()
        Me.PolishButton = New System.Windows.Forms.Button()
        Me.CroatianButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ProgrammerLabel = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDialog2 = New System.Windows.Forms.PrintDialog()
        Me.InstructionalLabel = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DisplayLabel
        '
        Me.DisplayLabel.AutoSize = True
        Me.DisplayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayLabel.Location = New System.Drawing.Point(69, 44)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(0, 24)
        Me.DisplayLabel.TabIndex = 0
        '
        'EnglishButton
        '
        Me.EnglishButton.Location = New System.Drawing.Point(27, 118)
        Me.EnglishButton.Name = "EnglishButton"
        Me.EnglishButton.Size = New System.Drawing.Size(75, 23)
        Me.EnglishButton.TabIndex = 1
        Me.EnglishButton.Text = "English"
        Me.EnglishButton.UseVisualStyleBackColor = True
        '
        'SpanishButton
        '
        Me.SpanishButton.Location = New System.Drawing.Point(137, 118)
        Me.SpanishButton.Name = "SpanishButton"
        Me.SpanishButton.Size = New System.Drawing.Size(75, 23)
        Me.SpanishButton.TabIndex = 2
        Me.SpanishButton.Text = "Spanish"
        Me.SpanishButton.UseVisualStyleBackColor = True
        '
        'PolishButton
        '
        Me.PolishButton.Location = New System.Drawing.Point(27, 158)
        Me.PolishButton.Name = "PolishButton"
        Me.PolishButton.Size = New System.Drawing.Size(75, 23)
        Me.PolishButton.TabIndex = 3
        Me.PolishButton.Text = "Polish"
        Me.PolishButton.UseVisualStyleBackColor = True
        '
        'CroatianButton
        '
        Me.CroatianButton.Location = New System.Drawing.Point(137, 158)
        Me.CroatianButton.Name = "CroatianButton"
        Me.CroatianButton.Size = New System.Drawing.Size(75, 23)
        Me.CroatianButton.TabIndex = 4
        Me.CroatianButton.Text = "Croatian"
        Me.CroatianButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(12, 237)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ProgrammerLabel
        '
        Me.ProgrammerLabel.AutoSize = True
        Me.ProgrammerLabel.Location = New System.Drawing.Point(146, 242)
        Me.ProgrammerLabel.Name = "ProgrammerLabel"
        Me.ProgrammerLabel.Size = New System.Drawing.Size(97, 13)
        Me.ProgrammerLabel.TabIndex = 6
        Me.ProgrammerLabel.Text = "By: Douglas Shirilla"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDialog2
        '
        Me.PrintDialog2.UseEXDialog = True
        '
        'InstructionalLabel
        '
        Me.InstructionalLabel.AutoSize = True
        Me.InstructionalLabel.Location = New System.Drawing.Point(53, 91)
        Me.InstructionalLabel.Name = "InstructionalLabel"
        Me.InstructionalLabel.Size = New System.Drawing.Size(132, 13)
        Me.InstructionalLabel.TabIndex = 7
        Me.InstructionalLabel.Text = "Select a Language Below:"
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(12, 208)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 8
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 270)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.InstructionalLabel)
        Me.Controls.Add(Me.ProgrammerLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.CroatianButton)
        Me.Controls.Add(Me.PolishButton)
        Me.Controls.Add(Me.SpanishButton)
        Me.Controls.Add(Me.EnglishButton)
        Me.Controls.Add(Me.DisplayLabel)
        Me.Name = "Form1"
        Me.Text = "Hello World"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DisplayLabel As Label
    Friend WithEvents EnglishButton As Button
    Friend WithEvents SpanishButton As Button
    Friend WithEvents PolishButton As Button
    Friend WithEvents CroatianButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ProgrammerLabel As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDialog2 As PrintDialog
    Friend WithEvents InstructionalLabel As Label
    Friend WithEvents ClearButton As Button
End Class
