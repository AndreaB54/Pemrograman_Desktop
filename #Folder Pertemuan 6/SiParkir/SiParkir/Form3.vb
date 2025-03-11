Public Class Form3
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Dim form4 As New Form4
        form4.Show()
        Me.Hide()
    End Sub
End Class