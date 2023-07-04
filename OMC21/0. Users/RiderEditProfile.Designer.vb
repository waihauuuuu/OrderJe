<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RiderEditProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RiderEditProfile))
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnAboutUs = New System.Windows.Forms.Button()
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnPersonal = New System.Windows.Forms.Button()
        Me.CloseMinimize2 = New OMC21.CloseMinimize()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.iconAboutUs = New System.Windows.Forms.Button()
        Me.iconTransaction = New System.Windows.Forms.Button()
        Me.iconPersonal = New System.Windows.Forms.Button()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.Panel4.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContainer
        '
        Me.pnlContainer.BackColor = System.Drawing.Color.Gray
        Me.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlContainer.Location = New System.Drawing.Point(250, 38)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(517, 510)
        Me.pnlContainer.TabIndex = 54
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lblUserID)
        Me.Panel4.Controls.Add(Me.iconAboutUs)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.btnLogout)
        Me.Panel4.Controls.Add(Me.btnAboutUs)
        Me.Panel4.Controls.Add(Me.iconTransaction)
        Me.Panel4.Controls.Add(Me.iconPersonal)
        Me.Panel4.Controls.Add(Me.btnTransaction)
        Me.Panel4.Controls.Add(Me.lblUsername)
        Me.Panel4.Controls.Add(Me.btnPersonal)
        Me.Panel4.Controls.Add(Me.picProfile)
        Me.Panel4.Location = New System.Drawing.Point(0, 38)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(254, 510)
        Me.Panel4.TabIndex = 53
        '
        'lblUserID
        '
        Me.lblUserID.Font = New System.Drawing.Font("Comic Sans MS", 9.0!)
        Me.lblUserID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblUserID.Location = New System.Drawing.Point(136, 210)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(44, 17)
        Me.lblUserID.TabIndex = 23
        Me.lblUserID.Text = "XXXX"
        Me.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(67, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "User ID: "
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(-1, 463)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(250, 43)
        Me.btnLogout.TabIndex = 21
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnAboutUs
        '
        Me.btnAboutUs.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAboutUs.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAboutUs.ForeColor = System.Drawing.Color.White
        Me.btnAboutUs.Location = New System.Drawing.Point(52, 334)
        Me.btnAboutUs.Name = "btnAboutUs"
        Me.btnAboutUs.Size = New System.Drawing.Size(197, 43)
        Me.btnAboutUs.TabIndex = 20
        Me.btnAboutUs.Text = "About Us"
        Me.btnAboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAboutUs.UseVisualStyleBackColor = False
        '
        'btnTransaction
        '
        Me.btnTransaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransaction.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaction.ForeColor = System.Drawing.Color.White
        Me.btnTransaction.Location = New System.Drawing.Point(52, 291)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(197, 43)
        Me.btnTransaction.TabIndex = 3
        Me.btnTransaction.Text = "Transaction History"
        Me.btnTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaction.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblUsername.Location = New System.Drawing.Point(85, 181)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(80, 23)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPersonal
        '
        Me.btnPersonal.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPersonal.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPersonal.ForeColor = System.Drawing.Color.White
        Me.btnPersonal.Location = New System.Drawing.Point(52, 248)
        Me.btnPersonal.Name = "btnPersonal"
        Me.btnPersonal.Size = New System.Drawing.Size(197, 43)
        Me.btnPersonal.TabIndex = 1
        Me.btnPersonal.Text = "Personal Details"
        Me.btnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPersonal.UseVisualStyleBackColor = False
        '
        'CloseMinimize2
        '
        Me.CloseMinimize2.BackColor = System.Drawing.Color.Transparent
        Me.CloseMinimize2.ForeColor = System.Drawing.Color.Transparent
        Me.CloseMinimize2.Location = New System.Drawing.Point(700, 5)
        Me.CloseMinimize2.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.CloseMinimize2.Name = "CloseMinimize2"
        Me.CloseMinimize2.Size = New System.Drawing.Size(71, 28)
        Me.CloseMinimize2.TabIndex = 56
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Transparent
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(7, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(32, 32)
        Me.btnBack.TabIndex = 55
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'iconAboutUs
        '
        Me.iconAboutUs.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.iconAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.iconAboutUs.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iconAboutUs.ForeColor = System.Drawing.Color.White
        Me.iconAboutUs.Image = Global.OMC21.My.Resources.Resources.AboutUs
        Me.iconAboutUs.Location = New System.Drawing.Point(-1, 334)
        Me.iconAboutUs.Name = "iconAboutUs"
        Me.iconAboutUs.Size = New System.Drawing.Size(55, 43)
        Me.iconAboutUs.TabIndex = 26
        Me.iconAboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconAboutUs.UseVisualStyleBackColor = False
        '
        'iconTransaction
        '
        Me.iconTransaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.iconTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.iconTransaction.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iconTransaction.ForeColor = System.Drawing.Color.White
        Me.iconTransaction.Image = Global.OMC21.My.Resources.Resources.TransactionHistory
        Me.iconTransaction.Location = New System.Drawing.Point(-1, 291)
        Me.iconTransaction.Name = "iconTransaction"
        Me.iconTransaction.Size = New System.Drawing.Size(55, 43)
        Me.iconTransaction.TabIndex = 23
        Me.iconTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconTransaction.UseVisualStyleBackColor = False
        '
        'iconPersonal
        '
        Me.iconPersonal.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.iconPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.iconPersonal.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iconPersonal.ForeColor = System.Drawing.Color.White
        Me.iconPersonal.Image = Global.OMC21.My.Resources.Resources.PersonalDetails
        Me.iconPersonal.Location = New System.Drawing.Point(-1, 248)
        Me.iconPersonal.Name = "iconPersonal"
        Me.iconPersonal.Size = New System.Drawing.Size(55, 43)
        Me.iconPersonal.TabIndex = 22
        Me.iconPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconPersonal.UseVisualStyleBackColor = False
        '
        'picProfile
        '
        Me.picProfile.Image = Global.OMC21.My.Resources.Resources.profilePic
        Me.picProfile.Location = New System.Drawing.Point(61, 31)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(130, 133)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfile.TabIndex = 0
        Me.picProfile.TabStop = False
        '
        'RiderEditProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(767, 547)
        Me.Controls.Add(Me.CloseMinimize2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.pnlContainer)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "RiderEditProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RiderEditProfile"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents pnlContainer As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblUserID As Label
    Friend WithEvents iconAboutUs As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnAboutUs As Button
    Friend WithEvents iconTransaction As Button
    Friend WithEvents iconPersonal As Button
    Friend WithEvents btnTransaction As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnPersonal As Button
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents CloseMinimize2 As CloseMinimize
End Class
