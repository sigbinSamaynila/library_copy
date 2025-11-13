Imports System.Data.SqlClient

Public Class login

    Dim connectionString As String = "Data Source=DESKTOP-G19RU13\SQLEXPRESS;Initial Catalog=Library System Management;Integrated Security=True"


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
    End Sub


    Private Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        Dim user = Trim(txtUsername.TextValue)
        Dim pass = Trim(txtPassword.TextValue)

        If user = "" Or pass = "" Then
            MsgBox("Please enter your Student ID and Password.", MsgBoxStyle.Exclamation, "Missing Fields")
            Exit Sub
        End If

        If LCase(user) = "admin" And pass = "1234" Then
            Dim adminForm As New LoadingScreen
            adminForm.LoggedStudentID = "admin"
            adminForm.Show
            Hide
            Exit Sub
        End If


        Dim studentID As Integer

        If Not IsNumeric(user) Then
            MsgBox("Student ID must be a number (e.g., 2025001).", MsgBoxStyle.Exclamation, "Invalid Input")
            Exit Sub
        Else
            studentID = CInt(user)
        End If


        Dim conn As New SqlConnection(connectionString)
        Try
            conn.Open


            Dim checkIDQuery = "SELECT COUNT(*) FROM Student WHERE StudentID = @StudentID"
            Dim cmd As New SqlCommand(checkIDQuery, conn)
            cmd.Parameters.AddWithValue("@StudentID", studentID)

            Dim idExists = Convert.ToInt32(cmd.ExecuteScalar)

            If idExists > 0 Then

                Dim checkPassQuery = "SELECT COUNT(*) FROM Student WHERE StudentID = @StudentID AND Password = @Password"
                Dim cmdPass As New SqlCommand(checkPassQuery, conn)
                cmdPass.Parameters.AddWithValue("@StudentID", studentID)
                cmdPass.Parameters.AddWithValue("@Password", pass)

                Dim passCorrect = Convert.ToInt32(cmdPass.ExecuteScalar)

                If passCorrect > 0 Then

                    Dim nextForm As New LoadingScreen
                    nextForm.LoggedStudentID = studentID.ToString
                    nextForm.Show
                    Hide
                Else
                    MsgBox("Wrong Password. Please try again.", MsgBoxStyle.Exclamation, "Login Failed")
                End If
            Else
                MsgBox("Student ID not found. Please check your ID.", MsgBoxStyle.Exclamation, "Login Failed")
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            conn.Close
        End Try
    End Sub

End Class
