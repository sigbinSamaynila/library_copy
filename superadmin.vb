Imports Microsoft.Data.SqlClient

Public Class superadmin
    Private connectionString As String = "Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database=LibraryDB;"

    Private Sub superadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboardData()
    End Sub

    Private Sub LoadDashboardData()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Count total students
                Dim usersQuery As String = "SELECT COUNT(*) FROM [user_log]"
                Using usersCmd As New SqlCommand(usersQuery, connection)
                    Dim userCount As Integer = Convert.ToInt32(usersCmd.ExecuteScalar())
                    total_students.Text = "Students: " & userCount.ToString()
                End Using

                ' Count total books
                Dim booksQuery As String = "SELECT COUNT(*) FROM books1"
                Using booksCmd As New SqlCommand(booksQuery, connection)
                    Dim bookCount As Integer = Convert.ToInt32(booksCmd.ExecuteScalar())
                    total_books.Text = "Books: " & bookCount.ToString()
                End Using

                ' Count borrowed books
                Dim borrowedQuery As String = "SELECT COUNT(*) FROM inventory WHERE [Borrowed] = 'Yes'"
                Using borrowedCmd As New SqlCommand(borrowedQuery, connection)
                    Dim borrowedCount As Integer = Convert.ToInt32(borrowedCmd.ExecuteScalar())
                    lbl_borrowed_count.Text = borrowedCount.ToString()
                End Using

                ' Count available books
                Dim availableQuery As String = "SELECT COUNT(*) FROM inventory WHERE [Borrowed] = 'No'"
                Using availableCmd As New SqlCommand(availableQuery, connection)
                    Dim availableCount As Integer = Convert.ToInt32(availableCmd.ExecuteScalar())
                    lbl_available_count.Text = availableCount.ToString()
                End Using

            End Using
        Catch ex As Exception
            ' Silent error handling for dashboard
        End Try
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        LoadDashboardData()
    End Sub
End Class