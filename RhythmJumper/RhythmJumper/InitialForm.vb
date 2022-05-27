Imports System.Runtime.InteropServices

Public Class InitialForm
    Dim intTempDifficulty As Integer = 1

    Dim intCurrentIndex As Integer = 0
    Dim boolKeyPresses() As Boolean = {False, False, False, False, False, False, False, False, False, False}
    Dim boolEasterEggListenMode As Boolean = False

    Enum SongEnum
        Easy
        Intermediate
        Hard
    End Enum

    Private Sub InitialForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.intIsFormLoaded = 0
    End Sub
    Protected Sub playSong(SongDifficulty As SongEnum)
        My.Computer.Audio.Stop()
        If SongDifficulty = SongEnum.Easy Then
            ' Song TBD
        ElseIf SongDifficulty = SongEnum.Intermediate Then
            My.Computer.Audio.Play(My.Resources.FinalBattle_INT, AudioPlayMode.BackgroundLoop)
        ElseIf SongDifficulty = SongEnum.Hard Then
            My.Computer.Audio.Play(My.Resources.Kurorak_Artha_HRD, AudioPlayMode.BackgroundLoop)
        End If
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        MessageBox.Show("Programmed by siliconninja" + Environment.NewLine +
                        "Game idea inspired by Geometry Dash" + Environment.NewLine +
                        "Music credits:" + Environment.NewLine +
                        "Easy: TBD" + Environment.NewLine +
                        "Medium: Final Battle by Waterflame" + Environment.NewLine +
                        "(non-commercial license, credit: www.youtube.com/waterflame89)" + Environment.NewLine +
                        "Hard: Kurorak - Artha: https://youtu.be/5M61dsEQ1f0" + Environment.NewLine +
                        "Modified (trimmed length of song), song licensed under CC-BY 3.0" + Environment.NewLine +
                        "Easter Egg 2: Final Battle by Waterflame" + Environment.NewLine +
                        "(non-commercial license, credit: www.youtube.com/waterflame89)" + Environment.NewLine +
                        "For full licensing information please either click the License Info/Song License Info buttons on the main menu screen, " + Environment.NewLine +
                        "find the LICENSE and LICENSE.songs files in the program resources folder, or visit: " + Environment.NewLine +
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
            Dim gameForm As GameForm = New GameForm()
            gameForm.Show()
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
            Dim strEEHTextFileContent As String = My.Resources.EasterEggHints_md

            MessageBox.Show(strEEHTextFileContent, "Easter Egg Hints", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub testForKeyPress(intArrIndex As Integer, keyCode As System.Windows.Forms.Keys, correctKeyCode As System.Windows.Forms.Keys)
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
                intCurrentIndex += 1
            ElseIf (keyCode <> correctKeyCode) Then
                boolKeyPresses = {False, False, False, False, False, False, False, False, False, False}
                intCurrentIndex = 0
            End If
        End If
    End Sub

    ' source https://amalhashim.wordpress.com/2013/12/04/vb-net-keydown-event-not-firing-with-winform-application/
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keydata As Keys) As Boolean
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
        End Select
        testForKeyPress(intCurrentIndex, keydata, keyCorrectKey)
        If intCurrentIndex = 10 Then
            lblEasterEggText.Text = "Easter Egg: Listening Mode!"
            playSong(SongEnum.Hard)
            boolEasterEggListenMode = True
        End If
        ' While we want to have the Windows APIs recognize that the key was processed,
        ' we also want to allow for editing of the easter egg code text box.
        ' Returning True will suppress other key presses, such as in the text box, which we don't want.
        ' https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.processcmdkey?view=windowsdesktop-6.0
        Return False
    End Function

    Private Sub txtEasterEggCode_TextChanged(sender As Object, e As EventArgs) Handles txtEasterEggCode.TextChanged
        If txtEasterEggCode.Text = "fox" Then
            lblEasterEggText.Text = "Easter Egg: Game music!"
            boolEasterEggListenMode = False
            playSong(SongEnum.Intermediate)
            'pictFakeBgd.Image = My.Resources.RickAstley
            btnStart.Text = "Enjoy! (Type xof in the easter egg box to stop)"
            btnStart.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Underline)
            btnStart.Enabled = False
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

    Protected Sub showFile(ResourceString As String)
        Using Reader As System.IO.TextReader = New System.IO.StringReader(ResourceString)
            Dim Text As String = Reader.ReadToEnd()
            For i As Int16 = 1 To 20 Step 1
                Dim startPos = ((i - 1) * Text.Length / 20)
                Dim PartOfText
                Try
                    ' Does type inference in VB save the day in 2022?
                    PartOfText = Text.Substring(startPos, Text.Length / 20)
                    If i = 20 Then
                        PartOfText = Text.Substring(startPos - 1)
                    End If
                Catch
                    PartOfText = Text.Substring(startPos)
                End Try
                MessageBox.Show(PartOfText, "License info - " & i & "/20", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Next
        End Using
    End Sub

    Private Sub btnLicenseInfo_Click(sender As Object, e As EventArgs) Handles btnLicenseInfo.Click
        showFile(My.Resources.LICENSE)
    End Sub

    Private Sub btnSongLicenseInfo_Click(sender As Object, e As EventArgs) Handles btnSongLicenseInfo.Click
        showFile(My.Resources.LICENSE_SONGS)
    End Sub
End Class
