﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InitialForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InitialForm))
        Me.lblGameName = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radHard = New System.Windows.Forms.RadioButton()
        Me.radNormal = New System.Windows.Forms.RadioButton()
        Me.radEasy = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnHighScores = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnEasterEggs = New System.Windows.Forms.Button()
        Me.lblEasterEggText = New System.Windows.Forms.Label()
        Me.lblCodeEnterMessage = New System.Windows.Forms.Label()
        Me.pictPlayer = New System.Windows.Forms.PictureBox()
        Me.pictFakeBgd = New System.Windows.Forms.PictureBox()
        Me.btnLicenseInfo = New System.Windows.Forms.Button()
        Me.btnSongLicenseInfo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEasterEggCode = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pictPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictFakeBgd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGameName
        '
        Me.lblGameName.AutoSize = True
        Me.lblGameName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameName.ForeColor = System.Drawing.Color.White
        Me.lblGameName.Location = New System.Drawing.Point(312, 5)
        Me.lblGameName.Name = "lblGameName"
        Me.lblGameName.Size = New System.Drawing.Size(180, 29)
        Me.lblGameName.TabIndex = 0
        Me.lblGameName.Text = "Rhythm Jumper"
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(35, 396)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(149, 60)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start Game"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(664, 396)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(149, 60)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radHard)
        Me.GroupBox1.Controls.Add(Me.radNormal)
        Me.GroupBox1.Controls.Add(Me.radEasy)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(21, 129)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(163, 108)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose"
        '
        'radHard
        '
        Me.radHard.AutoSize = True
        Me.radHard.Location = New System.Drawing.Point(13, 75)
        Me.radHard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radHard.Name = "radHard"
        Me.radHard.Size = New System.Drawing.Size(96, 20)
        Me.radHard.TabIndex = 4
        Me.radHard.Text = "Hard Mode"
        Me.radHard.UseVisualStyleBackColor = True
        '
        'radNormal
        '
        Me.radNormal.AutoSize = True
        Me.radNormal.Location = New System.Drawing.Point(13, 48)
        Me.radNormal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radNormal.Name = "radNormal"
        Me.radNormal.Size = New System.Drawing.Size(110, 20)
        Me.radNormal.TabIndex = 3
        Me.radNormal.Text = "Normal Mode"
        Me.radNormal.UseVisualStyleBackColor = True
        '
        'radEasy
        '
        Me.radEasy.AutoSize = True
        Me.radEasy.Checked = True
        Me.radEasy.Location = New System.Drawing.Point(13, 21)
        Me.radEasy.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radEasy.Name = "radEasy"
        Me.radEasy.Size = New System.Drawing.Size(97, 20)
        Me.radEasy.TabIndex = 2
        Me.radEasy.TabStop = True
        Me.radEasy.Text = "Easy Mode"
        Me.radEasy.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(659, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 32)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Instructions"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(661, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 144)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "SPACE to jump." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press Ctrl+E while in-game" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to quit game." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If you land on an ob" &
    "stacle, you" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "have to start over." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Some obstacles are tricks" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and don't go all " &
    "the way ;)"
        '
        'btnHighScores
        '
        Me.btnHighScores.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnHighScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHighScores.Location = New System.Drawing.Point(357, 396)
        Me.btnHighScores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHighScores.Name = "btnHighScores"
        Me.btnHighScores.Size = New System.Drawing.Size(155, 60)
        Me.btnHighScores.TabIndex = 6
        Me.btnHighScores.Text = "High Scores"
        Me.btnHighScores.UseVisualStyleBackColor = False
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAbout.Location = New System.Drawing.Point(209, 68)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnAbout.TabIndex = 0
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'btnEasterEggs
        '
        Me.btnEasterEggs.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEasterEggs.Location = New System.Drawing.Point(512, 68)
        Me.btnEasterEggs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEasterEggs.Name = "btnEasterEggs"
        Me.btnEasterEggs.Size = New System.Drawing.Size(125, 23)
        Me.btnEasterEggs.TabIndex = 9
        Me.btnEasterEggs.Text = "Easter Egg Hints"
        Me.btnEasterEggs.UseVisualStyleBackColor = False
        '
        'lblEasterEggText
        '
        Me.lblEasterEggText.AutoSize = True
        Me.lblEasterEggText.ForeColor = System.Drawing.Color.White
        Me.lblEasterEggText.Location = New System.Drawing.Point(32, 254)
        Me.lblEasterEggText.Name = "lblEasterEggText"
        Me.lblEasterEggText.Size = New System.Drawing.Size(101, 16)
        Me.lblEasterEggText.TabIndex = 11
        Me.lblEasterEggText.Text = "Easter Egg: ???"
        '
        'lblCodeEnterMessage
        '
        Me.lblCodeEnterMessage.AutoSize = True
        Me.lblCodeEnterMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodeEnterMessage.ForeColor = System.Drawing.Color.White
        Me.lblCodeEnterMessage.Location = New System.Drawing.Point(729, 302)
        Me.lblCodeEnterMessage.Name = "lblCodeEnterMessage"
        Me.lblCodeEnterMessage.Size = New System.Drawing.Size(84, 16)
        Me.lblCodeEnterMessage.TabIndex = 14
        Me.lblCodeEnterMessage.Text = "Enter Code"
        '
        'pictPlayer
        '
        Me.pictPlayer.Image = Global.RhythmJumper.My.Resources.Resources.RJ_Person
        Me.pictPlayer.Location = New System.Drawing.Point(395, 252)
        Me.pictPlayer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pictPlayer.Name = "pictPlayer"
        Me.pictPlayer.Size = New System.Drawing.Size(49, 100)
        Me.pictPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictPlayer.TabIndex = 9
        Me.pictPlayer.TabStop = False
        '
        'pictFakeBgd
        '
        Me.pictFakeBgd.Image = Global.RhythmJumper.My.Resources.Resources.RhythmJumper_Background_MainMenu
        Me.pictFakeBgd.Location = New System.Drawing.Point(155, 117)
        Me.pictFakeBgd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pictFakeBgd.Name = "pictFakeBgd"
        Me.pictFakeBgd.Size = New System.Drawing.Size(528, 235)
        Me.pictFakeBgd.TabIndex = 10
        Me.pictFakeBgd.TabStop = False
        '
        'btnLicenseInfo
        '
        Me.btnLicenseInfo.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLicenseInfo.Location = New System.Drawing.Point(342, 59)
        Me.btnLicenseInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLicenseInfo.Name = "btnLicenseInfo"
        Me.btnLicenseInfo.Size = New System.Drawing.Size(102, 23)
        Me.btnLicenseInfo.TabIndex = 15
        Me.btnLicenseInfo.Text = "License Info"
        Me.btnLicenseInfo.UseVisualStyleBackColor = False
        '
        'btnSongLicenseInfo
        '
        Me.btnSongLicenseInfo.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSongLicenseInfo.Location = New System.Drawing.Point(325, 88)
        Me.btnSongLicenseInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSongLicenseInfo.Name = "btnSongLicenseInfo"
        Me.btnSongLicenseInfo.Size = New System.Drawing.Size(144, 23)
        Me.btnSongLicenseInfo.TabIndex = 16
        Me.btnSongLicenseInfo.Text = "Song License Info"
        Me.btnSongLicenseInfo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(321, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 24)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "v1.0.1 - 5/26/2022"
        '
        'txtEasterEggCode
        '
        Me.txtEasterEggCode.Location = New System.Drawing.Point(689, 330)
        Me.txtEasterEggCode.Name = "txtEasterEggCode"
        Me.txtEasterEggCode.Size = New System.Drawing.Size(170, 22)
        Me.txtEasterEggCode.TabIndex = 18
        '
        'InitialForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(885, 468)
        Me.Controls.Add(Me.txtEasterEggCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSongLicenseInfo)
        Me.Controls.Add(Me.btnLicenseInfo)
        Me.Controls.Add(Me.lblCodeEnterMessage)
        Me.Controls.Add(Me.lblEasterEggText)
        Me.Controls.Add(Me.btnEasterEggs)
        Me.Controls.Add(Me.pictPlayer)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnHighScores)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblGameName)
        Me.Controls.Add(Me.pictFakeBgd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "InitialForm"
        Me.Text = "Main Menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pictPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictFakeBgd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGameName As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radHard As System.Windows.Forms.RadioButton
    Friend WithEvents radNormal As System.Windows.Forms.RadioButton
    Friend WithEvents radEasy As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnHighScores As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents pictPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents pictFakeBgd As System.Windows.Forms.PictureBox
    Friend WithEvents btnEasterEggs As System.Windows.Forms.Button
    Friend WithEvents lblEasterEggText As System.Windows.Forms.Label
    Friend WithEvents lblCodeEnterMessage As System.Windows.Forms.Label
    Friend WithEvents btnLicenseInfo As Button
    Friend WithEvents btnSongLicenseInfo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEasterEggCode As TextBox
End Class
