<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_OnlineBanking
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
        btnNext = New Guna.UI2.WinForms.Guna2Button()
        lblPaymentMethod = New Label()
        Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        lblBankName = New Label()
        lblAccountNumber = New Label()
        lblName = New Label()
        lblBankDetails = New Label()
        Guna2GroupBox1.SuspendLayout()
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
        btnBack.TabIndex = 87
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
        btnNext.TabIndex = 86
        btnNext.Text = "Next"
        ' 
        ' lblPaymentMethod
        ' 
        lblPaymentMethod.AutoSize = True
        lblPaymentMethod.Font = New Font("Cooper Black", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPaymentMethod.ForeColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        lblPaymentMethod.Location = New Point(223, 40)
        lblPaymentMethod.Name = "lblPaymentMethod"
        lblPaymentMethod.Size = New Size(344, 39)
        lblPaymentMethod.TabIndex = 85
        lblPaymentMethod.Text = "ONLINE BANKING"
        lblPaymentMethod.UseMnemonic = False
        ' 
        ' Guna2GroupBox1
        ' 
        Guna2GroupBox1.BorderRadius = 16
        Guna2GroupBox1.BorderStyle = Drawing2D.DashStyle.Dash
        Guna2GroupBox1.Controls.Add(lblBankName)
        Guna2GroupBox1.Controls.Add(lblAccountNumber)
        Guna2GroupBox1.Controls.Add(lblName)
        Guna2GroupBox1.Controls.Add(lblBankDetails)
        Guna2GroupBox1.CustomizableEdges = CustomizableEdges5
        Guna2GroupBox1.FillColor = Color.Silver
        Guna2GroupBox1.Font = New Font("Segoe UI", 9F)
        Guna2GroupBox1.ForeColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2GroupBox1.Location = New Point(173, 130)
        Guna2GroupBox1.Margin = New Padding(2)
        Guna2GroupBox1.Name = "Guna2GroupBox1"
        Guna2GroupBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2GroupBox1.Size = New Size(455, 190)
        Guna2GroupBox1.TabIndex = 88
        Guna2GroupBox1.Text = "Guna2GroupBox1"
        ' 
        ' lblBankName
        ' 
        lblBankName.AutoSize = True
        lblBankName.BackColor = Color.White
        lblBankName.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBankName.Location = New Point(50, 148)
        lblBankName.Margin = New Padding(2, 0, 2, 0)
        lblBankName.Name = "lblBankName"
        lblBankName.Size = New Size(265, 25)
        lblBankName.TabIndex = 15
        lblBankName.Text = "Bank name : Madani Bank"
        ' 
        ' lblAccountNumber
        ' 
        lblAccountNumber.AutoSize = True
        lblAccountNumber.BackColor = Color.White
        lblAccountNumber.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(134))
        lblAccountNumber.Location = New Point(50, 104)
        lblAccountNumber.Margin = New Padding(2, 0, 2, 0)
        lblAccountNumber.Name = "lblAccountNumber"
        lblAccountNumber.Size = New Size(323, 25)
        lblAccountNumber.TabIndex = 14
        lblAccountNumber.Text = "Account Number : 75450296425"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.BackColor = Color.White
        lblName.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(50, 59)
        lblName.Margin = New Padding(2, 0, 2, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(381, 25)
        lblName.TabIndex = 13
        lblName.Text = "Name : Bro Parcel Delivery Enterprise "
        ' 
        ' lblBankDetails
        ' 
        lblBankDetails.AutoSize = True
        lblBankDetails.BackColor = Color.White
        lblBankDetails.Font = New Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBankDetails.ForeColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        lblBankDetails.Location = New Point(8, 8)
        lblBankDetails.Name = "lblBankDetails"
        lblBankDetails.Size = New Size(142, 23)
        lblBankDetails.TabIndex = 12
        lblBankDetails.Text = "Bank details:"
        lblBankDetails.UseMnemonic = False
        ' 
        ' User_OnlineBanking
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(226), CByte(225))
        ClientSize = New Size(800, 450)
        Controls.Add(Guna2GroupBox1)
        Controls.Add(btnBack)
        Controls.Add(btnNext)
        Controls.Add(lblPaymentMethod)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "User_OnlineBanking"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ONLINE BANKING"
        Guna2GroupBox1.ResumeLayout(False)
        Guna2GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNext As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblPaymentMethod As Label
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblBankName As Label
    Friend WithEvents lblAccountNumber As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblBankDetails As Label
End Class
