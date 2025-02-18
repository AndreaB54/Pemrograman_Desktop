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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        SidePanel = New Panel()
        pbLogo = New PictureBox()
        ordersBtn = New Button()
        tablesBtn = New Button()
        dashboardBtn = New Button()
        AppNameLabel = New Label()
        panelTgl = New Panel()
        lblTanggal = New Label()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        Label2 = New Label()
        Panel3 = New Panel()
        Label3 = New Label()
        Panel4 = New Panel()
        Label4 = New Label()
        Panel5 = New Panel()
        Label5 = New Label()
        Panel6 = New Panel()
        Label6 = New Label()
        Panel7 = New Panel()
        Label7 = New Label()
        Panel8 = New Panel()
        Label8 = New Label()
        Panel9 = New Panel()
        Label9 = New Label()
        Panel10 = New Panel()
        Label10 = New Label()
        Panel11 = New Panel()
        Label11 = New Label()
        Panel12 = New Panel()
        Label12 = New Label()
        Panel13 = New Panel()
        Label13 = New Label()
        Panel14 = New Panel()
        Label14 = New Label()
        Panel15 = New Panel()
        Label15 = New Label()
        SidePanel.SuspendLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        panelTgl.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        Panel9.SuspendLayout()
        Panel10.SuspendLayout()
        Panel11.SuspendLayout()
        Panel12.SuspendLayout()
        Panel13.SuspendLayout()
        Panel14.SuspendLayout()
        Panel15.SuspendLayout()
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
        ordersBtn.FlatStyle = FlatStyle.Flat
        ordersBtn.Font = New Font("Segoe UI", 10.0F)
        ordersBtn.ForeColor = Color.Black
        ordersBtn.Location = New Point(20, 298)
        ordersBtn.Name = "ordersBtn"
        ordersBtn.Size = New Size(160, 40)
        ordersBtn.TabIndex = 4
        ordersBtn.Text = "Orders"
        ordersBtn.UseVisualStyleBackColor = True
        ' 
        ' tablesBtn
        ' 
        tablesBtn.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
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
        ' panelTgl
        ' 
        panelTgl.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        panelTgl.BorderStyle = BorderStyle.FixedSingle
        panelTgl.Controls.Add(lblTanggal)
        panelTgl.Location = New Point(267, 114)
        panelTgl.Name = "panelTgl"
        panelTgl.Size = New Size(109, 100)
        panelTgl.TabIndex = 1
        ' 
        ' lblTanggal
        ' 
        lblTanggal.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        lblTanggal.ForeColor = Color.Black
        lblTanggal.Location = New Point(10, 10)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(60, 30)
        lblTanggal.TabIndex = 0
        lblTanggal.Text = "1"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(267, 248)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(109, 100)
        Panel1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(10, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 30)
        Label1.TabIndex = 0
        Label1.Text = "1"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Aquamarine
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(-1, -1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(109, 100)
        Panel2.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(10, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 30)
        Label2.TabIndex = 0
        Label2.Text = "3"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(267, 383)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(109, 100)
        Panel3.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(10, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 30)
        Label3.TabIndex = 0
        Label3.Text = "5"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Aquamarine
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Label4)
        Panel4.Location = New Point(267, 517)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(109, 100)
        Panel4.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(10, 10)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 30)
        Label4.TabIndex = 0
        Label4.Text = "7"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(Panel6)
        Panel5.Controls.Add(Label5)
        Panel5.Location = New Point(466, 114)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(109, 100)
        Panel5.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(10, 10)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 30)
        Label5.TabIndex = 0
        Label5.Text = "1"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Aquamarine
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(Label6)
        Panel6.Location = New Point(-1, -1)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(109, 100)
        Panel6.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(10, 10)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 30)
        Label6.TabIndex = 0
        Label6.Text = "2"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Panel7.BorderStyle = BorderStyle.FixedSingle
        Panel7.Controls.Add(Label7)
        Panel7.Location = New Point(466, 248)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(109, 100)
        Panel7.TabIndex = 6
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(10, 10)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 30)
        Label7.TabIndex = 0
        Label7.Text = "4"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.Aquamarine
        Panel8.BorderStyle = BorderStyle.FixedSingle
        Panel8.Controls.Add(Label8)
        Panel8.Location = New Point(466, 383)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(109, 100)
        Panel8.TabIndex = 7
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(10, 10)
        Label8.Name = "Label8"
        Label8.Size = New Size(60, 30)
        Label8.TabIndex = 0
        Label8.Text = "6"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Panel9.BorderStyle = BorderStyle.FixedSingle
        Panel9.Controls.Add(Label9)
        Panel9.Location = New Point(466, 517)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(109, 100)
        Panel9.TabIndex = 8
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(10, 10)
        Label9.Name = "Label9"
        Label9.Size = New Size(60, 30)
        Label9.TabIndex = 0
        Label9.Text = "8"
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.Aquamarine
        Panel10.BorderStyle = BorderStyle.FixedSingle
        Panel10.Controls.Add(Label10)
        Panel10.Location = New Point(651, 114)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(226, 100)
        Panel10.TabIndex = 9
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(10, 10)
        Label10.Name = "Label10"
        Label10.Size = New Size(60, 30)
        Label10.TabIndex = 0
        Label10.Text = "9"
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Panel11.BorderStyle = BorderStyle.FixedSingle
        Panel11.Controls.Add(Label11)
        Panel11.Location = New Point(651, 248)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(226, 100)
        Panel11.TabIndex = 10
        ' 
        ' Label11
        ' 
        Label11.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(10, 10)
        Label11.Name = "Label11"
        Label11.Size = New Size(60, 30)
        Label11.TabIndex = 0
        Label11.Text = "10"
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.Aquamarine
        Panel12.BorderStyle = BorderStyle.FixedSingle
        Panel12.Controls.Add(Label12)
        Panel12.Location = New Point(651, 383)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(226, 100)
        Panel12.TabIndex = 11
        ' 
        ' Label12
        ' 
        Label12.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(10, 10)
        Label12.Name = "Label12"
        Label12.Size = New Size(60, 30)
        Label12.TabIndex = 0
        Label12.Text = "11"
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.Aquamarine
        Panel13.BorderStyle = BorderStyle.FixedSingle
        Panel13.Controls.Add(Label13)
        Panel13.Location = New Point(651, 517)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(226, 100)
        Panel13.TabIndex = 12
        ' 
        ' Label13
        ' 
        Label13.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(10, 10)
        Label13.Name = "Label13"
        Label13.Size = New Size(60, 30)
        Label13.TabIndex = 0
        Label13.Text = "12"
        ' 
        ' Panel14
        ' 
        Panel14.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Panel14.BorderStyle = BorderStyle.FixedSingle
        Panel14.Controls.Add(Label14)
        Panel14.Location = New Point(440, 12)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(120, 43)
        Panel14.TabIndex = 13
        ' 
        ' Label14
        ' 
        Label14.Font = New Font("Arial", 12.0F, FontStyle.Bold)
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(10, 10)
        Label14.Name = "Label14"
        Label14.Size = New Size(109, 30)
        Label14.TabIndex = 0
        Label14.Text = "Reserved"
        ' 
        ' Panel15
        ' 
        Panel15.BackColor = Color.Aquamarine
        Panel15.BorderStyle = BorderStyle.FixedSingle
        Panel15.Controls.Add(Label15)
        Panel15.Location = New Point(560, 12)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(120, 43)
        Panel15.TabIndex = 14
        ' 
        ' Label15
        ' 
        Label15.Font = New Font("Arial", 12.0F, FontStyle.Bold)
        Label15.ForeColor = Color.Black
        Label15.Location = New Point(10, 10)
        Label15.Name = "Label15"
        Label15.Size = New Size(109, 30)
        Label15.TabIndex = 0
        Label15.Text = "Available"
        ' 
        ' Form3
        ' 
        ClientSize = New Size(995, 678)
        Controls.Add(Panel15)
        Controls.Add(Panel14)
        Controls.Add(Panel13)
        Controls.Add(Panel12)
        Controls.Add(Panel11)
        Controls.Add(Panel10)
        Controls.Add(Panel9)
        Controls.Add(Panel8)
        Controls.Add(Panel7)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(panelTgl)
        Controls.Add(SidePanel)
        Name = "Form3"
        Text = "Restaurant Reservation"
        SidePanel.ResumeLayout(False)
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        panelTgl.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel10.ResumeLayout(False)
        Panel11.ResumeLayout(False)
        Panel12.ResumeLayout(False)
        Panel13.ResumeLayout(False)
        Panel14.ResumeLayout(False)
        Panel15.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents pbLogo As PictureBox
    Private WithEvents panelTgl As Panel
    Private WithEvents lblTanggal As Label
    Private WithEvents Panel1 As Panel
    Private WithEvents Panel2 As Panel
    Private WithEvents Label2 As Label
    Private WithEvents Label1 As Label
    Private WithEvents Panel3 As Panel
    Private WithEvents Label3 As Label
    Private WithEvents Panel4 As Panel
    Private WithEvents Label4 As Label
    Private WithEvents Panel5 As Panel
    Private WithEvents Panel6 As Panel
    Private WithEvents Label6 As Label
    Private WithEvents Label5 As Label
    Private WithEvents Panel7 As Panel
    Private WithEvents Label7 As Label
    Private WithEvents Panel8 As Panel
    Private WithEvents Label8 As Label
    Private WithEvents Panel9 As Panel
    Private WithEvents Label9 As Label
    Private WithEvents Panel10 As Panel
    Private WithEvents Label10 As Label
    Private WithEvents Panel11 As Panel
    Private WithEvents Label11 As Label
    Private WithEvents Panel12 As Panel
    Private WithEvents Label12 As Label
    Private WithEvents Panel13 As Panel
    Private WithEvents Label13 As Label
    Private WithEvents Panel14 As Panel
    Private WithEvents Label14 As Label
    Private WithEvents Panel15 As Panel
    Private WithEvents Label15 As Label
End Class