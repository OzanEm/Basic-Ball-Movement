Public Class Form1


    Dim IntSpeed As Double 'Speed entered
    Dim xDelta As Double 'Speed
    Dim yDelta As Double ' '' 
    Dim AngleO As Double ' Angle

    Dim OriginalHeight As Double 'Relative position
    Dim OriginalWidth As Double ' Relative position

    Dim NewX As Int32 'New x for ball
    Dim NewY As Int32 ' New y for ball

    Dim Xc As Int32 'Ball center coordinates
    Dim Xy As Int32 ' '' 
    Dim iXSize As Int32 'Client Dimension
    Dim iYSize As Int32

    'Rect variables
    Dim RectBall As Rectangle ' Ball itself
    Dim myGraphics As Graphics ' Graph object for drawing


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'This is where motion happens
        If RectBall.Y < 10 Then '10 is used for buffer so it looks neat
            RectBall.Y = 10
            yDelta = -yDelta



        End If

        If RectBall.Y > Me.ClientRectangle.Height - RectBall.Height - 10 Then
            RectBall.Y = Me.ClientRectangle.Height - RectBall.Height - 10
            yDelta = -yDelta

        End If

        If RectBall.X < 10 Then
            RectBall.X = 10
            xDelta = -xDelta

        End If

        If RectBall.X > Me.ClientRectangle.Width - RectBall.Width - 10 Then
            RectBall.X = Me.ClientRectangle.Width - RectBall.Width - 10
            xDelta = -xDelta

        End If

        'Speed is determined now is added to the x , y

        NewX += xDelta
        NewY += yDelta
        Invalidate() 'Paint is called at the end after new position is calculated

    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        If xDelta = 0 Then
            xDelta = 10
        End If
        If yDelta = 0 Then
            yDelta = 10
        End If
        'Default speed can be changed 
        Timer1.Enabled = True

    End Sub

    Private Sub Ball_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Speed_Click(sender As Object, e As EventArgs) Handles Speed.Click
        IntSpeed = Convert.ToDouble(SpeedBox.Text)
        xDelta = IntSpeed * Math.Cos(AngleO) 'Getting speed from the user
        yDelta = IntSpeed * Math.Sin(AngleO) 'if no angle is selected zero will be the angle
        'Motion will happen in one dimension for zero
        Timer1.Enabled = True

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DrawBall()
        'Ball is created at load
    End Sub

    Private Sub Stp_Click(sender As Object, e As EventArgs) Handles Stp.Click
        Timer1.Enabled = False
        'Stops


    End Sub

    Private Sub Angle_Click(sender As Object, e As EventArgs) Handles Angle.Click
        AngleO = Convert.ToDouble(AngleBox.Text) 'Angle is applied to the speed
        xDelta = xDelta * Math.Cos(AngleO)
        yDelta = yDelta * Math.Sin(AngleO)
    End Sub

    Private Sub AngleBox_TextChanged(sender As Object, e As EventArgs) Handles AngleBox.TextChanged

    End Sub

    Public Sub DrawBall()
        RectBall = New Rectangle()
        myGraphics = Me.CreateGraphics
        Dim myPen As New Pen(Drawing.Color.Blue, 5)
        Dim blueBrush As New SolidBrush(Color.Blue)
        'Ball is created here
        'Paint is called when repaint is nessecery
        'For handling the animation

        RectBall.X = 0
        RectBall.Y = 0
        NewX = 200
        NewY = 350
        RectBall.Width = 24
        RectBall.Height = 24
        iXSize = 24
        iYSize = 24
        Xc = (RectBall.X + RectBall.Width) / 2
        Xy = (RectBall.Y + RectBall.Height) / 2
        myGraphics.FillRectangle(blueBrush, RectBall)
        myGraphics.DrawEllipse(myPen, RectBall)
    End Sub



    Private Sub Form1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        Dim Pen As New Pen(Me.BackColor, 1)
        Dim Brush As New SolidBrush(Me.BackColor)


        e.Graphics.FillRectangle(Brush, RectBall)
        e.Graphics.DrawEllipse(Pen, RectBall)
        'Backcolor ellipse in the old position 
        Dim myPen As New Pen(Drawing.Color.Blue, 5)
        Dim blueBrush As New SolidBrush(Color.Blue)

        RectBall.X = NewX 'New position
        RectBall.Y = NewY
        Xc = Me.ClientRectangle.Width
        Xy = Me.ClientRectangle.Height
        e.Graphics.FillRectangle(blueBrush, RectBall)
        e.Graphics.DrawEllipse(myPen, RectBall)
        'Here ball is drawn again with each interval
        OriginalHeight = RectBall.Y / Me.ClientRectangle.Height 'Used in resize
        OriginalWidth = RectBall.X / Me.ClientRectangle.Width 'Original position

    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'Resize control

        'Original position relative to window mulitplied with new height and width
        NewX = OriginalWidth * Me.ClientRectangle.Width
        NewY = OriginalHeight * Me.ClientRectangle.Height

        If NewY < 10 Then 'Checking limits
            NewY = 10
        End If

        If NewY > Me.ClientRectangle.Height - RectBall.Height - 10 Then
            NewY = Me.ClientRectangle.Height - RectBall.Height - 10
        End If

        If NewX < 10 Then
            NewX = 10
        End If

        If NewX > Me.ClientRectangle.Width - RectBall.Width - 10 Then
            NewX = Me.ClientRectangle.Width - RectBall.Width - 10

        End If

        OriginalHeight = RectBall.Y / Me.ClientRectangle.Height 'Ratio is calculated again
        OriginalWidth = RectBall.X / Me.ClientRectangle.Width

        Me.Refresh() 'Paint is called



    End Sub
End Class
