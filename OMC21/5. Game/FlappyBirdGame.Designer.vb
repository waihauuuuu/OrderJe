<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlappyBirdGame
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
        Me.gameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblGameOver = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.pipeTop = New System.Windows.Forms.PictureBox()
        Me.FlappyBird = New System.Windows.Forms.PictureBox()
        Me.ground = New System.Windows.Forms.PictureBox()
        Me.pipeBottom = New System.Windows.Forms.PictureBox()
        Me.btnPlayAgain = New System.Windows.Forms.Button()
        CType(Me.pipeTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlappyBird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pipeBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gameTimer
        '
        Me.gameTimer.Enabled = True
        Me.gameTimer.Interval = 20
        '
        'lblGameOver
        '
        Me.lblGameOver.BackColor = System.Drawing.Color.Transparent
        Me.lblGameOver.Font = New System.Drawing.Font("Bahnschrift Condensed", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOver.ForeColor = System.Drawing.Color.Red
        Me.lblGameOver.Location = New System.Drawing.Point(109, 151)
        Me.lblGameOver.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(186, 50)
        Me.lblGameOver.TabIndex = 11
        '
        'lblScore
        '
        Me.lblScore.Font = New System.Drawing.Font("Bahnschrift Condensed", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(8, 11)
        Me.lblScore.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(186, 50)
        Me.lblScore.TabIndex = 10
        Me.lblScore.Text = "Score = 0"
        '
        'pipeTop
        '
        Me.pipeTop.Image = Global.OMC21.My.Resources.Resources.pipedown
        Me.pipeTop.Location = New System.Drawing.Point(161, -22)
        Me.pipeTop.Margin = New System.Windows.Forms.Padding(2)
        Me.pipeTop.Name = "pipeTop"
        Me.pipeTop.Size = New System.Drawing.Size(73, 139)
        Me.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pipeTop.TabIndex = 6
        Me.pipeTop.TabStop = False
        '
        'FlappyBird
        '
        Me.FlappyBird.Image = Global.OMC21.My.Resources.Resources.bird
        Me.FlappyBird.Location = New System.Drawing.Point(38, 151)
        Me.FlappyBird.Margin = New System.Windows.Forms.Padding(2)
        Me.FlappyBird.Name = "FlappyBird"
        Me.FlappyBird.Size = New System.Drawing.Size(58, 44)
        Me.FlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FlappyBird.TabIndex = 7
        Me.FlappyBird.TabStop = False
        '
        'ground
        '
        Me.ground.Image = Global.OMC21.My.Resources.Resources.ground
        Me.ground.Location = New System.Drawing.Point(-11, 353)
        Me.ground.Margin = New System.Windows.Forms.Padding(2)
        Me.ground.Name = "ground"
        Me.ground.Size = New System.Drawing.Size(417, 80)
        Me.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ground.TabIndex = 9
        Me.ground.TabStop = False
        '
        'pipeBottom
        '
        Me.pipeBottom.Image = Global.OMC21.My.Resources.Resources.pipe
        Me.pipeBottom.Location = New System.Drawing.Point(293, 203)
        Me.pipeBottom.Margin = New System.Windows.Forms.Padding(2)
        Me.pipeBottom.Name = "pipeBottom"
        Me.pipeBottom.Size = New System.Drawing.Size(73, 155)
        Me.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pipeBottom.TabIndex = 8
        Me.pipeBottom.TabStop = False
        '
        'btnPlayAgain
        '
        Me.btnPlayAgain.Location = New System.Drawing.Point(132, 213)
        Me.btnPlayAgain.Name = "btnPlayAgain"
        Me.btnPlayAgain.Size = New System.Drawing.Size(112, 23)
        Me.btnPlayAgain.TabIndex = 12
        Me.btnPlayAgain.Text = "Play Again"
        Me.btnPlayAgain.UseVisualStyleBackColor = True
        Me.btnPlayAgain.Visible = False
        '
        'FlappyBirdGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(395, 411)
        Me.Controls.Add(Me.btnPlayAgain)
        Me.Controls.Add(Me.lblGameOver)
        Me.Controls.Add(Me.pipeTop)
        Me.Controls.Add(Me.FlappyBird)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.ground)
        Me.Controls.Add(Me.pipeBottom)
        Me.Name = "FlappyBirdGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flappy Bird"
        CType(Me.pipeTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlappyBird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pipeBottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gameTimer As Timer
    Friend WithEvents lblGameOver As Label
    Friend WithEvents pipeTop As PictureBox
    Friend WithEvents FlappyBird As PictureBox
    Friend WithEvents lblScore As Label
    Friend WithEvents ground As PictureBox
    Friend WithEvents pipeBottom As PictureBox
    Friend WithEvents btnPlayAgain As Button
End Class
