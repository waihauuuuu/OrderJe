<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerHomepage
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEditProfile = New System.Windows.Forms.Button()
        Me.btnFeedback = New System.Windows.Forms.Button()
        Me.btnDelivery = New System.Windows.Forms.Button()
        Me.btnGames = New System.Windows.Forms.Button()
        Me.btnCafe = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.CloseMinimize4 = New OMC21.CloseMinimize()
        Me.CloseMinimize2 = New OMC21.CloseMinimize()
        Me.CloseMinimize3 = New OMC21.CloseMinimize()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblLogout = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnEditProfile)
        Me.Panel1.Controls.Add(Me.btnFeedback)
        Me.Panel1.Controls.Add(Me.btnDelivery)
        Me.Panel1.Controls.Add(Me.btnGames)
        Me.Panel1.Controls.Add(Me.btnCafe)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.btnHome)
        Me.Panel1.Controls.Add(Me.picProfile)
        Me.Panel1.Location = New System.Drawing.Point(0, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(147, 470)
        Me.Panel1.TabIndex = 0
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
        Me.btnFeedback.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFeedback.ForeColor = System.Drawing.Color.White
        Me.btnFeedback.Location = New System.Drawing.Point(-6, 379)
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Size = New System.Drawing.Size(151, 43)
        Me.btnFeedback.TabIndex = 20
        Me.btnFeedback.Text = "Feedback"
        Me.btnFeedback.UseVisualStyleBackColor = False
        '
        'btnDelivery
        '
        Me.btnDelivery.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelivery.ForeColor = System.Drawing.Color.White
        Me.btnDelivery.Location = New System.Drawing.Point(-6, 336)
        Me.btnDelivery.Name = "btnDelivery"
        Me.btnDelivery.Size = New System.Drawing.Size(151, 43)
        Me.btnDelivery.TabIndex = 5
        Me.btnDelivery.Text = "Delivery"
        Me.btnDelivery.UseVisualStyleBackColor = False
        '
        'btnGames
        '
        Me.btnGames.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGames.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGames.ForeColor = System.Drawing.Color.White
        Me.btnGames.Location = New System.Drawing.Point(-6, 293)
        Me.btnGames.Name = "btnGames"
        Me.btnGames.Size = New System.Drawing.Size(151, 43)
        Me.btnGames.TabIndex = 4
        Me.btnGames.Text = "Mini Games"
        Me.btnGames.UseVisualStyleBackColor = False
        '
        'btnCafe
        '
        Me.btnCafe.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCafe.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCafe.ForeColor = System.Drawing.Color.White
        Me.btnCafe.Location = New System.Drawing.Point(-6, 250)
        Me.btnCafe.Name = "btnCafe"
        Me.btnCafe.Size = New System.Drawing.Size(151, 43)
        Me.btnCafe.TabIndex = 3
        Me.btnCafe.Text = "Cafe"
        Me.btnCafe.UseVisualStyleBackColor = False
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
        Me.btnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Location = New System.Drawing.Point(-6, 207)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(151, 43)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Home"
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
        'pnlContainer
        '
        Me.pnlContainer.BackColor = System.Drawing.Color.DimGray
        Me.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlContainer.Location = New System.Drawing.Point(144, 38)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(622, 470)
        Me.pnlContainer.TabIndex = 2
        '
        'CloseMinimize4
        '
        Me.CloseMinimize4.BackColor = System.Drawing.Color.Transparent
        Me.CloseMinimize4.ForeColor = System.Drawing.Color.Transparent
        Me.CloseMinimize4.Location = New System.Drawing.Point(700, 3)
        Me.CloseMinimize4.Margin = New System.Windows.Forms.Padding(4)
        Me.CloseMinimize4.Name = "CloseMinimize4"
        Me.CloseMinimize4.Size = New System.Drawing.Size(68, 31)
        Me.CloseMinimize4.TabIndex = 3
        '
        'CloseMinimize2
        '
        Me.CloseMinimize2.BackColor = System.Drawing.Color.Transparent
        Me.CloseMinimize2.ForeColor = System.Drawing.Color.Transparent
        Me.CloseMinimize2.Location = New System.Drawing.Point(0, 0)
        Me.CloseMinimize2.Name = "CloseMinimize2"
        Me.CloseMinimize2.Size = New System.Drawing.Size(68, 51)
        Me.CloseMinimize2.TabIndex = 0
        '
        'CloseMinimize3
        '
        Me.CloseMinimize3.BackColor = System.Drawing.Color.Transparent
        Me.CloseMinimize3.ForeColor = System.Drawing.Color.Transparent
        Me.CloseMinimize3.Location = New System.Drawing.Point(0, 0)
        Me.CloseMinimize3.Name = "CloseMinimize3"
        Me.CloseMinimize3.Size = New System.Drawing.Size(68, 51)
        Me.CloseMinimize3.TabIndex = 0
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
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblLogout
        '
        Me.lblLogout.AutoSize = True
        Me.lblLogout.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.lblLogout.Location = New System.Drawing.Point(41, 515)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(58, 23)
        Me.lblLogout.TabIndex = 5
        Me.lblLogout.Text = "Logout"
        '
        'CustomerHomepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(767, 547)
        Me.Controls.Add(Me.lblLogout)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.CloseMinimize4)
        Me.Controls.Add(Me.pnlContainer)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "CustomerHomepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Homepage"
        Me.Panel1.ResumeLayout(False)
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlContainer As Panel
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents btnCafe As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnHome As Button
    Friend WithEvents btnFeedback As Button
    Friend WithEvents btnDelivery As Button
    Friend WithEvents btnGames As Button
    Friend WithEvents CloseMinimize1 As CloseMinimize
    Friend WithEvents CloseMinimize2 As CloseMinimize
    Friend WithEvents CloseMinimize3 As CloseMinimize
    Friend WithEvents CloseMinimize4 As CloseMinimize
    Friend WithEvents btnEditProfile As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblLogout As Label
End Class
