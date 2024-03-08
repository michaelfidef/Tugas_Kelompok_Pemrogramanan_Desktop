Imports System.Globalization
Imports System.IO

Public Class Form1

    Public Property MyValue As String
    Public Property MySelectedDate As DateTime
    Public Property MyPanelsData As List(Of PanelData)

    Public Sub New()
        InitializeComponent()
        MyPanelsData = New List(Of PanelData)()
    End Sub

    Private Sub NewAlarmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewAlarmToolStripMenuItem.Click
        Dim SecondForm As New Form2
        SecondForm.PanelsData = MyPanelsData
        SecondForm.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim WIBCulture As New CultureInfo("id-ID")
        lblDateTime.Text = DateAndTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub BukaArsipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaArsipToolStripMenuItem.Click
        SaveDataToFile()
    End Sub

    Public Sub SaveDataToFile()
        If MyPanelsData IsNot Nothing AndAlso MyPanelsData.Count > 0 Then
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "File Teks (*.txt)|*.txt"
            saveFileDialog.Title = "Simpan File Teks"
            saveFileDialog.ShowDialog()

            If saveFileDialog.FileName <> "" Then
                Using sw As New StreamWriter(saveFileDialog.FileName)
                    For Each panelData In MyPanelsData
                        sw.WriteLine($"Panel: {panelData.Hour}:{panelData.Minutes}:{panelData.Second}, {panelData.Dates}")
                    Next
                End Using
            End If
        Else
            MessageBox.Show("Tidak ada data panel yang disimpan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            LoadData()
            DisplayLoadedData()
        End If
    End Sub

    Public Sub LoadData()
        ' Membersihkan data panel sebelum memuat data baru
        MyPanelsData.Clear()

        ' Membaca data dari file teks
        Dim lines As String() = File.ReadAllLines(OpenFileDialog1.FileName)

        ' Memproses setiap baris data
        For Each line As String In lines
            ' Membagi baris menjadi bagian-bagian berdasarkan tanda koma (,)
            Dim parts As String() = line.Split(","c)

            ' Memeriksa apakah baris memiliki format yang diharapkan
            If parts.Length = 2 Then
                ' Memisahkan bagian waktu dan tanggal
                Dim timePart As String() = parts(0).Split(" "c)
                Dim datePart As String() = parts(1).Trim().Split("/"c)

                ' Membaca data waktu
                Dim timeData As String() = timePart(1).Trim().Split(":"c)
                Dim hour As String = timeData(0).Trim()
                Dim minutes As String = timeData(1).Trim()
                Dim second As String = timeData(2).Trim()

                ' Membaca data tanggal
                Dim day As String = datePart(0).Trim()
                Dim month As String = datePart(1).Trim()
                Dim year As String = datePart(2).Trim()

                ' Menambahkan data panel ke dalam list MyPanelsData
                MyPanelsData.Add(New PanelData() With {
                    .Hour = hour,
                    .Minutes = minutes,
                    .Second = second,
                    .Dates = $"{day}/{month}/{year}"
                })
            Else
                ' Menampilkan pesan kesalahan jika format tidak sesuai
                MessageBox.Show("Format data tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next

        MessageBox.Show("Data panel berhasil dimuat.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private WithEvents FlowLayoutPanel1 As New FlowLayoutPanel()

    Private Sub DisplayLoadedData()
        ' Membersihkan FlowLayoutPanel sebelum menampilkan data
        FlowLayoutPanel1.Controls.Clear()

        ' Memeriksa apakah ada data panel yang dimuat
        If MyPanelsData IsNot Nothing AndAlso MyPanelsData.Count > 0 Then
            ' Memproses setiap data panel yang dimuat
            For Each panelData As PanelData In MyPanelsData
                ' Membuat panel untuk menampilkan data panel
                Dim panel As New Panel()
                panel.BackColor = Color.Pink
                panel.BorderStyle = BorderStyle.FixedSingle
                panel.AutoSize = True

                ' Membuat label untuk menampilkan data panel
                Dim lblPanelData As New Label()
                lblPanelData.AutoSize = True
                lblPanelData.Text = $"Panel: {panelData.Hour}:{panelData.Minutes}:{panelData.Second}, {panelData.Dates}"

                ' Menambahkan label ke dalam panel
                panel.Controls.Add(lblPanelData)

                ' Menambahkan panel ke dalam FlowLayoutPanel
                'FlowLayoutPanel1.Controls.Add(panel)            
            Next
        Else
            ' Menampilkan pesan jika tidak ada data panel yang dimuat
            MessageBox.Show("Tidak ada data panel yang dimuat.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


End Class
