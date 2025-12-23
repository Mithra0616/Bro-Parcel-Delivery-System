Imports Microsoft.Data.SqlClient
Public Class Rider_Selection_Form
    Private connectionString As String = "Data Source=LAPTOP-NHFH6U0I;Initial Catalog=BroParcelService;Integrated Security=True;Trust Server Certificate=True"
    Public Property SelectedRiderId As Integer
    Private Sub Rider_Selection_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRiders()
    End Sub

    Private Sub LoadRiders()
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT riderID, FullName, VehicleType FROM rider_reg"
            Dim command As New SqlCommand(query, connection)

            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridViewRider.DataSource = table
        End Using
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If DataGridViewRider.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a rider.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = DataGridViewRider.SelectedRows(0)
        SelectedRiderId = Convert.ToInt32(selectedRow.Cells("riderID").Value)

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Close the current form 
        Me.Hide() ' Hide the current form
        Dim adminbookinglist As New Admin_Booking_List()
        adminbookinglist.Show() ' Go back to the admin booking list
    End Sub
End Class