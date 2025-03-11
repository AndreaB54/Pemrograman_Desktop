<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dataParkir = New DataGridView()
        lblPeriode = New Label()
        cbBulan = New ComboBox()
        tbTahun = New TextBox()
        btnTampilkan = New Button()
        lblLaporan = New Label()
        btnTutup = New Button()
        CType(dataParkir, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dataParkir
        ' 
        dataParkir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataParkir.Location = New Point(22, 132)
        dataParkir.Name = "dataParkir"
        dataParkir.RowHeadersWidth = 51
        dataParkir.Size = New Size(689, 287)
        dataParkir.TabIndex = 11
        ' 
        ' lblPeriode
        ' 
        lblPeriode.AutoSize = True
        lblPeriode.Font = New Font("Segoe UI", 12F)
        lblPeriode.Location = New Point(22, 21)
        lblPeriode.Name = "lblPeriode"
        lblPeriode.Size = New Size(78, 28)
        lblPeriode.TabIndex = 13
        lblPeriode.Text = "Periode"
        ' 
        ' cbBulan
        ' 
        cbBulan.FormattingEnabled = True
        cbBulan.Location = New Point(169, 21)
        cbBulan.Name = "cbBulan"
        cbBulan.Size = New Size(116, 28)
        cbBulan.TabIndex = 14
        cbBulan.Text = "Bulan"
        ' 
        ' tbTahun
        ' 
        tbTahun.Location = New Point(298, 21)
        tbTahun.Name = "tbTahun"
        tbTahun.Size = New Size(121, 27)
        tbTahun.TabIndex = 26
        tbTahun.Text = "Tahun"
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.BackColor = Color.SkyBlue
        btnTampilkan.Location = New Point(452, 19)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(102, 29)
        btnTampilkan.TabIndex = 27
        btnTampilkan.Text = "Tampilkan!"
        btnTampilkan.UseVisualStyleBackColor = False
        ' 
        ' lblLaporan
        ' 
        lblLaporan.AutoSize = True
        lblLaporan.Font = New Font("Segoe UI", 12F)
        lblLaporan.Location = New Point(22, 90)
        lblLaporan.Name = "lblLaporan"
        lblLaporan.Size = New Size(92, 28)
        lblLaporan.TabIndex = 28
        lblLaporan.Text = "Laporan :"
        ' 
        ' btnTutup
        ' 
        btnTutup.BackColor = Color.SkyBlue
        btnTutup.Location = New Point(609, 428)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(102, 29)
        btnTutup.TabIndex = 29
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = False
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCoral
        ClientSize = New Size(729, 472)
        Controls.Add(btnTutup)
        Controls.Add(lblLaporan)
        Controls.Add(btnTampilkan)
        Controls.Add(tbTahun)
        Controls.Add(cbBulan)
        Controls.Add(lblPeriode)
        Controls.Add(dataParkir)
        Name = "Form5"
        Text = "SIParkir - Laporan Pendapatan Parkir"
        CType(dataParkir, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dataParkir As DataGridView
    Friend WithEvents lblPeriode As Label
    Friend WithEvents cbBulan As ComboBox
    Friend WithEvents tbTahun As TextBox
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents lblLaporan As Label
    Friend WithEvents btnTutup As Button

End Class
