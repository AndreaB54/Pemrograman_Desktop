Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class frmUtama
    Dim modegambar As String
    Dim warnatepi As Color = Color.Black
    Dim warnaisian As Color = Color.White
    Dim tepi As New System.Drawing.Pen(warnatepi, 3)
    Dim isian As New System.Drawing.SolidBrush(warnaisian)
    Dim titik As Point = Nothing
    Dim dipencet As Boolean = False
    Dim bmp As Bitmap

    Private Sub frmUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnBersihkan.PerformClick()
        tepi.EndCap = LineCap.Round
        btnUndo.Enabled = False
    End Sub

    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.White)
        End Using
        PictureBox1.Image = bmp
        btnUndo.Enabled = False
    End Sub

    Private Sub RadioBebas_CheckedChanged(sender As Object, e As EventArgs) Handles RadioBebas.CheckedChanged
        modegambar = "bebas"
    End Sub

    Private Sub RadioGaris_CheckedChanged(sender As Object, e As EventArgs) Handles RadioGaris.CheckedChanged
        modegambar = "garis"
    End Sub

    Private Sub RadioKotak_CheckedChanged(sender As Object, e As EventArgs) Handles RadioKotak.CheckedChanged
        modegambar = "kotak"
    End Sub

    Private Sub RadioElips_CheckedChanged(sender As Object, e As EventArgs) Handles RadioElips.CheckedChanged
        modegambar = "elips"
    End Sub

    Private Sub RadioKotakIsi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioKotakIsi.CheckedChanged
        modegambar = "kotakisi"
    End Sub

    Private Sub RadioElipsIsi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioElipsIsi.CheckedChanged
        modegambar = "elipsisi"
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        tepi.Width = NumericUpDown1.Value
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        tepi.Color = warnatepi
        isian.Color = warnaisian
        titik = e.Location
        dipencet = True
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        Select Case modegambar
            Case "bebas"
                If dipencet Then
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawLine(tepi, titik, e.Location)
                    End Using
                    PictureBox1.Invalidate()
                    TextBox1.AppendText("o " + "warnatepi" + " " + warnatepi.R.ToString + " " + warnatepi.G.ToString + " " + warnatepi.B.ToString & vbCrLf)
                    TextBox1.AppendText("o garis " + titik.X.ToString + " " + titik.Y.ToString + " " + e.X.ToString + " " + e.Y.ToString & vbCrLf)
                    titik = e.Location
                End If
        End Select
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        btnUndo.Enabled = True

        Select Case modegambar
            Case "garis"
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawLine(tepi, titik, e.Location)
                End Using
            Case "kotak"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawRectangle(tepi, rect)
                End Using
            Case "elips"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawEllipse(tepi, rect)
                End Using
            Case "kotakisi"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.FillRectangle(isian, rect)
                End Using
            Case "elipsisi"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.FillEllipse(isian, rect)
                End Using
        End Select
        PictureBox1.Invalidate()
        dipencet = False
        If (titik.X <> e.X And titik.Y <> e.Y) Then
            TextBox1.AppendText("o " + "tebal" + " " + tepi.Width.ToString & vbCrLf)
            TextBox1.AppendText("o " + "warnatepi" + " " + warnatepi.R.ToString + " " + warnatepi.G.ToString + " " + warnatepi.B.ToString & vbCrLf)
            TextBox1.AppendText("o " + "warnaisian" + " " + warnaisian.R.ToString + " " + warnaisian.G.ToString + " " + warnaisian.B.ToString & vbCrLf)
            TextBox1.AppendText("o " + modegambar + " " + titik.X.ToString + " " + titik.Y.ToString + " " + e.X.ToString + " " + e.Y.ToString & vbCrLf)
        End If
    End Sub

    Private Sub Warna1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna1.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna1.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna1.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub Warna2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna2.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna2.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna2.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub Warna3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna3.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna3.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna3.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub Warna4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna4.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna4.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna4.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub Warna5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna5.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna5.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna5.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub Warna6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna6.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna6.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna6.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub btnGbrUlang_Click(sender As Object, e As EventArgs) Handles btnGbrUlang.Click
        btnBersihkan.PerformClick()
        Dim a As Integer = TextBox1.Lines.Count
        For i As Integer = 0 To a - 1
            Dim teksbaris As String = TextBox1.Lines(i)
            Dim pecah() As String
            pecah = teksbaris.Split(" "c)
            On Error Resume Next
            pecah(1) = pecah(1).Trim(" "c)
            Select Case pecah(1)
                Case "tebal"
                    tepi.Width = CSng(pecah(2))
                Case "warnatepi"
                    warnatepi = Color.FromArgb(CByte(pecah(2)), CByte(pecah(3)), CByte(pecah(4)))
                    tepi.Color = warnatepi
                Case "warnaisian"
                    warnaisian = Color.FromArgb(CByte(pecah(2)), CByte(pecah(3)),
                   CByte(pecah(4)))
                    isian.Color = warnaisian
                Case "garis"
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawLine(tepi, CInt(pecah(2)), CInt(pecah(3)),
                       CInt(pecah(4)), CInt(pecah(5)))
                    End Using
                Case "kotak"
                    Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)),
                   CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawRectangle(tepi, rect)
                    End Using
                Case "elips"
                    Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)),
                   CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawEllipse(tepi, rect)
                    End Using
                Case "kotakisi"
                    Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)),
                   CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.FillRectangle(isian, rect)
                    End Using
                Case "elipsisi"
                    Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)),
                   CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.FillEllipse(isian, rect)
                    End Using
            End Select
        Next
        PictureBox1.Invalidate()
        btnUndo.Enabled = True
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub BukaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaToolStripMenuItem.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                bmp = New Bitmap(openFileDialog.FileName)
                PictureBox1.Image = bmp
                PictureBox1.Invalidate()
            End If
        End Using
    End Sub

    Private Sub SimpanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanToolStripMenuItem.Click
        Using saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp"
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                PictureBox1.Image.Save(saveFileDialog.FileName)
            End If
        End Using
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        Dim lines = New List(Of String)(TextBox1.Lines)

        If lines.Count = 0 Then
            btnUndo.Enabled = False
            Return
        End If

        Dim lastCommandLines As Integer = 5
        If lines.Count < lastCommandLines Then
            lastCommandLines = lines.Count
        End If

        lines.RemoveRange(lines.Count - lastCommandLines, lastCommandLines)

        TextBox1.Lines = lines.ToArray()

        btnBersihkan.PerformClick()
        btnGbrUlang_Click(Nothing, Nothing)

        btnUndo.Enabled = TextBox1.Lines.Length > 0
    End Sub
End Class
