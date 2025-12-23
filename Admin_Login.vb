Imports Microsoft.Data.SqlClient
Imports System.Text
Imports System.Security.Cryptography

Public Class Admin_Login

    Private connectionString As String = "Data Source=LAPTOP-NHFH6U0I;Initial Catalog=BroParcelService;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"

    ' Paths to the images for the password visibility toggle button
    Private EyeWithSlashPath As String = "C:\Users\User\Downloads\sample_button_images\with_slash.png"
    Private EyeWithoutSlashPath As String = "C:\Users\User\Downloads\sample_button_images\without_slash.png"

    ' Boolean to track password visibility
    Private isPasswordVisible As Boolean = False

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim registrationForm As New Admin_Registration()
        registrationForm.Show()
        Me.Hide() ' Hide the login form
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Close the current form and show the main menu form
        Me.Hide() ' Hide the current form
        Dim mainMenu As New Main_Menu() ' Create an instance of the MainMenu form
        mainMenu.Show() ' Show the MainMenuForm
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim adminId As String = txtAdminID.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If String.IsNullOrEmpty(adminId) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both Admin ID and Password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Hash the entered password before checking
        Dim hashedPassword As String = HashPassword(password)

        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT COUNT(*) FROM admin_reg WHERE AdminID = @AdminID AND Password = @Password"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@AdminID", adminId)
            command.Parameters.AddWithValue("@Password", hashedPassword) ' Compare hashed password

            connection.Open()
            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

            If count > 0 Then
                ' Credentials are valid, open the admin page
                Dim AdminPage As New Admin_Page()
                AdminPage.Show()
                Me.Hide() ' Hide the login form
            Else
                MessageBox.Show("Invalid Admin ID or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
    End Sub

    ' Function to hash the password using SHA256 (same as in registration)
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = sha256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For Each b As Byte In bytes
                builder.Append(b.ToString("x2")) ' Convert byte to hex string
            Next
            Return builder.ToString() ' Return the hashed password as a hex string
        End Using
    End Function

    Private Sub Admin_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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