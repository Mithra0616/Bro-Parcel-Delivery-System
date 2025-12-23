Imports Microsoft.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Rider_Login

    Public Shared RiderID As Integer ' Shared property to store the logged-in Rider ID
    Private connectionString As String = "Data Source=LAPTOP-NHFH6U0I;Initial Catalog=BroParcelService;Integrated Security=True;Trust Server Certificate=True"

    ' Paths to the images for the password visibility toggle button
    Private EyeWithSlashPath As String = "C:\Users\User\Downloads\sample_button_images\with_slash.png"
    Private EyeWithoutSlashPath As String = "C:\Users\User\Downloads\sample_button_images\without_slash.png"

    ' Declare a boolean to track the password visibility state
    Private isPasswordVisible As Boolean = False

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Close the current form and show the main menu form
        Me.Hide() ' Hide the current form
        Dim mainMenu As New Main_Menu() ' Create an instance of the MainMenu form
        mainMenu.Show() ' Show the MainMenuForm
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim registrationForm As New Rider_Registration()
        registrationForm.Show()
        Me.Hide() ' Hide the login form
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand("
            SELECT riderID 
            FROM rider_reg 
            WHERE riderID = @riderID AND Password = @Password", connection)

            command.Parameters.AddWithValue("@riderID", txtRiderID.Text)
            command.Parameters.AddWithValue("@Password", txtPassword.Text)

            connection.Open()
            Dim result As Object = command.ExecuteScalar()

            If result IsNot Nothing Then
                RiderID = Convert.ToInt32(result) ' Set the RiderID
                MessageBox.Show("Login successful! Rider ID: " & RiderID.ToString())

                ' Navigate to Rider Page form instead of Rider Parcel Update
                Dim riderPage As New Rider_Page()
                riderPage.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid login. Please check your credentials.")
            End If
        End Using
    End Sub

    ' Function to hash the password using SHA256 (same as in registration)
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

    Private Sub Rider_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default password masking with dots
        txtPassword.PasswordChar = "•"c

        ' Set initial image for the button
        btnShow.Image = Image.FromFile(EyeWithSlashPath)
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        ' Toggle password visibility
        If isPasswordVisible Then
            ' Mask the password field and update the button image
            txtPassword.PasswordChar = "•"c
            btnShow.Image = Image.FromFile(EyeWithSlashPath)
        Else
            ' Unmask the password field and update the button image
            txtPassword.PasswordChar = ControlChars.NullChar
            btnShow.Image = Image.FromFile(EyeWithoutSlashPath)
        End If

        ' Update the visibility state
        isPasswordVisible = Not isPasswordVisible
    End Sub
End Class