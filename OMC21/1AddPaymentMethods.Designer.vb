<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPaymentMethods
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstMethod = New System.Windows.Forms.ListBox()
        Me.btnAddMethod = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(14, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 23)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(37, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 23)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Payment Methods"
        '
        'lstMethod
        '
        Me.lstMethod.FormattingEnabled = True
        Me.lstMethod.ItemHeight = 17
        Me.lstMethod.Location = New System.Drawing.Point(41, 59)
        Me.lstMethod.Name = "lstMethod"
        Me.lstMethod.Size = New System.Drawing.Size(422, 174)
        Me.lstMethod.TabIndex = 38
        '
        'btnAddMethod
        '
        Me.btnAddMethod.Location = New System.Drawing.Point(176, 260)
        Me.btnAddMethod.Name = "btnAddMethod"
        Me.btnAddMethod.Size = New System.Drawing.Size(147, 31)
        Me.btnAddMethod.TabIndex = 39
        Me.btnAddMethod.Text = "Add Payment Methods"
        Me.btnAddMethod.UseVisualStyleBackColor = True
        '
        'AddPaymentMethods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.btnAddMethod)
        Me.Controls.Add(Me.lstMethod)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AddPaymentMethods"
        Me.Size = New System.Drawing.Size(517, 510)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lstMethod As ListBox
    Friend WithEvents btnAddMethod As Button
End Class
