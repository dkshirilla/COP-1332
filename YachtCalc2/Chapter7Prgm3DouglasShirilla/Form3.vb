Imports Microsoft.VisualBasic.FileIO

Public Class ResForm

    Private ReservationTextFieldParser As TextFieldParser

    Private Sub ResForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim FileString As String = "reservation.txt"

        Try
            ReservationTextFieldParser = New TextFieldParser(FileString)
            ReservationTextFieldParser.TextFieldType = FieldType.Delimited
            ReservationTextFieldParser.SetDelimiters("/")
        Catch
            MessageBox.Show("Unable to read the file: " & FileString, "File Error")
        End Try
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        Dim FieldString() As String

        If Not ReservationTextFieldParser.EndOfData Then
            FieldString = ReservationTextFieldParser.ReadFields()
            TextParBox.Text = FieldString(0)
            TextHoursBox.Text = FieldString(1)
            TextSizeBox.Text = FieldString(2)
            TextTypeBox.Text = FieldString(3)
            TextCostBox.Text = FieldString(4)
        Else
            MessageBox.Show("No more records to display.", "End of Data")

        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class