Imports Microsoft.Data.SqlClient

Public Class books
    Private Sub books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateDatabaseAndTable()
        LoadBooksData()
    End Sub

    Private Sub CreateDatabaseAndTable()
        Dim masterConnectionString As String = "Server=(localdb)\MSSQLLocalDB;Integrated Security=true;"

        Try
            Using connection As New SqlConnection(masterConnectionString)
                connection.Open()

                ' Create database
                Dim createDb As String = "IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'LibraryDB') CREATE DATABASE LibraryDB;"
                Using cmd As New SqlCommand(createDb, connection)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Now create table in LibraryDB
            Dim libraryConnectionString As String = "Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database=LibraryDB;"
            Using connection As New SqlConnection(libraryConnectionString)
                connection.Open()

                Dim createTable As String = "
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='final1' AND xtype='U')
                    CREATE TABLE final1 (
                        Id INT PRIMARY KEY IDENTITY(1,1),
                        title NVARCHAR(100),
                        author NVARCHAR(100),
                        genre NVARCHAR(50)
                    );"

                Using cmd As New SqlCommand(createTable, connection)
                    cmd.ExecuteNonQuery()
                End Using

                ' Insert sample data if table is empty
                Dim insertData As String = "
                    IF NOT EXISTS (SELECT * FROM final1)
                    INSERT INTO final1 (title, author, genre) VALUES 
                    ('The Great Gatsby', 'F. Scott Fitzgerald', 'Fiction'),
                    ('To Kill a Mockingbird', 'Harper Lee', 'Fiction'),
                    ('1984', 'George Orwell', 'Science Fiction');"

                Using cmd As New SqlCommand(insertData, connection)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error creating database: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadBooksData()
        Dim connectionString As String = "Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database=LibraryDB;"

        Try
            Using connection As New SqlConnection(connectionString)
                Using adapter As New SqlDataAdapter("SELECT * FROM final1", connection)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    DataGridView1.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub
End Class