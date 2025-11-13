<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inventory
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnOnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_generate_report = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_total_books = New System.Windows.Forms.Label()
        Me.lbl_borrowed_books = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_available_books = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TitleDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.GenreDataGridViewTextBoxColumn, Me.BorrowedDataGridViewTextBoxColumn, Me.ReturnOnDataGridViewTextBoxColumn})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1212, 470)
        Me.DataGridView1.TabIndex = 0
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.Width = 200
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
        Me.GenreDataGridViewTextBoxColumn.Width = 120
        '
        'BorrowedDataGridViewTextBoxColumn
        '
        Me.BorrowedDataGridViewTextBoxColumn.DataPropertyName = "Borrowed"
        Me.BorrowedDataGridViewTextBoxColumn.HeaderText = "Borrowed"
        Me.BorrowedDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.BorrowedDataGridViewTextBoxColumn.Name = "BorrowedDataGridViewTextBoxColumn"
        Me.BorrowedDataGridViewTextBoxColumn.Width = 120
        '
        'ReturnOnDataGridViewTextBoxColumn
        '
        Me.ReturnOnDataGridViewTextBoxColumn.DataPropertyName = "Return On"
        Me.ReturnOnDataGridViewTextBoxColumn.HeaderText = "Return On"
        Me.ReturnOnDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ReturnOnDataGridViewTextBoxColumn.Name = "ReturnOnDataGridViewTextBoxColumn"
        Me.ReturnOnDataGridViewTextBoxColumn.Width = 150
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(12, 12)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(120, 45)
        Me.btn_refresh.TabIndex = 1
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'btn_generate_report
        '
        Me.btn_generate_report.Location = New System.Drawing.Point(150, 12)
        Me.btn_generate_report.Name = "btn_generate_report"
        Me.btn_generate_report.Size = New System.Drawing.Size(180, 45)
        Me.btn_generate_report.TabIndex = 2
        Me.btn_generate_report.Text = "Generate Report"
        Me.btn_generate_report.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(350, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total Books:"
        '
        'lbl_total_books
        '
        Me.lbl_total_books.AutoSize = True
        Me.lbl_total_books.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_books.ForeColor = System.Drawing.Color.Blue
        Me.lbl_total_books.Location = New System.Drawing.Point(456, 12)
        Me.lbl_total_books.Name = "lbl_total_books"
        Me.lbl_total_books.Size = New System.Drawing.Size(19, 20)
        Me.lbl_total_books.TabIndex = 4
        Me.lbl_total_books.Text = "0"
        '
        'lbl_borrowed_books
        '
        Me.lbl_borrowed_books.AutoSize = True
        Me.lbl_borrowed_books.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_borrowed_books.ForeColor = System.Drawing.Color.Red
        Me.lbl_borrowed_books.Location = New System.Drawing.Point(456, 42)
        Me.lbl_borrowed_books.Name = "lbl_borrowed_books"
        Me.lbl_borrowed_books.Size = New System.Drawing.Size(19, 20)
        Me.lbl_borrowed_books.TabIndex = 6
        Me.lbl_borrowed_books.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(350, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Borrowed Books:"
        '
        'lbl_available_books
        '
        Me.lbl_available_books.AutoSize = True
        Me.lbl_available_books.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_available_books.ForeColor = System.Drawing.Color.Green
        Me.lbl_available_books.Location = New System.Drawing.Point(656, 12)
        Me.lbl_available_books.Name = "lbl_available_books"
        Me.lbl_available_books.Size = New System.Drawing.Size(19, 20)
        Me.lbl_available_books.TabIndex = 8
        Me.lbl_available_books.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(550, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Available:"
        '
        'inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1224, 599)
        Me.Controls.Add(Me.lbl_available_books)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_borrowed_books)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_total_books)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_generate_report)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "inventory"
        Me.Text = "inventory"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorrowedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReturnOnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btn_generate_report As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_total_books As Label
    Friend WithEvents lbl_borrowed_books As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_available_books As Label
    Friend WithEvents Label5 As Label
End Class