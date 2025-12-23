<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Upload_Payment
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
        btnUploadReceipt = New Guna.UI2.WinForms.Guna2Button()
        btnBack = New Guna.UI2.WinForms.Guna2Button()
        PictureBoxPreview = New PictureBox()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(PictureBoxPreview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnUploadReceipt
        ' 
        btnUploadReceipt.AutoRoundedCorners = True
        btnUploadReceipt.BorderRadius = 15
        btnUploadReceipt.CustomizableEdges = CustomizableEdges1
        btnUploadReceipt.DisabledState.BorderColor = Color.DarkGray
        btnUploadReceipt.DisabledState.CustomBorderColor = Color.DarkGray
        btnUploadReceipt.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnUploadReceipt.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnUploadReceipt.FillColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        btnUploadReceipt.Font = New Font("Century Gothic", 9F)
        btnUploadReceipt.ForeColor = Color.White
        btnUploadReceipt.Location = New Point(564, 201)
        btnUploadReceipt.Name = "btnUploadReceipt"
        btnUploadReceipt.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnUploadReceipt.Size = New Size(176, 32)
        btnUploadReceipt.TabIndex = 50
        btnUploadReceipt.Text = "Upload Receipt"
        ' 
        ' btnBack
        ' 
        btnBack.AutoRoundedCorners = True
        btnBack.BorderRadius = 15
        btnBack.CustomizableEdges = CustomizableEdges3
        btnBack.DisabledState.BorderColor = Color.DarkGray
        btnBack.DisabledState.CustomBorderColor = Color.DarkGray
        btnBack.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnBack.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnBack.FillColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        btnBack.Font = New Font("Century Gothic", 9F)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(564, 398)
        btnBack.Name = "btnBack"
        btnBack.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnBack.Size = New Size(176, 32)
        btnBack.TabIndex = 49
        btnBack.Text = "Back"
        ' 
        ' PictureBoxPreview
        ' 
        PictureBoxPreview.Location = New Point(60, 139)
        PictureBoxPreview.Margin = New Padding(2, 3, 2, 3)
        PictureBoxPreview.Name = "PictureBoxPreview"
        PictureBoxPreview.Size = New Size(441, 291)
        PictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxPreview.TabIndex = 48
        PictureBoxPreview.TabStop = False
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel2.ForeColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        Guna2HtmlLabel2.Location = New Point(164, 81)
        Guna2HtmlLabel2.Margin = New Padding(2, 3, 2, 3)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(435, 25)
        Guna2HtmlLabel2.TabIndex = 47
        Guna2HtmlLabel2.Text = "Please upload your payment receipt below"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Cooper Black", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.ForeColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        Guna2HtmlLabel1.Location = New Point(164, 21)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(441, 51)
        Guna2HtmlLabel1.TabIndex = 46
        Guna2HtmlLabel1.Text = "UPLOAD PAYMENT"
        ' 
        ' User_Upload_Payment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(226), CByte(225))
        ClientSize = New Size(800, 450)
        Controls.Add(btnUploadReceipt)
        Controls.Add(btnBack)
        Controls.Add(PictureBoxPreview)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(Guna2HtmlLabel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "User_Upload_Payment"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UPLOAD_PAYMENT"
        CType(PictureBoxPreview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnUploadReceipt As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBoxPreview As PictureBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
