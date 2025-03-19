Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim frmUtama As New Form4

        Dim sql As String = "select username,password from " & tbluser & " where username='" & tbUsername.Text & "' and password='" & tbPassword.Text & "'"
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If
        myDataReader = myCommand.ExecuteReader
        If myDataReader.HasRows Then
            myDataReader.Close()
            pengguna = tbUsername.Text
            password = tbPassword.Text
            frmUtama.lblInformasi.Text = "Informasi - (User: " & pengguna & ")"
            frmUtama.lblTanggal.Text = "Tangggal : " & Now.Day & " - " & Now.Month & " - " & Now.Year
            frmUtama.RefreshGrid()
            frmUtama.HitungJumlah()
            frmUtama.Show()
            Me.Hide()
        Else
            MsgBox("Username / Password salah!")
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub

    Private Sub Login_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Return Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateConnection()
    End Sub



End Class
