﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrationAproval
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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnRider = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(208, 42)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 23)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "Data"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.OMC21.My.Resources.Resources.OrderJeLogo
        Me.PictureBox1.Location = New System.Drawing.Point(45, -5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        '
        'btnCustomer
        '
        Me.btnCustomer.Location = New System.Drawing.Point(45, 120)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(90, 47)
        Me.btnCustomer.TabIndex = 72
        Me.btnCustomer.Text = "Customer"
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'btnRider
        '
        Me.btnRider.Location = New System.Drawing.Point(134, 120)
        Me.btnRider.Name = "btnRider"
        Me.btnRider.Size = New System.Drawing.Size(90, 47)
        Me.btnRider.TabIndex = 73
        Me.btnRider.Text = "Rider"
        Me.btnRider.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(45, 164)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(527, 279)
        Me.DataGridView1.TabIndex = 74
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(223, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 47)
        Me.Button1.TabIndex = 75
        Me.Button1.Text = "Cafe Owner"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RegistrationAproval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnRider)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RegistrationAproval"
        Me.Size = New System.Drawing.Size(622, 470)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnRider As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
End Class
