<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class return_book
    Inherits System.Windows.Forms.Form


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


    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt_book_id = New System.Windows.Forms.TextBox()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.btn_find = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.lbl_book_title = New System.Windows.Forms.Label()
        Me.lbl_book_author = New System.Windows.Forms.Label()
        Me.lbl_book_genre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 150)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(800, 300)
        Me.DataGridView1.TabIndex = 0

        Me.txt_book_id.Location = New System.Drawing.Point(100, 20)
        Me.txt_book_id.Name = "txt_book_id"
        Me.txt_book_id.Size = New System.Drawing.Size(100, 26)
        Me.txt_book_id.TabIndex = 1

        Me.btn_return.Location = New System.Drawing.Point(220, 15)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(100, 35)
        Me.btn_return.TabIndex = 2
        Me.btn_return.Text = "Return Book"
        Me.btn_return.UseVisualStyleBackColor = True

        Me.btn_find.Location = New System.Drawing.Point(330, 15)
        Me.btn_find.Name = "btn_find"
        Me.btn_find.Size = New System.Drawing.Size(100, 35)
        Me.btn_find.TabIndex = 3
        Me.btn_find.Text = "Find Book"
        Me.btn_find.UseVisualStyleBackColor = True

        Me.btn_clear.Location = New System.Drawing.Point(440, 15)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(100, 35)
        Me.btn_clear.TabIndex = 4
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True

        Me.btn_refresh.Location = New System.Drawing.Point(550, 15)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(100, 35)
        Me.btn_refresh.TabIndex = 5
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True

        Me.lbl_book_title.AutoSize = True
        Me.lbl_book_title.Location = New System.Drawing.Point(100, 60)
        Me.lbl_book_title.Name = "lbl_book_title"
        Me.lbl_book_title.Size = New System.Drawing.Size(51, 20)
        Me.lbl_book_title.TabIndex = 6
        Me.lbl_book_title.Text = "Title: "

        Me.lbl_book_author.AutoSize = True
        Me.lbl_book_author.Location = New System.Drawing.Point(100, 90)
        Me.lbl_book_author.Name = "lbl_book_author"
        Me.lbl_book_author.Size = New System.Drawing.Size(70, 20)
        Me.lbl_book_author.TabIndex = 7
        Me.lbl_book_author.Text = "Author: "

        Me.lbl_book_genre.AutoSize = True
        Me.lbl_book_genre.Location = New System.Drawing.Point(100, 120)
        Me.lbl_book_genre.Name = "lbl_book_genre"
        Me.lbl_book_genre.Size = New System.Drawing.Size(67, 20)
        Me.lbl_book_genre.TabIndex = 8
        Me.lbl_book_genre.Text = "Genre: "

        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Book ID:"

        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Book Info:"

        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 11

        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 20)
        Me.Label4.TabIndex = 12

        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 462)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_book_genre)
        Me.Controls.Add(Me.lbl_book_author)
        Me.Controls.Add(Me.lbl_book_title)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_find)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.txt_book_id)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "return_book"
        Me.Text = "Return Book"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_book_id As TextBox
    Friend WithEvents btn_return As Button
    Friend WithEvents btn_find As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_refresh As Button
    Friend WithEvents lbl_book_title As Label
    Friend WithEvents lbl_book_author As Label
    Friend WithEvents lbl_book_genre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class