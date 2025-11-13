Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

Namespace library_system
    Public Class ModernButton
        Inherits Button


        Private _borderColor As Color = Color.MediumSlateBlue
        Private _borderSize As Integer = 2
        Private _borderRadius As Integer = 20
        Private _backgroundColor As Color = Color.MediumSlateBlue
        Private _textColor As Color = Color.White
        Private _hoverColor As Color = Color.DarkSlateBlue
        Private _isHovering As Boolean = False

        Public Sub New()
            MyBase.New()
            Me.FlatStyle = FlatStyle.Flat
            Me.FlatAppearance.BorderSize = 0
            Me.BackColor = _backgroundColor
            Me.ForeColor = _textColor
            Me.SetStyle(ControlStyles.StandardClick Or ControlStyles.StandardDoubleClick, False)
        End Sub

        <Category("Modern Style")>
        Public Property BorderColor As Color
            Get
                Return _borderColor
            End Get
            Set(value As Color)
                _borderColor = value
                Me.Invalidate()
            End Set
        End Property

        <Category("Modern Style")>
        Public Property BorderSize As Integer
            Get
                Return _borderSize
            End Get
            Set(value As Integer)
                _borderSize = value
                Me.Invalidate()
            End Set
        End Property

        <Category("Modern Style")>
        Public Property BorderRadius As Integer
            Get
                Return _borderRadius
            End Get
            Set(value As Integer)
                _borderRadius = value
                Me.Invalidate()
            End Set
        End Property

        <Category("Modern Style")>
        Public Property BackgroundColor As Color
            Get
                Return _backgroundColor
            End Get
            Set(value As Color)
                _backgroundColor = value
                If Not _isHovering Then
                    Me.BackColor = value
                End If
                Me.Invalidate()
            End Set
        End Property

        <Category("Modern Style")>
        Public Property TextColor As Color
            Get
                Return _textColor
            End Get
            Set(value As Color)
                _textColor = value
                Me.ForeColor = value
                Me.Invalidate()
            End Set
        End Property

        <Category("Modern Style")>
        Public Property HoverColor As Color
            Get
                Return _hoverColor
            End Get
            Set(value As Color)
                _hoverColor = value
                Me.Invalidate()
            End Set
        End Property

        Protected Overrides Sub OnMouseEnter(e As EventArgs)
            MyBase.OnMouseEnter(e)
            _isHovering = True
            Me.BackColor = _hoverColor
            Me.Invalidate()
        End Sub

        Protected Overrides Sub OnMouseLeave(e As EventArgs)
            MyBase.OnMouseLeave(e)
            _isHovering = False
            Me.BackColor = _backgroundColor
            Me.Invalidate()
        End Sub

        Protected Overrides Sub OnPaint(pe As PaintEventArgs)
            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias


            pe.Graphics.Clear(If(Me.Parent IsNot Nothing, Me.Parent.BackColor, SystemColors.Control))


            Dim rect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
            Using path As GraphicsPath = GetRoundPath(rect, _borderRadius)

                Using brush As New SolidBrush(Me.BackColor)
                    pe.Graphics.FillPath(brush, path)
                End Using


                Using pen As New Pen(_borderColor, _borderSize)
                    pe.Graphics.DrawPath(pen, path)
                End Using
            End Using


            Dim sf As New StringFormat() With {
        .Alignment = StringAlignment.Center,
        .LineAlignment = StringAlignment.Center
    }
            Using brush As New SolidBrush(Me.ForeColor)
                pe.Graphics.DrawString(Me.Text, Me.Font, brush, rect, sf)
            End Using
        End Sub



        Private Function GetRoundPath(rect As Rectangle, radius As Integer) As GraphicsPath
            Dim path As New GraphicsPath()
            Dim r As Integer = radius * 2
            path.StartFigure()
            path.AddArc(rect.X, rect.Y, r, r, 180, 90)
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90)
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90)
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90)
            path.CloseFigure()
            Return path
        End Function
    End Class
End Namespace
