Imports System.Text
Imports Microsoft.Data.SqlClient
Imports System.Security.Cryptography ' Contains classes for cryptographic operations, including hashing.

Public Class User_Login

    Public Shared StudentID As Integer ' Declare it as Shared so it can be accessed across forms

    ' Paths to the images for the password visibility toggle button
    Private EyeWithSlashPath As String = "C:\Users\User\Downloads\sample_button_images\with_slash.png"
    Private EyeWithoutSlashPath As String = "C:\Users\User\Downloads\sample_button_images\without_slash.png"

    ' Declare a boolean to track the password visibility state
    Private isPasswordVisible As Boolean = False

    Private Sub User_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mask the password field with dots
        txtPassword.PasswordChar = "•"c

        ' Attempt to load the initial button image
        Try
            If IO.File.Exists(EyeWithoutSlashPath) Then
                btnShow.Image = Image.FromFile(EyeWithoutSlashPath)
            Else
                MessageBox.Show("The image file for the 'without slash' button is missing. Please check the path.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading image: " & ex.Message)
        End Try
    End Sub

    ' Event handler for the Sign Up button
    Private Sub btnSignUp_Click_1(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim registrationForm As New User_Registration ' Create an instance of the User_Registration form
        registrationForm.Show() ' Show the registration form
        Hide() ' Hide the login form
    End Sub

    ' Event handler for the Login button
    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Define the connection string
        Dim connString = "Data Source=LAPTOP-NHFH6U0I;Initial Catalog=BroParcelService;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"

        ' Establish a connection to the database
        Using connection As New SqlConnection(connString)
            ' Create a SQL command to check user credentials
            Dim command As New SqlCommand("SELECT StudentId FROM user_reg WHERE StudentId = @StudentId AND Password = @Password", connection)

            ' Add parameters to the SQL command to prevent SQL injection attacks
            command.Parameters.AddWithValue("@StudentId", CInt(txtStudentID.Text)) ' Add Student ID parameter
            command.Parameters.AddWithValue("@Password", HashPassword(txtPassword.Text)) ' Hash the password and add as a parameter

            ' Open the database connection
            connection.Open()

            ' Execute the SQL command and get the first column of the first row in the result set
            Dim studentId = command.ExecuteScalar

            ' Check if the result is not null, meaning login is successful
            If studentId IsNot Nothing Then

                ' Store the Student ID in the shared variable for access in other forms
                User_Login.StudentID = CInt(studentId)

                MessageBox.Show("Login successful!") ' Show success message

                ' Redirect to the user page form
                Dim mainForm As New User_Page ' Create an instance of the User_Page form
                mainForm.Show() ' Show the user page form
                Hide() ' Hide the login form
            Else
                MessageBox.Show("Invalid Student ID or Password.") ' Show error message if credentials are invalid
            End If
        End Using ' Automatically closes the database connection when done
    End Sub

    ' Function to hash the password using SHA256
    Private Function HashPassword(password As String) As String

        ' Create a new SHA256 instance
        Using sha256 As SHA256 = SHA256.Create()
            ' Compute the hash of the input password as a byte array
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            ' Convert the byte array to a hexadecimal string
            Dim builder As New StringBuilder()
            For Each b As Byte In bytes
                builder.Append(b.ToString("x2")) ' Convert each byte to a 2-digit hex string
            Next
            Return builder.ToString() ' Return the hashed password as a hex string
        End Using
    End Function

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Close the current form and navigate back to the main menu form
        Hide() ' Hide the current form
        Dim mainMenu As New Main_Menu ' Create an instance of the MainMenu form
        mainMenu.Show() ' Show the MainMenuForm
    End Sub

    ' Event handler for the password visibility toggle button
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        ' Toggle password visibility
        Try
            If isPasswordVisible Then
                ' Mask the password
                txtPassword.PasswordChar = "•"c

                ' Change button image to "without slash"
                If IO.File.Exists(EyeWithoutSlashPath) Then
                    btnShow.Image = Image.FromFile(EyeWithoutSlashPath)
                Else
                    MessageBox.Show("The image file for the 'without slash' button is missing. Please check the path.")
                End If
            Else
                ' Unmask the password
                txtPassword.PasswordChar = ControlChars.NullChar

                ' Change button image to "with slash"
                If IO.File.Exists(EyeWithSlashPath) Then
                    btnShow.Image = Image.FromFile(EyeWithSlashPath)
                Else
                    MessageBox.Show("The image file for the 'with slash' button is missing. Please check the path.")
                End If
            End If

            ' Update the toggle state
            isPasswordVisible = Not isPasswordVisible
        Catch ex As Exception
            MessageBox.Show("Error toggling password visibility: " & ex.Message)
        End Try
    End Sub

End Class
