Public Class frmWatermark
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim watermarkText As String = TextBox1.Text.Trim()

        If String.IsNullOrEmpty(watermarkText) Then
            MessageBox.Show("Please enter text for watermark.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If frmUtama.PictureBox1.Image IsNot Nothing Then
            Dim bmp As New Bitmap(frmUtama.PictureBox1.Image)
            Using g As Graphics = Graphics.FromImage(bmp)
                Using font As New Font("Arial", 25)
                    Using brush As New SolidBrush(Color.Black)
                        Dim textSize As SizeF = g.MeasureString(watermarkText, font)
                        Dim rows As Integer = Math.Floor(bmp.Height / (textSize.Height * 1.5))
                        Dim cols As Integer = Math.Floor(bmp.Width / (textSize.Width * 1.5))

                        For i As Integer = 0 To rows - 1
                            For j As Integer = 0 To cols - 1
                                Dim x As Single = j * (textSize.Width * 1.5)
                                Dim y As Single = i * (textSize.Height * 1.5)
                                g.DrawString(watermarkText, font, brush, x, y)
                            Next
                        Next
                    End Using
                End Using
            End Using

            frmUtama.PictureBox1.Image = bmp
            Me.Close()
        Else
            MessageBox.Show("No image opened in the PictureBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class