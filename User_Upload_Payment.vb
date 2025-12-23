Imports Microsoft.Data.SqlClient
Public Class User_Upload_Payment
    Private bookingForm As User_Booking_Form
    Private price As Decimal

    Public Sub New(form As User_Booking_Form, price As Decimal)
        InitializeComponent()
        bookingForm = form
        Me.price = price
    End Sub

    Private Sub btnUploadReceipt_Click(sender As Object, e As EventArgs) Handles btnUploadReceipt.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "JPEG Image|*.jpg;*.jpeg|All Files|*.*"
        openFileDialog.Title = "Select Receipt Image"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            MessageBox.Show("Receipt uploaded successfully: " & filePath, "Upload Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PictureBoxPreview.Image = Image.FromFile(filePath)

            Dim trackingNumber As String = InputBox("Please enter the tracking number:", "Tracking Number")
            If Not String.IsNullOrEmpty(trackingNumber) Then
                If SaveReceiptToDatabase(trackingNumber, filePath) Then
                    ' If the receipt is saved successfully, navigate to Payment_Success form
                    Dim paymentSuccessForm As New Payment_Success()
                    paymentSuccessForm.Show()
                    Me.Hide() ' Hide the current form
                Else
                    MessageBox.Show("Failed to save the receipt to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Tracking number cannot be empty.")
            End If
        End If
    End Sub

    Private Function SaveReceiptToDatabase(trackingNumber As String, receiptPath As String) As Boolean
        Dim connectionString As String = "Data Source=LAPTOP-NHFH6U0I;Initial Catalog=BroParcelService;Integrated Security=True;Trust Server Certificate=True"
        Dim query As String = "INSERT INTO user_upload_receipt (TrackingNumber, ReceiptPath, Status) VALUES (@TrackingNumber, @ReceiptPath, @Status)"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@TrackingNumber", trackingNumber)
                command.Parameters.AddWithValue("@ReceiptPath", receiptPath)
                command.Parameters.AddWithValue("@Status", "Pending")

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    Return True ' Indicate success
                Catch ex As Exception
                    MessageBox.Show($"Error saving receipt: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False ' Indicate failure
                End Try
            End Using
        End Using
    End Function

    Private Sub User_Payment_Upload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide() ' Hide the current form
        Dim UserPayment As New User_Payment(bookingForm, price)
        UserPayment.Show()
    End Sub
End Class