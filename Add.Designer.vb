<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.clear_button = New System.Windows.Forms.Button()
        Me.add_button = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.author = New System.Windows.Forms.TextBox()
        Me.title = New System.Windows.Forms.TextBox()
        Me.genres = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.genres)
        Me.Panel1.Controls.Add(Me.clear_button)
        Me.Panel1.Controls.Add(Me.add_button)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.author)
        Me.Panel1.Controls.Add(Me.title)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(274, 294)
        Me.Panel1.TabIndex = 0
        '
        'clear_button
        '
        Me.clear_button.Location = New System.Drawing.Point(163, 202)
        Me.clear_button.Name = "clear_button"
        Me.clear_button.Size = New System.Drawing.Size(75, 32)
        Me.clear_button.TabIndex = 8
        Me.clear_button.Text = "Clear All"
        Me.clear_button.UseVisualStyleBackColor = True
        '
        'add_button
        '
        Me.add_button.Location = New System.Drawing.Point(43, 202)
        Me.add_button.Name = "add_button"
        Me.add_button.Size = New System.Drawing.Size(75, 32)
        Me.add_button.TabIndex = 7
        Me.add_button.Text = "Add Book"
        Me.add_button.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Genre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Author"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Title"
        '
        'author
        '
        Me.author.Location = New System.Drawing.Point(103, 96)
        Me.author.Name = "author"
        Me.author.Size = New System.Drawing.Size(150, 26)
        Me.author.TabIndex = 1
        '
        'title
        '
        Me.title.Location = New System.Drawing.Point(103, 50)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(150, 26)
        Me.title.TabIndex = 0
        '
        'genres
        '
        Me.genres.Location = New System.Drawing.Point(103, 144)
        Me.genres.Name = "genres"
        Me.genres.Size = New System.Drawing.Size(150, 26)
        Me.genres.TabIndex = 9
        '
        'Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Add"
        Me.Text = "Add"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents author As TextBox
    Friend WithEvents title As TextBox
    Friend WithEvents clear_button As Button
    Friend WithEvents add_button As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents genres As TextBox
End Class
