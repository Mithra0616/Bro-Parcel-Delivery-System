<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Finance
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
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtTotalProfit = New TextBox()
        btnBack = New Guna.UI2.WinForms.Guna2Button()
        btnCalculate = New Guna.UI2.WinForms.Guna2Button()
        dtpEndDate = New DateTimePicker()
        dtpStartDate = New DateTimePicker()
        DataGridViewProfit = New DataGridView()
        CType(DataGridViewProfit, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Guna2HtmlLabel2.ForeColor = Color.Black
        Guna2HtmlLabel2.Location = New Point(523, 56)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(113, 25)
        Guna2HtmlLabel2.TabIndex = 79
        Guna2HtmlLabel2.Text = "Total Profit :"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Guna2HtmlLabel1.ForeColor = Color.Black
        Guna2HtmlLabel1.Location = New Point(523, 260)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(50, 25)
        Guna2HtmlLabel1.TabIndex = 78
        Guna2HtmlLabel1.Text = "End :"
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Guna2HtmlLabel3.ForeColor = Color.Black
        Guna2HtmlLabel3.Location = New Point(523, 181)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(56, 25)
        Guna2HtmlLabel3.TabIndex = 77
        Guna2HtmlLabel3.Text = "Start :"
        ' 
        ' txtTotalProfit
        ' 
        txtTotalProfit.Location = New Point(523, 87)
        txtTotalProfit.Name = "txtTotalProfit"
        txtTotalProfit.ReadOnly = True
        txtTotalProfit.Size = New Size(262, 27)
        txtTotalProfit.TabIndex = 76
        ' 
        ' btnBack
        ' 
        btnBack.AutoRoundedCorners = True
        btnBack.BorderRadius = 15
        btnBack.CustomizableEdges = CustomizableEdges1
        btnBack.DisabledState.BorderColor = Color.DarkGray
        btnBack.DisabledState.CustomBorderColor = Color.DarkGray
        btnBack.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnBack.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnBack.FillColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        btnBack.Font = New Font("Century Gothic", 9F)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(27, 389)
        btnBack.Name = "btnBack"
        btnBack.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnBack.Size = New Size(176, 32)
        btnBack.TabIndex = 75
        btnBack.Text = "Back"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.AutoRoundedCorners = True
        btnCalculate.BorderRadius = 15
        btnCalculate.CustomizableEdges = CustomizableEdges3
        btnCalculate.DisabledState.BorderColor = Color.DarkGray
        btnCalculate.DisabledState.CustomBorderColor = Color.DarkGray
        btnCalculate.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnCalculate.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnCalculate.FillColor = Color.FromArgb(CByte(239), CByte(89), CByte(39))
        btnCalculate.Font = New Font("Century Gothic", 9F)
        btnCalculate.ForeColor = Color.White
        btnCalculate.Location = New Point(563, 337)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnCalculate.Size = New Size(176, 32)
        btnCalculate.TabIndex = 74
        btnCalculate.Text = "Calculate"
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Location = New Point(523, 291)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(262, 27)
        dtpEndDate.TabIndex = 73
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Location = New Point(523, 212)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(262, 27)
        dtpStartDate.TabIndex = 72
        ' 
        ' DataGridViewProfit
        ' 
        DataGridViewProfit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewProfit.Location = New Point(27, 29)
        DataGridViewProfit.Name = "DataGridViewProfit"
        DataGridViewProfit.RowHeadersWidth = 51
        DataGridViewProfit.Size = New Size(474, 340)
        DataGridViewProfit.TabIndex = 71
        ' 
        ' Admin_Finance
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(226), CByte(225))
        ClientSize = New Size(800, 450)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(Guna2HtmlLabel3)
        Controls.Add(txtTotalProfit)
        Controls.Add(btnBack)
        Controls.Add(btnCalculate)
        Controls.Add(dtpEndDate)
        Controls.Add(dtpStartDate)
        Controls.Add(DataGridViewProfit)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Admin_Finance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FINANCE"
        CType(DataGridViewProfit, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtTotalProfit As TextBox
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCalculate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents DataGridViewProfit As DataGridView
End Class
