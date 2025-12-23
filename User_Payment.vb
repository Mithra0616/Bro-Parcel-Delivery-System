Public Class User_Payment
    Private bookingForm As User_Booking_Form
    Private price As Decimal

    Public Sub New(form As User_Booking_Form, price As Decimal)
        InitializeComponent()
        bookingForm = form
        Me.price = price
    End Sub

    Private Sub User_Payment_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Display the total price in the read-only TextBox
            txtTotalPrice.Text = price.ToString("C") ' Format as currency
        Catch ex As Exception
            MessageBox.Show($"Error loading payment form: {ex.Message}")
        End Try
    End Sub

    Private Sub btnQR_Click(sender As Object, e As EventArgs) Handles btnQR.Click
        ' Navigate to the QR payment form
        Dim qrPayment As New User_QRPayment(bookingForm, price)
        qrPayment.Show()
        Me.Hide()
    End Sub

    Private Sub btnOnlineBanking_Click(sender As Object, e As EventArgs) Handles btnOnlineBanking.Click
        ' Navigate to the online banking payment form
        Dim onlineBanking As New User_OnlineBanking(bookingForm, price)
        onlineBanking.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Close the current form and show the admin page form
        Me.Hide() ' Hide the current form
        Dim BookingForm As New User_Booking_Form()
        BookingForm.Show()
    End Sub
End Class