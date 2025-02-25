<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        imageList1 = New ImageList(components)
        StatusStrip1 = New StatusStrip()
        toolStripStatusReady = New ToolStripStatusLabel()
        toolStripStatusDimension = New ToolStripStatusLabel()
        toolStripStatusBits = New ToolStripStatusLabel()
        toolStripStatusResolution = New ToolStripStatusLabel()
        toolStripStatusRawFormat = New ToolStripStatusLabel()
        ToolTip1 = New ToolTip(components)
        tvDrive = New TreeView()
        lvlmage = New ListView()
        chName = New ColumnHeader()
        chExtension = New ColumnHeader()
        chFileSize = New ColumnHeader()
        chLastModified = New ColumnHeader()
        chLastAccessed = New ColumnHeader()
        chCreatedDate = New ColumnHeader()
        chAttributes = New ColumnHeader()
        PictureBox1 = New PictureBox()
        SplitContainerUtama = New SplitContainer()
        SplitContainerBawah = New SplitContainer()
        SplitContainerBawah2 = New SplitContainer()
        tcProperties = New TabControl()
        TabPage1 = New TabPage()
        PropertyGrid1 = New PropertyGrid()
        TabPage2 = New TabPage()
        lvExif = New ListView()
        chProperty = New ColumnHeader()
        chValue = New ColumnHeader()
        StatusStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainerUtama, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainerUtama.Panel1.SuspendLayout()
        SplitContainerUtama.Panel2.SuspendLayout()
        SplitContainerUtama.SuspendLayout()
        CType(SplitContainerBawah, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainerBawah.Panel1.SuspendLayout()
        SplitContainerBawah.Panel2.SuspendLayout()
        SplitContainerBawah.SuspendLayout()
        CType(SplitContainerBawah2, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainerBawah2.Panel1.SuspendLayout()
        SplitContainerBawah2.Panel2.SuspendLayout()
        SplitContainerBawah2.SuspendLayout()
        tcProperties.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' imageList1
        ' 
        imageList1.ColorDepth = ColorDepth.Depth32Bit
        imageList1.ImageSize = New Size(16, 16)
        imageList1.TransparentColor = Color.Transparent
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {toolStripStatusReady, toolStripStatusDimension, toolStripStatusBits, toolStripStatusResolution, toolStripStatusRawFormat})
        StatusStrip1.Location = New Point(0, 420)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 30)
        StatusStrip1.TabIndex = 0
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' toolStripStatusReady
        ' 
        toolStripStatusReady.Name = "toolStripStatusReady"
        toolStripStatusReady.Size = New Size(53, 24)
        toolStripStatusReady.Text = "Ready."
        ' 
        ' toolStripStatusDimension
        ' 
        toolStripStatusDimension.BorderSides = ToolStripStatusLabelBorderSides.Left
        toolStripStatusDimension.BorderStyle = Border3DStyle.Etched
        toolStripStatusDimension.Name = "toolStripStatusDimension"
        toolStripStatusDimension.Size = New Size(90, 24)
        toolStripStatusDimension.Text = "Dimensions"
        ' 
        ' toolStripStatusBits
        ' 
        toolStripStatusBits.BorderSides = ToolStripStatusLabelBorderSides.Left
        toolStripStatusBits.BorderStyle = Border3DStyle.Etched
        toolStripStatusBits.Name = "toolStripStatusBits"
        toolStripStatusBits.Size = New Size(68, 24)
        toolStripStatusBits.Text = "# of bits"
        ' 
        ' toolStripStatusResolution
        ' 
        toolStripStatusResolution.BorderSides = ToolStripStatusLabelBorderSides.Left
        toolStripStatusResolution.BorderStyle = Border3DStyle.Etched
        toolStripStatusResolution.Name = "toolStripStatusResolution"
        toolStripStatusResolution.Size = New Size(83, 24)
        toolStripStatusResolution.Text = "Resolution"
        ' 
        ' toolStripStatusRawFormat
        ' 
        toolStripStatusRawFormat.BorderSides = ToolStripStatusLabelBorderSides.Left
        toolStripStatusRawFormat.BorderStyle = Border3DStyle.Etched
        toolStripStatusRawFormat.Name = "toolStripStatusRawFormat"
        toolStripStatusRawFormat.Size = New Size(92, 24)
        toolStripStatusRawFormat.Text = "Raw Format"
        ' 
        ' ToolTip1
        ' 
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
        ToolTip1.ToolTipTitle = "ImageViewer Tip:"
        ' 
        ' tvDrive
        ' 
        tvDrive.Dock = DockStyle.Fill
        tvDrive.ImageIndex = 0
        tvDrive.ImageList = imageList1
        tvDrive.Location = New Point(0, 0)
        tvDrive.Name = "tvDrive"
        tvDrive.SelectedImageIndex = 0
        tvDrive.Size = New Size(156, 420)
        tvDrive.TabIndex = 0
        ToolTip1.SetToolTip(tvDrive, "Please select drive/folder that contain one or more images")
        ' 
        ' lvlmage
        ' 
        lvlmage.Columns.AddRange(New ColumnHeader() {chName, chExtension, chFileSize, chLastModified, chLastAccessed, chCreatedDate, chAttributes})
        lvlmage.GridLines = True
        lvlmage.Location = New Point(0, 0)
        lvlmage.Name = "lvlmage"
        lvlmage.Size = New Size(640, 255)
        lvlmage.SmallImageList = imageList1
        lvlmage.TabIndex = 0
        ToolTip1.SetToolTip(lvlmage, "Image file(s)")
        lvlmage.UseCompatibleStateImageBehavior = False
        lvlmage.View = View.Details
        ' 
        ' chName
        ' 
        chName.Tag = ""
        chName.Text = "Name"
        chName.Width = 200
        ' 
        ' chExtension
        ' 
        chExtension.Text = "Extension"
        chExtension.Width = 110
        ' 
        ' chFileSize
        ' 
        chFileSize.Text = "File Size"
        chFileSize.Width = 120
        ' 
        ' chLastModified
        ' 
        chLastModified.Text = "Modified Date"
        chLastModified.Width = 120
        ' 
        ' chLastAccessed
        ' 
        chLastAccessed.Text = "Last Accessed"
        chLastAccessed.Width = 120
        ' 
        ' chCreatedDate
        ' 
        chCreatedDate.Text = "Created Date"
        chCreatedDate.Width = 120
        ' 
        ' chAttributes
        ' 
        chAttributes.Text = "Attributes"
        chAttributes.Width = 120
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(393, 168)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ToolTip1.SetToolTip(PictureBox1, "Double click to view this image in auto size mode!")
        ' 
        ' SplitContainerUtama
        ' 
        SplitContainerUtama.Dock = DockStyle.Fill
        SplitContainerUtama.Location = New Point(0, 0)
        SplitContainerUtama.Name = "SplitContainerUtama"
        ' 
        ' SplitContainerUtama.Panel1
        ' 
        SplitContainerUtama.Panel1.Controls.Add(tvDrive)
        ' 
        ' SplitContainerUtama.Panel2
        ' 
        SplitContainerUtama.Panel2.Controls.Add(SplitContainerBawah)
        SplitContainerUtama.Size = New Size(800, 420)
        SplitContainerUtama.SplitterDistance = 156
        SplitContainerUtama.TabIndex = 1
        ' 
        ' SplitContainerBawah
        ' 
        SplitContainerBawah.Dock = DockStyle.Fill
        SplitContainerBawah.Location = New Point(0, 0)
        SplitContainerBawah.Name = "SplitContainerBawah"
        SplitContainerBawah.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainerBawah.Panel1
        ' 
        SplitContainerBawah.Panel1.Controls.Add(lvlmage)
        ' 
        ' SplitContainerBawah.Panel2
        ' 
        SplitContainerBawah.Panel2.Controls.Add(SplitContainerBawah2)
        SplitContainerBawah.Size = New Size(640, 420)
        SplitContainerBawah.SplitterDistance = 248
        SplitContainerBawah.TabIndex = 0
        ' 
        ' SplitContainerBawah2
        ' 
        SplitContainerBawah2.Dock = DockStyle.Fill
        SplitContainerBawah2.Location = New Point(0, 0)
        SplitContainerBawah2.Name = "SplitContainerBawah2"
        ' 
        ' SplitContainerBawah2.Panel1
        ' 
        SplitContainerBawah2.Panel1.Controls.Add(tcProperties)
        ' 
        ' SplitContainerBawah2.Panel2
        ' 
        SplitContainerBawah2.Panel2.Controls.Add(PictureBox1)
        SplitContainerBawah2.Size = New Size(640, 168)
        SplitContainerBawah2.SplitterDistance = 243
        SplitContainerBawah2.TabIndex = 0
        ' 
        ' tcProperties
        ' 
        tcProperties.Controls.Add(TabPage1)
        tcProperties.Controls.Add(TabPage2)
        tcProperties.Dock = DockStyle.Fill
        tcProperties.Location = New Point(0, 0)
        tcProperties.Name = "tcProperties"
        tcProperties.SelectedIndex = 0
        tcProperties.Size = New Size(243, 168)
        tcProperties.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(PropertyGrid1)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(235, 135)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Image Properties"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' PropertyGrid1
        ' 
        PropertyGrid1.Dock = DockStyle.Fill
        PropertyGrid1.Location = New Point(3, 3)
        PropertyGrid1.Name = "PropertyGrid1"
        PropertyGrid1.Size = New Size(229, 129)
        PropertyGrid1.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(lvExif)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(235, 135)
        TabPage2.TabIndex = 1
        TabPage2.Text = "EXIF Metadata"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' lvExif
        ' 
        lvExif.Columns.AddRange(New ColumnHeader() {chProperty, chValue})
        lvExif.Dock = DockStyle.Fill
        lvExif.GridLines = True
        lvExif.Location = New Point(3, 3)
        lvExif.Name = "lvExif"
        lvExif.Size = New Size(229, 129)
        lvExif.TabIndex = 0
        lvExif.UseCompatibleStateImageBehavior = False
        lvExif.View = View.Details
        ' 
        ' chProperty
        ' 
        chProperty.Text = "Property"
        chProperty.Width = 120
        ' 
        ' chValue
        ' 
        chValue.Text = "Value"
        chValue.Width = 120
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(SplitContainerUtama)
        Controls.Add(StatusStrip1)
        Name = "Form1"
        Text = "Image Viewer"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainerUtama.Panel1.ResumeLayout(False)
        SplitContainerUtama.Panel2.ResumeLayout(False)
        CType(SplitContainerUtama, ComponentModel.ISupportInitialize).EndInit()
        SplitContainerUtama.ResumeLayout(False)
        SplitContainerBawah.Panel1.ResumeLayout(False)
        SplitContainerBawah.Panel2.ResumeLayout(False)
        CType(SplitContainerBawah, ComponentModel.ISupportInitialize).EndInit()
        SplitContainerBawah.ResumeLayout(False)
        SplitContainerBawah2.Panel1.ResumeLayout(False)
        SplitContainerBawah2.Panel2.ResumeLayout(False)
        CType(SplitContainerBawah2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainerBawah2.ResumeLayout(False)
        tcProperties.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents imageList1 As ImageList
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents toolStripStatusReady As ToolStripStatusLabel
    Friend WithEvents toolStripStatusDimension As ToolStripStatusLabel
    Friend WithEvents toolStripStatusBits As ToolStripStatusLabel
    Friend WithEvents toolStripStatusResolution As ToolStripStatusLabel
    Friend WithEvents toolStripStatusRawFormat As ToolStripStatusLabel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SplitContainerUtama As SplitContainer
    Friend WithEvents SplitContainerBawah As SplitContainer
    Friend WithEvents SplitContainerBawah2 As SplitContainer
    Friend WithEvents tvDrive As TreeView
    Friend WithEvents lvlmage As ListView
    Friend WithEvents chName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chFileSize As ColumnHeader
    Friend WithEvents chLastModified As ColumnHeader
    Friend WithEvents chLastAccessed As ColumnHeader
    Friend WithEvents chCreatedDate As ColumnHeader
    Friend WithEvents chAttributes As ColumnHeader
    Friend WithEvents tcProperties As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lvExif As ListView
    Friend WithEvents PropertyGrid1 As PropertyGrid
    Friend WithEvents chProperty As ColumnHeader
    Friend WithEvents chValue As ColumnHeader
    Friend WithEvents PictureBox1 As PictureBox

End Class