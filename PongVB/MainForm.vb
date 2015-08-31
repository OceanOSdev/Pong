Imports System.Runtime.InteropServices

Public Class frmMain
#Region "globals"
    Dim speed As Single = 10 ' Ball Speed  
    Dim rndInst As New Random() ' Random instance  
    Dim xVel As Single = Math.Cos(rndInst.Next(5, 10)) * speed  ' why the hell is a "float" called a single? 
    Dim yVel As Single = Math.Sin(rndInst.Next(5, 10)) * speed  ' Nevermind, I figured it out
    ' The player's scores.
    Dim compScore As Integer = 0
    Dim plrScore As Integer = 0
    ' Multiplayer?
    Dim blnMult As Boolean = False
#End Region

    ''' <summary>
    ''' Gets state of Key Asynchronously (what ever that is lol)
    ''' </summary>
    ''' <param name="vKey">The Key to check the state of</param>
    ''' <returns>Hell if I know</returns>
    ''' <remarks>Pretty dank</remarks>
    <DllImport("user32.dll")>
    Public Shared Function GetAsyncKeyState(ByVal vKey As Int32) As UShort
        ' This function is empty and it still does stuff lol, how dank is that?
    End Function

    ''' <summary>
    ''' Sets location of picture box
    ''' </summary>
    ''' <param name="location">The new location of the picture box</param>
    ''' <remarks>nothing revolutionary</remarks>
    Private Sub SetLocation(ByVal [location] As Point)
        Me.paddlePlayer.Location = [location]
    End Sub

    ''' <summary>
    ''' Technically just an event handler for the timer, however I'm using it as the game loop.
    ''' </summary>
    ''' <param name="sender">
    ''' used to distinguish between senders, for example, if I had this 
    ''' handle both tmrClock and another timer, I'd use sender to see
    ''' which event is being handled
    ''' </param>
    ''' <param name="e">Event arguments</param>
    ''' <remarks>kinda hacky, but meh</remarks>
    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick

    #Region "Player Movement"
        REM moves the player's paddle up 8 points
        If (GetAsyncKeyState(Keys.W)) Then
            Dim newLoc As New Point(paddlePlayer.Location.X, paddlePlayer.Location.Y - 8)
            SetLocation(newLoc)
        End If

        REM moves the player's paddle 8 points
        If (GetAsyncKeyState(Keys.S)) Then
            Dim newLoc As New Point(paddlePlayer.Location.X, paddlePlayer.Location.Y + 8)
            SetLocation(newLoc)
        End If
#End Region

#Region "Computer Player Movement"
        If Not blnMult Then
            If picBall.Location.Y > 5 And picBall.Location.Y < Me.Height - 40 - paddlePlayer.Height Then
                paddleComputer.Location = New Point(paddleComputer.Location.X, picBall.Location.Y)
            End If
        Else
            If GetAsyncKeyState(Keys.Up) Or GetAsyncKeyState(Keys.I) Then
                paddleComputer.Location = New Point(paddleComputer.Location.X, paddleComputer.Location.Y - 8)
            End If

            If GetAsyncKeyState(Keys.Down) Or GetAsyncKeyState(Keys.K) Then
                paddleComputer.Location = New Point(paddleComputer.Location.X, paddleComputer.Location.Y + 8)
            End If
        End If
#End Region

#Region "Multiplayer"
        If (GetAsyncKeyState(Keys.P)) Then
            blnMult = Not blnMult
        End If
#End Region

#Region "Ball Movement"
        ' Move the game ball.  
        picBall.Location = New Point(picBall.Location.X + xVel, picBall.Location.Y + yVel)
#End Region

#Region "Collision"
        ' Check for top wall.
        If picBall.Location.Y < 0 Then
            picBall.Location = New Point(picBall.Location.X, 0)
            yVel = -yVel
        End If

        ' Check for bottom wall.
        If picBall.Location.Y > Me.Height - picBall.Size.Height - 45 Then
            picBall.Location = New Point(picBall.Location.X, Me.Height - picBall.Size.Height - 45)
            yVel = -yVel
        End If

        ' Check for computer paddle.
        If picBall.Bounds.IntersectsWith(paddleComputer.Bounds) Then
            picBall.Location = New Point(paddleComputer.Location.X - paddleComputer.Size.Width - 1,
            picBall.Location.Y)
            xVel = -xVel
        End If

        ' Check for player paddle.
        If picBall.Bounds.IntersectsWith(paddlePlayer.Bounds) Then
            picBall.Location = New Point(paddlePlayer.Location.X + paddlePlayer.Size.Width + 1,
            picBall.Location.Y)
            xVel = -xVel
        End If

        ' Check for right wall.
        If picBall.Location.X > Me.Width - picBall.Size.Width - paddlePlayer.Width Then
            plrScore += 1
            picBall.Location = New Point(Me.Size.Width / 2, Me.Size.Height / 2)
            lblPlayerScore.Text = Convert.ToString(plrScore)
        End If

        ' Check for left wall.
        If picBall.Location.X < 0 Then
            compScore += 1
            picBall.Location = New Point(Me.Size.Width / 2, Me.Size.Height / 2)
            lblComputerScore.Text = Convert.ToString(compScore)
        End If
#End Region
    End Sub
End Class
