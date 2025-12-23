Imports System.IO
Imports Microsoft.Data.SqlClient

Public Class User_Booking_Form
    Private photoPath As String ' To store the path of the uploaded photo
    Private parcelPrices As Dictionary(Of String, Decimal)

    ' Constructor to initialize the parcelPrices dictionary
    Public Sub New()
        InitializeComponent()
        parcelPrices = New Dictionary(Of String, Decimal) From {
            {"Parcel K", 0.5D},
            {"Parcel A", 1D},
            {"Parcel B", 2D},
            {"Parcel C", 3D},
            {"Parcel D", 3.5D},
            {"Parcel E", 4.5D}
        }
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                photoPath = openFileDialog.FileName

                If File.Exists(photoPath) Then
                    Try
                        PictureBox1.Image = Image.FromFile(photoPath)
                        MessageBox.Show("Image loaded successfully!")
                    Catch ex As Exception
                        MessageBox.Show($"Error loading image: {ex.Message}")
                    End Try
                Else
                    MessageBox.Show("The selected file does not exist.")
                End If
            Else
                MessageBox.Show("No file selected.")
            End If
        End Using
    End Sub

    Private Sub btnProceedToPayment_Click(sender As Object, e As EventArgs) Handles btnProceedToPayment.Click
        Try
            Dim recipientName As String = txtNameOnParcel.Text
            Dim trackingNumber As String = txtTrackingNumber.Text
            Dim village As String = txtVillage.Text
            Dim parcelSize As String = GetSelectedParcelSize()

            ' Validate fields
            If String.IsNullOrEmpty(recipientName) OrElse String.IsNullOrEmpty(trackingNumber) OrElse String.IsNullOrEmpty(parcelSize) OrElse String.IsNullOrEmpty(photoPath) OrElse String.IsNullOrEmpty(village) Then
                MessageBox.Show("Please fill in all fields and upload a photo.")
                Return
            End If

            Dim price As Decimal = CalculatePrice(parcelSize)

            ' Check if student ID is valid before proceeding
            Dim currentStudentId As Integer = GetCurrentStudentId()

            If currentStudentId <= 0 Then
                MessageBox.Show("Please log in first.")
                Return
            End If

            SaveBookingToDatabase(recipientName, parcelSize, price, currentStudentId, trackingNumber, village)

            MessageBox.Show($"Booking successful! Total price: {price:C}. Proceeding to payment...")

            Dim userPayment As New User_Payment(Me, price)
            userPayment.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        End Try
    End Sub

    Private Function GetSelectedParcelSize() As String
        If rbtnParcelK.Checked Then Return "Parcel K"
        If rbtnParcelA.Checked Then Return "Parcel A"
        If rbtnParcelB.Checked Then Return "Parcel B"
        If rbtnParcelC.Checked Then Return "Parcel C"
        If rbtnParcelD.Checked Then Return "Parcel D"
        If rbtnParcelE.Checked Then Return "Parcel E"

        MessageBox.Show("Please select a parcel size.")
        Return String.Empty
    End Function

    Private Function CalculatePrice(parcelSize As String) As Decimal
        If parcelPrices.ContainsKey(parcelSize) Then
            Return parcelPrices(parcelSize)
        End If
        Return 0D
    End Function

    Private Sub SaveBookingToDatabase(recipientName As String, parcelSize As String, price As Decimal, studentId As Integer, trackingNumber As String, village As String)
        Try
            Dim connectionString As String = "Data Source=LAPTOP-NHFH6U0I;Initial Catalog=BroParcelService;Integrated Security=True;Trust Server Certificate=True"
            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand("INSERT INTO user_booking_delivery (NameOnParcel, ParcelSize, PhotoPath, StudentID, Price, BookingDate, TrackingNumber, Village, Status) VALUES (@NameOnParcel, @ParcelSize, @PhotoPath, @StudentID, @Price, @BookingDate, @TrackingNumber, @Village, @Status)", connection)

                command.Parameters.AddWithValue("@NameOnParcel", recipientName)
                command.Parameters.AddWithValue("@ParcelSize", parcelSize)
                command.Parameters.AddWithValue("@PhotoPath", photoPath)
                command.Parameters.AddWithValue("@StudentID", studentId)
                command.Parameters.AddWithValue("@Price", price)
                command.Parameters.AddWithValue("@BookingDate", DateTime.Now)
                command.Parameters.AddWithValue("@TrackingNumber", trackingNumber)
                command.Parameters.AddWithValue("@Village", village)
                command.Parameters.AddWithValue("@Status", "Pending") ' Set the status to 'Pending'

                connection.Open()
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error saving booking to database: {ex.Message}")
        End Try
    End Sub

    Private Function GetCurrentStudentId() As Integer
        ' Using the shared StudentID from User_Login
        Dim studentId As Integer = User_Login.StudentID
        If studentId <= 0 Then
            MessageBox.Show("Please log in first.")
            Return -1
        End If
        Return studentId
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Dim userpage As New User_Page()
        userpage.Show()
    End Sub

    Private Sub User_Booking_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Debugging the student ID on form load
        MessageBox.Show("CurrentStudentId on Load: " & Usersession.CurrentStudentId)
    End Sub

    Public Property Price As Decimal
End Class