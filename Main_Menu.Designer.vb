<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Menu))
        btnRider = New Guna.UI2.WinForms.Guna2Button()
        btnAdmin = New Guna.UI2.WinForms.Guna2Button()
        btnStudent = New Guna.UI2.WinForms.Guna2Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnRider
        ' 
        btnRider.AutoRoundedCorners = True
        btnRider.BorderRadius = 27
        btnRider.CustomizableEdges = CustomizableEdges1
        btnRider.DisabledState.BorderColor = Color.DarkGray
        btnRider.DisabledState.CustomBorderColor = Color.DarkGray
        btnRider.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnRider.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnRider.FillColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        btnRider.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRider.ForeColor = Color.White
        btnRider.Location = New Point(89, 318)
        btnRider.Name = "btnRider"
        btnRider.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnRider.Size = New Size(225, 56)
        btnRider.TabIndex = 14
        btnRider.Text = "Rider"
        ' 
        ' btnAdmin
        ' 
        btnAdmin.AutoRoundedCorners = True
        btnAdmin.BackColor = Color.Transparent
        btnAdmin.BorderRadius = 27
        btnAdmin.CustomizableEdges = CustomizableEdges3
        btnAdmin.DisabledState.BorderColor = Color.DarkGray
        btnAdmin.DisabledState.CustomBorderColor = Color.DarkGray
        btnAdmin.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAdmin.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAdmin.FillColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        btnAdmin.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdmin.ForeColor = Color.White
        btnAdmin.Location = New Point(89, 233)
        btnAdmin.Name = "btnAdmin"
        btnAdmin.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnAdmin.Size = New Size(225, 56)
        btnAdmin.TabIndex = 13
        btnAdmin.Text = "Admin"
        ' 
        ' btnStudent
        ' 
        btnStudent.AutoRoundedCorners = True
        btnStudent.BackColor = Color.Transparent
        btnStudent.BorderRadius = 27
        btnStudent.CustomizableEdges = CustomizableEdges5
        btnStudent.DisabledState.BorderColor = Color.DarkGray
        btnStudent.DisabledState.CustomBorderColor = Color.DarkGray
        btnStudent.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnStudent.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnStudent.FillColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        btnStudent.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnStudent.ForeColor = Color.White
        btnStudent.Location = New Point(89, 146)
        btnStudent.Name = "btnStudent"
        btnStudent.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnStudent.Size = New Size(225, 56)
        btnStudent.TabIndex = 12
        btnStudent.Text = "Student"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        Label1.Location = New Point(22, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(442, 69)
        Label1.TabIndex = 10
        Label1.Text = "BRO PARCEL"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(320, -10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(474, 470)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(246), CByte(226), CByte(225))
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.ForeColor = Color.FromArgb(CByte(246), CByte(226), CByte(225))
        Button1.Location = New Point(9, 394)
        Button1.Margin = New Padding(0)
        Button1.Name = "Button1"
        Button1.Size = New Size(47, 47)
        Button1.TabIndex = 15
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Main_Menu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(226), CByte(225))
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(btnRider)
        Controls.Add(btnAdmin)
        Controls.Add(btnStudent)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Main_Menu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MAIN MENU"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnRider As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdmin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnStudent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button

End Class
