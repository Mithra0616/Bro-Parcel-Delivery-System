Imports Microsoft.Data.SqlClient

Public Class User_Profile
    Dim studentID As Integer = User_Login.StudentID ' Retrieve the StudentID from the login form

    Dim connectionString As String = "Data Source=LAPTOP-NHFH6U0I;Initial Catalog=BroParcelService;Integrated Security=True;Trust Server Certificate=True;"

    Private Sub User_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserProfile()
    End Sub

    Private Sub LoadUserProfile()
        Try
            ' Retrieve the StudentID from the User_Login form
            Dim studentID As Integer = User_Login.StudentID
            If studentID <= 0 Then
                MessageBox.Show("Student ID is not valid. Please log in.")
                Return
            End If

            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand("SELECT FullName, studentID, PhoneNumber, Village FROM user_reg WHERE studentID = @StudentID", connection)
                command.Parameters.Add("@StudentID", SqlDbType.Int).Value = studentID

                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        txtName.Text = reader("FullName").ToString()
                        txtStudentID.Text = reader("StudentID").ToString()
                        txtPhoneNumber.Text = reader("PhoneNumber").ToString()
                        txtVIllage.Text = reader("Village").ToString()
                    Else
                        MessageBox.Show("No user found with the given StudentID.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading user profile: " & ex.Message)
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If ValidateInputs() Then
            UpdateUserProfile()
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(txtPhoneNumber.Text) Then
            MessageBox.Show("Phone number cannot be empty.")
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtVIllage.Text) Then
            MessageBox.Show("Village cannot be empty.")
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Password cannot be empty.")
            Return False
        End If
        Return True
    End Function

    Private Sub UpdateUserProfile()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand("UPDATE user_reg SET PhoneNumber = @PhoneNumber, Village = @Village, Password = @Password WHERE StudentID = @StudentID", connection)
                command.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
                command.Parameters.AddWithValue("@Village", txtVIllage.Text)
                command.Parameters.AddWithValue("@Password", txtPassword.Text) ' Consider hashing the password
                command.Parameters.Add("@StudentID", SqlDbType.Int).Value = studentID ' Explicitly set type to Int

                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Profile updated successfully.")
                Else
                    MessageBox.Show("Failed to update the profile. No rows were affected.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating user profile: " & ex.Message)
            Debug.WriteLine(ex.StackTrace)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Dim userpage As New User_Page()
        userpage.Show()
    End Sub
End Class
