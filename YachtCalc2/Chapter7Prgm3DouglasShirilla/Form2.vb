Public Class SummaryForm
    Private Sub SummaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumofChartBox.Text = Form1.NumofChartersInteger.ToString()
        AvgHoursBox.Text = Form1.AvgHoursChartDecimal.ToString()
        TotalRevBox.Text = Form1.TotalRevenueInteger.ToString("c")
    End Sub


    Private Sub PrintPreviewSum_Click(sender As Object, e As EventArgs) Handles PrintPreviewSum.Click
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


        PrintLineString = "Total Number of Charters: " & Form1.NumofChartersInteger.ToString() 

        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, 100, 85)

        PrintLineString = "Average Hours: " & Form1.AvgHoursChartDecimal.ToString()

        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, 100, 115)

        PrintLineString = "Total Revenue: " & Form1.TotalRevenueInteger.ToString("c")

        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, 100, 135)

        e.Graphics.DrawString("Charter Summary", PrintFont, Brushes.Black, 100,
                              25)

        VerticalPrintLocationSingle += LineHeightSingle

        e.Graphics.DrawString("Developed by: Douglas Shirilla", HeadingFont, Brushes.Black, 100, 55)

        VerticalPrintLocationSingle += LineHeightSingle * 2




    End Sub
End Class