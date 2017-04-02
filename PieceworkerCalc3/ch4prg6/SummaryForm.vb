Public Class SummaryForm
   

    Private Sub SummaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TotalPiecesBox.Text = Form1.TotalPiecesCompletedInteger
        TotalPayText.Text = Form1.TotalPayDecimal.ToString("C")
        AvgPayBox.Text = (Form1.TotalPayDecimal / Form1.NumberOfWorkersInteger).ToString("C")
        numofworktextbox.Text = Form1.NumberOfWorkersInteger
    End Sub

    Private Sub CloseSummaryButton_Click(sender As Object, e As EventArgs) Handles CloseSummaryButton.Click
        Me.Hide()
    End Sub
End Class