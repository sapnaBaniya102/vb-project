<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.registerpnl = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.picture = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.datetime = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.phonenumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.email = New Guna.UI2.WinForms.Guna2TextBox()
        Me.address = New Guna.UI2.WinForms.Guna2TextBox()
        Me.username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.fullname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.registercloase = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.maximize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.minimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.registerpnl.SuspendLayout()
        CType(Me.picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'registerpnl
        '
        Me.registerpnl.BackColor = System.Drawing.Color.Transparent
        Me.registerpnl.BackgroundImage = Global.first.My.Resources.Resources.landing_page
        Me.registerpnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.registerpnl.Controls.Add(Me.LinkLabel2)
        Me.registerpnl.Controls.Add(Me.Label1)
        Me.registerpnl.Controls.Add(Me.Guna2GradientButton1)
        Me.registerpnl.Controls.Add(Me.LinkLabel1)
        Me.registerpnl.Controls.Add(Me.picture)
        Me.registerpnl.Controls.Add(Me.datetime)
        Me.registerpnl.Controls.Add(Me.password)
        Me.registerpnl.Controls.Add(Me.phonenumber)
        Me.registerpnl.Controls.Add(Me.email)
        Me.registerpnl.Controls.Add(Me.address)
        Me.registerpnl.Controls.Add(Me.username)
        Me.registerpnl.Controls.Add(Me.fullname)
        Me.registerpnl.Controls.Add(Me.Guna2HtmlLabel1)
        Me.registerpnl.FillColor = System.Drawing.Color.Transparent
        Me.registerpnl.Location = New System.Drawing.Point(72, 50)
        Me.registerpnl.Name = "registerpnl"
        Me.registerpnl.ShadowColor = System.Drawing.Color.DimGray
        Me.registerpnl.ShadowDepth = 130
        Me.registerpnl.Size = New System.Drawing.Size(756, 525)
        Me.registerpnl.TabIndex = 0
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.SaddleBrown
        Me.LinkLabel2.Location = New System.Drawing.Point(426, 478)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(57, 24)
        Me.LinkLabel2.TabIndex = 13
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Login"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(188, 482)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Already Have Account Click"
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.CheckedState.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.CustomImages.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.Silver
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.HoverState.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(157, 413)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.ShadowDecoration.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(404, 57)
        Me.Guna2GradientButton1.TabIndex = 10
        Me.Guna2GradientButton1.Text = "Register"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(426, 156)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(63, 20)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Brower"
        '
        'picture
        '
        Me.picture.FillColor = System.Drawing.Color.Transparent
        Me.picture.Location = New System.Drawing.Point(559, 74)
        Me.picture.Name = "picture"
        Me.picture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.picture.ShadowDecoration.Parent = Me.picture
        Me.picture.Size = New System.Drawing.Size(140, 102)
        Me.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picture.TabIndex = 8
        Me.picture.TabStop = False
        '
        'datetime
        '
        Me.datetime.BorderRadius = 7
        Me.datetime.CheckedState.Parent = Me.datetime
        Me.datetime.FillColor = System.Drawing.Color.White
        Me.datetime.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.datetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetime.HoverState.Parent = Me.datetime
        Me.datetime.Location = New System.Drawing.Point(430, 345)
        Me.datetime.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.datetime.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.datetime.Name = "datetime"
        Me.datetime.ShadowDecoration.Parent = Me.datetime
        Me.datetime.Size = New System.Drawing.Size(247, 41)
        Me.datetime.TabIndex = 7
        Me.datetime.Value = New Date(2021, 4, 12, 17, 35, 6, 905)
        '
        'password
        '
        Me.password.BorderColor = System.Drawing.Color.Transparent
        Me.password.BorderRadius = 7
        Me.password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password.DefaultText = ""
        Me.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password.DisabledState.Parent = Me.password
        Me.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password.FocusedState.Parent = Me.password
        Me.password.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.password.ForeColor = System.Drawing.Color.Black
        Me.password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password.HoverState.Parent = Me.password
        Me.password.Location = New System.Drawing.Point(78, 336)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.password.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.password.PlaceholderText = "Password"
        Me.password.SelectedText = ""
        Me.password.ShadowDecoration.Parent = Me.password
        Me.password.Size = New System.Drawing.Size(251, 50)
        Me.password.TabIndex = 6
        Me.password.UseSystemPasswordChar = True
        '
        'phonenumber
        '
        Me.phonenumber.BorderColor = System.Drawing.Color.Transparent
        Me.phonenumber.BorderRadius = 7
        Me.phonenumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.phonenumber.DefaultText = ""
        Me.phonenumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.phonenumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.phonenumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.phonenumber.DisabledState.Parent = Me.phonenumber
        Me.phonenumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.phonenumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.phonenumber.FocusedState.Parent = Me.phonenumber
        Me.phonenumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.phonenumber.ForeColor = System.Drawing.Color.Black
        Me.phonenumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.phonenumber.HoverState.Parent = Me.phonenumber
        Me.phonenumber.Location = New System.Drawing.Point(429, 266)
        Me.phonenumber.Name = "phonenumber"
        Me.phonenumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.phonenumber.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.phonenumber.PlaceholderText = "Phone Number"
        Me.phonenumber.SelectedText = ""
        Me.phonenumber.ShadowDecoration.Parent = Me.phonenumber
        Me.phonenumber.Size = New System.Drawing.Size(248, 50)
        Me.phonenumber.TabIndex = 5
        '
        'email
        '
        Me.email.BorderColor = System.Drawing.Color.Transparent
        Me.email.BorderRadius = 7
        Me.email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email.DefaultText = ""
        Me.email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.email.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email.DisabledState.Parent = Me.email
        Me.email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email.FocusedState.Parent = Me.email
        Me.email.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.email.ForeColor = System.Drawing.Color.Black
        Me.email.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email.HoverState.Parent = Me.email
        Me.email.Location = New System.Drawing.Point(430, 195)
        Me.email.Name = "email"
        Me.email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.email.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.email.PlaceholderText = "Email"
        Me.email.SelectedText = ""
        Me.email.ShadowDecoration.Parent = Me.email
        Me.email.Size = New System.Drawing.Size(247, 50)
        Me.email.TabIndex = 4
        '
        'address
        '
        Me.address.BorderColor = System.Drawing.Color.Transparent
        Me.address.BorderRadius = 7
        Me.address.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.address.DefaultText = ""
        Me.address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.address.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.address.DisabledState.Parent = Me.address
        Me.address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.address.FocusedState.Parent = Me.address
        Me.address.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.address.ForeColor = System.Drawing.Color.Black
        Me.address.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.address.HoverState.Parent = Me.address
        Me.address.Location = New System.Drawing.Point(78, 266)
        Me.address.Name = "address"
        Me.address.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.address.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.address.PlaceholderText = "Address"
        Me.address.SelectedText = ""
        Me.address.ShadowDecoration.Parent = Me.address
        Me.address.Size = New System.Drawing.Size(251, 50)
        Me.address.TabIndex = 3
        '
        'username
        '
        Me.username.BorderColor = System.Drawing.Color.Transparent
        Me.username.BorderRadius = 7
        Me.username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.username.DefaultText = ""
        Me.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.username.DisabledState.Parent = Me.username
        Me.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.username.FocusedState.Parent = Me.username
        Me.username.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.username.ForeColor = System.Drawing.Color.Black
        Me.username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.username.HoverState.Parent = Me.username
        Me.username.Location = New System.Drawing.Point(78, 195)
        Me.username.Name = "username"
        Me.username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.username.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.username.PlaceholderText = "Username"
        Me.username.SelectedText = ""
        Me.username.ShadowDecoration.Parent = Me.username
        Me.username.Size = New System.Drawing.Size(251, 50)
        Me.username.TabIndex = 2
        '
        'fullname
        '
        Me.fullname.BorderColor = System.Drawing.Color.Transparent
        Me.fullname.BorderRadius = 7
        Me.fullname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fullname.DefaultText = ""
        Me.fullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.fullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.fullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fullname.DisabledState.Parent = Me.fullname
        Me.fullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fullname.FocusedState.Parent = Me.fullname
        Me.fullname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fullname.ForeColor = System.Drawing.Color.Black
        Me.fullname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fullname.HoverState.Parent = Me.fullname
        Me.fullname.Location = New System.Drawing.Point(78, 126)
        Me.fullname.Name = "fullname"
        Me.fullname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fullname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fullname.PlaceholderText = "Full Name"
        Me.fullname.SelectedText = ""
        Me.fullname.ShadowDecoration.Parent = Me.fullname
        Me.fullname.Size = New System.Drawing.Size(251, 50)
        Me.fullname.TabIndex = 1
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft YaHei", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(309, 42)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(164, 46)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "REGISTER    "
        '
        'registercloase
        '
        Me.registercloase.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.registercloase.BackColor = System.Drawing.Color.Transparent
        Me.registercloase.FillColor = System.Drawing.Color.Transparent
        Me.registercloase.HoverState.FillColor = System.Drawing.Color.White
        Me.registercloase.HoverState.Parent = Me.registercloase
        Me.registercloase.IconColor = System.Drawing.Color.Black
        Me.registercloase.Location = New System.Drawing.Point(872, 0)
        Me.registercloase.Name = "registercloase"
        Me.registercloase.ShadowDecoration.Parent = Me.registercloase
        Me.registercloase.Size = New System.Drawing.Size(38, 32)
        Me.registercloase.TabIndex = 2
        '
        'maximize
        '
        Me.maximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maximize.BackColor = System.Drawing.Color.Transparent
        Me.maximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.maximize.FillColor = System.Drawing.Color.Transparent
        Me.maximize.HoverState.FillColor = System.Drawing.Color.White
        Me.maximize.HoverState.Parent = Me.maximize
        Me.maximize.IconColor = System.Drawing.Color.Black
        Me.maximize.Location = New System.Drawing.Point(837, 0)
        Me.maximize.Name = "maximize"
        Me.maximize.ShadowDecoration.Parent = Me.maximize
        Me.maximize.Size = New System.Drawing.Size(38, 32)
        Me.maximize.TabIndex = 3
        '
        'minimize
        '
        Me.minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimize.BackColor = System.Drawing.Color.Transparent
        Me.minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.minimize.FillColor = System.Drawing.Color.Transparent
        Me.minimize.HoverState.FillColor = System.Drawing.Color.White
        Me.minimize.HoverState.Parent = Me.minimize
        Me.minimize.IconColor = System.Drawing.Color.Black
        Me.minimize.Location = New System.Drawing.Point(804, 0)
        Me.minimize.Name = "minimize"
        Me.minimize.ShadowDecoration.Parent = Me.minimize
        Me.minimize.Size = New System.Drawing.Size(38, 32)
        Me.minimize.TabIndex = 4
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_VER_POSITIVE
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.first.My.Resources.Resources.landing_page
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(911, 587)
        Me.Controls.Add(Me.minimize)
        Me.Controls.Add(Me.maximize)
        Me.Controls.Add(Me.registercloase)
        Me.Controls.Add(Me.registerpnl)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.registerpnl.ResumeLayout(False)
        Me.registerpnl.PerformLayout()
        CType(Me.picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents registerpnl As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents fullname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents datetime As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents phonenumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents email As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents address As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents picture As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents registercloase As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents maximize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents minimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
End Class
