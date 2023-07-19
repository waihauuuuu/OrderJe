<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RiderHomepage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RiderHomepage))
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.iconFeedback = New System.Windows.Forms.Button()
        Me.btnEditProfile = New System.Windows.Forms.Button()
        Me.btnFeedback = New System.Windows.Forms.Button()
        Me.iconHome = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.lblLogout = New System.Windows.Forms.Label()
        Me.CloseMinimize1 = New OMC21.CloseMinimize()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.x = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContainer
        '
        Me.pnlContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlContainer.Location = New System.Drawing.Point(144, 38)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(622, 470)
        Me.pnlContainer.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.iconFeedback)
        Me.Panel1.Controls.Add(Me.btnEditProfile)
        Me.Panel1.Controls.Add(Me.btnFeedback)
        Me.Panel1.Controls.Add(Me.iconHome)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.btnHome)
        Me.Panel1.Controls.Add(Me.picProfile)
        Me.Panel1.Location = New System.Drawing.Point(0, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(147, 470)
        Me.Panel1.TabIndex = 6
        '
        'iconFeedback
        '
        Me.iconFeedback.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.iconFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.iconFeedback.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.iconFeedback.ForeColor = System.Drawing.Color.White
        Me.iconFeedback.Image = Global.OMC21.My.Resources.Resources.Feedback
        Me.iconFeedback.Location = New System.Drawing.Point(-1, 250)
        Me.iconFeedback.Name = "iconFeedback"
        Me.iconFeedback.Size = New System.Drawing.Size(48, 43)
        Me.iconFeedback.TabIndex = 25
        Me.iconFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconFeedback.UseVisualStyleBackColor = False
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
        Me.btnFeedback.Location = New System.Drawing.Point(44, 250)
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Size = New System.Drawing.Size(101, 43)
        Me.btnFeedback.TabIndex = 20
        Me.btnFeedback.Text = "Feedback"
        Me.btnFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFeedback.UseVisualStyleBackColor = False
        '
        'iconHome
        '
        Me.iconHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.iconHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.iconHome.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.iconHome.ForeColor = System.Drawing.Color.White
        Me.iconHome.Image = CType(resources.GetObject("iconHome.Image"), System.Drawing.Image)
        Me.iconHome.Location = New System.Drawing.Point(-1, 207)
        Me.iconHome.Name = "iconHome"
        Me.iconHome.Size = New System.Drawing.Size(48, 43)
        Me.iconHome.TabIndex = 21
        Me.iconHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconHome.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight
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
        Me.btnHome.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(44, 207)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(101, 43)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Home"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.UseVisualStyleBackColor = False
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
        'lblLogout
        '
        Me.lblLogout.AutoSize = True
        Me.lblLogout.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.lblLogout.ForeColor = System.Drawing.Color.White
        Me.lblLogout.Location = New System.Drawing.Point(41, 515)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(58, 23)
        Me.lblLogout.TabIndex = 7
        Me.lblLogout.Text = "Logout"
        '
        'CloseMinimize1
        '
        Me.CloseMinimize1.BackColor = System.Drawing.Color.Transparent
        Me.CloseMinimize1.ForeColor = System.Drawing.Color.Transparent
        Me.CloseMinimize1.Location = New System.Drawing.Point(700, 2)
        Me.CloseMinimize1.Margin = New System.Windows.Forms.Padding(5)
        Me.CloseMinimize1.Name = "CloseMinimize1"
        Me.CloseMinimize1.Size = New System.Drawing.Size(79, 37)
        Me.CloseMinimize1.TabIndex = 13
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLogout.Image = Global.OMC21.My.Resources.Resources.icons8_logout_48
        Me.btnLogout.Location = New System.Drawing.Point(0, 508)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(35, 39)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'x
        '
        Me.x.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.x.FlatAppearance.BorderSize = 0
        Me.x.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.x.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.x.Image = Global.OMC21.My.Resources.Resources.icons8_logout_48
        Me.x.Location = New System.Drawing.Point(-65, 506)
        Me.x.Name = "x"
        Me.x.Size = New System.Drawing.Size(35, 39)
        Me.x.TabIndex = 9
        Me.x.UseVisualStyleBackColor = False
        '
        'RiderHomepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(767, 547)
        Me.Controls.Add(Me.pnlContainer)
        Me.Controls.Add(Me.CloseMinimize1)
        Me.Controls.Add(Me.lblLogout)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.x)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RiderHomepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RiderHomepage"
        Me.Panel1.ResumeLayout(False)
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents x As Button
    Friend WithEvents pnlContainer As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents iconFeedback As Button
    Friend WithEvents btnEditProfile As Button
    Friend WithEvents btnFeedback As Button
    Friend WithEvents iconHome As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnHome As Button
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents lblLogout As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents CloseMinimize1 As CloseMinimize
End Class
