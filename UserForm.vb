Imports System.Data.SqlClient

Public Class UserForm

    Dim connectionString As String = "Data Source=DESKTOP-G19RU13\SQLEXPRESS;Initial Catalog=Library System Management;Integrated Security=True"

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim sname As String = txtName.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim program As String = txtProgram.Text.Trim()

        ' Validation
        If sname = "" Or email = "" Or txtAge.Text = "" Or txtYear.Text = "" Or program = "" Then
            MessageBox.Show("Please fill in all fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim age As Integer
        Dim year As Integer

        If Not Integer.TryParse(txtAge.Text, age) Then
            MessageBox.Show("Please enter a valid number for Age.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not Integer.TryParse(txtYear.Text, year) Then
            MessageBox.Show("Please enter a valid number for Year.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim defaultPassword As String = "123"

        ' NOTE: single-line SQL to avoid VB multiline literal issues
        Dim query As String = "INSERT INTO [dbo].[Student] (Name, Email, Age, Year, Program, Password) " & _
                              "VALUES (@Name, @Email, @Age, @Year, @Program, @Password); SELECT SCOPE_IDENTITY();"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Name", sname)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@Age", age)
                cmd.Parameters.AddWithValue("@Year", year)
                cmd.Parameters.AddWithValue("@Program", program)
                cmd.Parameters.AddWithValue("@Password", defaultPassword)

                Try
                    conn.Open()

                    Dim obj As Object = cmd.ExecuteScalar()

                    If obj Is Nothing OrElse obj Is DBNull.Value Then
                        MessageBox.Show("Insert succeeded but could not retrieve new StudentID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        ' SCOPE_IDENTITY() returns numeric/decimal — convert safely
                        Dim newID As Integer = Convert.ToInt32(Convert.ToDecimal(obj))

                        MessageBox.Show("Student added successfully!" & vbCrLf & _
                                        "Student ID (Username): " & newID.ToString() & vbCrLf & _
                                        "Default Password: 123", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        txtName.Clear()
                        txtEmail.Clear()
                        txtAge.Clear()
                        txtYear.Clear()
                        txtProgram.Clear()
                    End If

                Catch ex As SqlException
                    ' Show SQL-specific error number/message
                    MessageBox.Show("SQL error (" & ex.Number & "): " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As Exception
                    ' General exception
                    MessageBox.Show("Error saving student: " & ex.Message & vbCrLf & "StackTrace: " & ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
