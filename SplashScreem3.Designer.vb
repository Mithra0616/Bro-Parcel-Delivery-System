<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreem3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreem3))
        PictureBox1 = New PictureBox()
        lblPercent = New Label()
        lblLoading = New Label()
        msg_label = New Label()
        ProgressBar1 = New ProgressBar()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(213, 46)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(369, 225)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' lblPercent
        ' 
        lblPercent.AutoSize = True
        lblPercent.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPercent.Location = New Point(392, 375)
        lblPercent.Name = "lblPercent"
        lblPercent.Size = New Size(52, 21)
        lblPercent.TabIndex = 13
        lblPercent.Text = "000..."
        ' 
        ' lblLoading
        ' 
        lblLoading.AutoSize = True
        lblLoading.Font = New Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLoading.Location = New Point(279, 375)
        lblLoading.Name = "lblLoading"
        lblLoading.Size = New Size(97, 21)
        lblLoading.TabIndex = 12
        lblLoading.Text = "Loading... "
        ' 
        ' msg_label
        ' 
        msg_label.AutoSize = True
        msg_label.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        msg_label.Location = New Point(279, 341)
        msg_label.Name = "msg_label"
        msg_label.Size = New Size(180, 34)
        msg_label.TabIndex = 11
        msg_label.Text = "Processing..."
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(12, 399)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(776, 39)
        ProgressBar1.TabIndex = 10
        ' 
        ' Timer1
        ' 
        ' 
        ' SplashScreem3
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
        Name = "SplashScreem3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SplashScreem3"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPercent As Label
    Friend WithEvents lblLoading As Label
    Friend WithEvents msg_label As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
