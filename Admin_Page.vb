Public Class Admin_Page
    Private Sub Admin_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Event handler for the "Accept New Rider" button
    Private Sub btnAcceptNewRider_Click(sender As Object, e As EventArgs) Handles btnAcceptNewRider.Click
        Dim riderForm As New Rider_Approval()
        riderForm.Show()
        Me.Hide() ' Optional: Hide the current form
    End Sub

    ' Event handler for the "Accept New Admin" button
    Private Sub btnAcceptNewAdmin_Click(sender As Object, e As EventArgs) Handles btnAcceptNewAdmin.Click
        Dim adminForm As New Admin_Approval()
        adminForm.Show()
        Me.Hide() ' Hide the current form
    End Sub

    ' Event handler for the "Booking_List" button
    Private Sub btnBookingList_Click(sender As Object, e As EventArgs) Handles btnBookingList.Click
        Dim bookingForm As New Admin_Booking_List()
        bookingForm.Show()
        Me.Hide() ' Hide the current form
    End Sub

    ' Event handler for the "Finance" button
    Private Sub btnFinance_Click(sender As Object, e As EventArgs) Handles btnFinance.Click
        Dim financeForm As New Admin_Finance()
        financeForm.Show()
        Me.Hide() ' Hide the current form
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Close the current form and show the main menu form
        Me.Hide()
        Dim adminLogin As New Admin_Login()
        adminLogin.Show()
    End Sub
End Class