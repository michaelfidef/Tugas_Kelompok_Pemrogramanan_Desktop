Public Class frmUtama
    Private namafile As String

    Private Sub BukaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaToolStripMenuItem.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFileDialog1.FileName)
            namafile = openFileDialog1.FileName
        End If
    End Sub

    Private Sub SimpanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanToolStripMenuItem.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        Dim MyPicture As Image
        MyPicture = PictureBox1.Image
        saveFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            If saveFileDialog1.FilterIndex = 1 Then
                MyPicture.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
            End If
            If saveFileDialog1.FilterIndex = 2 Then
                MyPicture.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
            End If
        End If
    End Sub

    Private Sub PropertiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropertiToolStripMenuItem.Click
        MessageBox.Show("Nama File: " + namafile + vbCr + "Lebar: " + PictureBox1.Image.Width.ToString + vbCr + "Tinggi: " + PictureBox1.Image.Height.ToString)
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub GreyscaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyscaleToolStripMenuItem.Click
        If PictureBox1.Image IsNot Nothing Then
            Dim r, g, b, gray As Integer
            Dim bmp As New Bitmap(PictureBox1.Image)
            For bar As Integer = 0 To PictureBox1.Image.Height - 1
                For kol As Integer = 0 To PictureBox1.Image.Width - 1
                    r = bmp.GetPixel(kol, bar).R
                    g = bmp.GetPixel(kol, bar).G
                    b = bmp.GetPixel(kol, bar).B
                    gray = Math.Round(0.2126 * r + 0.7152 * g + 0.0722 * b)
                    bmp.SetPixel(kol, bar, Color.FromArgb(gray, gray, gray))
                Next
            Next
            PictureBox1.Image = bmp
        Else
            MessageBox.Show("No image opened in the PictureBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub CerahkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerahkanToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R + 10
                g = bmp.GetPixel(kol, bar).G + 10
                b = bmp.GetPixel(kol, bar).B + 10
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub GelapkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GelapkanToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R - 10
                g = bmp.GetPixel(kol, bar).G - 10
                b = bmp.GetPixel(kol, bar).B - 10
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub TambahKontrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKontrasToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                r = Math.Round(128 + (1.1 * (r - 128)))
                g = Math.Round(128 + (1.1 * (g - 128)))
                b = Math.Round(128 + (1.1 * (b - 128)))
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub KurangiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KurangiToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                r = Math.Round(128 + (0.90909 * (r - 128)))
                g = Math.Round(128 + (0.90909 * (g - 128)))
                b = Math.Round(128 + (0.90909 * (b - 128)))
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(namafile)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub TampilkanHistogramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TampilkanHistogramToolStripMenuItem.Click
        frmHistogram.ShowDialog()
    End Sub

    Private Sub TajamkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TajamkanToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        Dim kernel As Integer() = {-1, -1, -1, -1, 8, -1, -1, -1, -1}
        For bar As Integer = 1 To PictureBox1.Image.Height - 2
            For kol As Integer = 1 To PictureBox1.Image.Width - 2
                r = 0
                g = 0
                b = 0
                For i As Integer = 0 To 8
                    r = r + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 +
                   (i \ 3)).R)
                    g = g + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 +
                   (i \ 3)).G)
                    b = b + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 +
                   (i \ 3)).B)
                Next
                r = Math.Floor(r / 3)
                g = Math.Floor(g / 3)
                b = Math.Floor(b / 3)
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub KaburkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KaburkanToolStripMenuItem.Click
        Dim blurKernel As Integer() = {1, 2, 1, 2, 4, 2, 1, 2, 1}
        Dim divisor As Integer = 16
        ApplyCustomKernel(blurKernel, divisor)
    End Sub

    Private Sub ApplyCustomKernel(ByVal kernel As Integer(), ByVal divisor As Integer)
        If PictureBox1.Image IsNot Nothing Then
            Dim bmp As New Bitmap(PictureBox1.Image)
            Dim width As Integer = bmp.Width
            Dim height As Integer = bmp.Height
            Dim resultBitmap As New Bitmap(width, height)

            For y As Integer = 1 To height - 2
                For x As Integer = 1 To width - 2
                    Dim red As Integer = 0
                    Dim green As Integer = 0
                    Dim blue As Integer = 0

                    For i As Integer = 0 To 8
                        Dim pixelColor As Color = bmp.GetPixel(x - 1 + (i Mod 3), y - 1 + (i \ 3))
                        red += kernel(i) * pixelColor.R
                        green += kernel(i) * pixelColor.G
                        blue += kernel(i) * pixelColor.B
                    Next

                    red /= divisor
                    green /= divisor
                    blue /= divisor

                    red = Math.Min(Math.Max(red, 0), 255)
                    green = Math.Min(Math.Max(green, 0), 255)
                    blue = Math.Min(Math.Max(blue, 0), 255)

                    resultBitmap.SetPixel(x, y, Color.FromArgb(red, green, blue))
                Next
            Next

            PictureBox1.Image = resultBitmap
        Else
            MessageBox.Show("No image opened in the PictureBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub Putar90DerajatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Putar90DerajatToolStripMenuItem.Click
        Dim bmp = New Bitmap(PictureBox1.Image)
        bmp.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox1.Image = bmp
    End Sub

    Private Sub FlipHorisontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlipHorisontalToolStripMenuItem.Click
        Dim bmp As New Bitmap(PictureBox1.Image)
        FlipHorizontalManually(bmp)
    End Sub

    Private Sub FlipHorizontalManually(ByVal bmp As Bitmap)
        Dim width As Integer = bmp.Width
        Dim height As Integer = bmp.Height

        Dim flippedBitmap As New Bitmap(width, height)
        For y As Integer = 0 To height - 1
            For x As Integer = 0 To width - 1
                Dim originalColor As Color = bmp.GetPixel(x, y)

                Dim flippedX As Integer = width - 1 - x
                Dim flippedY As Integer = y
                flippedBitmap.SetPixel(flippedX, flippedY, originalColor)
            Next
        Next

        PictureBox1.Image = flippedBitmap
    End Sub


    Private Sub FlipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlipToolStripMenuItem.Click
        Dim bmp = New Bitmap(PictureBox1.Image)
        bmp.RotateFlip(RotateFlipType.RotateNoneFlipY)
        PictureBox1.Image = bmp
    End Sub

    Private Sub HistogramBalokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistogramBalokToolStripMenuItem.Click
        frmHistogramBalok.ShowDialog()
    End Sub

    Private Sub WatermarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WatermarkToolStripMenuItem.Click
        frmWatermark.ShowDialog()
    End Sub

    Private Sub BorderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorderToolStripMenuItem.Click
        frmBorder.ShowDialog()
    End Sub

    Private Sub InversiWarnaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InversiWarnaToolStripMenuItem.Click
        If PictureBox1.Image IsNot Nothing Then
            Dim bmp As New Bitmap(PictureBox1.Image)
            For bar As Integer = 0 To PictureBox1.Image.Height - 1
                For kol As Integer = 0 To PictureBox1.Image.Width - 1
                    Dim r As Integer = bmp.GetPixel(kol, bar).R
                    Dim g As Integer = bmp.GetPixel(kol, bar).G
                    Dim b As Integer = bmp.GetPixel(kol, bar).B
                    bmp.SetPixel(kol, bar, Color.FromArgb(255 - r, 255 - g, 255 - b))
                Next
            Next
            PictureBox1.Image = bmp
        Else
            MessageBox.Show("No image opened in the PictureBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RonaMerahToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaMerahToolStripMenuItem.Click
        If PictureBox1.Image IsNot Nothing Then
            Dim bmp As New Bitmap(PictureBox1.Image)
            For bar As Integer = 0 To PictureBox1.Image.Height - 1
                For kol As Integer = 0 To PictureBox1.Image.Width - 1
                    Dim r As Integer = bmp.GetPixel(kol, bar).R
                    Dim g As Integer = bmp.GetPixel(kol, bar).G
                    Dim b As Integer = bmp.GetPixel(kol, bar).B
                    bmp.SetPixel(kol, bar, Color.FromArgb(r, 0, 0))
                Next
            Next
            PictureBox1.Image = bmp
        Else
            MessageBox.Show("No image opened in the PictureBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RonaHijauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaHijauToolStripMenuItem.Click
        If PictureBox1.Image IsNot Nothing Then
            Dim bmp As New Bitmap(PictureBox1.Image)
            For bar As Integer = 0 To PictureBox1.Image.Height - 1
                For kol As Integer = 0 To PictureBox1.Image.Width - 1
                    Dim r As Integer = bmp.GetPixel(kol, bar).R
                    Dim g As Integer = bmp.GetPixel(kol, bar).G
                    Dim b As Integer = bmp.GetPixel(kol, bar).B
                    bmp.SetPixel(kol, bar, Color.FromArgb(0, g, 0))
                Next
            Next
            PictureBox1.Image = bmp
        Else
            MessageBox.Show("No image opened in the PictureBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RonaBiruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaBiruToolStripMenuItem.Click
        If PictureBox1.Image IsNot Nothing Then
            Dim bmp As New Bitmap(PictureBox1.Image)
            For bar As Integer = 0 To PictureBox1.Image.Height - 1
                For kol As Integer = 0 To PictureBox1.Image.Width - 1
                    Dim r As Integer = bmp.GetPixel(kol, bar).R
                    Dim g As Integer = bmp.GetPixel(kol, bar).G
                    Dim b As Integer = bmp.GetPixel(kol, bar).B
                    bmp.SetPixel(kol, bar, Color.FromArgb(0, 0, b))
                Next
            Next
            PictureBox1.Image = bmp
        Else
            MessageBox.Show("No image opened in the PictureBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RonaSpesialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaSpesialToolStripMenuItem.Click
        If PictureBox1.Image IsNot Nothing Then
            Dim bmp As New Bitmap(PictureBox1.Image)
            For bar As Integer = 0 To PictureBox1.Image.Height - 1
                For kol As Integer = 0 To PictureBox1.Image.Width - 1
                    Dim r As Integer = bmp.GetPixel(kol, bar).R
                    Dim g As Integer = bmp.GetPixel(kol, bar).G
                    Dim b As Integer = bmp.GetPixel(kol, bar).B
                    bmp.SetPixel(kol, bar, Color.FromArgb(b, r, g))
                Next
            Next
            PictureBox1.Image = bmp
        Else
            MessageBox.Show("No image opened in the PictureBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
