<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
    Private WithEvents PanelCalendar As Panel ' New panel for calendar
    Private WithEvents lblMonthYear As Label ' New label for month and year
    Private WithEvents panelTgl As Panel ' Panel for date
    Private WithEvents lblTanggal As Label ' Label for date
    Private WithEvents lblHari As Label ' Label for day

    'NOTE: The following procedure is required by the Windows Form Designer.
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        SidePanel = New Panel()
        pbLogo = New PictureBox()
        ordersBtn = New Button()
        tablesBtn = New Button()
        dashboardBtn = New Button()
        AppNameLabel = New Label()
        PanelCalendar = New Panel()
        Panel6 = New Panel()
        Label11 = New Label()
        Label12 = New Label()
        Panel5 = New Panel()
        Label9 = New Label()
        Label10 = New Label()
        Panel4 = New Panel()
        Label7 = New Label()
        Label8 = New Label()
        Panel3 = New Panel()
        Label5 = New Label()
        Label6 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label3 = New Label()
        Label4 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        panelTgl = New Panel()
        lblTanggal = New Label()
        lblHari = New Label()
        lblMonthYear = New Label()
        DataGridView1 = New DataGridView()
        SidePanel.SuspendLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        PanelCalendar.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        panelTgl.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        tablesBtn.FlatStyle = FlatStyle.Flat
        tablesBtn.Font = New Font("Segoe UI", 10.0F)
        tablesBtn.ForeColor = Color.Black
        tablesBtn.Location = New Point(20, 248)
        tablesBtn.Name = "tablesBtn"
        tablesBtn.Size = New Size(160, 40)
        tablesBtn.TabIndex = 5
        tablesBtn.Text = "Tables"
        tablesBtn.UseVisualStyleBackColor = True
        ' 
        ' dashboardBtn
        ' 
        dashboardBtn.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
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
        ' PanelCalendar
        ' 
        PanelCalendar.BackColor = Color.FromArgb(CByte(245), CByte(242), CByte(250))
        PanelCalendar.Controls.Add(Panel6)
        PanelCalendar.Controls.Add(Panel5)
        PanelCalendar.Controls.Add(Panel4)
        PanelCalendar.Controls.Add(Panel3)
        PanelCalendar.Controls.Add(Panel1)
        PanelCalendar.Controls.Add(panelTgl)
        PanelCalendar.Controls.Add(lblMonthYear)
        PanelCalendar.Location = New Point(250, 50)
        PanelCalendar.Name = "PanelCalendar"
        PanelCalendar.Size = New Size(704, 161)
        PanelCalendar.TabIndex = 11
        ' 
        ' Panel6
        ' 
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(Label11)
        Panel6.Controls.Add(Label12)
        Panel6.Location = New Point(571, 44)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(81, 100)
        Panel6.TabIndex = 12
        ' 
        ' Label11
        ' 
        Label11.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(10, 10)
        Label11.Name = "Label11"
        Label11.Size = New Size(60, 30)
        Label11.TabIndex = 0
        Label11.Text = "21"
        ' 
        ' Label12
        ' 
        Label12.Font = New Font("Arial", 10.0F)
        Label12.ForeColor = Color.Gray
        Label12.Location = New Point(10, 40)
        Label12.Name = "Label12"
        Label12.Size = New Size(60, 30)
        Label12.TabIndex = 1
        Label12.Text = "Fri"
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(Label9)
        Panel5.Controls.Add(Label10)
        Panel5.Location = New Point(466, 44)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(81, 100)
        Panel5.TabIndex = 12
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(10, 10)
        Label9.Name = "Label9"
        Label9.Size = New Size(60, 30)
        Label9.TabIndex = 0
        Label9.Text = "20"
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("Arial", 10.0F)
        Label10.ForeColor = Color.Gray
        Label10.Location = New Point(10, 40)
        Label10.Name = "Label10"
        Label10.Size = New Size(60, 30)
        Label10.TabIndex = 1
        Label10.Text = "Thu"
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(Label8)
        Panel4.Location = New Point(361, 44)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(81, 100)
        Panel4.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(10, 10)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 30)
        Label7.TabIndex = 0
        Label7.Text = "19"
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Arial", 10.0F)
        Label8.ForeColor = Color.Gray
        Label8.Location = New Point(10, 40)
        Label8.Name = "Label8"
        Label8.Size = New Size(60, 30)
        Label8.TabIndex = 1
        Label8.Text = "Wed"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label6)
        Panel3.Location = New Point(250, 44)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(81, 100)
        Panel3.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(10, 10)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 30)
        Label5.TabIndex = 0
        Label5.Text = "18"
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Arial", 10.0F)
        Label6.ForeColor = Color.Gray
        Label6.Location = New Point(10, 40)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 30)
        Label6.TabIndex = 1
        Label6.Text = "Tue"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(138, 44)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(81, 100)
        Panel1.TabIndex = 12
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(-1, -1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(81, 100)
        Panel2.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(10, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 30)
        Label3.TabIndex = 0
        Label3.Text = "17"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Arial", 10.0F)
        Label4.ForeColor = Color.Gray
        Label4.Location = New Point(10, 40)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 30)
        Label4.TabIndex = 1
        Label4.Text = "Mon"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(10, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 30)
        Label1.TabIndex = 0
        Label1.Text = "8"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Arial", 10.0F)
        Label2.ForeColor = Color.Gray
        Label2.Location = New Point(10, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 30)
        Label2.TabIndex = 1
        Label2.Text = "Thu"
        ' 
        ' panelTgl
        ' 
        panelTgl.BorderStyle = BorderStyle.FixedSingle
        panelTgl.Controls.Add(lblTanggal)
        panelTgl.Controls.Add(lblHari)
        panelTgl.Location = New Point(28, 44)
        panelTgl.Name = "panelTgl"
        panelTgl.Size = New Size(81, 100)
        panelTgl.TabIndex = 0
        ' 
        ' lblTanggal
        ' 
        lblTanggal.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        lblTanggal.ForeColor = Color.Black
        lblTanggal.Location = New Point(10, 10)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(60, 30)
        lblTanggal.TabIndex = 0
        lblTanggal.Text = "16"
        ' 
        ' lblHari
        ' 
        lblHari.Font = New Font("Arial", 10.0F)
        lblHari.ForeColor = Color.Gray
        lblHari.Location = New Point(10, 40)
        lblHari.Name = "lblHari"
        lblHari.Size = New Size(60, 30)
        lblHari.TabIndex = 1
        lblHari.Text = "Sun"
        ' 
        ' lblMonthYear
        ' 
        lblMonthYear.AutoSize = True
        lblMonthYear.Font = New Font("Arial", 12.0F, FontStyle.Bold)
        lblMonthYear.ForeColor = Color.Black
        lblMonthYear.Location = New Point(10, 10)
        lblMonthYear.Name = "lblMonthYear"
        lblMonthYear.Size = New Size(145, 24)
        lblMonthYear.TabIndex = 0
        lblMonthYear.Text = "February 2025"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(250, 247)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(321, 385)
        DataGridView1.TabIndex = 12
        ' 
        ' Form2
        ' 
        ClientSize = New Size(995, 678)
        Controls.Add(DataGridView1)
        Controls.Add(PanelCalendar)
        Controls.Add(SidePanel)
        Name = "Form2"
        Text = "Restaurant Reservation"
        SidePanel.ResumeLayout(False)
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        PanelCalendar.ResumeLayout(False)
        PanelCalendar.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        panelTgl.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Private WithEvents Panel6 As Panel
    Private WithEvents Label11 As Label
    Private WithEvents Label12 As Label
    Private WithEvents Panel5 As Panel
    Private WithEvents Label9 As Label
    Private WithEvents Label10 As Label
    Private WithEvents Panel4 As Panel
    Private WithEvents Label7 As Label
    Private WithEvents Label8 As Label
    Private WithEvents Panel3 As Panel
    Private WithEvents Label5 As Label
    Private WithEvents Label6 As Label
    Private WithEvents Panel1 As Panel
    Private WithEvents Panel2 As Panel
    Private WithEvents Label3 As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents pbLogo As PictureBox
End Class