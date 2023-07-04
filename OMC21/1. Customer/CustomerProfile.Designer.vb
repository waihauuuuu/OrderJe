<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerProfile
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
        Me.btnChange = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVillage = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(333, 301)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(143, 38)
        Me.btnChange.TabIndex = 47
        Me.btnChange.Text = "Change Profile Picture"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(38, 424)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 17)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Village"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(38, 353)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 17)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Gender"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(38, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 17)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Phone Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(38, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(38, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 17)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(38, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Full Name"
        '
        'txtVillage
        '
        Me.txtVillage.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVillage.Location = New System.Drawing.Point(41, 444)
        Me.txtVillage.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtVillage.Name = "txtVillage"
        Me.txtVillage.Size = New System.Drawing.Size(249, 24)
        Me.txtVillage.TabIndex = 40
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(41, 194)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(249, 24)
        Me.txtEmail.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(37, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 23)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Personal Details"
        '
        'txtFullName
        '
        Me.txtFullName.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(41, 85)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(249, 24)
        Me.txtFullName.TabIndex = 33
        '
        'picProfile
        '
        Me.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProfile.Location = New System.Drawing.Point(346, 139)
        Me.picProfile.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(117, 147)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfile.TabIndex = 32
        Me.picProfile.TabStop = False
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(41, 251)
        Me.txtPhone.Mask = "###-########"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(249, 24)
        Me.txtPhone.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(38, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(41, 139)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(249, 24)
        Me.txtUsername.TabIndex = 50
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(362, 444)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 33)
        Me.btnSave.TabIndex = 52
        Me.btnSave.Text = "Save changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Location = New System.Drawing.Point(41, 384)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(52, 21)
        Me.rbMale.TabIndex = 53
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Location = New System.Drawing.Point(124, 384)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(63, 21)
        Me.rbFemale.TabIndex = 54
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Location = New System.Drawing.Point(41, 309)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(123, 29)
        Me.btnChangePassword.TabIndex = 55
        Me.btnChangePassword.Text = "Change Password"
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'CustomerProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.rbFemale)
        Me.Controls.Add(Me.rbMale)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtVillage)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.picProfile)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CustomerProfile"
        Me.Size = New System.Drawing.Size(517, 510)
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnChange As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtVillage As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents txtPhone As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents btnChangePassword As Button
End Class
