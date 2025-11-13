Imports Microsoft.Data.SqlClient
Imports System.IO

Public Class inventory
    Private connectionString As String = "Data Source=DESKTOP-9R7NK8N;Initial Catalog=books;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"

    Private Sub inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateInventoryTable()
        LoadInventoryData()
        UpdateStatistics()
    End Sub

    Private Sub CreateInventoryTable()
        Try
            Using connection As New SqlConnection("Data Source=DESKTOP-9R7NK8N;Initial Catalog=books;Integrated Security=True;Encrypt=True;Trust Server Certificate=True")
                connection.Open()

                ' Create LibraryDB if it doesn't exist
                Dim createDb As String = "IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'LibraryDB') CREATE DATABASE LibraryDB;"
                Using cmd As New SqlCommand(createDb, connection)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Create inventory table
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim createTable As String = "
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='inventory' AND xtype='U')
                    CREATE TABLE inventory (
                        [Book Id] INT PRIMARY KEY IDENTITY(1,1),
                        [Title] NVARCHAR(100),
                        [Author] NVARCHAR(100),
                        [Genre] NVARCHAR(50),
                        [Borrowed] NVARCHAR(3) DEFAULT 'No',
                        [Return On] DATE NULL
                    );"

                Using cmd As New SqlCommand(createTable, connection)
                    cmd.ExecuteNonQuery()
                End Using

                ' Insert sample data if table is empty
                Dim insertData As String = "
                    IF NOT EXISTS (SELECT * FROM inventory)
                    INSERT INTO inventory ([Title], [Author], [Genre], [Borrowed], [Return On]) VALUES 
                    ('The Great Gatsby', 'F. Scott Fitzgerald', 'Fiction', 'No', NULL),
                    ('To Kill a Mockingbird', 'Harper Lee', 'Fiction', 'Yes', '2024-02-15'),
                    ('1984', 'George Orwell', 'Science Fiction', 'No', NULL),
                    ('Pride and Prejudice', 'Jane Austen', 'Romance', 'Yes', '2024-02-20'),
                    ('The Hobbit', 'J.R.R. Tolkien', 'Fantasy', 'No', NULL),
                    ('The Catcher in the Rye', 'J.D. Salinger', 'Fiction', 'Yes', '2024-02-18');"

                Using cmd As New SqlCommand(insertData, connection)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error creating inventory table: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadInventoryData()
        Try
            Using connection As New SqlConnection(connectionString)
                Using adapter As New SqlDataAdapter("SELECT [Title], [Author], [Genre], [Borrowed], [Return On] FROM inventory", connection)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    DataGridView1.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading inventory data: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateStatistics()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Total books
                Dim totalQuery As String = "SELECT COUNT(*) FROM inventory"
                Using cmd As New SqlCommand(totalQuery, connection)
                    lbl_total_books.Text = cmd.ExecuteScalar().ToString()
                End Using

                ' Borrowed books
                Dim borrowedQuery As String = "SELECT COUNT(*) FROM inventory WHERE [Borrowed] = 'Yes'"
                Using cmd As New SqlCommand(borrowedQuery, connection)
                    lbl_borrowed_books.Text = cmd.ExecuteScalar().ToString()
                End Using

                ' Available books
                Dim availableQuery As String = "SELECT COUNT(*) FROM inventory WHERE [Borrowed] = 'No'"
                Using cmd As New SqlCommand(availableQuery, connection)
                    lbl_available_books.Text = cmd.ExecuteScalar().ToString()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating statistics: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        LoadInventoryData()
        UpdateStatistics()
        MessageBox.Show("Inventory refreshed successfully!")
    End Sub

    Private Sub btn_generate_report_Click(sender As Object, e As EventArgs) Handles btn_generate_report.Click
        GenerateInventoryReport()
    End Sub

    Private Sub GenerateInventoryReport()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Get all inventory data
                Dim query As String = "SELECT [Title], [Author], [Genre], [Borrowed], [Return On] FROM inventory ORDER BY [Title]"
                Using adapter As New SqlDataAdapter(query, connection)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    ' Create report content
                    Dim reportContent As New System.Text.StringBuilder()
                    reportContent.AppendLine("LIBRARY INVENTORY REPORT")
                    reportContent.AppendLine("Generated on: " & DateTime.Now.ToString())
                    reportContent.AppendLine("=" & StrDup(50, "="))
                    reportContent.AppendLine()

                    ' Add statistics
                    reportContent.AppendLine("STATISTICS:")
                    reportContent.AppendLine("Total Books: " & lbl_total_books.Text)
                    reportContent.AppendLine("Borrowed Books: " & lbl_borrowed_books.Text)
                    reportContent.AppendLine("Available Books: " & lbl_available_books.Text)
                    reportContent.AppendLine()

                    ' Add book details
                    reportContent.AppendLine("BOOK DETAILS:")
                    reportContent.AppendLine(String.Format("{0,-30} {1,-20} {2,-15} {3,-10} {4,-12}",
                                                         "Title", "Author", "Genre", "Borrowed", "Return Date"))
                    reportContent.AppendLine(StrDup(90, "-"))

                    For Each row As DataRow In table.Rows
                        Dim returnDate As String = If(row("Return On") Is DBNull.Value, "N/A", Convert.ToDateTime(row("Return On")).ToString("yyyy-MM-dd"))
                        reportContent.AppendLine(String.Format("{0,-30} {1,-20} {2,-15} {3,-10} {4,-12}",
                                                             row("Title").ToString(),
                                                             row("Author").ToString(),
                                                             row("Genre").ToString(),
                                                             row("Borrowed").ToString(),
                                                             row("Return On").ToString(),
                                                             returnDate))
                    Next

                    ' Save report to file
                    Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                    Dim filePath As String = Path.Combine(desktopPath, "Library_Inventory_Report_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".txt")

                    File.WriteAllText(filePath, reportContent.ToString())
                    MessageBox.Show("Inventory report generated successfully!" & vbCrLf & "Saved to: " & filePath)

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating report: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = DataGridView1.Columns("BorrowedDataGridViewTextBoxColumn").Index Then
            If e.Value IsNot Nothing AndAlso e.Value.ToString() = "Yes" Then
                e.CellStyle.BackColor = Color.LightCoral
                e.CellStyle.ForeColor = Color.DarkRed
            Else
                e.CellStyle.BackColor = Color.LightGreen
                e.CellStyle.ForeColor = Color.DarkGreen
            End If
        End If

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = DataGridView1.Columns("ReturnOnDataGridViewTextBoxColumn").Index Then
            If e.Value IsNot Nothing AndAlso e.Value IsNot DBNull.Value Then
                Dim returnDate As DateTime = Convert.ToDateTime(e.Value)
                If returnDate < DateTime.Now Then
                    e.CellStyle.BackColor = Color.Orange
                    e.CellStyle.ForeColor = Color.DarkOrange
                End If
            End If
        End If
    End Sub
End Class