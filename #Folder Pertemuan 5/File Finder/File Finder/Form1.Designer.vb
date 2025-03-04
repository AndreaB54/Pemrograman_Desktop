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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ExportFileListToTextFileToolStripMenuItem = New ToolStripMenuItem()
        RefreshFolderToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        Panel1 = New Panel()
        btnSearch = New Button()
        txtExtension = New TextBox()
        cbFind = New ComboBox()
        lblFind = New Label()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolStripProgressBar1 = New ToolStripProgressBar()
        ImageList1 = New ImageList(components)
        ContextMenuStrip1 = New ContextMenuStrip(components)
        OpenExecuteFileToolStripMenuItem = New ToolStripMenuItem()
        OpenAndSelectFileInFolderToolStripMenuItem = New ToolStripMenuItem()
        CopyFullPathToClipboardToolStripMenuItem = New ToolStripMenuItem()
        CopyFolderPathToClipboardToolStripMenuItem = New ToolStripMenuItem()
        SplitContainer1 = New SplitContainer()
        Panel2 = New Panel()
        Label3 = New Label()
        lblInfo = New Label()
        tvDrive = New TreeView()
        lvFile = New ListView()
        chName = New ColumnHeader()
        chExt = New ColumnHeader()
        chFSize = New ColumnHeader()
        chLModified = New ColumnHeader()
        chLAccessed = New ColumnHeader()
        chCDate = New ColumnHeader()
        chAttributes = New ColumnHeader()
        chPath = New ColumnHeader()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        ContextMenuStrip1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExportFileListToTextFileToolStripMenuItem, RefreshFolderToolStripMenuItem, ToolStripSeparator1, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' ExportFileListToTextFileToolStripMenuItem
        ' 
        ExportFileListToTextFileToolStripMenuItem.Name = "ExportFileListToTextFileToolStripMenuItem"
        ExportFileListToTextFileToolStripMenuItem.Size = New Size(264, 26)
        ExportFileListToTextFileToolStripMenuItem.Text = "Export File List to Text File"
        ' 
        ' RefreshFolderToolStripMenuItem
        ' 
        RefreshFolderToolStripMenuItem.Name = "RefreshFolderToolStripMenuItem"
        RefreshFolderToolStripMenuItem.Size = New Size(264, 26)
        RefreshFolderToolStripMenuItem.Text = "Refresh Folder"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(261, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(264, 26)
        ExitToolStripMenuItem.Text = "E&xit"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HelpToolStripMenuItem1, ToolStripSeparator2, AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(55, 24)
        HelpToolStripMenuItem.Text = "&Help"
        ' 
        ' HelpToolStripMenuItem1
        ' 
        HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        HelpToolStripMenuItem1.Size = New Size(133, 26)
        HelpToolStripMenuItem1.Text = "Help"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(130, 6)
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(133, 26)
        AboutToolStripMenuItem.Text = "A&bout"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnSearch)
        Panel1.Controls.Add(txtExtension)
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Controls.Add(cbFind)
        Panel1.Controls.Add(lblFind)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 80)
        Panel1.TabIndex = 1
        ' 
        ' btnSearch
        ' 
        btnSearch.Dock = DockStyle.Right
        btnSearch.Location = New Point(712, 28)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(88, 52)
        btnSearch.TabIndex = 7
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtExtension
        ' 
        txtExtension.Location = New Point(638, 36)
        txtExtension.Name = "txtExtension"
        txtExtension.Size = New Size(65, 27)
        txtExtension.TabIndex = 6
        txtExtension.Text = "*.*"
        ' 
        ' cbFind
        ' 
        cbFind.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbFind.AutoCompleteSource = AutoCompleteSource.FileSystem
        cbFind.FormattingEnabled = True
        cbFind.Location = New Point(71, 36)
        cbFind.Name = "cbFind"
        cbFind.Size = New Size(555, 28)
        cbFind.TabIndex = 5
        ' 
        ' lblFind
        ' 
        lblFind.AutoSize = True
        lblFind.Location = New Point(12, 38)
        lblFind.Name = "lblFind"
        lblFind.Size = New Size(44, 20)
        lblFind.TabIndex = 4
        lblFind.Text = "Find :"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, ToolStripProgressBar1})
        StatusStrip1.Location = New Point(0, 424)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 26)
        StatusStrip1.TabIndex = 2
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(683, 20)
        ToolStripStatusLabel1.Spring = True
        ToolStripStatusLabel1.Text = "Ready"
        ToolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ToolStripProgressBar1
        ' 
        ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        ToolStripProgressBar1.Size = New Size(100, 18)
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "drive.png")
        ImageList1.Images.SetKeyName(1, "exe.png")
        ImageList1.Images.SetKeyName(2, "file.png")
        ImageList1.Images.SetKeyName(3, "folder.png")
        ImageList1.Images.SetKeyName(4, "image.png")
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {OpenExecuteFileToolStripMenuItem, OpenAndSelectFileInFolderToolStripMenuItem, CopyFullPathToClipboardToolStripMenuItem, CopyFolderPathToClipboardToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(279, 100)
        ' 
        ' OpenExecuteFileToolStripMenuItem
        ' 
        OpenExecuteFileToolStripMenuItem.Name = "OpenExecuteFileToolStripMenuItem"
        OpenExecuteFileToolStripMenuItem.Size = New Size(278, 24)
        OpenExecuteFileToolStripMenuItem.Text = "Open/Execute File"
        ' 
        ' OpenAndSelectFileInFolderToolStripMenuItem
        ' 
        OpenAndSelectFileInFolderToolStripMenuItem.Name = "OpenAndSelectFileInFolderToolStripMenuItem"
        OpenAndSelectFileInFolderToolStripMenuItem.Size = New Size(278, 24)
        OpenAndSelectFileInFolderToolStripMenuItem.Text = "Open and Select File in Folder"
        ' 
        ' CopyFullPathToClipboardToolStripMenuItem
        ' 
        CopyFullPathToClipboardToolStripMenuItem.Name = "CopyFullPathToClipboardToolStripMenuItem"
        CopyFullPathToClipboardToolStripMenuItem.Size = New Size(278, 24)
        CopyFullPathToClipboardToolStripMenuItem.Text = "Copy Full Path to Clipboard"
        ' 
        ' CopyFolderPathToClipboardToolStripMenuItem
        ' 
        CopyFolderPathToClipboardToolStripMenuItem.Name = "CopyFolderPathToClipboardToolStripMenuItem"
        CopyFolderPathToClipboardToolStripMenuItem.Size = New Size(278, 24)
        CopyFolderPathToClipboardToolStripMenuItem.Text = "Copy Folder Path to Clipboard"
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 80)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(Panel2)
        SplitContainer1.Panel1.Controls.Add(tvDrive)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(lvFile)
        SplitContainer1.Size = New Size(800, 344)
        SplitContainer1.SplitterDistance = 266
        SplitContainer1.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(lblInfo)
        Panel2.Location = New Point(0, 208)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(266, 136)
        Panel2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 20)
        Label3.TabIndex = 1
        ' 
        ' lblInfo
        ' 
        lblInfo.AutoSize = True
        lblInfo.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInfo.Location = New Point(12, 12)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(155, 20)
        lblInfo.TabIndex = 0
        lblInfo.Text = "Free Fixed Disk Info :"
        ' 
        ' tvDrive
        ' 
        tvDrive.Dock = DockStyle.Fill
        tvDrive.ImageIndex = 0
        tvDrive.ImageList = ImageList1
        tvDrive.Location = New Point(0, 0)
        tvDrive.Name = "tvDrive"
        tvDrive.SelectedImageIndex = 0
        tvDrive.Size = New Size(266, 344)
        tvDrive.TabIndex = 0
        ' 
        ' lvFile
        ' 
        lvFile.Columns.AddRange(New ColumnHeader() {chName, chExt, chFSize, chLModified, chLAccessed, chCDate, chAttributes, chPath})
        lvFile.ContextMenuStrip = ContextMenuStrip1
        lvFile.GridLines = True
        lvFile.Location = New Point(2, 0)
        lvFile.Name = "lvFile"
        lvFile.Size = New Size(528, 344)
        lvFile.SmallImageList = ImageList1
        lvFile.TabIndex = 2
        lvFile.UseCompatibleStateImageBehavior = False
        lvFile.View = View.Details
        ' 
        ' chName
        ' 
        chName.Text = "Name"
        ' 
        ' chExt
        ' 
        chExt.Text = "Extension"
        chExt.Width = 75
        ' 
        ' chFSize
        ' 
        chFSize.Text = "File Size"
        chFSize.Width = 75
        ' 
        ' chLModified
        ' 
        chLModified.Text = "Last Modified"
        chLModified.Width = 80
        ' 
        ' chLAccessed
        ' 
        chLAccessed.Text = "Last Accessed"
        chLAccessed.Width = 80
        ' 
        ' chCDate
        ' 
        chCDate.Text = "Created Date"
        chCDate.Width = 75
        ' 
        ' chAttributes
        ' 
        chAttributes.Text = "Attributes"
        chAttributes.Width = 70
        ' 
        ' chPath
        ' 
        chPath.Text = "Full Path"
        chPath.Width = 75
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(SplitContainer1)
        Controls.Add(StatusStrip1)
        Controls.Add(Panel1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FileFInder"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ContextMenuStrip1.ResumeLayout(False)
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportFileListToTextFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents cbFind As ComboBox
    Friend WithEvents lblFind As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OpenExecuteFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenAndSelectFileInFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyFullPathToClipboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyFolderPathToClipboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtExtension As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents tvDrive As TreeView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblInfo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lvFile As ListView
    Friend WithEvents chName As ColumnHeader
    Friend WithEvents chExt As ColumnHeader
    Friend WithEvents chFSize As ColumnHeader
    Friend WithEvents chLModified As ColumnHeader
    Friend WithEvents chLAccessed As ColumnHeader
    Friend WithEvents chCDate As ColumnHeader
    Friend WithEvents chAttributes As ColumnHeader
    Friend WithEvents chPath As ColumnHeader

End Class
