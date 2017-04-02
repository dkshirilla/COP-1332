'Project: Chapter 12 Program 1
'Programmer: Douglas Shirilla
'Date: 05/04/2016 
'Professor Lisa Thomas
'Description: Let user input name and amount of pieces completed and calculate
'dollar amount earned and include a summary table to display various data from user inputs
'REVISED FROM CHAPTER 4 TO INCLUDE MENU OPTIONS
'REVISED FROM CHAPTER 5 TO INCLUDE A CLASS OBJECT

Public Class Form1
    'declare global variables
    Public NumberOfWorkersInteger As Integer = 0
    Public TotalPayDecimal As Decimal = 0
    Public PiecesCompletedInteger As Integer
    Public DollarsEarnedDecimal As Decimal
    Public AveragePayPerPersonDecimal As Decimal
    Public TotalPiecesCompletedInteger As Integer
    Public PricePerPieceDecimal As Decimal
    Public Thepiecepay As piecepay
    Public MessageString As String


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
        Dim PiecesCompletedInteger As Integer


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
            Else
                'call function
                PricePerPieceDecimal = PiecePrice(PiecesCompletedInteger)
                NumberOfWorkersInteger += 1
                'PiecesCompletedInteger = Integer.Parse(PiecesCompletedBox.Text)
                'DollarsEarnedDecimal = PricePerPieceDecimal * PiecesCompletedInteger
                'DollarsEarnedBox.Text = (PricePerPieceDecimal * PiecesCompletedInteger).ToString("C")
                'TotalPiecesCompletedInteger = PiecesCompletedInteger + TotalPiecesCompletedInteger
                'TotalPayDecimal = DollarsEarnedDecimal + TotalPayDecimal
                Thepiecepay = New piecepay(Integer.Parse(PiecesCompletedBox.Text), PricePerPieceDecimal)
                DollarsEarnedBox.Text = Thepiecepay.TotalPrice.ToString("c")
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

            'Display Summary Display Box 

            MessageString = "Number of pieces completed: " & piecepay.PieceCount & Environment.NewLine & Environment.NewLine &
                "Total Pay: " & piecepay.PriceTotal.ToString("c") & Environment.NewLine & Environment.NewLine &
                "Average Pay: " & (piecepay.PriceTotal / NumberOfWorkersInteger).ToString("C") & Environment.NewLine & Environment.NewLine &
                "Total Number of Workers: " & NumberOfWorkersInteger

            MessageBox.Show(MessageString, "Pieceworker summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub



    'displays information about the program
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Programmer: Douglas Shirilla Program:Ch12 Program 1", "About My Project", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            DollarsEarnedBox.Clear()
            PiecesCompletedBox.Clear()
            NameTextBox.Clear()
            NumberOfWorkersInteger = 0
            MessageString = ""

        End If
    End Sub


    'exit program
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
