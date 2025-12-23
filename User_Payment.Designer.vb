<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Payment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User_Payment))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        txtTotalPrice = New TextBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        btnBack = New Guna.UI2.WinForms.Guna2Button()
        btnQR = New Guna.UI2.WinForms.Guna2Button()
        btnOnlineBanking = New Guna.UI2.WinForms.Guna2Button()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtTotalPrice
        ' 
        txtTotalPrice.Location = New Point(278, 95)
        txtTotalPrice.Name = "txtTotalPrice"
        txtTotalPrice.ReadOnly = True
        txtTotalPrice.Size = New Size(221, 27)
        txtTotalPrice.TabIndex = 87
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(442, 140)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(225, 146)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 86
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(111, 140)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(225, 146)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 85
        PictureBox1.TabStop = False
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
        btnBack.Location = New Point(634, 394)
        btnBack.Name = "btnBack"
        btnBack.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnBack.Size = New Size(147, 34)
        btnBack.TabIndex = 84
        btnBack.Text = "Back"
        ' 
        ' btnQR
        ' 
        btnQR.AutoRoundedCorners = True
        btnQR.BorderRadius = 27
        btnQR.CustomizableEdges = CustomizableEdges3
        btnQR.DisabledState.BorderColor = Color.DarkGray
        btnQR.DisabledState.CustomBorderColor = Color.DarkGray
        btnQR.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnQR.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnQR.FillColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        btnQR.Font = New Font("Century Gothic", 13.8F)
        btnQR.ForeColor = Color.White
        btnQR.Location = New Point(442, 304)
        btnQR.Name = "btnQR"
        btnQR.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnQR.Size = New Size(225, 56)
        btnQR.TabIndex = 83
        btnQR.Text = "QR CODE"
        ' 
        ' btnOnlineBanking
        ' 
        btnOnlineBanking.AutoRoundedCorners = True
        btnOnlineBanking.BorderRadius = 27
        btnOnlineBanking.CustomizableEdges = CustomizableEdges5
        btnOnlineBanking.DisabledState.BorderColor = Color.DarkGray
        btnOnlineBanking.DisabledState.CustomBorderColor = Color.DarkGray
        btnOnlineBanking.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnOnlineBanking.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnOnlineBanking.FillColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        btnOnlineBanking.Font = New Font("Century Gothic", 13.8F)
        btnOnlineBanking.ForeColor = Color.White
        btnOnlineBanking.Location = New Point(111, 304)
        btnOnlineBanking.Name = "btnOnlineBanking"
        btnOnlineBanking.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnOnlineBanking.Size = New Size(225, 56)
        btnOnlineBanking.TabIndex = 82
        btnOnlineBanking.Text = "ONLINE BANKING"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Cooper Black", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.ForeColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        Guna2HtmlLabel1.Location = New Point(156, 29)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(454, 51)
        Guna2HtmlLabel1.TabIndex = 81
        Guna2HtmlLabel1.Text = "PAYMENT OPTIONS"
        ' 
        ' User_Payment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(226), CByte(225))
        ClientSize = New Size(800, 450)
        Controls.Add(txtTotalPrice)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(btnBack)
        Controls.Add(btnQR)
        Controls.Add(btnOnlineBanking)
        Controls.Add(Guna2HtmlLabel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "User_Payment"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PAYMENT"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnQR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnOnlineBanking As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
