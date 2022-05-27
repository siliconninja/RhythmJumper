Imports System.Runtime.InteropServices

Public Class InitialForm
    Dim intTempDifficulty As Integer = 1
    'Dim intTempIsFormShown As Integer = 0

    ' uuddlrlrba
    Dim intCurrentIndex As Integer = 0
    Dim boolKeyPresses() As Boolean = {False, False, False, False, False, False, False, False, False, False}
    Dim boolEasterEggListenMode As Boolean = False

    ' https://stackoverflow.com/questions/5702669/how-to-open-notepad-from-a-windows-forms-application-and-place-some-text-in-it
    ' hex value stored as an int value for send message function - https://msdn.microsoft.com/en-us/library/windows/desktop/ms632644(v=vs.85).aspx
    ' Const WM_SETTEXT As Integer = &HC
    '<DllImport("user32.dll")>
    'Private Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As IntPtr, <MarshalAs(UnmanagedType.LPStr)> lParam As String) As IntPtr
    'End Function

    Private Sub InitialForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.intIsFormLoaded = 0


    End Sub



    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        MessageBox.Show("Programmed by SiliconNinja" + Environment.NewLine +
                        "Game idea inspired by Geometry Dash" + Environment.NewLine +
                        "Music credits:" + Environment.NewLine +
                        "Easy: Time Leap by Aero Chord" + Environment.NewLine +
                        "(non-commercial license by NCS (youtube.com/user/NoCopyrightSounds/about)," + Environment.NewLine +
                        "original upload: soundcloud.com/aerochordmusic/time-leap-original-mix-1)" + Environment.NewLine +
                        "Medium: Final Battle by Waterflame" + Environment.NewLine +
                        "(non-commercial license, credit: www.youtube.com/waterflame89)" + Environment.NewLine +
                        "Hard: Kurorak - Artha: https://youtu.be/5M61dsEQ1f0" + Environment.NewLine +
                        "Modified (trimmed length of song), song licensed under CC-BY 3.0" + Environment.NewLine +
                        "Easter Egg 2: Final Battle by Waterflame" + Environment.NewLine +
                        "(non-commercial license, credit: www.youtube.com/waterflame89)" + Environment.NewLine +
                        "For full licensing information please find the LICENSE and LICENSE.songs in the program resources folder, or visit:" + Environment.NewLine +
                        "https://raw.githubusercontent.com/siliconninja/RhythmJumper/master/LICENSE", "Credits", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub radEasy_CheckedChanged(sender As Object, e As EventArgs) Handles radEasy.CheckedChanged
        intTempDifficulty = 1
    End Sub

    Private Sub radNormal_CheckedChanged(sender As Object, e As EventArgs) Handles radNormal.CheckedChanged
        intTempDifficulty = 2
    End Sub

    Private Sub radHard_CheckedChanged(sender As Object, e As EventArgs) Handles radHard.CheckedChanged
        intTempDifficulty = 3
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If My.Settings.intIsFormLoaded = 0 Then
            My.Settings.intDifficulty = intTempDifficulty
            My.Settings.boolListenMode = boolEasterEggListenMode
            Dim x As GameForm = New GameForm()
            x.Show()
            My.Settings.intIsFormLoaded = 1
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnEasterEggs_Click(sender As Object, e As EventArgs) Handles btnEasterEggs.Click
        Dim mbrResult = MessageBox.Show("Hint #1: Have you played Contra before or heard of it?" + Environment.NewLine +
                                        "Hint #2: Fill in the blank: The quick brown dog jumps over the lazy ___." + Environment.NewLine +
                                        "Hint #3: Hmmm... I don't feel like giving a hint. Click Cancel for more. (Press the keys to activate the easter egg while in the game window)",
                                        "Hints", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If (mbrResult = Windows.Forms.DialogResult.Cancel) Then

            ' notepad process info and parameters
            'Dim psiNotepad As ProcessStartInfo = New ProcessStartInfo("notepad.exe")
            'psiNotepad.UseShellExecute = True

            'Dim notepad As Process = Process.Start(psiNotepad) ' start notepad and attach it to notepad pointer (obj ref) for control

            Dim strEEHTextFileContent As String = My.Resources.EasterEggHints_md

            MessageBox.Show(strEEHTextFileContent, "Easter Egg Hints", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'SendMessage(notepad.MainWindowHandle, WM_SETTEXT, IntPtr.Zero, strEEHTextFileContent) ' send message to notepad process
        End If
    End Sub

    Private Sub testForKeyPress(intArrIndex As Integer, keyCode As System.Windows.Forms.Keys, correctKeyCode As System.Windows.Forms.Keys)
        ' silly workaround but might work
        'boolKeyPresses(-1) = True
        If intArrIndex > 0 Then
            If keyCode = correctKeyCode And boolKeyPresses(intArrIndex - 1) = True Then
                boolKeyPresses(intArrIndex) = True
                'MessageBox.Show("Correct " + intArrIndex.ToString())
                intCurrentIndex += 1
            ElseIf (keyCode <> correctKeyCode) And boolKeyPresses(intArrIndex - 1) = True Then
                boolKeyPresses = {False, False, False, False, False, False, False, False, False, False}
                intCurrentIndex = 0
            End If
        ElseIf intArrIndex = 0 Then
            If keyCode = correctKeyCode Then
                boolKeyPresses(intArrIndex) = True
                'MessageBox.Show("Correct " + intArrIndex.ToString())
                intCurrentIndex += 1
            ElseIf (keyCode <> correctKeyCode) Then
                boolKeyPresses = {False, False, False, False, False, False, False, False, False, False}
                intCurrentIndex = 0
            End If
        End If

        'If keyCode = correctKeyCode Then
        '    boolKeyPresses(intArrIndex) = True
        '    MessageBox.Show("Correct " + intArrIndex)
        'Else
        '    boolKeyPresses = {False, False, False, False, False, False, False, False, False, False}
        'End If

    End Sub

    Private Sub InitialForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'If e.KeyValue = Keys.Up Then
        'MessageBox.Show("test")
        'End If
    End Sub

    Private Sub InitialForm_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles MyBase.PreviewKeyDown
        'Me.KeyPreview = True
        'If e.KeyCode = Keys.Up Then
        '    boolKeyPresses(0) = True
        'End If
        'If boolKeyPresses(0) = True Then
        'testForKeyPress(0, e.KeyCode, Keys.Up)

        'testForKeyPress(2, e.KeyCode, Keys.Down)
        'MessageBox.Show(e.KeyCode)
        'End If
        'e.IsInputKey = True
    End Sub

    Private Sub InitialForm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

    End Sub
    ' source https://amalhashim.wordpress.com/2013/12/04/vb-net-keydown-event-not-firing-with-winform-application/
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keydata As Keys) As Boolean
        'If keydata = Keys.Up Then
        'MessageBox.Show("test")
        'End If
        Dim keyCorrectKey As Keys
        Select Case intCurrentIndex
            Case 0
                keyCorrectKey = Keys.Up
            Case 1
                keyCorrectKey = Keys.Up
            Case 2
                keyCorrectKey = Keys.Down
            Case 3
                keyCorrectKey = Keys.Down
            Case 4
                keyCorrectKey = Keys.Left
            Case 5
                keyCorrectKey = Keys.Right
            Case 6
                keyCorrectKey = Keys.Left
            Case 7
                keyCorrectKey = Keys.Right
            Case 8
                keyCorrectKey = Keys.B
            Case 9
                keyCorrectKey = Keys.A
                'MessageBox.Show("Easter egg 3 success!")
        End Select
        testForKeyPress(intCurrentIndex, keydata, keyCorrectKey)
        If intCurrentIndex = 10 Then
            lblEasterEggText.Text = "Easter Egg: Listening Mode!"
            boolEasterEggListenMode = True
        End If
        'Return True
    End Function

    Private Sub txtEasterEggCode_TextChanged(sender As Object, e As EventArgs) Handles txtEasterEggCode.TextChanged
        If txtEasterEggCode.Text = "fox" Then
            lblEasterEggText.Text = "Easter Egg: Game music!"
            boolEasterEggListenMode = False
            My.Computer.Audio.Play(My.Resources.FinalBattle_INT, AudioPlayMode.BackgroundLoop)
            'pictFakeBgd.Image = My.Resources.RickAstley
            btnStart.Text = "Enjoy! (Type xof in the easter egg box to stop)"
            btnStart.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Underline)
            btnStart.Enabled = False
            btnExit.Enabled = False
            btnExit.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Underline)
            btnExit.Text = "Now you can't exit!"
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        ElseIf txtEasterEggCode.Text = "xof" Then
            lblEasterEggText.Text = "Easter Egg: Silence!"
            boolEasterEggListenMode = False
            My.Computer.Audio.Stop()
            'pictFakeBgd.Image = My.Resources.RhythmJumper_Background_MainMenu
            btnStart.Text = "Start Game"
            btnStart.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Regular)
            btnStart.Enabled = True
            btnExit.Enabled = True
            btnExit.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Regular)
            btnExit.Text = "Exit"
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        End If
    End Sub

    Private Sub btnHighScores_Click(sender As Object, e As EventArgs) Handles btnHighScores.Click
        Dim strMsgBoxString As String = "HALL OF FAME" + Environment.NewLine +
            "Easy: " + My.Settings.strEZName +
            " / " + My.Settings.intHighScoreEZ.ToString() + Environment.NewLine +
            "Normal: " + My.Settings.strINTName +
            " / " + My.Settings.intHighScoreINT.ToString() + Environment.NewLine +
            "Hard: " + My.Settings.strHRDName +
            " / " + My.Settings.intHighScoreHRD.ToString() + Environment.NewLine

        MessageBox.Show(strMsgBoxString, "High Scores!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
End Class
