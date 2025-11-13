Imports System.Data.SqlClient

Public Class log
    Private Sub btn_log_Click(sender As Object, e As EventArgs) Handles btn_log.Click

        Dim connection As New SqlConnection("Data Source=DESKTOP-9R7NK8N;Initial Catalog=books;Integrated Security=True")
        Dim command As New SqlCommand("", connection)
        Dim adp As New SqlDataAdapter(command)


    End Sub
End Class
