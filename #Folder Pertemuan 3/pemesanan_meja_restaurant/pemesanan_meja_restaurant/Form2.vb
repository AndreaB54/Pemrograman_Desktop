Public Class Form2
    Private Sub tablesBtn_Click(sender As Object, e As EventArgs) Handles tablesBtn.Click
        Dim formTiga As New Form3()
        formTiga.Show()
        Me.Hide()
    End Sub
    Private Sub ordersBtn_Click(sender As Object, e As EventArgs) Handles ordersBtn.Click
        Dim formEmpat As New Form4()
        formEmpat.Show()
        Me.Hide()
    End Sub

End Class