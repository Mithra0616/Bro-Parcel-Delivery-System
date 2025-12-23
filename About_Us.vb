Public Class About_Us
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Close the current form and show the main menu form
        Hide() ' Hide the current form
        Dim mainMenu As New Main_Menu ' Create an instance of the MainMenu form
        mainMenu.Show() ' Show the MainMenuForm
    End Sub
End Class