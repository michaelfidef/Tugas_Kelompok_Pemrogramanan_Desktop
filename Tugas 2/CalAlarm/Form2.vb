

Public Class Form2

    Public Property MyValue As String
    Public Property SelectedDate As DateTime

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        SelectedDate = Date.Today
        Form1.MySelectedDate = SelectedDate
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Now.ToString("h:mm:ss tt")
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
        CreatePanel()
        Dim combinedTime As String = txtBoxHour.Text & ":" & txtBoxMinutes.Text & ":" & txtBoxSecond.Text
        Me.Close()
    End Sub


    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        SelectedDate = MonthCalendar1.SelectionStart
        If SelectedDate = Nothing Then
            SelectedDate = Date.Today
        End If
        Form1.MySelectedDate = SelectedDate
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Public Sub CreatePanel()
        Dim panelWidth As Integer = 200
        Dim panelHeight As Integer = 100
        Dim panelSpacing As Integer = 10
        Dim panelCount As Integer = 0
        If panelCount < 5 Then
            Dim pnl As New Panel()
            With pnl
                .Width = panelWidth
                .Height = panelHeight
                .Location = New Point(panelCount * (panelWidth + panelSpacing), 60)
                .Name = "panel" & panelCount.ToString
                .Visible = True
                .BackColor = Color.Red
            End With
            AddLabelsToPanel(pnl)
            Form1.Controls.Add(pnl)
            panelCount += 1
        End If
    End Sub

    Private Sub AddLabelsToPanel(ByVal pnl As Panel)
        ' Create and configure labels as needed
        Dim lblWaktu As New Label
        With lblWaktu
            .Name = "waktu" & pnl.Name.Substring(5)
            .Text = "22:22:22"
            .Location = New Point(10, 20)
        End With
        pnl.Controls.Add(lblWaktu)

        Dim lblTanggal As New Label
        With lblTanggal
            .Text = "12/11/2024"
            .Location = New Point(20, 40)
        End With
        pnl.Controls.Add(lblTanggal)
    End Sub



End Class