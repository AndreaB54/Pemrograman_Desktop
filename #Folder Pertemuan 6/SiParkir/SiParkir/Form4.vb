Public Class Form4
    Private Sub AturProfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AturProfilToolStripMenuItem.Click
        Dim form2 As New Form2
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim form1 As New Form1
        form1.Show()
        Me.Close()
    End Sub

    Private Sub LanggananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LanggananToolStripMenuItem.Click
        Dim form3 As New Form3
        form3.Show()
        Me.Hide()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        Dim form5 As New Form5
        form5.Show()
        Me.Hide()
    End Sub
End Class