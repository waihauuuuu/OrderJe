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
        Me.iconFeedback = New System.Windows.Forms.Button()
        Me.btnFeedback = New System.Windows.Forms.Button()
        Me.iconTransactionHistory = New System.Windows.Forms.Button()
        Me.btnTransactionHistory = New System.Windows.Forms.Button()
        Me.iconData = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnData = New System.Windows.Forms.Button()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.CloseMinimize1 = New OMC21.CloseMinimize()
        Me.lblLogout = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
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
        Me.Panel1.Controls.Add(Me.btnFeedback)
        Me.Panel1.Controls.Add(Me.iconTransactionHistory)
        Me.Panel1.Controls.Add(Me.btnTransactionHistory)
        Me.Panel1.Controls.Add(Me.iconData)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.btnData)
        Me.Panel1.Controls.Add(Me.picProfile)
        Me.Panel1.Location = New System.Drawing.Point(0, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(147, 470)
        Me.Panel1.TabIndex = 10
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
        'iconTransactionHistory
        '
        Me.iconTransactionHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.iconTransactionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.iconTransactionHistory.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.iconTransactionHistory.ForeColor = System.Drawing.Color.White
        Me.iconTransactionHistory.Image = Global.OMC21.My.Resources.Resources.TransactionHistory
        Me.iconTransactionHistory.Location = New System.Drawing.Point(-1, 250)
        Me.iconTransactionHistory.Name = "iconTransactionHistory"
        Me.iconTransactionHistory.Size = New System.Drawing.Size(48, 43)
        Me.iconTransactionHistory.TabIndex = 23
        Me.iconTransactionHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconTransactionHistory.UseVisualStyleBackColor = False
        '
        'btnTransactionHistory
        '
        Me.btnTransactionHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnTransactionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransactionHistory.Font = New System.Drawing.Font("Comic Sans MS", 9.0!)
        Me.btnTransactionHistory.ForeColor = System.Drawing.Color.White
        Me.btnTransactionHistory.Location = New System.Drawing.Point(44, 250)
        Me.btnTransactionHistory.Name = "btnTransactionHistory"
        Me.btnTransactionHistory.Size = New System.Drawing.Size(102, 43)
        Me.btnTransactionHistory.TabIndex = 4
        Me.btnTransactionHistory.Text = "Transaction  History"
        Me.btnTransactionHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransactionHistory.UseVisualStyleBackColor = False
        '
        'iconData
        '
        Me.iconData.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.iconData.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.iconData.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.iconData.ForeColor = System.Drawing.Color.White
        Me.iconData.Image = Global.OMC21.My.Resources.Resources.UsersData
        Me.iconData.Location = New System.Drawing.Point(-1, 207)
        Me.iconData.Name = "iconData"
        Me.iconData.Size = New System.Drawing.Size(48, 43)
        Me.iconData.TabIndex = 21
        Me.iconData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconData.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(32, 148)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(80, 23)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Admin"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnData
        '
        Me.btnData.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnData.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.btnData.ForeColor = System.Drawing.Color.White
        Me.btnData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnData.Location = New System.Drawing.Point(44, 207)
        Me.btnData.Name = "btnData"
        Me.btnData.Size = New System.Drawing.Size(101, 43)
        Me.btnData.TabIndex = 1
        Me.btnData.Text = "Users' Data"
        Me.btnData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnData.UseVisualStyleBackColor = False
        '
        'picProfile
        '
        Me.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProfile.Image = Global.OMC21.My.Resources.Resources.profilePic
        Me.picProfile.Location = New System.Drawing.Point(25, 51)
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
        Me.CloseMinimize1.Margin = New System.Windows.Forms.Padding(4)
        Me.CloseMinimize1.Name = "CloseMinimize1"
        Me.CloseMinimize1.Size = New System.Drawing.Size(68, 36)
        Me.CloseMinimize1.TabIndex = 12
        '
        'lblLogout
        '
        Me.lblLogout.AutoSize = True
        Me.lblLogout.BackColor = System.Drawing.Color.Transparent
        Me.lblLogout.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.lblLogout.ForeColor = System.Drawing.Color.White
        Me.lblLogout.Location = New System.Drawing.Point(41, 515)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(58, 23)
        Me.lblLogout.TabIndex = 7
        Me.lblLogout.Text = "Logout"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
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
        'AdminHomepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(767, 547)
        Me.Controls.Add(Me.lblLogout)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.CloseMinimize1)
        Me.Controls.Add(Me.pnlContainer)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AdminHomepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminHomepage"
        Me.Panel1.ResumeLayout(False)
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlContainer As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents iconFeedback As Button
    Friend WithEvents btnFeedback As Button
    Friend WithEvents iconTransactionHistory As Button
    Friend WithEvents btnTransactionHistory As Button
    Friend WithEvents iconData As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnData As Button
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents CloseMinimize1 As CloseMinimize
    Friend WithEvents lblLogout As Label
    Friend WithEvents btnLogout As Button
End Class
