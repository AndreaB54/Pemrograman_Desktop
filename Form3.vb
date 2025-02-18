Public Class Form3
    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        Dim formDua As New Form2()
        formDua.Show()
        Me.Hide()
    End Sub

    Private Sub ordersBtn_Click(sender As Object, e As EventArgs) Handles ordersBtn.Click
        Dim formEmpat As New Form4()
        formEmpat.Show()
        Me.Hide()
    End Sub
End Class