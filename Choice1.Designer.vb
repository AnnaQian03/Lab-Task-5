<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Choice1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNNext = New System.Windows.Forms.Button()
        Me.BTNCheck = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Point = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(287, 94)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "What is vb.net"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTNNext
        '
        Me.BTNNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BTNNext.Location = New System.Drawing.Point(223, 327)
        Me.BTNNext.Name = "BTNNext"
        Me.BTNNext.Size = New System.Drawing.Size(106, 47)
        Me.BTNNext.TabIndex = 4
        Me.BTNNext.Text = "Next"
        Me.BTNNext.UseVisualStyleBackColor = True
        '
        'BTNCheck
        '
        Me.BTNCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BTNCheck.Location = New System.Drawing.Point(12, 327)
        Me.BTNCheck.Name = "BTNCheck"
        Me.BTNCheck.Size = New System.Drawing.Size(108, 47)
        Me.BTNCheck.TabIndex = 5
        Me.BTNCheck.Text = "Check It !"
        Me.BTNCheck.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.RadioButton1.Location = New System.Drawing.Point(23, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(239, 29)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Programming Language"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 151)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.RadioButton2.Location = New System.Drawing.Point(23, 63)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(187, 29)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "High class fish net"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.RadioButton3.Location = New System.Drawing.Point(23, 107)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(149, 29)
        Me.RadioButton3.TabIndex = 8
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Video Games"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Point
        '
        Me.Point.AutoSize = True
        Me.Point.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Point.Location = New System.Drawing.Point(237, 296)
        Me.Point.Name = "Point"
        Me.Point.Size = New System.Drawing.Size(0, 25)
        Me.Point.TabIndex = 8
        '
        'Choice1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 406)
        Me.Controls.Add(Me.Point)
        Me.Controls.Add(Me.BTNCheck)
        Me.Controls.Add(Me.BTNNext)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Choice1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choice1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents BTNNext As Button
    Friend WithEvents BTNCheck As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Point As Label
End Class
