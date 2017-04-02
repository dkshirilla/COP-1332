'Project: Chapter 3 Program 4
'Date: 02/08/2016
'Programmer: Douglas Shirilla
'Description: Calculate charges for a group use of the studio then display summary information
'after all groups have been entered
'Professor: Lisa Thomas COP 1220



Public Class Form1
    'Declare variables and the constant 
    Private GroupCountInteger As Integer = 0
    Private AvgChargDecimal, TotalChargeSumDecimal, MinutesUsedDecimal, CurrentChargesDecimal As Decimal
    Const RENTAL_RATE_PER_MINUTE_Decimal As Decimal = 3.333D
    'set up calculate button to perform calculations and output the results to textboxes
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
            'make sure minutes entered value is numeric using a try/catch statement 
        Try
            If GroupNameTextBox.Text > "" Then
                MinutesUsedDecimal = Decimal.Parse(MinutesUsedTextBox.Text)
                'perform the rest of the calculations
                GroupCountInteger += 1
                CurrentChargesDecimal = MinutesUsedDecimal * RENTAL_RATE_PER_MINUTE_Decimal
                TotalChargeSumDecimal = CurrentChargesDecimal + TotalChargeSumDecimal
                AvgChargDecimal = TotalChargeSumDecimal / GroupCountInteger
                'displays output
                CurrentChargesTextBox.Text = CurrentChargesDecimal.ToString("C")
                TotalChargesGroupsTextBox.Text = TotalChargeSumDecimal.ToString("C")
                AvgChargTextBox.Text = AvgChargDecimal.ToString("C")
                TotalNumGroupsTextBox.Text = GroupCountInteger.ToString("D")
            Else
                MessageBox.Show("Group name text box cannot be blank", "Data Entry Error", MessageBoxButtons.OK)
                With GroupNameTextBox
                    .Focus()
                End With
            End If
        Catch Exception As FormatException
            MessageBox.Show("A value must be entered for minutes and it must be numeric", "Data Entry Error", MessageBoxButtons.OK)
            With MinutesUsedTextBox
                .Focus()
                .Clear()
            End With
        End Try
           End Sub

    'clears entered data
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'clear text boxes and return all values to 0
        TotalNumGroupsTextBox.Clear()
        AvgChargTextBox.Clear()
        TotalChargesGroupsTextBox.Clear()
        CurrentChargesTextBox.Clear()
        GroupNameTextBox.Clear()
        MinutesUsedTextBox.Clear()
        GroupCountInteger = 0
        TotalChargeSumDecimal = 0
        With GroupNameTextBox
            .Clear()
            .Focus()
        End With
    End Sub
    ' close the program
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub


End Class
