<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        PictureBox1 = New PictureBox()
        lblLtitle = New Label()
        lblLusername = New Label()
        Label1 = New Label()
        lblRemind = New Label()
        btnSubmit = New library_system.ModernButton()
        txtPassword = New library_system.RoundTextBox()
        txtUsername = New library_system.RoundTextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(242), CByte(244), CByte(247))
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-5, 0)
        PictureBox1.Margin = New Padding(5, 6, 5, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1395, 790)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        PictureBox1.Tag = ""
        ' 
        ' lblLtitle
        ' 
        lblLtitle.AutoSize = True
        lblLtitle.BackColor = Color.FromArgb(CByte(242), CByte(244), CByte(247))
        lblLtitle.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblLtitle.Location = New Point(190, 117)
        lblLtitle.Margin = New Padding(5, 0, 5, 0)
        lblLtitle.Name = "lblLtitle"
        lblLtitle.Size = New Size(109, 48)
        lblLtitle.TabIndex = 1
        lblLtitle.Text = "Login"
        ' 
        ' lblLusername
        ' 
        lblLusername.AutoSize = True
        lblLusername.BackColor = Color.FromArgb(CByte(242), CByte(244), CByte(247))
        lblLusername.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblLusername.ForeColor = Color.IndianRed
        lblLusername.Location = New Point(80, 206)
        lblLusername.Margin = New Padding(5, 0, 5, 0)
        lblLusername.Name = "lblLusername"
        lblLusername.Size = New Size(210, 23)
        lblLusername.TabIndex = 3
        lblLusername.Text = "Enter Your Username"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(242), CByte(244), CByte(247))
        Label1.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.IndianRed
        Label1.Location = New Point(80, 342)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(202, 23)
        Label1.TabIndex = 4
        Label1.Text = "Enter Your Password"
        ' 
        ' lblRemind
        ' 
        lblRemind.AutoSize = True
        lblRemind.BackColor = Color.FromArgb(CByte(242), CByte(244), CByte(247))
        lblRemind.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblRemind.ForeColor = Color.IndianRed
        lblRemind.Location = New Point(87, 450)
        lblRemind.Margin = New Padding(5, 0, 5, 0)
        lblRemind.Name = "lblRemind"
        lblRemind.Size = New Size(0, 23)
        lblRemind.TabIndex = 11
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(255), CByte(107), CByte(53))
        btnSubmit.BackgroundColor = Color.FromArgb(CByte(255), CByte(107), CByte(53))
        btnSubmit.BorderColor = Color.Gray
        btnSubmit.BorderRadius = 20
        btnSubmit.BorderSize = 0
        btnSubmit.FlatAppearance.BorderSize = 0
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSubmit.ForeColor = Color.White
        btnSubmit.HoverColor = Color.Tomato
        btnSubmit.Location = New Point(85, 450)
        btnSubmit.Margin = New Padding(5, 6, 5, 6)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(367, 58)
        btnSubmit.TabIndex = 10
        btnSubmit.Text = "Login"
        btnSubmit.TextColor = Color.White
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.White
        txtPassword.BorderColor = Color.MediumSlateBlue
        txtPassword.BorderRadius = 13
        txtPassword.BorderSize = 2
        txtPassword.ForeColor = Color.FromArgb(CByte(51), CByte(51), CByte(51))
        txtPassword.Location = New Point(85, 379)
        txtPassword.Margin = New Padding(5, 6, 5, 6)
        txtPassword.Name = "txtPassword"
        txtPassword.Padding = New Padding(8, 10, 8, 10)
        txtPassword.PlaceholderText = "Password"
        txtPassword.Size = New Size(367, 60)
        txtPassword.TabIndex = 9
        txtPassword.TextAlign = HorizontalAlignment.Left
        txtPassword.TextValue = ""
        txtPassword.UseSystemPasswordChar = False
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.White
        txtUsername.BorderColor = Color.MediumSlateBlue
        txtUsername.BorderRadius = 13
        txtUsername.BorderSize = 2
        txtUsername.ForeColor = Color.FromArgb(CByte(51), CByte(51), CByte(51))
        txtUsername.Location = New Point(85, 242)
        txtUsername.Margin = New Padding(5, 6, 5, 6)
        txtUsername.Name = "txtUsername"
        txtUsername.Padding = New Padding(8, 10, 8, 10)
        txtUsername.PlaceholderText = "Enter Your Username"
        txtUsername.Size = New Size(367, 56)
        txtUsername.TabIndex = 8
        txtUsername.TextAlign = HorizontalAlignment.Left
        txtUsername.TextValue = ""
        txtUsername.UseSystemPasswordChar = False
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1390, 790)
        Controls.Add(lblRemind)
        Controls.Add(btnSubmit)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label1)
        Controls.Add(lblLusername)
        Controls.Add(lblLtitle)
        Controls.Add(PictureBox1)
        Margin = New Padding(5, 6, 5, 6)
        MaximizeBox = False
        MinimizeBox = False
        Name = "login"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLtitle As System.Windows.Forms.Label
    Friend WithEvents lblLusername As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents btnSubmit As library_system.ModernButton
    Private WithEvents txtPassword As library_system.RoundTextBox
    Private WithEvents txtUsername As library_system.RoundTextBox
    Friend WithEvents lblRemind As System.Windows.Forms.Label

End Class
