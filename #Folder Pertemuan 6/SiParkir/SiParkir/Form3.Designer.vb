<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        lblNamaPel = New Label()
        lblNoPlat = New Label()
        tbNamaPel = New TextBox()
        tbNoPlat = New TextBox()
        btnTambah = New Button()
        btnTutup = New Button()
        tbTarif = New TextBox()
        lblTarif = New Label()
        lblBerlaku = New Label()
        DateTimePicker1 = New DateTimePicker()
        lblLangganan = New Label()
        DataGridView1 = New DataGridView()
        lblId = New Label()
        lblJenis = New Label()
        cmbJenis = New ComboBox()
        btnEdit = New Button()
        btnHapus = New Button()
        btnCancel = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblNamaPel
        ' 
        lblNamaPel.AutoSize = True
        lblNamaPel.Font = New Font("Segoe UI", 12F)
        lblNamaPel.Location = New Point(24, 22)
        lblNamaPel.Name = "lblNamaPel"
        lblNamaPel.Size = New Size(160, 28)
        lblNamaPel.TabIndex = 0
        lblNamaPel.Text = "Nama Pelanggan"
        ' 
        ' lblNoPlat
        ' 
        lblNoPlat.AutoSize = True
        lblNoPlat.Font = New Font("Segoe UI", 12F)
        lblNoPlat.Location = New Point(24, 72)
        lblNoPlat.Name = "lblNoPlat"
        lblNoPlat.Size = New Size(113, 28)
        lblNoPlat.TabIndex = 1
        lblNoPlat.Text = "Nomor Plat"
        ' 
        ' tbNamaPel
        ' 
        tbNamaPel.Location = New Point(195, 22)
        tbNamaPel.Name = "tbNamaPel"
        tbNamaPel.Size = New Size(247, 27)
        tbNamaPel.TabIndex = 2
        ' 
        ' tbNoPlat
        ' 
        tbNoPlat.Location = New Point(195, 76)
        tbNoPlat.Name = "tbNoPlat"
        tbNoPlat.Size = New Size(247, 27)
        tbNoPlat.TabIndex = 3
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.SkyBlue
        btnTambah.Location = New Point(466, 172)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(77, 29)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnTutup
        ' 
        btnTutup.BackColor = Color.SkyBlue
        btnTutup.Location = New Point(698, 433)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(94, 29)
        btnTutup.TabIndex = 5
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = False
        ' 
        ' tbTarif
        ' 
        tbTarif.Location = New Point(195, 122)
        tbTarif.Name = "tbTarif"
        tbTarif.Size = New Size(247, 27)
        tbTarif.TabIndex = 7
        ' 
        ' lblTarif
        ' 
        lblTarif.AutoSize = True
        lblTarif.Font = New Font("Segoe UI", 12F)
        lblTarif.Location = New Point(24, 122)
        lblTarif.Name = "lblTarif"
        lblTarif.Size = New Size(145, 28)
        lblTarif.TabIndex = 6
        lblTarif.Text = "Tarif langganan"
        ' 
        ' lblBerlaku
        ' 
        lblBerlaku.AutoSize = True
        lblBerlaku.Font = New Font("Segoe UI", 12F)
        lblBerlaku.Location = New Point(24, 174)
        lblBerlaku.Name = "lblBerlaku"
        lblBerlaku.Size = New Size(142, 28)
        lblBerlaku.TabIndex = 8
        lblBerlaku.Text = "Berlaku hingga"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(195, 174)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(247, 27)
        DateTimePicker1.TabIndex = 9
        ' 
        ' lblLangganan
        ' 
        lblLangganan.AutoSize = True
        lblLangganan.Font = New Font("Segoe UI", 12F)
        lblLangganan.Location = New Point(24, 238)
        lblLangganan.Name = "lblLangganan"
        lblLangganan.Size = New Size(292, 28)
        lblLangganan.TabIndex = 10
        lblLangganan.Text = "Kendaraan terdaftar langganan :"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(24, 269)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(763, 158)
        DataGridView1.TabIndex = 11
        ' 
        ' lblId
        ' 
        lblId.AutoSize = True
        lblId.Font = New Font("Segoe UI", 12F)
        lblId.Location = New Point(469, 18)
        lblId.Name = "lblId"
        lblId.Size = New Size(136, 28)
        lblId.TabIndex = 12
        lblId.Text = "ID Pelanggan :"
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.Font = New Font("Segoe UI", 12F)
        lblJenis.Location = New Point(469, 72)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(53, 28)
        lblJenis.TabIndex = 13
        lblJenis.Text = "Jenis"
        ' 
        ' cmbJenis
        ' 
        cmbJenis.FormattingEnabled = True
        cmbJenis.Location = New Point(549, 72)
        cmbJenis.Name = "cmbJenis"
        cmbJenis.Size = New Size(116, 28)
        cmbJenis.TabIndex = 14
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.SkyBlue
        btnEdit.Location = New Point(549, 172)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(77, 29)
        btnEdit.TabIndex = 15
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.SkyBlue
        btnHapus.Location = New Point(632, 172)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(77, 29)
        btnHapus.TabIndex = 16
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.SkyBlue
        btnCancel.Location = New Point(715, 172)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(77, 29)
        btnCancel.TabIndex = 17
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCoral
        ClientSize = New Size(799, 472)
        Controls.Add(btnCancel)
        Controls.Add(btnHapus)
        Controls.Add(btnEdit)
        Controls.Add(cmbJenis)
        Controls.Add(lblJenis)
        Controls.Add(lblId)
        Controls.Add(DataGridView1)
        Controls.Add(lblLangganan)
        Controls.Add(DateTimePicker1)
        Controls.Add(lblBerlaku)
        Controls.Add(tbTarif)
        Controls.Add(lblTarif)
        Controls.Add(btnTutup)
        Controls.Add(btnTambah)
        Controls.Add(tbNoPlat)
        Controls.Add(tbNamaPel)
        Controls.Add(lblNoPlat)
        Controls.Add(lblNamaPel)
        Name = "Form3"
        Text = "SIParkir - Langganan"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNamaPel As Label
    Friend WithEvents lblNoPlat As Label
    Friend WithEvents tbNamaPel As TextBox
    Friend WithEvents tbNoPlat As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnTutup As Button
    Friend WithEvents tbTarif As TextBox
    Friend WithEvents lblTarif As Label
    Friend WithEvents lblBerlaku As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblLangganan As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblId As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents cmbJenis As ComboBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnCancel As Button

End Class
