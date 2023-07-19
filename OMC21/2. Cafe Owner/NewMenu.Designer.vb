<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewMenu
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblFoodName = New System.Windows.Forms.Label()
        Me.picMenu = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtMenuName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNotification = New System.Windows.Forms.Button()
        CType(Me.picMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescription
        '
        Me.txtDescription.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtDescription.Location = New System.Drawing.Point(299, 188)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(278, 138)
        Me.txtDescription.TabIndex = 36
        Me.txtDescription.Text = "Description"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(208, 42)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 23)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "Add Menu"
        '
        'lblFoodName
        '
        Me.lblFoodName.AutoSize = True
        Me.lblFoodName.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodName.ForeColor = System.Drawing.Color.White
        Me.lblFoodName.Location = New System.Drawing.Point(42, 147)
        Me.lblFoodName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFoodName.Name = "lblFoodName"
        Me.lblFoodName.Size = New System.Drawing.Size(78, 17)
        Me.lblFoodName.TabIndex = 32
        Me.lblFoodName.Text = "Menu Name :"
        '
        'picMenu
        '
        Me.picMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMenu.Location = New System.Drawing.Point(42, 188)
        Me.picMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.picMenu.Name = "picMenu"
        Me.picMenu.Size = New System.Drawing.Size(218, 138)
        Me.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMenu.TabIndex = 31
        Me.picMenu.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.OMC21.My.Resources.Resources.OrderJeLogo
        Me.PictureBox1.Location = New System.Drawing.Point(45, -5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'txtMenuName
        '
        Me.txtMenuName.Location = New System.Drawing.Point(127, 144)
        Me.txtMenuName.Name = "txtMenuName"
        Me.txtMenuName.Size = New System.Drawing.Size(450, 24)
        Me.txtMenuName.TabIndex = 71
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(257, 410)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 25)
        Me.btnSave.TabIndex = 72
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(42, 345)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(218, 23)
        Me.btnUpload.TabIndex = 73
        Me.btnUpload.Text = "Upload Picture"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(296, 346)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Cost :"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(377, 343)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(200, 24)
        Me.txtCost.TabIndex = 76
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(349, 346)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 17)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "RM"
        '
        'btnNotification
        '
        Me.btnNotification.BackColor = System.Drawing.Color.White
        Me.btnNotification.Image = Global.OMC21.My.Resources.Resources.icons8_notification_35
        Me.btnNotification.Location = New System.Drawing.Point(551, 33)
        Me.btnNotification.Name = "btnNotification"
        Me.btnNotification.Size = New System.Drawing.Size(45, 45)
        Me.btnNotification.TabIndex = 84
        Me.btnNotification.UseVisualStyleBackColor = False
        '
        'NewMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Controls.Add(Me.btnNotification)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtMenuName)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblFoodName)
        Me.Controls.Add(Me.picMenu)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NewMenu"
        Me.Size = New System.Drawing.Size(622, 470)
        CType(Me.picMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picMenu As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lblFoodName As Label
    Friend WithEvents txtMenuName As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCost As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnNotification As Button
End Class
