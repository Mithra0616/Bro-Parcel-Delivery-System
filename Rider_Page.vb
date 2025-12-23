Public Class Rider_Page
    Private Sub btnParcelStatus_Click(sender As Object, e As EventArgs) Handles btnParcelStatus.Click
        Dim DeliveryForm As New Rider_Parcel_Update(Admin_Booking_List) ' Assuming you have a form for booking delivery
        DeliveryForm.Show() ' Show the book delivery form
        Me.Hide() ' Hide the user page
    End Sub

    Private Sub btnParcelHistory_Click(sender As Object, e As EventArgs) Handles btnParcelHistory.Click
        Dim DeliveryForm As New Rider_Parcel_History() ' Assuming you have a form for booking delivery
        DeliveryForm.Show() ' Show the past delivery form
        Me.Hide() ' Hide the user page
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide() ' Hide the current form
        Dim UserPayment As New Rider_Login()
        UserPayment.Show()
    End Sub

    Private Sub Rider_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class