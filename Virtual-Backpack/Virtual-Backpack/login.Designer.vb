<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.loginBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.registertb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.register = New System.Windows.Forms.Label()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.closeBtn = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2PictureBox5 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox4 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.userTb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.passwordTb = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'loginBtn
        '
        Me.loginBtn.Animated = True
        Me.loginBtn.AutoRoundedCorners = True
        Me.loginBtn.BorderRadius = 20
        Me.loginBtn.CheckedState.Parent = Me.loginBtn
        Me.loginBtn.CustomImages.Parent = Me.loginBtn
        Me.loginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.loginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.loginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.loginBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.loginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.loginBtn.DisabledState.Parent = Me.loginBtn
        Me.loginBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.loginBtn.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.loginBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ForeColor = System.Drawing.Color.White
        Me.loginBtn.HoverState.Parent = Me.loginBtn
        Me.loginBtn.Location = New System.Drawing.Point(441, 254)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.ShadowDecoration.Parent = Me.loginBtn
        Me.loginBtn.Size = New System.Drawing.Size(270, 43)
        Me.loginBtn.TabIndex = 4
        Me.loginBtn.Text = "Login"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BorderThickness = 0
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = "User Login"
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.HoverState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Location = New System.Drawing.Point(521, 82)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.ShadowDecoration.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Size = New System.Drawing.Size(147, 43)
        Me.Guna2TextBox1.TabIndex = 5
        '
        'registertb
        '
        Me.registertb.Animated = True
        Me.registertb.BorderThickness = 0
        Me.registertb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.registertb.DefaultText = "Don't have an account?"
        Me.registertb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.registertb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.registertb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.registertb.DisabledState.Parent = Me.registertb
        Me.registertb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.registertb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.registertb.FocusedState.Parent = Me.registertb
        Me.registertb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registertb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.registertb.HoverState.Parent = Me.registertb
        Me.registertb.Location = New System.Drawing.Point(458, 315)
        Me.registertb.Name = "registertb"
        Me.registertb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.registertb.PlaceholderText = ""
        Me.registertb.SelectedText = ""
        Me.registertb.ShadowDecoration.Parent = Me.registertb
        Me.registertb.Size = New System.Drawing.Size(178, 32)
        Me.registertb.TabIndex = 6
        '
        'register
        '
        Me.register.AutoSize = True
        Me.register.BackColor = System.Drawing.Color.Transparent
        Me.register.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.register.ForeColor = System.Drawing.SystemColors.Highlight
        Me.register.Location = New System.Drawing.Point(606, 323)
        Me.register.Name = "register"
        Me.register.Size = New System.Drawing.Size(75, 15)
        Me.register.TabIndex = 13
        Me.register.Text = "Register here"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 6
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockForm = False
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.DragStartTransparencyValue = 1.0R
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2CirclePictureBox2
        '
        Me.Guna2CirclePictureBox2.Image = Global.Virtual_Backpack.My.Resources.Resources.close
        Me.Guna2CirclePictureBox2.ImageRotate = 0!
        Me.Guna2CirclePictureBox2.Location = New System.Drawing.Point(722, 12)
        Me.Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2"
        Me.Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox2.ShadowDecoration.Parent = Me.Guna2CirclePictureBox2
        Me.Guna2CirclePictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.Guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox2.TabIndex = 24
        Me.Guna2CirclePictureBox2.TabStop = False
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.Color.Transparent
        Me.closeBtn.BackgroundImage = Global.Virtual_Backpack.My.Resources.Resources.cancel
        Me.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closeBtn.CheckedState.Parent = Me.closeBtn
        Me.closeBtn.CustomImages.Parent = Me.closeBtn
        Me.closeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.closeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.closeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.closeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.closeBtn.DisabledState.Parent = Me.closeBtn
        Me.closeBtn.FillColor = System.Drawing.Color.Transparent
        Me.closeBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.closeBtn.ForeColor = System.Drawing.Color.White
        Me.closeBtn.HoverState.Parent = Me.closeBtn
        Me.closeBtn.Location = New System.Drawing.Point(758, 12)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.closeBtn.ShadowDecoration.Parent = Me.closeBtn
        Me.closeBtn.Size = New System.Drawing.Size(30, 30)
        Me.closeBtn.TabIndex = 23
        Me.closeBtn.TabStop = False
        Me.closeBtn.UseTransparentBackground = True
        '
        'Guna2PictureBox5
        '
        Me.Guna2PictureBox5.Image = Global.Virtual_Backpack.My.Resources.Resources.line1
        Me.Guna2PictureBox5.ImageRotate = 0!
        Me.Guna2PictureBox5.Location = New System.Drawing.Point(357, 347)
        Me.Guna2PictureBox5.Name = "Guna2PictureBox5"
        Me.Guna2PictureBox5.ShadowDecoration.Parent = Me.Guna2PictureBox5
        Me.Guna2PictureBox5.Size = New System.Drawing.Size(39, 34)
        Me.Guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox5.TabIndex = 11
        Me.Guna2PictureBox5.TabStop = False
        '
        'Guna2PictureBox4
        '
        Me.Guna2PictureBox4.Image = Global.Virtual_Backpack.My.Resources.Resources.circle1
        Me.Guna2PictureBox4.ImageRotate = 0!
        Me.Guna2PictureBox4.Location = New System.Drawing.Point(297, 291)
        Me.Guna2PictureBox4.Name = "Guna2PictureBox4"
        Me.Guna2PictureBox4.ShadowDecoration.Parent = Me.Guna2PictureBox4
        Me.Guna2PictureBox4.Size = New System.Drawing.Size(48, 52)
        Me.Guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox4.TabIndex = 10
        Me.Guna2PictureBox4.TabStop = False
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.Image = Global.Virtual_Backpack.My.Resources.Resources.line1
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(225, 82)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.ShadowDecoration.Parent = Me.Guna2PictureBox3
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(48, 41)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox3.TabIndex = 9
        Me.Guna2PictureBox3.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.Virtual_Backpack.My.Resources.Resources.background1
        Me.Guna2PictureBox1.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Vertical
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-1, 12)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(366, 452)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 3
        Me.Guna2PictureBox1.TabStop = False
        '
        'userTb
        '
        Me.userTb.Animated = True
        Me.userTb.BackColor = System.Drawing.SystemColors.Window
        Me.userTb.BorderRadius = 8
        Me.userTb.BorderThickness = 0
        Me.userTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.userTb.DefaultText = ""
        Me.userTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.userTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.userTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.userTb.DisabledState.Parent = Me.userTb
        Me.userTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.userTb.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.userTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.userTb.FocusedState.Parent = Me.userTb
        Me.userTb.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.userTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.userTb.HoverState.Parent = Me.userTb
        Me.userTb.IconLeft = Global.Virtual_Backpack.My.Resources.Resources.user1
        Me.userTb.Location = New System.Drawing.Point(441, 133)
        Me.userTb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.userTb.Name = "userTb"
        Me.userTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.userTb.PlaceholderForeColor = System.Drawing.SystemColors.GrayText
        Me.userTb.PlaceholderText = "Username"
        Me.userTb.SelectedText = ""
        Me.userTb.ShadowDecoration.Parent = Me.userTb
        Me.userTb.Size = New System.Drawing.Size(270, 43)
        Me.userTb.TabIndex = 1
        '
        'passwordTb
        '
        Me.passwordTb.Animated = True
        Me.passwordTb.BackColor = System.Drawing.SystemColors.Window
        Me.passwordTb.BorderRadius = 8
        Me.passwordTb.BorderThickness = 0
        Me.passwordTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passwordTb.DefaultText = ""
        Me.passwordTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.passwordTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.passwordTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordTb.DisabledState.Parent = Me.passwordTb
        Me.passwordTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordTb.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.passwordTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwordTb.FocusedState.Parent = Me.passwordTb
        Me.passwordTb.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.passwordTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwordTb.HoverState.Parent = Me.passwordTb
        Me.passwordTb.IconLeft = CType(resources.GetObject("passwordTb.IconLeft"), System.Drawing.Image)
        Me.passwordTb.Location = New System.Drawing.Point(441, 189)
        Me.passwordTb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.passwordTb.Name = "passwordTb"
        Me.passwordTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.passwordTb.PlaceholderForeColor = System.Drawing.SystemColors.GrayText
        Me.passwordTb.PlaceholderText = "Password"
        Me.passwordTb.SelectedText = ""
        Me.passwordTb.ShadowDecoration.Parent = Me.passwordTb
        Me.passwordTb.Size = New System.Drawing.Size(270, 43)
        Me.passwordTb.TabIndex = 2
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Guna2CirclePictureBox2)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.register)
        Me.Controls.Add(Me.Guna2PictureBox5)
        Me.Controls.Add(Me.Guna2PictureBox4)
        Me.Controls.Add(Me.Guna2PictureBox3)
        Me.Controls.Add(Me.registertb)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.userTb)
        Me.Controls.Add(Me.passwordTb)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents passwordTb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents userTb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents loginBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents registertb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox4 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox5 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents register As Label
    Friend WithEvents closeBtn As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
End Class
