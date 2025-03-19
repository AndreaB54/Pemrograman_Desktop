Imports MySql.Data.MySqlClient
Public Class Form2
    Dim frmUtama As New Form4
    Dim frmLogin As New Form1
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If tbNewPassword.Text = tbConfirmPass.Text Then
            Dim sql As String = "update users set password='" & tbNewPassword.Text & "' where username='" & pengguna & "'"
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql
            End If
            If myCommand.ExecuteNonQuery = 1 Then
                MsgBox("Password berhasil diganti, silahkan login ulang!")
                frmLogin.tbPassword.Clear()
                frmLogin.tbUsername.Clear()
                Me.Close()
                frmUtama.Close()
                frmLogin.tbUsername.Focus()
                frmLogin.ShowDialog()
            End If
        ElseIf tbConfirmPass.Text <> "" Then
            MsgBox("Password tidak sama!")
        End If
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbUsername.Text = pengguna
        tbNewPassword.Text = password
    End Sub

    Private Sub Form2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Return Then
            btnSimpan.PerformClick()
        End If
    End Sub
End Class