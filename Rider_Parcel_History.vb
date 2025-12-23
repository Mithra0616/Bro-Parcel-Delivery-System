Imports Microsoft.Data.SqlClient

Public Class Rider_Parcel_History
    Private connectionString As String = "Data Source=LAPTOP-NHFH6U0I;Initial Catalog=BroParcelService;Integrated Security=True;Trust Server Certificate=True"

    Private Sub Rider_Parcel_History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDeliveredParcels()
    End Sub

    ' Method to load delivered parcels into the DataGridView
    Private Sub LoadDeliveredParcels()
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand("SELECT * FROM user_booking_delivery WHERE Status = 'Delivered'", connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            DataGridViewDeliveredParcel.DataSource = dataTable ' Bind the DataTable to the DataGridView
        End Using
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Close the current form and show the main menu form
        Hide() ' Hide the current form
        Dim riderPage As New Rider_Page
        riderPage.Show()
    End Sub
End Class