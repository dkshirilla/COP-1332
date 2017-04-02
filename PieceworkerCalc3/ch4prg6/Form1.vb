'Project: Chapter 6 Program 5
'Programmer: Douglas Shirilla
'Date: 03/09/2016
'Professor Lisa Thomas
'Description: Let user input name and amount of pieces completed and calculate
'dollar amount earned and include a summary table to display various data from user inputs
'REVISED FROM CHAPTER 4 TO INCLUDE MENU OPTIONS
'REVISED FROM CHAPTER 5 TO INCLUDE A SPLASH SCREEN, SUMMARY FORM, ABOUT BOX, AND A SLOGAN AND LOGO

Public Class Form1
    'declare variables
    Friend NumberOfWorkersInteger As Integer
    Friend TotalNumofWorkersInteger As Integer
    Friend TotalPayDecimal As Decimal
    Friend PiecesCompletedInteger As Integer
    Friend DollarsEarnedDecimal As Decimal
    Friend AveragePayPerPersonDecimal As Decimal
    Friend TotalPiecesCompletedInteger As Integer
    Friend PricePerPieceDecimal As Decimal


    'function declaration
    Private Function PiecePrice(ByVal PiecesCompletedInteger As Integer) As Decimal
        If PiecesCompletedInteger < 200 Then
            Return 0.5
        ElseIf PiecesCompletedInteger < 400 Then
            Return 0.55
        ElseIf PiecesCompletedInteger < 600 Then
            Return 0.6
        Else
            Return 0.65
        End If
    End Function



    Private Sub CalculatePayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatePayToolStripMenuItem.Click



        'makes sure input data has been entered and then calculates required numbers
        Try
            If PiecesCompletedBox.Text = "" Then
                MessageBox.Show("Pieces Completed box cannot be empty", "Data entry error", MessageBoxButtons.OK,
                                MessageBoxIcon.Stop)
            ElseIf NameTextBox.Text = "" Then
                MessageBox.Show("Worker's name box cannot be empty", "Data entry error", MessageBoxButtons.OK,
                                MessageBoxIcon.Stop)
                With NameTextBox
                    .Focus()
                End With
            Else : PiecesCompletedInteger = Integer.Parse(PiecesCompletedBox.Text)
                'call function
                PricePerPieceDecimal = PiecePrice(PiecesCompletedInteger)
                DollarsEarnedDecimal = PricePerPieceDecimal * PiecesCompletedInteger
                DollarsEarnedBox.Text = (PricePerPieceDecimal * PiecesCompletedInteger).ToString("C")
                NumberOfWorkersInteger += 1
                TotalPiecesCompletedInteger = PiecesCompletedInteger + TotalPiecesCompletedInteger
                TotalPayDecimal = DollarsEarnedDecimal + TotalPayDecimal
            End If
        Catch ex As FormatException
            MessageBox.Show("Value must be numeric", "Date entry error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            With PiecesCompletedBox
                .Focus()
            End With
        End Try
    End Sub




    'clears current info
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        DollarsEarnedBox.Clear()
        NameTextBox.Clear()
        PiecesCompletedBox.Clear()
    End Sub





    'displays summary information after at least one worker has been entered
    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click

        'makes sure at least one worker's information has been entered
        If NumberOfWorkersInteger = 0 Then
            MessageBox.Show("Must input at least one employee", "Data entry error", MessageBoxButtons.OK,
                            MessageBoxIcon.Stop)
        Else
            'TotalPiecesBox.Text = TotalPiecesCompletedInteger
            'TotalPayText.Text = TotalPayDecimal.ToString("C")
            'AvgPayBox.Text = (TotalPayDecimal / NumberOfWorkersInteger).ToString("C")
            'numofworktextbox.Text = NumberOfWorkersInteger

            SummaryForm.ShowDialog()
        End If


    End Sub



    'displays information about the program
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Programmer: Douglas Shirilla Program:Ch5 Program 1", "About My Project", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    'changes the font of the dollars earned text box
    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        With FontDialog1
            .ShowDialog()
            DollarsEarnedBox.Font = .Font
        End With
    End Sub



    'changes the color of the dollars earned text box
    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        With ColorDialog1
            .ShowDialog()
            DollarsEarnedBox.BackColor = .Color
        End With
    End Sub

    'clears all entered data and resets values to zero
    Private Sub ClearAllToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        Dim ReturnDialogResult As DialogResult
        Dim MessageString As String

        MessageString = "Clear all entered data?"
        ReturnDialogResult = MessageBox.Show(MessageString, "Clear all", MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If ReturnDialogResult = Windows.Forms.DialogResult.Yes Then
            SummaryForm.TotalPiecesBox.Clear()
            SummaryForm.TotalPayText.Clear()
            SummaryForm.AvgPayBox.Clear()
            DollarsEarnedBox.Clear()
            PiecesCompletedBox.Clear()
            NameTextBox.Clear()
            SummaryForm.numofworktextbox.Clear()
            TotalPiecesCompletedInteger = 0
            PiecesCompletedInteger = 0
            DollarsEarnedDecimal = 0
            TotalPayDecimal = 0
            NumberOfWorkersInteger = 0
        End If
    End Sub


    'exit program
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutBoxToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub SloganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SloganToolStripMenuItem.Click
        'hides slogan if menu item is clicked after opening
        If SloganToolStripMenuItem.Checked Then
            SloganToolStripMenuItem.Checked = False
            SloganLabel.Visible = False
        Else
            'displays slogan on startup
            SloganToolStripMenuItem.Checked = True
            SloganLabel.Visible = True
        End If
    End Sub

    Private Sub LogoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoToolStripMenuItem.Click
        'hides logo if logo menu item is clicked
        If LogoToolStripMenuItem.Checked Then
            LogoToolStripMenuItem.Checked = False
            LogoPictureBox.Visible = False
        Else
            LogoToolStripMenuItem.Checked = True
            LogoPictureBox.Visible = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
