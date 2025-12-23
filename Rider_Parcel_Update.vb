Imports Microsoft.Data.SqlClient

Public Class Rider_Parcel_Update
    Dim riderID As Integer = Rider_Login.RiderID ' Retrieve the Rider ID from the login form

    Private adminBookingList As Admin_Booking_List
    Public Sub New(adminBookingList As Admin_Booking_List)
        InitializeComponent()
    End Sub

    Private connectionString As String = "Data Source=LAPTOP-NHFH6U0I;Initial Catalog=BroParcelService;Integrated Security=True;Trust Server Certificate=True"

    Private Sub Rider_Parcel_Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadParcels()
    End Sub

    ' Method to load parcels into the DataGridView
    Private Sub LoadParcels()
        Dim riderID As Integer = Rider_Login.RiderID ' Retrieve RiderID

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(" SELECT NameOnParcel, TrackingNumber, Status, Village FROM user_booking_delivery  WHERE AssignedRider = @riderID AND (Status IS NULL OR Status IN ('Pending', 'Picked Up'))", connection)
            command.Parameters.AddWithValue("@riderID", riderID)

            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()

            Try
                adapter.Fill(dataTable)

                If dataTable.Rows.Count > 0 Then
                    DataGridViewParcels.DataSource = dataTable
                Else
                    MessageBox.Show("No parcels found for this rider.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error loading parcels: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnPickUp_Click(sender As Object, e As EventArgs) Handles btnPickUp.Click
        If DataGridViewParcels.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridViewParcels.SelectedRows(0)
            Dim trackingNumber As String = selectedRow.Cells("TrackingNumber").Value.ToString()

            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand("UPDATE user_booking_delivery SET Status = 'Picked Up' WHERE TrackingNumber = @TrackingNumber", connection)
                command.Parameters.AddWithValue("@TrackingNumber", trackingNumber)

                connection.Open()
                command.ExecuteNonQuery()
            End Using

            ' Update the DataGridView row directly
            selectedRow.Cells("Status").Value = "Picked Up"
            MessageBox.Show("Parcel status updated to 'Picked Up'.")
        Else
            MessageBox.Show("Please select a parcel to pick up.")
        End If
    End Sub

    Private Sub btnDelivered_Click(sender As Object, e As EventArgs) Handles btnDelivered.Click
        If DataGridViewParcels.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridViewParcels.SelectedRows(0)
            Dim trackingNumber As String = selectedRow.Cells("TrackingNumber").Value.ToString()

            Using connection As New SqlConnection(connectionString)
                ' Corrected the SQL query to UPDATE the status to "Delivered"
                Dim command As New SqlCommand("UPDATE user_booking_delivery SET Status = 'Delivered' WHERE TrackingNumber = @TrackingNumber AND AssignedRider = @RiderID", connection)
                command.Parameters.AddWithValue("@TrackingNumber", trackingNumber)
                command.Parameters.AddWithValue("@RiderID", riderID)

                connection.Open()
                command.ExecuteNonQuery() ' Execute the update command
            End Using

            ' Update the DataGridView row directly
            selectedRow.Cells("Status").Value = "Delivered"
            MessageBox.Show("Parcel status updated to 'Delivered'.")
        Else
            MessageBox.Show("Please select a parcel to deliver.")
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Close the current form and show the main menu form
        Hide() ' Hide the current form
        Dim riderPage As New Rider_Page
        riderPage.Show()
    End Sub

End Class