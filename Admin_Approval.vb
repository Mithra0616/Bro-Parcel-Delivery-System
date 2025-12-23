Imports Microsoft.Data.SqlClient
Public Class Admin_Approval

    Private connectionString As String = "Data Source=LAPTOP-NHFH6U0I;Initial Catalog=BroParcelService;Integrated Security=True;Trust Server Certificate=True"

    Private Sub Admin_Approval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPendingApprovals()
    End Sub

    Private Sub LoadPendingApprovals()
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT AdminID, FullName, StudentId, PhoneNumber, Email, IsApproved FROM admin_reg WHERE IsApproved = 0"
            Dim command As New SqlCommand(query, connection)

            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridViewAdmin.DataSource = table
        End Using
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        If DataGridViewAdmin.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridViewAdmin.SelectedRows(0)
            Dim adminId As Integer = Convert.ToInt32(selectedRow.Cells("AdminID").Value)

            ' Confirmation dialog
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to approve this admin?", "Confirm Approval", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Using connection As New SqlConnection(connectionString)
                    Dim query As String = "UPDATE admin_reg SET IsApproved = 1 WHERE AdminID = @AdminID"
                    Dim command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@AdminID", adminId)

                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show("Admin approved successfully!")

                        LoadPendingApprovals() ' Refresh the DataGridView
                    Catch ex As Exception
                        MessageBox.Show("Error approving admin: " & ex.Message)
                    End Try
                End Using
            End If
        Else
            MessageBox.Show("Please select an admin to approve.")
        End If
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        If DataGridViewAdmin.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridViewAdmin.SelectedRows(0)
            Dim adminId As Integer = Convert.ToInt32(selectedRow.Cells("AdminID").Value)

            ' Confirmation dialog
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to reject this admin?", "Confirm Rejection", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Using connection As New SqlConnection(connectionString)
                    Dim query As String = "DELETE FROM admin_reg WHERE AdminID = @AdminID"
                    Dim command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@AdminID", adminId)

                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show("Admin rejected and removed successfully!")
                        LoadPendingApprovals() ' Refresh the DataGridView
                    Catch ex As Exception
                        MessageBox.Show("Error rejecting admin: " & ex.Message)
                    End Try
                End Using
            End If
        Else
            MessageBox.Show("Please select an admin to reject.")
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Close the current form and show the admin page form
        Me.Hide() ' Hide the current form
        Dim adminpage As New Admin_Page()
        adminpage.Show()
    End Sub
End Class