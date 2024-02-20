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
        Me.components = New System.ComponentModel.Container()
        Me.lblRound = New System.Windows.Forms.Label()
        Me.btn11 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblGiliran = New System.Windows.Forms.Label()
        Me.lblWaktu = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblScoreX = New System.Windows.Forms.Label()
        Me.lblScoreO = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn12 = New System.Windows.Forms.Button()
        Me.btn23 = New System.Windows.Forms.Button()
        Me.btn22 = New System.Windows.Forms.Button()
        Me.btn21 = New System.Windows.Forms.Button()
        Me.btn33 = New System.Windows.Forms.Button()
        Me.btn32 = New System.Windows.Forms.Button()
        Me.btn31 = New System.Windows.Forms.Button()
        Me.ScoreX = New System.Windows.Forms.Label()
        Me.ScoreO = New System.Windows.Forms.Label()
        Me.btn13 = New System.Windows.Forms.Button()
        Me.lblRound1 = New System.Windows.Forms.Label()
        Me.lblGiliran1 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblRound
        '
        Me.lblRound.AutoSize = True
        Me.lblRound.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblRound.Location = New System.Drawing.Point(279, 20)
        Me.lblRound.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRound.Name = "lblRound"
        Me.lblRound.Size = New System.Drawing.Size(109, 31)
        Me.lblRound.TabIndex = 0
        Me.lblRound.Text = "Round :"
        '
        'btn11
        '
        Me.btn11.Font = New System.Drawing.Font("Microsoft Sans Serif", 79.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn11.Location = New System.Drawing.Point(16, 77)
        Me.btn11.Margin = New System.Windows.Forms.Padding(2)
        Me.btn11.Name = "btn11"
        Me.btn11.Size = New System.Drawing.Size(114, 128)
        Me.btn11.TabIndex = 1
        Me.btn11.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(130, 77)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(0, 0)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblGiliran
        '
        Me.lblGiliran.AutoSize = True
        Me.lblGiliran.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblGiliran.Location = New System.Drawing.Point(387, 112)
        Me.lblGiliran.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGiliran.Name = "lblGiliran"
        Me.lblGiliran.Size = New System.Drawing.Size(84, 50)
        Me.lblGiliran.TabIndex = 11
        Me.lblGiliran.Text = "Giliran " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pemain:"
        '
        'lblWaktu
        '
        Me.lblWaktu.AutoSize = True
        Me.lblWaktu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblWaktu.Location = New System.Drawing.Point(526, 112)
        Me.lblWaktu.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWaktu.Name = "lblWaktu"
        Me.lblWaktu.Size = New System.Drawing.Size(159, 50)
        Me.lblWaktu.TabIndex = 12
        Me.lblWaktu.Text = "Waktu Giliran" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pemain Tersisa :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(507, 145)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 25)
        Me.Label3.TabIndex = 13
        '
        'lblScoreX
        '
        Me.lblScoreX.AutoSize = True
        Me.lblScoreX.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblScoreX.Location = New System.Drawing.Point(387, 274)
        Me.lblScoreX.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblScoreX.Name = "lblScoreX"
        Me.lblScoreX.Size = New System.Drawing.Size(165, 25)
        Me.lblScoreX.TabIndex = 14
        Me.lblScoreX.Text = "Score Pemain X :"
        '
        'lblScoreO
        '
        Me.lblScoreO.AutoSize = True
        Me.lblScoreO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblScoreO.Location = New System.Drawing.Point(387, 318)
        Me.lblScoreO.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblScoreO.Name = "lblScoreO"
        Me.lblScoreO.Size = New System.Drawing.Size(167, 25)
        Me.lblScoreO.TabIndex = 15
        Me.lblScoreO.Text = "Score Pemain O :"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'btn12
        '
        Me.btn12.Font = New System.Drawing.Font("Microsoft Sans Serif", 79.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn12.Location = New System.Drawing.Point(130, 77)
        Me.btn12.Margin = New System.Windows.Forms.Padding(2)
        Me.btn12.Name = "btn12"
        Me.btn12.Size = New System.Drawing.Size(114, 128)
        Me.btn12.TabIndex = 16
        Me.btn12.UseVisualStyleBackColor = True
        '
        'btn23
        '
        Me.btn23.Font = New System.Drawing.Font("Microsoft Sans Serif", 79.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn23.Location = New System.Drawing.Point(243, 204)
        Me.btn23.Margin = New System.Windows.Forms.Padding(2)
        Me.btn23.Name = "btn23"
        Me.btn23.Size = New System.Drawing.Size(114, 128)
        Me.btn23.TabIndex = 20
        Me.btn23.UseVisualStyleBackColor = True
        '
        'btn22
        '
        Me.btn22.Font = New System.Drawing.Font("Microsoft Sans Serif", 79.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn22.Location = New System.Drawing.Point(130, 204)
        Me.btn22.Margin = New System.Windows.Forms.Padding(2)
        Me.btn22.Name = "btn22"
        Me.btn22.Size = New System.Drawing.Size(114, 128)
        Me.btn22.TabIndex = 19
        Me.btn22.UseVisualStyleBackColor = True
        '
        'btn21
        '
        Me.btn21.Font = New System.Drawing.Font("Microsoft Sans Serif", 79.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn21.Location = New System.Drawing.Point(16, 204)
        Me.btn21.Margin = New System.Windows.Forms.Padding(2)
        Me.btn21.Name = "btn21"
        Me.btn21.Size = New System.Drawing.Size(114, 128)
        Me.btn21.TabIndex = 18
        Me.btn21.UseVisualStyleBackColor = True
        '
        'btn33
        '
        Me.btn33.Font = New System.Drawing.Font("Microsoft Sans Serif", 79.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn33.Location = New System.Drawing.Point(243, 331)
        Me.btn33.Margin = New System.Windows.Forms.Padding(2)
        Me.btn33.Name = "btn33"
        Me.btn33.Size = New System.Drawing.Size(114, 128)
        Me.btn33.TabIndex = 23
        Me.btn33.UseVisualStyleBackColor = True
        '
        'btn32
        '
        Me.btn32.Font = New System.Drawing.Font("Microsoft Sans Serif", 79.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn32.Location = New System.Drawing.Point(130, 331)
        Me.btn32.Margin = New System.Windows.Forms.Padding(2)
        Me.btn32.Name = "btn32"
        Me.btn32.Size = New System.Drawing.Size(114, 128)
        Me.btn32.TabIndex = 22
        Me.btn32.UseVisualStyleBackColor = True
        '
        'btn31
        '
        Me.btn31.Font = New System.Drawing.Font("Microsoft Sans Serif", 79.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn31.Location = New System.Drawing.Point(16, 331)
        Me.btn31.Margin = New System.Windows.Forms.Padding(2)
        Me.btn31.Name = "btn31"
        Me.btn31.Size = New System.Drawing.Size(114, 128)
        Me.btn31.TabIndex = 21
        Me.btn31.UseVisualStyleBackColor = True
        '
        'ScoreX
        '
        Me.ScoreX.AutoSize = True
        Me.ScoreX.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreX.Location = New System.Drawing.Point(550, 274)
        Me.ScoreX.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ScoreX.Name = "ScoreX"
        Me.ScoreX.Size = New System.Drawing.Size(23, 25)
        Me.ScoreX.TabIndex = 24
        Me.ScoreX.Text = "0"
        '
        'ScoreO
        '
        Me.ScoreO.AutoSize = True
        Me.ScoreO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreO.Location = New System.Drawing.Point(550, 318)
        Me.ScoreO.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ScoreO.Name = "ScoreO"
        Me.ScoreO.Size = New System.Drawing.Size(23, 25)
        Me.ScoreO.TabIndex = 25
        Me.ScoreO.Text = "0"
        '
        'btn13
        '
        Me.btn13.Font = New System.Drawing.Font("Microsoft Sans Serif", 79.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn13.Location = New System.Drawing.Point(243, 77)
        Me.btn13.Margin = New System.Windows.Forms.Padding(2)
        Me.btn13.Name = "btn13"
        Me.btn13.Size = New System.Drawing.Size(114, 128)
        Me.btn13.TabIndex = 17
        Me.btn13.UseVisualStyleBackColor = True
        '
        'lblRound1
        '
        Me.lblRound1.AutoSize = True
        Me.lblRound1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblRound1.Location = New System.Drawing.Point(376, 20)
        Me.lblRound1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRound1.Name = "lblRound1"
        Me.lblRound1.Size = New System.Drawing.Size(29, 31)
        Me.lblRound1.TabIndex = 26
        Me.lblRound1.Text = "0"
        '
        'lblGiliran1
        '
        Me.lblGiliran1.AutoSize = True
        Me.lblGiliran1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGiliran1.Location = New System.Drawing.Point(410, 174)
        Me.lblGiliran1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGiliran1.Name = "lblGiliran1"
        Me.lblGiliran1.Size = New System.Drawing.Size(26, 25)
        Me.lblGiliran1.TabIndex = 27
        Me.lblGiliran1.Text = "X"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(583, 174)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(34, 25)
        Me.lblTime.TabIndex = 28
        Me.lblTime.Text = "10"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 473)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblGiliran1)
        Me.Controls.Add(Me.lblRound1)
        Me.Controls.Add(Me.ScoreO)
        Me.Controls.Add(Me.ScoreX)
        Me.Controls.Add(Me.btn33)
        Me.Controls.Add(Me.btn32)
        Me.Controls.Add(Me.btn31)
        Me.Controls.Add(Me.btn23)
        Me.Controls.Add(Me.btn22)
        Me.Controls.Add(Me.btn21)
        Me.Controls.Add(Me.btn13)
        Me.Controls.Add(Me.btn12)
        Me.Controls.Add(Me.lblScoreO)
        Me.Controls.Add(Me.lblScoreX)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblWaktu)
        Me.Controls.Add(Me.lblGiliran)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn11)
        Me.Controls.Add(Me.lblRound)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "TikTakToe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRound As Label
    Friend WithEvents btn11 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblGiliran As Label
    Friend WithEvents lblWaktu As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblScoreX As Label
    Friend WithEvents lblScoreO As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn12 As Button
    Friend WithEvents btn23 As Button
    Friend WithEvents btn22 As Button
    Friend WithEvents btn21 As Button
    Friend WithEvents btn33 As Button
    Friend WithEvents btn32 As Button
    Friend WithEvents btn31 As Button
    Friend WithEvents ScoreX As Label
    Friend WithEvents ScoreO As Label
    Friend WithEvents btn13 As Button
    Friend WithEvents lblRound1 As Label
    Friend WithEvents lblGiliran1 As Label
    Friend WithEvents lblTime As Label
End Class
