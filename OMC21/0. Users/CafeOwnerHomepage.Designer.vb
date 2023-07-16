<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CafeOwnerHomepage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CafeOwnerHomepage))
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCafeName = New System.Windows.Forms.Label()
        Me.btnFeedback = New System.Windows.Forms.Button()
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.lblLogout = New System.Windows.Forms.Label()
        Me.CloseMinimize1 = New OMC21.CloseMinimize()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.iconFeedback = New System.Windows.Forms.Button()
        Me.iconTransaction = New System.Windows.Forms.Button()
        Me.iconMenu = New System.Windows.Forms.Button()
        Me.iconHome = New System.Windows.Forms.Button()
        Me.pnlContainer.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContainer
        '
        Me.pnlContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.pnlContainer.Controls.Add(Me.PictureBox1)
        Me.pnlContainer.Controls.Add(Me.Label1)
        Me.pnlContainer.Location = New System.Drawing.Point(144, 38)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(622, 470)
        Me.pnlContainer.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblCafeName)
        Me.Panel1.Controls.Add(Me.iconFeedback)
        Me.Panel1.Controls.Add(Me.btnFeedback)
        Me.Panel1.Controls.Add(Me.iconTransaction)
        Me.Panel1.Controls.Add(Me.iconMenu)
        Me.Panel1.Controls.Add(Me.btnTransaction)
        Me.Panel1.Controls.Add(Me.iconHome)
        Me.Panel1.Controls.Add(Me.btnMenu)
        Me.Panel1.Controls.Add(Me.btnHome)
        Me.Panel1.Location = New System.Drawing.Point(0, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(147, 470)
        Me.Panel1.TabIndex = 7
        '
        'lblCafeName
        '
        Me.lblCafeName.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCafeName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCafeName.Location = New System.Drawing.Point(18, 108)
        Me.lblCafeName.Name = "lblCafeName"
        Me.lblCafeName.Size = New System.Drawing.Size(106, 72)
        Me.lblCafeName.TabIndex = 26
        Me.lblCafeName.Text = "Cafe Name"
        '
        'btnFeedback
        '
        Me.btnFeedback.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFeedback.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.btnFeedback.ForeColor = System.Drawing.Color.White
        Me.btnFeedback.Location = New System.Drawing.Point(44, 336)
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Size = New System.Drawing.Size(101, 43)
        Me.btnFeedback.TabIndex = 20
        Me.btnFeedback.Text = "Feedback"
        Me.btnFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFeedback.UseVisualStyleBackColor = False
        '
        'btnTransaction
        '
        Me.btnTransaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTransaction.Font = New System.Drawing.Font("Comic Sans MS", 9.0!)
        Me.btnTransaction.ForeColor = System.Drawing.Color.White
        Me.btnTransaction.Location = New System.Drawing.Point(44, 293)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(102, 43)
        Me.btnTransaction.TabIndex = 4
        Me.btnTransaction.Text = "Transaction  History"
        Me.btnTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaction.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMenu.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.btnMenu.ForeColor = System.Drawing.Color.White
        Me.btnMenu.Location = New System.Drawing.Point(44, 250)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(101, 43)
        Me.btnMenu.TabIndex = 3
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenu.UseVisualStyleBackColor = False
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
        'lblLogout
        '
        Me.lblLogout.AutoSize = True
        Me.lblLogout.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.lblLogout.ForeColor = System.Drawing.Color.White
        Me.lblLogout.Location = New System.Drawing.Point(41, 515)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(58, 23)
        Me.lblLogout.TabIndex = 9
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 30.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(25, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 56)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome Back!"
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
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.OMC21.My.Resources.Resources.CafeHome
        Me.PictureBox1.Location = New System.Drawing.Point(-68, 109)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(573, 335)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'iconFeedback
        '
        Me.iconFeedback.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.iconFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.iconFeedback.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.iconFeedback.ForeColor = System.Drawing.Color.White
        Me.iconFeedback.Image = Global.OMC21.My.Resources.Resources.Feedback
        Me.iconFeedback.Location = New System.Drawing.Point(-1, 336)
        Me.iconFeedback.Name = "iconFeedback"
        Me.iconFeedback.Size = New System.Drawing.Size(48, 43)
        Me.iconFeedback.TabIndex = 25
        Me.iconFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconFeedback.UseVisualStyleBackColor = False
        '
        'iconTransaction
        '
        Me.iconTransaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.iconTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.iconTransaction.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.iconTransaction.ForeColor = System.Drawing.Color.White
        Me.iconTransaction.Image = Global.OMC21.My.Resources.Resources.TransactionHistory
        Me.iconTransaction.Location = New System.Drawing.Point(-1, 293)
        Me.iconTransaction.Name = "iconTransaction"
        Me.iconTransaction.Size = New System.Drawing.Size(48, 43)
        Me.iconTransaction.TabIndex = 23
        Me.iconTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconTransaction.UseVisualStyleBackColor = False
        '
        'iconMenu
        '
        Me.iconMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.iconMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.iconMenu.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.iconMenu.ForeColor = System.Drawing.Color.White
        Me.iconMenu.Image = Global.OMC21.My.Resources.Resources.NewMenu
        Me.iconMenu.Location = New System.Drawing.Point(-1, 250)
        Me.iconMenu.Name = "iconMenu"
        Me.iconMenu.Size = New System.Drawing.Size(48, 43)
        Me.iconMenu.TabIndex = 22
        Me.iconMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.iconMenu.UseVisualStyleBackColor = False
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
        'CafeOwnerHomepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(767, 547)
        Me.Controls.Add(Me.CloseMinimize1)
        Me.Controls.Add(Me.lblLogout)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.pnlContainer)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CafeOwnerHomepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CafeOwnerHomepage"
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlContainer.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlContainer As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents iconFeedback As Button
    Friend WithEvents btnFeedback As Button
    Friend WithEvents iconTransaction As Button
    Friend WithEvents iconMenu As Button
    Friend WithEvents btnTransaction As Button
    Friend WithEvents iconHome As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents lblLogout As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents CloseMinimize1 As CloseMinimize
    Friend WithEvents lblCafeName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
