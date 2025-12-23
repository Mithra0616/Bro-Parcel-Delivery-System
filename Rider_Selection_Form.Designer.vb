<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rider_Selection_Form
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
        btnSelect = New Guna.UI2.WinForms.Guna2Button()
        DataGridViewRider = New DataGridView()
        CType(DataGridViewRider, ComponentModel.ISupportInitialize).BeginInit()
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
        btnBack.TabIndex = 84
        btnBack.Text = "Back"
        ' 
        ' btnSelect
        ' 
        btnSelect.AutoRoundedCorners = True
        btnSelect.BorderRadius = 16
        btnSelect.CustomizableEdges = CustomizableEdges3
        btnSelect.DisabledState.BorderColor = Color.DarkGray
        btnSelect.DisabledState.CustomBorderColor = Color.DarkGray
        btnSelect.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSelect.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSelect.FillColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        btnSelect.Font = New Font("Century Gothic", 9F)
        btnSelect.ForeColor = Color.White
        btnSelect.Location = New Point(625, 393)
        btnSelect.Name = "btnSelect"
        btnSelect.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnSelect.Size = New Size(147, 34)
        btnSelect.TabIndex = 83
        btnSelect.Text = "Select"
        ' 
        ' DataGridViewRider
        ' 
        DataGridViewRider.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewRider.Location = New Point(30, 23)
        DataGridViewRider.Name = "DataGridViewRider"
        DataGridViewRider.RowHeadersWidth = 51
        DataGridViewRider.Size = New Size(742, 352)
        DataGridViewRider.TabIndex = 82
        ' 
        ' Rider_Selection_Form
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(226), CByte(225))
        ClientSize = New Size(800, 450)
        Controls.Add(btnBack)
        Controls.Add(btnSelect)
        Controls.Add(DataGridViewRider)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Rider_Selection_Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RIDER SELECTION"
        CType(DataGridViewRider, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSelect As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridViewRider As DataGridView
End Class
