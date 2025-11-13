Imports System.Data.SqlClient

Public Class ChangePass

    ' Get connection string
    Dim connectionString As String = "Data Source=DESKTOP-G19RU13\SQLEXPRESS;Initial Catalog=Library System Management;Integrated Security=True"

    ' Store logged-in StudentID (you will pass this from login form)
    Public StudentID As String

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim currentPass As String = Trim(txtCurrentPassword.TextValue)
        Dim newPass As String = Trim(txtNewPassword.TextValue)
        Dim confirmPass As String = Trim(txtConfirmPassword.TextValue)

        ' Check empty fields
        If currentPass = "" Or newPass = "" Or confirmPass = "" Then
            MsgBox("Please fill out all fields.", MsgBoxStyle.Exclamation, "Missing Information")
            Exit Sub
        End If

        ' Confirm passwords match
        If newPass <> confirmPass Then
            MsgBox("New passwords do not match.", MsgBoxStyle.Exclamation, "Mismatch")
            Exit Sub
        End If

        Using conn As New SqlConnection(connectionString)
            conn.Open()

            ' 1️⃣ Check if current password is correct
            Dim checkQuery As String = "SELECT COUNT(*) FROM Student WHERE StudentID = @StudentID AND Password = @Password"
            Using checkCmd As New SqlCommand(checkQuery, conn)
                checkCmd.Parameters.AddWithValue("@StudentID", StudentID)
                checkCmd.Parameters.AddWithValue("@Password", currentPass)

                Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If count = 0 Then
                    MsgBox("Current password is incorrect.", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If
            End Using

            ' 2️⃣ Update password
            Dim updateQuery As String = "UPDATE Student SET Password = @NewPassword WHERE StudentID = @StudentID"
            Using updateCmd As New SqlCommand(updateQuery, conn)
                updateCmd.Parameters.AddWithValue("@NewPassword", newPass)
                updateCmd.Parameters.AddWithValue("@StudentID", StudentID)
                updateCmd.ExecuteNonQuery()
            End Using

            MsgBox("Password changed successfully!", MsgBoxStyle.Information, "Success")
            Me.Close()
        End Using
    End Sub

End Class