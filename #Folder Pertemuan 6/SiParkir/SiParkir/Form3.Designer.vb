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
        lblTambah = New Button()
        btnTutup = New Button()
        tbTarif = New TextBox()
        lblTarif = New Label()
        lblBerlaku = New Label()
        dtpBerlaku = New DateTimePicker()
        lblLangganan = New Label()
        DataGridView1 = New DataGridView()
        lblId = New Label()
        lblJenis = New Label()
        ComboBox1 = New ComboBox()
        lblEdit = New Button()
        lblHapus = New Button()
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
        ' lblTambah
        ' 
        lblTambah.BackColor = Color.SkyBlue
        lblTambah.Location = New Point(466, 172)
        lblTambah.Name = "lblTambah"
        lblTambah.Size = New Size(77, 29)
        lblTambah.TabIndex = 4
        lblTambah.Text = "Tambah"
        lblTambah.UseVisualStyleBackColor = False
        ' 
        ' btnTutup
        ' 
        btnTutup.BackColor = Color.SkyBlue
        btnTutup.Location = New Point(592, 433)
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
        ' dtpBerlaku
        ' 
        dtpBerlaku.Location = New Point(195, 174)
        dtpBerlaku.Name = "dtpBerlaku"
        dtpBerlaku.Size = New Size(247, 27)
        dtpBerlaku.TabIndex = 9
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
        DataGridView1.Size = New Size(662, 158)
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
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(549, 72)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(116, 28)
        ComboBox1.TabIndex = 14
        ' 
        ' lblEdit
        ' 
        lblEdit.BackColor = Color.SkyBlue
        lblEdit.Location = New Point(549, 172)
        lblEdit.Name = "lblEdit"
        lblEdit.Size = New Size(77, 29)
        lblEdit.TabIndex = 15
        lblEdit.Text = "Edit"
        lblEdit.UseVisualStyleBackColor = False
        ' 
        ' lblHapus
        ' 
        lblHapus.BackColor = Color.SkyBlue
        lblHapus.Location = New Point(632, 172)
        lblHapus.Name = "lblHapus"
        lblHapus.Size = New Size(77, 29)
        lblHapus.TabIndex = 16
        lblHapus.Text = "Hapus"
        lblHapus.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCoral
        ClientSize = New Size(720, 472)
        Controls.Add(lblHapus)
        Controls.Add(lblEdit)
        Controls.Add(ComboBox1)
        Controls.Add(lblJenis)
        Controls.Add(lblId)
        Controls.Add(DataGridView1)
        Controls.Add(lblLangganan)
        Controls.Add(dtpBerlaku)
        Controls.Add(lblBerlaku)
        Controls.Add(tbTarif)
        Controls.Add(lblTarif)
        Controls.Add(btnTutup)
        Controls.Add(lblTambah)
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
    Friend WithEvents lblTambah As Button
    Friend WithEvents btnTutup As Button
    Friend WithEvents tbTarif As TextBox
    Friend WithEvents lblTarif As Label
    Friend WithEvents lblBerlaku As Label
    Friend WithEvents dtpBerlaku As DateTimePicker
    Friend WithEvents lblLangganan As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblId As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblEdit As Button
    Friend WithEvents lblHapus As Button

End Class
