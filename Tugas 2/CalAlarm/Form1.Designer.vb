<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AlarmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewAlarmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukaArsipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlarmToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1212, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AlarmToolStripMenuItem
        '
        Me.AlarmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewAlarmToolStripMenuItem, Me.BukaArsipToolStripMenuItem, Me.LoadToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.AlarmToolStripMenuItem.Name = "AlarmToolStripMenuItem"
        Me.AlarmToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.AlarmToolStripMenuItem.Text = "Alarm"
        '
        'NewAlarmToolStripMenuItem
        '
        Me.NewAlarmToolStripMenuItem.Name = "NewAlarmToolStripMenuItem"
        Me.NewAlarmToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.NewAlarmToolStripMenuItem.Text = "Tambah Alarm"
        '
        'BukaArsipToolStripMenuItem
        '
        Me.BukaArsipToolStripMenuItem.Name = "BukaArsipToolStripMenuItem"
        Me.BukaArsipToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.BukaArsipToolStripMenuItem.Text = "Simpan"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.LoadToolStripMenuItem.Text = "Load"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Waktu Sekarang :"
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Location = New System.Drawing.Point(132, 32)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(0, 16)
        Me.lblDateTime.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1212, 383)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Alarmku"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AlarmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewAlarmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaArsipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDateTime As Label
End Class
