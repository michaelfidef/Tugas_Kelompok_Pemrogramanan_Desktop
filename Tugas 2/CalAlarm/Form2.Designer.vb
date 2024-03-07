<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.txtDeskripsi = New System.Windows.Forms.TextBox()
        Me.txtBoxHour = New System.Windows.Forms.TextBox()
        Me.txtBoxSecond = New System.Windows.Forms.TextBox()
        Me.txtBoxMinutes = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.lblTimeNow = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(18, 44)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'txtDeskripsi
        '
        Me.txtDeskripsi.Enabled = False
        Me.txtDeskripsi.Location = New System.Drawing.Point(180, 273)
        Me.txtDeskripsi.Name = "txtDeskripsi"
        Me.txtDeskripsi.Size = New System.Drawing.Size(100, 22)
        Me.txtDeskripsi.TabIndex = 1
        '
        'txtBoxHour
        '
        Me.txtBoxHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxHour.Location = New System.Drawing.Point(336, 106)
        Me.txtBoxHour.Name = "txtBoxHour"
        Me.txtBoxHour.Size = New System.Drawing.Size(51, 45)
        Me.txtBoxHour.TabIndex = 2
        Me.txtBoxHour.Text = "00"
        Me.txtBoxHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxSecond
        '
        Me.txtBoxSecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxSecond.Location = New System.Drawing.Point(493, 106)
        Me.txtBoxSecond.Name = "txtBoxSecond"
        Me.txtBoxSecond.Size = New System.Drawing.Size(51, 45)
        Me.txtBoxSecond.TabIndex = 3
        Me.txtBoxSecond.Text = "00"
        Me.txtBoxSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxMinutes
        '
        Me.txtBoxMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxMinutes.Location = New System.Drawing.Point(418, 106)
        Me.txtBoxMinutes.Name = "txtBoxMinutes"
        Me.txtBoxMinutes.Size = New System.Drawing.Size(51, 45)
        Me.txtBoxMinutes.TabIndex = 4
        Me.txtBoxMinutes.Text = "00"
        Me.txtBoxMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(336, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(418, 53)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(508, 53)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(36, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "+"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(336, 175)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(36, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "-"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(418, 175)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(36, 23)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "-"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(508, 175)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(36, 23)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "-"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(469, 228)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 11
        Me.Button7.Text = "Simpan"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(370, 228)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 12
        Me.Button8.Text = "Batal"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'lblTimeNow
        '
        Me.lblTimeNow.AutoSize = True
        Me.lblTimeNow.Location = New System.Drawing.Point(367, 276)
        Me.lblTimeNow.Name = "lblTimeNow"
        Me.lblTimeNow.Size = New System.Drawing.Size(111, 16)
        Me.lblTimeNow.TabIndex = 13
        Me.lblTimeNow.Text = "Waktu sekarang :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(211, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Tambah Alarm Baru"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Deskripsi : "
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Location = New System.Drawing.Point(484, 276)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(0, 16)
        Me.lblDateTime.TabIndex = 16
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(393, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 39)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(475, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 39)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = ":"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 310)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTimeNow)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtBoxMinutes)
        Me.Controls.Add(Me.txtBoxSecond)
        Me.Controls.Add(Me.txtBoxHour)
        Me.Controls.Add(Me.txtDeskripsi)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Name = "Form2"
        Me.Text = "New Alarm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents txtBoxHour As TextBox
    Friend WithEvents txtBoxSecond As TextBox
    Friend WithEvents txtBoxMinutes As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents lblTimeNow As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
