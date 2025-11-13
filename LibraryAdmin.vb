Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class LibraryAdmin
    Private connectionString As String = "Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database=LibraryDB;"

    ' Make sure your form has these buttons declared WithEvents in the designer
    ' These declarations should already be in your Designer.vb file

    Sub switchPanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub button_edit_Click(sender As Object, e As EventArgs) Handles button_edit.Click
        switchPanel(edit_book)
    End Sub

    Private Sub button_users_Click(sender As Object, e As EventArgs) Handles button_users.Click
        switchPanel(user)
    End Sub

    Private Sub inventory_btn_Click(sender As Object, e As EventArgs) Handles inventory_btn.Click
        switchPanel(inventory)
    End Sub

    Private Sub board_btn_Click(sender As Object, e As EventArgs) Handles board_btn.Click
        switchPanel(superadmin)
    End Sub

    ' Make sure this button exists on your form and is named "borrow_btn"
    Private Sub borrow_btn_Click(sender As Object, e As EventArgs)
        Dim borrow As New borrow_book()
        borrow.Show()
        Me.Hide()
    End Sub

    ' Make sure these buttons exist on your form
    Private Sub btn_dashboard_Click(sender As Object, e As EventArgs)
        LoadData()
        MessageBox.Show("Dashboard refreshed!", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_settings_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Settings feature coming soon!", "Settings",
                       MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LibraryAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateDatabaseAndTables()
        LoadData()

        Timer1.Interval = 5000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadData()
    End Sub

    Private Sub CreateDatabaseAndTables()
        Try
            Using connection As New SqlConnection("Server=(localdb)\MSSQLLocalDB;Integrated Security=true;")
                connection.Open()

                ' Create LibraryDB if it doesn't exist
                Dim createDb As String = "IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'LibraryDB') CREATE DATABASE LibraryDB;"
                Using cmd As New SqlCommand(createDb, connection)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Create necessary tables
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Create user_log table if not exists
                Dim createUserLogTable As String = "
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='user_log' AND xtype='U')
                    CREATE TABLE [user_log] (
                        Id INT PRIMARY KEY IDENTITY(1,1),
                        username NVARCHAR(100),
                        program NVARCHAR(100),
                        department NVARCHAR(100)
                    );"

                Using cmd As New SqlCommand(createUserLogTable, connection)
                    cmd.ExecuteNonQuery()
                End Using

                ' Create books1 table if not exists
                Dim createBooksTable As String = "
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='books1' AND xtype='U')
                    CREATE TABLE books1 (
                        [Book Id] INT PRIMARY KEY IDENTITY(1,1),
                        [Title] NVARCHAR(100),
                        [Author] NVARCHAR(100),
                        [Genre] NVARCHAR(50),
                        [Date Added] DATE DEFAULT GETDATE()
                    );"

                Using cmd As New SqlCommand(createBooksTable, connection)
                    cmd.ExecuteNonQuery()
                End Using

                ' Insert sample data if tables are empty
                Dim insertSampleData As String = "
                    IF NOT EXISTS (SELECT * FROM [user_log])
                    INSERT INTO [user_log] (username, program, department) VALUES 
                    ('john_doe', 'Computer Science', 'Engineering'),
                    ('jane_smith', 'Business Administration', 'Business'),
                    ('mike_johnson', 'Psychology', 'Social Sciences');

                    IF NOT EXISTS (SELECT * FROM books1)
                    INSERT INTO books1 ([Title], [Author], [Genre]) VALUES 
                    ('The Great Gatsby', 'F. Scott Fitzgerald', 'Fiction'),
                    ('To Kill a Mockingbird', 'Harper Lee', 'Fiction'),
                    ('1984', 'George Orwell', 'Science Fiction');"

                Using cmd As New SqlCommand(insertSampleData, connection)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error creating database tables: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadData()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Count users
                Dim usersque As String = "SELECT COUNT(*) FROM [user_log]"
                Dim usersCommand As New SqlCommand(usersque, connection)
                Dim userCount As Integer = Convert.ToInt32(usersCommand.ExecuteScalar())

                ' Count books
                Dim booksque As String = "SELECT COUNT(*) FROM books1"
                Dim booksCommand As New SqlCommand(booksque, connection)
                Dim bookCount As Integer = Convert.ToInt32(booksCommand.ExecuteScalar())

                ' Update UI elements
                If total_books IsNot Nothing Then
                    total_books.Text = "Total Books: " & bookCount.ToString()
                End If

                If total_students IsNot Nothing Then
                    total_students.Text = "Total Students: " & userCount.ToString()
                End If

            End Using
        Catch ex As Exception
            ' Silent fail - don't show message box for timer updates
        End Try
    End Sub

    ' Method to refresh all child forms when needed
    Public Sub RefreshAllData()
        LoadData()
    End Sub

    Private Sub return_btn_Click(sender As Object, e As EventArgs) Handles return_btn.Click
        switchPanel(return_book)
    End Sub

    Private Sub borrow_btn_Click_1(sender As Object, e As EventArgs) Handles borrow_btn.Click
        switchPanel(borrow_book)
    End Sub
End Class