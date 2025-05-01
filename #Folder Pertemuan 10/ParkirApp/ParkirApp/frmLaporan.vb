Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmLaporan
    Private Sub frmLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New DataSet1
        Dim myAdapter As New MySqlDataAdapter

        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        myAdapter.SelectCommand = New MySqlCommand("SELECT * FROM tblparkir WHERE DATE(waktu_masuk) = CURDATE()", myConn) 'menampilkan laporan hari ini saja
        'myAdapter.SelectCommand = New MySqlCommand("SELECT * FROM tblparkir", myConn) 'menampilkan laporan keseluruhan
        myAdapter.Fill(ds.Tables(0))

        ReportViewer1.Reset()
        ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1_LapParkir", ds.Tables(0)))
        ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        frmUtama.Show()
        Me.Hide()
    End Sub
End Class