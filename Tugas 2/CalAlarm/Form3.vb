Imports System.Media

Public Class Form3
    Private _panelData As PanelData
    Private soundPlayer As SoundPlayer

    Public Sub New(ByVal panelData As PanelData)
        InitializeComponent()
        _panelData = panelData
    End Sub

    Private Sub btnMatikan_Click(sender As Object, e As EventArgs) Handles btnMatikan.Click
        soundPlayer.Stop()
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSetWaktuAlarm.Text = _panelData.Dates
        lblWaktuSekarang.Text = $"{_panelData.Hour}:{_panelData.Minutes}:{_panelData.Second}"

        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim formWidth As Integer = Me.Width
        Dim formHeight As Integer = Me.Height
        Dim offsetX As Integer = 5
        Dim offsetY As Integer = 45

        Me.Location = New Point(screenWidth - formWidth - offsetX, screenHeight - formHeight - offsetY)

        soundPlayer = New SoundPlayer("../alarm.wav")

        soundPlayer.PlayLooping()
    End Sub
End Class
