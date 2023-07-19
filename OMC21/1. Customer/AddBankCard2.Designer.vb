<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBankCard2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddBankCard2))
        Me.btnClose = New System.Windows.Forms.Label()
        Me.txtExpired = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtBank = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDate = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCardNumber = New System.Windows.Forms.Label()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCVV = New System.Windows.Forms.MaskedTextBox()
        Me.txtCardNum = New System.Windows.Forms.MaskedTextBox()
        Me.btnAddCard = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(460, 9)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(22, 23)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "X"
        '
        'txtExpired
        '
        Me.txtExpired.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtExpired.Location = New System.Drawing.Point(266, 369)
        Me.txtExpired.Mask = "00/00"
        Me.txtExpired.Name = "txtExpired"
        Me.txtExpired.Size = New System.Drawing.Size(99, 20)
        Me.txtExpired.TabIndex = 67
        Me.txtExpired.Text = "0000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(263, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Expired Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(25, 349)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 17)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Card Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(381, 349)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 17)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "CVV"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(263, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 17)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Cardholder's Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(25, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 17)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Bank"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(266, 301)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(203, 20)
        Me.txtName.TabIndex = 60
        '
        'txtBank
        '
        Me.txtBank.Location = New System.Drawing.Point(26, 301)
        Me.txtBank.Name = "txtBank"
        Me.txtBank.Size = New System.Drawing.Size(203, 20)
        Me.txtBank.TabIndex = 59
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtDate)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblCardNumber)
        Me.Panel1.Controls.Add(Me.lblBank)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Location = New System.Drawing.Point(26, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(305, 191)
        Me.Panel1.TabIndex = 58
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.Color.Blue
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDate.Enabled = False
        Me.txtDate.ForeColor = System.Drawing.Color.White
        Me.txtDate.Location = New System.Drawing.Point(129, 124)
        Me.txtDate.Mask = "00/00"
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(41, 13)
        Me.txtDate.TabIndex = 44
        Me.txtDate.Text = "0000"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(208, 127)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(73, 44)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 43
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(32, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 6.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(55, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 10)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "EXPIRED DATE: "
        '
        'lblCardNumber
        '
        Me.lblCardNumber.AutoSize = True
        Me.lblCardNumber.Font = New System.Drawing.Font("Comic Sans MS", 15.0!)
        Me.lblCardNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCardNumber.Location = New System.Drawing.Point(27, 84)
        Me.lblCardNumber.Name = "lblCardNumber"
        Me.lblCardNumber.Size = New System.Drawing.Size(222, 28)
        Me.lblCardNumber.TabIndex = 2
        Me.lblCardNumber.Text = "0000 0000 0000 0000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblBank
        '
        Me.lblBank.AutoSize = True
        Me.lblBank.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.lblBank.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBank.Location = New System.Drawing.Point(13, 10)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(55, 23)
        Me.lblBank.TabIndex = 1
        Me.lblBank.Text = "BANK"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblName.Location = New System.Drawing.Point(14, 154)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(95, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "NAME SURNAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(22, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 23)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Card Details"
        '
        'txtCVV
        '
        Me.txtCVV.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtCVV.Location = New System.Drawing.Point(384, 369)
        Me.txtCVV.Mask = "000"
        Me.txtCVV.Name = "txtCVV"
        Me.txtCVV.Size = New System.Drawing.Size(85, 20)
        Me.txtCVV.TabIndex = 66
        Me.txtCVV.Text = "000"
        '
        'txtCardNum
        '
        Me.txtCardNum.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtCardNum.Location = New System.Drawing.Point(25, 369)
        Me.txtCardNum.Mask = "0000 0000 0000 0000"
        Me.txtCardNum.Name = "txtCardNum"
        Me.txtCardNum.Size = New System.Drawing.Size(204, 20)
        Me.txtCardNum.TabIndex = 68
        Me.txtCardNum.Text = "0000000000000000"
        '
        'btnAddCard
        '
        Me.btnAddCard.Location = New System.Drawing.Point(171, 405)
        Me.btnAddCard.Name = "btnAddCard"
        Me.btnAddCard.Size = New System.Drawing.Size(147, 31)
        Me.btnAddCard.TabIndex = 69
        Me.btnAddCard.Text = "Add Card"
        Me.btnAddCard.UseVisualStyleBackColor = True
        '
        'AddBankCard2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(495, 448)
        Me.Controls.Add(Me.btnAddCard)
        Me.Controls.Add(Me.txtExpired)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtBank)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCVV)
        Me.Controls.Add(Me.txtCardNum)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddBankCard2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddBankCard2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Label
    Friend WithEvents txtExpired As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtBank As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtDate As MaskedTextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCardNumber As Label
    Friend WithEvents lblBank As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCVV As MaskedTextBox
    Friend WithEvents txtCardNum As MaskedTextBox
    Friend WithEvents btnAddCard As Button
End Class
