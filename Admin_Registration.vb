Imports Microsoft.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Admin_Registration

    Private connectionString As String = "Data Source=LAPTOP-NHFH6U0I;Initial Catalog=BroParcelService;Integrated Security=True;Trust Server Certificate=True"
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Validate input fields
        If String.IsNullOrWhiteSpace(txtFullName.Text) OrElse String.IsNullOrWhiteSpace(txtStudentID.Text) OrElse
           String.IsNullOrWhiteSpace(txtPassword.Text) OrElse String.IsNullOrWhiteSpace(txtPhoneNumber.Text) OrElse
           String.IsNullOrWhiteSpace(txtEmail.Text) OrElse Not Regex.IsMatch(txtEmail.Text, "^[^@\s]+@[^@\s]+\.[^@\s]+$") Then
            MessageBox.Show("Please fill in all fields correctly, including a valid email address.")
            Return ' Exit the method if validation fails
        End If

        ' Check if the photo has been uploaded
        If String.IsNullOrWhiteSpace(picAdminPhoto.ImageLocation) Then
            MessageBox.Show("Please upload a photo.")
            Return ' Exit the method if no photo is uploaded
        End If

        ' Check if the Student ID already exists in the database
        Dim studentIdExists As Boolean = False
        Using connection As New SqlConnection(connectionString)
            Dim checkQuery As String = "SELECT COUNT(*) FROM admin_reg WHERE StudentId = @StudentId"
            Dim checkCommand As New SqlCommand(checkQuery, connection)
            checkCommand.Parameters.AddWithValue("@StudentId", txtStudentID.Text) ' Parameterized query to prevent SQL injection

            connection.Open()
            studentIdExists = Convert.ToInt32(checkCommand.ExecuteScalar()) > 0
        End Using

        If studentIdExists Then
            MessageBox.Show("This Student ID is already registered. Please use a different Student ID.")
            Return ' Exit the method if the Student ID is already registered
        End If

        ' Ensure the directory for storing photos exists
        Dim photoDirectory As String = "C:\AdminPhotos\"
        If Not Directory.Exists(photoDirectory) Then
            Directory.CreateDirectory(photoDirectory)
        End If

        ' Generate a unique filename to avoid conflicts when saving the photo
        Dim fileName As String = Path.GetFileName(picAdminPhoto.ImageLocation)
        Dim uniqueFileName As String = Path.GetFileNameWithoutExtension(fileName) & "_" & Guid.NewGuid().ToString() & Path.GetExtension(fileName)
        Dim photoPath As String = Path.Combine(photoDirectory, uniqueFileName)

        ' Copy the uploaded file to the specified directory
        File.Copy(picAdminPhoto.ImageLocation, photoPath, True)

        ' Database interaction to register the new admin
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO admin_reg (FullName, StudentId, Password, PhoneNumber, Email, PhotoPath, IsApproved) 
                                   VALUES (@FullName, @StudentId, @Password, @PhoneNumber, @Email, @PhotoPath, 0); 
                                   SELECT SCOPE_IDENTITY();"
                Dim command As New SqlCommand(query, connection)

                command.Parameters.AddWithValue("@FullName", txtFullName.Text)
                command.Parameters.AddWithValue("@StudentId", txtStudentID.Text)
                command.Parameters.AddWithValue("@Password", txtPassword.Text)
                command.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
                command.Parameters.AddWithValue("@Email", txtEmail.Text)
                command.Parameters.AddWithValue("@PhotoPath", photoPath)

                connection.Open()
                Dim newAdminId As Integer = Convert.ToInt32(command.ExecuteScalar()) ' Get the new Admin ID

                ' Show a message with the new Admin ID and login advice
                MessageBox.Show($"Registration successful! Your Admin ID is {newAdminId}. You can try to log in after 12 hours for approval by an existing admin.")
                ClearFields() ' Call the method to clear input fields after successful registration
            End Using
        Catch ex As Exception
            ' Handle any errors that occur during database interaction
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub txtVillage_TextChanged(sender As Object, e As EventArgs) Handles txtVillage.TextChanged
        txtVillage.Text = txtVillage.Text.ToUpper() ' Convert the text to uppercase
        txtVillage.SelectionStart = txtVillage.Text.Length ' Set the cursor to the end of the text
    End Sub

    ' Event handler for the Full Name text box to convert input to uppercase
    Private Sub txtFullName_TextChanged(sender As Object, e As EventArgs) Handles txtFullName.TextChanged
        txtFullName.Text = txtFullName.Text.ToUpper() ' Convert the text to uppercase
        txtFullName.SelectionStart = txtFullName.Text.Length ' Set the cursor to the end of the text
    End Sub

    ' Method to clear input fields
    Private Sub ClearFields()
        txtFullName.Text = ""
        txtStudentID.Text = ""
        txtPassword.Text = ""
        txtPhoneNumber.Text = ""
        txtEmail.Text = "" ' Clear the email field
        picAdminPhoto.Image = Nothing ' Clear the PictureBox image
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            picAdminPhoto.ImageLocation = openFileDialog.FileName
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Close the current form and show the main menu form
        Me.Hide() ' Hide the current form
        Dim mainMenu As New Main_Menu() ' Create an instance of the MainMenu form
        mainMenu.Show() ' Show the MainMenuForm
    End Sub
End Class