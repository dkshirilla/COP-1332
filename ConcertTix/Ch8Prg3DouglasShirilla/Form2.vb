'Programmer:Douglas Shirilla
'Summary form for chapter 8 program 3

Public Class SummaryForm


    'enable the choice to close the form
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    'enable print preview
    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load
    End Sub


    'declare printing information to allow the summary to be printed
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim PrintFont As New Font("Arial", 16)
        Dim HeadingFont As New Font("Arial", 16, FontStyle.Bold)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle = e.MarginBounds.Top
        Dim PrintLineString As String

        e.Graphics.DrawString("Ticket Sales Summary", PrintFont, Brushes.Black, HorizontalPrintLocationSingle,
                              VerticalPrintLocationSingle)

        VerticalPrintLocationSingle += LineHeightSingle

        e.Graphics.DrawString("Developed by Douglas Shirilla", PrintFont, Brushes.Black, HorizontalPrintLocationSingle,
                              VerticalPrintLocationSingle)

        VerticalPrintLocationSingle += LineHeightSingle * 2

        e.Graphics.DrawString("Ticket summary list:", HeadingFont, Brushes.Black, HorizontalPrintLocationSingle, 200)

        PrintLineString = "The number of Balcony seats sold: " & Form1.NumofEachSectionInteger(3) & Environment.NewLine & "The number of General seats sold: " & Form1.NumofEachSectionInteger(0) & Environment.NewLine & "The number of Mezzanine seats sold: " & Form1.NumofEachSectionInteger(1) &
            Environment.NewLine & "The number of Orchestra seats sold: " & Form1.NumofEachSectionInteger(2) & Environment.NewLine & Environment.NewLine & Environment.NewLine & "The total number of tickets sold: " & Form1.TotalNumofTicketsInteger & Environment.NewLine & "The total cost of all ticket sales is: " & Form1.TotalCostDecimal.ToString("C")


        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, 240)

    End Sub

    'show a print preview
    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

End Class