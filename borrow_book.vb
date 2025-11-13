Imports Microsoft.Data.SqlClient
Imports Microsoft.Identity.Client.Platforms.Shared

Public Class borrow_book

    Dim connectionString As String = "Data Source=DESKTOP-9R7NK8N;Initial Catalog=books;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;"

    Private Sub borrow_book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBooksData()
    End Sub

    Private Sub LoadBooksData()
        ' ✅ Connection string that matches your SSMS database:
        Dim connectionString As String = "Data Source=DESKTOP-9R7NK8N;Initial Catalog=books;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;"

        Try
            Using connection As New SqlConnection(connectionString)
                ' ✅ Query to match your table
                Dim query As String = "SELECT [Book Id], Title, Author, Genre, [Date Added] FROM dbo.books1"

                Using adapter As New SqlDataAdapter(query, connection)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    DataGridView1.DataSource = table
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading books data: " & ex.Message)
        End Try
    End Sub
End Class
