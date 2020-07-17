'==============================================================================
'Project:           Visual Basic video game project 
'Title:             Turtle Escape
'File Name:         FinalProject.exe, FinalProject.vb, FinalProject.sln
'Date Completed:    3/12/2020
'
'Authors:            Melanie Lamp, Christopher Schmitt, Andy Park, 
'                    and Mitch Fisher
'Course:             CS161 Winter 2020
'
'Description:       The objective is to reach the end of the finish line
'                   while avoiding the cars and alligators. You're also encouraged
'                   to finish in the fastest time possible for a maximum score. 
'                   There's two stages: 1st the background scrolls and the user must
'                   avoid obstacles coming towards them, but their ability to 
'                   move backwards is inhibited. In the second Stage, the BG is
'                   stationary and the user must cross 3 lanes with obstacles
'                   as fast as possible.The score is determined by taking the 
'                   maximum score (arbitrary) then subtracting from that the time 
'                   the user took to cross stage 1 and stage 2, and then adding
'                   to that the total amount of lives left multiplied by our life
'                   value. 
'==============================================================================
' Known Bugs:       1. Turtle progress can exceed the river before the final 
'                   part is loaded. Currently turtle is moved back to start of
'                   water. 
'                   2. Turtle does Not change animation When reaching the
'                   the water. 
'                   3. When Collision with obstacles is detected, will sometimes
'                   respawn the turtle in front of a car with no time to avoid
'                   4. If you don't finish in a reasonable time score could
'                   potential be negative and music could stop playing. Although
'                   game is not designed to require the time it would take to
'                   get a negative score.
'==============================================================================
Option Explicit On
Option Strict On

Imports System.Drawing.Drawing2D
Imports System.Threading

