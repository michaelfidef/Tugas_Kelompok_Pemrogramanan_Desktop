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

        Chart1.Series.Clear()

        Dim redSeries As New DataVisualization.Charting.Series("Red")
        Dim greenSeries As New DataVisualization.Charting.Series("Green")
        Dim blueSeries As New DataVisualization.Charting.Series("Blue")

        redSeries.Color = Color.Red
        greenSeries.Color = Color.Green
        blueSeries.Color = Color.Blue

        Chart1.ChartAreas(0).AxisY.Maximum = 10000
        Chart1.ChartAreas(0).AxisX.Maximum = 100

        redSeries("PixelPointWidth") = 20
        greenSeries("PixelPointWidth") = 20
        blueSeries("PixelPointWidth") = 20

        Dim xOffset As Integer = (27 + 10) * 2

        For i As Integer = 0 To 255
            hR = frekR(i)
            hG = frekG(i)
            hB = frekB(i)
            redSeries.Points.AddXY(i + xOffset, hR)
            greenSeries.Points.AddXY(i + xOffset, hG)
            blueSeries.Points.AddXY(i + xOffset, hB)
        Next

        Chart1.Series.Add(redSeries)
        Chart1.Series.Add(greenSeries)
        Chart1.Series.Add(blueSeries)

        For i As Integer = 0 To 40
            Chart1.Series(0).Points(i).CustomProperties = "BarLabelStyle=Center"
            Chart1.Series(1).Points(i).CustomProperties = "BarLabelStyle=Center"
            Chart1.Series(2).Points(i).CustomProperties = "BarLabelStyle=Center"
        Next
    End Sub
End Class