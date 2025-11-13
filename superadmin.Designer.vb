<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class superadmin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.total_students = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.total_books = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_borrowed_count = New System.Windows.Forms.Label()
        Me.lbl_available_count = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.total_students)
        Me.Panel1.Location = New System.Drawing.Point(72, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(388, 118)
        Me.Panel1.TabIndex = 0
        '
        'total_students
        '
        Me.total_students.AutoSize = True
        Me.total_students.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_students.ForeColor = System.Drawing.Color.White
        Me.total_students.Location = New System.Drawing.Point(28, 38)
        Me.total_students.Name = "total_students"
        Me.total_students.Size = New System.Drawing.Size(238, 37)
        Me.total_students.TabIndex = 2
        Me.total_students.Text = "Total Students"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel2.Controls.Add(Me.total_books)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(475, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(388, 118)
        Me.Panel2.TabIndex = 1
        '
        'total_books
        '
        Me.total_books.AutoSize = True
        Me.total_books.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_books.ForeColor = System.Drawing.Color.White
        Me.total_books.Location = New System.Drawing.Point(28, 38)
        Me.total_books.Name = "total_books"
        Me.total_books.Size = New System.Drawing.Size(198, 37)
        Me.total_books.TabIndex = 3
        Me.total_books.Text = "Total Books"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Orange
        Me.Panel3.Controls.Add(Me.lbl_borrowed_count)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(72, 172)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(388, 288)
        Me.Panel3.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Tomato
        Me.Panel4.Controls.Add(Me.lbl_available_count)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(475, 172)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(388, 288)
        Me.Panel4.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'lbl_borrowed_count
        '
        Me.lbl_borrowed_count.AutoSize = True
        Me.lbl_borrowed_count.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_borrowed_count.ForeColor = System.Drawing.Color.White
        Me.lbl_borrowed_count.Location = New System.Drawing.Point(125, 120)
        Me.lbl_borrowed_count.Name = "lbl_borrowed_count"
        Me.lbl_borrowed_count.Size = New System.Drawing.Size(99, 108)
        Me.lbl_borrowed_count.TabIndex = 4
        Me.lbl_borrowed_count.Text = "0"
        Me.lbl_borrowed_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_available_count
        '
        Me.lbl_available_count.AutoSize = True
        Me.lbl_available_count.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_available_count.ForeColor = System.Drawing.Color.White
        Me.lbl_available_count.Location = New System.Drawing.Point(125, 120)
        Me.lbl_available_count.Name = "lbl_available_count"
        Me.lbl_available_count.Size = New System.Drawing.Size(99, 108)
        Me.lbl_available_count.TabIndex = 5
        Me.lbl_available_count.Text = "0"
        Me.lbl_available_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Borrowed Books"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(28, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(278, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Available Books"
        '
        'btn_refresh
        '
        Me.btn_refresh.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_refresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.ForeColor = System.Drawing.Color.White
        Me.btn_refresh.Location = New System.Drawing.Point(900, 35)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(120, 50)
        Me.btn_refresh.TabIndex = 2
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'superadmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1380, 586)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "superadmin"
        Me.Text = "superadmin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents total_students As Label
    Friend WithEvents total_books As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbl_borrowed_count As Label
    Friend WithEvents lbl_available_count As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_refresh As Button
End Class