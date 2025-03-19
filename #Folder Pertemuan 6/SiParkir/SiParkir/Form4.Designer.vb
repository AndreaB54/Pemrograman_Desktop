<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        components = New ComponentModel.Container()
        lblNoPlat = New Label()
        tbNoPlat = New TextBox()
        lblMasuk = New Button()
        lblParkir = New Label()
        dataParkir = New DataGridView()
        lblJenis = New Label()
        lblKeluar = New Button()
        MenuStrip1 = New MenuStrip()
        SistemToolStripMenuItem = New ToolStripMenuItem()
        AturProfilToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        AdminToolStripMenuItem = New ToolStripMenuItem()
        LanggananToolStripMenuItem = New ToolStripMenuItem()
        LaporanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem1 = New ToolStripMenuItem()
        TentangToolStripMenuItem = New ToolStripMenuItem()
        tbPlat = New TextBox()
        Panel1 = New Panel()
        lblInformasi = New Label()
        lblTanggal = New Label()
        lblJam = New Label()
        lblJmlKendaraan = New Label()
        lblBiaya = New Label()
        tbBiaya = New TextBox()
        lblInfoJenis = New Label()
        lblTekan = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        DeleteToolStripMenuItem = New ToolStripMenuItem()
        CType(dataParkir, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        ContextMenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblNoPlat
        ' 
        lblNoPlat.AutoSize = True
        lblNoPlat.Font = New Font("Segoe UI", 12F)
        lblNoPlat.Location = New Point(22, 181)
        lblNoPlat.Name = "lblNoPlat"
        lblNoPlat.Size = New Size(113, 28)
        lblNoPlat.TabIndex = 1
        lblNoPlat.Text = "Nomor Plat"
        ' 
        ' tbNoPlat
        ' 
        tbNoPlat.Location = New Point(193, 185)
        tbNoPlat.Name = "tbNoPlat"
        tbNoPlat.Size = New Size(197, 27)
        tbNoPlat.TabIndex = 3
        ' 
        ' lblMasuk
        ' 
        lblMasuk.BackColor = Color.SkyBlue
        lblMasuk.Location = New Point(193, 271)
        lblMasuk.Name = "lblMasuk"
        lblMasuk.Size = New Size(77, 29)
        lblMasuk.TabIndex = 4
        lblMasuk.Text = "Masuk"
        lblMasuk.UseVisualStyleBackColor = False
        ' 
        ' lblParkir
        ' 
        lblParkir.AutoSize = True
        lblParkir.Font = New Font("Segoe UI", 12F)
        lblParkir.Location = New Point(485, 181)
        lblParkir.Name = "lblParkir"
        lblParkir.Size = New Size(233, 28)
        lblParkir.TabIndex = 10
        lblParkir.Text = "Kendaraan sedang parkir:"
        ' 
        ' dataParkir
        ' 
        dataParkir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataParkir.Location = New Point(485, 212)
        dataParkir.Name = "dataParkir"
        dataParkir.RowHeadersWidth = 51
        dataParkir.Size = New Size(413, 213)
        dataParkir.TabIndex = 11
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.Font = New Font("Segoe UI", 10F)
        lblJenis.Location = New Point(22, 221)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(457, 23)
        lblJenis.TabIndex = 13
        lblJenis.Text = "F1 - Motor, F2 - Mobil, F3 - Taksi, F4 - Sepeda, F5 - Bis/Truk"
        ' 
        ' lblKeluar
        ' 
        lblKeluar.BackColor = Color.SkyBlue
        lblKeluar.Location = New Point(363, 271)
        lblKeluar.Name = "lblKeluar"
        lblKeluar.Size = New Size(77, 29)
        lblKeluar.TabIndex = 15
        lblKeluar.Text = "Keluar"
        lblKeluar.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {SistemToolStripMenuItem, AdminToolStripMenuItem, BantuanToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(910, 28)
        MenuStrip1.TabIndex = 17
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SistemToolStripMenuItem
        ' 
        SistemToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AturProfilToolStripMenuItem, LogoutToolStripMenuItem})
        SistemToolStripMenuItem.Name = "SistemToolStripMenuItem"
        SistemToolStripMenuItem.Size = New Size(67, 24)
        SistemToolStripMenuItem.Text = "Sistem"
        ' 
        ' AturProfilToolStripMenuItem
        ' 
        AturProfilToolStripMenuItem.Name = "AturProfilToolStripMenuItem"
        AturProfilToolStripMenuItem.Size = New Size(159, 26)
        AturProfilToolStripMenuItem.Text = "Atur Profil"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(159, 26)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' AdminToolStripMenuItem
        ' 
        AdminToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LanggananToolStripMenuItem, LaporanToolStripMenuItem})
        AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        AdminToolStripMenuItem.Size = New Size(67, 24)
        AdminToolStripMenuItem.Text = "Admin"
        ' 
        ' LanggananToolStripMenuItem
        ' 
        LanggananToolStripMenuItem.Name = "LanggananToolStripMenuItem"
        LanggananToolStripMenuItem.Size = New Size(165, 26)
        LanggananToolStripMenuItem.Text = "Langganan"
        ' 
        ' LaporanToolStripMenuItem
        ' 
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Size = New Size(165, 26)
        LaporanToolStripMenuItem.Text = "Laporan"
        ' 
        ' BantuanToolStripMenuItem
        ' 
        BantuanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BantuanToolStripMenuItem1, TentangToolStripMenuItem})
        BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        BantuanToolStripMenuItem.Size = New Size(77, 24)
        BantuanToolStripMenuItem.Text = "Bantuan"
        ' 
        ' BantuanToolStripMenuItem1
        ' 
        BantuanToolStripMenuItem1.Name = "BantuanToolStripMenuItem1"
        BantuanToolStripMenuItem1.Size = New Size(146, 26)
        BantuanToolStripMenuItem1.Text = "Bantuan"
        ' 
        ' TentangToolStripMenuItem
        ' 
        TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        TentangToolStripMenuItem.Size = New Size(146, 26)
        TentangToolStripMenuItem.Text = "Tentang"
        ' 
        ' tbPlat
        ' 
        tbPlat.Font = New Font("Segoe UI", 45F)
        tbPlat.Location = New Point(22, 52)
        tbPlat.Name = "tbPlat"
        tbPlat.Size = New Size(876, 107)
        tbPlat.TabIndex = 18
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkGray
        Panel1.Location = New Point(22, 362)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(443, 4)
        Panel1.TabIndex = 19
        ' 
        ' lblInformasi
        ' 
        lblInformasi.AutoSize = True
        lblInformasi.Font = New Font("Segoe UI", 12F)
        lblInformasi.Location = New Point(22, 368)
        lblInformasi.Name = "lblInformasi"
        lblInformasi.Size = New Size(93, 28)
        lblInformasi.TabIndex = 20
        lblInformasi.Text = "Informasi"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Font = New Font("Segoe UI", 12F)
        lblTanggal.Location = New Point(22, 394)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(193, 28)
        lblTanggal.TabIndex = 21
        lblTanggal.Text = "Tanggal: 11-03-2024"
        ' 
        ' lblJam
        ' 
        lblJam.AutoSize = True
        lblJam.Font = New Font("Segoe UI", 12F)
        lblJam.Location = New Point(272, 394)
        lblJam.Name = "lblJam"
        lblJam.Size = New Size(129, 28)
        lblJam.TabIndex = 22
        lblJam.Text = "Jam: 00:00:00"
        ' 
        ' lblJmlKendaraan
        ' 
        lblJmlKendaraan.AutoSize = True
        lblJmlKendaraan.Font = New Font("Segoe UI", 12F)
        lblJmlKendaraan.Location = New Point(22, 426)
        lblJmlKendaraan.Name = "lblJmlKendaraan"
        lblJmlKendaraan.Size = New Size(410, 28)
        lblJmlKendaraan.TabIndex = 23
        lblJmlKendaraan.Text = "0 Motor, 0 Mobil, 0 Taksi, 0 Sepeda, 0 Bis/Truk"
        ' 
        ' lblBiaya
        ' 
        lblBiaya.AutoSize = True
        lblBiaya.Font = New Font("Segoe UI", 12F)
        lblBiaya.Location = New Point(22, 306)
        lblBiaya.Name = "lblBiaya"
        lblBiaya.Size = New Size(112, 28)
        lblBiaya.TabIndex = 24
        lblBiaya.Text = "Biaya Parkir"
        ' 
        ' tbBiaya
        ' 
        tbBiaya.Font = New Font("Segoe UI", 18F)
        tbBiaya.Location = New Point(193, 307)
        tbBiaya.Name = "tbBiaya"
        tbBiaya.Size = New Size(247, 47)
        tbBiaya.TabIndex = 25
        ' 
        ' lblInfoJenis
        ' 
        lblInfoJenis.AutoSize = True
        lblInfoJenis.Font = New Font("Segoe UI", 12F)
        lblInfoJenis.Location = New Point(396, 185)
        lblInfoJenis.Name = "lblInfoJenis"
        lblInfoJenis.Size = New Size(0, 28)
        lblInfoJenis.TabIndex = 26
        ' 
        ' lblTekan
        ' 
        lblTekan.AutoSize = True
        lblTekan.Font = New Font("Segoe UI", 10F)
        lblTekan.Location = New Point(22, 244)
        lblTekan.Name = "lblTekan"
        lblTekan.Size = New Size(266, 23)
        lblTekan.TabIndex = 27
        lblTekan.Text = "Tekan Enter untuk Masuk / Keluar"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {DeleteToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(123, 28)
        ' 
        ' DeleteToolStripMenuItem
        ' 
        DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        DeleteToolStripMenuItem.Size = New Size(122, 24)
        DeleteToolStripMenuItem.Text = "Delete"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCoral
        ClientSize = New Size(910, 472)
        Controls.Add(lblTekan)
        Controls.Add(lblInfoJenis)
        Controls.Add(tbBiaya)
        Controls.Add(lblBiaya)
        Controls.Add(lblJmlKendaraan)
        Controls.Add(lblJam)
        Controls.Add(lblTanggal)
        Controls.Add(lblInformasi)
        Controls.Add(Panel1)
        Controls.Add(tbPlat)
        Controls.Add(lblKeluar)
        Controls.Add(lblJenis)
        Controls.Add(dataParkir)
        Controls.Add(lblParkir)
        Controls.Add(lblMasuk)
        Controls.Add(tbNoPlat)
        Controls.Add(lblNoPlat)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form4"
        Text = "SIParkir - Form Utama"
        CType(dataParkir, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ContextMenuStrip1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblNoPlat As Label
    Friend WithEvents tbNoPlat As TextBox
    Friend WithEvents lblMasuk As Button
    Friend WithEvents lblParkir As Label
    Friend WithEvents dataParkir As DataGridView
    Friend WithEvents lblJenis As Label
    Friend WithEvents lblKeluar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tbPlat As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblInformasi As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblJam As Label
    Friend WithEvents lblJmlKendaraan As Label
    Friend WithEvents lblBiaya As Label
    Friend WithEvents tbBiaya As TextBox
    Friend WithEvents AturProfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LanggananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblInfoJenis As Label
    Friend WithEvents lblTekan As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem

End Class
