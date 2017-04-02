'Programmer: Douglas Shirilla
'Class:COP 1332
'Instructor: Lisa Thomas
'Project: Chapter 8 Program 3
'Date:03/30/2016
'Purpose:Get user input for desired ticket purchase and give current cost plus make a summary form that allows a user to print out all information for current customer
'REVISED




Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    'Declare variables

    'declare array for ticket price
    Public TicketPriceDecimal() As Decimal =
        {10D, 15D, 27.5D, 40D}
    'declare array for number of each section sold
    Public NumofEachSectionInteger() As Integer =
        {0, 0, 0, 0}
    
    Public NumofGenTicketsInteger As Integer = 0
    Public NumofMezTicketsInteger As Integer = 0
    Public NumofOrcTicketsInteger As Integer = 0
    Public NumofBalTicketsInteger As Integer = 0
    Public TotalNumofTicketsInteger As Integer
    Public TotalCostDecimal As Decimal = 0D


    'determine cost of current purchase
    Private Sub CostButton_Click(sender As Object, e As EventArgs) Handles CostButton.Click
        Dim TicketCostIndexInteger As Integer
        Dim NumOfTicketsInteger As Integer
        'make sure user enters a numeric value for number of tickets
        Try
            TicketCostIndexInteger = SeatLocationList.SelectedIndex
            If TicketCostIndexInteger <> -1 Then
                NumOfTicketsInteger = Integer.Parse(NumofTicBox.Text)
                TicketCostIndexInteger = SeatLocationList.SelectedIndex
                PriceTextBox.Text = (TicketPriceDecimal(TicketCostIndexInteger) * NumOfTicketsInteger).ToString("c")
                If SeatLocationList.Text = "General" Then
                    NumofEachSectionInteger(0) += NumOfTicketsInteger
                End If
                If SeatLocationList.Text = "Mezzanine" Then
                    NumofEachSectionInteger(1) += NumOfTicketsInteger
                End If
                If SeatLocationList.Text = "Orchestra" Then
                    NumofEachSectionInteger(2) += NumOfTicketsInteger
                End If
                If SeatLocationList.Text = "Balcony" Then
                    NumofEachSectionInteger(3) += NumOfTicketsInteger
                End If
                TotalCostDecimal += (TicketPriceDecimal(TicketCostIndexInteger) * NumOfTicketsInteger).ToString("c")
                TotalNumofTicketsInteger += NumOfTicketsInteger
                TotCurCostText.Text = TotalCostDecimal.ToString("c")
            Else
                MessageBox.Show("Select an area of seating", "Data entry error", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Number of tickets must be numeric value", "Data entry value",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    'close program
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'clear current purchase information
    Private Sub ClearToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem1.Click
        NumofTicBox.Text = ""
        PriceTextBox.Text = ""
        TotCurCostText.Text = ""
    End Sub

    'clear all input that has been entered since execution
    Private Sub ClearAllToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem1.Click
        Dim MessageString As String
        Dim ResponseDialogResult As DialogResult

        'make sure user wants to delete all information
        MessageString = "Are you sure you want to clear all information that has been entered?"
        ResponseDialogResult = MessageBox.Show(MessageString, "Clear Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ResponseDialogResult = Windows.Forms.DialogResult.Yes Then
            NumofTicBox.Text = ""
            PriceTextBox.Text = ""
            NumofBalTicketsInteger = 0
            NumofGenTicketsInteger = 0
            NumofMezTicketsInteger = 0
            NumofOrcTicketsInteger = 0
            TotalCostDecimal = 0
            TotalNumofTicketsInteger = 0
            TotCurCostText.Text = ""
            NumofEachSectionInteger = {0, 0, 0, 0}
        End If

    End Sub

    Private Sub SummaryFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryFormToolStripMenuItem.Click

        'send gathered information to the summary form 
        SummaryForm.NumofBalBox.Text = NumofEachSectionInteger(3)
        SummaryForm.NumofGenBox.Text = NumofEachSectionInteger(0)
        SummaryForm.NumofMezBox.Text = NumofEachSectionInteger(1)
        SummaryForm.NumofOrcBox.Text = NumofEachSectionInteger(2)
        SummaryForm.TotTicBox.Text = TotalNumofTicketsInteger
        SummaryForm.TotCostBox.Text = TotalCostDecimal.ToString("c")
        SummaryForm.Show()
    End Sub


    'display an about box
    Private Sub AboutBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutBoxToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub
End Class
