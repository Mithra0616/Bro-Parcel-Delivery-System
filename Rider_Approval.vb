Imports Microsoft.Data.SqlClient
Public Class Rider_Approval

    ' connection string
    Private connectionString As String = "Data Source=LAPTOP-NHFH6U0I;Initial Catalog=BroParcelService;Integrated Security=True;Trust Server Certificate=True"
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Close the current form and show the admin page form
        Me.Hide() ' Hide the current form
        Dim adminpage As New Admin_Page()
        adminpage.Show()
    End Sub

    Private Sub Rider_Approval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPendingApprovals()
    End Sub

    Private Sub LoadPendingApprovals()
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT RiderID, FullName, StudentID, Email, PhoneNumber, VehicleType, CarPlate, Password, StudentPhoto, CarStickerPhoto, LicensePhoto, RegistrationDate, IsApproved FROM rider_reg WHERE IsApproved = 0"
            Dim command As New SqlCommand(query, connection)

            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridViewRider.DataSource = table
        End Using
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        If DataGridViewRider.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridViewRider.SelectedRows(0)
            Dim riderId As Integer = Convert.ToInt32(selectedRow.Cells("RiderID").Value)

            ' Confirmation dialog
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to approve this rider?", "Confirm Approval", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Using connection As New SqlConnection(connectionString)
                    Dim query As String = "UPDATE rider_reg SET IsApproved = 1 WHERE RiderID = @RiderID"
                    Dim command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@RiderID", riderId)

                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show("Rider approved successfully!")

                        LoadPendingApprovals() ' Refresh the DataGridView
                    Catch ex As Exception
                        MessageBox.Show("Error approving rider: " & ex.Message)
                    End Try
                End Using
            End If
        Else
            MessageBox.Show("Please select an rider to approve.")
        End If
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        If DataGridViewRider.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridViewRider.SelectedRows(0)
            Dim riderId As Integer = Convert.ToInt32(selectedRow.Cells("riderID").Value)

            ' Confirmation dialog
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to reject this rider?", "Confirm Rejection", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Using connection As New SqlConnection(connectionString)
                    Dim query As String = "DELETE FROM rider_reg WHERE RiderID = @RiderID"
                    Dim command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@RiderID", riderId)

                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show("Rider rejected and removed successfully!")
                        LoadPendingApprovals() ' Refresh the DataGridView
                    Catch ex As Exception
                        MessageBox.Show("Error rejecting rider: " & ex.Message)
                    End Try
                End Using
            End If
        Else
            MessageBox.Show("Please select a rider to reject.")
        End If
    End Sub
End Class