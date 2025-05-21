Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Public Class Form1
    'map (peta papan permainan)
    Dim map = {
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
    {0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0},
    {0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0},
    {0, 1, 0, 0, 0, 1, 0, 1, 1, 0, 0},
    {0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0},
    {0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0},
    {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
    {0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0},
    {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
    {0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
    {0, 1, 0, 1, 1, 1, 1, 1, 0, 1, 0},
    {0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0},
    {0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
}



    'kumpulan variabel
    Dim tsz = 40
    Dim pacx = 1
    Dim pacy = 1
    Dim enmx = 5
    Dim enmy = 7
    Dim enmx2 = 5
    Dim enmy2 = 7
    Dim enmx3 = 5
    Dim enmy3 = 7
    Dim goalx = 9
    Dim goaly = 13
    Dim bmp As Bitmap
    Dim oldpacx = 0
    Dim oldpacy = 0
    Dim nyawa As Integer = 3

    'deklarasi sprite citra yang digunakan
    Dim wall As Image = Image.FromFile("..\aset_game_pakman\bata.png")
    Dim way As Image = Image.FromFile("..\aset_game_pakman\rumput.png")
    Dim pac_kanan As Image = Image.FromFile("..\aset_game_pakman\pakman.png")
    Dim pac_kiri As Image = Image.FromFile("..\aset_game_pakman\pakman3.png")
    Dim pac_atas As Image = Image.FromFile("..\aset_game_pakman\pakman4.png")
    Dim pac_bawah As Image = Image.FromFile("..\aset_game_pakman\pakman2.png")
    Dim pac As Image = pac_kanan
    Dim enm As Image = Image.FromFile("..\aset_game_pakman\hantu3.png")
    Dim enm2 As Image = Image.FromFile("..\aset_game_pakman\hantu2.png")
    Dim enm3 As Image = Image.FromFile("..\aset_game_pakman\hantu1.png")
    Dim goal As Image = Image.FromFile("..\aset_game_pakman\omah.jpg")
    Dim heart As Image = Image.FromFile("..\aset_game_pakman\heart.png")

    Private Sub Redraw()
        Dim g As Graphics = Graphics.FromImage(PictureBox1.Image)
        Dim rows = map.GetUpperBound(0) + 1
        Dim cols = map.GetUpperBound(1) + 1

        ' Bersihkan gambar lama
        g.Clear(Color.Black)

        ' Gambarkan background (jalan dan tembok) sesuai ukuran map
        For y = 0 To rows - 1
            For x = 0 To cols - 1
                If map(y, x) = 0 Then
                    g.DrawImage(wall, x * tsz, y * tsz, tsz, tsz)
                Else
                    g.DrawImage(way, x * tsz, y * tsz, tsz, tsz)
                End If
            Next
        Next

        ' Gambar pacman
        g.DrawImage(pac, pacx * tsz, pacy * tsz, tsz, tsz)

        ' Gambar musuh
        g.DrawImage(enm, enmx * tsz, enmy * tsz, tsz, tsz)
        g.DrawImage(enm2, enmx2 * tsz, enmy2 * tsz, tsz, tsz)
        g.DrawImage(enm3, enmx3 * tsz, enmy3 * tsz, tsz, tsz)

        ' Gambar goal
        g.DrawImage(goal, goalx * tsz, goaly * tsz, tsz, tsz)

        ' Gambar nyawa di pojok kiri atas
        For i As Integer = 0 To nyawa - 1
            g.DrawImage(heart, i * tsz, 0, tsz, tsz)
        Next

        PictureBox1.Refresh()
    End Sub


    Private Sub ResetPositions()
        pacx = 1
        pacy = 1
        oldpacx = pacx
        oldpacy = pacy
    End Sub


    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                If map(pacy - 1, pacx) = 1 Then
                    pacy = pacy - 1
                    pac = pac_atas
                End If
            Case Keys.Down
                If map(pacy + 1, pacx) = 1 Then
                    pacy = pacy + 1
                    pac = pac_bawah
                End If
            Case Keys.Right
                If map(pacy, pacx + 1) = 1 Then
                    pacx = pacx + 1
                    pac = pac_kanan
                End If
            Case Keys.Left
                If map(pacy, pacx - 1) = 1 Then
                    pacx = pacx - 1
                    pac = pac_kiri
                End If
        End Select
        Redraw()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'sesuaikan dulu ukuran picturebox dan form
        PictureBox1.Width = (map.length / (map.GetUpperBound(0) + 1)) * tsz
        PictureBox1.Height = (map.GetUpperBound(0) + 1) * tsz
        Me.Width = PictureBox1.Width + tsz
        Me.Height = PictureBox1.Height + tsz
        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Image = bmp
        Redraw()
    End Sub

    Private Sub EnemyMove(px As Integer, py As Integer, ByRef ex As Integer, ByRef ey As Integer, Optional seed As Integer = 0)
        Dim rnd As New Random(Environment.TickCount + seed)
        Dim dx = Math.Abs(px - ex)
        Dim dy = Math.Abs(py - ey)
        Dim arah As Integer

        If dx > dy Then
            arah = If(px > ex, 1, 3)
        ElseIf dy > dx Then
            arah = If(py > ey, 2, 0)
        Else
            arah = rnd.Next(0, 4)
        End If

        Select Case arah
            Case 0
                If map(ey - 1, ex) = 1 Then ey -= 1
            Case 1
                If map(ey, ex + 1) = 1 Then ex += 1
            Case 2
                If map(ey + 1, ex) = 1 Then ey += 1
            Case 3
                If map(ey, ex - 1) = 1 Then ex -= 1
        End Select
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        EnemyMove(pacx, pacy, enmx, enmy, 1)
        EnemyMove(pacx, pacy, enmx2, enmy2, 2)
        EnemyMove(pacx, pacy, enmx3, enmy3, 3)

        ' Cek tabrakan
        If (pacx = enmx And pacy = enmy) Or (pacx = enmx2 And pacy = enmy2) Or (pacx = enmx3 And pacy = enmy3) Then
            Timer1.Stop()
            nyawa -= 1
            If nyawa <= 0 Then
                Timer1.Enabled = False
                MsgBox("Game Over! Pacman Dies!")
            Else
                MsgBox("Caught! Lives left: " & nyawa)
                ResetPositions()
                Timer1.Start()
            End If
            Return
        End If

        If (pacx = goalx) And (pacy = goaly) Then
            Timer1.Enabled = False
            MsgBox("Pacman safe at Home!")
            Return
        End If
        Redraw()
    End Sub
End Class
