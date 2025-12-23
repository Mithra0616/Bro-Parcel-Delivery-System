Public Class Main_Menu
    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Event handler for Student button click
    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        ' Create an instance of the splash screen
        Dim splash As New SplashScreen()

        ' Show the splash screen and process its events
        splash.Show()

        ' Delay to allow the splash screen to display properly before proceeding
        Application.DoEvents()

        ' Start a timer or thread to close the splash screen after it's done
        ' This logic will be handled in the SplashScreen itself

        ' Splash screen will automatically transition to the User_Login form
        Me.Hide() ' Hide Main_Menu form
    End Sub

    ' Event handler for Admin button click
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        ' Create an instance of the splash screen
        Dim splash As New SplashScreen2()

        ' Show the splash screen and process its events
        splash.Show()

        ' Delay to allow the splash screen to display properly before proceeding
        Application.DoEvents()

        ' Start a timer or thread to close the splash screen after it's done
        ' This logic will be handled in the SplashScreen itself

        ' Splash screen will automatically transition to the User_Login form
        Me.Hide() ' Hide Main_Menu form
    End Sub

    ' Event handler for Rider button click
    Private Sub btnRider_Click(sender As Object, e As EventArgs) Handles btnRider.Click
        ' Create an instance of the splash screen
        Dim splash As New SplashScreem3()

        ' Show the splash screen and process its events
        splash.Show()

        ' Delay to allow the splash screen to display properly before proceeding
        Application.DoEvents()

        ' Start a timer or thread to close the splash screen after it's done
        ' This logic will be handled in the SplashScreen itself

        ' Splash screen will automatically transition to the User_Login form
        Me.Hide() ' Hide Main_Menu form
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim AboutUs As New About_Us
        AboutUs.Show()  'open the About Us form 
        Me.Hide()  'Hide the main page 
    End Sub
End Class
