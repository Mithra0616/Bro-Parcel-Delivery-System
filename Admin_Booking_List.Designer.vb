<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Booking_List
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        btnBack = New Guna.UI2.WinForms.Guna2Button()
        btnAssignDelivery = New Guna.UI2.WinForms.Guna2Button()
        DataGridViewBookings = New DataGridView()
        CType(DataGridViewBookings, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.AutoRoundedCorners = True
        btnBack.BorderRadius = 16
        btnBack.CustomizableEdges = CustomizableEdges1
        btnBack.DisabledState.BorderColor = Color.DarkGray
        btnBack.DisabledState.CustomBorderColor = Color.DarkGray
        btnBack.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnBack.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnBack.FillColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        btnBack.Font = New Font("Century Gothic", 9F)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(29, 393)
        btnBack.Name = "btnBack"
        btnBack.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnBack.Size = New Size(147, 34)
        btnBack.TabIndex = 81
        btnBack.Text = "Back"
        ' 
        ' btnAssignDelivery
        ' 
        btnAssignDelivery.AutoRoundedCorners = True
        btnAssignDelivery.BorderRadius = 16
        btnAssignDelivery.CustomizableEdges = CustomizableEdges3
        btnAssignDelivery.DisabledState.BorderColor = Color.DarkGray
        btnAssignDelivery.DisabledState.CustomBorderColor = Color.DarkGray
        btnAssignDelivery.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAssignDelivery.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAssignDelivery.FillColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        btnAssignDelivery.Font = New Font("Century Gothic", 9F)
        btnAssignDelivery.ForeColor = Color.White
        btnAssignDelivery.Location = New Point(625, 393)
        btnAssignDelivery.Name = "btnAssignDelivery"
        btnAssignDelivery.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnAssignDelivery.Size = New Size(147, 34)
        btnAssignDelivery.TabIndex = 79
        btnAssignDelivery.Text = "Assign Delivery"
        ' 
        ' DataGridViewBookings
        ' 
        DataGridViewBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewBookings.Location = New Point(30, 23)
        DataGridViewBookings.Name = "DataGridViewBookings"
        DataGridViewBookings.RowHeadersWidth = 51
        DataGridViewBookings.Size = New Size(742, 352)
        DataGridViewBookings.TabIndex = 78
        ' 
        ' Admin_Booking_List
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(226), CByte(225))
        ClientSize = New Size(800, 450)
        Controls.Add(btnBack)
        Controls.Add(btnAssignDelivery)
        Controls.Add(DataGridViewBookings)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Admin_Booking_List"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BOOKING LIST"
        CType(DataGridViewBookings, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAssignDelivery As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridViewBookings As DataGridView
End Class
