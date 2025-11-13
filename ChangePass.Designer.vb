<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePass))
        Me.txtCurrentPassword = New library_system.RoundTextBox
        Me.txtNewPassword = New library_system.RoundTextBox
        Me.txtConfirmPassword = New library_system.RoundTextBox
        Me.btnSave = New library_system.ModernButton
        Me.lblLtitle = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.BackColor = System.Drawing.Color.White
        Me.txtCurrentPassword.BorderRadius = 13
        Me.txtCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtCurrentPassword.Location = New System.Drawing.Point(35, 79)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.Padding = New System.Windows.Forms.Padding(5)
        Me.txtCurrentPassword.PlaceholderText = "Enter Your Username"
        Me.txtCurrentPassword.Size = New System.Drawing.Size(220, 29)
        Me.txtCurrentPassword.TabIndex = 9
        Me.txtCurrentPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtCurrentPassword.TextValue = ""
        Me.txtCurrentPassword.UseSystemPasswordChar = False
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BackColor = System.Drawing.Color.White
        Me.txtNewPassword.BorderRadius = 13
        Me.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtNewPassword.Location = New System.Drawing.Point(35, 146)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Padding = New System.Windows.Forms.Padding(5)
        Me.txtNewPassword.PlaceholderText = "Enter Your Username"
        Me.txtNewPassword.Size = New System.Drawing.Size(220, 29)
        Me.txtNewPassword.TabIndex = 10
        Me.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtNewPassword.TextValue = ""
        Me.txtNewPassword.UseSystemPasswordChar = False
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BackColor = System.Drawing.Color.White
        Me.txtConfirmPassword.BorderRadius = 13
        Me.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(35, 209)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Padding = New System.Windows.Forms.Padding(5)
        Me.txtConfirmPassword.PlaceholderText = "Enter Your Username"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(220, 29)
        Me.txtConfirmPassword.TabIndex = 11
        Me.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtConfirmPassword.TextValue = ""
        Me.txtConfirmPassword.UseSystemPasswordChar = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnSave.BorderColor = System.Drawing.Color.Gray
        Me.btnSave.BorderRadius = 20
        Me.btnSave.BorderSize = 0
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.HoverColor = System.Drawing.Color.Tomato
        Me.btnSave.Location = New System.Drawing.Point(35, 257)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(220, 30)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save Password"
        Me.btnSave.TextColor = System.Drawing.Color.White
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblLtitle
        '
        Me.lblLtitle.AutoSize = True
        Me.lblLtitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.lblLtitle.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLtitle.Location = New System.Drawing.Point(117, 18)
        Me.lblLtitle.Name = "lblLtitle"
        Me.lblLtitle.Size = New System.Drawing.Size(207, 32)
        Me.lblLtitle.TabIndex = 13
        Me.lblLtitle.Text = "Change Password"
        '
        'ChangePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(834, 411)
        Me.Controls.Add(Me.lblLtitle)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.txtCurrentPassword)
        Me.DoubleBuffered = True
        Me.Name = "ChangePass"
        Me.Text = "ChangePass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCurrentPassword As library_system.RoundTextBox
    Friend WithEvents txtNewPassword As library_system.RoundTextBox
    Friend WithEvents txtConfirmPassword As library_system.RoundTextBox
    Friend WithEvents btnSave As library_system.ModernButton
    Friend WithEvents lblLtitle As System.Windows.Forms.Label
End Class
