Imports MySql.Data.MySqlClient

Module ModuleDB
    Public pengguna As String = "andrea"
    Public password As String = "andrea"
    Public myStrCon As MySqlConnectionStringBuilder = New MySqlConnectionStringBuilder() ' Ganti MySqlBaseConnectionStringBuilder dengan MySqlConnectionStringBuilder
    Public myConn As MySqlConnection
    Public myCommand As MySqlCommand
    Public myDataReader As MySqlDataReader
    Public myDataAdapter As MySqlDataAdapter
    Public jns As String = String.Empty
    Public tbluser As String = "users" ' Nama tabel user
    Public bts As Integer = 5

    Public Sub CreateConnection()
        myStrCon.UserID = pengguna ' Menggunakan variabel pengguna
        myStrCon.Server = "localhost"
        myStrCon.Password = password ' Menggunakan variabel password
        myStrCon.Database = "siparkir" ' Sesuaikan nama databasenya
        myConn = New MySqlConnection(myStrCon.ConnectionString) ' Gunakan myStrCon.ConnectionString
    End Sub
End Module