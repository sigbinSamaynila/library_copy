<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class user
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
        Me.id_txt = New System.Windows.Forms.TextBox()
        Me.user_txt = New System.Windows.Forms.TextBox()
        Me.program_txt = New System.Windows.Forms.TextBox()
        Me.department_txt = New System.Windows.Forms.TextBox()
        Me.find_txt = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dlt_btn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgramDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserlogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_refresh = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserlogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'id_txt
        '
        Me.id_txt.Location = New System.Drawing.Point(120, 50)
        Me.id_txt.Name = "id_txt"
        Me.id_txt.Size = New System.Drawing.Size(150, 26)
        Me.id_txt.TabIndex = 1
        '
        'user_txt
        '
        Me.user_txt.Location = New System.Drawing.Point(120, 90)
        Me.user_txt.Name = "user_txt"
        Me.user_txt.Size = New System.Drawing.Size(150, 26)
        Me.user_txt.TabIndex = 2
        '
        'program_txt
        '
        Me.program_txt.Location = New System.Drawing.Point(120, 130)
        Me.program_txt.Name = "program_txt"
        Me.program_txt.Size = New System.Drawing.Size(150, 26)
        Me.program_txt.TabIndex = 3
        '
        'department_txt
        '
        Me.department_txt.Location = New System.Drawing.Point(120, 170)
        Me.department_txt.Name = "department_txt"
        Me.department_txt.Size = New System.Drawing.Size(150, 26)
        Me.department_txt.TabIndex = 4
        '
        'find_txt
        '
        Me.find_txt.Location = New System.Drawing.Point(120, 210)
        Me.find_txt.Name = "find_txt"
        Me.find_txt.Size = New System.Drawing.Size(150, 35)
        Me.find_txt.TabIndex = 5
        Me.find_txt.Text = "Find User"
        Me.find_txt.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'dlt_btn
        '
        Me.dlt_btn.BackColor = System.Drawing.Color.LightCoral
        Me.dlt_btn.Location = New System.Drawing.Point(120, 290)
        Me.dlt_btn.Name = "dlt_btn"
        Me.dlt_btn.Size = New System.Drawing.Size(150, 35)
        Me.dlt_btn.TabIndex = 6
        Me.dlt_btn.Text = "Delete User"
        Me.dlt_btn.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.ProgramDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UserlogBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(300, 50)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(700, 400)
        Me.DataGridView1.TabIndex = 7
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 80
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.Width = 150
        '
        'ProgramDataGridViewTextBoxColumn
        '
        Me.ProgramDataGridViewTextBoxColumn.DataPropertyName = "Program"
        Me.ProgramDataGridViewTextBoxColumn.HeaderText = "Program"
        Me.ProgramDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ProgramDataGridViewTextBoxColumn.Name = "ProgramDataGridViewTextBoxColumn"
        Me.ProgramDataGridViewTextBoxColumn.Width = 150
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        Me.DepartmentDataGridViewTextBoxColumn.Width = 150
        '
        'UserlogBindingSource
        '
        Me.UserlogBindingSource.DataMember = "user_log"
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.LightGreen
        Me.btn_add.Location = New System.Drawing.Point(120, 250)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(150, 35)
        Me.btn_add.TabIndex = 8
        Me.btn_add.Text = "Add User"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.LightBlue
        Me.btn_update.Location = New System.Drawing.Point(120, 330)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(150, 35)
        Me.btn_update.TabIndex = 9
        Me.btn_update.Text = "Update User"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(120, 370)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(150, 35)
        Me.btn_clear.TabIndex = 10
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Student ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Program:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Department:"
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(120, 410)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(150, 35)
        Me.btn_refresh.TabIndex = 15
        Me.btn_refresh.Text = "Refresh Data"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 500)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dlt_btn)
        Me.Controls.Add(Me.find_txt)
        Me.Controls.Add(Me.department_txt)
        Me.Controls.Add(Me.program_txt)
        Me.Controls.Add(Me.user_txt)
        Me.Controls.Add(Me.id_txt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "user"
        Me.Text = "user"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserlogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents id_txt As TextBox
    Friend WithEvents user_txt As TextBox
    Friend WithEvents program_txt As TextBox
    Friend WithEvents department_txt As TextBox
    Friend WithEvents find_txt As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents dlt_btn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents UserlogBindingSource As BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProgramDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_refresh As Button
End Class