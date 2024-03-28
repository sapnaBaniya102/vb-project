<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setting
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcurrent = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtnew = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(230, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Setting"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(50, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Change Password"
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.BackgroundImage = Global.first.My.Resources.Resources.laptop_with_gears_emerging_from_display_development_fix_process_update_by_serhii_mudruk_gettyimages_1201799929_2400x1600_100854507_large
        Me.Guna2ShadowPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtre)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtnew)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtcurrent)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label5)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label4)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label3)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(118, 138)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.DarkGray
        Me.Guna2ShadowPanel1.ShadowDepth = 70
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(526, 393)
        Me.Guna2ShadowPanel1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 29)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Current Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 29)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "New Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(221, 29)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Re-Write Password"
        '
        'txtcurrent
        '
        Me.txtcurrent.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcurrent.DefaultText = ""
        Me.txtcurrent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcurrent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcurrent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcurrent.DisabledState.Parent = Me.txtcurrent
        Me.txtcurrent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcurrent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcurrent.FocusedState.Parent = Me.txtcurrent
        Me.txtcurrent.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtcurrent.ForeColor = System.Drawing.Color.Black
        Me.txtcurrent.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcurrent.HoverState.Parent = Me.txtcurrent
        Me.txtcurrent.Location = New System.Drawing.Point(53, 80)
        Me.txtcurrent.Name = "txtcurrent"
        Me.txtcurrent.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcurrent.PlaceholderText = ""
        Me.txtcurrent.SelectedText = ""
        Me.txtcurrent.ShadowDecoration.Parent = Me.txtcurrent
        Me.txtcurrent.Size = New System.Drawing.Size(398, 37)
        Me.txtcurrent.TabIndex = 3
        Me.txtcurrent.UseSystemPasswordChar = True
        '
        'txtnew
        '
        Me.txtnew.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnew.DefaultText = ""
        Me.txtnew.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtnew.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtnew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnew.DisabledState.Parent = Me.txtnew
        Me.txtnew.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnew.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnew.FocusedState.Parent = Me.txtnew
        Me.txtnew.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtnew.ForeColor = System.Drawing.Color.Black
        Me.txtnew.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnew.HoverState.Parent = Me.txtnew
        Me.txtnew.Location = New System.Drawing.Point(53, 189)
        Me.txtnew.Name = "txtnew"
        Me.txtnew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnew.PlaceholderText = ""
        Me.txtnew.SelectedText = ""
        Me.txtnew.ShadowDecoration.Parent = Me.txtnew
        Me.txtnew.Size = New System.Drawing.Size(398, 37)
        Me.txtnew.TabIndex = 4
        Me.txtnew.UseSystemPasswordChar = True
        '
        'txtre
        '
        Me.txtre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtre.DefaultText = ""
        Me.txtre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtre.DisabledState.Parent = Me.txtre
        Me.txtre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtre.FocusedState.Parent = Me.txtre
        Me.txtre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtre.ForeColor = System.Drawing.Color.Black
        Me.txtre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtre.HoverState.Parent = Me.txtre
        Me.txtre.Location = New System.Drawing.Point(53, 280)
        Me.txtre.Name = "txtre"
        Me.txtre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtre.PlaceholderText = ""
        Me.txtre.SelectedText = ""
        Me.txtre.ShadowDecoration.Parent = Me.txtre
        Me.txtre.Size = New System.Drawing.Size(398, 37)
        Me.txtre.TabIndex = 5
        Me.txtre.UseSystemPasswordChar = True
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(352, 323)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(147, 45)
        Me.Guna2Button1.TabIndex = 6
        Me.Guna2Button1.Text = "Change"
        '
        'setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.first.My.Resources.Resources.laptop_with_gears_emerging_from_display_development_fix_process_update_by_serhii_mudruk_gettyimages_1201799929_2400x1600_100854507_large
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(831, 584)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "setting"
        Me.Text = "setting"
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtnew As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtcurrent As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
