<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formBeranda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formBeranda))
        leftPanel = New Panel()
        btnLaporan = New Button()
        btnAkunPenghuni = New Button()
        btnKomplain = New Button()
        btnTagihan = New Button()
        btnPenghuniKamar = New Button()
        btnKamarKost = New Button()
        TextBox1 = New TextBox()
        btnBeranda = New Button()
        topPanel = New Panel()
        TextBox8 = New TextBox()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        btnAkun = New Button()
        panelBeranda = New Panel()
        Label7 = New Label()
        TextBox3 = New TextBox()
        Panel6 = New Panel()
        Label1 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        TextBox2 = New TextBox()
        Panel5 = New Panel()
        TextBox7 = New TextBox()
        Label5 = New Label()
        Panel10 = New Panel()
        Panel4 = New Panel()
        TextBox6 = New TextBox()
        Label4 = New Label()
        Panel9 = New Panel()
        Panel2 = New Panel()
        TextBox5 = New TextBox()
        Label3 = New Label()
        Panel8 = New Panel()
        Panel1 = New Panel()
        TextBox4 = New TextBox()
        Label2 = New Label()
        Panel7 = New Panel()
        leftPanel.SuspendLayout()
        topPanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        panelBeranda.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' leftPanel
        ' 
        leftPanel.BackColor = Color.WhiteSmoke
        leftPanel.Controls.Add(btnLaporan)
        leftPanel.Controls.Add(btnAkunPenghuni)
        leftPanel.Controls.Add(btnKomplain)
        leftPanel.Controls.Add(btnTagihan)
        leftPanel.Controls.Add(btnPenghuniKamar)
        leftPanel.Controls.Add(btnKamarKost)
        leftPanel.Controls.Add(TextBox1)
        leftPanel.Controls.Add(btnBeranda)
        leftPanel.ForeColor = Color.Black
        leftPanel.Location = New Point(-3, 22)
        leftPanel.Name = "leftPanel"
        leftPanel.Size = New Size(203, 410)
        leftPanel.TabIndex = 0
        ' 
        ' btnLaporan
        ' 
        btnLaporan.FlatAppearance.BorderSize = 0
        btnLaporan.FlatStyle = FlatStyle.Flat
        btnLaporan.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLaporan.Image = CType(resources.GetObject("btnLaporan.Image"), Image)
        btnLaporan.ImageAlign = ContentAlignment.MiddleLeft
        btnLaporan.Location = New Point(3, 248)
        btnLaporan.Name = "btnLaporan"
        btnLaporan.Size = New Size(197, 36)
        btnLaporan.TabIndex = 8
        btnLaporan.Text = "   Laporan"
        btnLaporan.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLaporan.UseVisualStyleBackColor = True
        ' 
        ' btnAkunPenghuni
        ' 
        btnAkunPenghuni.FlatAppearance.BorderSize = 0
        btnAkunPenghuni.FlatStyle = FlatStyle.Flat
        btnAkunPenghuni.Font = New Font("Montserrat", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAkunPenghuni.Image = CType(resources.GetObject("btnAkunPenghuni.Image"), Image)
        btnAkunPenghuni.ImageAlign = ContentAlignment.MiddleLeft
        btnAkunPenghuni.Location = New Point(3, 332)
        btnAkunPenghuni.Name = "btnAkunPenghuni"
        btnAkunPenghuni.Size = New Size(197, 36)
        btnAkunPenghuni.TabIndex = 7
        btnAkunPenghuni.Text = "   Akun Penghuni"
        btnAkunPenghuni.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAkunPenghuni.UseVisualStyleBackColor = True
        ' 
        ' btnKomplain
        ' 
        btnKomplain.FlatAppearance.BorderSize = 0
        btnKomplain.FlatStyle = FlatStyle.Flat
        btnKomplain.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKomplain.Image = CType(resources.GetObject("btnKomplain.Image"), Image)
        btnKomplain.ImageAlign = ContentAlignment.MiddleLeft
        btnKomplain.Location = New Point(3, 290)
        btnKomplain.Name = "btnKomplain"
        btnKomplain.Size = New Size(197, 36)
        btnKomplain.TabIndex = 6
        btnKomplain.Text = "  Komplain"
        btnKomplain.TextImageRelation = TextImageRelation.ImageBeforeText
        btnKomplain.UseVisualStyleBackColor = True
        ' 
        ' btnTagihan
        ' 
        btnTagihan.FlatAppearance.BorderSize = 0
        btnTagihan.FlatStyle = FlatStyle.Flat
        btnTagihan.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTagihan.Image = CType(resources.GetObject("btnTagihan.Image"), Image)
        btnTagihan.ImageAlign = ContentAlignment.MiddleLeft
        btnTagihan.Location = New Point(3, 206)
        btnTagihan.Name = "btnTagihan"
        btnTagihan.Size = New Size(197, 36)
        btnTagihan.TabIndex = 4
        btnTagihan.Text = "   Tagihan"
        btnTagihan.TextImageRelation = TextImageRelation.ImageBeforeText
        btnTagihan.UseVisualStyleBackColor = True
        ' 
        ' btnPenghuniKamar
        ' 
        btnPenghuniKamar.FlatAppearance.BorderSize = 0
        btnPenghuniKamar.FlatStyle = FlatStyle.Flat
        btnPenghuniKamar.Font = New Font("Montserrat", 11F, FontStyle.Bold)
        btnPenghuniKamar.Image = CType(resources.GetObject("btnPenghuniKamar.Image"), Image)
        btnPenghuniKamar.ImageAlign = ContentAlignment.MiddleLeft
        btnPenghuniKamar.Location = New Point(3, 164)
        btnPenghuniKamar.Name = "btnPenghuniKamar"
        btnPenghuniKamar.Size = New Size(197, 36)
        btnPenghuniKamar.TabIndex = 3
        btnPenghuniKamar.Text = "   Penghuni Kamar"
        btnPenghuniKamar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnPenghuniKamar.UseVisualStyleBackColor = True
        ' 
        ' btnKamarKost
        ' 
        btnKamarKost.FlatAppearance.BorderSize = 0
        btnKamarKost.FlatStyle = FlatStyle.Flat
        btnKamarKost.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKamarKost.Image = CType(resources.GetObject("btnKamarKost.Image"), Image)
        btnKamarKost.ImageAlign = ContentAlignment.MiddleLeft
        btnKamarKost.Location = New Point(3, 122)
        btnKamarKost.Name = "btnKamarKost"
        btnKamarKost.Size = New Size(197, 36)
        btnKamarKost.TabIndex = 2
        btnKamarKost.Text = "  Kamar Kost"
        btnKamarKost.TextImageRelation = TextImageRelation.ImageBeforeText
        btnKamarKost.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.WhiteSmoke
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Montserrat ExtraBold", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(3, 7)
        TextBox1.Name = "TextBox1"
        TextBox1.RightToLeft = RightToLeft.Yes
        TextBox1.Size = New Size(131, 46)
        TextBox1.TabIndex = 1
        TextBox1.Text = "LOGO"
        ' 
        ' btnBeranda
        ' 
        btnBeranda.BackColor = Color.Orange
        btnBeranda.FlatAppearance.BorderSize = 0
        btnBeranda.FlatStyle = FlatStyle.Flat
        btnBeranda.Font = New Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBeranda.Image = CType(resources.GetObject("btnBeranda.Image"), Image)
        btnBeranda.ImageAlign = ContentAlignment.MiddleLeft
        btnBeranda.Location = New Point(0, 80)
        btnBeranda.Name = "btnBeranda"
        btnBeranda.Size = New Size(203, 36)
        btnBeranda.TabIndex = 0
        btnBeranda.Text = "  Beranda"
        btnBeranda.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBeranda.UseVisualStyleBackColor = False
        ' 
        ' topPanel
        ' 
        topPanel.BackColor = Color.WhiteSmoke
        topPanel.Controls.Add(TextBox8)
        topPanel.Controls.Add(Label6)
        topPanel.Controls.Add(PictureBox1)
        topPanel.Controls.Add(btnAkun)
        topPanel.Location = New Point(238, 0)
        topPanel.Name = "topPanel"
        topPanel.Size = New Size(608, 55)
        topPanel.TabIndex = 1
        ' 
        ' TextBox8
        ' 
        TextBox8.BackColor = Color.WhiteSmoke
        TextBox8.BorderStyle = BorderStyle.None
        TextBox8.Font = New Font("Montserrat ExtraBold", 25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox8.Location = New Point(7, 5)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(235, 41)
        TextBox8.TabIndex = 4
        TextBox8.Text = "BERANDA"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Montserrat", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(243, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(130, 19)
        Label6.TabIndex = 3
        Label6.Text = "25 Agustus 2024"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Location = New Point(379, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(63, 50)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' btnAkun
        ' 
        btnAkun.FlatAppearance.BorderSize = 0
        btnAkun.FlatStyle = FlatStyle.Flat
        btnAkun.Font = New Font("Montserrat Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAkun.Image = CType(resources.GetObject("btnAkun.Image"), Image)
        btnAkun.Location = New Point(461, 0)
        btnAkun.Name = "btnAkun"
        btnAkun.Size = New Size(144, 54)
        btnAkun.TabIndex = 0
        btnAkun.Text = "Halo, User"
        btnAkun.TextImageRelation = TextImageRelation.TextBeforeImage
        btnAkun.UseVisualStyleBackColor = True
        ' 
        ' panelBeranda
        ' 
        panelBeranda.BackColor = Color.WhiteSmoke
        panelBeranda.Controls.Add(Label7)
        panelBeranda.Controls.Add(TextBox3)
        panelBeranda.Controls.Add(Panel6)
        panelBeranda.Controls.Add(Panel5)
        panelBeranda.Controls.Add(Panel4)
        panelBeranda.Controls.Add(Panel2)
        panelBeranda.Controls.Add(Panel1)
        panelBeranda.Location = New Point(238, 61)
        panelBeranda.Name = "panelBeranda"
        panelBeranda.Size = New Size(608, 371)
        panelBeranda.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(24, 289)
        Label7.Name = "Label7"
        Label7.RightToLeft = RightToLeft.No
        Label7.Size = New Size(229, 22)
        Label7.TabIndex = 4
        Label7.Text = "Selamat datang di Aplikasi..."
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.WhiteSmoke
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Font = New Font("Montserrat ExtraBold", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(24, 238)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(257, 49)
        TextBox3.TabIndex = 3
        TextBox3.Text = "HALO USER"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Orange
        Panel6.Controls.Add(Label1)
        Panel6.Controls.Add(FlowLayoutPanel1)
        Panel6.Controls.Add(TextBox2)
        Panel6.Location = New Point(308, 209)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(278, 142)
        Panel6.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Montserrat ExtraBold", 9.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(108, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(167, 19)
        Label1.TabIndex = 5
        Label1.Text = "TOTAL PENDAPATAN"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.WhiteSmoke
        FlowLayoutPanel1.BackgroundImage = CType(resources.GetObject("FlowLayoutPanel1.BackgroundImage"), Image)
        FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Center
        FlowLayoutPanel1.Location = New Point(15, 13)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(88, 117)
        FlowLayoutPanel1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Orange
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("American Captain", 35F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = Color.Transparent
        TextBox2.Location = New Point(109, 53)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(166, 56)
        TextBox2.TabIndex = 3
        TextBox2.Text = "2.000.000"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Orange
        Panel5.Controls.Add(TextBox7)
        Panel5.Controls.Add(Label5)
        Panel5.Controls.Add(Panel10)
        Panel5.Location = New Point(450, 19)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(136, 162)
        Panel5.TabIndex = 1
        ' 
        ' TextBox7
        ' 
        TextBox7.BackColor = Color.Orange
        TextBox7.BorderStyle = BorderStyle.None
        TextBox7.Font = New Font("American Captain", 37F)
        TextBox7.ForeColor = Color.Transparent
        TextBox7.Location = New Point(57, 90)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(31, 59)
        TextBox7.TabIndex = 9
        TextBox7.Text = "3"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Montserrat Medium", 8.249999F, FontStyle.Bold)
        Label5.ForeColor = Color.WhiteSmoke
        Label5.Location = New Point(11, 145)
        Label5.Name = "Label5"
        Label5.Size = New Size(113, 15)
        Label5.TabIndex = 8
        Label5.Text = "AKUN PENGGUNA"
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.WhiteSmoke
        Panel10.BackgroundImage = CType(resources.GetObject("Panel10.BackgroundImage"), Image)
        Panel10.BackgroundImageLayout = ImageLayout.Center
        Panel10.Location = New Point(8, 8)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(120, 76)
        Panel10.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Orange
        Panel4.Controls.Add(TextBox6)
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(Panel9)
        Panel4.Location = New Point(308, 19)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(136, 162)
        Panel4.TabIndex = 2
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = Color.Orange
        TextBox6.BorderStyle = BorderStyle.None
        TextBox6.Font = New Font("American Captain", 37F)
        TextBox6.ForeColor = Color.Transparent
        TextBox6.Location = New Point(57, 90)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(31, 59)
        TextBox6.TabIndex = 7
        TextBox6.Text = "3"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Montserrat Medium", 8.249999F, FontStyle.Bold)
        Label4.ForeColor = Color.WhiteSmoke
        Label4.Location = New Point(11, 145)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 15)
        Label4.TabIndex = 8
        Label4.Text = "JUMLAH TAGIHAN"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.WhiteSmoke
        Panel9.BackgroundImage = CType(resources.GetObject("Panel9.BackgroundImage"), Image)
        Panel9.BackgroundImageLayout = ImageLayout.Center
        Panel9.Location = New Point(8, 8)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(120, 76)
        Panel9.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Orange
        Panel2.Controls.Add(TextBox5)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Panel8)
        Panel2.Location = New Point(166, 19)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(136, 162)
        Panel2.TabIndex = 1
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.Orange
        TextBox5.BorderStyle = BorderStyle.None
        TextBox5.Font = New Font("American Captain", 37F)
        TextBox5.ForeColor = Color.Transparent
        TextBox5.Location = New Point(56, 90)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(31, 59)
        TextBox5.TabIndex = 7
        TextBox5.Text = "3"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Montserrat Medium", 8.249999F, FontStyle.Bold)
        Label3.ForeColor = Color.WhiteSmoke
        Label3.Location = New Point(23, 145)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 15)
        Label3.TabIndex = 7
        Label3.Text = "KAMAR KOST"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.WhiteSmoke
        Panel8.BackgroundImage = CType(resources.GetObject("Panel8.BackgroundImage"), Image)
        Panel8.BackgroundImageLayout = ImageLayout.Center
        Panel8.Location = New Point(8, 8)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(120, 76)
        Panel8.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Orange
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Panel7)
        Panel1.Location = New Point(24, 19)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(136, 162)
        Panel1.TabIndex = 0
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.Orange
        TextBox4.BorderStyle = BorderStyle.None
        TextBox4.Font = New Font("American Captain", 37F)
        TextBox4.ForeColor = Color.Transparent
        TextBox4.Location = New Point(57, 90)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(31, 59)
        TextBox4.TabIndex = 6
        TextBox4.Text = "3"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Montserrat Medium", 8.249999F, FontStyle.Bold)
        Label2.ForeColor = Color.WhiteSmoke
        Label2.Location = New Point(13, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 15)
        Label2.TabIndex = 6
        Label2.Text = "PENGHUNI KOST"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.WhiteSmoke
        Panel7.BackgroundImage = CType(resources.GetObject("Panel7.BackgroundImage"), Image)
        Panel7.BackgroundImageLayout = ImageLayout.Center
        Panel7.Location = New Point(8, 8)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(120, 76)
        Panel7.TabIndex = 0
        ' 
        ' formBeranda
        ' 
        AccessibleRole = AccessibleRole.None
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.IndianRed
        ClientSize = New Size(867, 459)
        Controls.Add(panelBeranda)
        Controls.Add(topPanel)
        Controls.Add(leftPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "formBeranda"
        Text = "Aplikasi Manajemen Kost"
        leftPanel.ResumeLayout(False)
        leftPanel.PerformLayout()
        topPanel.ResumeLayout(False)
        topPanel.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        panelBeranda.ResumeLayout(False)
        panelBeranda.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Public WithEvents leftPanel As Panel
    Friend WithEvents topPanel As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnBeranda As Button
    Friend WithEvents btnKamarKost As Button
    Friend WithEvents btnPenghuniKamar As Button
    Friend WithEvents btnTagihan As Button
    Friend WithEvents btnKomplain As Button
    Friend WithEvents btnAkunPenghuni As Button
    Friend WithEvents btnLaporan As Button
    Friend WithEvents panelBeranda As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents btnAkun As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label7 As Label

End Class
