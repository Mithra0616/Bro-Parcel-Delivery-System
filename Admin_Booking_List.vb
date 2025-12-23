Imports Microsoft.Data.SqlClient

Public Class Admin_Booking_List
    Public Event DeliveryAssigned()

    Private connectionString As String = "Data Source=LAPTOP-NHFH6U0I;Initial Catalog=BroParcelService;Integrated Security=True;Trust Server Certificate=True"
    Private Sub Admin_Booking_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBookings()
    End Sub

    Private Sub LoadBookings()
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT BookingID, NameOnParcel, TrackingNumber, BookingDate, Price, AssignedRider FROM user_booking_delivery" ' Adjust the query as needed
            Dim command As New SqlCommand(query, connection)

            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridViewBookings.DataSource = table
        End Using
    End Sub

    Private Sub btnAssignDelivery_Click(sender As Object, e As EventArgs) Handles btnAssignDelivery.Click
        If DataGridViewBookings.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a booking to assign.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim riderParcelUpdate As New Rider_Parcel_Update(Me)


        Dim selectedRow As DataGridViewRow = DataGridViewBookings.SelectedRows(0)
        Dim bookingId As Integer = Convert.ToInt32(selectedRow.Cells("BookingID").Value)

        Dim riderId As Integer = SelectRider()

        If riderId > 0 Then
            If AssignDeliveryToRider(bookingId, riderId) Then
                MessageBox.Show("Delivery assigned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadBookings()

                ' Raise the event
                RaiseEvent DeliveryAssigned()
            End If
        End If
    End Sub

    Private Function SelectRider() As Integer
        Dim riderSelectionForm As New Rider_Selection_Form()
        If riderSelectionForm.ShowDialog() = DialogResult.OK Then
            Return riderSelectionForm.SelectedRiderId ' Get the selected rider's ID
        End If
        Return -1 ' No rider selected
    End Function

    Private Function AssignDeliveryToRider(bookingId As Integer, riderId As Integer) As Boolean
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand("UPDATE user_booking_delivery SET AssignedRider = @RiderID WHERE BookingID = @BookingID", connection)

            command.Parameters.AddWithValue("@RiderID", riderId)
            command.Parameters.AddWithValue("@BookingID", bookingId) ' Ensure the parameter name matches

            connection.Open()
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            Return rowsAffected > 0 ' Returns true if a row was updated
        End Using
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Close the current form and show the admin page form
        Me.Hide() ' Hide the current form
        Dim adminpage As New Admin_Page()
        adminpage.Show()
    End Sub
End Class