<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment_Success
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payment_Success))
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnExit = New Guna.UI2.WinForms.Guna2Button()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        picAnimation = New PictureBox()
        CType(picAnimation, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Cooper Black", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.ForeColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        Guna2HtmlLabel1.Location = New Point(161, 51)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(458, 51)
        Guna2HtmlLabel1.TabIndex = 17
        Guna2HtmlLabel1.Text = "PAYMENT SUCCESS"
        ' 
        ' btnExit
        ' 
        btnExit.AutoRoundedCorners = True
        btnExit.BorderRadius = 19
        btnExit.CustomizableEdges = CustomizableEdges1
        btnExit.DisabledState.BorderColor = Color.DarkGray
        btnExit.DisabledState.CustomBorderColor = Color.DarkGray
        btnExit.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnExit.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnExit.FillColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        btnExit.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(319, 391)
        btnExit.Name = "btnExit"
        btnExit.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnExit.Size = New Size(143, 41)
        btnExit.TabIndex = 21
        btnExit.Text = "Exit"
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel2.ForeColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        Guna2HtmlLabel2.Location = New Point(108, 339)
        Guna2HtmlLabel2.Margin = New Padding(2, 3, 2, 3)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(597, 25)
        Guna2HtmlLabel2.TabIndex = 20
        Guna2HtmlLabel2.Text = "Thank you for your payment and for choosing our service!"
        ' 
        ' picAnimation
        ' 
        picAnimation.Image = CType(resources.GetObject("picAnimation.Image"), Image)
        picAnimation.Location = New Point(182, 54)
        picAnimation.Margin = New Padding(2, 3, 2, 3)
        picAnimation.Name = "picAnimation"
        picAnimation.Size = New Size(415, 327)
        picAnimation.SizeMode = PictureBoxSizeMode.Zoom
        picAnimation.TabIndex = 22
        picAnimation.TabStop = False
        ' 
        ' Payment_Success
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(226), CByte(225))
        ClientSize = New Size(800, 450)
        Controls.Add(btnExit)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(picAnimation)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Payment_Success"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PAYMENT SUCCESS"
        CType(picAnimation, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents picAnimation As PictureBox
End Class
