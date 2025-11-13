<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class log
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
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.btn_log = New System.Windows.Forms.Button()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(245, 150)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(232, 26)
        Me.txtusername.TabIndex = 0
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(245, 233)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(232, 26)
        Me.txtpassword.TabIndex = 1
        '
        'btn_log
        '
        Me.btn_log.Location = New System.Drawing.Point(271, 284)
        Me.btn_log.Name = "btn_log"
        Me.btn_log.Size = New System.Drawing.Size(182, 37)
        Me.btn_log.TabIndex = 2
        Me.btn_log.Text = "Log In"
        Me.btn_log.UseVisualStyleBackColor = True
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(245, 192)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(232, 26)
        Me.txtemail.TabIndex = 3
        '
        'log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.btn_log)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Name = "log"
        Me.Text = "log"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents btn_log As Button
    Friend WithEvents txtemail As TextBox
End Class
