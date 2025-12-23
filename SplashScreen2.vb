Public Class SplashScreen2
    ' Declare an instance of User_Login at the class level
    Private admin_login As New Admin_Login()
    Private Sub SplashScreen2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0
        Timer1.Interval = 100 ' Set the interval for Timer1 (100 milliseconds)
        Timer1.Start() ' Start Timer1 for the progress bar
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Increment progress bar
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 5
            lblPercent.Text = ProgressBar1.Value & "% Completing . . ."
        End If

        ' Update messages based on the progress bar value
        Select Case ProgressBar1.Value
            Case 10
                msg_label.Text = "Loading . . ."
            Case 20
                msg_label.Text = "Preparing database . . ."
            Case 50
                msg_label.Text = "Please be patient . . ."
            Case 85
                msg_label.Text = "Nice! We're ready. . ."
            Case 100
                msg_label.Text = "Launching Database . . ."
                Timer1.Stop()  ' Stop Timer1 when progress is complete

                ' Transition to the User_Login form
                ShowAdminLogin()
        End Select
    End Sub
    ' Method to show the User_Login form
    Private Sub ShowAdminLogin()
        Timer1.Stop() ' Stop the timer
        admin_login.Show() ' Show the User_Login form
        Me.Close() ' Close the splash screen
    End Sub
End Class