<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class edit
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
        Me.author_txt = New System.Windows.Forms.TextBox()
        Me.id_txt = New System.Windows.Forms.TextBox()
        Me.title_txt = New System.Windows.Forms.TextBox()
        Me.genre_txt = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.upd_txt = New System.Windows.Forms.Button()
        Me.dlt_txt = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.find_txt = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TITLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AUTHORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GENREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'author_txt
        '
        Me.author_txt.Location = New System.Drawing.Point(68, 159)
        Me.author_txt.Name = "author_txt"
        Me.author_txt.Size = New System.Drawing.Size(100, 26)
        Me.author_txt.TabIndex = 1
        '
        'id_txt
        '
        Me.id_txt.Location = New System.Drawing.Point(68, 65)
        Me.id_txt.Name = "id_txt"
        Me.id_txt.Size = New System.Drawing.Size(100, 26)
        Me.id_txt.TabIndex = 2
        '
        'title_txt
        '
        Me.title_txt.Location = New System.Drawing.Point(68, 114)
        Me.title_txt.Name = "title_txt"
        Me.title_txt.Size = New System.Drawing.Size(100, 26)
        Me.title_txt.TabIndex = 4
        '
        'genre_txt
        '
        Me.genre_txt.Location = New System.Drawing.Point(68, 211)
        Me.genre_txt.Name = "genre_txt"
        Me.genre_txt.Size = New System.Drawing.Size(100, 26)
        Me.genre_txt.TabIndex = 5
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(8, 71)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(26, 20)
        Me.lbl1.TabIndex = 6
        Me.lbl1.Text = "ID"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(8, 117)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(38, 20)
        Me.lbl2.TabIndex = 7
        Me.lbl2.Text = "Title"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(8, 165)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(57, 20)
        Me.lbl3.TabIndex = 8
        Me.lbl3.Text = "Author"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Location = New System.Drawing.Point(8, 214)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(54, 20)
        Me.lbl5.TabIndex = 9
        Me.lbl5.Text = "Genre"
        '
        'upd_txt
        '
        Me.upd_txt.Location = New System.Drawing.Point(101, 312)
        Me.upd_txt.Name = "upd_txt"
        Me.upd_txt.Size = New System.Drawing.Size(75, 31)
        Me.upd_txt.TabIndex = 12
        Me.upd_txt.Text = "Update"
        Me.upd_txt.UseVisualStyleBackColor = True
        '
        'dlt_txt
        '
        Me.dlt_txt.Location = New System.Drawing.Point(12, 312)
        Me.dlt_txt.Name = "dlt_txt"
        Me.dlt_txt.Size = New System.Drawing.Size(75, 31)
        Me.dlt_txt.TabIndex = 13
        Me.dlt_txt.Text = "Delete"
        Me.dlt_txt.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(101, 266)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 31)
        Me.btn_add.TabIndex = 15
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(53, 359)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(75, 31)
        Me.clear.TabIndex = 16
        Me.clear.Text = "Clear All"
        Me.clear.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.TITLEDataGridViewTextBoxColumn, Me.AUTHORDataGridViewTextBoxColumn, Me.GENREDataGridViewTextBoxColumn, Me.DATEDataGridViewTextBoxColumn})
        Me.DataGridView1.Location = New System.Drawing.Point(174, 65)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1079, 468)
        Me.DataGridView1.TabIndex = 17
        '
        'find_txt
        '
        Me.find_txt.Location = New System.Drawing.Point(12, 266)
        Me.find_txt.Name = "find_txt"
        Me.find_txt.Size = New System.Drawing.Size(75, 31)
        Me.find_txt.TabIndex = 18
        Me.find_txt.Text = "Search"
        Me.find_txt.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 150
        '
        'TITLEDataGridViewTextBoxColumn
        '
        Me.TITLEDataGridViewTextBoxColumn.DataPropertyName = "TITLE"
        Me.TITLEDataGridViewTextBoxColumn.HeaderText = "TITLE"
        Me.TITLEDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TITLEDataGridViewTextBoxColumn.Name = "TITLEDataGridViewTextBoxColumn"
        Me.TITLEDataGridViewTextBoxColumn.Width = 150
        '
        'AUTHORDataGridViewTextBoxColumn
        '
        Me.AUTHORDataGridViewTextBoxColumn.DataPropertyName = "AUTHOR"
        Me.AUTHORDataGridViewTextBoxColumn.HeaderText = "AUTHOR"
        Me.AUTHORDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AUTHORDataGridViewTextBoxColumn.Name = "AUTHORDataGridViewTextBoxColumn"
        Me.AUTHORDataGridViewTextBoxColumn.Width = 150
        '
        'GENREDataGridViewTextBoxColumn
        '
        Me.GENREDataGridViewTextBoxColumn.DataPropertyName = "GENRE"
        Me.GENREDataGridViewTextBoxColumn.HeaderText = "GENRE"
        Me.GENREDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.GENREDataGridViewTextBoxColumn.Name = "GENREDataGridViewTextBoxColumn"
        Me.GENREDataGridViewTextBoxColumn.Width = 150
        '
        'DATEDataGridViewTextBoxColumn
        '
        Me.DATEDataGridViewTextBoxColumn.DataPropertyName = "DATE"
        Me.DATEDataGridViewTextBoxColumn.HeaderText = "DATE"
        Me.DATEDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DATEDataGridViewTextBoxColumn.Name = "DATEDataGridViewTextBoxColumn"
        Me.DATEDataGridViewTextBoxColumn.Width = 150
        '
        'edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1538, 647)
        Me.Controls.Add(Me.find_txt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.dlt_txt)
        Me.Controls.Add(Me.upd_txt)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.genre_txt)
        Me.Controls.Add(Me.title_txt)
        Me.Controls.Add(Me.id_txt)
        Me.Controls.Add(Me.author_txt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "edit"
        Me.Text = "edit"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents author_txt As TextBox
    Friend WithEvents id_txt As TextBox
    Friend WithEvents title_txt As TextBox
    Friend WithEvents genre_txt As TextBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents upd_txt As Button
    Friend WithEvents dlt_txt As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents clear As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents find_txt As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TITLEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AUTHORDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GENREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class