Imports Microsoft.Data.SqlClient

Public Class Admin_Finance
    Private connectionString As String = "Data Source=LAPTOP-NHFH6U0I;Initial Catalog=BroParcelService;Integrated Security=True;Trust Server Certificate=True"
    Private connection As SqlConnection

    Private Sub Admin_Finance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New SqlConnection(connectionString)

        ' Set default date range (e.g., last month to today)
        dtpStartDate.Value = DateTime.Now.AddMonths(-1)
        dtpEndDate.Value = DateTime.Now

        ' Initialize columns for the DataGridView
        InitializeDataGridViewColumns()

        ' Call the method to load data for the default date range
        UpdatePaidDeliveriesList()
    End Sub

    Private Sub InitializeDataGridViewColumns()
        ' Check if columns already exist, if not, add them
        If DataGridViewProfit.Columns.Count = 0 Then
            DataGridViewProfit.Columns.Add("BookingDate", "Booking Date")
            DataGridViewProfit.Columns.Add("Amount", "Amount")
        End If
    End Sub

    Private Sub UpdatePaidDeliveriesList()
        ' Ensure columns are initialized before trying to add data
        InitializeDataGridViewColumns()

        ' Clear the DataGridView before adding new rows
        DataGridViewProfit.Rows.Clear()

        ' Get the selected dates from the DateTimePickers
        Dim startDate As DateTime = dtpStartDate.Value
        Dim endDate As DateTime = dtpEndDate.Value

        ' Ensure start date is before end date
        If startDate > endDate Then
            MessageBox.Show("Start Date cannot be later than End Date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' SQL query to get the data for the selected date range
        Dim query As String = "SELECT BookingDate, price FROM user_booking_delivery WHERE Status = 'Delivered' AND BookingDate BETWEEN @StartDate AND @EndDate"
        Dim command As New SqlCommand(query, connection)

        ' Add parameters to the command to prevent SQL injection
        command.Parameters.AddWithValue("@StartDate", startDate)
        command.Parameters.AddWithValue("@EndDate", endDate)

        Try
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()

            ' Check if there are any results from the query
            If Not reader.HasRows Then
                MessageBox.Show("No delivered bookings found for the selected date range.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' Read and display the data
            While reader.Read()
                Dim deliveryDate As DateTime = reader.GetDateTime(0)
                Dim amount As Decimal = reader.GetDecimal(1)
                DataGridViewProfit.Rows.Add(deliveryDate.ToShortDateString(), amount)
            End While
        Catch ex As Exception
            MessageBox.Show("Error retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Call the function to fetch and display the data for the selected date range
        UpdatePaidDeliveriesList()

        ' Variable to store total profit
        Dim totalProfit As Decimal = 0D

        ' Loop through the DataGridView rows and calculate the total profit
        For Each row As DataGridViewRow In DataGridViewProfit.Rows
            If Not row.IsNewRow Then ' Ignore the new row placeholder
                ' Ensure the value in the Amount column is a valid decimal
                If row.Cells("Amount").Value IsNot Nothing AndAlso Decimal.TryParse(row.Cells("Amount").Value.ToString(), Nothing) Then
                    Dim amount As Decimal = Convert.ToDecimal(row.Cells("Amount").Value)
                    totalProfit += amount
                End If
            End If
        Next

        ' Display the total profit in the text box
        txtTotalProfit.Text = totalProfit.ToString("C2") ' Format as currency
    End Sub

    Private Sub dtpStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartDate.ValueChanged, dtpEndDate.ValueChanged
        ' Call the function to refresh the data when the date changes
        UpdatePaidDeliveriesList()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Close the current form and show the admin page form
        Me.Hide() ' Hide the current form
        Dim adminpage As New Admin_Page()
        adminpage.Show()
    End Sub
End Class