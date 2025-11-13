<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register_student
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
        id_txt = New TextBox()
        student_txt = New TextBox()
        year_txt = New TextBox()
        program_txt = New TextBox()
        department_txt = New TextBox()
        pass_txt = New TextBox()
        age_txt = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        rgs_btn = New Button()
        SuspendLayout()
        ' 
        ' id_txt
        ' 
        id_txt.Location = New Point(196, 86)
        id_txt.Name = "id_txt"
        id_txt.Size = New Size(150, 31)
        id_txt.TabIndex = 0
        ' 
        ' student_txt
        ' 
        student_txt.Location = New Point(196, 132)
        student_txt.Name = "student_txt"
        student_txt.Size = New Size(150, 31)
        student_txt.TabIndex = 1
        ' 
        ' year_txt
        ' 
        year_txt.Location = New Point(196, 235)
        year_txt.Name = "year_txt"
        year_txt.Size = New Size(150, 31)
        year_txt.TabIndex = 3
        ' 
        ' program_txt
        ' 
        program_txt.Location = New Point(480, 89)
        program_txt.Name = "program_txt"
        program_txt.Size = New Size(150, 31)
        program_txt.TabIndex = 4
        ' 
        ' department_txt
        ' 
        department_txt.Location = New Point(506, 135)
        department_txt.Name = "department_txt"
        department_txt.Size = New Size(150, 31)
        department_txt.TabIndex = 5
        ' 
        ' pass_txt
        ' 
        pass_txt.Location = New Point(486, 190)
        pass_txt.Name = "pass_txt"
        pass_txt.Size = New Size(150, 31)
        pass_txt.TabIndex = 6
        ' 
        ' age_txt
        ' 
        age_txt.Location = New Point(196, 190)
        age_txt.Name = "age_txt"
        age_txt.Size = New Size(150, 31)
        age_txt.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(65, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 25)
        Label1.TabIndex = 8
        Label1.Text = "Student ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(65, 138)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 25)
        Label2.TabIndex = 9
        Label2.Text = "Student Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(114, 196)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 25)
        Label4.TabIndex = 11
        Label4.Text = "Age"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(114, 238)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 25)
        Label5.TabIndex = 12
        Label5.Text = "Year"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(393, 89)
        Label6.Name = "Label6"
        Label6.Size = New Size(81, 25)
        Label6.TabIndex = 13
        Label6.Text = "Program"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(393, 138)
        Label7.Name = "Label7"
        Label7.Size = New Size(107, 25)
        Label7.TabIndex = 14
        Label7.Text = "Department"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(393, 190)
        Label8.Name = "Label8"
        Label8.Size = New Size(87, 25)
        Label8.TabIndex = 15
        Label8.Text = "Password"
        ' 
        ' rgs_btn
        ' 
        rgs_btn.Location = New Point(301, 291)
        rgs_btn.Name = "rgs_btn"
        rgs_btn.Size = New Size(200, 79)
        rgs_btn.TabIndex = 16
        rgs_btn.Text = "Register"
        rgs_btn.UseVisualStyleBackColor = True
        ' 
        ' register_student
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(rgs_btn)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(age_txt)
        Controls.Add(pass_txt)
        Controls.Add(department_txt)
        Controls.Add(program_txt)
        Controls.Add(year_txt)
        Controls.Add(student_txt)
        Controls.Add(id_txt)
        Name = "register_student"
        Text = "register_student"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents id_txt As TextBox
    Friend WithEvents student_txt As TextBox
    Friend WithEvents year_txt As TextBox
    Friend WithEvents program_txt As TextBox
    Friend WithEvents department_txt As TextBox
    Friend WithEvents pass_txt As TextBox
    Friend WithEvents age_txt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents rgs_btn As Button
End Class
