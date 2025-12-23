<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Approval
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
        btnReject = New Guna.UI2.WinForms.Guna2Button()
        btnApprove = New Guna.UI2.WinForms.Guna2Button()
        DataGridViewAdmin = New DataGridView()
        CType(DataGridViewAdmin, ComponentModel.ISupportInitialize).BeginInit()
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
        btnBack.TabIndex = 77
        btnBack.Text = "Back"
        ' 
        ' btnReject
        ' 
        btnReject.AutoRoundedCorners = True
        btnReject.BorderRadius = 16
        btnReject.CustomizableEdges = CustomizableEdges3
        btnReject.DisabledState.BorderColor = Color.DarkGray
        btnReject.DisabledState.CustomBorderColor = Color.DarkGray
        btnReject.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnReject.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnReject.FillColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        btnReject.Font = New Font("Century Gothic", 9F)
        btnReject.ForeColor = Color.White
        btnReject.Location = New Point(431, 393)
        btnReject.Name = "btnReject"
        btnReject.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnReject.Size = New Size(147, 34)
        btnReject.TabIndex = 76
        btnReject.Text = "Reject"
        ' 
        ' btnApprove
        ' 
        btnApprove.AutoRoundedCorners = True
        btnApprove.BorderRadius = 16
        btnApprove.CustomizableEdges = CustomizableEdges5
        btnApprove.DisabledState.BorderColor = Color.DarkGray
        btnApprove.DisabledState.CustomBorderColor = Color.DarkGray
        btnApprove.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnApprove.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnApprove.FillColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        btnApprove.Font = New Font("Century Gothic", 9F)
        btnApprove.ForeColor = Color.White
        btnApprove.Location = New Point(625, 393)
        btnApprove.Name = "btnApprove"
        btnApprove.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnApprove.Size = New Size(147, 34)
        btnApprove.TabIndex = 75
        btnApprove.Text = "Approve"
        ' 
        ' DataGridViewAdmin
        ' 
        DataGridViewAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewAdmin.Location = New Point(30, 23)
        DataGridViewAdmin.Name = "DataGridViewAdmin"
        DataGridViewAdmin.RowHeadersWidth = 51
        DataGridViewAdmin.Size = New Size(742, 352)
        DataGridViewAdmin.TabIndex = 74
        ' 
        ' Admin_Approval
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(226), CByte(225))
        ClientSize = New Size(800, 450)
        Controls.Add(btnBack)
        Controls.Add(btnReject)
        Controls.Add(btnApprove)
        Controls.Add(DataGridViewAdmin)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Admin_Approval"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ADMIN APPROVAL"
        CType(DataGridViewAdmin, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReject As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnApprove As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridViewAdmin As DataGridView
End Class
