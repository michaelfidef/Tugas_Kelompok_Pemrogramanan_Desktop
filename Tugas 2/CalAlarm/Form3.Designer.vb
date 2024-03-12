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
        Me.btnMatikan = New System.Windows.Forms.Button()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.lblWaktu = New System.Windows.Forms.Label()
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
        'btnMatikan
        '
        Me.btnMatikan.Location = New System.Drawing.Point(266, 64)
        Me.btnMatikan.Name = "btnMatikan"
        Me.btnMatikan.Size = New System.Drawing.Size(75, 23)
        Me.btnMatikan.TabIndex = 2
        Me.btnMatikan.Text = "Matikan!"
        Me.btnMatikan.UseVisualStyleBackColor = True
        '
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
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 134)
        Me.Controls.Add(Me.lblWaktu)
        Me.Controls.Add(Me.lblTanggal)
        Me.Controls.Add(Me.btnMatikan)
        Me.Controls.Add(Me.Alarmku)
        Me.Name = "Form3"
        Me.Text = "Alarm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Alarmku As Label
    Friend WithEvents btnMatikan As Button
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblWaktu As Label
End Class
