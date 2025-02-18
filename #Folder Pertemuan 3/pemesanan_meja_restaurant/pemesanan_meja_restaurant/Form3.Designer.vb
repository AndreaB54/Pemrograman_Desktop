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
        panelMeja1 = New Panel()
        lblTanggal = New Label()
        Panel1 = New Panel()
        panelMeja3 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        panelMeja5 = New Panel()
        Label3 = New Label()
        panelMeja7 = New Panel()
        Label4 = New Label()
        Panel5 = New Panel()
        panelMeja2 = New Panel()
        Label6 = New Label()
        Label5 = New Label()
        panelMeja4 = New Panel()
        Label7 = New Label()
        panelMeja6 = New Panel()
        Label8 = New Label()
        panelMeja8 = New Panel()
        Label9 = New Label()
        panelMeja9 = New Panel()
        Label10 = New Label()
        panelMeja10 = New Panel()
        Label11 = New Label()
        panelMeja11 = New Panel()
        Label12 = New Label()
        panelMeja12 = New Panel()
        Label13 = New Label()
        Panel14 = New Panel()
        Label14 = New Label()
        Panel15 = New Panel()
        Label15 = New Label()
        SidePanel.SuspendLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        panelMeja1.SuspendLayout()
        Panel1.SuspendLayout()
        panelMeja3.SuspendLayout()
        panelMeja5.SuspendLayout()
        panelMeja7.SuspendLayout()
        Panel5.SuspendLayout()
        panelMeja2.SuspendLayout()
        panelMeja4.SuspendLayout()
        panelMeja6.SuspendLayout()
        panelMeja8.SuspendLayout()
        panelMeja9.SuspendLayout()
        panelMeja10.SuspendLayout()
        panelMeja11.SuspendLayout()
        panelMeja12.SuspendLayout()
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
        ' panelMeja1
        ' 
        panelMeja1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        panelMeja1.BorderStyle = BorderStyle.FixedSingle
        panelMeja1.Controls.Add(lblTanggal)
        panelMeja1.Location = New Point(267, 114)
        panelMeja1.Name = "panelMeja1"
        panelMeja1.Size = New Size(109, 100)
        panelMeja1.TabIndex = 1
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
        Panel1.Controls.Add(panelMeja3)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(267, 248)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(109, 100)
        Panel1.TabIndex = 2
        ' 
        ' panelMeja3
        ' 
        panelMeja3.BackColor = Color.Aquamarine
        panelMeja3.BorderStyle = BorderStyle.FixedSingle
        panelMeja3.Controls.Add(Label2)
        panelMeja3.Location = New Point(-1, -1)
        panelMeja3.Name = "panelMeja3"
        panelMeja3.Size = New Size(109, 100)
        panelMeja3.TabIndex = 2
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
        ' panelMeja5
        ' 
        panelMeja5.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        panelMeja5.BorderStyle = BorderStyle.FixedSingle
        panelMeja5.Controls.Add(Label3)
        panelMeja5.Location = New Point(267, 383)
        panelMeja5.Name = "panelMeja5"
        panelMeja5.Size = New Size(109, 100)
        panelMeja5.TabIndex = 3
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
        ' panelMeja7
        ' 
        panelMeja7.BackColor = Color.Aquamarine
        panelMeja7.BorderStyle = BorderStyle.FixedSingle
        panelMeja7.Controls.Add(Label4)
        panelMeja7.Location = New Point(267, 517)
        panelMeja7.Name = "panelMeja7"
        panelMeja7.Size = New Size(109, 100)
        panelMeja7.TabIndex = 4
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
        Panel5.Controls.Add(panelMeja2)
        Panel5.Controls.Add(Label5)
        Panel5.Location = New Point(466, 114)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(109, 100)
        Panel5.TabIndex = 5
        ' 
        ' panelMeja2
        ' 
        panelMeja2.BackColor = Color.Aquamarine
        panelMeja2.BorderStyle = BorderStyle.FixedSingle
        panelMeja2.Controls.Add(Label6)
        panelMeja2.Location = New Point(-1, -1)
        panelMeja2.Name = "panelMeja2"
        panelMeja2.Size = New Size(109, 100)
        panelMeja2.TabIndex = 2
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
        ' panelMeja4
        ' 
        panelMeja4.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        panelMeja4.BorderStyle = BorderStyle.FixedSingle
        panelMeja4.Controls.Add(Label7)
        panelMeja4.Location = New Point(466, 248)
        panelMeja4.Name = "panelMeja4"
        panelMeja4.Size = New Size(109, 100)
        panelMeja4.TabIndex = 6
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
        ' panelMeja6
        ' 
        panelMeja6.BackColor = Color.Aquamarine
        panelMeja6.BorderStyle = BorderStyle.FixedSingle
        panelMeja6.Controls.Add(Label8)
        panelMeja6.Location = New Point(466, 383)
        panelMeja6.Name = "panelMeja6"
        panelMeja6.Size = New Size(109, 100)
        panelMeja6.TabIndex = 7
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
        ' panelMeja8
        ' 
        panelMeja8.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        panelMeja8.BorderStyle = BorderStyle.FixedSingle
        panelMeja8.Controls.Add(Label9)
        panelMeja8.Location = New Point(466, 517)
        panelMeja8.Name = "panelMeja8"
        panelMeja8.Size = New Size(109, 100)
        panelMeja8.TabIndex = 8
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
        ' panelMeja9
        ' 
        panelMeja9.BackColor = Color.Aquamarine
        panelMeja9.BorderStyle = BorderStyle.FixedSingle
        panelMeja9.Controls.Add(Label10)
        panelMeja9.Location = New Point(651, 114)
        panelMeja9.Name = "panelMeja9"
        panelMeja9.Size = New Size(226, 100)
        panelMeja9.TabIndex = 9
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
        ' panelMeja10
        ' 
        panelMeja10.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        panelMeja10.BorderStyle = BorderStyle.FixedSingle
        panelMeja10.Controls.Add(Label11)
        panelMeja10.Location = New Point(651, 248)
        panelMeja10.Name = "panelMeja10"
        panelMeja10.Size = New Size(226, 100)
        panelMeja10.TabIndex = 10
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
        ' panelMeja11
        ' 
        panelMeja11.BackColor = Color.Aquamarine
        panelMeja11.BorderStyle = BorderStyle.FixedSingle
        panelMeja11.Controls.Add(Label12)
        panelMeja11.Location = New Point(651, 383)
        panelMeja11.Name = "panelMeja11"
        panelMeja11.Size = New Size(226, 100)
        panelMeja11.TabIndex = 11
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
        ' panelMeja12
        ' 
        panelMeja12.BackColor = Color.Aquamarine
        panelMeja12.BorderStyle = BorderStyle.FixedSingle
        panelMeja12.Controls.Add(Label13)
        panelMeja12.Location = New Point(651, 517)
        panelMeja12.Name = "panelMeja12"
        panelMeja12.Size = New Size(226, 100)
        panelMeja12.TabIndex = 12
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
        Controls.Add(panelMeja12)
        Controls.Add(panelMeja11)
        Controls.Add(panelMeja10)
        Controls.Add(panelMeja9)
        Controls.Add(panelMeja8)
        Controls.Add(panelMeja6)
        Controls.Add(panelMeja4)
        Controls.Add(Panel5)
        Controls.Add(panelMeja7)
        Controls.Add(panelMeja5)
        Controls.Add(Panel1)
        Controls.Add(panelMeja1)
        Controls.Add(SidePanel)
        Name = "Form3"
        Text = "Restaurant Reservation"
        SidePanel.ResumeLayout(False)
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        panelMeja1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        panelMeja3.ResumeLayout(False)
        panelMeja5.ResumeLayout(False)
        panelMeja7.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        panelMeja2.ResumeLayout(False)
        panelMeja4.ResumeLayout(False)
        panelMeja6.ResumeLayout(False)
        panelMeja8.ResumeLayout(False)
        panelMeja9.ResumeLayout(False)
        panelMeja10.ResumeLayout(False)
        panelMeja11.ResumeLayout(False)
        panelMeja12.ResumeLayout(False)
        Panel14.ResumeLayout(False)
        Panel15.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents pbLogo As PictureBox
    Private WithEvents panelMeja1 As Panel
    Private WithEvents lblTanggal As Label
    Private WithEvents Panel1 As Panel
    Private WithEvents panelMeja3 As Panel
    Private WithEvents Label2 As Label
    Private WithEvents Label1 As Label
    Private WithEvents panelMeja5 As Panel
    Private WithEvents Label3 As Label
    Private WithEvents panelMeja7 As Panel
    Private WithEvents Label4 As Label
    Private WithEvents Panel5 As Panel
    Private WithEvents panelMeja2 As Panel
    Private WithEvents Label6 As Label
    Private WithEvents Label5 As Label
    Private WithEvents panelMeja4 As Panel
    Private WithEvents Label7 As Label
    Private WithEvents panelMeja6 As Panel
    Private WithEvents Label8 As Label
    Private WithEvents panelMeja8 As Panel
    Private WithEvents Label9 As Label
    Private WithEvents panelMeja9 As Panel
    Private WithEvents Label10 As Label
    Private WithEvents panelMeja10 As Panel
    Private WithEvents Label11 As Label
    Private WithEvents panelMeja11 As Panel
    Private WithEvents Label12 As Label
    Private WithEvents panelMeja12 As Panel
    Private WithEvents Label13 As Label
    Private WithEvents Panel14 As Panel
    Private WithEvents Label14 As Label
    Private WithEvents Panel15 As Panel
    Private WithEvents Label15 As Label
End Class