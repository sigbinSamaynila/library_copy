<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LibraryAdmin
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LibraryAdmin))
        button_edit = New Button()
        button_users = New Button()
        Panel1 = New Panel()
        borrow_btn = New Button()
        return_btn = New Button()
        inventory_btn = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        board_btn = New Button()
        Panel2 = New Panel()
        Panel4 = New Panel()
        total_books = New Label()
        Panel3 = New Panel()
        total_students = New Label()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' button_edit
        ' 
        button_edit.Location = New Point(0, 276)
        button_edit.Margin = New Padding(3, 4, 3, 4)
        button_edit.Name = "button_edit"
        button_edit.Size = New Size(222, 82)
        button_edit.TabIndex = 6
        button_edit.Text = "Edit Book"
        button_edit.UseVisualStyleBackColor = True
        ' 
        ' button_users
        ' 
        button_users.Location = New Point(0, 350)
        button_users.Margin = New Padding(3, 4, 3, 4)
        button_users.Name = "button_users"
        button_users.Size = New Size(222, 82)
        button_users.TabIndex = 7
        button_users.Text = "Users"
        button_users.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(borrow_btn)
        Panel1.Controls.Add(return_btn)
        Panel1.Controls.Add(inventory_btn)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(board_btn)
        Panel1.Controls.Add(button_edit)
        Panel1.Controls.Add(button_users)
        Panel1.Location = New Point(0, -2)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(222, 834)
        Panel1.TabIndex = 11
        ' 
        ' borrow_btn
        ' 
        borrow_btn.Location = New Point(0, 508)
        borrow_btn.Margin = New Padding(3, 4, 3, 4)
        borrow_btn.Name = "borrow_btn"
        borrow_btn.Size = New Size(222, 89)
        borrow_btn.TabIndex = 14
        borrow_btn.Text = "Borrow"
        borrow_btn.UseVisualStyleBackColor = True
        ' 
        ' return_btn
        ' 
        return_btn.Location = New Point(0, 428)
        return_btn.Margin = New Padding(3, 4, 3, 4)
        return_btn.Name = "return_btn"
        return_btn.Size = New Size(222, 84)
        return_btn.TabIndex = 14
        return_btn.Text = "Return"
        return_btn.UseVisualStyleBackColor = True
        ' 
        ' inventory_btn
        ' 
        inventory_btn.Location = New Point(2, 591)
        inventory_btn.Margin = New Padding(3, 4, 3, 4)
        inventory_btn.Name = "inventory_btn"
        inventory_btn.Size = New Size(222, 82)
        inventory_btn.TabIndex = 9
        inventory_btn.Text = "Inventory"
        inventory_btn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ControlLight
        Label1.Location = New Point(0, 124)
        Label1.Name = "Label1"
        Label1.Size = New Size(224, 84)
        Label1.TabIndex = 0
        Label1.Text = "Assistant Librarian"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ControlLight
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 4)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(224, 135)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' board_btn
        ' 
        board_btn.Location = New Point(0, 200)
        board_btn.Margin = New Padding(3, 4, 3, 4)
        board_btn.Name = "board_btn"
        board_btn.Size = New Size(222, 82)
        board_btn.TabIndex = 10
        board_btn.Text = "Dashboard"
        board_btn.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(231, 36)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1454, 585)
        Panel2.TabIndex = 12
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveCaption
        Panel4.Controls.Add(total_books)
        Panel4.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel4.Location = New Point(528, 44)
        Panel4.Margin = New Padding(3, 4, 3, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(431, 148)
        Panel4.TabIndex = 3
        ' 
        ' total_books
        ' 
        total_books.AutoSize = True
        total_books.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        total_books.Location = New Point(31, 48)
        total_books.Name = "total_books"
        total_books.Size = New Size(198, 37)
        total_books.TabIndex = 3
        total_books.Text = "Total Books"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveCaption
        Panel3.Controls.Add(total_students)
        Panel3.Location = New Point(80, 44)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(431, 148)
        Panel3.TabIndex = 13
        ' 
        ' total_students
        ' 
        total_students.AutoSize = True
        total_students.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        total_students.Location = New Point(31, 48)
        total_students.Name = "total_students"
        total_students.Size = New Size(238, 37)
        total_students.TabIndex = 2
        total_students.Text = "Total Students"
        ' 
        ' Timer1
        ' 
        ' 
        ' LibraryAdmin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1864, 835)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        Name = "LibraryAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)

    End Sub
    Friend WithEvents button_edit As Button
    Friend WithEvents button_users As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents board_btn As Button
    Friend WithEvents inventory_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents total_students As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents total_books As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents borrow_btn As Button
    Friend WithEvents return_btn As Button
End Class
