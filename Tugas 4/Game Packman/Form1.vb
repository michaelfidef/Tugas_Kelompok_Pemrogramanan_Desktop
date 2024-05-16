﻿Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1
    Dim map = {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
               {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
               {0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0},
               {0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
               {0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 0},
               {0, 1, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1, 1, 0, 1, 1, 0},
               {0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 0, 1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
               {0, 1, 0, 1, 0, 1, 0, 1, 1, 0, 0, 1, 0, 1, 1, 0, 1, 1, 0, 1, 0},
               {0, 1, 0, 1, 0, 1, 0, 1, 1, 0, 1, 1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
               {0, 1, 1, 1, 1, 1, 0, 1, 1, 0, 0, 1, 0, 1, 1, 1, 1, 1, 0, 1, 0},
               {0, 1, 0, 0, 0, 1, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0},
               {0, 1, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
               {0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
               {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
               {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}}
    'kumpulan variabel
    Dim tsz = 40 'tile size (ukuran grid/tilenya)
    Dim pacx = 1 'pakman itu di petak x mana sekarang
    Dim pacy = 1 ' petak y
    Dim enmx = 19 'musuh itu di petak x berapa
    Dim enmy = 13 ' petak y
    Dim enmx2 = 19 'musuh kedua di petak x berapa
    Dim enmy2 = 1 ' petak y
    Dim enmx3 = 5 'musuh ketiga di petak x berapa
    Dim enmy3 = 5
    Dim goalx = 19 'goal (pintu keluar pakman di petak x brp
    Dim goaly = 13 'goal di petak y berapa
    Dim bmp As Bitmap
    Dim oldpacx = 0
    Dim oldpacy = 0
    Dim lives As Integer = 3
    Dim chasing As Boolean = True ' Flag to determine if ghosts are chasing
    'deklarasi sprite citra yang digunakan
    Dim wall As Image = My.Resources.bata
    Dim way As Image = My.Resources.rumput
    Dim pac As Image = My.Resources.pakman
    Dim enm As Image = My.Resources.hantu3
    Dim enm2 As Image = My.Resources.hantu1
    Dim enm3 As Image = My.Resources.hantu2
    Dim goal As Image = My.Resources.omah
    Dim lifeSprite As Image = My.Resources.heart

    Private Sub Redraw()
        Dim g As Graphics = Graphics.FromImage(PictureBox1.Image)
        For y = 0 To 14
            For x = 0 To 20
                If map(y, x) = 0 Then
                    g.DrawImage(wall, x * tsz, y * tsz, tsz, tsz)
                Else
                    g.DrawImage(way, x * tsz, y * tsz, tsz, tsz)
                End If
            Next
        Next
        'gambarkan pacman
        g.DrawImage(pac, pacx * tsz, pacy * tsz, tsz, tsz)
        'gambarkan musuh
        g.DrawImage(enm, enmx * tsz, enmy * tsz, tsz, tsz)
        g.DrawImage(enm2, enmx2 * tsz, enmy2 * tsz, tsz, tsz)
        g.DrawImage(enm3, enmx3 * tsz, enmy3 * tsz, tsz, tsz)
        'gambarkan goal
        g.DrawImage(goal, goalx * tsz, goaly * tsz, tsz, tsz)
        For i = 0 To lives - 1
            g.DrawImage(lifeSprite, i * tsz, 15 * tsz, tsz, tsz)
        Next
        PictureBox1.Refresh()
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                If pacy > 0 AndAlso map(pacy - 1, pacx) = 1 Then
                    pacy -= 1
                    pac = My.Resources.pakman4
                End If
            Case Keys.Down
                If pacy < map.GetUpperBound(0) AndAlso map(pacy + 1, pacx) = 1 Then
                    pacy += 1
                    pac = My.Resources.pakman2
                End If
            Case Keys.Right
                If pacx < map.GetUpperBound(1) AndAlso map(pacy, pacx + 1) = 1 Then
                    pacx += 1
                    pac = My.Resources.pakman
                End If
            Case Keys.Left
                If pacx > 0 AndAlso map(pacy, pacx - 1) = 1 Then
                    pacx -= 1
                    pac = My.Resources.pakman3
                End If
        End Select
        CheckCulDeSac()
        cekEnemies()
        Redraw()

        If (pacx = goalx) And (pacy = goaly) Then
            Timer1.Enabled = False
            MsgBox("Pakman safe at Home!")
            ResetGame()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Width = (map.GetUpperBound(1) + 1) * tsz
        PictureBox1.Height = (map.GetUpperBound(0) + 1) * tsz
        Me.Width = PictureBox1.Width + tsz
        Me.Height = PictureBox1.Height + tsz + tsz
        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Image = bmp
        Redraw()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If chasing Then
            Dim distances As New List(Of Tuple(Of Integer, Integer, Integer))
            distances.Add(New Tuple(Of Integer, Integer, Integer)(enmx, enmy, Math.Abs(pacx - enmx) + Math.Abs(pacy - enmy)))
            distances.Add(New Tuple(Of Integer, Integer, Integer)(enmx2, enmy2, Math.Abs(pacx - enmx2) + Math.Abs(pacy - enmy2)))
            distances.Add(New Tuple(Of Integer, Integer, Integer)(enmx3, enmy3, Math.Abs(pacx - enmx3) + Math.Abs(pacy - enmy3)))
            distances = distances.OrderBy(Function(d) d.Item3).ToList()

            ' Move the two closest enemies towards Pacman
            MoveEnemyTowardsPacman(distances(0).Item1, distances(0).Item2, pacx, pacy)
            MoveEnemyTowardsPacman(distances(1).Item1, distances(1).Item2, pacx, pacy)
        Else
            ' Move all enemies randomly
            MoveEnemyRandomly(enmx, enmy)
            MoveEnemyRandomly(enmx2, enmy2)
            MoveEnemyRandomly(enmx3, enmy3)
        End If

        ' Periksa dan pindahkan hantu yang terjebak
        CheckAndMoveStuckEnemy(enmx, enmy, pacx, pacy)
        CheckAndMoveStuckEnemy(enmx2, enmy2, pacx, pacy)
        CheckAndMoveStuckEnemy(enmx3, enmy3, pacx, pacy)

        ' Check if Pakman is caught by any enemy
        cekEnemies()
        Redraw()
    End Sub

    Private Sub MoveEnemyTowardsPacman(ByRef enmx As Integer, ByRef enmy As Integer, targetX As Integer, targetY As Integer)
        Dim directions As New List(Of Integer) From {0, 1, 2, 3}
        Dim moved As Boolean = False

        While directions.Count > 0 AndAlso Not moved
            Dim direction As Integer = directions(CInt(Math.Floor(Rnd() * directions.Count)))
            directions.Remove(direction)

            Select Case direction
                Case 0 ' Up
                    If enmy > 0 AndAlso map(enmy - 1, enmx) = 1 Then
                        enmy -= 1
                        moved = True
                    End If
                Case 1 ' Right
                    If enmx < map.GetUpperBound(1) AndAlso map(enmy, enmx + 1) = 1 Then
                        enmx += 1
                        moved = True
                    End If
                Case 2 ' Down
                    If enmy < map.GetUpperBound(0) AndAlso map(enmy + 1, enmx) = 1 Then
                        enmy += 1
                        moved = True
                    End If
                Case 3 ' Left
                    If enmx > 0 AndAlso map(enmy, enmx - 1) = 1 Then
                        enmx -= 1
                        moved = True
                    End If
            End Select
        End While
    End Sub

    Private Sub MoveEnemyRandomly(ByRef enmx As Integer, ByRef enmy As Integer)
        Dim directions As New List(Of Integer) From {0, 1, 2, 3}
        Dim moved As Boolean = False

        While directions.Count > 0 AndAlso Not moved
            Dim direction As Integer = directions(CInt(Math.Floor(Rnd() * directions.Count)))
            directions.Remove(direction)

            Select Case direction
                Case 0 ' Up
                    If enmy > 0 AndAlso map(enmy - 1, enmx) = 1 Then
                        enmy -= 1
                        moved = True
                    End If
                Case 1 ' Right
                    If enmx < map.GetUpperBound(1) AndAlso map(enmy, enmx + 1) = 1 Then
                        enmx += 1
                        moved = True
                    End If
                Case 2 ' Down
                    If enmy < map.GetUpperBound(0) AndAlso map(enmy + 1, enmx) = 1 Then
                        enmy += 1
                        moved = True
                    End If
                Case 3 ' Left
                    If enmx > 0 AndAlso map(enmy, enmx - 1) = 1 Then
                        enmx -= 1
                        moved = True
                    End If
            End Select
        End While
    End Sub

    Private Sub CheckAndMoveStuckEnemy(ByRef enmx As Integer, ByRef enmy As Integer, pacx As Integer, pacy As Integer)
        Dim directions As New List(Of Integer) From {0, 1, 2, 3}
        Dim moved As Boolean = False

        ' Periksa apakah hantu terjebak
        While directions.Count > 0 AndAlso Not moved
            Dim direction As Integer = directions(CInt(Math.Floor(Rnd() * directions.Count)))
            directions.Remove(direction)

            Select Case direction
                Case 0 ' Up
                    If enmy > 0 AndAlso map(enmy - 1, enmx) = 1 Then
                        enmy -= 1
                        moved = True
                    End If
                Case 1 ' Right
                    If enmx < map.GetUpperBound(1) AndAlso map(enmy, enmx + 1) = 1 Then
                        enmx += 1
                        moved = True
                    End If
                Case 2 ' Down
                    If enmy < map.GetUpperBound(0) AndAlso map(enmy + 1, enmx) = 1 Then
                        enmy += 1
                        moved = True
                    End If
                Case 3 ' Left
                    If enmx > 0 AndAlso map(enmy, enmx - 1) = 1 Then
                        enmx -= 1
                        moved = True
                    End If
            End Select
        End While

        ' Periksa apakah Pakman berada dalam ceruk
        If IsInCulDeSac(pacx, pacy) Then
            Dim randomDirection As Integer = CInt(Math.Floor(Rnd() * 4)) ' 0 untuk atas, 1 untuk kanan, 2 untuk bawah, 3 untuk kiri

            ' Ubah posisi hantu berdasarkan arah yang ditentukan
            Select Case randomDirection
                Case 0 ' Atas
                    If enmy > 0 AndAlso map(enmy - 1, enmx) = 1 Then
                        enmy -= 1
                    End If
                Case 1 ' Kanan
                    If enmx < map.GetUpperBound(1) AndAlso map(enmy, enmx + 1) = 1 Then
                        enmx += 1
                    End If
                Case 2 ' Bawah
                    If enmy < map.GetUpperBound(0) AndAlso map(enmy + 1, enmx) = 1 Then
                        enmy += 1
                    End If
                Case 3 ' Kiri
                    If enmx > 0 AndAlso map(enmy, enmx - 1) = 1 Then
                        enmx -= 1
                    End If
            End Select
        End If
    End Sub

    Private Function IsInCulDeSac(pacx As Integer, pacy As Integer) As Boolean
        ' Inisialisasi variabel untuk menghitung jumlah tembok di sekitar Pakman
        Dim wallCount As Integer = 0

        ' Cek setiap arah di sekitar Pakman
        If map(pacy - 1, pacx) = 0 Then ' Cek atas
            wallCount += 1
        End If
        If map(pacy + 1, pacx) = 0 Then ' Cek bawah
            wallCount += 1
        End If
        If map(pacy, pacx - 1) = 0 Then ' Cek kiri
            wallCount += 1
        End If
        If map(pacy, pacx + 1) = 0 Then ' Cek kanan
            wallCount += 1
        End If

        ' Jika jumlah tembok di sekitar Pakman adalah 3, maka Pakman berada dalam ceruk
        Return wallCount = 3
    End Function


    Private Sub cekEnemies()
        If (pacx = enmx AndAlso pacy = enmy) OrElse (pacx = enmx2 AndAlso pacy = enmy2) OrElse (pacx = enmx3 AndAlso pacy = enmy3) Then
            cekNyawa()
        End If
    End Sub

    Private Sub cekNyawa()
        lives -= 1
        If lives >= 0 Then
            Dim g As Graphics = Graphics.FromImage(PictureBox1.Image)
            g.FillRectangle(Brushes.White, lives * tsz, 15 * tsz, tsz, tsz)
            PictureBox1.Refresh()
        End If
        If lives <= 0 Then
            Timer1.Enabled = False
            MsgBox("Game Over!")
            ResetGame()
        Else
            Redraw()
        End If
    End Sub

    Private Sub ResetGame()
        lives = 3
        pacx = 1
        pacy = 1
        enmx = 19
        enmy = 13
        enmx2 = 19
        enmy2 = 1
        enmx3 = 5
        enmy3 = 5
        Timer1.Enabled = True
        Redraw()
    End Sub

    Private Sub CheckCulDeSac()
        If IsCulDeSac(pacx, pacy) Then
            chasing = False
        Else
            chasing = True
        End If
    End Sub

    Private Function IsCulDeSac(x As Integer, y As Integer) As Boolean
        Dim walls As Integer = 0
        If x > 0 AndAlso map(y, x - 1) = 0 Then walls += 1
        If x < map.GetUpperBound(1) AndAlso map(y, x + 1) = 0 Then walls += 1
        If y > 0 AndAlso map(y - 1, x) = 0 Then walls += 1
        If y < map.GetUpperBound(0) AndAlso map(y + 1, x) = 0 Then walls += 1
        Return walls >= 3
    End Function
End Class