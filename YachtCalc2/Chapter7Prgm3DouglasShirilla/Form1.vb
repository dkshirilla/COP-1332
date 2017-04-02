Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class Form1
    Public NumofHoursInteger As Integer
    Public NumofChartersInteger As Integer = 0
    Public AvgHoursChartDecimal As Decimal
    Public TotalRevenueInteger As Integer
    Public IsDirtyBoolean As Boolean
    ' declare price constants for boat sizes
    Const TWENTY_TWO_Decimal As Decimal = 95D
    Const TWENTY_FOUR_Decimal As Decimal = 137D
    Const THIRTY_Decimal As Decimal = 160D
    Const THIRTY_TWO_Decimal As Decimal = 192D
    Const THIRTY_SIX_Decimal As Decimal = 250D
    Const THIRTY_EIGHT_Decimal As Decimal = 400D
    Const FORTY_FIVE_Decimal As Decimal = 550D



    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ResponseDialogResult As DialogResult
        Dim YachttypelistString As String

        Try
            Dim YachttypeStreamReader As StreamReader =
            New StreamReader("yachttype.txt")
            Do Until YachttypeStreamReader.Peek = -1
                YachttypelistString = YachttypeStreamReader.ReadLine()
                YachttypeBox.Items.Add(YachttypelistString)
            Loop
            YachttypeStreamReader.Close()

        Catch ex As Exception
            ResponseDialogResult = MessageBox.Show("Create a new file?", "File not found", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ResponseDialogResult = Windows.Forms.DialogResult.No Then
                Me.Close()
            End If

        End Try
    End Sub
    Private Sub AddYachtTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddYachtTypeToolStripMenuItem.Click
        With YachttypeBox
            If .Text <> "" Then
                Dim ItemFoundBoolean As Boolean
                Dim ItemIndexInteger As Integer
                Do Until ItemFoundBoolean Or ItemIndexInteger = .Items.Count
                    If .Text = .Items(ItemIndexInteger).ToString() Then
                        ItemFoundBoolean = True
                        Exit Do
                    Else
                        ItemIndexInteger += 1
                    End If
                Loop
                If ItemFoundBoolean Then
                    MessageBox.Show("Duplicate item.", "Add Failed", MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation)
                Else : .Items.Add(.Text)
                    .Text = ""
                End If
            Else
                MessageBox.Show("Enter a yacht type to add", "Missing Data", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation)
            End If
            .Focus()
        End With
    End Sub

    Private Sub RemoveYachtTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveYachtTypeToolStripMenuItem.Click
        With YachttypeBox
            If .SelectedIndex <> -1 Then
                .Items.RemoveAt(.SelectedIndex)
            Else
                MessageBox.Show("First select the yacht type to remove.", "No Selection Made",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End With
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Dim TotalHoursInteger As Integer
        Dim ChartCostInteger As Integer
        Try
            If HoursTextBox.Text = "" Then
                MessageBox.Show("Hours chartered box cannot be left blank", "Data entry error",
                                MessageBoxButtons.OK)
            ElseIf YachttypeBox.Text = "" Then
                MessageBox.Show("A yacht type must be selected from the list", "Data entry error",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf YachtSizeList.Text = "" Then
                MessageBox.Show("A yacht size must be selected from the list", "Data entry error",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf PartyTextBox.Text = "" Then
                MessageBox.Show("A party name must be entered", "Data entry error",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else : NumofHoursInteger = Integer.Parse(HoursTextBox.Text)
                If YachtSizeList.Text = "22" Then
                    ChartCostInteger = (TWENTY_TWO_Decimal * NumofHoursInteger)
                ElseIf YachtSizeList.Text = "24" Then
                    ChartCostInteger = (TWENTY_FOUR_Decimal * NumofHoursInteger)
                ElseIf YachtSizeList.Text = "30" Then
                    ChartCostInteger = (THIRTY_Decimal * NumofHoursInteger)
                ElseIf YachtSizeList.Text = "32" Then
                    ChartCostInteger = (THIRTY_TWO_Decimal * NumofHoursInteger)
                ElseIf YachtSizeList.Text = "36" Then
                    ChartCostInteger = (THIRTY_SIX_Decimal * NumofHoursInteger)
                ElseIf YachtSizeList.Text = "38" Then
                    ChartCostInteger = (THIRTY_EIGHT_Decimal * NumofHoursInteger)
                ElseIf YachtSizeList.Text = "45" Then
                    ChartCostInteger = (FORTY_FIVE_Decimal * NumofHoursInteger)
                End If
                CostTextBox.Text = ChartCostInteger.ToString("c")
                TotalRevenueInteger = ChartCostInteger + TotalRevenueInteger
                TotalHoursInteger = NumofHoursInteger + TotalHoursInteger
                NumofChartersInteger += 1
                AvgHoursChartDecimal = TotalHoursInteger / NumofChartersInteger
            End If
        Catch ex As Exception
            MessageBox.Show("Hours must be numeric and an integer value", "Data entry error",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            With HoursTextBox
                .Focus()
                .SelectAll()
            End With
        End Try

    End Sub

    Private Sub DisplayCountOfYachtTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayCountOfYachtTypeToolStripMenuItem.Click
        Dim MessageString As String

        MessageString = "The number of yacht types is " & YachttypeBox.Items.Count & "."
        MessageBox.Show(MessageString, "Yacht Count", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AboutFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutFormToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub PrintSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintSummaryToolStripMenuItem.Click
        SummaryForm.ShowDialog()
    End Sub


   
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim FileString As String = "reservation.txt"
        Dim RecordString As String = PartyTextBox.Text & "/" & HoursTextBox.Text & "/" & YachtSizeList.Text & "/" & YachttypeBox.Text & "/" & CostTextBox.Text & Environment.NewLine
        My.Computer.FileSystem.WriteAllText(FileString, RecordString, True)
        Dim NumberItemsInteger As Integer

        Dim YachtStreamWriter As StreamWriter = New StreamWriter("yachttype.txt", False)

        NumberItemsInteger = YachttypeBox.Items.Count - 1
        For IndexInteger As Integer = 0 To NumberItemsInteger
            YachtStreamWriter.WriteLine(YachttypeBox.Items(IndexInteger))
        Next IndexInteger
        YachtStreamWriter.Close()
        IsDirtyBoolean = False
        Me.Close()
    End Sub



    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        PartyTextBox.Text = ""
        CostTextBox.Text = ""
        HoursTextBox.Text = ""
        YachttypeBox.Text = ""
        CostTextBox.Text = ""
        YachtSizeList.Text = ""
    End Sub

    Private Sub PrintYachtTypesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintYachtTypesToolStripMenuItem.Click
        PrintPreviewDialog1.Document = PrintDocument2
        PrintPreviewDialog1.ShowDialog()
    End Sub


    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim PrintFont As New Font("Arial", 16)
        Dim HeadingFont As New Font("Arial", 16, FontStyle.Bold)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle = e.MarginBounds.Top
        Dim PrintLineString As String

        e.Graphics.DrawString("Charter List Summary", PrintFont, Brushes.Black, HorizontalPrintLocationSingle,
                              VerticalPrintLocationSingle)

        VerticalPrintLocationSingle += LineHeightSingle

        e.Graphics.DrawString("Developed by:Douglas Shirilla", PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)

        VerticalPrintLocationSingle += LineHeightSingle * 2

        PrintLineString = "            "

        e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)

        VerticalPrintLocationSingle += LineHeightSingle

        For ListIndexInteger As Integer = 0 To Me.YachttypeBox.Items.Count - 1

            PrintLineString = Me.YachttypeBox.Items(ListIndexInteger).ToString()

            e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)

            VerticalPrintLocationSingle += LineHeightSingle

        Next ListIndexInteger
    End Sub

    


    'Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    ' Dim ResponseDialogResult As DialogResult
    'Dim MessageString As String = "Yacht list has changed. Save the List?"
    'ResponseDialogResult = MessageBox.Show(MessageBox.Show(MessageString, "Yacht List Changed", MessageBoxButtons.YesNo,
    '' MessageBoxIcon.Question))
    ' If ResponseDialogResult = DialogResult.Yes Then
    'SaveYachtTypeListToolStripMenuItem_Click(sender, e)
    'End If
    'End Sub

    Private Sub ReservationFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservationFormToolStripMenuItem.Click
        ResForm.Show()
    End Sub
End Class

