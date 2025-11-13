Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class user
    Private connectionString As String = "Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database=LibraryDB;"

    Private Sub user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateUserTables()
        LoadUserData()

        ' Set up timer to refresh data every 5 seconds
        Timer1.Interval = 5000
        Timer1.Start()
    End Sub

    Private Sub CreateUserTables()
        Try
            Using connection As New SqlConnection("Server=(localdb)\MSSQLLocalDB;Integrated Security=true;")
                connection.Open()

                ' Create LibraryDB if it doesn't exist
                Dim createDb As String = "IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'LibraryDB') CREATE DATABASE LibraryDB;"
                Using cmd As New SqlCommand(createDb, connection)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Create user_log table
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim createTable As String = "
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='user_log' AND xtype='U')
                    CREATE TABLE [user_log] (
                        Id INT PRIMARY KEY IDENTITY(1,1),
                        Username NVARCHAR(100),
                        Program NVARCHAR(100),
                        Department NVARCHAR(100)
                    );"

                Using cmd As New SqlCommand(createTable, connection)
                    cmd.ExecuteNonQuery()
                End Using

                ' Insert sample data if table is empty
                Dim insertData As String = "
                    IF NOT EXISTS (SELECT * FROM [user_log])
                    INSERT INTO [user_log] (Username, Program, Department) VALUES 
                    ('john_doe', 'Computer Science', 'Engineering'),
                    ('jane_smith', 'Business Administration', 'Business'),
                    ('mike_johnson', 'Psychology', 'Social Sciences'),
                    ('sarah_wilson', 'Biology', 'Science'),
                    ('david_brown', 'Mathematics', 'Science');"

                Using cmd As New SqlCommand(insertData, connection)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error creating user tables: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadUserData()
        Try
            Using connection As New SqlConnection(connectionString)
                Using adapter As New SqlDataAdapter("SELECT Id, Username, Program, Department FROM [user_log] ORDER BY Id", connection)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    DataGridView1.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading user data: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If String.IsNullOrWhiteSpace(user_txt.Text) Then
            MessageBox.Show("Please enter a username!")
            Return
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO [user_log] (Username, Program, Department) VALUES (@Username, @Program, @Department)"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Username", user_txt.Text)
                    cmd.Parameters.AddWithValue("@Program", If(String.IsNullOrWhiteSpace(program_txt.Text), DBNull.Value, program_txt.Text))
                    cmd.Parameters.AddWithValue("@Department", If(String.IsNullOrWhiteSpace(department_txt.Text), DBNull.Value, department_txt.Text))
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("User added successfully!")
            ClearFields()
            LoadUserData()

        Catch ex As Exception
            MessageBox.Show("Error adding user: " & ex.Message)
        End Try
    End Sub

    Private Sub find_txt_Click(sender As Object, e As EventArgs) Handles find_txt.Click
        If String.IsNullOrWhiteSpace(id_txt.Text) Then
            MessageBox.Show("Please enter a User ID to search!")
            Return
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT * FROM [user_log] WHERE Id = @Id"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Id", id_txt.Text)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            user_txt.Text = reader("Username").ToString()
                            program_txt.Text = reader("Program").ToString()
                            department_txt.Text = reader("Department").ToString()
                            MessageBox.Show("User found!")
                        Else
                            MessageBox.Show("User not found!")
                            ClearFields()
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error searching for user: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If String.IsNullOrWhiteSpace(id_txt.Text) Then
            MessageBox.Show("Please enter a User ID to update!")
            Return
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "UPDATE [user_log] SET Username = @Username, Program = @Program, Department = @Department WHERE Id = @Id"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Id", id_txt.Text)
                    cmd.Parameters.AddWithValue("@Username", user_txt.Text)
                    cmd.Parameters.AddWithValue("@Program", If(String.IsNullOrWhiteSpace(program_txt.Text), DBNull.Value, program_txt.Text))
                    cmd.Parameters.AddWithValue("@Department", If(String.IsNullOrWhiteSpace(department_txt.Text), DBNull.Value, department_txt.Text))
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("User updated successfully!")
                    Else
                        MessageBox.Show("No user found with that ID!")
                    End If
                End Using
            End Using

            ClearFields()
            LoadUserData()

        Catch ex As Exception
            MessageBox.Show("Error updating user: " & ex.Message)
        End Try
    End Sub

    Private Sub dlt_btn_Click(sender As Object, e As EventArgs) Handles dlt_btn.Click
        If String.IsNullOrWhiteSpace(id_txt.Text) Then
            MessageBox.Show("Please enter a User ID to delete!")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "DELETE FROM [user_log] WHERE Id = @Id"
                    Using cmd As New SqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@Id", id_txt.Text)
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("User deleted successfully!")
                        Else
                            MessageBox.Show("No user found with that ID!")
                        End If
                    End Using
                End Using

                ClearFields()
                LoadUserData()

            Catch ex As Exception
                MessageBox.Show("Error deleting user: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        ClearFields()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        LoadUserData()
        MessageBox.Show("Data refreshed!")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadUserData()
    End Sub

    Private Sub ClearFields()
        id_txt.Clear()
        user_txt.Clear()
        program_txt.Clear()
        department_txt.Clear()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            id_txt.Text = row.Cells("Id").Value.ToString()
            user_txt.Text = row.Cells("Username").Value.ToString()
            program_txt.Text = row.Cells("Program").Value.ToString()
            department_txt.Text = row.Cells("Department").Value.ToString()
        End If
    End Sub
End Class