<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class edit_book
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
        Me.title_txt = New System.Windows.Forms.TextBox()
        Me.author_txt = New System.Windows.Forms.TextBox()
        Me.genre_txt = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.upd_txt = New System.Windows.Forms.Button()
        Me.dlt_txt = New System.Windows.Forms.Button()
        Me.find_txt = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BookIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateAddedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_txt = New System.Windows.Forms.TextBox()
        Me.gn_id = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'title_txt
        '
        Me.title_txt.Location = New System.Drawing.Point(63, 153)
        Me.title_txt.Name = "title_txt"
        Me.title_txt.Size = New System.Drawing.Size(100, 26)
        Me.title_txt.TabIndex = 0
        '
        'author_txt
        '
        Me.author_txt.Location = New System.Drawing.Point(63, 185)
        Me.author_txt.Name = "author_txt"
        Me.author_txt.Size = New System.Drawing.Size(100, 26)
        Me.author_txt.TabIndex = 1
        '
        'genre_txt
        '
        Me.genre_txt.Location = New System.Drawing.Point(63, 217)
        Me.genre_txt.Name = "genre_txt"
        Me.genre_txt.Size = New System.Drawing.Size(100, 26)
        Me.genre_txt.TabIndex = 2
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(12, 261)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 49)
        Me.btn_add.TabIndex = 4
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'upd_txt
        '
        Me.upd_txt.Location = New System.Drawing.Point(93, 261)
        Me.upd_txt.Name = "upd_txt"
        Me.upd_txt.Size = New System.Drawing.Size(75, 49)
        Me.upd_txt.TabIndex = 5
        Me.upd_txt.Text = "Update"
        Me.upd_txt.UseVisualStyleBackColor = True
        '
        'dlt_txt
        '
        Me.dlt_txt.Location = New System.Drawing.Point(12, 316)
        Me.dlt_txt.Name = "dlt_txt"
        Me.dlt_txt.Size = New System.Drawing.Size(75, 48)
        Me.dlt_txt.TabIndex = 6
        Me.dlt_txt.Text = "Delete"
        Me.dlt_txt.UseVisualStyleBackColor = True
        '
        'find_txt
        '
        Me.find_txt.Location = New System.Drawing.Point(93, 316)
        Me.find_txt.Name = "find_txt"
        Me.find_txt.Size = New System.Drawing.Size(75, 48)
        Me.find_txt.TabIndex = 7
        Me.find_txt.Text = "Find"
        Me.find_txt.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(25, 370)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(138, 48)
        Me.clear.TabIndex = 8
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookIdDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.GenreDataGridViewTextBoxColumn, Me.DateAddedDataGridViewTextBoxColumn})
        Me.DataGridView1.Location = New System.Drawing.Point(183, 116)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(806, 302)
        Me.DataGridView1.TabIndex = 9
        '
        'BookIdDataGridViewTextBoxColumn
        '
        Me.BookIdDataGridViewTextBoxColumn.DataPropertyName = "Book Id"
        Me.BookIdDataGridViewTextBoxColumn.HeaderText = "Book Id"
        Me.BookIdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.BookIdDataGridViewTextBoxColumn.Name = "BookIdDataGridViewTextBoxColumn"
        Me.BookIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.BookIdDataGridViewTextBoxColumn.Width = 150
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.Width = 150
        '
        'AuthorDataGridViewTextBoxColumn
        '
        Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "Author"
        Me.AuthorDataGridViewTextBoxColumn.HeaderText = "Author"
        Me.AuthorDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
        Me.AuthorDataGridViewTextBoxColumn.Width = 150
        '
        'GenreDataGridViewTextBoxColumn
        '
        Me.GenreDataGridViewTextBoxColumn.DataPropertyName = "Genre"
        Me.GenreDataGridViewTextBoxColumn.HeaderText = "Genre"
        Me.GenreDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.GenreDataGridViewTextBoxColumn.Name = "GenreDataGridViewTextBoxColumn"
        Me.GenreDataGridViewTextBoxColumn.Width = 150
        '
        'DateAddedDataGridViewTextBoxColumn
        '
        Me.DateAddedDataGridViewTextBoxColumn.DataPropertyName = "Date Added"
        Me.DateAddedDataGridViewTextBoxColumn.HeaderText = "Date Added"
        Me.DateAddedDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DateAddedDataGridViewTextBoxColumn.Name = "DateAddedDataGridViewTextBoxColumn"
        Me.DateAddedDataGridViewTextBoxColumn.Width = 150
        '
        'id_txt
        '
        Me.id_txt.Location = New System.Drawing.Point(63, 116)
        Me.id_txt.Name = "id_txt"
        Me.id_txt.Size = New System.Drawing.Size(100, 26)
        Me.id_txt.TabIndex = 10
        '
        'gn_id
        '
        Me.gn_id.Location = New System.Drawing.Point(63, 61)
        Me.gn_id.Name = "gn_id"
        Me.gn_id.Size = New System.Drawing.Size(100, 49)
        Me.gn_id.TabIndex = 11
        Me.gn_id.Text = "Generate ID"
        Me.gn_id.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Book Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Author"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Genre"
        '
        'edit_book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 588)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gn_id)
        Me.Controls.Add(Me.id_txt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.find_txt)
        Me.Controls.Add(Me.dlt_txt)
        Me.Controls.Add(Me.upd_txt)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.genre_txt)
        Me.Controls.Add(Me.author_txt)
        Me.Controls.Add(Me.title_txt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "edit_book"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "edit_book"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents title_txt As TextBox
    Friend WithEvents author_txt As TextBox
    Friend WithEvents genre_txt As TextBox
    Friend WithEvents btn_add As Button
    Friend WithEvents upd_txt As Button
    Friend WithEvents dlt_txt As Button
    Friend WithEvents find_txt As Button
    Friend WithEvents clear As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BookIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateAddedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents id_txt As TextBox
    Friend WithEvents gn_id As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class