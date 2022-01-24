<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class planner_manager
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.plannerdate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.taskTb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.plannertime = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.saveBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.deleteBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2BorderlessForm2 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.minBtn = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.closeBtn = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'plannerdate
        '
        Me.plannerdate.AutoRoundedCorners = True
        Me.plannerdate.BackColor = System.Drawing.Color.Transparent
        Me.plannerdate.BorderRadius = 9
        Me.plannerdate.Checked = True
        Me.plannerdate.CheckedState.Parent = Me.plannerdate
        Me.plannerdate.FillColor = System.Drawing.Color.White
        Me.plannerdate.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.plannerdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.plannerdate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.plannerdate.HoverState.Parent = Me.plannerdate
        Me.plannerdate.Location = New System.Drawing.Point(96, 78)
        Me.plannerdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.plannerdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.plannerdate.Name = "plannerdate"
        Me.plannerdate.ShadowDecoration.Parent = Me.plannerdate
        Me.plannerdate.Size = New System.Drawing.Size(220, 20)
        Me.plannerdate.TabIndex = 29
        Me.plannerdate.Value = New Date(2022, 1, 5, 17, 21, 57, 224)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(49, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(49, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Task:"
        '
        'taskTb
        '
        Me.taskTb.Animated = True
        Me.taskTb.BackColor = System.Drawing.SystemColors.Window
        Me.taskTb.BorderRadius = 8
        Me.taskTb.BorderThickness = 0
        Me.taskTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.taskTb.DefaultText = ""
        Me.taskTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.taskTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.taskTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.taskTb.DisabledState.Parent = Me.taskTb
        Me.taskTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.taskTb.FillColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.taskTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.taskTb.FocusedState.Parent = Me.taskTb
        Me.taskTb.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.taskTb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.taskTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.taskTb.HoverState.Parent = Me.taskTb
        Me.taskTb.Location = New System.Drawing.Point(96, 104)
        Me.taskTb.Name = "taskTb"
        Me.taskTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.taskTb.PlaceholderForeColor = System.Drawing.SystemColors.GrayText
        Me.taskTb.PlaceholderText = ""
        Me.taskTb.SelectedText = ""
        Me.taskTb.ShadowDecoration.Parent = Me.taskTb
        Me.taskTb.Size = New System.Drawing.Size(220, 61)
        Me.taskTb.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(49, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "New Task:"
        '
        'plannertime
        '
        Me.plannertime.AutoRoundedCorners = True
        Me.plannertime.BorderRadius = 9
        Me.plannertime.Checked = True
        Me.plannertime.CheckedState.Parent = Me.plannertime
        Me.plannertime.FillColor = System.Drawing.Color.White
        Me.plannertime.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.plannertime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.plannertime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.plannertime.HoverState.Parent = Me.plannertime
        Me.plannertime.Location = New System.Drawing.Point(96, 171)
        Me.plannertime.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.plannertime.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.plannertime.Name = "plannertime"
        Me.plannertime.ShadowDecoration.Parent = Me.plannertime
        Me.plannertime.Size = New System.Drawing.Size(220, 20)
        Me.plannertime.TabIndex = 35
        Me.plannertime.Value = New Date(2022, 1, 5, 17, 21, 57, 224)
        '
        'saveBtn
        '
        Me.saveBtn.Animated = True
        Me.saveBtn.AutoRoundedCorners = True
        Me.saveBtn.BorderRadius = 10
        Me.saveBtn.CheckedState.Parent = Me.saveBtn
        Me.saveBtn.CustomImages.Parent = Me.saveBtn
        Me.saveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.saveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.saveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.saveBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.saveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.saveBtn.DisabledState.Parent = Me.saveBtn
        Me.saveBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.saveBtn.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.saveBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.saveBtn.ForeColor = System.Drawing.Color.White
        Me.saveBtn.HoverState.Parent = Me.saveBtn
        Me.saveBtn.Location = New System.Drawing.Point(247, 210)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.ShadowDecoration.Parent = Me.saveBtn
        Me.saveBtn.Size = New System.Drawing.Size(73, 23)
        Me.saveBtn.TabIndex = 36
        Me.saveBtn.Text = "Save"
        '
        'deleteBtn
        '
        Me.deleteBtn.Animated = True
        Me.deleteBtn.AutoRoundedCorners = True
        Me.deleteBtn.BorderRadius = 10
        Me.deleteBtn.CheckedState.Parent = Me.deleteBtn
        Me.deleteBtn.CustomImages.Parent = Me.deleteBtn
        Me.deleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.deleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.deleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.deleteBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.deleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.deleteBtn.DisabledState.Parent = Me.deleteBtn
        Me.deleteBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.deleteBtn.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.deleteBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.deleteBtn.ForeColor = System.Drawing.Color.White
        Me.deleteBtn.HoverState.Parent = Me.deleteBtn
        Me.deleteBtn.Location = New System.Drawing.Point(168, 210)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.ShadowDecoration.Parent = Me.deleteBtn
        Me.deleteBtn.Size = New System.Drawing.Size(73, 23)
        Me.deleteBtn.TabIndex = 37
        Me.deleteBtn.Text = "Delete"
        '
        'Guna2BorderlessForm2
        '
        Me.Guna2BorderlessForm2.BorderRadius = 6
        Me.Guna2BorderlessForm2.ContainerControl = Me
        Me.Guna2BorderlessForm2.DockForm = False
        Me.Guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm2.DragStartTransparencyValue = 1.0R
        Me.Guna2BorderlessForm2.ResizeForm = False
        '
        'minBtn
        '
        Me.minBtn.BackColor = System.Drawing.Color.Transparent
        Me.minBtn.BackgroundImage = Global.Virtual_Backpack.My.Resources.Resources.close
        Me.minBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.minBtn.CheckedState.Parent = Me.minBtn
        Me.minBtn.CustomImages.Parent = Me.minBtn
        Me.minBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.minBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.minBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.minBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.minBtn.DisabledState.Parent = Me.minBtn
        Me.minBtn.FillColor = System.Drawing.Color.Transparent
        Me.minBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.minBtn.ForeColor = System.Drawing.Color.White
        Me.minBtn.HoverState.Parent = Me.minBtn
        Me.minBtn.Location = New System.Drawing.Point(300, 12)
        Me.minBtn.Name = "minBtn"
        Me.minBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.minBtn.ShadowDecoration.Parent = Me.minBtn
        Me.minBtn.Size = New System.Drawing.Size(20, 20)
        Me.minBtn.TabIndex = 27
        Me.minBtn.TabStop = False
        Me.minBtn.UseTransparentBackground = True
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
        Me.closeBtn.Location = New System.Drawing.Point(323, 12)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.closeBtn.ShadowDecoration.Parent = Me.closeBtn
        Me.closeBtn.Size = New System.Drawing.Size(20, 20)
        Me.closeBtn.TabIndex = 26
        Me.closeBtn.TabStop = False
        Me.closeBtn.UseTransparentBackground = True
        '
        'planner_manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(355, 260)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.plannertime)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.taskTb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.plannerdate)
        Me.Controls.Add(Me.minBtn)
        Me.Controls.Add(Me.closeBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "planner_manager"
        Me.Text = "planner_manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents minBtn As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents closeBtn As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents plannerdate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents taskTb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents plannertime As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents saveBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents deleteBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2BorderlessForm2 As Guna.UI2.WinForms.Guna2BorderlessForm
End Class
