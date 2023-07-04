<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashScreen
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
        Me.components = New System.ComponentModel.Container()
        Me.TimerLoading = New System.Windows.Forms.Timer(Me.components)
        Me.picOrderJe = New System.Windows.Forms.PictureBox()
        Me.picLoading = New System.Windows.Forms.PictureBox()
        Me.Bar = New System.Windows.Forms.Panel()
        Me.Value = New System.Windows.Forms.Panel()
        Me.lblVersion = New System.Windows.Forms.Label()
        CType(Me.picOrderJe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimerLoading
        '
        '
        'picOrderJe
        '
        Me.picOrderJe.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.picOrderJe.BackgroundImage = Global.OMC21.My.Resources.Resources.loading
        Me.picOrderJe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picOrderJe.Image = Global.OMC21.My.Resources.Resources.OrderJeLogo2
        Me.picOrderJe.Location = New System.Drawing.Point(239, 115)
        Me.picOrderJe.Name = "picOrderJe"
        Me.picOrderJe.Size = New System.Drawing.Size(172, 169)
        Me.picOrderJe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOrderJe.TabIndex = 0
        Me.picOrderJe.TabStop = False
        '
        'picLoading
        '
        Me.picLoading.BackColor = System.Drawing.Color.Transparent
        Me.picLoading.Image = Global.OMC21.My.Resources.Resources.loading1
        Me.picLoading.Location = New System.Drawing.Point(186, 58)
        Me.picLoading.Name = "picLoading"
        Me.picLoading.Size = New System.Drawing.Size(280, 280)
        Me.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLoading.TabIndex = 1
        Me.picLoading.TabStop = False
        '
        'Bar
        '
        Me.Bar.Controls.Add(Me.Value)
        Me.Bar.Location = New System.Drawing.Point(-1, 352)
        Me.Bar.Name = "Bar"
        Me.Bar.Size = New System.Drawing.Size(661, 30)
        Me.Bar.TabIndex = 2
        Me.Bar.Visible = False
        '
        'Value
        '
        Me.Value.BackColor = System.Drawing.Color.SeaGreen
        Me.Value.Location = New System.Drawing.Point(-1, 0)
        Me.Value.Name = "Value"
        Me.Value.Size = New System.Drawing.Size(1, 30)
        Me.Value.TabIndex = 3
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.lblVersion.ForeColor = System.Drawing.SystemColors.Control
        Me.lblVersion.Location = New System.Drawing.Point(571, 332)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(77, 17)
        Me.lblVersion.TabIndex = 4
        Me.lblVersion.Text = "version 1.0.0"
        Me.lblVersion.Visible = False
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(660, 415)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.Bar)
        Me.Controls.Add(Me.picOrderJe)
        Me.Controls.Add(Me.picLoading)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SplashScreen"
        CType(Me.picOrderJe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picOrderJe As PictureBox
    Friend WithEvents picLoading As PictureBox
    Friend WithEvents TimerLoading As Timer
    Friend WithEvents Bar As Panel
    Friend WithEvents Value As Panel
    Friend WithEvents lblVersion As Label
End Class
