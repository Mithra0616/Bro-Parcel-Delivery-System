<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Track_Parcel
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
        btnBack = New Guna.UI2.WinForms.Guna2Button()
        btnTrack = New Guna.UI2.WinForms.Guna2Button()
        txtTrackingNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Label1 = New Label()
        DataGridViewTrackParcel = New DataGridView()
        CType(DataGridViewTrackParcel, ComponentModel.ISupportInitialize).BeginInit()
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
        btnBack.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(603, 393)
        btnBack.Name = "btnBack"
        btnBack.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnBack.Size = New Size(147, 34)
        btnBack.TabIndex = 38
        btnBack.Text = "Back"
        ' 
        ' btnTrack
        ' 
        btnTrack.CustomizableEdges = CustomizableEdges3
        btnTrack.DisabledState.BorderColor = Color.DarkGray
        btnTrack.DisabledState.CustomBorderColor = Color.DarkGray
        btnTrack.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnTrack.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnTrack.FillColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        btnTrack.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTrack.ForeColor = Color.White
        btnTrack.Location = New Point(225, 129)
        btnTrack.Name = "btnTrack"
        btnTrack.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnTrack.Size = New Size(322, 39)
        btnTrack.TabIndex = 37
        btnTrack.Text = "TRACK"
        ' 
        ' txtTrackingNumber
        ' 
        txtTrackingNumber.CustomizableEdges = CustomizableEdges5
        txtTrackingNumber.DefaultText = ""
        txtTrackingNumber.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtTrackingNumber.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtTrackingNumber.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtTrackingNumber.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtTrackingNumber.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtTrackingNumber.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTrackingNumber.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtTrackingNumber.Location = New Point(225, 92)
        txtTrackingNumber.Margin = New Padding(3, 4, 3, 4)
        txtTrackingNumber.Name = "txtTrackingNumber"
        txtTrackingNumber.PasswordChar = ChrW(0)
        txtTrackingNumber.PlaceholderText = "Enter your tracking number"
        txtTrackingNumber.SelectedText = ""
        txtTrackingNumber.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtTrackingNumber.Size = New Size(322, 43)
        txtTrackingNumber.TabIndex = 36
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        Label1.Location = New Point(172, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(428, 46)
        Label1.TabIndex = 35
        Label1.Text = "TRACK YOUR ITEM"
        ' 
        ' DataGridViewTrackParcel
        ' 
        DataGridViewTrackParcel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewTrackParcel.Location = New Point(98, 214)
        DataGridViewTrackParcel.Name = "DataGridViewTrackParcel"
        DataGridViewTrackParcel.RowHeadersWidth = 51
        DataGridViewTrackParcel.Size = New Size(600, 136)
        DataGridViewTrackParcel.TabIndex = 39
        ' 
        ' User_Track_Parcel
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(226), CByte(225))
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridViewTrackParcel)
        Controls.Add(btnBack)
        Controls.Add(btnTrack)
        Controls.Add(txtTrackingNumber)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "User_Track_Parcel"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TRACK PARCEL"
        CType(DataGridViewTrackParcel, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTrack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtTrackingNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewTrackParcel As DataGridView
End Class
