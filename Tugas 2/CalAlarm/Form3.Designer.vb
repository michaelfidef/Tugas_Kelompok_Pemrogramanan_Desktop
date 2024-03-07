<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Alarmku = New System.Windows.Forms.Label()
        Me.lblSetWaktuAlarm = New System.Windows.Forms.Label()
        Me.btnMatikan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Alarmku
        '
        Me.Alarmku.AutoSize = True
        Me.Alarmku.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alarmku.Location = New System.Drawing.Point(45, 21)
        Me.Alarmku.Name = "Alarmku"
        Me.Alarmku.Size = New System.Drawing.Size(77, 20)
        Me.Alarmku.TabIndex = 0
        Me.Alarmku.Text = "Alarmku"
        '
        'lblSetWaktuAlarm
        '
        Me.lblSetWaktuAlarm.AutoSize = True
        Me.lblSetWaktuAlarm.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetWaktuAlarm.Location = New System.Drawing.Point(45, 89)
        Me.lblSetWaktuAlarm.Name = "lblSetWaktuAlarm"
        Me.lblSetWaktuAlarm.Size = New System.Drawing.Size(21, 16)
        Me.lblSetWaktuAlarm.TabIndex = 1
        Me.lblSetWaktuAlarm.Text = "tgl"
        '
        'btnMatikan
        '
        Me.btnMatikan.Location = New System.Drawing.Point(266, 64)
        Me.btnMatikan.Name = "btnMatikan"
        Me.btnMatikan.Size = New System.Drawing.Size(75, 23)
        Me.btnMatikan.TabIndex = 2
        Me.btnMatikan.Text = "Matikan!"
        Me.btnMatikan.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 134)
        Me.Controls.Add(Me.btnMatikan)
        Me.Controls.Add(Me.lblSetWaktuAlarm)
        Me.Controls.Add(Me.Alarmku)
        Me.Name = "Form3"
        Me.Text = "Alarm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Alarmku As Label
    Friend WithEvents lblSetWaktuAlarm As Label
    Friend WithEvents btnMatikan As Button
End Class
