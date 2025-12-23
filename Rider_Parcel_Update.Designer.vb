<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rider_Parcel_Update
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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        btnPickUp = New Guna.UI2.WinForms.Guna2Button()
        btnDelivered = New Guna.UI2.WinForms.Guna2Button()
        DataGridViewParcels = New DataGridView()
        btnBack = New Guna.UI2.WinForms.Guna2Button()
        CType(DataGridViewParcels, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnPickUp
        ' 
        btnPickUp.AutoRoundedCorners = True
        btnPickUp.BorderRadius = 16
        btnPickUp.CustomizableEdges = CustomizableEdges1
        btnPickUp.DisabledState.BorderColor = Color.DarkGray
        btnPickUp.DisabledState.CustomBorderColor = Color.DarkGray
        btnPickUp.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnPickUp.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnPickUp.FillColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        btnPickUp.Font = New Font("Century Gothic", 9F)
        btnPickUp.ForeColor = Color.White
        btnPickUp.Location = New Point(431, 393)
        btnPickUp.Name = "btnPickUp"
        btnPickUp.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnPickUp.Size = New Size(147, 34)
        btnPickUp.TabIndex = 76
        btnPickUp.Text = "Pick Up"
        ' 
        ' btnDelivered
        ' 
        btnDelivered.AutoRoundedCorners = True
        btnDelivered.BorderRadius = 16
        btnDelivered.CustomizableEdges = CustomizableEdges3
        btnDelivered.DisabledState.BorderColor = Color.DarkGray
        btnDelivered.DisabledState.CustomBorderColor = Color.DarkGray
        btnDelivered.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnDelivered.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnDelivered.FillColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        btnDelivered.Font = New Font("Century Gothic", 9F)
        btnDelivered.ForeColor = Color.White
        btnDelivered.Location = New Point(625, 393)
        btnDelivered.Name = "btnDelivered"
        btnDelivered.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnDelivered.Size = New Size(147, 34)
        btnDelivered.TabIndex = 75
        btnDelivered.Text = "Delivered"
        ' 
        ' DataGridViewParcels
        ' 
        DataGridViewParcels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewParcels.Location = New Point(30, 23)
        DataGridViewParcels.Name = "DataGridViewParcels"
        DataGridViewParcels.RowHeadersWidth = 51
        DataGridViewParcels.Size = New Size(742, 352)
        DataGridViewParcels.TabIndex = 74
        ' 
        ' btnBack
        ' 
        btnBack.AutoRoundedCorners = True
        btnBack.BorderRadius = 16
        btnBack.CustomizableEdges = CustomizableEdges5
        btnBack.DisabledState.BorderColor = Color.DarkGray
        btnBack.DisabledState.CustomBorderColor = Color.DarkGray
        btnBack.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnBack.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnBack.FillColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        btnBack.Font = New Font("Century Gothic", 9F)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(29, 393)
        btnBack.Name = "btnBack"
        btnBack.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnBack.Size = New Size(147, 34)
        btnBack.TabIndex = 77
        btnBack.Text = "Back"
        ' 
        ' Rider_Parcel_Update
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(226), CByte(225))
        ClientSize = New Size(800, 450)
        Controls.Add(btnBack)
        Controls.Add(btnPickUp)
        Controls.Add(btnDelivered)
        Controls.Add(DataGridViewParcels)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Rider_Parcel_Update"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Rider_Parcel_Update"
        CType(DataGridViewParcels, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnPickUp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelivered As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridViewParcels As DataGridView
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
End Class
