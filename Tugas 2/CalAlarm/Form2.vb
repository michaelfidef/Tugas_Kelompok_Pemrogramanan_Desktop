Module Globals
    Public panelCount As Integer = 0
End Module

Public Class Form2

    Public Property SelectedDate As DateTime
    Private Shared panelCount As Integer = 0
    Public Property MyValue As String
    Public Property MySelectedDate As DateTime
    Public Property PanelsData As List(Of PanelData)

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        SelectedDate = Date.Today
        Form1.MySelectedDate = SelectedDate
    End Sub

    Private Sub Form2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtBoxHour.Text = DateAndTime.Now.ToString("HH")
        txtBoxMinutes.Text = DateAndTime.Now.ToString("mm")
        txtBoxSecond.Text = DateAndTime.Now.ToString("ss")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = DateAndTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hourValue As Integer = CInt(txtBoxHour.Text)
        If hourValue < 23 Then
            hourValue += 1
        Else
            hourValue = 0
        End If
        txtBoxHour.Text = hourValue.ToString("00")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim hourValue As Integer = CInt(txtBoxHour.Text)
        If hourValue > 0 Then
            hourValue -= 1
        Else
            hourValue = 23
        End If
        txtBoxHour.Text = hourValue.ToString("00")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim minutesValue As Integer = CInt(txtBoxMinutes.Text)
        If minutesValue < 59 Then
            minutesValue += 1
        Else
            minutesValue = 0
        End If
        txtBoxMinutes.Text = minutesValue.ToString("00")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim minutesValue As Integer = CInt(txtBoxMinutes.Text)
        If minutesValue > 0 Then
            minutesValue -= 1
        Else
            minutesValue = 59
        End If
        txtBoxMinutes.Text = minutesValue.ToString("00")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim secondValue As Integer = CInt(txtBoxSecond.Text)
        If secondValue < 59 Then
            secondValue += 1
        Else
            secondValue = 0
        End If
        txtBoxSecond.Text = secondValue.ToString("00")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim secondValue As Integer = CInt(txtBoxSecond.Text)
        If secondValue > 0 Then
            secondValue -= 1
        Else
            secondValue = 59
        End If
        txtBoxSecond.Text = secondValue.ToString("00")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim inputTime As TimeSpan = TimeSpan.Parse(txtBoxHour.Text & ":" & txtBoxMinutes.Text & ":" & txtBoxSecond.Text)
        Dim currentTime As TimeSpan = DateTime.Now.TimeOfDay

        If inputTime > currentTime Then
            If panelCount < 8 Then
                Dim panelData As New PanelData()
                With panelData
                    .Hour = txtBoxHour.Text
                    .Minutes = txtBoxMinutes.Text
                    .Second = txtBoxSecond.Text
                    .Dates = SelectedDate.ToShortDateString()
                End With

                PanelsData.Add(panelData)
                CreatePanel()
                Form1.DisplayLoadedData()
            Else
                MessageBox.Show("Mohon maaf, data alarm hanya bisa berisi maksimum 8 saja")
            End If
            Me.Close()
        Else
            MessageBox.Show("Waktu yang dimasukkan harus lebih besar dari waktu sekarang", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        SelectedDate = MonthCalendar1.SelectionStart
        Form1.MySelectedDate = SelectedDate
        txtDeskripsi.Text = SelectedDate
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Public Sub CreatePanel()
        Dim panelWidth As Integer = 200
        Dim panelHeight As Integer = 100
        Dim panelSpacing As Integer = 10
        Dim verticalSpacing As Integer = 10

        Dim panelsInCurrentRow As Integer = panelCount Mod 4
        Dim locationX As Integer = panelsInCurrentRow * (panelWidth + panelSpacing)
        Dim locationY As Integer = (panelCount \ 4) * (panelHeight + panelSpacing) + 60

        Dim pnl As New Panel()
        Form1.Controls.Add(pnl)
        With pnl
            .Width = panelWidth
            .Height = panelHeight
            .Location = New Point(locationX, locationY)
            .Name = "panel" & panelCount.ToString
            .Visible = True
            .BackColor = Color.Pink
        End With

        AddLabelsToPanel(pnl)
        panelCount += 1

        FillEmptySpaces()
    End Sub

    Public Sub AddLabelsToPanel(ByVal pnl As Panel)
        Dim lblWaktu As New Label
        With lblWaktu
            .Name = "waktu" & pnl.Name.Substring(5)
            .Text = $"{txtBoxHour.Text}:{txtBoxMinutes.Text}:{txtBoxSecond.Text}"
            .Location = New Point(10, 20)
            .Font = New Font(lblWaktu.Font, FontStyle.Bold)
            .Font = New Font(lblWaktu.Font.FontFamily, 20)
            .AutoSize = True
        End With

        pnl.Controls.Add(lblWaktu)
        Dim lblTanggal As New Label
        With lblTanggal
            .Name = "tanggal" & pnl.Name.Substring(5)
            .Text = SelectedDate.ToShortDateString()
            .Location = New Point(10, 60)
            .AutoSize = True
        End With
        pnl.Controls.Add(lblTanggal)
    End Sub

    Public Sub FillEmptySpaces()
        Dim panelWidth As Integer = 200
        Dim panelHeight As Integer = 100
        Dim panelSpacing As Integer = 10
        Dim verticalSpacing As Integer = 10

        Dim totalPanels As Integer = Me.Controls.OfType(Of Panel)().Count

        Dim rowCount As Integer = 0
        Dim columnCount As Integer = 0

        For i As Integer = 0 To totalPanels - 1
            Dim panel As Panel = Me.Controls.OfType(Of Panel)().FirstOrDefault(Function(p) p.Location = New Point(columnCount * (panelWidth + panelSpacing), rowCount * (panelHeight + verticalSpacing) + 60))

            If panel Is Nothing Then
                panel = New Panel()
                With panel
                    .BackColor = Color.Pink
                    .BorderStyle = BorderStyle.FixedSingle
                    .Size = New Size(panelWidth, panelHeight)
                    .Location = New Point(columnCount * (panelWidth + panelSpacing), rowCount * (panelHeight + verticalSpacing) + 60)
                End With

                Dim lblWaktu As New Label
                With lblWaktu
                    .Name = "waktu"
                    .Text = ""
                    .Location = New Point(10, 20)
                    .Font = New Font(lblWaktu.Font, FontStyle.Bold)
                    .Font = New Font(lblWaktu.Font.FontFamily, 20)
                    .AutoSize = True
                End With

                Dim lblTanggal As New Label
                With lblTanggal
                    .Name = "tanggal"
                    .Text = ""
                    .Location = New Point(10, 60)
                    .AutoSize = True
                End With

                panel.Controls.Add(lblWaktu)
                panel.Controls.Add(lblTanggal)

                Me.Controls.Add(panel)
            End If

            columnCount += 1
            If columnCount = 4 Then
                columnCount = 0
                rowCount += 1
            End If
        Next
    End Sub

End Class

Public Class PanelData
    Public Property Hour As String
    Public Property Minutes As String
    Public Property Second As String
    Public Property Dates As String
End Class