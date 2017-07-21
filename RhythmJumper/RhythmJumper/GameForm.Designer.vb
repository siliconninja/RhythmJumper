<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameForm))
        Me.lblNumAttempts = New System.Windows.Forms.Label()
        Me.jumpTimer = New System.Windows.Forms.Timer(Me.components)
        Me.obstacleTimer = New System.Windows.Forms.Timer(Me.components)
        Me.musicTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblObstacles = New System.Windows.Forms.Label()
        Me.pictPlayer = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictBgd = New System.Windows.Forms.PictureBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnRegisterHS = New System.Windows.Forms.Button()
        CType(Me.pictPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictBgd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNumAttempts
        '
        Me.lblNumAttempts.AutoSize = True
        Me.lblNumAttempts.ForeColor = System.Drawing.Color.White
        Me.lblNumAttempts.Location = New System.Drawing.Point(9, 237)
        Me.lblNumAttempts.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumAttempts.Name = "lblNumAttempts"
        Me.lblNumAttempts.Size = New System.Drawing.Size(60, 13)
        Me.lblNumAttempts.TabIndex = 1
        Me.lblNumAttempts.Text = "Attempts: 1"
        '
        'jumpTimer
        '
        Me.jumpTimer.Interval = 50
        '
        'obstacleTimer
        '
        Me.obstacleTimer.Interval = 50
        '
        'musicTimer
        '
        Me.musicTimer.Interval = 50
        '
        'lblObstacles
        '
        Me.lblObstacles.AutoSize = True
        Me.lblObstacles.ForeColor = System.Drawing.Color.White
        Me.lblObstacles.Location = New System.Drawing.Point(652, 237)
        Me.lblObstacles.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObstacles.Name = "lblObstacles"
        Me.lblObstacles.Size = New System.Drawing.Size(71, 13)
        Me.lblObstacles.TabIndex = 7
        Me.lblObstacles.Text = "Obstacle #: 0"
        '
        'pictPlayer
        '
        Me.pictPlayer.BackColor = System.Drawing.Color.Black
        Me.pictPlayer.Image = Global.RhythmJumper.My.Resources.Resources.RJ_Person
        Me.pictPlayer.Location = New System.Drawing.Point(64, 174)
        Me.pictPlayer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pictPlayer.Name = "pictPlayer"
        Me.pictPlayer.Size = New System.Drawing.Size(27, 59)
        Me.pictPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictPlayer.TabIndex = 4
        Me.pictPlayer.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(136, 10)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(416, 52)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'pictBgd
        '
        Me.pictBgd.Image = Global.RhythmJumper.My.Resources.Resources.RhythmJumper_Background
        Me.pictBgd.Location = New System.Drawing.Point(9, 67)
        Me.pictBgd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pictBgd.Name = "pictBgd"
        Me.pictBgd.Size = New System.Drawing.Size(712, 168)
        Me.pictBgd.TabIndex = 0
        Me.pictBgd.TabStop = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(281, 28)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(120, 20)
        Me.txtName.TabIndex = 8
        '
        'btnRegisterHS
        '
        Me.btnRegisterHS.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRegisterHS.Location = New System.Drawing.Point(413, 28)
        Me.btnRegisterHS.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRegisterHS.Name = "btnRegisterHS"
        Me.btnRegisterHS.Size = New System.Drawing.Size(139, 19)
        Me.btnRegisterHS.TabIndex = 9
        Me.btnRegisterHS.Text = "Put Your Name In!"
        Me.btnRegisterHS.UseVisualStyleBackColor = False
        '
        'GameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(730, 362)
        Me.Controls.Add(Me.btnRegisterHS)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblObstacles)
        Me.Controls.Add(Me.pictPlayer)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblNumAttempts)
        Me.Controls.Add(Me.pictBgd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "GameForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game"
        CType(Me.pictPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictBgd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pictBgd As System.Windows.Forms.PictureBox
    Friend WithEvents lblNumAttempts As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents pictPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents jumpTimer As System.Windows.Forms.Timer
    Friend WithEvents obstacleTimer As System.Windows.Forms.Timer
    Friend WithEvents musicTimer As System.Windows.Forms.Timer
    Friend WithEvents lblObstacles As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnRegisterHS As System.Windows.Forms.Button
End Class
