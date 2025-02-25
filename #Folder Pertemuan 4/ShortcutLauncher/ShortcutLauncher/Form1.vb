Public Class Form1
    Private Sub AddNewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddNewToolStripMenuItem.Click
        AddNew.ShowDialog
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AddNew.RefreshSemua()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        AddNew.RefreshSemua()
        Me.Refresh()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Created 25 February 2025")
    End Sub
End Class
