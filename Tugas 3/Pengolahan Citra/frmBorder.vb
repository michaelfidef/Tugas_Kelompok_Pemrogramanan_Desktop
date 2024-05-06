Public Class frmBorder


    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim pen As New Pen(GetColorFromName(cbWarna.SelectedItem.ToString()), Convert.ToInt32(cbKetebalan.SelectedItem.ToString().Replace("px", "")))
        Dim g As Graphics = frmUtama.PictureBox1.CreateGraphics()

        g.DrawRectangle(pen, 0, 0, frmUtama.PictureBox1.Width - 1, frmUtama.PictureBox1.Height - 1)
        g.Dispose()
        Me.Close()
    End Sub

    Private Function GetColorFromName(ByVal warna As String) As Color
        If warna = "Black" Then
            Return Color.Black
        ElseIf warna = "Red" Then
            Return Color.Red
        ElseIf warna = "Green" Then
            Return Color.Green
        ElseIf warna = "Blue" Then
            Return Color.LightSkyBlue
        Else
            Return Color.Black
        End If
    End Function

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class