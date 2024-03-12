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

        CheckAndRemoveExpiredPanels()
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
        MyPanelsData.Clear()

        Dim lines As String() = File.ReadAllLines(OpenFileDialog1.FileName)

        For Each line As String In lines
            Dim parts As String() = line.Split(","c)

            If parts.Length = 2 Then
                Dim timePart As String() = parts(0).Split(" "c)
                Dim datePart As String() = parts(1).Trim().Split("/"c)

                Dim timeData As String() = timePart(1).Trim().Split(":"c)
                Dim hour As String = timeData(0).Trim()
                Dim minutes As String = timeData(1).Trim()
                Dim second As String = timeData(2).Trim()

                Dim day As String = datePart(0).Trim()
                Dim month As String = datePart(1).Trim()
                Dim year As String = datePart(2).Trim()

                MyPanelsData.Add(New PanelData() With {
                    .Hour = hour,
                    .Minutes = minutes,
                    .Second = second,
                    .Dates = $"{day}/{month}/{year}"
                })
            Else
                MessageBox.Show("Format data tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next
        ' MessageBox.Show("Data panel berhasil dimuat.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub RemoveAllPanels()
        Dim panelsToRemove As New List(Of Panel)

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Panel Then
                panelsToRemove.Add(TryCast(ctrl, Panel))
            End If
        Next

        For Each panelToRemove As Panel In panelsToRemove
            Me.Controls.Remove(panelToRemove)
            panelToRemove.Dispose()
        Next
    End Sub

    Public Sub DisplayLoadedData()
        RemoveAllPanels()

        If MyPanelsData IsNot Nothing AndAlso MyPanelsData.Count > 0 Then
            Dim panelWidth As Integer = 200
            Dim panelHeight As Integer = 100
            Dim panelSpacing As Integer = 10
            Dim verticalSpacing As Integer = 10

            Dim totalPanels As Integer = MyPanelsData.Count

            Dim rowCount As Integer = 0
            Dim columnCount As Integer = 0

            For i As Integer = 0 To totalPanels - 1

                Dim panel As New Panel()
                With panel
                    .BackColor = Color.Pink
                    .BorderStyle = BorderStyle.FixedSingle
                    .Size = New Size(panelWidth, panelHeight)
                    .Location = New Point(columnCount * (panelWidth + panelSpacing), rowCount * (panelHeight + verticalSpacing) + 60)
                End With

                Dim lblWaktu As New Label
                With lblWaktu
                    .Name = "waktu"
                    .Text = $"{MyPanelsData(i).Hour}:{MyPanelsData(i).Minutes}:{MyPanelsData(i).Second}"
                    .Location = New Point(10, 20)
                    .Font = New Font(lblWaktu.Font, FontStyle.Bold)
                    .Font = New Font(lblWaktu.Font.FontFamily, 20)
                    .AutoSize = True
                End With

                Dim lblTanggal As New Label
                With lblTanggal
                    .Name = "tanggal"
                    .Text = $"{MyPanelsData(i).Dates}"
                    .Location = New Point(10, 60)
                    .AutoSize = True
                End With

                panel.Controls.Add(lblWaktu)
                panel.Controls.Add(lblTanggal)

                Me.Controls.Add(panel)

                columnCount += 1
                If columnCount = 4 Then
                    columnCount = 0
                    rowCount += 1
                End If
            Next
        Else
            MessageBox.Show("Tidak ada data panel yang dimuat.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Public Sub CheckAndRemoveExpiredPanels()
        Dim panelsToRemove As New List(Of Panel)

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Panel Then
                Dim panel As Panel = TryCast(ctrl, Panel)
                Dim waktuLabel As Label = panel.Controls.OfType(Of Label).FirstOrDefault(Function(lbl) lbl.Name = "waktu")
                Dim tanggalLabel As Label = panel.Controls.OfType(Of Label).FirstOrDefault(Function(lbl) lbl.Name = "tanggal")

                If waktuLabel IsNot Nothing AndAlso tanggalLabel IsNot Nothing Then
                    Dim waktuPanel As DateTime
                    If DateTime.TryParseExact(waktuLabel.Text, "HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, waktuPanel) Then
                        Dim tanggalPanel As DateTime
                        If DateTime.TryParseExact(tanggalLabel.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, tanggalPanel) Then
                            If waktuPanel <= DateTime.Now AndAlso tanggalPanel <= DateTime.Now.Date Then
                                ' Tambahkan panel ke dalam list panelsToRemove
                                panelsToRemove.Add(panel)
                            End If
                        End If
                    End If
                End If
            End If
        Next

        ' Hapus panel-panel yang telah ditentukan dari daftar MyPanelsData dan dari form
        For Each panelToRemove As Panel In panelsToRemove
            Dim waktuPanelText As String = panelToRemove.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name = "waktu")?.Text
            Dim tanggalPanelText As String = panelToRemove.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name = "tanggal")?.Text

            ' Hapus panel dari daftar MyPanelsData
            Dim panelDataToRemove As PanelData = MyPanelsData.FirstOrDefault(Function(p) $"{p.Hour}:{p.Minutes}:{p.Second}" = waktuPanelText AndAlso p.Dates = tanggalPanelText)
            If panelDataToRemove IsNot Nothing Then
                MyPanelsData.Remove(panelDataToRemove)

                ' Kirim data ke Form3
                Dim form3 As New Form3(panelDataToRemove)
                form3.Show()
            End If

            ' Hapus panel dari form
            Me.Controls.Remove(panelToRemove)
            panelToRemove.Dispose()
        Next
    End Sub




End Class