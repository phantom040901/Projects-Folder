<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        btnLogin = New Guna.UI2.WinForms.Guna2GradientButton()
        cb_UserType = New ComboBox()
        Button1 = New Button()
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Guna2CirclePictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Sitka Subheading", 27.75F, FontStyle.Bold Or FontStyle.Italic)
        Guna2HtmlLabel1.Location = New Point(119, 20)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(378, 55)
        Guna2HtmlLabel1.TabIndex = 1
        Guna2HtmlLabel1.Text = "ADMIN PANEL LOGIN"
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Sitka Subheading", 36F, FontStyle.Bold)
        Guna2HtmlLabel2.ForeColor = Color.Transparent
        Guna2HtmlLabel2.Location = New Point(191, 27)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(163, 71)
        Guna2HtmlLabel2.TabIndex = 0
        Guna2HtmlLabel2.Text = "LOG IN"
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderRadius = 10
        txtUsername.CustomizableEdges = CustomizableEdges1
        txtUsername.DefaultText = ""
        txtUsername.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtUsername.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtUsername.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtUsername.FillColor = Color.DarkOrange
        txtUsername.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtUsername.Font = New Font("Segoe UI", 9F)
        txtUsername.ForeColor = Color.White
        txtUsername.Location = New Point(149, 116)
        txtUsername.Name = "txtUsername"
        txtUsername.PasswordChar = ChrW(0)
        txtUsername.PlaceholderForeColor = Color.White
        txtUsername.PlaceholderText = "Username"
        txtUsername.SelectedText = ""
        txtUsername.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtUsername.Size = New Size(283, 39)
        txtUsername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        txtUsername.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.Transparent
        txtPassword.BorderRadius = 10
        txtPassword.CustomizableEdges = CustomizableEdges3
        txtPassword.DefaultText = ""
        txtPassword.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtPassword.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtPassword.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPassword.FillColor = Color.DarkOrange
        txtPassword.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPassword.Font = New Font("Segoe UI", 9F)
        txtPassword.ForeColor = Color.White
        txtPassword.Location = New Point(149, 172)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = ChrW(0)
        txtPassword.PlaceholderForeColor = Color.White
        txtPassword.PlaceholderText = "Password"
        txtPassword.SelectedText = ""
        txtPassword.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtPassword.Size = New Size(283, 39)
        txtPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        txtPassword.TabIndex = 2
        ' 
        ' Guna2CirclePictureBox1
        ' 
        Guna2CirclePictureBox1.BackColor = Color.Transparent
        Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), Image)
        Guna2CirclePictureBox1.ImageRotate = 0F
        Guna2CirclePictureBox1.Location = New Point(104, 116)
        Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges5
        Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CirclePictureBox1.Size = New Size(39, 39)
        Guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Guna2CirclePictureBox1.TabIndex = 3
        Guna2CirclePictureBox1.TabStop = False
        ' 
        ' Guna2CirclePictureBox2
        ' 
        Guna2CirclePictureBox2.BackColor = Color.Transparent
        Guna2CirclePictureBox2.FillColor = SystemColors.Window
        Guna2CirclePictureBox2.Image = CType(resources.GetObject("Guna2CirclePictureBox2.Image"), Image)
        Guna2CirclePictureBox2.ImageRotate = 0F
        Guna2CirclePictureBox2.Location = New Point(104, 172)
        Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2"
        Guna2CirclePictureBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CirclePictureBox2.Size = New Size(39, 39)
        Guna2CirclePictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        Guna2CirclePictureBox2.TabIndex = 4
        Guna2CirclePictureBox2.TabStop = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Transparent
        btnLogin.BorderRadius = 10
        btnLogin.CustomBorderColor = Color.White
        btnLogin.CustomizableEdges = CustomizableEdges7
        btnLogin.DisabledState.BorderColor = Color.DarkGray
        btnLogin.DisabledState.CustomBorderColor = Color.DarkGray
        btnLogin.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnLogin.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnLogin.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnLogin.FillColor = Color.White
        btnLogin.FillColor2 = Color.HotPink
        btnLogin.Font = New Font("Verdana", 9.75F)
        btnLogin.ForeColor = Color.Black
        btnLogin.HoverState.FillColor = Color.HotPink
        btnLogin.HoverState.FillColor2 = Color.DeepPink
        btnLogin.Location = New Point(191, 274)
        btnLogin.Name = "btnLogin"
        btnLogin.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnLogin.Size = New Size(180, 40)
        btnLogin.TabIndex = 3
        btnLogin.Text = "LOGIN"
        ' 
        ' cb_UserType
        ' 
        cb_UserType.FormattingEnabled = True
        cb_UserType.Items.AddRange(New Object() {"Employee", "Admin"})
        cb_UserType.Location = New Point(12, 12)
        cb_UserType.Name = "cb_UserType"
        cb_UserType.Size = New Size(121, 23)
        cb_UserType.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(390, 74)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 6
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(539, 339)
        Controls.Add(Button1)
        Controls.Add(cb_UserType)
        Controls.Add(btnLogin)
        Controls.Add(Guna2CirclePictureBox2)
        Controls.Add(Guna2CirclePictureBox1)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Guna2HtmlLabel2)
        DoubleBuffered = True
        ForeColor = SystemColors.ControlLight
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(Guna2CirclePictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents cb_UserType As ComboBox
    Friend WithEvents Button1 As Button
End Class
