Public Class Form4
    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        Dim formDua As New Form2()
        formDua.Show()
        Me.Hide()
    End Sub

    Private Sub tablesBtn_Click(sender As Object, e As EventArgs) Handles tablesBtn.Click
        Dim formTiga As New Form3()
        formTiga.Show()
        Me.Hide()
    End Sub
End Class