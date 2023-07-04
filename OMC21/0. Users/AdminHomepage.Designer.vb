<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminHomepage
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
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEditProfile = New System.Windows.Forms.Button()
        Me.btnFeedback = New System.Windows.Forms.Button()
        Me.btnGames = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.iconFeedback = New System.Windows.Forms.Button()
        Me.iconGames = New System.Windows.Forms.Button()
        Me.iconHome = New System.Windows.Forms.Button()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.CloseMinimize1 = New OMC21.CloseMinimize()
        Me.Panel1.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContainer
        '
        Me.pnlContainer.BackColor = System.Drawing.SystemColors.Control
        Me.pnlContainer.Location = New System.Drawing.Point(144, 38)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(622, 470)
        Me.pnlContainer.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.iconFeedback)
        Me.Panel1.Controls.Add(Me.btnEditProfile)
        Me.Panel1.Controls.Add(Me.btnFeedback)
        Me.Panel1.Controls.Add(Me.iconGames)
        Me.Panel1.Controls.Add(Me.btnGames)
        Me.Panel1.Controls.Add(Me.iconHome)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.btnHome)
        Me.Panel1.Controls.Add(Me.picProfile)
        Me.Panel1.Location = New System.Drawing.Point(0, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(147, 470)
        Me.Panel1.TabIndex = 10
        '
        'btnEditProfile
        '
        Me.btnEditProfile.BackColor = System.Drawing.Color.Gray
        Me.btnEditProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEditProfile.Location = New System.Drawing.Point(25, 142)
        Me.btnEditProfile.Name = "btnEditProfile"
        Me.btnEditProfile.Size = New System.Drawing.Size(96, 32)
        Me.btnEditProfile.TabIndex = 21
        Me.btnEditProfile.Text = "Edit Profile"
        Me.btnEditProfile.UseVisualStyleBackColor = False
        '
        'btnFeedback
        '
        Me.btnFeedback.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFeedback.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.btnFeedback.ForeColor = System.Drawing.Color.White
        Me.btnFeedback.Location = New System.Drawing.Point(44, 293)
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Size = New System.Drawing.Size(101, 43)
        Me.btnFeedback.TabIndex = 20
        Me.btnFeedback.Text = "Feedback"
        Me.btnFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFeedback.UseVisualStyleBackColor = False
        '
        'btnGames
        '
        Me.btnGames.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnGames.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGames.Font = New System.Drawing.Font("Comic Sans MS", 9.0!)
        Me.btnGames.ForeColor = System.Drawing.Color.White
        Me.btnGames.Location = New System.Drawing.Point(44, 250)
        Me.btnGames.Name = "btnGames"
        Me.btnGames.Size = New System.Drawing.Size(102, 43)
        Me.btnGames.TabIndex = 4
        Me.btnGames.Text = "Transaction  History"
        Me.btnGames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGames.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(32, 116)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(80, 23)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHome.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(44, 207)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(101, 43)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Users' Data"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'iconFeedback
        '
        Me.iconFeedback.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.iconFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.iconFeedback.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.iconFeedback.ForeColor = System.Drawing.Color.White
        Me.iconFeedback.Image = Global.OMC21.My.Resources.Resources.Feedback
        Me.iconFeedback.Location = New System.Drawing.Point(-1, 293)
        Me.iconFeedback.Name = "iconFeedback"
        Me.iconFeedback.Size = New System.Drawing.Size(48, 43)
        Me.iconFeedback.TabIndex = 25
        Me.iconFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconFeedback.UseVisualStyleBackColor = False
        '
        'iconGames
        '
        Me.iconGames.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.iconGames.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.iconGames.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.iconGames.ForeColor = System.Drawing.Color.White
        Me.iconGames.Image = Global.OMC21.My.Resources.Resources.TransactionHistory
        Me.iconGames.Location = New System.Drawing.Point(-1, 250)
        Me.iconGames.Name = "iconGames"
        Me.iconGames.Size = New System.Drawing.Size(48, 43)
        Me.iconGames.TabIndex = 23
        Me.iconGames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconGames.UseVisualStyleBackColor = False
        '
        'iconHome
        '
        Me.iconHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.iconHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.iconHome.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.iconHome.ForeColor = System.Drawing.Color.White
        Me.iconHome.Image = Global.OMC21.My.Resources.Resources.UsersData
        Me.iconHome.Location = New System.Drawing.Point(-1, 207)
        Me.iconHome.Name = "iconHome"
        Me.iconHome.Size = New System.Drawing.Size(48, 43)
        Me.iconHome.TabIndex = 21
        Me.iconHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconHome.UseVisualStyleBackColor = False
        '
        'picProfile
        '
        Me.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProfile.Image = Global.OMC21.My.Resources.Resources.profilePic
        Me.picProfile.Location = New System.Drawing.Point(25, 19)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(96, 94)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfile.TabIndex = 0
        Me.picProfile.TabStop = False
        '
        'CloseMinimize1
        '
        Me.CloseMinimize1.BackColor = System.Drawing.Color.Transparent
        Me.CloseMinimize1.ForeColor = System.Drawing.Color.Transparent
        Me.CloseMinimize1.Location = New System.Drawing.Point(700, 2)
        Me.CloseMinimize1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CloseMinimize1.Name = "CloseMinimize1"
        Me.CloseMinimize1.Size = New System.Drawing.Size(68, 36)
        Me.CloseMinimize1.TabIndex = 12
        '
        'AdminHomepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(767, 547)
        Me.Controls.Add(Me.CloseMinimize1)
        Me.Controls.Add(Me.pnlContainer)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AdminHomepage"
        Me.Text = "AdminHomepage"
        Me.Panel1.ResumeLayout(False)
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlContainer As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents iconFeedback As Button
    Friend WithEvents btnEditProfile As Button
    Friend WithEvents btnFeedback As Button
    Friend WithEvents iconGames As Button
    Friend WithEvents btnGames As Button
    Friend WithEvents iconHome As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnHome As Button
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents CloseMinimize1 As CloseMinimize
End Class
