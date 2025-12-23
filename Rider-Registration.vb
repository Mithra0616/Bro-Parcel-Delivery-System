Imports System.IO
Imports Microsoft.Data.SqlClient

Public Class Rider_Registration

    ' Connection string to your SQL database
    Private connectionString As String = "Data Source=LAPTOP-NHFH6U0I;Initial Catalog=BroParcelService;Integrated Security=True;Trust Server Certificate=True"

    Private Sub Rider_Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnUploadPhoto_Click(sender As Object, e As EventArgs) Handles btnUploadPhoto.Click
        UploadPhoto(picRiderPhoto)
    End Sub

    Private Sub btnUploadCarSticker_Click(sender As Object, e As EventArgs) Handles btnUploadCarSticker.Click
        UploadPhoto(picCarSticker)
    End Sub

    Private Sub btnUploadLicense_Click(sender As Object, e As EventArgs) Handles btnUploadLicense.Click
        UploadPhoto(picLicensePhoto)
    End Sub

    Private Sub UploadPhoto(pictureBox As PictureBox)
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                pictureBox.Image = Image.FromFile(openFileDialog.FileName)
            End If
        End Using
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim fullname As String = txtFullName.Text
        Dim studentID As String = txtStudentID.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhoneNumber.Text
        Dim vehicleType As String = cboVehicleType.SelectedItem.ToString()
        Dim carPlate As String = txtCarPlate.Text
        Dim password As String = txtPassword.Text

        ' Convert images to byte array
        Dim studentPhoto As Byte() = If(picRiderPhoto.Image IsNot Nothing, ImageToByteArray(picRiderPhoto.Image), Nothing)
        Dim carSticker As Byte() = If(picCarSticker.Image IsNot Nothing, ImageToByteArray(picCarSticker.Image), Nothing)
        Dim licensePhoto As Byte() = If(picLicensePhoto.Image IsNot Nothing, ImageToByteArray(picLicensePhoto.Image), Nothing)

        ' Check if all required photos are uploaded
        If studentPhoto Is Nothing OrElse carSticker Is Nothing OrElse licensePhoto Is Nothing Then
            MessageBox.Show("Please upload all required photos.")
            Return
        End If

        ' Insert data into the database
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand("INSERT INTO rider_reg (FullName, StudentID, Email, PhoneNumber, VehicleType, CarPlate, Password, StudentPhoto, CarStickerPhoto, LicensePhoto) VALUES (@FullName, @StudentID, @Email, @PhoneNumber, @VehicleType, @CarPlate, @Password, @StudentPhoto, @CarStickerPhoto, @LicensePhoto)", connection)

            command.Parameters.AddWithValue("@FullName", fullname)
            command.Parameters.AddWithValue("@StudentID", studentID)
            command.Parameters.AddWithValue("@Email", email)
            command.Parameters.AddWithValue("@PhoneNumber", phone)
            command.Parameters.AddWithValue("@VehicleType", vehicleType)
            command.Parameters.AddWithValue("@CarPlate", carPlate)
            command.Parameters.AddWithValue("@Password", password)
            command.Parameters.AddWithValue("@StudentPhoto", studentPhoto)
            command.Parameters.AddWithValue("@CarStickerPhoto", carSticker)
            command.Parameters.AddWithValue("@LicensePhoto", licensePhoto)

            connection.Open()
            command.ExecuteNonQuery()
            MessageBox.Show("Registration successful!")
        End Using
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtFullName.Clear()
        txtStudentID.Clear()
        txtEmail.Clear()
        txtPhoneNumber.Clear()
        txtCarPlate.Clear()
        txtPassword.Clear()
        cboVehicleType.SelectedIndex = -1 ' Clear the selected item in the combo box
        picRiderPhoto.Image = Nothing ' Clear the photo
        picCarSticker.Image = Nothing ' Clear the car sticker photo
        picLicensePhoto.Image = Nothing ' Clear the license photo
    End Sub


    Private Function ImageToByteArray(image As Image) As Byte()
        If image Is Nothing Then Return Nothing
        Using ms As New MemoryStream()
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
            Return ms.ToArray()
        End Using
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Close the current form and show the login form
        Me.Hide() ' Hide the current form
        Dim riderlogin As New Rider_Login() ' Create an instance of the MainMenu form
        riderlogin.Show() ' Show the MainMenuForm
    End Sub
End Class