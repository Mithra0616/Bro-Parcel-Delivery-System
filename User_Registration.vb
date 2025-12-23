Imports Microsoft.Data.SqlClient ' Import for SQL Server database operations
Imports System.Text
Imports System.Text.RegularExpressions ' Provides classes for using regular expressions to validate strings.
Imports System.Security.Cryptography ' Contains classes for cryptographic operations, including hashing.

Public Class User_Registration
    Private Sub User_Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This method is called when the form is loaded. Currently, it does nothing.
    End Sub

    ' Event handler for the Register button click event
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Check if the password and confirm password match
        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match.") ' Show error message if they don't match
            Return ' Exit the subroutine
        End If

        ' Validate the password using the IsValidPassword function
        If Not IsValidPassword(txtPassword.Text) Then
            MessageBox.Show("Password must be at least 12 characters long and include uppercase letters, lowercase letters, numbers, and symbols.") ' Show error message if password is invalid
            Return ' Exit the subroutine
        End If

        ' Validate the phone number format
        If Not IsValidPhoneNumber(txtPhoneNumber.Text) Then
            MessageBox.Show("Phone number must be 10 or 11 digits.") ' Show error message if phone number is invalid
            Return ' Exit the subroutine
        End If


        ' Define the connection string directly in the code
        Dim connectionString As String = "Data Source=LAPTOP-NHFH6U0I;Initial Catalog=BroParcelService;Integrated Security=True;Trust Server Certificate=True"

        ' Establish a connection to the database
        Using connection As New SqlConnection(connectionString)
            ' Create a SQL command to check if the StudentID already exists in the Users table
            Dim checkCommand As New SqlCommand("SELECT COUNT(*) FROM user_reg WHERE StudentId = @StudentId", connection)
            checkCommand.Parameters.AddWithValue("@StudentId", CInt(txtStudentID.Text)) ' Convert Student ID to Integer

            ' Open the database connection
            connection.Open()
            ' Execute the command to check for existing StudentID
            Dim existingCount As Integer = CInt(checkCommand.ExecuteScalar()) ' Get the count of existing StudentID
            Dim enteredVillage As String = txtVillage.Text.Trim()

            ' If the count is greater than 0, it means the StudentID is already registered
            If existingCount > 0 Then
                MessageBox.Show("This Student ID is already registered. Please use a different Student ID.") ' Show error message
                Return ' Exit the subroutine
            End If

            ' Create a SQL command to insert a new user into the Users table
            Dim command As New SqlCommand("INSERT INTO user_reg (FullName, StudentId, Password, PhoneNumber, Village) VALUES (@FullName, @StudentId, @Password, @PhoneNumber, @Village)", connection)
            ' Add parameters to the SQL command to prevent SQL injection
            command.Parameters.AddWithValue("@FullName", txtFullName.Text) ' Full name
            command.Parameters.AddWithValue("@StudentId", CInt(txtStudentID.Text)) ' Convert Student ID to Integer
            command.Parameters.AddWithValue("@Password", HashPassword(txtPassword.Text)) ' Hash the password before storing
            command.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text) ' Phone number
            command.Parameters.AddWithValue("@Village", txtVillage.Text.ToUpper()) ' Convert village to uppercase

            ' Execute the command to insert the new user
            Dim result As Integer = command.ExecuteNonQuery() ' Execute the command and get the result
            ' Check if the insertion was successful
            If result > 0 Then
                MessageBox.Show("Registration successful!") ' Show success message
                ' Redirect to the login page (assuming you have a form named LoginForm)
                Dim loginForm As New User_Login()
                loginForm.Show() ' Show the login form
                Me.Hide() ' Hide the registration form
            Else
                MessageBox.Show("Registration failed.") ' Show failure message
            End If
        End Using ' Automatically closes the connection when done
    End Sub

    ' Function to validate the password
    Private Function IsValidPassword(password As String) As Boolean
        ' Check if the password is at least 12 characters long
        If password.Length < 12 Then
            Return False
        End If

        ' Check for uppercase letters, lowercase letters, numbers, and symbols
        Dim hasUpperCase As Boolean = Regex.IsMatch(password, "[A-Z]")
        Dim hasLowerCase As Boolean = Regex.IsMatch(password, "[a-z]")
        Dim hasNumber As Boolean = Regex.IsMatch(password, "[0-9]")
        Dim hasSymbol As Boolean = Regex.IsMatch(password, "[^a-zA-Z0-9]")

        Return hasUpperCase AndAlso hasLowerCase AndAlso hasNumber AndAlso hasSymbol
    End Function

    ' Function to hash the password using SHA256
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For Each b As Byte In bytes
                builder.Append(b.ToString("x2")) ' Convert byte to hex string
            Next
            Return builder.ToString() ' Return the hashed password as a hex string
        End Using
    End Function

    ' Function to validate the phone number format
    Private Function IsValidPhoneNumber(phoneNumber As String) As Boolean
        ' Check if the phone number is either 10 or 11 digits long
        Return Regex.IsMatch(phoneNumber, "^\d{10}$|^\d{11}$")
    End Function

    ' Event handler for the Village text box to convert input to uppercase
    Private Sub txtVillage_TextChanged(sender As Object, e As EventArgs) Handles txtVillage.TextChanged
        txtVillage.Text = txtVillage.Text.ToUpper() ' Convert the text to uppercase
        txtVillage.SelectionStart = txtVillage.Text.Length ' Set the cursor to the end of the text
    End Sub

    ' Event handler for the Full Name text box to convert input to uppercase
    Private Sub txtFullName_TextChanged(sender As Object, e As EventArgs) Handles txtFullName.TextChanged
        txtFullName.Text = txtFullName.Text.ToUpper() ' Convert the text to uppercase
        txtFullName.SelectionStart = txtFullName.Text.Length ' Set the cursor to the end of the text
    End Sub

    Private Sub btnBackToLogin_Click(sender As Object, e As EventArgs) Handles btnBackToLogin.Click
        ' Close the current form and show the main menu form
        Me.Hide() ' Hide the current form
        Dim mainMenu As New Main_Menu() ' Create an instance of the MainMenu form
        mainMenu.Show() ' Show the MainMenuForm
    End Sub
End Class
