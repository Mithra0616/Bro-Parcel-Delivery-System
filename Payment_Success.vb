Public Class Payment_Success
    Private Sub Payment_Success_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Display a confirmation message
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's response
        If result = DialogResult.Yes Then

            ' Show a thank you message
            MessageBox.Show("Thank you for using Bro Parcel Delivery Service.", "Goodbye", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Exit the application
            Application.Exit()
        End If
    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel2.Click

    End Sub
End Class