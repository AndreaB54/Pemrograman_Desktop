Public Class Form1
    Private Sub ButtonSubmit_Click_1(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        Dim formDua As New Form2()
        formDua.Show()
        Me.Hide()
    End Sub
End Class
