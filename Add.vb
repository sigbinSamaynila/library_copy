Imports Microsoft.Data.SqlClient
Imports System.Data


Public Class Add

    ' ✅ Fixed: Removed extra parenthesis, added proper connection declaration
    Dim connectionString As String = "Data Source=DESKTOP-G19RU13\SQLEXPRESS;Initial Catalog=books;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    Private Sub add_button_Click(sender As Object, e As EventArgs) Handles add_button.Click

        ' ✅ Added proper connection reference
        Dim command As New SqlCommand("INSERT INTO table3 (Title, Author, Published, Genre) VALUES (@Title, @Author, @Published, @Genre)", connection)

        ' ✅ Open the connection
        connection.Open()

        ' ✅ Validation checks
        If (title.Text.Length = 0 AndAlso author.Text.Length = 0 AndAlso genres.Text.Length = 0) Then
            MessageBox.Show("Please fill all the fields")
        ElseIf (title.Text.Length = 0) Then
            MessageBox.Show("Enter a title")
        ElseIf (author.Text.Length = 0) Then
            MessageBox.Show("Enter an author")
        ElseIf (genres.Text.Length = 0) Then
            MessageBox.Show("Enter a genre")
        ElseIf (title.TextLength < 50 AndAlso author.TextLength < 50 AndAlso genres.TextLength < 50) Then

            ' ✅ Added parameters before executing
            command.Parameters.AddWithValue("@Title", title.Text)
            command.Parameters.AddWithValue("@Author", author.Text)
            command.Parameters.AddWithValue("@Published", Date.Now)
            command.Parameters.AddWithValue("@Genre", genres.Text)

            command.ExecuteNonQuery()
            MessageBox.Show("Book Added")
        Else
            MessageBox.Show("Try Again")
        End If

        connection.Close()
    End Sub

    Public Sub que(ByVal query As String)
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@Title", title.Text)
        command.Parameters.AddWithValue("@Author", author.Text)
        command.Parameters.AddWithValue("@Published", Date.Now)
        command.Parameters.AddWithValue("@Genre", genres.Text)

        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub clear_button_Click(sender As Object, e As EventArgs) Handles clear_button.Click
        title.Text = ""
        author.Text = ""
        genres.Text = ""
    End Sub

End Class
