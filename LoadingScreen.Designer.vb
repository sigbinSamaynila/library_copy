<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingScreen
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoadingScreen))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label2 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblPercent = New System.Windows.Forms.Label
        Me.FadeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.RoundPictureBox1 = New library_system.RoundPictureBox
        CType(Me.RoundPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 306)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(681, 17)
        Me.ProgressBar1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(286, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 40)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Welcome!"
        '
        'Timer1
        '
        Me.Timer1.Interval = 300
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.BackColor = System.Drawing.Color.Transparent
        Me.lblPercent.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPercent.Location = New System.Drawing.Point(12, 282)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(34, 21)
        Me.lblPercent.TabIndex = 4
        Me.lblPercent.Text = "......"
        '
        'FadeTimer
        '
        Me.FadeTimer.Interval = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(277, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 40)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Please wait!"
        '
        'RoundPictureBox1
        '
        Me.RoundPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.RoundPictureBox1.Image = CType(resources.GetObject("RoundPictureBox1.Image"), System.Drawing.Image)
        Me.RoundPictureBox1.Location = New System.Drawing.Point(222, 76)
        Me.RoundPictureBox1.Name = "RoundPictureBox1"
        Me.RoundPictureBox1.Size = New System.Drawing.Size(283, 132)
        Me.RoundPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RoundPictureBox1.TabIndex = 6
        Me.RoundPictureBox1.TabStop = False
        '
        'LoadingScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(705, 335)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RoundPictureBox1)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoadingScreen"
        Me.Text = "LoadingScreen"
        CType(Me.RoundPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblPercent As System.Windows.Forms.Label
    Friend WithEvents FadeTimer As System.Windows.Forms.Timer
    Friend WithEvents RoundPictureBox1 As library_system.RoundPictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
