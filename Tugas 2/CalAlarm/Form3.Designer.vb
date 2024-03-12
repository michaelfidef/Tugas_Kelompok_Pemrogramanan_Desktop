<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.Alarmku = New System.Windows.Forms.Label()
        Me.btnMatikan = New System.Windows.Forms.Button()
<<<<<<< HEAD
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.lblWaktu = New System.Windows.Forms.Label()
=======
        Me.lblWaktuSekarang = New System.Windows.Forms.Label()
>>>>>>> 47218c8aa92fae1a18f9e4cdf1bba43548975c90
        Me.SuspendLayout()
        '
        'Alarmku
        '
        Me.Alarmku.AutoSize = True
        Me.Alarmku.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alarmku.Location = New System.Drawing.Point(34, 17)
        Me.Alarmku.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Alarmku.Name = "Alarmku"
        Me.Alarmku.Size = New System.Drawing.Size(66, 17)
        Me.Alarmku.TabIndex = 0
        Me.Alarmku.Text = "Alarmku"
        '
<<<<<<< HEAD
=======
        'lblSetWaktuAlarm
        '
        Me.lblSetWaktuAlarm.AutoSize = True
        Me.lblSetWaktuAlarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetWaktuAlarm.Location = New System.Drawing.Point(34, 72)
        Me.lblSetWaktuAlarm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSetWaktuAlarm.Name = "lblSetWaktuAlarm"
        Me.lblSetWaktuAlarm.Size = New System.Drawing.Size(18, 13)
        Me.lblSetWaktuAlarm.TabIndex = 1
        Me.lblSetWaktuAlarm.Text = "tgl"
        '
>>>>>>> 47218c8aa92fae1a18f9e4cdf1bba43548975c90
        'btnMatikan
        '
        Me.btnMatikan.Location = New System.Drawing.Point(200, 52)
        Me.btnMatikan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMatikan.Name = "btnMatikan"
        Me.btnMatikan.Size = New System.Drawing.Size(56, 19)
        Me.btnMatikan.TabIndex = 2
        Me.btnMatikan.Text = "Matikan!"
        Me.btnMatikan.UseVisualStyleBackColor = True
        '
<<<<<<< HEAD
        'lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Location = New System.Drawing.Point(49, 55)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(48, 16)
        Me.lblTanggal.TabIndex = 3
        Me.lblTanggal.Text = "Label1"
        '
        'lblWaktu
        '
        Me.lblWaktu.AutoSize = True
        Me.lblWaktu.Location = New System.Drawing.Point(49, 94)
        Me.lblWaktu.Name = "lblWaktu"
        Me.lblWaktu.Size = New System.Drawing.Size(48, 16)
        Me.lblWaktu.TabIndex = 4
        Me.lblWaktu.Text = "Label2"
=======
        'lblWaktuSekarang
        '
        Me.lblWaktuSekarang.AutoSize = True
        Me.lblWaktuSekarang.Location = New System.Drawing.Point(37, 38)
        Me.lblWaktuSekarang.Name = "lblWaktuSekarang"
        Me.lblWaktuSekarang.Size = New System.Drawing.Size(39, 13)
        Me.lblWaktuSekarang.TabIndex = 3
        Me.lblWaktuSekarang.Text = "Label1"
>>>>>>> 47218c8aa92fae1a18f9e4cdf1bba43548975c90
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< HEAD
        Me.ClientSize = New System.Drawing.Size(423, 134)
        Me.Controls.Add(Me.lblWaktu)
        Me.Controls.Add(Me.lblTanggal)
=======
        Me.ClientSize = New System.Drawing.Size(317, 109)
        Me.Controls.Add(Me.lblWaktuSekarang)
>>>>>>> 47218c8aa92fae1a18f9e4cdf1bba43548975c90
        Me.Controls.Add(Me.btnMatikan)
        Me.Controls.Add(Me.Alarmku)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form3"
        Me.Text = "Alarm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Alarmku As Label
    Friend WithEvents btnMatikan As Button
<<<<<<< HEAD
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblWaktu As Label
=======
    Friend WithEvents lblWaktuSekarang As Label
>>>>>>> 47218c8aa92fae1a18f9e4cdf1bba43548975c90
End Class
