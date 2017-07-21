Public Class GameForm
    Dim intCurrentMusicTime As Integer = 0
    Dim intJumpStep As Integer = 0
    Dim intCurrentMusicStep As Integer = 0
    Dim intNumAttempts As Integer = 1
    'Dim intObstacles As Integer = 0
    'Dim arrObstacles() As Integer
    Dim intObstacleStep As Integer = 0
    Dim intObstDx As Integer = 0
    Dim intObstDy As Integer = 0
    Dim intSuccessObstacles As Integer = 0
    Dim myGraphics As Graphics
    'Dim clearGraphics As Graphics
    Dim colorBrush As New Drawing.SolidBrush(Color.Blue)
    Dim eraser As New Drawing.SolidBrush(Color.Black)
    Dim rectCurrent As New Rectangle
    Dim alreadyShowedMsgBox As Integer = 0
    Dim intDifficulty As Integer = My.Settings.intDifficulty
    ' for the "invincibility" glitch
    Dim intNumOfEasterEggKeysPressed As Integer = 0
    Dim boolInvincibility As Boolean = False

    ' LAST INDEX IN SONG TIMES ARRAY IS COMPLETION

    ' start song at 3 seconds
    ' end at 93 (1:33)
    Dim dblArrEZSongTimes() = {9, 12.5, 14, 17.5, 20, 23, 25.5, 28, 30, 32, 33.5, 35, 37, 38.5, 40, 43, 45, 48, 52, 53.5, 58, 59, 61, 66, 69, 71.5, 74, 77, 78.5, 80, 84, 85.5, 91, 93}
    ' Use 50ms intervals only!
    ' TODO: convert all of the numbers to milliseconds < DONE

    ' start song at 2 seconds
    ' end at 1:45 (105)
    Dim dblArrINTSongTimes() = {2, 3.5, 4.5, 6.5, 7.5, 10, 11.5, 13.5, 15, 18, 19.5, 21, 21.5, 24, 26, 29, 31.5, 33.5, 36, 39, 41.5, 44, 46, 48, 50, 52, 54, 57, 59.25, 60.5, 63.2, 66.4, 69.3, 72.3, 75.1, 77.8, 80.1, 82.2, 87.3, 89.9, 91.1, 94.6, 97.1, 98.1, 100, 103, 105}
    Dim ptPlayerLoc As Point

    ' start song at 4.1 seconds
    ' end at 2:26 (146)
    Dim dblArrHRDSongTimes() = {4.1, 5.1, 6.2, 7.1, 8.0, 10, 12, 13.5, 14.7, 16, 17.3, 19.7, 21.2, 23.7, 25.3, 26.3, 29.1, 31.1, 34.2, 36.1, 37.7, 41.1, 43.4, 44.9, 47.7, 49.8, 51.1, 53.2, 54.9, 57.9, 59.4, 60.3, 63.1, 66.3, 70.1, 72.4, 75.6, 77.9, 79.6, 82.1, 84.5, 87.2, 89.9, 92.3, 94.1, 97.9, 99.4, 102.3, 105, 108.3, 111, 114.1, 115.7, 119.3, 122.1, 124.4, 127.4, 130, 132, 135, 140, 142, 146}

    'Dim lblObstacles As Object

    Private Sub GameForm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

    End Sub
    Private Sub GameForm_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp

    End Sub

    Private Sub jumpTimer_Tick(sender As Object, e As EventArgs) Handles jumpTimer.Tick
        ' start jumping
        If (intJumpStep >= 0 And intJumpStep <= 5) Then
            ' x and y
            Dim dx As Integer = pictPlayer.Location.X
            Dim dy As Integer = pictPlayer.Location.Y
            pictPlayer.Location = New Point(dx, dy - 20)
            intJumpStep += 1
        ElseIf (intJumpStep >= 6 And intJumpStep <= 11) Then
            ' x and y
            Dim dx As Integer = pictPlayer.Location.X
            Dim dy As Integer = pictPlayer.Location.Y
            pictPlayer.Location = New Point(dx, dy + 20)
            intJumpStep += 1
        Else
            jumpTimer.Stop()
        End If

    End Sub

    Private Sub GameForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' JUMP TEST!
        ' get key press
        ' http://stackoverflow.com/questions/10663193/handling-keycode-keychar-events-in-windows-form-textbox-control
        ' http://vbcity.com/forums/t/89334.aspx

        ' CTRL+K, CTRL+C - comment multiple lines
        'If e.KeyCode = Keys.J Then
        '    ' jump test
        '    jumpTimer.Start()
        '    'MessageBox.Show("it works")
        '    If intJumpStep = 12 Then
        '        intJumpStep = 0
        '    End If
        '    ' create a new obstacle
        '    createNewObstacle(510, 120)
        '    'PictureBox2.Imag()
        'End If
        If e.KeyCode = Keys.Space Then
            ' jump test
            jumpTimer.Start()
            'MessageBox.Show("it works")
            If intJumpStep = 12 Then
                intJumpStep = 0
            End If
            ' CRUCIAL for multiple keypresses
        ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.E AndAlso e.Modifiers = Keys.Control Then
            My.Computer.Audio.Stop()
            Me.Close()
        Else
            testForCorrectKey(e.KeyCode)
            If intNumOfEasterEggKeysPressed = 6 Then
                boolInvincibility = True
                pictPlayer.Hide()
            End If
        End If

    End Sub

    Private Sub testForCorrectKey(keyPressedKey As Keys)
        ' cheat code: down up C 4 x l
        ' TODO: BUG: 4 as the easter egg key will not work if it is pressed on the numpad
        Dim keyCorrectKey As Keys
        Select Case intNumOfEasterEggKeysPressed
            Case 0
                keyCorrectKey = Keys.Down
            Case 1
                keyCorrectKey = Keys.Up
            Case 2
                keyCorrectKey = Keys.C
            Case 3
                keyCorrectKey = Keys.D4
            Case 4
                keyCorrectKey = Keys.X
            Case 5
                keyCorrectKey = Keys.L
        End Select
        If keyPressedKey = keyCorrectKey Then
            intNumOfEasterEggKeysPressed += 1
            'MessageBox.Show("yay")
        Else
            intNumOfEasterEggKeysPressed = 0
        End If
    End Sub

    Private Sub createNewObstacle(intX As Integer, intY As Integer)
        ' test paint
        ' http://www.techotopia.com/index.php/Drawing_Graphics_in_Visual_Basic
        ' 12, 82 picturebox coordinates
        ' 289 = y for bottom of box
        ' 961 = x for right of box
        ' 12, 289 clear graphics
        ' 961, 289 create graphics for box
        ' http://www.vbasic.net/draw-graphics-using-visual-basic/

        ' use control as graphics to paint over
        ' http://www.vbforums.com/showthread.php?646616-RESOLVED-Painting-Over-Controls

        'myGraphics.FillRectangle(blueBrush, 561, 189, 20, 60)
        'Dim x As Rectangle = New Rectangle(961, 289, 20, 60)
        'Dim x As Rectangle = New Rectangle(900, 100, 20, 80)

        ' NEW COORDINATES
        ' 12, 289 clear graphics
        ' 510, 120 create graphics for box
        rectCurrent = New Rectangle(intX, intY, 20, 60)
        myGraphics.FillRectangle(colorBrush, rectCurrent)
        'clearGraphics(intObstDx, intObstDy)
        intObstDx = intX
        intObstDy = intY
        obstacleTimer.Start()
        'myGraphics.

        'myGraphics.FillRectangle(blueBrush, 0, 0, 20, 60)
    End Sub

    Private Sub GameForm_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

    End Sub

    Private Sub obstacleTimer_Tick(sender As Object, e As EventArgs) Handles obstacleTimer.Tick
        ' start moving obstacle
        'Dim dx = intObstDx
        'Dim dy = intObstDy

        If (intObstacleStep >= 0 And intObstacleStep <= 16) Then
            ' x and y
            'Dim myGraphics As Graphics = pictBgd.CreateGraphics
            'Dim blueBrush As New Drawing.SolidBrush(Color.Blue)
            'myGraphics.FillRectangle(blueBrush, 561, 189, 20, 60)
            'Dim x As Rectangle = New Rectangle(961, 289, 20, 60)
            'Dim x As Rectangle = New Rectangle(900, 100, 20, 80)

            ' NEW COORDINATES
            ' 12, 289 clear graphics
            ' 510, 120 create graphics for box


            'clearGraphics(intObstDx, intObstDy)
            pictBgd.Refresh()
            createNewObstacle(intObstDx, intObstDy)
            intObstDx -= 15
            intObstacleStep += 1
            ' be lenient, doesn't have to be in the exact timing as the player
            Dim rectObstacle As Rectangle = New Rectangle(intObstDx + 10, intObstDy + 40, 10, 20)
            If (pictPlayer.Bounds.IntersectsWith(rectObstacle) And alreadyShowedMsgBox = 0 And boolInvincibility = False) Then
                ' GAME OVER!
                ' save memory by stopping audio
                'musicTimer.Stop()
                intCurrentMusicStep = 0
                My.Computer.Audio.Stop()
                alreadyShowedMsgBox = 1
                Dim mbrResult = MessageBox.Show("Game Over!", "Play again?", MessageBoxButtons.OK, MessageBoxIcon.Error)

                If (mbrResult = Windows.Forms.DialogResult.OK) Then
                    ' reset music and jump
                    intCurrentMusicTime = 0
                    intJumpStep = 0
                    intCurrentMusicStep = 0
                    ' add 1 to attempt counter
                    intNumAttempts += 1
                    lblNumAttempts.Text = "Attempts: " + Convert.ToString(intNumAttempts)
                    'Dim intObstacles As Integer = 0
                    'Dim arrObstacles() As Integer

                    ' reset variables
                    intObstacleStep = 16
                    intObstDx = -900
                    intObstDy = -900
                    intSuccessObstacles = 0
                    lblObstacles.Text = "Obstacle #: " + Convert.ToString(intSuccessObstacles)

                    ' clear timers to free memory
                    obstacleTimer.Stop()
                    jumpTimer.Stop()
                    musicTimer.Stop()
                    pictBgd.Refresh()
                    ' stop music
                    My.Computer.Audio.Stop()
                    Select Case intDifficulty
                        Case 1
                            My.Computer.Audio.Play(My.Resources.TimeLeap_EZ, AudioPlayMode.Background)
                        Case 2
                            My.Computer.Audio.Play(My.Resources.FinalBattle_INT, AudioPlayMode.Background)
                            ' HARD MODE... OH NO.
                        Case 3
                            My.Computer.Audio.Play(My.Resources.Kurorak_Artha_HRD, AudioPlayMode.Background)
                    End Select
                    pictPlayer.Location = ptPlayerLoc
                    musicTimer.Start()
                    alreadyShowedMsgBox = 0
                End If
            Else

                intObstacleStep = 0

                'obstacleTimer.Stop()
            End If
            ' old method
            'If (pictPlayer.Bounds.IntersectsWith(rectCurrent)) Then
            '    MessageBox.Show("Game Over!", "Play again?", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    'MessageBox.Show("collision")
            'End If
        End If


    End Sub

    Private Sub GameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myGraphics = pictBgd.CreateGraphics
        txtName.Hide()
        btnRegisterHS.Hide()
        If (My.Settings.boolListenMode = True) Then

        Else
            musicTimer.Start()
        End If

        ' !! Don't just add to resources folder, go to my project!!
        Select Case intDifficulty
            Case 1
                My.Computer.Audio.Play(My.Resources.TimeLeap_EZ, AudioPlayMode.Background)
                ' have brush remain its blue color
            Case 2
                My.Computer.Audio.Play(My.Resources.FinalBattle_INT, AudioPlayMode.Background)
                ' for fun GFX, change brush to yellow for medium
                colorBrush.Color = Color.Yellow
            Case 3
                My.Computer.Audio.Play(My.Resources.Kurorak_Artha_HRD, AudioPlayMode.Background)
                ' and RED FOR HARD!!!!
                colorBrush.Color = Color.Red
        End Select


        ' get player location for future use
        ptPlayerLoc = pictPlayer.Location
        'My.Computer.Audio.Play(, AudioPlayMode.Background)

        ' stop music
        'My.Computer.Audio.Stop()

        'MessageBox.Show(convertToMillisecond(dblArrEZSongTimes(intCurrentMusicStep)))
        'intArrSongTimes(1)
    End Sub
    Private Sub clearGraphics(intX As Integer, intY As Integer)
        'myGraphics.FillRectangle(eraser, intX + 7, intY, 20, 60)
    End Sub

    Function convertToMillisecond(dblSecond As Double)
        Dim intMillisecond As Integer = dblSecond * 1000
        Return intMillisecond
    End Function


    Private Sub musicTimer_Tick(sender As Object, e As EventArgs) Handles musicTimer.Tick
        Dim intNextMS As Integer
        Try
            Select Case intDifficulty
                Case 1
                    intNextMS = convertToMillisecond(dblArrEZSongTimes(intCurrentMusicStep))
                Case 2
                    intNextMS = convertToMillisecond(dblArrINTSongTimes(intCurrentMusicStep))
                Case 3
                    intNextMS = convertToMillisecond(dblArrHRDSongTimes(intCurrentMusicStep))
            End Select
        Catch ex As Exception
            ' if outside the bounds of the array... (then you win!)
            musicTimer.Stop()
            obstacleTimer.Stop()
            ' reset variables
            intObstacleStep = 16
            intObstDx = -900
            intObstDy = -900
            My.Computer.Audio.Stop()
            intSuccessObstacles += 1
            lblObstacles.Text = "Obstacle #: " + Convert.ToString(intSuccessObstacles)
            If boolInvincibility = False Then
                MessageBox.Show("You win with " + Convert.ToString(intNumAttempts) + " attempts! Congratulations!", "Yay!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Select Case intDifficulty
                    Case 1
                        If My.Settings.intHighScoreEZ = 0 Or intNumAttempts < My.Settings.intHighScoreEZ Then
                            My.Settings.intHighScoreEZ = intNumAttempts
                            MessageBox.Show("New high score for easy mode!", "High Score", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            btnRegisterHS.Show()
                            txtName.Show()
                        End If
                    Case 2
                        If My.Settings.intHighScoreINT = 0 Or intNumAttempts < My.Settings.intHighScoreINT Then
                            My.Settings.intHighScoreINT = intNumAttempts
                            MessageBox.Show("New high score for normal mode!", "High Score", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            btnRegisterHS.Show()
                            txtName.Show()
                        End If
                    Case 3
                        If My.Settings.intHighScoreHRD = 0 Or intNumAttempts < My.Settings.intHighScoreHRD Then
                            My.Settings.intHighScoreHRD = intNumAttempts
                            MessageBox.Show("New high score for hard mode!", "High Score", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            btnRegisterHS.Show()
                            txtName.Show()
                        End If
                End Select
            End If
            intNumAttempts = 1
        End Try

        'MessageBox.Show(intNextMS)

        intCurrentMusicTime += 50
        'lblNumAttempts.Text = "DEBUG MS: " + intCurrentMusicTime.ToString()
        'lblDifficulty.Text = "DEBUG MS: " + intNextMS.ToString()
        If (Convert.ToUInt32(intCurrentMusicTime) + 650) = Convert.ToUInt32(intNextMS) And intDifficulty = 1 Then
            'MessageBox.Show("yay")
            createNewObstacle(510, 120)
            intSuccessObstacles += 1
            lblObstacles.Text = "Obstacle #: " + Convert.ToString(intSuccessObstacles)
            intCurrentMusicStep += 1
            ' make it harder! (faster obstacles)
        ElseIf (Convert.ToUInt32(intCurrentMusicTime) + 450) = Convert.ToUInt32(intNextMS) And intDifficulty = 2 Then
            'MessageBox.Show("yay")
            createNewObstacle(410, 120)
            intSuccessObstacles += 1
            lblObstacles.Text = "Obstacle #: " + Convert.ToString(intSuccessObstacles)
            intCurrentMusicStep += 1
            ' HARD MODE. PREPARE FOR MADNESS!
        ElseIf (Convert.ToUInt32(intCurrentMusicTime) + 400) = Convert.ToUInt32(intNextMS) And intDifficulty = 3 Then
            'MessageBox.Show("yay")
            createNewObstacle(350, 120)
            intSuccessObstacles += 1
            lblObstacles.Text = "Obstacle #: " + Convert.ToString(intSuccessObstacles)
            intCurrentMusicStep += 1
        End If
        'intCurrentMusicStep += 1
    End Sub

    Private Sub lblNumAttempts_Click(sender As Object, e As EventArgs) Handles lblNumAttempts.Click

    End Sub

    ' this method is called through ctrl+e (quit key combination) or by pressing x or closing some other way (in-game)
    ' BUG: this doesn't work on the mainform, it will get closed too
    Private Sub GameForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Computer.Audio.Stop() ' BUG: This method doesn't work with Mono, resulting in continuous audio. Potentially use Naudio library?
        My.Settings.intIsFormLoaded = 0
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub btnRegisterHS_Click(sender As Object, e As EventArgs) Handles btnRegisterHS.Click
        Select Case intDifficulty
            Case 1
                My.Settings.strEZName = txtName.Text
            Case 2
                My.Settings.strINTName = txtName.Text
            Case 3
                My.Settings.strHRDName = txtName.Text
        End Select
        MessageBox.Show("Registered!")
        btnRegisterHS.Hide()
        txtName.Hide()
    End Sub
End Class