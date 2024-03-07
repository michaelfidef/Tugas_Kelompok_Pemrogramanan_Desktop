Imports System.Globalization

Public Class Form1

    Public Property MyValue As String
    Public Property MySelectedDate As DateTime

    Private Sub NewAlarmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewAlarmToolStripMenuItem.Click
        Dim SecondForm As New Form2
        SecondForm.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim WIBCulture As New CultureInfo("id-ID")
        lblDateTime.Text = Now.ToString("h:mm:ss", WIBCulture)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
