<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.counterA = New System.Windows.Forms.Button()
        Me.counterB = New System.Windows.Forms.Button()
        Me.generate = New System.Windows.Forms.Button()
        Me.mainInfo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(193, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 37)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(266, 172)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 37)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(339, 172)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(67, 37)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(189, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "NUMBER OF QUEUE"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(193, 215)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(67, 37)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(266, 215)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(67, 37)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(339, 215)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(67, 37)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'counterA
        '
        Me.counterA.Location = New System.Drawing.Point(147, 172)
        Me.counterA.Name = "counterA"
        Me.counterA.Size = New System.Drawing.Size(40, 37)
        Me.counterA.TabIndex = 10
        Me.counterA.Text = "A"
        Me.counterA.UseVisualStyleBackColor = True
        '
        'counterB
        '
        Me.counterB.Location = New System.Drawing.Point(147, 215)
        Me.counterB.Name = "counterB"
        Me.counterB.Size = New System.Drawing.Size(40, 37)
        Me.counterB.TabIndex = 11
        Me.counterB.Text = "B"
        Me.counterB.UseVisualStyleBackColor = True
        '
        'generate
        '
        Me.generate.Location = New System.Drawing.Point(147, 258)
        Me.generate.Name = "generate"
        Me.generate.Size = New System.Drawing.Size(259, 37)
        Me.generate.TabIndex = 16
        Me.generate.Text = "Generate"
        Me.generate.UseVisualStyleBackColor = True
        '
        'mainInfo
        '
        Me.mainInfo.AutoSize = True
        Me.mainInfo.BackColor = System.Drawing.Color.Snow
        Me.mainInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mainInfo.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainInfo.Location = New System.Drawing.Point(6, 14)
        Me.mainInfo.MinimumSize = New System.Drawing.Size(135, 40)
        Me.mainInfo.Name = "mainInfo"
        Me.mainInfo.Size = New System.Drawing.Size(139, 40)
        Me.mainInfo.TabIndex = 17
        Me.mainInfo.Text = "NOW QUEUE"
        Me.mainInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Snow
        Me.Label3.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 92)
        Me.Label3.MinimumSize = New System.Drawing.Size(135, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 35)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "NOW QUEUE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Snow
        Me.Label4.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 136)
        Me.Label4.MinimumSize = New System.Drawing.Size(135, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 35)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "NOW QUEUE"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Snow
        Me.Label5.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 252)
        Me.Label5.MinimumSize = New System.Drawing.Size(135, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 35)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "NOW QUEUE"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Snow
        Me.Label6.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 209)
        Me.Label6.MinimumSize = New System.Drawing.Size(135, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 35)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "NOW QUEUE"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 57)
        Me.Label7.MinimumSize = New System.Drawing.Size(135, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 35)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "A"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 174)
        Me.Label8.MinimumSize = New System.Drawing.Size(135, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 35)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "B"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(419, 300)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.mainInfo)
        Me.Controls.Add(Me.generate)
        Me.Controls.Add(Me.counterB)
        Me.Controls.Add(Me.counterA)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents counterA As System.Windows.Forms.Button
    Friend WithEvents counterB As System.Windows.Forms.Button
    Friend WithEvents generate As System.Windows.Forms.Button
    Friend WithEvents mainInfo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
