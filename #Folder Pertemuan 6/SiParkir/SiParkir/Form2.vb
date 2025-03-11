Public Class Form2
    Dim form4 As New Form4
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        form4.Show()
        Me.Close()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        form4.Show()
        Me.Close()
    End Sub
End Class