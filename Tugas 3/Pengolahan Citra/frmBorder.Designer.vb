<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorder
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.cbWarna = New System.Windows.Forms.ComboBox()
        Me.cbKetebalan = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Warna Border :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ketebalan Border :"
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(114, 193)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 2
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(417, 193)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 3
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'cbWarna
        '
        Me.cbWarna.FormattingEnabled = True
        Me.cbWarna.Items.AddRange(New Object() {"Black", "Red", "Green", "Blue"})
        Me.cbWarna.Location = New System.Drawing.Point(368, 65)
        Me.cbWarna.Name = "cbWarna"
        Me.cbWarna.Size = New System.Drawing.Size(169, 24)
        Me.cbWarna.TabIndex = 4
        '
        'cbKetebalan
        '
        Me.cbKetebalan.FormattingEnabled = True
        Me.cbKetebalan.Items.AddRange(New Object() {"5px", "10px", "15px", "25px"})
        Me.cbKetebalan.Location = New System.Drawing.Point(368, 121)
        Me.cbKetebalan.Name = "cbKetebalan"
        Me.cbKetebalan.Size = New System.Drawing.Size(169, 24)
        Me.cbKetebalan.TabIndex = 5
        '
        'frmBorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 253)
        Me.Controls.Add(Me.cbKetebalan)
        Me.Controls.Add(Me.cbWarna)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBorder"
        Me.Text = "Opsi Border"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents cbWarna As ComboBox
    Friend WithEvents cbKetebalan As ComboBox
End Class