Public Class FinalProject
    '--------------------------------------------------------------------------
    'Description:   Classwide variable declaration
    '--------------------------------------------------------------------------

    'Background image variables
    Dim graBG As Graphics
    Dim bmpBG As Bitmap = New Bitmap("..\Multimedia\background.png")
    Dim mtxBG As Matrix
    Dim graBuffer As Graphics
    Dim bmpBuffer As Bitmap
    Dim cshtViewWidth As Short
    Dim cshtViewHeight As Short
    Dim cshtBGMoveX As Short = -1
    Dim cshtBGMoveY As Short = 0
    Dim cshtBGY As Short

    'Sprite (Turtle) variables
    Dim graTurtle As Graphics
    Dim bmpTurtle As Bitmap = New Bitmap("..\Multimedia\turtleAnimation_right.png")
    Dim cshtTurtleX As Short = 50
    Dim cshtTurtleY As Short = 200
    Dim cshtTurtleNumberOfFrames As Short = 9 'Goes w/ sprite Animation Variables
    Dim cshtTurtleW As Short = CShort(bmpTurtle.Width / cshtTurtleNumberOfFrames)
    Dim cshtTurtleH As Short = CShort(bmpTurtle.Height)
    Dim cshtTurtleMoveX As Short = 10
    Dim cshtTurtleMoveY As Short = 10

    'Sprite (Turtle) Animation 
    Dim recCurrentFrame As Rectangle
    Dim cshtFrameX As Short
    Dim cshtFrameY As Short
    Dim cshtAnimatedSpriteLength As Short = CShort(bmpTurtle.Width)

    'Car variables/Images
    Dim bmpCarBlueDown As Bitmap = New Bitmap("..\Multimedia\carbludown.png")
    Dim bmpCarBlueUp As Bitmap = New Bitmap("..\Multimedia\CarBluUp.png")
    Dim bmpCarGreenUp As Bitmap = New Bitmap("..\Multimedia\cargrnup.png")
    Dim bmpCarGreenDown As Bitmap = New Bitmap("..\Multimedia\cargrndown.png")
    Dim bmpCarRedDown As Bitmap = New Bitmap("..\Multimedia\carredDown.png")
    Dim bmpCarRedUp As Bitmap = New Bitmap("..\Multimedia\carredUp.png")

    'Height and Width Same for all cars
    Dim cshtCarW As Short = CShort(bmpCarBlueDown.Width)
    Dim cshtCarH As Short = CShort(bmpCarBlueDown.Height)

    'Lane 1 Variables
    Dim graCar1stLane As Graphics
    Dim mtxCar1stLane As Matrix
    Dim cshtCar1stLane_X As Short = 200 'Drawn in First Lane
    Dim cshtCar1stLane_Y As Short = -100 'Draw Outside the Panel coming down
    Dim cshtMovementEnd1stLane As Short = 100
    Dim cshtCar1stLane_MoveX As Short = 0
    Dim cshtCar1stLane_MoveY As Short = 12

    'Lane 2 Variables
    Dim graCar2ndLane As Graphics
    Dim mtxCar2ndLane As Matrix
    Dim cshtCar2ndLane_X As Short = 250 'Drawn in second lane
    Dim cshtCar2ndLane_Y As Short
    Dim cshtMovementEndCar2ndLane As Short = 150
    Dim cshtCar2ndLane_MoveX As Short = 0
    Dim cshtCar2ndLane_MoveY As Short = -8

    'Lane 3 Variables
    Dim graCar3rdLane As Graphics
    Dim mtxCar3rdLane As Matrix
    Dim cshtCar3rdLane_X As Short = 525
    Dim cshtCar3rdLane_Y As Short = -500
    Dim cshtMovementEndCar3rdLane As Short = 200
    Dim cshtCar3rdLane_MoveX As Short = 0
    Dim cshtCar3rdLane_MoveY As Short = 8

    'Lane 4 Variables
    Dim graCar4thLane As Graphics
    Dim mtxCar4thLane As Matrix
    Dim cshtCar4thLane_X As Short = 625 '600 Orginally (May mess up somethign)
    Dim cshtCar4thLane_Y As Short = -200
    Dim cshtMovementEndCar4thLane As Short = 200
    Dim cshtCar4thLane_MoveX As Short = 0
    Dim cshtCar4thLane_MoveY As Short = 8

    'Lane 5 Variables
    Dim graCar5thLane As Graphics
    Dim mtxCar5thLane As Matrix
    Dim cshtCar5thLane_X As Short = 725
    Dim cshtCar5thLane_Y As Short = -300
    Dim cshtMovementEndCar5thLane As Short = 200
    Dim cshtCar5thLane_MoveX As Short = 0
    Dim cshtCar5thLane_MoveY As Short = 6

    'water crossing variables
    Dim graAlligator As Graphics
    Dim mtxAlligator As Matrix
    Dim bmpAlligator As Bitmap = New Bitmap("..\Multimedia\alligator_Animation.png")
    Dim cshtAlligator_X As Short = 120 'Drawn in First Lane
    Dim cshtAlligator_Y As Short = -50 'Draw Outside the Panel coming down
    Dim cshtMovementEndAlligator As Short = 600
    Dim cshtAlligator_MoveX As Short = 0
    Dim cshtAlligator_MoveY As Short = 3


    'Alligator Animation 
    Dim recCurrentAlligatorFrame As Rectangle
    Dim cshtAlligatorFrameX As Short
    Dim cshtAlligatorFrameY As Short
    Dim cshtAlligatorNumberOfFrames As Short = 12
    Dim cshtAlligatorW As Short = CShort(bmpAlligator.Width / cshtAlligatorNumberOfFrames)
    Dim cshtAlligatorH As Short = CShort(bmpAlligator.Height)
    Dim cshtAnimatedAlligatorLength As Short = CShort(bmpAlligator.Width)

    'Lane 6 Variables
    Dim graCar6thLane As Graphics
    Dim mtxCar6thLane As Matrix
    Dim cshtCar6thLane_X As Short = 350
    Dim cshtCar6thLane_Y As Short = -100
    Dim cshtMovementEndCar6thLane As Short = 300
    Dim cshtCar6thLane_MoveX As Short = 0
    Dim cshtCar6thLane_MoveY As Short = 7

    'Lane 7 Variables
    Dim graCar7thLane As Graphics
    Dim mtxCar7thLane As Matrix
    Dim cshtCar7thLane_X As Short = 500
    Dim cshtCar7thLane_Y As Short = -100
    Dim cshtMovementEndCar7thLane As Short = 125
    Dim cshtCar7thLane_MoveX As Short = 0
    Dim cshtCar7thLane_MoveY As Short = -9

    'Scoring
    Dim intStart As Integer
    Dim intStop As Integer
    Dim intStage1 As Integer
    Dim intStage2 As Integer
    Dim lngScore As Long = 0
    Dim lngHighScore As Long = 0
    Dim bytDeathCounter As Byte = 3
    Const cintLIFE As Integer = 10000
    Const clngMAX_TIME As Long = 100000

    'Sound
    Dim cstrSongPath As String = Application.StartupPath

    '--------------------------------------------------------------------------
    'Description:   During our load event, we'll make all the colors on our 
    '               sprites and obstacles transparent, set up all our graphics
    '               objects and matrices, and set up our song path for our music
    '--------------------------------------------------------------------------
    Private Sub FinalProject_Load(sender As Object,
                                  e As EventArgs) Handles Me.Load

        frmSplash.ShowSplash()
        Randomize()
        cshtViewWidth = CShort(pnlDisplay.Width)
        cshtViewHeight = CShort(pnlDisplay.Height)

        lblInfo.Text = Chr(13) & "Press start to begin a new game."

        'For drawing and displaying
        graBuffer = pnlDisplay.CreateGraphics
        bmpBuffer = New Bitmap(pnlDisplay.Width, pnlDisplay.Height, graBuffer)

        'Making Colors on our Sprites and Obstacles Transparent
        bmpCarBlueDown.MakeTransparent(Color.FromArgb(255, 0, 0))
        bmpCarBlueUp.MakeTransparent(Color.FromArgb(255, 0, 0))
        bmpCarGreenUp.MakeTransparent(Color.FromArgb(0, 0, 255))
        bmpCarGreenDown.MakeTransparent(Color.FromArgb(0, 0, 255))
        bmpCarRedUp.MakeTransparent(Color.FromArgb(0, 255, 0))
        bmpCarRedDown.MakeTransparent(Color.FromArgb(0, 255, 0))
        bmpTurtle.MakeTransparent(Color.FromArgb(255, 0, 0))
        bmpAlligator.MakeTransparent(Color.FromArgb(0, 0, 255))

        graBG = Graphics.FromImage(bmpBuffer)
        mtxBG = New Matrix(1, 0, 0, 1, cshtBGMoveX, cshtBGMoveY)

        graCar1stLane = Graphics.FromImage(bmpBuffer)
        mtxCar1stLane = New Matrix(1, 0, 0, 1,
                                   cshtCar1stLane_MoveX, cshtCar1stLane_MoveY)

        graCar2ndLane = Graphics.FromImage(bmpBuffer)
        mtxCar2ndLane = New Matrix(1, 0, 0, 1,
                                   cshtCar2ndLane_MoveX, cshtCar2ndLane_MoveY)

        'Determined by Panel Size so we declare value in Load event
        'Same for 7th Lane. Reason for is Car starts below the panel.
        cshtCar2ndLane_Y = CShort(pnlDisplay.Height + 200)

        graCar3rdLane = Graphics.FromImage(bmpBuffer)
        mtxCar3rdLane = New Matrix(1, 0, 0, 1,
                                   cshtCar3rdLane_MoveX, cshtCar3rdLane_MoveY)

        graCar4thLane = Graphics.FromImage(bmpBuffer)
        mtxCar4thLane = New Matrix(1, 0, 0, 1,
                                   cshtCar4thLane_MoveX, cshtCar4thLane_MoveY)

        graCar5thLane = Graphics.FromImage(bmpBuffer)
        mtxCar5thLane = New Matrix(1, 0, 0, 1,
                                   cshtCar5thLane_MoveX, cshtCar5thLane_MoveY)

        graAlligator = Graphics.FromImage(bmpBuffer)
        mtxAlligator = New Matrix(1, 0, 0, 1,
                                   cshtAlligator_MoveX, cshtAlligator_MoveY)

        graCar6thLane = Graphics.FromImage(bmpBuffer)
        mtxCar6thLane = New Matrix(1, 0, 0, 1,
                                   cshtCar6thLane_MoveX, cshtCar6thLane_MoveY)

        graCar7thLane = Graphics.FromImage(bmpBuffer)
        mtxCar7thLane = New Matrix(1, 0, 0, 1,
                                   cshtCar7thLane_MoveX, cshtCar7thLane_MoveY)
        cshtCar7thLane_Y = CShort(pnlDisplay.Height + 300)

        graTurtle = Graphics.FromImage(bmpBuffer)

        cstrSongPath = cstrSongPath.Substring(0, cstrSongPath.Length -
                       "Debug".Length) & "\Multimedia\TMNT.wav"

        wmpPlayer.Visible = False

    End Sub

    '--------------------------------------------------------------------------
    'Description:   This function is for detecting our collision or rather for
    '               checking if our sprite is in the same location as our 
    '               obstacle. Does so by drawing a bounding box around each
    '               of our obstacles using the obstacles starting location, 
    '               width & height, and how far its traveled down the screen.
    '               NOTE: This function only works for obstacles in first 5 
    '               lanes. Obstacles in lanes 6 and 7 have slightly different 
    '               formula.
    '
    'Called By:     btnStart_Click
    '--------------------------------------------------------------------------
    Private Function fCollision(ByVal intXLocation As Integer,
                     ByVal intObj1X As Integer, ByVal intObj1W As Integer,
                     ByVal intObj2X As Integer, ByVal intObj1Y As Integer,
                     ByVal intObj1H As Integer, ByVal intObj2Y As Integer,
                     ByVal intObj2H As Integer, ByVal intObj2W As Integer,
                     ByVal intDistance As Integer) As Boolean

        Dim blnAnswer = False

        If intObj1X + intObj1W - 10 >= intObj2X - intXLocation And
                intObj1Y + intObj1H >= intObj2Y + intDistance + 20 And
                intObj1Y <= intObj2Y + intObj2H + intDistance - 20 And
                intObj1X <= intObj2X + intObj2W - intXLocation Then


            My.Computer.Audio.Play("..\Multimedia\Squish.wav")
            blnAnswer = True

        End If

        Return blnAnswer

    End Function

    '--------------------------------------------------------------------------
    'Description:   Keeps track of the current player lives remaining displayed
    '               on screen and turns them over to empty shells with each
    '               satisfying splat.
    '
    'Called By:     btnStart_Click, pEnding
    '--------------------------------------------------------------------------
    Private Sub sDeathCount()

        If bytDeathCounter = 2 Then
            lblLife3.Visible = True
            lblLife3.Image = Image.FromFile("..\Multimedia\deadSprite.png")
            lblInfo.Text = Chr(13) & "You didn't make it, but you have another life!"
        ElseIf bytDeathCounter = 1 Then

            lblLife2.Visible = True
            lblLife2.Image = Image.FromFile("..\Multimedia\deadSprite.png")
            lblInfo.Text = Chr(13) & "Oh no! Only one life left!"
        ElseIf bytDeathCounter = 0 Then

            lblLife1.Visible = True
            lblLife1.Image = Image.FromFile("..\Multimedia\deadSprite.png")
            lblInfo.Text = Chr(13) & "Select the start button to play again."
        End If

    End Sub

    '--------------------------------------------------------------------------
    'Description:   When the user clicks the button, it will draw our turtle,
    '               cars, and start scrolling our background each iteration
    '               of our loop until it reaches the end of the first stage
    '               which is when the finish line is in full view. The user
    '               will manipulate the turtles location with arrow keys and
    '               try to avoid the cars, but their ability to move back
    '               is inhibited by the scrolling background.

    'Calls:         CarColor, fColllision, pSpriteAnimation, sKilled
    '--------------------------------------------------------------------------
    Private Sub btnStart_Click(sender As Object,
                               e As EventArgs) Handles btnStart.Click

        'Click Start to get the background and sprite on panel and from and
        'reset all fields so you can start  
        btnStart.Enabled = False
        btnQuit.Enabled = False

        Dim i As Integer

        Dim shtDistanceTraveled1stLane As Short
        Dim shtDistanceTraveled2ndLane As Short
        Dim shtDistanceTraveled3rdLane As Short
        Dim shtDistanceTraveled4thLane As Short
        Dim shtDistanceTraveled5thLane As Short

        Dim shtCounter1stLane As Short
        Dim shtCounter2ndLane As Short
        Dim shtCounter3rdLane As Short
        Dim shtCounter4thLane As Short
        Dim shtCounter5thLane As Short

        Dim bmpCarLane1 As Bitmap
        Dim bmpCarLane2 As Bitmap
        Dim bmpCarLane3 As Bitmap
        Dim bmpCarLane4 As Bitmap
        Dim bmpCarLane5 As Bitmap

        'Reset all our labels, graphics objects, and variables at the start
        'of each playthrough
        If lngScore > 0 Then
            lblPrevious.Text = lngScore.ToString
        End If

        My.Computer.Audio.Stop() 'Stop game over sound when restarting
        lngScore = 0
        cshtTurtleX = 25
        cshtTurtleY = 175
        bytDeathCounter = 3
        graBG.ResetTransform()
        graTurtle.ResetTransform()
        lblLife1.Image = Image.FromFile("..\Multimedia\RightSprite.png")
        lblLife2.Image = Image.FromFile("..\Multimedia\RightSprite.png")
        lblLife3.Image = Image.FromFile("..\Multimedia\RightSprite.png")
        lblInfo.Text = Chr(13) & "Get across the road before the hunter catches you!"

        'Randomizing the Colors of Cars (Value passed is Lane Number)
        bmpCarLane1 = CarColor(1)
        bmpCarLane2 = CarColor(2)
        bmpCarLane3 = CarColor(3)
        bmpCarLane4 = CarColor(4)
        bmpCarLane5 = CarColor(5)

        'Make the BG And Turtle appear before Message.
        graBG.DrawImageUnscaled(bmpBG, 0, 0)
        graBuffer.DrawImage(bmpBuffer, 0, 0)
        MessageBox.Show("Oh No! A hunter is closing in on your nest. Quickly cross the busy highway before your babies get taken.")

        'Audio 
        wmpPlayer.URL = cstrSongPath
        wmpPlayer.Ctlcontrols.play()

        'Start the timer
        intStart = Environment.TickCount

        For i = 0 To (bmpBG.Width - cshtViewWidth)

            'First we Draw our BG and Turtle Sprite

            graBG.DrawImageUnscaled(bmpBG, 0, 0)
            pSpriteAnimation(i)

            'Obstalces (Cars) Animation

            'This Car will be in our first lane
            'Checking to see if Car has reached the end of the screen 
            'which it will do Every 100 iterations (cshtCarMovementEnd)
            'NOTE 100 Value is determined by Car Locations Y Value and Matrix Vertical 
            'Translation Value (i.e how far our car travels)

            If Not i Mod cshtMovementEnd1stLane = 0 Then

                'If it hasn't then we just draw it with its position changin
                'after each iteration as we trasnform our graCar
                graCar1stLane.DrawImageUnscaled(bmpCarLane1, cshtCar1stLane_X - i,
                                                cshtCar1stLane_Y)

            Else

                'If it has then we reset our graphics so it will repeat the animation
                'and we also retreive a new car color for the lane
                graCar1stLane.ResetTransform()
                bmpCarLane1 = CarColor(1)
                shtDistanceTraveled1stLane = 0
                shtCounter1stLane = 0

            End If

            'This car will be in our 2nd lane

            If Not i Mod cshtMovementEndCar2ndLane = 0 Then

                'If it hasn't then we just draw it in its new position
                graCar2ndLane.DrawImage(bmpCarGreenUp, cshtCar2ndLane_X - i,
                                        cshtCar2ndLane_Y)

            Else

                'If it has then we reset our graphics so it will repeat the animation
                'and we also retreive a new car color for the lane.           
                graCar2ndLane.ResetTransform()
                bmpCarLane2 = CarColor(2)
                shtDistanceTraveled2ndLane = 0
                shtCounter2ndLane = 0

            End If

            'This Car Will be in our 3rd Lane
            If Not i Mod cshtMovementEndCar3rdLane = 0 Then

                'If it hasn't then we just draw it in its new position
                graCar3rdLane.DrawImage(bmpCarLane3, cshtCar3rdLane_X - i,
                                        cshtCar3rdLane_Y)

            Else

                'If it has then we reset our graphics so it will repeat the animation
                'and we also retreive a new car color for the lne
                graCar3rdLane.ResetTransform()
                bmpCarLane3 = CarColor(3)
                shtDistanceTraveled3rdLane = 0
                shtCounter3rdLane = 0

            End If

            'This Car Will be in our 4th Lane
            If Not i Mod cshtMovementEndCar4thLane = 0 Then

                'If it hasn't then we just draw it in its new position
                graCar4thLane.DrawImage(bmpCarLane4, cshtCar4thLane_X - i,
                                        cshtCar4thLane_Y)

            Else

                'If it has then we reset our graphics so it will repeat the animation
                'and we also retreive a new car color for the lne
                graCar4thLane.ResetTransform()
                bmpCarLane4 = CarColor(4)
                shtDistanceTraveled4thLane = 0
                shtCounter4thLane = 0

            End If

            If Not i Mod cshtMovementEndCar5thLane = 0 Then

                'If it hasn't then we just draw it in its new position
                graCar5thLane.DrawImage(bmpCarLane5, cshtCar5thLane_X - i,
                                        cshtCar5thLane_Y)

            Else

                'If it has then we reset our graphics so it will repeat the animation
                'and we also retreive a new car color for the lne
                graCar5thLane.ResetTransform()
                bmpCarLane5 = CarColor(5)
                shtDistanceTraveled5thLane = 0
                shtCounter5thLane = 0

            End If

            'End of Car Animation

            'This is our Collision Code. What it does is we have a seperate 
            'counter that determines how many iterations in the car animation have 
            'passed. We multiply it by our distance traveled in one iteration 
            '(cshtCarnthLane_MoveY) to get our total distance traveled for the 
            'entire animation. We then add one to the counter (1 car animation
            'has passed). Then we check that our sprite (turtle) isn't in the 
            'vicinity of the car. After the Car Animation has reset (look at 
            'code above) we reset both our counter and DistanceTraveled variables
            'to make our bounding box reset with the car sprite.
            'NOTE- The Use of Literals is to make collision a little less exact
            'due to exlusively using variables putting collision right on the 
            'edge of our images. Using literals lets the images overlap a little.
            'before the collision is detected.


            shtDistanceTraveled1stLane = CShort(shtCounter1stLane * cshtCar1stLane_MoveY)
            shtDistanceTraveled2ndLane = CShort(shtCounter2ndLane * cshtCar2ndLane_MoveY)
            shtDistanceTraveled3rdLane = CShort(shtCounter3rdLane * cshtCar3rdLane_MoveY)
            shtDistanceTraveled4thLane = CShort(shtCounter4thLane * cshtCar4thLane_MoveY)
            shtDistanceTraveled5thLane = CShort(shtCounter5thLane * cshtCar5thLane_MoveY)

            shtCounter1stLane += CShort(1)
            shtCounter2ndLane += CShort(1)
            shtCounter3rdLane += CShort(1)
            shtCounter4thLane += CShort(1)
            shtCounter5thLane += CShort(1)

            'lane 1
            If fCollision(i, cshtTurtleX, cshtTurtleW, cshtCar1stLane_X,
                          cshtTurtleY, cshtTurtleH, cshtCar1stLane_Y,
                          cshtCarH, cshtCarW, shtDistanceTraveled1stLane) = True Then

                'If Collision is deteced, reset sprites location to before 
                'the obstacle(unless user Is in the second or fifth lane), 
                'subtract one life, then check to see If user has lives remaning.

                If cshtTurtleX < 25 Then
                    cshtTurtleX = 25
                Else
                    cshtTurtleX += cshtCarW + cshtTurtleW
                End If
                bytDeathCounter -= CByte(1)
                sDeathCount()

                If bytDeathCounter = 0 Then

                    Call sKilled()
                    Exit For

                End If

            End If

            'lane 2
            If fCollision(i, cshtTurtleX, cshtTurtleW, cshtCar2ndLane_X,
                          cshtTurtleY, cshtTurtleH, cshtCar2ndLane_Y,
                          cshtCarH, cshtCarW, shtDistanceTraveled2ndLane) = True Then
                'We want our sprite to respawn on the grass (safe zone) 
                'to ensure it doesn't spawn right in front of our car in
                'the first lane. Same idea for fifth lane.
                If cshtTurtleX < 25 Then
                    cshtTurtleX += (cshtCarW + cshtTurtleW)
                Else
                    cshtTurtleX += (cshtCarW + cshtTurtleW)
                End If
                bytDeathCounter -= CByte(1)
                sDeathCount()

                If bytDeathCounter = 0 Then

                    Call sKilled()
                    Exit For

                End If

            End If

            'lane 3
            If fCollision(i, cshtTurtleX, cshtTurtleW, cshtCar3rdLane_X,
                          cshtTurtleY, cshtTurtleH, cshtCar3rdLane_Y,
                          cshtCarH, cshtCarW, shtDistanceTraveled3rdLane) = True Then

                If cshtTurtleX < 25 Then
                    cshtTurtleX = 25
                Else
                    cshtTurtleX += cshtCarW + cshtTurtleW
                End If
                bytDeathCounter -= CByte(1)
                sDeathCount()

                If bytDeathCounter = 0 Then

                    Call sKilled()
                    Exit For

                End If

            End If

            'lane 4
            If fCollision(i, cshtTurtleX, cshtTurtleW, cshtCar4thLane_X,
                          cshtTurtleY, cshtTurtleH, cshtCar4thLane_Y,
                          cshtCarH, cshtCarW, shtDistanceTraveled4thLane) = True Then

                If cshtTurtleX < 25 Then
                    cshtTurtleX = 25
                Else
                    cshtTurtleX += cshtCarW + cshtTurtleW
                End If
                bytDeathCounter -= CByte(1)
                sDeathCount()

                If bytDeathCounter = 0 Then

                    Call sKilled()
                    Exit For

                End If

            End If

            'lane 5
            If fCollision(i, cshtTurtleX, cshtTurtleW, cshtCar5thLane_X,
                          cshtTurtleY, cshtTurtleH, cshtCar5thLane_Y,
                          cshtCarH, cshtCarW, shtDistanceTraveled5thLane) = True Then


                cshtTurtleX += cshtCarW + cshtTurtleW
                bytDeathCounter -= CByte(1)
                sDeathCount()

                If bytDeathCounter = 0 Then

                    Call sKilled()
                    Exit For

                End If

            End If
            'End of Collision Code

            'Drarwing everything onto our panel and transforming Graphics objects
            graBuffer.DrawImageUnscaled(bmpBuffer, 0, 0)
            graBG.MultiplyTransform(mtxBG)
            graCar1stLane.MultiplyTransform(mtxCar1stLane)
            graCar2ndLane.MultiplyTransform(mtxCar2ndLane)
            graCar3rdLane.MultiplyTransform(mtxCar3rdLane)
            graCar4thLane.MultiplyTransform(mtxCar4thLane)
            graCar5thLane.MultiplyTransform(mtxCar5thLane)
            Application.DoEvents()


        Next i

        'END OF BG SLIDING

        If bytDeathCounter > 0 Then

            intStop = Environment.TickCount
            intStage1 = intStop - intStart
            wmpPlayer.Ctlcontrols.stop()
            MessageBox.Show("You're almost there! Just avoid the gators and pass the last two lanes to get home")


            Call pEnding()

        End If

    End Sub


    '--------------------------------------------------------------------------
    'Description:   This is a procedure for after our BG has finished scrolling
    '               in our btnStart Click event. After the BG has reached its 
    '               end we start animating the cars and alligaotor and then 
    '               the user attempts to reach the finish line.
    '
    'Calls:         CarColor, pSpriteAnimation, fCollision, pAlligatorAnimation,
    '               sKilled
    ' 
    'Called By:     btnStart_Click
    '--------------------------------------------------------------------------
    Private Sub pEnding()

        'Get Random Car Colors
        Dim bmpCarLane6 = CarColor(6)
        Dim bmpCarLane7 = CarColor(7)

        Dim shtDistanceTraveledAlligator As Short
        Dim shtDistanceTraveled6thLane As Short
        Dim shtDistanceTraveled7thLane As Short

        Dim shtCounterAlligator As Short
        Dim shtCounter6thLane As Short
        Dim shtCounter7thLane As Short

        'Reset Turtles Location to before River
        cshtTurtleX = 25
        cshtTurtleY = 175

        'Play sound effect/music , Display message to user and start timer.
        lblInfo.Text = Chr(13) & "Watch out for the alligators!"
        wmpPlayer.Ctlcontrols.play()
        intStart = Environment.TickCount

        For j = 0 To 100000 'Arbirtrary Value to ensure to Animations don't stop

            If Not j Mod cshtMovementEndCar6thLane = 0 Then

                'Draw our BG and Cars
                graBG.DrawImageUnscaled(bmpBG, 0, 0)
                graCar6thLane.DrawImageUnscaled(bmpCarLane6, cshtCar6thLane_X,
                                                cshtCar6thLane_Y)
                graCar7thLane.DrawImageUnscaled(bmpCarLane7, cshtCar7thLane_X,
                                                cshtCar7thLane_Y)
                'Animate our sprite
                pSpriteAnimation(j)

                'Animate our obstacle (Alligator)
                pAlligatorAnimation(j)


                'Collision Code
                shtDistanceTraveledAlligator = CShort(shtCounterAlligator *
                    cshtAlligator_MoveY)
                shtCounterAlligator += CShort(1)

                shtDistanceTraveled6thLane = CShort(shtCounter6thLane *
                    cshtCar6thLane_MoveY)
                shtCounter6thLane += CShort(1)

                shtDistanceTraveled7thLane = CShort(shtCounter7thLane *
                    cshtCar7thLane_MoveY)
                shtCounter7thLane += CShort(1)

                'Water Crossing (Alligator Collision)
                If cshtTurtleX + cshtTurtleW - 10 >= cshtAlligator_X And
                    cshtTurtleY + cshtTurtleH >= cshtAlligator_Y +
                    shtDistanceTraveledAlligator + 20 And
                    cshtTurtleY <= cshtAlligator_Y + cshtAlligatorH +
                    shtDistanceTraveledAlligator - 20 And
                    cshtTurtleX <= cshtAlligator_X + cshtAlligatorW Then

                    'If Collision is deteced, play sound effect, reset sprites
                    'location to before the obstacle, subtract one life, then 
                    'check to see if user has lives remaning.
                    My.Computer.Audio.Play("..\Multimedia\Alligator.wav")

                    If cshtTurtleX < 25 Then
                        cshtTurtleX = 25
                    Else
                        cshtTurtleX -= cshtAlligatorW + cshtTurtleW
                    End If
                    bytDeathCounter -= CByte(1)
                    sDeathCount()

                    If bytDeathCounter = 0 Then

                        Call sKilled()
                        Exit For

                    End If

                End If

                'Lane 6
                If cshtTurtleX + cshtTurtleW - 10 >= cshtCar6thLane_X And
                cshtTurtleY + cshtTurtleH >= cshtCar6thLane_Y +
                shtDistanceTraveled6thLane + 20 And
                cshtTurtleY <= cshtCar6thLane_Y + cshtCarH +
                shtDistanceTraveled6thLane - 20 And
                cshtTurtleX <= cshtCar6thLane_X + cshtCarW Then

                    My.Computer.Audio.Play("..\Multimedia\Squish.wav")

                    If cshtTurtleX < 25 Then
                        cshtTurtleX = 25
                    Else
                        cshtTurtleX -= cshtCarW + cshtTurtleW
                    End If
                    bytDeathCounter -= CByte(1)
                    sDeathCount()

                    If bytDeathCounter = 0 Then

                        Call sKilled()
                        Exit For

                    End If

                End If

                '7th Lane
                If cshtTurtleX + cshtTurtleW - 10 >= cshtCar7thLane_X And
                    cshtTurtleY + cshtTurtleH >= cshtCar7thLane_Y +
                    shtDistanceTraveled7thLane + 20 And
                    cshtTurtleY <= cshtCar7thLane_Y + cshtCarH +
                    shtDistanceTraveled7thLane - 20 And
                    cshtTurtleX <= cshtCar7thLane_X + cshtCarW Then

                    My.Computer.Audio.Play("..\Multimedia\Squish.wav")

                    If cshtTurtleX < 25 Then
                        cshtTurtleX = 25
                    Else
                        cshtTurtleX -= cshtCarW + cshtTurtleW
                    End If
                    bytDeathCounter -= CByte(1)
                    sDeathCount()

                    If bytDeathCounter = 0 Then

                        Call sKilled()
                        Exit For

                    End If

                End If
                'End of Collision Code

                'Drawing Everything onto our panel And tranforming graphics
                graBuffer.DrawImageUnscaled(bmpBuffer, 0, 0)
                graAlligator.MultiplyTransform(mtxAlligator)
                graCar6thLane.MultiplyTransform(mtxCar6thLane)
                graCar7thLane.MultiplyTransform(mtxCar7thLane)
                Application.DoEvents()

            Else
                'Resetting our Graphics Objects and Distance/Counter Variables
                'Then getting a new random car color.
                graAlligator.ResetTransform()
                shtDistanceTraveledAlligator = 0
                shtCounterAlligator = 0

                graCar6thLane.ResetTransform()
                bmpCarLane6 = CarColor(6)
                shtDistanceTraveled6thLane = 0
                shtCounter6thLane = 0

                graCar7thLane.ResetTransform()
                bmpCarLane7 = CarColor(7)
                shtDistanceTraveled7thLane = 0
                shtCounter7thLane = 0

            End If

            'Finish line
            If cshtTurtleX > 685 Then

                intStop = Environment.TickCount
                intStage2 = intStop - intStart
                lngScore = clngMAX_TIME - (intStage1 + intStage2)
                lngScore += CInt(bytDeathCounter * cintLIFE)

                If lngScore > lngHighScore Then
                    lblInfo.Text = Chr(13) & "New High Score!"
                    lngHighScore = lngScore
                Else
                    lblInfo.Text = Chr(13) & "You made it!"
                End If

                lblCurrent.Text = lngScore.ToString
                lblHigh.Text = lngHighScore.ToString
                wmpPlayer.Ctlcontrols.stop()
                My.Computer.Audio.Play("..\Multimedia\finishline.wav")
                MessageBox.Show("Congratulations. You made it home in time to save your babies from the hunter.")
                My.Computer.Audio.Stop()
                btnQuit.Enabled = True
                btnStart.Enabled = True
                btnStart.Focus()
                Exit For

            End If

        Next j

    End Sub
    '--------------------------------------------------------------------------
    'Description:   Procedure for when the user runs out of lives and gets 
    '               a game over. Stops the music, Renables the buttons, and
    '               displays a message to the user.
    '
    'Called By:     btnStart_Click, pEnding
    '--------------------------------------------------------------------------
    Private Sub sKilled()

        wmpPlayer.Ctlcontrols.stop()
        My.Computer.Audio.Play("..\Multimedia\gameover.wav")
        btnStart.Enabled = True
        btnQuit.Enabled = True
        btnStart.Focus()
        MsgBox("Game Over")

    End Sub
    '--------------------------------------------------------------------------
    'Description:   Event for when user presses an arrow key. It will change the
    '               the location of our sprite (turtle) on our panel. If user 
    '               presses the escape button, then it will check to see if they
    '               wish to close the program.                   
    '--------------------------------------------------------------------------
    Private Sub FinalProject_KeyDown(sender As Object,
                                    e As KeyEventArgs) Handles Me.KeyDown

        Dim blnHitOnce As Boolean = False

        If e.KeyCode = Keys.Right And cshtTurtleX <
                        (cshtViewWidth - cshtTurtleW - 5) Then
            cshtTurtleX += cshtTurtleMoveX

        ElseIf e.KeyCode = Keys.Left And cshtTurtleX > 0 Then
            cshtTurtleX -= cshtTurtleMoveX

        ElseIf e.KeyCode = Keys.Down Then
            cshtTurtleY += cshtTurtleMoveY

        ElseIf e.KeyCode = Keys.Up Then
            cshtTurtleY -= cshtTurtleMoveY

        ElseIf e.KeyCode = Keys.Escape Then
            If MessageBox.Show("Do you want to exit?", "Exit?",
                               MessageBoxButtons.YesNo) =
                                    Windows.Forms.DialogResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub

    '-------------------------------------------------------------------------------
    'Description:   This function will randomly determine the color of our cars based
    '               on which lane they are in (i.e first lane will only have bitmpas
    '               with cars facing down returned) and return the random bmp color.
    '
    'Called By:     btnStart_Click, pEnding
    '-------------------------------------------------------------------------------
    Public Function CarColor(ByVal intNum As Integer) As Bitmap

        Dim intRandom As Integer

        'This if for the first lane
        If intNum = 1 Then

            intRandom = Int(CInt((3 * Rnd()) + 1))

            If intRandom = 1 Then
                Return bmpCarRedDown
            ElseIf intRandom = 2 Then
                Return bmpCarBlueDown
            ElseIf intRandom = 3 Then
                Return bmpCarGreenDown
            Else
                Return bmpCarRedDown
            End If

            'This is for the second
        ElseIf intNum = 2 Then
            intRandom = Int(CInt((3 * Rnd()) + 1))

            If intRandom = 1 Then
                Return bmpCarRedUp
            ElseIf intRandom = 2 Then
                Return bmpCarBlueUp
            ElseIf intRandom = 3 Then
                Return bmpCarGreenUp
            Else
                Return bmpCarRedUp
            End If

            'This is for the third Lane
        ElseIf intNum = 3 Then
            intRandom = Int(CInt((3 * Rnd()) + 1))

            If intRandom = 1 Then
                Return bmpCarRedDown
            ElseIf intRandom = 2 Then
                Return bmpCarBlueDown
            ElseIf intRandom = 3 Then
                Return bmpCarGreenDown
            Else
                Return bmpCarRedDown
            End If

            'This is for the fourth lane
        ElseIf intNum = 4 Then
            intRandom = Int(CInt((3 * Rnd()) + 1))

            If intRandom = 1 Then
                Return bmpCarRedDown
            ElseIf intRandom = 2 Then
                Return bmpCarBlueDown
            ElseIf intRandom = 3 Then
                Return bmpCarGreenDown
            Else
                Return bmpCarRedDown
            End If

            'This is the fifth lane
        ElseIf intNum = 5 Then
            intRandom = Int(CInt((3 * Rnd()) + 1))

            If intRandom = 1 Then
                Return bmpCarRedDown
            ElseIf intRandom = 2 Then
                Return bmpCarBlueDown
            ElseIf intRandom = 3 Then
                Return bmpCarGreenDown
            Else
                Return bmpCarRedDown
            End If


            'This is for the sixth lane
        ElseIf intNum = 6 Then
            intRandom = Int(CInt((3 * Rnd()) + 1))

            If intRandom = 1 Then
                Return bmpCarRedDown
            ElseIf intRandom = 2 Then
                Return bmpCarBlueDown
            ElseIf intRandom = 3 Then
                Return bmpCarGreenDown
            Else
                Return bmpCarRedDown
            End If

            'This is for the seventh lane
        ElseIf intNum = 7 Then
            intRandom = Int(CInt((3 * Rnd()) + 1))

            If intRandom = 1 Then
                Return bmpCarRedUp
            ElseIf intRandom = 2 Then
                Return bmpCarBlueUp
            ElseIf intRandom = 3 Then
                Return bmpCarGreenUp
            Else
                Return bmpCarRedUp
            End If
        End If

    End Function

    '-------------------------------------------------------------------------------
    'Description:   This procedure will animate our sprite (turtle).
    '
    'Called By:     btnStart_Click, pEnding
    '-------------------------------------------------------------------------------
    Private Sub pSpriteAnimation(ByVal i As Integer)

        recCurrentFrame = New Rectangle(cshtFrameX, cshtFrameY, cshtTurtleW,
                                        cshtTurtleH)
        graTurtle.DrawImage(bmpTurtle, cshtTurtleX, cshtTurtleY, recCurrentFrame,
                            GraphicsUnit.Pixel)

        If i Mod 20 = 0 Then

            If cshtFrameX >= cshtAnimatedSpriteLength - cshtTurtleW Then

                cshtFrameX = 0

            Else

                cshtFrameX += cshtTurtleW

            End If

        End If

    End Sub

    '-------------------------------------------------------------------------------
    'Description:   This procedure will animate the alligator. 
    '
    'Called By:     pEnding
    '-------------------------------------------------------------------------------
    Private Sub pAlligatorAnimation(ByVal j As Integer)

        'Alligator Animation

        recCurrentAlligatorFrame = New Rectangle(cshtAlligatorFrameX,
                                                cshtAlligatorFrameY,
                                                cshtAlligatorW, cshtAlligatorH)
        graAlligator.DrawImage(bmpAlligator, cshtAlligator_X, cshtAlligator_Y,
                            recCurrentAlligatorFrame, GraphicsUnit.Pixel)

        If j Mod 20 = 0 Then

            If cshtAlligatorFrameX >= cshtAnimatedAlligatorLength -
                cshtAlligatorW Then

                cshtAlligatorFrameX = 0

            Else

                cshtAlligatorFrameX += cshtAlligatorW

            End If

        End If

        'End of Alligator Animation
    End Sub

    '--------------------------------------------------------------------------
    'Description:   This event will happen if user clicks the Quit Button. It
    '               will then close the program.
    '--------------------------------------------------------------------------
    Private Sub btnQuit_Click(sender As Object,
                              e As EventArgs) Handles btnQuit.Click

        Me.Close()

    End Sub

End Class