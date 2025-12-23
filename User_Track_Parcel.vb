Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class User_Track_Parcel
    ' Database connection string
    Dim connString As String = "Data Source=LAPTOP-NHFH6U0I;Initial Catalog=BroParcelService;Integrated Security=True;Trust Server Certificate=True"

    ' Event when the "Track" button is clicked
    Private Sub btnTrack_Click(sender As Object, e As EventArgs) Handles btnTrack.Click
        ' Get the tracking number from the TextBox
        Dim trackingNumber As String = txtTrackingNumber.Text.Trim()

        ' Validate input
        If String.IsNullOrEmpty(trackingNumber) Then
            MessageBox.Show("Please enter a tracking number.")
            Return
        End If

        ' Fetch the parcel information
        GetParcelDetails(trackingNumber)
    End Sub

    ' Function to retrieve parcel details from the database
    Private Sub GetParcelDetails(trackingNumber As String)
        ' Initialize SQL query to get parcel information
        Dim query As String = "SELECT TrackingNumber, NameOnParcel, Status, AssignedRider, BookingDate FROM user_booking_delivery WHERE TrackingNumber = @TrackingNumber"

        ' Initialize connection and command
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand(query, conn)
                ' Add parameter to avoid SQL Injection
                cmd.Parameters.AddWithValue("@TrackingNumber", trackingNumber)

                ' Create DataAdapter to fill DataTable
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()

                Try
                    ' Open the connection
                    conn.Open()

                    ' Fill the DataTable with the result of the query
                    adapter.Fill(dt)

                    ' Check if we have any rows returned
                    If dt.Rows.Count > 0 Then
                        ' Bind the result to DataGridView
                        DataGridViewTrackParcel.DataSource = dt
                    Else
                        MessageBox.Show("No parcel found with the given tracking number.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    ' Close the connection
                    conn.Close()
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide() ' Hide the current form
        Dim UserPayment As New User_Page()
        UserPayment.Show()
    End Sub
End Class