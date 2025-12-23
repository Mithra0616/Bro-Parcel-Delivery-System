<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        ProgressBar1 = New ProgressBar()
        msg_label = New Label()
        lblLoading = New Label()
        lblPercent = New Label()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(12, 399)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(776, 39)
        ProgressBar1.TabIndex = 0
        ' 
        ' msg_label
        ' 
        msg_label.AutoSize = True
        msg_label.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        msg_label.Location = New Point(279, 341)
        msg_label.Name = "msg_label"
        msg_label.Size = New Size(180, 34)
        msg_label.TabIndex = 1
        msg_label.Text = "Processing..."
        ' 
        ' lblLoading
        ' 
        lblLoading.AutoSize = True
        lblLoading.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLoading.Location = New Point(279, 375)
        lblLoading.Name = "lblLoading"
        lblLoading.Size = New Size(97, 21)
        lblLoading.TabIndex = 2
        lblLoading.Text = "Loading... "
        ' 
        ' lblPercent
        ' 
        lblPercent.AutoSize = True
        lblPercent.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPercent.Location = New Point(389, 375)
        lblPercent.Name = "lblPercent"
        lblPercent.Size = New Size(52, 21)
        lblPercent.TabIndex = 3
        lblPercent.Text = "000..."
        ' 
        ' Timer1
        ' 
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(213, 79)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(369, 225)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' SplashScreen
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(226), CByte(225))
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(lblPercent)
        Controls.Add(lblLoading)
        Controls.Add(msg_label)
        Controls.Add(ProgressBar1)
        FormBorderStyle = FormBorderStyle.None
        Name = "SplashScreen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SplashScreen"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents msg_label As Label
    Friend WithEvents lblLoading As Label
    Friend WithEvents lblPercent As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
