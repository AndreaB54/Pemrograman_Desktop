Imports MySql.Data.MySqlClient

Public Class Form4
    Private Sub AturProfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AturProfilToolStripMenuItem.Click
        Dim frmProfil As New Form2
        frmProfil.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim frmLogin As New Form1
        Me.Close()
        frmLogin.tbUsername.Clear()
        frmLogin.tbPassword.Clear()
        frmLogin.tbUsername.Focus()
        frmLogin.ShowDialog()
    End Sub

    Private Sub LanggananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LanggananToolStripMenuItem.Click
        Dim frmLangganan As New Form3
        frmLangganan.Show()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        Dim form5 As New Form5
        form5.Show()
        Me.Hide()

        Dim sql As String = "select sum(harga) from tblparkir where DATE(waktu_masuk) = CURDATE() and DATE(waktu_keluar) = CURDATE()"
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If
        Dim hasil As Object = myCommand.ExecuteScalar
        Dim total As String = ""
        If hasil.Equals(DBNull.Value) Then
            total = "0"
        Else
            total = hasil.ToString
        End If
        MsgBox("Total Pendapatan hari ini: Rp. " & total)
    End Sub

    Sub RefreshGrid()
        Dim i
        i = 0
        dataParkir.Rows.Clear()
        Dim sql As String = "select * from tblparkir where DATE(`waktu_masuk`) = CURDATE()"
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
            While myDataReader.Read()
                dataParkir.Rows.Add()
                dataParkir.Item(0, i).Value = myDataReader("no_plat")
                dataParkir.Item(1, i).Value = myDataReader("waktu_masuk")
                dataParkir.Item(2, i).Value = myDataReader("waktu_keluar")
                dataParkir.Item(3, i).Value = myDataReader("harga")
                dataParkir.Item(4, i).Value = myDataReader("jenis")
                dataParkir.Item(5, i).Value = myDataReader("id")
                i = i + 1
            End While
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub

    Sub HitungJumlah()
        Dim sql As String = "select jenis,count(*) as jml," & bts & "-count(*) as sisa from tblparkir where DATE(`waktu_masuk`) = CURDATE() and waktu_keluar is null group by(jenis)"
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If
        myDataReader = myCommand.ExecuteReader
        Dim hsl As String = "Jumlah "
        If myDataReader.HasRows Then
            While myDataReader.Read()
                hsl = hsl & myDataReader("jenis").ToString & " = " &
                myDataReader("jml").ToString & ", "
            End While
            lblJmlKendaraan.Text = hsl
        Else
            lblJmlKendaraan.Text = "0 Motor, 0 Mobil, 0 Taksi, 0 Sepeda, 0 Bis/Truk"
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub

    Private Sub Form4_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim sql As String
        Dim harga As Integer = 0
        Dim nomor As String = String.Empty
        pengguna = "anton"

        ' Determine the vehicle type based on the function key pressed
        Select Case e.KeyCode
            Case Keys.F1
                jns = "Motor"
            Case Keys.F2
                jns = "Mobil"
            Case Keys.F3
                jns = "Taksi/Umum"
            Case Keys.F4
                jns = "Sepeda"
            Case Keys.F5
                jns = "Bus/Truk"
        End Select

        lblInfoJenis.Text = jns

        ' Open the connection if it's closed
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If

        ' Check if the Enter key was pressed
        If e.KeyCode = Keys.Return Then
            sql = "SELECT * FROM tblparkir WHERE no_plat=@noPlat AND waktu_keluar IS NULL AND DATE(waktu_masuk) = CURDATE()"

            Using myCommand As New MySqlCommand(sql, myConn)
                myCommand.Parameters.AddWithValue("@noPlat", tbPlat.Text.ToUpper())

                Using hasil1 As MySqlDataReader = myCommand.ExecuteReader()
                    If hasil1.HasRows Then ' If the vehicle is already parked
                        If MessageBox.Show("Keluar dari Parkir?", "Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            hasil1.Read()
                            jns = hasil1("jenis").ToString()
                            nomor = hasil1("id").ToString()

                            ' Determine the price based on vehicle type
                            Select Case jns
                                Case "Motor"
                                    harga = 2000
                                Case "Mobil", "Taksi/Umum"
                                    harga = 3000
                                Case "Sepeda"
                                    harga = 1000
                                Case "Bus/Truk"
                                    harga = 4000
                            End Select

                            ' Close the reader before executing the update
                            hasil1.Close()

                            ' Update the parking record
                            sql = "UPDATE tblparkir SET waktu_keluar = CURRENT_TIMESTAMP(), harga = IF(CEIL((UNIX_TIMESTAMP(waktu_keluar) - UNIX_TIMESTAMP(waktu_masuk)) / 60 / 60) > 1, CEIL((UNIX_TIMESTAMP(waktu_keluar) - UNIX_TIMESTAMP(waktu_masuk)) / 60 / 60) * @harga, @harga) WHERE id = @nomor"
                            myCommand.CommandText = sql
                            myCommand.Parameters.Clear()
                            myCommand.Parameters.AddWithValue("@harga", harga)
                            myCommand.Parameters.AddWithValue("@nomor", nomor)
                            myCommand.ExecuteNonQuery()

                            ' Fetch the updated record to display the price
                            sql = "SELECT * FROM tblparkir WHERE id = @nomor"
                            myCommand.CommandText = sql
                            myCommand.Parameters.Clear()
                            myCommand.Parameters.AddWithValue("@nomor", nomor)

                            Using hasil2 As MySqlDataReader = myCommand.ExecuteReader()
                                If hasil2.Read() Then
                                    tbBiaya.Text = "Rp. " & hasil2("harga").ToString()
                                End If
                            End Using

                            MsgBox("Sukses Keluar!")
                            jns = String.Empty
                        End If
                    Else ' If the vehicle is not parked, insert a new record
                        If String.IsNullOrEmpty(jns) Then
                            MsgBox("Masukan jenis kendaraan berikut:" & vbCrLf & lblJenis.Text)
                            Exit Sub
                        End If

                        sql = "INSERT INTO tblparkir(no_plat, jenis, user) VALUES (@noPlat, @jenis, @user)"
                        myCommand.CommandText = sql
                        myCommand.Parameters.Clear()
                        myCommand.Parameters.AddWithValue("@noPlat", tbPlat.Text.ToUpper())
                        myCommand.Parameters.AddWithValue("@jenis", lblInfoJenis.Text)
                        myCommand.Parameters.AddWithValue("@user", pengguna)
                        myCommand.ExecuteNonQuery()
                    End If
                End Using
            End Using

            tbPlat.Text = tbPlat.Text.ToUpper()
        End If
        ' Refresh the grid and calculate the total
        RefreshGrid()
        HitungJumlah()

        ' Close the connection if it's still open
        If myConn.State = ConnectionState.Open Then
            myConn.Close()
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTanggal.Text = "Tangggal : " & Now.Day & " - " & Now.Month & " - " & Now.Year
    End Sub

    Private Sub TentangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TentangToolStripMenuItem.Click
        MessageBox.Show("Sistem Parkir ini dirancang untuk memudahkan pengelolaan tempat parkir." & vbCrLf &
                    "Fitur utama dari sistem ini meliputi:" & vbCrLf &
                    "- Pendaftaran kendaraan" & vbCrLf &
                    "- Pemantauan ketersediaan tempat parkir" & vbCrLf &
                    "- Penghitungan biaya parkir secara otomatis" & vbCrLf &
                    "- Laporan penggunaan tempat parkir" & vbCrLf &
                    vbCrLf &
                    "Dikembangkan oleh Admin pada tahun 2025." & vbCrLf &
                    "Untuk informasi lebih lanjut, silakan hubungi admin@gmail.com.",
                    "Tentang Sistem Parkir",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)
    End Sub

    Private Sub BantuanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BantuanToolStripMenuItem1.Click
        MessageBox.Show("Selamat datang di Sistem Parkir!" & vbCrLf &
                    "Berikut adalah beberapa tips untuk membantu Anda menggunakan sistem ini:" & vbCrLf &
                    "1. **Pendaftaran Kendaraan**: Pastikan Anda mengisi semua informasi yang diperlukan saat mendaftar kendaraan." & vbCrLf &
                    "2. **Memilih Tempat Parkir**: Gunakan fitur pencarian untuk menemukan tempat parkir yang sesuai dengan kebutuhan Anda." & vbCrLf &
                    "3. **Pembayaran**: Pastikan untuk memeriksa tarif parkir sebelum melakukan pembayaran." & vbCrLf &
                    "4. **Dukungan**: Jika Anda mengalami masalah, Anda dapat mengakses menu 'Dukungan' untuk mendapatkan bantuan lebih lanjut." & vbCrLf &
                    vbCrLf &
                    "Untuk pertanyaan lebih lanjut, silakan hubungi tim dukungan kami di [Email Dukungan].",
                    "Bantuan Sistem Parkir",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If MessageBox.Show("Delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Dim sql As String = "delete from tblparkir where id=" & dataParkir.CurrentRow.Cells(5).Value.ToString
            MsgBox(sql)
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql
            End If
            Dim hasil As Integer = myCommand.ExecuteNonQuery
            If hasil = 1 Then
                MsgBox("Delete success!")
                RefreshGrid()
                HitungJumlah()
            End If
        Else
        End If
    End Sub

    Private Sub dataParkir_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dataParkir.CellEnter
        tbPlat.Text = dataParkir.Rows(e.RowIndex).Cells(0).Value
    End Sub
End Class