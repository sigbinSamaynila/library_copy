Imports Microsoft.Data.SqlClient

Public Class edit
    Private connectionString As String = "Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database=LibraryDB;"

    Private Sub edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateEditTable()
        LoadData()
    End Sub

    Private Sub CreateEditTable()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Create edit table if it doesn't exist
                Dim createTable As String = "
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='edit' AND xtype='U')
                    CREATE TABLE edit (
                        ID INT PRIMARY KEY IDENTITY(1,1),
                        TITLE NVARCHAR(100),
                        AUTHOR NVARCHAR(100),
                        GENRE NVARCHAR(50),
                        [DATE] DATE DEFAULT GETDATE()
                    );"

                Using cmd As New SqlCommand(createTable, connection)
                    cmd.ExecuteNonQuery()
                End Using

                ' Insert sample data if table is empty
                Dim insertData As String = "
                    IF NOT EXISTS (SELECT * FROM edit)
                    INSERT INTO edit (TITLE, AUTHOR, GENRE) VALUES 
                    ('The Great Gatsby', 'F. Scott Fitzgerald', 'Fiction'),
                    ('To Kill a Mockingbird', 'Harper Lee', 'Fiction'),
                    ('1984', 'George Orwell', 'Science Fiction'),
                    ('Pride and Prejudice', 'Jane Austen', 'Romance'),
                    ('The Hobbit', 'J.R.R. Tolkien', 'Fantasy');"

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
                Using adapter As New SqlDataAdapter("SELECT * FROM edit", connection)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    DataGridView1.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If String.IsNullOrWhiteSpace(title_txt.Text) OrElse String.IsNullOrWhiteSpace(author_txt.Text) Then
            MessageBox.Show("Please enter title and author!")
            Return
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO edit (TITLE, AUTHOR, GENRE) VALUES (@Title, @Author, @Genre)"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Title", title_txt.Text)
                    cmd.Parameters.AddWithValue("@Author", author_txt.Text)
                    cmd.Parameters.AddWithValue("@Genre", If(String.IsNullOrWhiteSpace(genre_txt.Text), DBNull.Value, genre_txt.Text))
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Book added successfully!")
            ClearFields()
            LoadData()

        Catch ex As Exception
            MessageBox.Show("Error adding book: " & ex.Message)
        End Try
    End Sub

    Private Sub upd_txt_Click(sender As Object, e As EventArgs) Handles upd_txt.Click
        If String.IsNullOrWhiteSpace(id_txt.Text) Then
            MessageBox.Show("Please enter an ID to update!")
            Return
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "UPDATE edit SET TITLE = @Title, AUTHOR = @Author, GENRE = @Genre WHERE ID = @ID"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@ID", id_txt.Text)
                    cmd.Parameters.AddWithValue("@Title", title_txt.Text)
                    cmd.Parameters.AddWithValue("@Author", author_txt.Text)
                    cmd.Parameters.AddWithValue("@Genre", If(String.IsNullOrWhiteSpace(genre_txt.Text), DBNull.Value, genre_txt.Text))
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Book updated successfully!")
                    Else
                        MessageBox.Show("No book found with that ID!")
                    End If
                End Using
            End Using

            ClearFields()
            LoadData()

        Catch ex As Exception
            MessageBox.Show("Error updating book: " & ex.Message)
        End Try
    End Sub

    Private Sub dlt_txt_Click(sender As Object, e As EventArgs) Handles dlt_txt.Click
        If String.IsNullOrWhiteSpace(id_txt.Text) Then
            MessageBox.Show("Please enter an ID to delete!")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "DELETE FROM edit WHERE ID = @ID"
                    Using cmd As New SqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@ID", id_txt.Text)
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Book deleted successfully!")
                        Else
                            MessageBox.Show("No book found with that ID!")
                        End If
                    End Using
                End Using

                ClearFields()
                LoadData()

            Catch ex As Exception
                MessageBox.Show("Error deleting book: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub find_txt_Click(sender As Object, e As EventArgs) Handles find_txt.Click
        If String.IsNullOrWhiteSpace(id_txt.Text) Then
            MessageBox.Show("Please enter an ID to search!")
            Return
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT * FROM edit WHERE ID = @ID"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@ID", id_txt.Text)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            title_txt.Text = reader("TITLE").ToString()
                            author_txt.Text = reader("AUTHOR").ToString()
                            genre_txt.Text = reader("GENRE").ToString()
                            MessageBox.Show("Book found!")
                        Else
                            MessageBox.Show("No book found with that ID!")
                            ClearFields()
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error searching for book: " & ex.Message)
        End Try
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        id_txt.Clear()
        title_txt.Clear()
        author_txt.Clear()
        genre_txt.Clear()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            id_txt.Text = row.Cells("IDDataGridViewTextBoxColumn").Value.ToString()
            title_txt.Text = row.Cells("TITLEDataGridViewTextBoxColumn").Value.ToString()
            author_txt.Text = row.Cells("AUTHORDataGridViewTextBoxColumn").Value.ToString()
            genre_txt.Text = row.Cells("GENREDataGridViewTextBoxColumn").Value.ToString()
        End If
    End Sub
End Class