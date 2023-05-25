<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Choice3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Choice3))
        Me.BTNCheck = New System.Windows.Forms.Button()
        Me.BTNNext = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Point = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTNCheck
        '
        Me.BTNCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BTNCheck.Location = New System.Drawing.Point(12, 339)
        Me.BTNCheck.Name = "BTNCheck"
        Me.BTNCheck.Size = New System.Drawing.Size(108, 47)
        Me.BTNCheck.TabIndex = 10
        Me.BTNCheck.Text = "Check It !"
        Me.BTNCheck.UseVisualStyleBackColor = True
        '
        'BTNNext
        '
        Me.BTNNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BTNNext.Location = New System.Drawing.Point(223, 339)
        Me.BTNNext.Name = "BTNNext"
        Me.BTNNext.Size = New System.Drawing.Size(106, 47)
        Me.BTNNext.TabIndex = 9
        Me.BTNNext.Text = "Next"
        Me.BTNNext.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(12, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(344, 140)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "what does .ToString(""c2"") function"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.RadioButton1.Location = New System.Drawing.Point(23, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(290, 29)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "change text into financial  type"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 151)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.RadioButton3.Location = New System.Drawing.Point(23, 107)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(225, 29)
        Me.RadioButton3.TabIndex = 8
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "change the text into c2"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.RadioButton2.Location = New System.Drawing.Point(23, 63)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(295, 29)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "change the font type of the text"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Point
        '
        Me.Point.AutoSize = True
        Me.Point.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Point.Location = New System.Drawing.Point(223, 305)
        Me.Point.Name = "Point"
        Me.Point.Size = New System.Drawing.Size(0, 25)
        Me.Point.TabIndex = 12
        '
        'Choice3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 406)
        Me.Controls.Add(Me.Point)
        Me.Controls.Add(Me.BTNCheck)
        Me.Controls.Add(Me.BTNNext)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Choice3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choice3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNCheck As Button
    Friend WithEvents BTNNext As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Point As Label
End Class
