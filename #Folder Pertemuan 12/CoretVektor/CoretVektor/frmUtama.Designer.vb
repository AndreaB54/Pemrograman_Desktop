<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUtama
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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        BukaToolStripMenuItem = New ToolStripMenuItem()
        SimpanToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1 = New GroupBox()
        ShapeIsian = New Panel()
        NumericUpDown1 = New NumericUpDown()
        ShapeTepi = New Panel()
        RadioBebas = New RadioButton()
        RadioGaris = New RadioButton()
        lblUkuran = New Label()
        RadioKotak = New RadioButton()
        RadioElipsIsi = New RadioButton()
        RadioElips = New RadioButton()
        RadioKotakIsi = New RadioButton()
        GroupBox2 = New GroupBox()
        btnGbrUlang = New Button()
        btnBersihkan = New Button()
        btnUndo = New Button()
        Warna6 = New Panel()
        Warna5 = New Panel()
        Warna4 = New Panel()
        Warna3 = New Panel()
        Warna2 = New Panel()
        Warna1 = New Panel()
        GroupBox3 = New GroupBox()
        TextBox1 = New TextBox()
        PictureBox1 = New PictureBox()
        MenuStrip1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1036, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BukaToolStripMenuItem, SimpanToolStripMenuItem, KeluarToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' BukaToolStripMenuItem
        ' 
        BukaToolStripMenuItem.Name = "BukaToolStripMenuItem"
        BukaToolStripMenuItem.Size = New Size(224, 26)
        BukaToolStripMenuItem.Text = "Buka"
        ' 
        ' SimpanToolStripMenuItem
        ' 
        SimpanToolStripMenuItem.Name = "SimpanToolStripMenuItem"
        SimpanToolStripMenuItem.Size = New Size(224, 26)
        SimpanToolStripMenuItem.Text = "Simpan"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(224, 26)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ShapeIsian)
        GroupBox1.Controls.Add(NumericUpDown1)
        GroupBox1.Controls.Add(ShapeTepi)
        GroupBox1.Controls.Add(RadioBebas)
        GroupBox1.Controls.Add(RadioGaris)
        GroupBox1.Controls.Add(lblUkuran)
        GroupBox1.Controls.Add(RadioKotak)
        GroupBox1.Controls.Add(RadioElipsIsi)
        GroupBox1.Controls.Add(RadioElips)
        GroupBox1.Controls.Add(RadioKotakIsi)
        GroupBox1.Dock = DockStyle.Left
        GroupBox1.Location = New Point(0, 28)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(193, 554)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tools"
        ' 
        ' ShapeIsian
        ' 
        ShapeIsian.BackColor = Color.White
        ShapeIsian.BorderStyle = BorderStyle.FixedSingle
        ShapeIsian.Location = New Point(104, 475)
        ShapeIsian.Name = "ShapeIsian"
        ShapeIsian.Size = New Size(50, 50)
        ShapeIsian.TabIndex = 19
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(30, 345)
        NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(124, 27)
        NumericUpDown1.TabIndex = 17
        NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' ShapeTepi
        ' 
        ShapeTepi.BackColor = Color.Black
        ShapeTepi.BorderStyle = BorderStyle.FixedSingle
        ShapeTepi.Location = New Point(30, 475)
        ShapeTepi.Name = "ShapeTepi"
        ShapeTepi.Size = New Size(50, 50)
        ShapeTepi.TabIndex = 18
        ' 
        ' RadioBebas
        ' 
        RadioBebas.AutoSize = True
        RadioBebas.Location = New Point(30, 40)
        RadioBebas.Name = "RadioBebas"
        RadioBebas.Size = New Size(70, 24)
        RadioBebas.TabIndex = 10
        RadioBebas.TabStop = True
        RadioBebas.Text = "Bebas"
        RadioBebas.UseVisualStyleBackColor = True
        ' 
        ' RadioGaris
        ' 
        RadioGaris.AutoSize = True
        RadioGaris.Location = New Point(30, 80)
        RadioGaris.Name = "RadioGaris"
        RadioGaris.Size = New Size(63, 24)
        RadioGaris.TabIndex = 11
        RadioGaris.TabStop = True
        RadioGaris.Text = "Garis"
        RadioGaris.UseVisualStyleBackColor = True
        ' 
        ' lblUkuran
        ' 
        lblUkuran.AutoSize = True
        lblUkuran.Location = New Point(30, 322)
        lblUkuran.Name = "lblUkuran"
        lblUkuran.Size = New Size(124, 20)
        lblUkuran.TabIndex = 16
        lblUkuran.Text = "Ukuran Garis Tepi"
        ' 
        ' RadioKotak
        ' 
        RadioKotak.AutoSize = True
        RadioKotak.Location = New Point(30, 120)
        RadioKotak.Name = "RadioKotak"
        RadioKotak.Size = New Size(68, 24)
        RadioKotak.TabIndex = 12
        RadioKotak.TabStop = True
        RadioKotak.Text = "Kotak"
        RadioKotak.UseVisualStyleBackColor = True
        ' 
        ' RadioElipsIsi
        ' 
        RadioElipsIsi.AutoSize = True
        RadioElipsIsi.Location = New Point(30, 240)
        RadioElipsIsi.Name = "RadioElipsIsi"
        RadioElipsIsi.Size = New Size(79, 24)
        RadioElipsIsi.TabIndex = 15
        RadioElipsIsi.TabStop = True
        RadioElipsIsi.Text = "Elips Isi"
        RadioElipsIsi.UseVisualStyleBackColor = True
        ' 
        ' RadioElips
        ' 
        RadioElips.AutoSize = True
        RadioElips.Location = New Point(30, 160)
        RadioElips.Name = "RadioElips"
        RadioElips.Size = New Size(61, 24)
        RadioElips.TabIndex = 13
        RadioElips.TabStop = True
        RadioElips.Text = "Elips"
        RadioElips.UseVisualStyleBackColor = True
        ' 
        ' RadioKotakIsi
        ' 
        RadioKotakIsi.AutoSize = True
        RadioKotakIsi.Location = New Point(30, 200)
        RadioKotakIsi.Name = "RadioKotakIsi"
        RadioKotakIsi.Size = New Size(86, 24)
        RadioKotakIsi.TabIndex = 14
        RadioKotakIsi.TabStop = True
        RadioKotakIsi.Text = "Kotak Isi"
        RadioKotakIsi.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnGbrUlang)
        GroupBox2.Controls.Add(btnBersihkan)
        GroupBox2.Controls.Add(btnUndo)
        GroupBox2.Controls.Add(Warna6)
        GroupBox2.Controls.Add(Warna5)
        GroupBox2.Controls.Add(Warna4)
        GroupBox2.Controls.Add(Warna3)
        GroupBox2.Controls.Add(Warna2)
        GroupBox2.Controls.Add(Warna1)
        GroupBox2.Dock = DockStyle.Bottom
        GroupBox2.Location = New Point(193, 505)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(843, 77)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Warna"
        ' 
        ' btnGbrUlang
        ' 
        btnGbrUlang.Location = New Point(663, 30)
        btnGbrUlang.Name = "btnGbrUlang"
        btnGbrUlang.Size = New Size(141, 29)
        btnGbrUlang.TabIndex = 26
        btnGbrUlang.Text = "Gambar Ulang!"
        btnGbrUlang.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.Location = New Point(467, 30)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(156, 29)
        btnBersihkan.TabIndex = 25
        btnBersihkan.Text = "Bersihkan Kanvas"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' btnUndo
        ' 
        btnUndo.Location = New Point(367, 30)
        btnUndo.Name = "btnUndo"
        btnUndo.Size = New Size(94, 29)
        btnUndo.TabIndex = 4
        btnUndo.Text = "Undo"
        btnUndo.UseVisualStyleBackColor = True
        ' 
        ' Warna6
        ' 
        Warna6.BackColor = Color.Black
        Warna6.BorderStyle = BorderStyle.FixedSingle
        Warna6.Location = New Point(194, 29)
        Warna6.Name = "Warna6"
        Warna6.Size = New Size(30, 30)
        Warna6.TabIndex = 24
        ' 
        ' Warna5
        ' 
        Warna5.BackColor = Color.White
        Warna5.BorderStyle = BorderStyle.FixedSingle
        Warna5.Location = New Point(158, 29)
        Warna5.Name = "Warna5"
        Warna5.Size = New Size(30, 30)
        Warna5.TabIndex = 23
        ' 
        ' Warna4
        ' 
        Warna4.BackColor = Color.Blue
        Warna4.BorderStyle = BorderStyle.FixedSingle
        Warna4.Location = New Point(122, 29)
        Warna4.Name = "Warna4"
        Warna4.Size = New Size(30, 30)
        Warna4.TabIndex = 22
        ' 
        ' Warna3
        ' 
        Warna3.BackColor = Color.Green
        Warna3.BorderStyle = BorderStyle.FixedSingle
        Warna3.Location = New Point(86, 29)
        Warna3.Name = "Warna3"
        Warna3.Size = New Size(30, 30)
        Warna3.TabIndex = 21
        ' 
        ' Warna2
        ' 
        Warna2.BackColor = Color.Yellow
        Warna2.BorderStyle = BorderStyle.FixedSingle
        Warna2.Location = New Point(50, 29)
        Warna2.Name = "Warna2"
        Warna2.Size = New Size(30, 30)
        Warna2.TabIndex = 20
        ' 
        ' Warna1
        ' 
        Warna1.BackColor = Color.Red
        Warna1.BorderStyle = BorderStyle.FixedSingle
        Warna1.Location = New Point(14, 29)
        Warna1.Name = "Warna1"
        Warna1.Size = New Size(30, 30)
        Warna1.TabIndex = 19
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(TextBox1)
        GroupBox3.Dock = DockStyle.Right
        GroupBox3.Location = New Point(786, 28)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(250, 477)
        GroupBox3.TabIndex = 3
        GroupBox3.TabStop = False
        GroupBox3.Text = "Objek"
        ' 
        ' TextBox1
        ' 
        TextBox1.Dock = DockStyle.Fill
        TextBox1.Location = New Point(3, 23)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(244, 451)
        TextBox1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Location = New Point(193, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(593, 477)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' frmUtama
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1036, 582)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "frmUtama"
        Text = "Corat-Coret Vektor"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ShapeIsian As Panel
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents ShapeTepi As Panel
    Friend WithEvents RadioBebas As RadioButton
    Friend WithEvents RadioGaris As RadioButton
    Friend WithEvents lblUkuran As Label
    Friend WithEvents RadioKotak As RadioButton
    Friend WithEvents RadioElipsIsi As RadioButton
    Friend WithEvents RadioElips As RadioButton
    Friend WithEvents RadioKotakIsi As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Warna6 As Panel
    Friend WithEvents Warna5 As Panel
    Friend WithEvents Warna4 As Panel
    Friend WithEvents Warna3 As Panel
    Friend WithEvents Warna2 As Panel
    Friend WithEvents Warna1 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnGbrUlang As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BukaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem

End Class
