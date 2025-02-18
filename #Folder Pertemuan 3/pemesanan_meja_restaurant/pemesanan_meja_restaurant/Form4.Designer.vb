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

    ' Declare controls as class-level variables
    Private WithEvents SidePanel As Panel
    Private WithEvents ordersBtn As Button
    Private WithEvents tablesBtn As Button
    Private WithEvents dashboardBtn As Button
    Private WithEvents AppNameLabel As Label

    'NOTE: The following procedure is required by the Windows Form Designer.
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        SidePanel = New Panel()
        pbLogo = New PictureBox()
        ordersBtn = New Button()
        tablesBtn = New Button()
        dashboardBtn = New Button()
        AppNameLabel = New Label()
        panelMenu1 = New Panel()
        PictureBox1 = New PictureBox()
        lblTanggal = New Label()
        lblHari = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        PictureBox3 = New PictureBox()
        Label3 = New Label()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Panel3 = New Panel()
        PictureBox4 = New PictureBox()
        Label5 = New Label()
        Label6 = New Label()
        Panel4 = New Panel()
        PictureBox5 = New PictureBox()
        Label7 = New Label()
        Label8 = New Label()
        Panel5 = New Panel()
        PictureBox6 = New PictureBox()
        Label9 = New Label()
        Label10 = New Label()
        Panel6 = New Panel()
        PictureBox7 = New PictureBox()
        Label11 = New Label()
        Label12 = New Label()
        Panel7 = New Panel()
        PictureBox8 = New PictureBox()
        Label13 = New Label()
        Label14 = New Label()
        Panel8 = New Panel()
        PictureBox9 = New PictureBox()
        Label15 = New Label()
        Label16 = New Label()
        Panel9 = New Panel()
        PictureBox10 = New PictureBox()
        Label17 = New Label()
        Label18 = New Label()
        SidePanel.SuspendLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        panelMenu1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        Panel8.SuspendLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        Panel9.SuspendLayout()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SidePanel
        ' 
        SidePanel.BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        SidePanel.Controls.Add(pbLogo)
        SidePanel.Controls.Add(ordersBtn)
        SidePanel.Controls.Add(tablesBtn)
        SidePanel.Controls.Add(dashboardBtn)
        SidePanel.Controls.Add(AppNameLabel)
        SidePanel.Dock = DockStyle.Left
        SidePanel.Location = New Point(0, 0)
        SidePanel.Name = "SidePanel"
        SidePanel.Size = New Size(200, 678)
        SidePanel.TabIndex = 0
        ' 
        ' pbLogo
        ' 
        pbLogo.BackColor = Color.Transparent
        pbLogo.BackgroundImage = CType(resources.GetObject("pbLogo.BackgroundImage"), Image)
        pbLogo.BackgroundImageLayout = ImageLayout.Stretch
        pbLogo.Location = New Point(50, 45)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(106, 103)
        pbLogo.TabIndex = 10
        pbLogo.TabStop = False
        ' 
        ' ordersBtn
        ' 
        ordersBtn.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ordersBtn.FlatStyle = FlatStyle.Flat
        ordersBtn.Font = New Font("Segoe UI", 10.0F)
        ordersBtn.ForeColor = Color.Black
        ordersBtn.Location = New Point(20, 298)
        ordersBtn.Name = "ordersBtn"
        ordersBtn.Size = New Size(160, 40)
        ordersBtn.TabIndex = 4
        ordersBtn.Text = "Orders"
        ordersBtn.UseVisualStyleBackColor = False
        ' 
        ' tablesBtn
        ' 
        tablesBtn.BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        tablesBtn.FlatStyle = FlatStyle.Flat
        tablesBtn.Font = New Font("Segoe UI", 10.0F)
        tablesBtn.ForeColor = Color.Black
        tablesBtn.Location = New Point(20, 248)
        tablesBtn.Name = "tablesBtn"
        tablesBtn.Size = New Size(160, 40)
        tablesBtn.TabIndex = 5
        tablesBtn.Text = "Tables"
        tablesBtn.UseVisualStyleBackColor = False
        ' 
        ' dashboardBtn
        ' 
        dashboardBtn.BackColor = Color.FromArgb(CByte(240), CByte(242), CByte(245))
        dashboardBtn.FlatStyle = FlatStyle.Flat
        dashboardBtn.Font = New Font("Segoe UI", 10.0F)
        dashboardBtn.ForeColor = Color.Black
        dashboardBtn.Location = New Point(20, 198)
        dashboardBtn.Name = "dashboardBtn"
        dashboardBtn.Size = New Size(160, 40)
        dashboardBtn.TabIndex = 7
        dashboardBtn.Text = "Dashboard"
        dashboardBtn.UseVisualStyleBackColor = False
        ' 
        ' AppNameLabel
        ' 
        AppNameLabel.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        AppNameLabel.ForeColor = Color.Black
        AppNameLabel.Location = New Point(50, 147)
        AppNameLabel.Name = "AppNameLabel"
        AppNameLabel.Size = New Size(120, 25)
        AppNameLabel.TabIndex = 9
        AppNameLabel.Text = "Cozy Dine."
        ' 
        ' panelMenu1
        ' 
        panelMenu1.BorderStyle = BorderStyle.FixedSingle
        panelMenu1.Controls.Add(PictureBox1)
        panelMenu1.Controls.Add(lblTanggal)
        panelMenu1.Controls.Add(lblHari)
        panelMenu1.Location = New Point(243, 26)
        panelMenu1.Name = "panelMenu1"
        panelMenu1.Size = New Size(178, 169)
        panelMenu1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(31, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(115, 112)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' lblTanggal
        ' 
        lblTanggal.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        lblTanggal.ForeColor = Color.Black
        lblTanggal.Location = New Point(42, 115)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(91, 30)
        lblTanggal.TabIndex = 0
        lblTanggal.Text = "Burger"
        ' 
        ' lblHari
        ' 
        lblHari.Font = New Font("Arial", 10.0F)
        lblHari.ForeColor = Color.Gray
        lblHari.Location = New Point(58, 145)
        lblHari.Name = "lblHari"
        lblHari.Size = New Size(60, 30)
        lblHari.TabIndex = 1
        lblHari.Text = "15000"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(477, 26)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(178, 169)
        Panel1.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(-1, -1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(178, 169)
        Panel2.TabIndex = 12
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(31, 1)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(115, 112)
        PictureBox3.TabIndex = 11
        PictureBox3.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(49, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 30)
        Label3.TabIndex = 0
        Label3.Text = "Pizza"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Arial", 10.0F)
        Label4.ForeColor = Color.Gray
        Label4.Location = New Point(64, 145)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 30)
        Label4.TabIndex = 1
        Label4.Text = "50000"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(31, 1)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(115, 112)
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(64, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 30)
        Label1.TabIndex = 0
        Label1.Text = "16"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Arial", 10.0F)
        Label2.ForeColor = Color.Gray
        Label2.Location = New Point(64, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 30)
        Label2.TabIndex = 1
        Label2.Text = "Sun"
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(PictureBox4)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label6)
        Panel3.Location = New Point(704, 26)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(178, 169)
        Panel3.TabIndex = 3
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(31, 1)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(115, 112)
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(64, 115)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 30)
        Label5.TabIndex = 0
        Label5.Text = "16"
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Arial", 10.0F)
        Label6.ForeColor = Color.Gray
        Label6.Location = New Point(64, 145)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 30)
        Label6.TabIndex = 1
        Label6.Text = "Sun"
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(PictureBox5)
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(Label8)
        Panel4.Location = New Point(243, 233)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(178, 169)
        Panel4.TabIndex = 4
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Image)
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Location = New Point(31, 1)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(115, 112)
        PictureBox5.TabIndex = 11
        PictureBox5.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(64, 115)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 30)
        Label7.TabIndex = 0
        Label7.Text = "16"
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Arial", 10.0F)
        Label8.ForeColor = Color.Gray
        Label8.Location = New Point(64, 145)
        Label8.Name = "Label8"
        Label8.Size = New Size(60, 30)
        Label8.TabIndex = 1
        Label8.Text = "Sun"
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(PictureBox6)
        Panel5.Controls.Add(Label9)
        Panel5.Controls.Add(Label10)
        Panel5.Location = New Point(477, 233)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(178, 169)
        Panel5.TabIndex = 5
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Transparent
        PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), Image)
        PictureBox6.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox6.Location = New Point(31, 1)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(115, 112)
        PictureBox6.TabIndex = 11
        PictureBox6.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(64, 115)
        Label9.Name = "Label9"
        Label9.Size = New Size(60, 30)
        Label9.TabIndex = 0
        Label9.Text = "16"
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("Arial", 10.0F)
        Label10.ForeColor = Color.Gray
        Label10.Location = New Point(64, 145)
        Label10.Name = "Label10"
        Label10.Size = New Size(60, 30)
        Label10.TabIndex = 1
        Label10.Text = "Sun"
        ' 
        ' Panel6
        ' 
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(PictureBox7)
        Panel6.Controls.Add(Label11)
        Panel6.Controls.Add(Label12)
        Panel6.Location = New Point(704, 233)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(178, 169)
        Panel6.TabIndex = 6
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), Image)
        PictureBox7.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox7.Location = New Point(31, 1)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(115, 112)
        PictureBox7.TabIndex = 11
        PictureBox7.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(64, 115)
        Label11.Name = "Label11"
        Label11.Size = New Size(60, 30)
        Label11.TabIndex = 0
        Label11.Text = "16"
        ' 
        ' Label12
        ' 
        Label12.Font = New Font("Arial", 10.0F)
        Label12.ForeColor = Color.Gray
        Label12.Location = New Point(64, 145)
        Label12.Name = "Label12"
        Label12.Size = New Size(60, 30)
        Label12.TabIndex = 1
        Label12.Text = "Sun"
        ' 
        ' Panel7
        ' 
        Panel7.BorderStyle = BorderStyle.FixedSingle
        Panel7.Controls.Add(PictureBox8)
        Panel7.Controls.Add(Label13)
        Panel7.Controls.Add(Label14)
        Panel7.Location = New Point(243, 438)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(178, 169)
        Panel7.TabIndex = 7
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.Transparent
        PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), Image)
        PictureBox8.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox8.Location = New Point(31, 1)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(115, 112)
        PictureBox8.TabIndex = 11
        PictureBox8.TabStop = False
        ' 
        ' Label13
        ' 
        Label13.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(64, 115)
        Label13.Name = "Label13"
        Label13.Size = New Size(60, 30)
        Label13.TabIndex = 0
        Label13.Text = "16"
        ' 
        ' Label14
        ' 
        Label14.Font = New Font("Arial", 10.0F)
        Label14.ForeColor = Color.Gray
        Label14.Location = New Point(64, 145)
        Label14.Name = "Label14"
        Label14.Size = New Size(60, 30)
        Label14.TabIndex = 1
        Label14.Text = "Sun"
        ' 
        ' Panel8
        ' 
        Panel8.BorderStyle = BorderStyle.FixedSingle
        Panel8.Controls.Add(PictureBox9)
        Panel8.Controls.Add(Label15)
        Panel8.Controls.Add(Label16)
        Panel8.Location = New Point(477, 438)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(178, 169)
        Panel8.TabIndex = 8
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = Color.Transparent
        PictureBox9.BackgroundImage = CType(resources.GetObject("PictureBox9.BackgroundImage"), Image)
        PictureBox9.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox9.Location = New Point(31, 1)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(115, 112)
        PictureBox9.TabIndex = 11
        PictureBox9.TabStop = False
        ' 
        ' Label15
        ' 
        Label15.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label15.ForeColor = Color.Black
        Label15.Location = New Point(64, 115)
        Label15.Name = "Label15"
        Label15.Size = New Size(60, 30)
        Label15.TabIndex = 0
        Label15.Text = "16"
        ' 
        ' Label16
        ' 
        Label16.Font = New Font("Arial", 10.0F)
        Label16.ForeColor = Color.Gray
        Label16.Location = New Point(64, 145)
        Label16.Name = "Label16"
        Label16.Size = New Size(60, 30)
        Label16.TabIndex = 1
        Label16.Text = "Sun"
        ' 
        ' Panel9
        ' 
        Panel9.BorderStyle = BorderStyle.FixedSingle
        Panel9.Controls.Add(PictureBox10)
        Panel9.Controls.Add(Label17)
        Panel9.Controls.Add(Label18)
        Panel9.Location = New Point(704, 438)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(178, 169)
        Panel9.TabIndex = 9
        ' 
        ' PictureBox10
        ' 
        PictureBox10.BackColor = Color.Transparent
        PictureBox10.BackgroundImage = CType(resources.GetObject("PictureBox10.BackgroundImage"), Image)
        PictureBox10.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox10.Location = New Point(31, 1)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(115, 112)
        PictureBox10.TabIndex = 11
        PictureBox10.TabStop = False
        ' 
        ' Label17
        ' 
        Label17.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label17.ForeColor = Color.Black
        Label17.Location = New Point(64, 115)
        Label17.Name = "Label17"
        Label17.Size = New Size(60, 30)
        Label17.TabIndex = 0
        Label17.Text = "16"
        ' 
        ' Label18
        ' 
        Label18.Font = New Font("Arial", 10.0F)
        Label18.ForeColor = Color.Gray
        Label18.Location = New Point(64, 145)
        Label18.Name = "Label18"
        Label18.Size = New Size(60, 30)
        Label18.TabIndex = 1
        Label18.Text = "Sun"
        ' 
        ' Form4
        ' 
        ClientSize = New Size(995, 678)
        Controls.Add(Panel9)
        Controls.Add(Panel8)
        Controls.Add(Panel7)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(panelMenu1)
        Controls.Add(SidePanel)
        Name = "Form4"
        Text = "Restaurant Reservation"
        SidePanel.ResumeLayout(False)
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        panelMenu1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        Panel8.ResumeLayout(False)
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        Panel9.ResumeLayout(False)
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents pbLogo As PictureBox
    Private WithEvents panelMenu1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents lblTanggal As Label
    Private WithEvents lblHari As Label
    Private WithEvents Panel1 As Panel
    Private WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Private WithEvents Label3 As Label
    Private WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Private WithEvents Panel3 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Private WithEvents Label5 As Label
    Private WithEvents Label6 As Label
    Private WithEvents Panel4 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Private WithEvents Label7 As Label
    Private WithEvents Label8 As Label
    Private WithEvents Panel5 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Private WithEvents Label9 As Label
    Private WithEvents Label10 As Label
    Private WithEvents Panel6 As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Private WithEvents Label11 As Label
    Private WithEvents Label12 As Label
    Private WithEvents Panel7 As Panel
    Friend WithEvents PictureBox8 As PictureBox
    Private WithEvents Label13 As Label
    Private WithEvents Label14 As Label
    Private WithEvents Panel8 As Panel
    Friend WithEvents PictureBox9 As PictureBox
    Private WithEvents Label15 As Label
    Private WithEvents Label16 As Label
    Private WithEvents Panel9 As Panel
    Friend WithEvents PictureBox10 As PictureBox
    Private WithEvents Label17 As Label
    Private WithEvents Label18 As Label
End Class