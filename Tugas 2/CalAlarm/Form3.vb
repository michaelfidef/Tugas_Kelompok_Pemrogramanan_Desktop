Imports System.Media

Public Class Form3
    Private _panelData As PanelData
    Private soundPlayer As SoundPlayer

    Public Sub New(ByVal panelData As PanelData)
        InitializeComponent()
        _panelData = panelData
    End Sub

    Private Sub btnMatikan_Click(sender As Object, e As EventArgs) Handles btnMatikan.Click
<<<<<<< HEAD
        soundPlayer.Stop()
=======
>>>>>>> 47218c8aa92fae1a18f9e4cdf1bba43548975c90
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
<<<<<<< HEAD
        lblTanggal.Text = _panelData.Dates
        lblWaktu.Text = $"{_panelData.Hour}:{_panelData.Minutes}:{_panelData.Second}"
=======
        lblSetWaktuAlarm.Text = _panelData.Dates
        lblWaktuSekarang.Text = $"{_panelData.Hour}:{_panelData.Minutes}:{_panelData.Second}"
>>>>>>> 47218c8aa92fae1a18f9e4cdf1bba43548975c90

        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim formWidth As Integer = Me.Width
        Dim formHeight As Integer = Me.Height
        Dim offsetX As Integer = 5
        Dim offsetY As Integer = 45

        Me.Location = New Point(screenWidth - formWidth - offsetX, screenHeight - formHeight - offsetY)

<<<<<<< HEAD
        soundPlayer = New SoundPlayer("..\alarm.wav")

        soundPlayer.PlayLooping()
    End Sub
End Class
=======
        ' Inisialisasi objek SoundPlayer dengan lokasi file audio
        soundPlayer = New SoundPlayer("C:\Kuliah\Pemrograman Desktop\Tugas\Tugas Kelompok 2\Tugas 2\alarm.wav") ' Ganti dengan path file audio yang sesuai

        ' Mainkan audio
        soundPlayer.PlayLooping()
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If soundPlayer IsNot Nothing Then
            soundPlayer.Stop()
        End If
    End Sub
End Class
>>>>>>> 47218c8aa92fae1a18f9e4cdf1bba43548975c90
