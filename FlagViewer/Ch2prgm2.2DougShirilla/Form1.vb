'Program:Flag Displayer
'Programmer: Douglas Shirilla
'Class: COP 1332
'Professor: Lisa Thomas
'Date: 02/03/2016
'Purpose: A form that allows the user to select various country flags with display options


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    'starts program with no flag displayed
    Private Sub FlagPictureBox_Click(sender As Object, e As EventArgs) Handles FlagPictureBox.Click
        FlagPictureBox.Visible = False
    End Sub
    'displays the united states flag
    Private Sub UnitedStatesRadio_CheckedChanged(sender As Object, e As EventArgs) Handles UnitedStatesRadio.CheckedChanged
        FlagPictureBox.Image = My.Resources.UNST0001
        CountryNameLabel.Text = "United States"
    End Sub
    'displays poland flag
    Private Sub PolandRadio_CheckedChanged(sender As Object, e As EventArgs) Handles PolandRadio.CheckedChanged
        FlagPictureBox.Image = My.Resources.POLA0001
        CountryNameLabel.Text = "Poland"
    End Sub
    'displays ireland flag
    Private Sub IrelandRadio_CheckedChanged(sender As Object, e As EventArgs) Handles IrelandRadio.CheckedChanged
        FlagPictureBox.Image = My.Resources.IREL0001
        CountryNameLabel.Text = "Ireland"
    End Sub
    'displays russia flag
    Private Sub RussiaRadio_CheckedChanged(sender As Object, e As EventArgs) Handles RussiaRadio.CheckedChanged
        FlagPictureBox.Image = My.Resources.RUSS0001
        CountryNameLabel.Text = "Russia"
    End Sub
    'displays the rebel alliance flag
    Private Sub RebelRadio_CheckedChanged(sender As Object, e As EventArgs) Handles RebelRadio.CheckedChanged
        FlagPictureBox.Image = My.Resources._51ak_nVSwQL__SX425_
        CountryNameLabel.Text = "Rebel Alliance"
    End Sub
    'displays form title when checked
    Private Sub TitleBox_CheckedChanged(sender As Object, e As EventArgs) Handles TitleBox.CheckedChanged
        TitleLabel.Visible = TitleBox.Checked
    End Sub
    'displays country name when checked 
    Private Sub CountryNameBox_CheckedChanged(sender As Object, e As EventArgs) Handles CountryNameBox.CheckedChanged
        CountryNameLabel.Visible = CountryNameBox.Checked
    End Sub
    'displays programmer name when checked
    Private Sub ProgrammerBox_CheckedChanged(sender As Object, e As EventArgs) Handles ProgrammerBox.CheckedChanged
        ProgNameLabel.Visible = ProgrammerBox.Checked
    End Sub
    'applys all display options to on
    Private Sub ApplyAllButton_Click(sender As Object, e As EventArgs) Handles ApplyAllButton.Click
        ProgrammerBox.Checked = True
        CountryNameBox.Checked = True
        TitleBox.Checked = True
    End Sub
    'clears all display options when clicked
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ProgrammerBox.Checked = False
        CountryNameBox.Checked = False
        TitleBox.Checked = False
    End Sub
    'closes and exits the program
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
