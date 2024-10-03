<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlLeftSide = New Panel()
        pnlOnVaria = New Panel()
        btnLogout = New Button()
        pnlOnAbout = New Panel()
        btnClassified = New Button()
        btnAbout = New Button()
        pnlOnOther = New Panel()
        btnComplianceReports = New Button()
        pnlOnDispo = New Panel()
        btnConfigurationFiles = New Button()
        Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        pnlOnJuice = New Panel()
        btnAuditLogs = New Button()
        pnlClassified = New Panel()
        DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Classified = New DataGridViewTextBoxColumn()
        pnlConfigurationFiles = New Panel()
        DataGridView3 = New Guna.UI2.WinForms.Guna2DataGridView()
        ConfigurationFiles = New DataGridViewTextBoxColumn()
        pnlComplianceReports = New Panel()
        DataGridView4 = New Guna.UI2.WinForms.Guna2DataGridView()
        ComplianceReports = New DataGridViewTextBoxColumn()
        pnlAuditLogs = New Panel()
        DataGridView2 = New Guna.UI2.WinForms.Guna2DataGridView()
        AuditLogs = New DataGridViewTextBoxColumn()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        pnlAbout = New Panel()
        pnlLeftSide.SuspendLayout()
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlClassified.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        pnlConfigurationFiles.SuspendLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        pnlComplianceReports.SuspendLayout()
        CType(DataGridView4, ComponentModel.ISupportInitialize).BeginInit()
        pnlAuditLogs.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlLeftSide
        ' 
        pnlLeftSide.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        pnlLeftSide.BackgroundImageLayout = ImageLayout.Stretch
        pnlLeftSide.Controls.Add(pnlOnVaria)
        pnlLeftSide.Controls.Add(btnLogout)
        pnlLeftSide.Controls.Add(pnlOnAbout)
        pnlLeftSide.Controls.Add(btnClassified)
        pnlLeftSide.Controls.Add(btnAbout)
        pnlLeftSide.Controls.Add(pnlOnOther)
        pnlLeftSide.Controls.Add(btnComplianceReports)
        pnlLeftSide.Controls.Add(pnlOnDispo)
        pnlLeftSide.Controls.Add(btnConfigurationFiles)
        pnlLeftSide.Controls.Add(Guna2CirclePictureBox1)
        pnlLeftSide.Controls.Add(pnlOnJuice)
        pnlLeftSide.Controls.Add(btnAuditLogs)
        pnlLeftSide.Dock = DockStyle.Left
        pnlLeftSide.Location = New Point(0, 0)
        pnlLeftSide.Name = "pnlLeftSide"
        pnlLeftSide.Size = New Size(194, 450)
        pnlLeftSide.TabIndex = 1
        ' 
        ' pnlOnVaria
        ' 
        pnlOnVaria.BackColor = Color.Orange
        pnlOnVaria.BackgroundImageLayout = ImageLayout.None
        pnlOnVaria.Location = New Point(0, 149)
        pnlOnVaria.Name = "pnlOnVaria"
        pnlOnVaria.Size = New Size(10, 38)
        pnlOnVaria.TabIndex = 2
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Transparent
        btnLogout.BackgroundImageLayout = ImageLayout.Zoom
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Microsoft Tai Le", 12F)
        btnLogout.ForeColor = Color.White
        btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), Image)
        btnLogout.Location = New Point(0, 400)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(194, 38)
        btnLogout.TabIndex = 12
        btnLogout.Text = "Log out "
        btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' pnlOnAbout
        ' 
        pnlOnAbout.BackColor = Color.Orange
        pnlOnAbout.BackgroundImageLayout = ImageLayout.None
        pnlOnAbout.Location = New Point(0, 325)
        pnlOnAbout.Name = "pnlOnAbout"
        pnlOnAbout.Size = New Size(10, 38)
        pnlOnAbout.TabIndex = 11
        ' 
        ' btnClassified
        ' 
        btnClassified.BackColor = Color.Transparent
        btnClassified.BackgroundImageLayout = ImageLayout.Zoom
        btnClassified.FlatAppearance.BorderSize = 0
        btnClassified.FlatStyle = FlatStyle.Flat
        btnClassified.Font = New Font("Microsoft Tai Le", 12F)
        btnClassified.ForeColor = Color.WhiteSmoke
        btnClassified.Image = CType(resources.GetObject("btnClassified.Image"), Image)
        btnClassified.Location = New Point(3, 149)
        btnClassified.Name = "btnClassified"
        btnClassified.Size = New Size(191, 38)
        btnClassified.TabIndex = 0
        btnClassified.Text = "Classified"
        btnClassified.TextImageRelation = TextImageRelation.ImageBeforeText
        btnClassified.UseVisualStyleBackColor = False
        ' 
        ' btnAbout
        ' 
        btnAbout.BackColor = Color.Transparent
        btnAbout.BackgroundImageLayout = ImageLayout.Zoom
        btnAbout.FlatAppearance.BorderSize = 0
        btnAbout.FlatStyle = FlatStyle.Flat
        btnAbout.Font = New Font("Microsoft Tai Le", 12F)
        btnAbout.ForeColor = Color.WhiteSmoke
        btnAbout.Image = CType(resources.GetObject("btnAbout.Image"), Image)
        btnAbout.Location = New Point(0, 325)
        btnAbout.Name = "btnAbout"
        btnAbout.Size = New Size(194, 38)
        btnAbout.TabIndex = 10
        btnAbout.Text = "  About"
        btnAbout.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAbout.UseVisualStyleBackColor = False
        ' 
        ' pnlOnOther
        ' 
        pnlOnOther.BackColor = Color.Orange
        pnlOnOther.BackgroundImageLayout = ImageLayout.None
        pnlOnOther.Location = New Point(0, 281)
        pnlOnOther.Name = "pnlOnOther"
        pnlOnOther.Size = New Size(10, 38)
        pnlOnOther.TabIndex = 9
        ' 
        ' btnComplianceReports
        ' 
        btnComplianceReports.BackColor = Color.Transparent
        btnComplianceReports.BackgroundImageLayout = ImageLayout.Zoom
        btnComplianceReports.FlatAppearance.BorderSize = 0
        btnComplianceReports.FlatStyle = FlatStyle.Flat
        btnComplianceReports.Font = New Font("Microsoft Tai Le", 12F)
        btnComplianceReports.ForeColor = Color.WhiteSmoke
        btnComplianceReports.Image = CType(resources.GetObject("btnComplianceReports.Image"), Image)
        btnComplianceReports.Location = New Point(0, 281)
        btnComplianceReports.Name = "btnComplianceReports"
        btnComplianceReports.Size = New Size(194, 38)
        btnComplianceReports.TabIndex = 8
        btnComplianceReports.Text = "Compliance Reports"
        btnComplianceReports.TextImageRelation = TextImageRelation.ImageBeforeText
        btnComplianceReports.UseVisualStyleBackColor = False
        ' 
        ' pnlOnDispo
        ' 
        pnlOnDispo.BackColor = Color.Orange
        pnlOnDispo.BackgroundImageLayout = ImageLayout.None
        pnlOnDispo.Location = New Point(0, 193)
        pnlOnDispo.Name = "pnlOnDispo"
        pnlOnDispo.Size = New Size(10, 38)
        pnlOnDispo.TabIndex = 5
        ' 
        ' btnConfigurationFiles
        ' 
        btnConfigurationFiles.BackColor = Color.Transparent
        btnConfigurationFiles.BackgroundImageLayout = ImageLayout.Zoom
        btnConfigurationFiles.FlatAppearance.BorderSize = 0
        btnConfigurationFiles.FlatStyle = FlatStyle.Flat
        btnConfigurationFiles.Font = New Font("Microsoft Tai Le", 12F)
        btnConfigurationFiles.ForeColor = Color.WhiteSmoke
        btnConfigurationFiles.Image = CType(resources.GetObject("btnConfigurationFiles.Image"), Image)
        btnConfigurationFiles.Location = New Point(0, 193)
        btnConfigurationFiles.Name = "btnConfigurationFiles"
        btnConfigurationFiles.Size = New Size(194, 38)
        btnConfigurationFiles.TabIndex = 4
        btnConfigurationFiles.Text = "Configuration Files"
        btnConfigurationFiles.TextImageRelation = TextImageRelation.ImageBeforeText
        btnConfigurationFiles.UseVisualStyleBackColor = False
        ' 
        ' Guna2CirclePictureBox1
        ' 
        Guna2CirclePictureBox1.BackColor = Color.Transparent
        Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), Image)
        Guna2CirclePictureBox1.ImageRotate = 0F
        Guna2CirclePictureBox1.Location = New Point(33, 29)
        Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CirclePictureBox1.Size = New Size(118, 109)
        Guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Guna2CirclePictureBox1.TabIndex = 3
        Guna2CirclePictureBox1.TabStop = False
        ' 
        ' pnlOnJuice
        ' 
        pnlOnJuice.BackColor = Color.Orange
        pnlOnJuice.BackgroundImageLayout = ImageLayout.None
        pnlOnJuice.Location = New Point(0, 237)
        pnlOnJuice.Name = "pnlOnJuice"
        pnlOnJuice.Size = New Size(10, 38)
        pnlOnJuice.TabIndex = 7
        ' 
        ' btnAuditLogs
        ' 
        btnAuditLogs.BackColor = Color.Transparent
        btnAuditLogs.BackgroundImageLayout = ImageLayout.Zoom
        btnAuditLogs.FlatAppearance.BorderSize = 0
        btnAuditLogs.FlatStyle = FlatStyle.Flat
        btnAuditLogs.Font = New Font("Microsoft Tai Le", 12F)
        btnAuditLogs.ForeColor = Color.WhiteSmoke
        btnAuditLogs.Image = CType(resources.GetObject("btnAuditLogs.Image"), Image)
        btnAuditLogs.Location = New Point(0, 237)
        btnAuditLogs.Name = "btnAuditLogs"
        btnAuditLogs.Size = New Size(194, 38)
        btnAuditLogs.TabIndex = 6
        btnAuditLogs.Text = "Audit Logs"
        btnAuditLogs.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAuditLogs.UseVisualStyleBackColor = False
        ' 
        ' pnlClassified
        ' 
        pnlClassified.AutoScroll = True
        pnlClassified.BackColor = SystemColors.WindowText
        pnlClassified.BackgroundImage = CType(resources.GetObject("pnlClassified.BackgroundImage"), Image)
        pnlClassified.BackgroundImageLayout = ImageLayout.Stretch
        pnlClassified.Controls.Add(DataGridView1)
        pnlClassified.Location = New Point(194, 0)
        pnlClassified.Name = "pnlClassified"
        pnlClassified.Size = New Size(307, 450)
        pnlClassified.TabIndex = 3
        ' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.ColumnHeadersHeight = 4
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Classified})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.Size = New Size(307, 450)
        DataGridView1.TabIndex = 0
        DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        DataGridView1.ThemeStyle.BackColor = Color.White
        DataGridView1.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridView1.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White
        DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridView1.ThemeStyle.HeaderStyle.Height = 4
        DataGridView1.ThemeStyle.ReadOnly = False
        DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White
        DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView1.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridView1.ThemeStyle.RowsStyle.Height = 25
        DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Classified
        ' 
        Classified.HeaderText = "Classified"
        Classified.Name = "Classified"
        ' 
        ' pnlConfigurationFiles
        ' 
        pnlConfigurationFiles.BackgroundImage = CType(resources.GetObject("pnlConfigurationFiles.BackgroundImage"), Image)
        pnlConfigurationFiles.BackgroundImageLayout = ImageLayout.Stretch
        pnlConfigurationFiles.Controls.Add(DataGridView3)
        pnlConfigurationFiles.Location = New Point(194, 0)
        pnlConfigurationFiles.Name = "pnlConfigurationFiles"
        pnlConfigurationFiles.Size = New Size(307, 447)
        pnlConfigurationFiles.TabIndex = 4
        ' 
        ' DataGridView3
        ' 
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridView3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridView3.ColumnHeadersHeight = 4
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridView3.Columns.AddRange(New DataGridViewColumn() {ConfigurationFiles})
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        DataGridView3.DefaultCellStyle = DataGridViewCellStyle6
        DataGridView3.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridView3.Location = New Point(0, -2)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.RowHeadersVisible = False
        DataGridView3.Size = New Size(307, 450)
        DataGridView3.TabIndex = 1
        DataGridView3.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        DataGridView3.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        DataGridView3.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        DataGridView3.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        DataGridView3.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        DataGridView3.ThemeStyle.BackColor = Color.White
        DataGridView3.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridView3.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridView3.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridView3.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        DataGridView3.ThemeStyle.HeaderStyle.ForeColor = Color.White
        DataGridView3.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridView3.ThemeStyle.HeaderStyle.Height = 4
        DataGridView3.ThemeStyle.ReadOnly = False
        DataGridView3.ThemeStyle.RowsStyle.BackColor = Color.White
        DataGridView3.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView3.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        DataGridView3.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridView3.ThemeStyle.RowsStyle.Height = 25
        DataGridView3.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridView3.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' ConfigurationFiles
        ' 
        ConfigurationFiles.HeaderText = "ConfigurationFiles"
        ConfigurationFiles.Name = "ConfigurationFiles"
        ' 
        ' pnlComplianceReports
        ' 
        pnlComplianceReports.BackgroundImage = CType(resources.GetObject("pnlComplianceReports.BackgroundImage"), Image)
        pnlComplianceReports.BackgroundImageLayout = ImageLayout.Stretch
        pnlComplianceReports.Controls.Add(DataGridView4)
        pnlComplianceReports.Location = New Point(197, 3)
        pnlComplianceReports.Name = "pnlComplianceReports"
        pnlComplianceReports.Size = New Size(304, 443)
        pnlComplianceReports.TabIndex = 5
        ' 
        ' DataGridView4
        ' 
        DataGridViewCellStyle7.BackColor = Color.White
        DataGridView4.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle8.ForeColor = Color.White
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        DataGridView4.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        DataGridView4.ColumnHeadersHeight = 4
        DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridView4.Columns.AddRange(New DataGridViewColumn() {ComplianceReports})
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = Color.White
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle9.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False
        DataGridView4.DefaultCellStyle = DataGridViewCellStyle9
        DataGridView4.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridView4.Location = New Point(-1, -4)
        DataGridView4.Name = "DataGridView4"
        DataGridView4.RowHeadersVisible = False
        DataGridView4.Size = New Size(307, 450)
        DataGridView4.TabIndex = 1
        DataGridView4.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        DataGridView4.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        DataGridView4.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        DataGridView4.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        DataGridView4.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        DataGridView4.ThemeStyle.BackColor = Color.White
        DataGridView4.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridView4.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridView4.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridView4.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        DataGridView4.ThemeStyle.HeaderStyle.ForeColor = Color.White
        DataGridView4.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridView4.ThemeStyle.HeaderStyle.Height = 4
        DataGridView4.ThemeStyle.ReadOnly = False
        DataGridView4.ThemeStyle.RowsStyle.BackColor = Color.White
        DataGridView4.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView4.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        DataGridView4.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridView4.ThemeStyle.RowsStyle.Height = 25
        DataGridView4.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridView4.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' ComplianceReports
        ' 
        ComplianceReports.HeaderText = "ComplianceReports"
        ComplianceReports.Name = "ComplianceReports"
        ' 
        ' pnlAuditLogs
        ' 
        pnlAuditLogs.BackgroundImageLayout = ImageLayout.Stretch
        pnlAuditLogs.Controls.Add(DataGridView2)
        pnlAuditLogs.Location = New Point(197, 3)
        pnlAuditLogs.Name = "pnlAuditLogs"
        pnlAuditLogs.Size = New Size(304, 443)
        pnlAuditLogs.TabIndex = 6
        ' 
        ' DataGridView2
        ' 
        DataGridViewCellStyle10.BackColor = Color.White
        DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle11.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle11.ForeColor = Color.White
        DataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True
        DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        DataGridView2.ColumnHeadersHeight = 4
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {AuditLogs})
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = Color.White
        DataGridViewCellStyle12.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle12.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle12.WrapMode = DataGridViewTriState.False
        DataGridView2.DefaultCellStyle = DataGridViewCellStyle12
        DataGridView2.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridView2.Location = New Point(-1, -4)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersVisible = False
        DataGridView2.Size = New Size(307, 450)
        DataGridView2.TabIndex = 1
        DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        DataGridView2.ThemeStyle.BackColor = Color.White
        DataGridView2.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridView2.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridView2.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        DataGridView2.ThemeStyle.HeaderStyle.ForeColor = Color.White
        DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridView2.ThemeStyle.HeaderStyle.Height = 4
        DataGridView2.ThemeStyle.ReadOnly = False
        DataGridView2.ThemeStyle.RowsStyle.BackColor = Color.White
        DataGridView2.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView2.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        DataGridView2.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridView2.ThemeStyle.RowsStyle.Height = 25
        DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' AuditLogs
        ' 
        AuditLogs.HeaderText = "AuditLogs"
        AuditLogs.Name = "AuditLogs"
        ' 
        ' pnlAbout
        ' 
        pnlAbout.BackgroundImage = CType(resources.GetObject("pnlAbout.BackgroundImage"), Image)
        pnlAbout.BackgroundImageLayout = ImageLayout.Stretch
        pnlAbout.Location = New Point(197, 3)
        pnlAbout.Name = "pnlAbout"
        pnlAbout.Size = New Size(304, 441)
        pnlAbout.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(500, 450)
        Controls.Add(pnlAuditLogs)
        Controls.Add(pnlClassified)
        Controls.Add(pnlConfigurationFiles)
        Controls.Add(pnlComplianceReports)
        Controls.Add(pnlAbout)
        Controls.Add(pnlLeftSide)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        pnlLeftSide.ResumeLayout(False)
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlClassified.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        pnlConfigurationFiles.ResumeLayout(False)
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        pnlComplianceReports.ResumeLayout(False)
        CType(DataGridView4, ComponentModel.ISupportInitialize).EndInit()
        pnlAuditLogs.ResumeLayout(False)
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlLeftSide As Panel
    Friend WithEvents pnlOnVaria As Panel
    Friend WithEvents btnClassified As Button
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents pnlOnAbout As Panel
    Friend WithEvents btnAbout As Button
    Friend WithEvents pnlOnOther As Panel
    Friend WithEvents btnComplianceReports As Button
    Friend WithEvents pnlOnJuice As Panel
    Friend WithEvents btnAuditLogs As Button
    Friend WithEvents pnlOnDispo As Panel
    Friend WithEvents btnConfigurationFiles As Button
    Friend WithEvents pnlOnLogout As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlClassified As Panel
    Friend WithEvents pnlConfigurationFiles As Panel
    Friend WithEvents pnlComplianceReports As Panel
    Friend WithEvents pnlAuditLogs As Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents pnlAbout As Panel
    Friend WithEvents DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Classified As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents AuditLogs As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView3 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ConfigurationFiles As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView4 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ComplianceReports As DataGridViewTextBoxColumn
End Class
