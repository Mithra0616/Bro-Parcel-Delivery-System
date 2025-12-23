Public Class User_Page
    ' Event handler for when the User Page form is loaded
    Private Sub User_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Code to execute when the User Page form loads (if needed)
    End Sub

    ' Event handler for the "Delivery Service" button
    Private Sub btnDeliveryService_Click(sender As Object, e As EventArgs) Handles btnDeliveryService.Click
        Dim bookDeliveryForm As New User_Booking_Form() ' Create an instance of the User_Booking_Form
        bookDeliveryForm.Show() ' Show the book delivery form
        Me.Hide() ' Hide the user page
    End Sub

    ' Event handler for the "Back" button
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Navigate back to the main menu form
        Me.Hide() ' Hide the current form
        Dim mainMenu As New Main_Menu() ' Create an instance of the MainMenu form
        mainMenu.Show() ' Show the Main_MenuForm
    End Sub

    ' Event handler for the "Track Parcel" button
    Private Sub btnTrackParcel_Click(sender As Object, e As EventArgs) Handles btnTrackParcel.Click
        Dim trackItemForm As New User_Track_Parcel() ' Create an instance of the User_Track_Parcel form
        trackItemForm.Show() ' Show the track  form
        Me.Hide() ' Hide the user page
    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

    End Sub

    ' Event handler for the "Profile" button
    Private Sub btnUserProfile_Click(sender As Object, e As EventArgs) Handles btnUserProfile.Click
        Dim userProfile As New User_Profile()
        userProfile.Show() ' Show the track item form
        Me.Hide() ' Hide the user page
    End Sub
End Class