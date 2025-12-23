<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rider_Page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rider_Page))
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnBack = New Guna.UI2.WinForms.Guna2Button()
        btnParcelStatus = New Guna.UI2.WinForms.Guna2TileButton()
        btnParcelHistory = New Guna.UI2.WinForms.Guna2TileButton()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Cooper Black", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.ForeColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        Guna2HtmlLabel1.Location = New Point(24, 30)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(420, 51)
        Guna2HtmlLabel1.TabIndex = 44
        Guna2HtmlLabel1.Text = "WELCOME RIDER !"
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
        btnBack.Location = New Point(641, 404)
        btnBack.Name = "btnBack"
        btnBack.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnBack.Size = New Size(147, 34)
        btnBack.TabIndex = 43
        btnBack.Text = "Back"
        ' 
        ' btnParcelStatus
        ' 
        btnParcelStatus.AutoRoundedCorners = True
        btnParcelStatus.BorderRadius = 57
        btnParcelStatus.CustomizableEdges = CustomizableEdges3
        btnParcelStatus.DisabledState.BorderColor = Color.DarkGray
        btnParcelStatus.DisabledState.CustomBorderColor = Color.DarkGray
        btnParcelStatus.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnParcelStatus.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnParcelStatus.FillColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        btnParcelStatus.Font = New Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnParcelStatus.ForeColor = Color.White
        btnParcelStatus.Location = New Point(55, 103)
        btnParcelStatus.Name = "btnParcelStatus"
        btnParcelStatus.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnParcelStatus.Size = New Size(317, 117)
        btnParcelStatus.TabIndex = 42
        btnParcelStatus.Text = "PARCEL STATUS"
        ' 
        ' btnParcelHistory
        ' 
        btnParcelHistory.AutoRoundedCorners = True
        btnParcelHistory.BorderRadius = 57
        btnParcelHistory.CustomizableEdges = CustomizableEdges5
        btnParcelHistory.DisabledState.BorderColor = Color.DarkGray
        btnParcelHistory.DisabledState.CustomBorderColor = Color.DarkGray
        btnParcelHistory.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnParcelHistory.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnParcelHistory.FillColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        btnParcelHistory.Font = New Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnParcelHistory.ForeColor = Color.White
        btnParcelHistory.Location = New Point(55, 274)
        btnParcelHistory.Name = "btnParcelHistory"
        btnParcelHistory.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnParcelHistory.Size = New Size(317, 117)
        btnParcelHistory.TabIndex = 41
        btnParcelHistory.Text = "PARCEL HISTORY"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(285, -86)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(541, 584)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 45
        PictureBox1.TabStop = False
        ' 
        ' Rider_Page
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(226), CByte(225))
        ClientSize = New Size(800, 450)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(btnBack)
        Controls.Add(btnParcelStatus)
        Controls.Add(btnParcelHistory)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Rider_Page"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Rider_Page"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnParcelStatus As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents btnParcelHistory As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
