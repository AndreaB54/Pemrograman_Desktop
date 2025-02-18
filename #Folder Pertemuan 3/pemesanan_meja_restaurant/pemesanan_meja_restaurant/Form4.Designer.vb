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
        SidePanel.SuspendLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
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
        ' Form4
        ' 
        ClientSize = New Size(995, 678)
        Controls.Add(SidePanel)
        Name = "Form4"
        Text = "Restaurant Reservation"
        SidePanel.ResumeLayout(False)
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents pbLogo As PictureBox
End Class