Public Class User_QRPayment
    Private bookingForm As User_Booking_Form
    Private price As Decimal

    ' Updated Constructor
    Public Sub New(booking As User_Booking_Form, price As Decimal)
        InitializeComponent()
        bookingForm = booking
        Me.price = price
    End Sub

    Private Sub User_QRPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide() ' Hide the current form
        Dim UserPayment As New User_Payment(bookingForm, price)
        UserPayment.Show()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Create an instance of the Payment Upload form with the current booking form
        Dim PaymentUpload As New User_Upload_Payment(bookingForm, price) ' Pass the current instance (booking form)
        PaymentUpload.Show() ' Navigate to the payment upload form
        Me.Hide() ' Hide the current form
    End Sub
End Class