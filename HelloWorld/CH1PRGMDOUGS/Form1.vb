'Program: Hello World
'Programmer: Douglas Shirilla
'Professor Lisa Thomas
'Date: 01/27/2016
'Purpose: To display the message "hello world" in various languages

Public Class Form1
    Private Printing As Object
    Public Property PrintForm1 As Object
    'displays the hello world message when a button is pressed
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles DisplayLabel.Click
    End Sub
    'displays "hello world" in english
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles EnglishButton.Click
        DisplayLabel.Text = "Hello World"
    End Sub
    'displays "hello world" in spanish
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles SpanishButton.Click
        DisplayLabel.Text = "Hola Mundo"
    End Sub
    'displays "hello world" in polish
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles PolishButton.Click
        DisplayLabel.Text = "Witaj świecie"
    End Sub
    'displays "hello world" in croatian
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles CroatianButton.Click
        DisplayLabel.Text = "Bok svijete"
    End Sub
    'exits and closes the program
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    'clears the contents of the display label
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayLabel.Text = ""
    End Sub
End Class