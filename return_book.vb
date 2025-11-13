Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class return_book
    Private connectionString As String = "Data Source=DESKTOP-9R7NK8N;Initial Catalog=books;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"

    Private Sub return_book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateBooksTable()
        LoadData()
    End Sub

    Private Sub CreateBooksTable()
        Try
            Using connection As New SqlConnection("Data Source=DESKTOP-9R7NK8N;Initial Catalog=books;Integrated Security=True;Encrypt=True;Trust Server Certificate=True")
                connection.Open()

                ' Create LibraryDB if it doesn't exist
                Dim createDb As String = "IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'LibraryDB') CREATE DATABASE LibraryDB;"
                Using cmd As New SqlCommand(createDb, connection)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Create books1 table
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim createTable As String = "
                    IF NOT EXISTS (SELECT * FROM inventory1 WHERE Book_Id='Book_Id')
                    CREATE TABLE books1 (
                        [Book Id] ,
                        [Title],
                        [Author] ,
                        [Genre] ,
                        [Date Added]
                    );"

                Using cmd As New SqlCommand(createTable, connection)
                    cmd.ExecuteNonQuery()
                End Using

                ' Create inventory table for tracking borrowed books
                Dim createInventoryTable As String = "   IF NOT EXISTS (SELECT * FROM books1 WHERE name='inventory1' AND xtype='U')
                    CREATE TABLE inventory (id, Title, Author, Genre, Borrowed, [Return On] );"


                Using cmd As New SqlCommand(createInventoryTable, connection)
                    cmd.ExecuteNonQuery()
                End Using

                ' Insert sample data if table is empty
                Dim insertData As String = " IF NOT EXISTS (SELECT * FROM books1)
                    INSERT INTO books1 ([Title], [Author], [Genre]) VALUES 
                    (Title, Author, Genre)

                    IF NOT EXISTS (SELECT * FROM inventory)
                    INSERT INTO inventory ([Id], [Title], [Author], [Genre], [Borrowed]) VALUES 
                    (Id, Title, Author, Genre, Borrowed, Return On);"


                Using cmd As New SqlCommand(insertData, connection)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error creating table: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadData()
        Try
            Using connection As New SqlConnection(connectionString)
                Using adapter As New SqlDataAdapter("SELECT [Book Id], Title, Author, Genre, [Date Added] FROM books1", connection)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    DataGridView1.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        If String.IsNullOrWhiteSpace(txt_book_id.Text) Then
            MessageBox.Show("Please enter a Book ID!")
            Return
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Check if book exists in books1 table
                Dim checkQuery As String = "SELECT COUNT(*) FROM books1 WHERE [Id] = @Id"
                Using checkCmd As New SqlCommand(checkQuery, connection)
                    checkCmd.Parameters.AddWithValue("@Id", txt_book_id.Text)
                    Dim bookExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If bookExists = 0 Then
                        MessageBox.Show("Book ID not found!")
                        Return
                    End If
                End Using

                ' Update inventory to mark book as returned
                Dim updateQuery As String = "UPDATE inventory SET [Borrowed] = 'No', [Return On] = NULL WHERE [Id] = @Id"
                Using updateCmd As New SqlCommand(updateQuery, connection)
                    updateCmd.Parameters.AddWithValue("@Id", txt_book_id.Text)
                    Dim rowsAffected As Integer = updateCmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Book returned successfully!")
                    Else
                        ' Book exists but not in inventory, add it
                        Dim insertQuery As String = "INSERT INTO inventory ([Id], [Title], [Author], [Genre], [Borrowed]) 
                                                   SELECT [Book Id], [Title], [Author], [Genre], 'No' 
                                                   FROM books1 WHERE [Book Id] = @BookId"
                        Using insertCmd As New SqlCommand(insertQuery, connection)
                            insertCmd.Parameters.AddWithValue("@Id", txt_book_id.Text)
                            insertCmd.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Book added to inventory as available!")
                    End If
                End Using
            End Using

            ClearFields()
            LoadData()

        Catch ex As Exception
            MessageBox.Show("Error returning book: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_find_Click(sender As Object, e As EventArgs) Handles btn_find.Click
        If String.IsNullOrWhiteSpace(txt_book_id.Text) Then
            MessageBox.Show("Please enter a Book ID!")
            Return
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT [Book Id], Title, Author, Genre FROM books1 WHERE [Book Id] = @BookId"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@BookId", txt_book_id.Text)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            lbl_book_title.Text = "Title: " & reader("Title").ToString()
                            lbl_book_author.Text = "Author: " & reader("Author").ToString()
                            lbl_book_genre.Text = "Genre: " & reader("Genre").ToString()
                            MessageBox.Show("Book found!")
                        Else
                            MessageBox.Show("Book not found!")
                            ClearBookInfo()
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error searching for book: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        ClearFields()
        ClearBookInfo()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        LoadData()
        MessageBox.Show("Data refreshed!")
    End Sub

    Private Sub ClearFields()
        txt_book_id.Clear()
    End Sub

    Private Sub ClearBookInfo()
        lbl_book_title.Text = "Title: "
        lbl_book_author.Text = "Author: "
        lbl_book_genre.Text = "Genre: "
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txt_book_id.Text = row.Cells("Book Id").Value.ToString()
            lbl_book_title.Text = "Title: " & row.Cells("Title").Value.ToString()
            lbl_book_author.Text = "Author: " & row.Cells("Author").Value.ToString()
            lbl_book_genre.Text = "Genre: " & row.Cells("Genre").Value.ToString()
        End If
    End Sub
End Class