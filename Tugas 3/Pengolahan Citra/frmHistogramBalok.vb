Public Class frmHistogramBalok
    Private Sub frmHistogramBalok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim r, g, b, max As Integer
        Dim hR, hG, hB As Integer
        Dim bmp = New Bitmap(frmUtama.PictureBox1.Image)
        Dim frekR(256), frekG(256), frekB(256) As Integer
        For i As Integer = 0 To 255
            frekR(i) = 0
            frekG(i) = 0
            frekB(i) = 0
        Next
        For bar As Integer = 1 To frmUtama.PictureBox1.Image.Height - 2
            For kol As Integer = 1 To frmUtama.PictureBox1.Image.Width - 2
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                frekR(r) = frekR(r) + 1
                frekG(g) = frekG(g) + 1
                frekB(b) = frekB(b) + 1
            Next
        Next
        Dim maxFrequency As Integer = Math.Max(Math.Max(frekR.Max(), frekG.Max()), frekB.Max())
        Chart1.Series.Clear()
        Chart2.Series.Clear()
        Chart3.Series.Clear()
        Dim redSeries As New DataVisualization.Charting.Series("Red")
        Dim greenSeries As New DataVisualization.Charting.Series("Green")
        Dim blueSeries As New DataVisualization.Charting.Series("Blue")

        redSeries.Color = Color.Red
        greenSeries.Color = Color.Green
        blueSeries.Color = Color.Blue

        Chart1.Series.Add(redSeries)
        Chart2.Series.Add(greenSeries)
        Chart3.Series.Add(blueSeries)
        For i As Integer = 0 To 255
            hR = Math.Round(frekR(i) / maxFrequency * 100)
            hG = Math.Round(frekG(i) / maxFrequency * 100)
            hB = Math.Round(frekB(i) / maxFrequency * 100)
            redSeries.Points.AddXY(i, hR)
            greenSeries.Points.AddXY(i, hG)
            blueSeries.Points.AddXY(i, hB)
        Next
    End Sub
End Class