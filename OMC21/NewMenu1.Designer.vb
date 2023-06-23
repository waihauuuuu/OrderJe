<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewMenu1
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
        Me.lstDesc = New System.Windows.Forms.ListBox()
        Me.txbFoodName = New System.Windows.Forms.TextBox()
        Me.lblFoodName = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstDesc
        '
        Me.lstDesc.FormattingEnabled = True
        Me.lstDesc.Location = New System.Drawing.Point(471, 140)
        Me.lstDesc.Name = "lstDesc"
        Me.lstDesc.Size = New System.Drawing.Size(175, 134)
        Me.lstDesc.TabIndex = 34
        '
        'txbFoodName
        '
        Me.txbFoodName.Location = New System.Drawing.Point(179, 302)
        Me.txbFoodName.Name = "txbFoodName"
        Me.txbFoodName.Size = New System.Drawing.Size(164, 20)
        Me.txbFoodName.TabIndex = 33
        '
        'lblFoodName
        '
        Me.lblFoodName.AutoSize = True
        Me.lblFoodName.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFoodName.Location = New System.Drawing.Point(68, 299)
        Me.lblFoodName.Name = "lblFoodName"
        Me.lblFoodName.Size = New System.Drawing.Size(100, 23)
        Me.lblFoodName.TabIndex = 32
        Me.lblFoodName.Text = "Food Name :"
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSave.Location = New System.Drawing.Point(570, 302)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(76, 23)
        Me.btnSave.TabIndex = 30
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(156, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 26)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "New Menu"
        '
        'picBox
        '
        Me.picBox.Location = New System.Drawing.Point(72, 138)
        Me.picBox.Name = "picBox"
        Me.picBox.Size = New System.Drawing.Size(239, 136)
        Me.picBox.TabIndex = 31
        Me.picBox.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.OMC21.My.Resources.Resources.IMG_20230617_214442_218
        Me.PictureBox1.Location = New System.Drawing.Point(45, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'NewMenu1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.Controls.Add(Me.lstDesc)
        Me.Controls.Add(Me.txbFoodName)
        Me.Controls.Add(Me.lblFoodName)
        Me.Controls.Add(Me.picBox)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "NewMenu1"
        Me.Size = New System.Drawing.Size(751, 434)
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstDesc As ListBox
    Friend WithEvents txbFoodName As TextBox
    Friend WithEvents lblFoodName As Label
    Friend WithEvents picBox As PictureBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
