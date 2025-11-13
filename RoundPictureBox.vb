Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace library_system
    <DefaultEvent("Click")>
    Public Class RoundPictureBox
        Inherits UserControl
        Implements ISupportInitialize

        Private _borderRadius As Integer = 20
        Private _image As Image
        Private _sizeMode As PictureBoxSizeMode = PictureBoxSizeMode.StretchImage
        Private _isInitializing As Boolean = False

        <Category("Round Style")>
        Public Property BorderRadius As Integer
            Get
                Return _borderRadius
            End Get
            Set(value As Integer)
                _borderRadius = value
                If Not _isInitializing Then Me.Invalidate()
            End Set
        End Property

        <Category("Appearance")>
        Public Property Image As Image
            Get
                Return _image
            End Get
            Set(value As Image)
                _image = value
                If Not _isInitializing Then Me.Invalidate()
            End Set
        End Property

        <Category("Appearance")>
        Public Property SizeMode As PictureBoxSizeMode
            Get
                Return _sizeMode
            End Get
            Set(value As PictureBoxSizeMode)
                _sizeMode = value
                If Not _isInitializing Then Me.Invalidate()
            End Set
        End Property

        Public Sub New()
            MyBase.New()
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or
                       ControlStyles.UserPaint Or
                       ControlStyles.ResizeRedraw Or
                       ControlStyles.OptimizedDoubleBuffer, True)
            Me.BackColor = Color.Transparent
            Me.DoubleBuffered = True
        End Sub


        Public Sub BeginInit() Implements ISupportInitialize.BeginInit
            _isInitializing = True
        End Sub

        Public Sub EndInit() Implements ISupportInitialize.EndInit
            _isInitializing = False
            Me.Invalidate()
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            MyBase.OnPaint(e)

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality

            Dim rect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
            Using path As GraphicsPath = GetRoundPath(rect, _borderRadius)

                Me.Region = New Region(path)


                If _image IsNot Nothing Then
                    DrawImageWithSizeMode(e.Graphics, rect)
                Else
                    Using brush As New SolidBrush(Me.BackColor)
                        e.Graphics.FillPath(brush, path)
                    End Using
                End If
            End Using
        End Sub

        Private Sub DrawImageWithSizeMode(g As Graphics, destRect As Rectangle)
            Select Case _sizeMode
                Case PictureBoxSizeMode.StretchImage
                    g.DrawImage(_image, destRect)
                Case PictureBoxSizeMode.Zoom
                    DrawImageZoom(g, destRect)
                Case PictureBoxSizeMode.CenterImage
                    DrawImageCenter(g, destRect)
                Case PictureBoxSizeMode.Normal
                    g.DrawImage(_image, New Point(0, 0))
            End Select
        End Sub

        Private Sub DrawImageZoom(g As Graphics, destRect As Rectangle)
            Dim scaleX As Double = destRect.Width / _image.Width
            Dim scaleY As Double = destRect.Height / _image.Height
            Dim scale As Double = Math.Min(scaleX, scaleY)

            Dim scaledWidth As Integer = CInt(_image.Width * scale)
            Dim scaledHeight As Integer = CInt(_image.Height * scale)
            Dim x As Integer = (destRect.Width - scaledWidth) \ 2
            Dim y As Integer = (destRect.Height - scaledHeight) \ 2

            g.DrawImage(_image, x, y, scaledWidth, scaledHeight)
        End Sub

        Private Sub DrawImageCenter(g As Graphics, destRect As Rectangle)
            Dim x As Integer = (destRect.Width - _image.Width) \ 2
            Dim y As Integer = (destRect.Height - _image.Height) \ 2
            g.DrawImage(_image, x, y, _image.Width, _image.Height)
        End Sub

        Private Function GetRoundPath(rect As Rectangle, radius As Integer) As GraphicsPath
            Dim path As New GraphicsPath()
            Dim diameter As Integer = radius * 2


            If radius > rect.Width Then radius = rect.Width
            If radius > rect.Height Then radius = rect.Height

            path.StartFigure()
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90)
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90)
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90)
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90)
            path.CloseFigure()
            Return path
        End Function
    End Class
End Namespace