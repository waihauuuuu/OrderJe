﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderStatus
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picDelivery = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblRiderInfo = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.btnCart = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnReceive = New System.Windows.Forms.Button()
        CType(Me.picDelivery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(208, 42)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 23)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "Delivery"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(220, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 23)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Estimated delivery time"
        '
        'picDelivery
        '
        Me.picDelivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDelivery.Image = Global.OMC21.My.Resources.Resources.Delivery
        Me.picDelivery.Location = New System.Drawing.Point(45, 130)
        Me.picDelivery.Name = "picDelivery"
        Me.picDelivery.Size = New System.Drawing.Size(141, 138)
        Me.picDelivery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDelivery.TabIndex = 74
        Me.picDelivery.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.OMC21.My.Resources.Resources.OrderJeLogo
        Me.PictureBox1.Location = New System.Drawing.Point(45, -5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'lblTimer
        '
        Me.lblTimer.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.lblTimer.ForeColor = System.Drawing.Color.White
        Me.lblTimer.Location = New System.Drawing.Point(232, 199)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(106, 41)
        Me.lblTimer.TabIndex = 75
        Me.lblTimer.Text = "lblTimer"
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRiderInfo
        '
        Me.lblRiderInfo.AutoSize = True
        Me.lblRiderInfo.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRiderInfo.ForeColor = System.Drawing.Color.White
        Me.lblRiderInfo.Location = New System.Drawing.Point(221, 319)
        Me.lblRiderInfo.Name = "lblRiderInfo"
        Me.lblRiderInfo.Size = New System.Drawing.Size(68, 16)
        Me.lblRiderInfo.TabIndex = 76
        Me.lblRiderInfo.Text = "Rider Info"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(332, 348)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(75, 17)
        Me.lblUsername.TabIndex = 77
        Me.lblUsername.Text = "lblUsername"
        '
        'picProfile
        '
        Me.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProfile.Image = Global.OMC21.My.Resources.Resources.profilePic
        Me.picProfile.Location = New System.Drawing.Point(45, 306)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(141, 138)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfile.TabIndex = 78
        Me.picProfile.TabStop = False
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.ForeColor = System.Drawing.Color.White
        Me.lblUserID.Location = New System.Drawing.Point(332, 380)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(44, 17)
        Me.lblUserID.TabIndex = 79
        Me.lblUserID.Text = "XXXX"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(221, 380)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "User ID: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(221, 414)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 17)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Contact Number: "
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.ForeColor = System.Drawing.Color.White
        Me.lblPhone.Location = New System.Drawing.Point(332, 414)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(112, 17)
        Me.lblPhone.TabIndex = 82
        Me.lblPhone.Text = "XXX-XXXXXXXX"
        '
        'btnCart
        '
        Me.btnCart.BackColor = System.Drawing.Color.White
        Me.btnCart.Image = Global.OMC21.My.Resources.Resources.icons8_cart_35
        Me.btnCart.Location = New System.Drawing.Point(551, 33)
        Me.btnCart.Name = "btnCart"
        Me.btnCart.Size = New System.Drawing.Size(45, 45)
        Me.btnCart.TabIndex = 84
        Me.btnCart.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(344, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 41)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Minute"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(221, 348)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Username: "
        '
        'btnReceive
        '
        Me.btnReceive.ForeColor = System.Drawing.Color.Black
        Me.btnReceive.Location = New System.Drawing.Point(491, 403)
        Me.btnReceive.Name = "btnReceive"
        Me.btnReceive.Size = New System.Drawing.Size(105, 34)
        Me.btnReceive.TabIndex = 87
        Me.btnReceive.Text = "Received"
        Me.btnReceive.UseVisualStyleBackColor = True
        '
        'OrderStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Controls.Add(Me.btnReceive)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCart)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.picProfile)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblRiderInfo)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.picDelivery)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "OrderStatus"
        Me.Size = New System.Drawing.Size(622, 470)
        CType(Me.picDelivery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents picDelivery As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTimer As Label
    Friend WithEvents lblRiderInfo As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents lblUserID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents btnCart As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnReceive As Button
End Class
