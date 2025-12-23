<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_QRPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User_QRPayment))
        btnBack = New Guna.UI2.WinForms.Guna2Button()
        btnNext = New Guna.UI2.WinForms.Guna2Button()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblPaymentMethod = New Label()
        PictureBox2 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
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
        btnBack.Location = New Point(154, 376)
        btnBack.Name = "btnBack"
        btnBack.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnBack.Size = New Size(147, 34)
        btnBack.TabIndex = 84
        btnBack.Text = "Back"
        ' 
        ' btnNext
        ' 
        btnNext.AutoRoundedCorners = True
        btnNext.BorderRadius = 16
        btnNext.CustomizableEdges = CustomizableEdges3
        btnNext.DisabledState.BorderColor = Color.DarkGray
        btnNext.DisabledState.CustomBorderColor = Color.DarkGray
        btnNext.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnNext.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnNext.FillColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        btnNext.Font = New Font("Century Gothic", 9F)
        btnNext.ForeColor = Color.White
        btnNext.Location = New Point(499, 376)
        btnNext.Name = "btnNext"
        btnNext.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnNext.Size = New Size(147, 34)
        btnNext.TabIndex = 83
        btnNext.Text = "Next"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.ForeColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        Guna2HtmlLabel1.Location = New Point(244, 96)
        Guna2HtmlLabel1.Margin = New Padding(2, 3, 2, 3)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(316, 25)
        Guna2HtmlLabel1.TabIndex = 82
        Guna2HtmlLabel1.Text = "Please scan the QR Code below"
        ' 
        ' lblPaymentMethod
        ' 
        lblPaymentMethod.AutoSize = True
        lblPaymentMethod.Font = New Font("Cooper Black", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPaymentMethod.ForeColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        lblPaymentMethod.Location = New Point(265, 41)
        lblPaymentMethod.Name = "lblPaymentMethod"
        lblPaymentMethod.Size = New Size(262, 39)
        lblPaymentMethod.TabIndex = 81
        lblPaymentMethod.Text = "QR PAYMENT"
        lblPaymentMethod.UseMnemonic = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(251, 141)
        PictureBox2.Margin = New Padding(2, 3, 2, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(295, 217)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 86
        PictureBox2.TabStop = False
        ' 
        ' User_QRPayment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(226), CByte(225))
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox2)
        Controls.Add(btnBack)
        Controls.Add(btnNext)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(lblPaymentMethod)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "User_QRPayment"
        StartPosition = FormStartPosition.CenterScreen
        Text = "QR PAYMENT"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNext As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
