Public Class LoadingScreen

    Dim progress As Integer = 0
    Public LoggedStudentID As String
    Private Sub LoadingScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        FadeTimer.Start()
        ProgressBar1.Value = 0
        lblPercent.Text = "Loading... 0%"
    End Sub


    Private Sub FadeTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FadeTimer.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        Else
            FadeTimer.Stop()
            Timer1.Start()
        End If
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        progress += 5
        If progress > 100 Then progress = 100

        ProgressBar1.Value = progress
        lblPercent.Text = "Loading... " & progress & "%"

        If progress >= 100 Then
            Timer1.Stop()
            Dim newform As New LibraryAdmin()
            newform.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub SplashScreen_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles Me.Paint
        Dim g As Graphics = e.Graphics
        Dim rect As Rectangle = Me.ClientRectangle
        Dim brush As New Drawing2D.LinearGradientBrush(rect, Color.Wheat, Color.MistyRose, 30)
        g.FillRectangle(brush, rect)
    End Sub


End Class
