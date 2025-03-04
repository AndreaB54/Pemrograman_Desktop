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
        lblPath = New Label()
        txtPath = New TextBox()
        lblOri = New Label()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        btnPath = New Button()
        lblExt = New Label()
        txtExt = New TextBox()
        lblPreview = New Label()
        lvlOri = New ListView()
        chFileName = New ColumnHeader()
        chExtension = New ColumnHeader()
        chAttribute = New ColumnHeader()
        chCreated = New ColumnHeader()
        chAccessed = New ColumnHeader()
        chModified = New ColumnHeader()
        TabControl1 = New TabControl()
        tpFilename = New TabPage()
        txtRightCropNCharF = New TextBox()
        rbRightCropNCharF = New RadioButton()
        txtInsertAfterF = New TextBox()
        rbInsertAfterF = New RadioButton()
        txtWithThisF = New TextBox()
        lblWithThisF = New Label()
        cbCaseF = New ComboBox()
        lblCaseF = New Label()
        txtLeftCropNCharF = New TextBox()
        txtInsertBeforeF = New TextBox()
        txtReplaceThisF = New TextBox()
        txtReplaceWithF = New TextBox()
        rbLeftCropNCharF = New RadioButton()
        rbInsertBeforeF = New RadioButton()
        rbReplaceThisF = New RadioButton()
        rbReplaceWithF = New RadioButton()
        tpExtension = New TabPage()
        txtRightCropNCharE = New TextBox()
        rbRightCropNCharE = New RadioButton()
        txtInsertAfterE = New TextBox()
        rbInsertAfterE = New RadioButton()
        txtWithThisE = New TextBox()
        lblWithThisE = New Label()
        cbCaseE = New ComboBox()
        lblCaseE = New Label()
        txtLeftCropNCharE = New TextBox()
        txtInsertBeforeE = New TextBox()
        txtReplaceThisE = New TextBox()
        txtReplaceWithE = New TextBox()
        rbLeftCropNCharE = New RadioButton()
        rbInsertBeforeE = New RadioButton()
        rbReplaceThisE = New RadioButton()
        rbReplaceWithE = New RadioButton()
        tpAutoNumber = New TabPage()
        GroupBox1 = New GroupBox()
        nudIncrementBy = New NumericUpDown()
        nudStartWithNumber = New NumericUpDown()
        lblIncrementBy = New Label()
        lblStartWithNumber = New Label()
        gbPlace = New GroupBox()
        rbBeforeFileName = New RadioButton()
        rbAfterFileName = New RadioButton()
        lvlPreview = New ListView()
        chFileName2 = New ColumnHeader()
        chExtension2 = New ColumnHeader()
        chAttribute2 = New ColumnHeader()
        chCreated2 = New ColumnHeader()
        chAccessed2 = New ColumnHeader()
        chModified2 = New ColumnHeader()
        btnPreview = New Button()
        btnRename = New Button()
        btnUndo = New Button()
        ImageList1 = New ImageList(components)
        TabControl1.SuspendLayout()
        tpFilename.SuspendLayout()
        tpExtension.SuspendLayout()
        tpAutoNumber.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(nudIncrementBy, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudStartWithNumber, ComponentModel.ISupportInitialize).BeginInit()
        gbPlace.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblPath
        ' 
        lblPath.AutoSize = True
        lblPath.Location = New Point(26, 30)
        lblPath.Name = "lblPath"
        lblPath.Size = New Size(44, 20)
        lblPath.TabIndex = 0
        lblPath.Text = "Path :"
        ' 
        ' txtPath
        ' 
        txtPath.Location = New Point(103, 27)
        txtPath.Name = "txtPath"
        txtPath.ReadOnly = True
        txtPath.Size = New Size(503, 27)
        txtPath.TabIndex = 1
        ' 
        ' lblOri
        ' 
        lblOri.AutoSize = True
        lblOri.Location = New Point(26, 77)
        lblOri.Name = "lblOri"
        lblOri.Size = New Size(96, 20)
        lblOri.TabIndex = 2
        lblOri.Text = "Original File :"
        ' 
        ' btnPath
        ' 
        btnPath.Location = New Point(612, 27)
        btnPath.Name = "btnPath"
        btnPath.Size = New Size(62, 27)
        btnPath.TabIndex = 3
        btnPath.Text = "..."
        btnPath.UseVisualStyleBackColor = True
        ' 
        ' lblExt
        ' 
        lblExt.AutoSize = True
        lblExt.Location = New Point(691, 30)
        lblExt.Name = "lblExt"
        lblExt.Size = New Size(56, 20)
        lblExt.TabIndex = 4
        lblExt.Text = "File Ext"
        ' 
        ' txtExt
        ' 
        txtExt.Location = New Point(758, 27)
        txtExt.Name = "txtExt"
        txtExt.Size = New Size(50, 27)
        txtExt.TabIndex = 5
        txtExt.Text = "*.*"
        txtExt.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblPreview
        ' 
        lblPreview.AutoSize = True
        lblPreview.Location = New Point(425, 77)
        lblPreview.Name = "lblPreview"
        lblPreview.Size = New Size(94, 20)
        lblPreview.TabIndex = 6
        lblPreview.Text = "Preview File :"
        ' 
        ' lvlOri
        ' 
        lvlOri.Columns.AddRange(New ColumnHeader() {chFileName, chExtension, chAttribute, chCreated, chAccessed, chModified})
        lvlOri.GridLines = True
        lvlOri.Location = New Point(26, 102)
        lvlOri.Name = "lvlOri"
        lvlOri.Size = New Size(391, 306)
        lvlOri.TabIndex = 7
        lvlOri.UseCompatibleStateImageBehavior = False
        lvlOri.View = View.Details
        ' 
        ' chFileName
        ' 
        chFileName.Text = "File Name"
        chFileName.Width = 90
        ' 
        ' chExtension
        ' 
        chExtension.Text = "Extension"
        chExtension.Width = 80
        ' 
        ' chAttribute
        ' 
        chAttribute.Text = "Attributes"
        chAttribute.Width = 80
        ' 
        ' chCreated
        ' 
        chCreated.Text = "Date Created"
        chCreated.Width = 100
        ' 
        ' chAccessed
        ' 
        chAccessed.Text = "Date Accessed"
        chAccessed.Width = 100
        ' 
        ' chModified
        ' 
        chModified.Text = "Date Modified"
        chModified.Width = 100
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tpFilename)
        TabControl1.Controls.Add(tpExtension)
        TabControl1.Controls.Add(tpAutoNumber)
        TabControl1.Location = New Point(32, 432)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(694, 176)
        TabControl1.TabIndex = 9
        ' 
        ' tpFilename
        ' 
        tpFilename.Controls.Add(txtRightCropNCharF)
        tpFilename.Controls.Add(rbRightCropNCharF)
        tpFilename.Controls.Add(txtInsertAfterF)
        tpFilename.Controls.Add(rbInsertAfterF)
        tpFilename.Controls.Add(txtWithThisF)
        tpFilename.Controls.Add(lblWithThisF)
        tpFilename.Controls.Add(cbCaseF)
        tpFilename.Controls.Add(lblCaseF)
        tpFilename.Controls.Add(txtLeftCropNCharF)
        tpFilename.Controls.Add(txtInsertBeforeF)
        tpFilename.Controls.Add(txtReplaceThisF)
        tpFilename.Controls.Add(txtReplaceWithF)
        tpFilename.Controls.Add(rbLeftCropNCharF)
        tpFilename.Controls.Add(rbInsertBeforeF)
        tpFilename.Controls.Add(rbReplaceThisF)
        tpFilename.Controls.Add(rbReplaceWithF)
        tpFilename.Location = New Point(4, 29)
        tpFilename.Name = "tpFilename"
        tpFilename.Padding = New Padding(3)
        tpFilename.Size = New Size(686, 143)
        tpFilename.TabIndex = 0
        tpFilename.Text = "File Name"
        tpFilename.UseVisualStyleBackColor = True
        ' 
        ' txtRightCropNCharF
        ' 
        txtRightCropNCharF.Location = New Point(503, 108)
        txtRightCropNCharF.Name = "txtRightCropNCharF"
        txtRightCropNCharF.ReadOnly = True
        txtRightCropNCharF.Size = New Size(171, 27)
        txtRightCropNCharF.TabIndex = 15
        ' 
        ' rbRightCropNCharF
        ' 
        rbRightCropNCharF.AutoSize = True
        rbRightCropNCharF.Location = New Point(354, 111)
        rbRightCropNCharF.Name = "rbRightCropNCharF"
        rbRightCropNCharF.Size = New Size(150, 24)
        rbRightCropNCharF.TabIndex = 14
        rbRightCropNCharF.Text = "Right crop n char :"
        rbRightCropNCharF.UseVisualStyleBackColor = True
        ' 
        ' txtInsertAfterF
        ' 
        txtInsertAfterF.Location = New Point(503, 75)
        txtInsertAfterF.Name = "txtInsertAfterF"
        txtInsertAfterF.ReadOnly = True
        txtInsertAfterF.Size = New Size(171, 27)
        txtInsertAfterF.TabIndex = 13
        ' 
        ' rbInsertAfterF
        ' 
        rbInsertAfterF.AutoSize = True
        rbInsertAfterF.Location = New Point(396, 75)
        rbInsertAfterF.Name = "rbInsertAfterF"
        rbInsertAfterF.Size = New Size(108, 24)
        rbInsertAfterF.TabIndex = 12
        rbInsertAfterF.Text = "Insert after :"
        rbInsertAfterF.UseVisualStyleBackColor = True
        ' 
        ' txtWithThisF
        ' 
        txtWithThisF.Location = New Point(486, 43)
        txtWithThisF.Name = "txtWithThisF"
        txtWithThisF.ReadOnly = True
        txtWithThisF.Size = New Size(188, 27)
        txtWithThisF.TabIndex = 11
        ' 
        ' lblWithThisF
        ' 
        lblWithThisF.AutoSize = True
        lblWithThisF.Location = New Point(413, 45)
        lblWithThisF.Name = "lblWithThisF"
        lblWithThisF.Size = New Size(74, 20)
        lblWithThisF.TabIndex = 10
        lblWithThisF.Text = "With this :"
        ' 
        ' cbCaseF
        ' 
        cbCaseF.FormattingEnabled = True
        cbCaseF.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "No Change"})
        cbCaseF.Location = New Point(517, 9)
        cbCaseF.Name = "cbCaseF"
        cbCaseF.Size = New Size(157, 28)
        cbCaseF.TabIndex = 9
        ' 
        ' lblCaseF
        ' 
        lblCaseF.AutoSize = True
        lblCaseF.Location = New Point(464, 12)
        lblCaseF.Name = "lblCaseF"
        lblCaseF.Size = New Size(47, 20)
        lblCaseF.TabIndex = 8
        lblCaseF.Text = "Case :"
        ' 
        ' txtLeftCropNCharF
        ' 
        txtLeftCropNCharF.Location = New Point(147, 110)
        txtLeftCropNCharF.Name = "txtLeftCropNCharF"
        txtLeftCropNCharF.Size = New Size(160, 27)
        txtLeftCropNCharF.TabIndex = 7
        ' 
        ' txtInsertBeforeF
        ' 
        txtInsertBeforeF.Location = New Point(147, 75)
        txtInsertBeforeF.Name = "txtInsertBeforeF"
        txtInsertBeforeF.Size = New Size(243, 27)
        txtInsertBeforeF.TabIndex = 6
        ' 
        ' txtReplaceThisF
        ' 
        txtReplaceThisF.Location = New Point(147, 42)
        txtReplaceThisF.Name = "txtReplaceThisF"
        txtReplaceThisF.Size = New Size(260, 27)
        txtReplaceThisF.TabIndex = 5
        ' 
        ' txtReplaceWithF
        ' 
        txtReplaceWithF.Location = New Point(147, 10)
        txtReplaceWithF.Name = "txtReplaceWithF"
        txtReplaceWithF.Size = New Size(311, 27)
        txtReplaceWithF.TabIndex = 4
        ' 
        ' rbLeftCropNCharF
        ' 
        rbLeftCropNCharF.AutoSize = True
        rbLeftCropNCharF.Location = New Point(11, 108)
        rbLeftCropNCharF.Name = "rbLeftCropNCharF"
        rbLeftCropNCharF.Size = New Size(140, 24)
        rbLeftCropNCharF.TabIndex = 3
        rbLeftCropNCharF.Text = "Left crop n char :"
        rbLeftCropNCharF.UseVisualStyleBackColor = True
        ' 
        ' rbInsertBeforeF
        ' 
        rbInsertBeforeF.AutoSize = True
        rbInsertBeforeF.Location = New Point(11, 76)
        rbInsertBeforeF.Name = "rbInsertBeforeF"
        rbInsertBeforeF.Size = New Size(121, 24)
        rbInsertBeforeF.TabIndex = 2
        rbInsertBeforeF.Text = "Insert Before :"
        rbInsertBeforeF.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceThisF
        ' 
        rbReplaceThisF.AutoSize = True
        rbReplaceThisF.Location = New Point(11, 43)
        rbReplaceThisF.Name = "rbReplaceThisF"
        rbReplaceThisF.Size = New Size(117, 24)
        rbReplaceThisF.TabIndex = 1
        rbReplaceThisF.Text = "Replace this :"
        rbReplaceThisF.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceWithF
        ' 
        rbReplaceWithF.AutoSize = True
        rbReplaceWithF.Checked = True
        rbReplaceWithF.Location = New Point(11, 10)
        rbReplaceWithF.Name = "rbReplaceWithF"
        rbReplaceWithF.Size = New Size(125, 24)
        rbReplaceWithF.TabIndex = 0
        rbReplaceWithF.TabStop = True
        rbReplaceWithF.Text = "Replace With :"
        rbReplaceWithF.UseVisualStyleBackColor = True
        ' 
        ' tpExtension
        ' 
        tpExtension.Controls.Add(txtRightCropNCharE)
        tpExtension.Controls.Add(rbRightCropNCharE)
        tpExtension.Controls.Add(txtInsertAfterE)
        tpExtension.Controls.Add(rbInsertAfterE)
        tpExtension.Controls.Add(txtWithThisE)
        tpExtension.Controls.Add(lblWithThisE)
        tpExtension.Controls.Add(cbCaseE)
        tpExtension.Controls.Add(lblCaseE)
        tpExtension.Controls.Add(txtLeftCropNCharE)
        tpExtension.Controls.Add(txtInsertBeforeE)
        tpExtension.Controls.Add(txtReplaceThisE)
        tpExtension.Controls.Add(txtReplaceWithE)
        tpExtension.Controls.Add(rbLeftCropNCharE)
        tpExtension.Controls.Add(rbInsertBeforeE)
        tpExtension.Controls.Add(rbReplaceThisE)
        tpExtension.Controls.Add(rbReplaceWithE)
        tpExtension.Location = New Point(4, 29)
        tpExtension.Name = "tpExtension"
        tpExtension.Padding = New Padding(3)
        tpExtension.Size = New Size(686, 143)
        tpExtension.TabIndex = 1
        tpExtension.Text = "Extension"
        tpExtension.UseVisualStyleBackColor = True
        ' 
        ' txtRightCropNCharE
        ' 
        txtRightCropNCharE.Location = New Point(504, 106)
        txtRightCropNCharE.Name = "txtRightCropNCharE"
        txtRightCropNCharE.ReadOnly = True
        txtRightCropNCharE.Size = New Size(171, 27)
        txtRightCropNCharE.TabIndex = 31
        ' 
        ' rbRightCropNCharE
        ' 
        rbRightCropNCharE.AutoSize = True
        rbRightCropNCharE.Location = New Point(355, 109)
        rbRightCropNCharE.Name = "rbRightCropNCharE"
        rbRightCropNCharE.Size = New Size(150, 24)
        rbRightCropNCharE.TabIndex = 30
        rbRightCropNCharE.Text = "Right crop n char :"
        rbRightCropNCharE.UseVisualStyleBackColor = True
        ' 
        ' txtInsertAfterE
        ' 
        txtInsertAfterE.Location = New Point(504, 73)
        txtInsertAfterE.Name = "txtInsertAfterE"
        txtInsertAfterE.ReadOnly = True
        txtInsertAfterE.Size = New Size(171, 27)
        txtInsertAfterE.TabIndex = 29
        ' 
        ' rbInsertAfterE
        ' 
        rbInsertAfterE.AutoSize = True
        rbInsertAfterE.Location = New Point(397, 73)
        rbInsertAfterE.Name = "rbInsertAfterE"
        rbInsertAfterE.Size = New Size(108, 24)
        rbInsertAfterE.TabIndex = 28
        rbInsertAfterE.Text = "Insert after :"
        rbInsertAfterE.UseVisualStyleBackColor = True
        ' 
        ' txtWithThisE
        ' 
        txtWithThisE.Location = New Point(487, 41)
        txtWithThisE.Name = "txtWithThisE"
        txtWithThisE.ReadOnly = True
        txtWithThisE.Size = New Size(188, 27)
        txtWithThisE.TabIndex = 27
        ' 
        ' lblWithThisE
        ' 
        lblWithThisE.AutoSize = True
        lblWithThisE.Location = New Point(414, 43)
        lblWithThisE.Name = "lblWithThisE"
        lblWithThisE.Size = New Size(74, 20)
        lblWithThisE.TabIndex = 26
        lblWithThisE.Text = "With this :"
        ' 
        ' cbCaseE
        ' 
        cbCaseE.FormattingEnabled = True
        cbCaseE.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "No Change"})
        cbCaseE.Location = New Point(518, 7)
        cbCaseE.Name = "cbCaseE"
        cbCaseE.Size = New Size(157, 28)
        cbCaseE.TabIndex = 25
        ' 
        ' lblCaseE
        ' 
        lblCaseE.AutoSize = True
        lblCaseE.Location = New Point(465, 10)
        lblCaseE.Name = "lblCaseE"
        lblCaseE.Size = New Size(47, 20)
        lblCaseE.TabIndex = 24
        lblCaseE.Text = "Case :"
        ' 
        ' txtLeftCropNCharE
        ' 
        txtLeftCropNCharE.Location = New Point(148, 108)
        txtLeftCropNCharE.Name = "txtLeftCropNCharE"
        txtLeftCropNCharE.ReadOnly = True
        txtLeftCropNCharE.Size = New Size(160, 27)
        txtLeftCropNCharE.TabIndex = 23
        ' 
        ' txtInsertBeforeE
        ' 
        txtInsertBeforeE.Location = New Point(148, 73)
        txtInsertBeforeE.Name = "txtInsertBeforeE"
        txtInsertBeforeE.ReadOnly = True
        txtInsertBeforeE.Size = New Size(243, 27)
        txtInsertBeforeE.TabIndex = 22
        ' 
        ' txtReplaceThisE
        ' 
        txtReplaceThisE.Location = New Point(148, 40)
        txtReplaceThisE.Name = "txtReplaceThisE"
        txtReplaceThisE.ReadOnly = True
        txtReplaceThisE.Size = New Size(260, 27)
        txtReplaceThisE.TabIndex = 21
        ' 
        ' txtReplaceWithE
        ' 
        txtReplaceWithE.Location = New Point(148, 8)
        txtReplaceWithE.Name = "txtReplaceWithE"
        txtReplaceWithE.ReadOnly = True
        txtReplaceWithE.Size = New Size(311, 27)
        txtReplaceWithE.TabIndex = 20
        ' 
        ' rbLeftCropNCharE
        ' 
        rbLeftCropNCharE.AutoSize = True
        rbLeftCropNCharE.Location = New Point(12, 106)
        rbLeftCropNCharE.Name = "rbLeftCropNCharE"
        rbLeftCropNCharE.Size = New Size(140, 24)
        rbLeftCropNCharE.TabIndex = 19
        rbLeftCropNCharE.Text = "Left crop n char :"
        rbLeftCropNCharE.UseVisualStyleBackColor = True
        ' 
        ' rbInsertBeforeE
        ' 
        rbInsertBeforeE.AutoSize = True
        rbInsertBeforeE.Location = New Point(12, 74)
        rbInsertBeforeE.Name = "rbInsertBeforeE"
        rbInsertBeforeE.Size = New Size(121, 24)
        rbInsertBeforeE.TabIndex = 18
        rbInsertBeforeE.Text = "Insert Before :"
        rbInsertBeforeE.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceThisE
        ' 
        rbReplaceThisE.AutoSize = True
        rbReplaceThisE.Location = New Point(12, 41)
        rbReplaceThisE.Name = "rbReplaceThisE"
        rbReplaceThisE.Size = New Size(117, 24)
        rbReplaceThisE.TabIndex = 17
        rbReplaceThisE.Text = "Replace this :"
        rbReplaceThisE.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceWithE
        ' 
        rbReplaceWithE.AutoSize = True
        rbReplaceWithE.Checked = True
        rbReplaceWithE.Location = New Point(12, 8)
        rbReplaceWithE.Name = "rbReplaceWithE"
        rbReplaceWithE.Size = New Size(125, 24)
        rbReplaceWithE.TabIndex = 16
        rbReplaceWithE.TabStop = True
        rbReplaceWithE.Text = "Replace With :"
        rbReplaceWithE.UseVisualStyleBackColor = True
        ' 
        ' tpAutoNumber
        ' 
        tpAutoNumber.Controls.Add(GroupBox1)
        tpAutoNumber.Controls.Add(gbPlace)
        tpAutoNumber.Location = New Point(4, 29)
        tpAutoNumber.Name = "tpAutoNumber"
        tpAutoNumber.Size = New Size(686, 143)
        tpAutoNumber.TabIndex = 2
        tpAutoNumber.Text = "Autonumber"
        tpAutoNumber.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(nudIncrementBy)
        GroupBox1.Controls.Add(nudStartWithNumber)
        GroupBox1.Controls.Add(lblIncrementBy)
        GroupBox1.Controls.Add(lblStartWithNumber)
        GroupBox1.Location = New Point(290, 15)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(376, 117)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "With :"
        ' 
        ' nudIncrementBy
        ' 
        nudIncrementBy.Location = New Point(161, 70)
        nudIncrementBy.Name = "nudIncrementBy"
        nudIncrementBy.Size = New Size(150, 27)
        nudIncrementBy.TabIndex = 15
        nudIncrementBy.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' nudStartWithNumber
        ' 
        nudStartWithNumber.Location = New Point(161, 37)
        nudStartWithNumber.Name = "nudStartWithNumber"
        nudStartWithNumber.Size = New Size(150, 27)
        nudStartWithNumber.TabIndex = 14
        nudStartWithNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' lblIncrementBy
        ' 
        lblIncrementBy.AutoSize = True
        lblIncrementBy.Location = New Point(17, 77)
        lblIncrementBy.Name = "lblIncrementBy"
        lblIncrementBy.Size = New Size(102, 20)
        lblIncrementBy.TabIndex = 3
        lblIncrementBy.Text = "Increment by :"
        ' 
        ' lblStartWithNumber
        ' 
        lblStartWithNumber.AutoSize = True
        lblStartWithNumber.Location = New Point(17, 40)
        lblStartWithNumber.Name = "lblStartWithNumber"
        lblStartWithNumber.Size = New Size(134, 20)
        lblStartWithNumber.TabIndex = 2
        lblStartWithNumber.Text = "Start with number :"
        ' 
        ' gbPlace
        ' 
        gbPlace.Controls.Add(rbBeforeFileName)
        gbPlace.Controls.Add(rbAfterFileName)
        gbPlace.Location = New Point(13, 15)
        gbPlace.Name = "gbPlace"
        gbPlace.Size = New Size(257, 117)
        gbPlace.TabIndex = 0
        gbPlace.TabStop = False
        gbPlace.Text = "Place :"
        ' 
        ' rbBeforeFileName
        ' 
        rbBeforeFileName.AutoSize = True
        rbBeforeFileName.Location = New Point(15, 77)
        rbBeforeFileName.Name = "rbBeforeFileName"
        rbBeforeFileName.Size = New Size(136, 24)
        rbBeforeFileName.TabIndex = 15
        rbBeforeFileName.TabStop = True
        rbBeforeFileName.Text = "Before filename"
        rbBeforeFileName.UseVisualStyleBackColor = True
        ' 
        ' rbAfterFileName
        ' 
        rbAfterFileName.AutoSize = True
        rbAfterFileName.Location = New Point(15, 40)
        rbAfterFileName.Name = "rbAfterFileName"
        rbAfterFileName.Size = New Size(125, 24)
        rbAfterFileName.TabIndex = 14
        rbAfterFileName.TabStop = True
        rbAfterFileName.Text = "After filename"
        rbAfterFileName.UseVisualStyleBackColor = True
        ' 
        ' lvlPreview
        ' 
        lvlPreview.Columns.AddRange(New ColumnHeader() {chFileName2, chExtension2, chAttribute2, chCreated2, chAccessed2, chModified2})
        lvlPreview.GridLines = True
        lvlPreview.Location = New Point(425, 102)
        lvlPreview.Name = "lvlPreview"
        lvlPreview.Size = New Size(391, 306)
        lvlPreview.TabIndex = 10
        lvlPreview.UseCompatibleStateImageBehavior = False
        lvlPreview.View = View.Details
        ' 
        ' chFileName2
        ' 
        chFileName2.Text = "File Name"
        chFileName2.Width = 90
        ' 
        ' chExtension2
        ' 
        chExtension2.Text = "Extension"
        chExtension2.Width = 80
        ' 
        ' chAttribute2
        ' 
        chAttribute2.Text = "Attributes"
        chAttribute2.Width = 80
        ' 
        ' chCreated2
        ' 
        chCreated2.Text = "Date Created"
        chCreated2.Width = 100
        ' 
        ' chAccessed2
        ' 
        chAccessed2.Text = "Date Accessed"
        chAccessed2.Width = 100
        ' 
        ' chModified2
        ' 
        chModified2.Text = "Date Modified"
        chModified2.Width = 100
        ' 
        ' btnPreview
        ' 
        btnPreview.Location = New Point(732, 432)
        btnPreview.Name = "btnPreview"
        btnPreview.Size = New Size(92, 26)
        btnPreview.TabIndex = 11
        btnPreview.Text = "Preview"
        btnPreview.UseVisualStyleBackColor = True
        ' 
        ' btnRename
        ' 
        btnRename.Location = New Point(732, 464)
        btnRename.Name = "btnRename"
        btnRename.Size = New Size(92, 26)
        btnRename.TabIndex = 12
        btnRename.Text = "Rename"
        btnRename.UseVisualStyleBackColor = True
        ' 
        ' btnUndo
        ' 
        btnUndo.Location = New Point(732, 496)
        btnUndo.Name = "btnUndo"
        btnUndo.Size = New Size(92, 26)
        btnUndo.TabIndex = 13
        btnUndo.Text = "Undo"
        btnUndo.UseVisualStyleBackColor = True
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(833, 622)
        Controls.Add(btnUndo)
        Controls.Add(btnRename)
        Controls.Add(btnPreview)
        Controls.Add(lvlPreview)
        Controls.Add(TabControl1)
        Controls.Add(lvlOri)
        Controls.Add(lblPreview)
        Controls.Add(txtExt)
        Controls.Add(lblExt)
        Controls.Add(btnPath)
        Controls.Add(lblOri)
        Controls.Add(txtPath)
        Controls.Add(lblPath)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mass Renamer"
        TabControl1.ResumeLayout(False)
        tpFilename.ResumeLayout(False)
        tpFilename.PerformLayout()
        tpExtension.ResumeLayout(False)
        tpExtension.PerformLayout()
        tpAutoNumber.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(nudIncrementBy, ComponentModel.ISupportInitialize).EndInit()
        CType(nudStartWithNumber, ComponentModel.ISupportInitialize).EndInit()
        gbPlace.ResumeLayout(False)
        gbPlace.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblPath As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents lblOri As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents btnPath As Button
    Friend WithEvents lblExt As Label
    Friend WithEvents txtExt As TextBox
    Friend WithEvents lblPreview As Label
    Friend WithEvents lvlOri As ListView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpFilename As TabPage
    Friend WithEvents tpExtension As TabPage
    Friend WithEvents chFileName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chAttribute As ColumnHeader
    Friend WithEvents chCreated As ColumnHeader
    Friend WithEvents chAccessed As ColumnHeader
    Friend WithEvents chModified As ColumnHeader
    Friend WithEvents lvlPreview As ListView
    Friend WithEvents chFileName2 As ColumnHeader
    Friend WithEvents chExtension2 As ColumnHeader
    Friend WithEvents chAttribute2 As ColumnHeader
    Friend WithEvents chCreated2 As ColumnHeader
    Friend WithEvents chAccessed2 As ColumnHeader
    Friend WithEvents chModified2 As ColumnHeader
    Friend WithEvents tpAutoNumber As TabPage
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnRename As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents rbLeftCropNCharF As RadioButton
    Friend WithEvents rbInsertBeforeF As RadioButton
    Friend WithEvents rbReplaceThisF As RadioButton
    Friend WithEvents rbReplaceWithF As RadioButton
    Friend WithEvents txtLeftCropNCharF As TextBox
    Friend WithEvents txtInsertBeforeF As TextBox
    Friend WithEvents txtReplaceThisF As TextBox
    Friend WithEvents txtReplaceWithF As TextBox
    Friend WithEvents txtInsertAfterF As TextBox
    Friend WithEvents rbInsertAfterF As RadioButton
    Friend WithEvents txtWithThisF As TextBox
    Friend WithEvents lblWithThisF As Label
    Friend WithEvents cbCaseF As ComboBox
    Friend WithEvents lblCaseF As Label
    Friend WithEvents txtRightCropNCharF As TextBox
    Friend WithEvents rbRightCropNCharF As RadioButton
    Friend WithEvents txtRightCropNCharE As TextBox
    Friend WithEvents rbRightCropNCharE As RadioButton
    Friend WithEvents txtInsertAfterE As TextBox
    Friend WithEvents rbInsertAfterE As RadioButton
    Friend WithEvents txtWithThisE As TextBox
    Friend WithEvents lblWithThisE As Label
    Friend WithEvents cbCaseE As ComboBox
    Friend WithEvents lblCaseE As Label
    Friend WithEvents txtLeftCropNCharE As TextBox
    Friend WithEvents txtInsertBeforeE As TextBox
    Friend WithEvents txtReplaceThisE As TextBox
    Friend WithEvents txtReplaceWithE As TextBox
    Friend WithEvents rbLeftCropNCharE As RadioButton
    Friend WithEvents rbInsertBeforeE As RadioButton
    Friend WithEvents rbReplaceThisE As RadioButton
    Friend WithEvents rbReplaceWithE As RadioButton
    Friend WithEvents gbPlace As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbBeforeFileName As RadioButton
    Friend WithEvents rbAfterFileName As RadioButton
    Friend WithEvents nudIncrementBy As NumericUpDown
    Friend WithEvents nudStartWithNumber As NumericUpDown
    Friend WithEvents lblIncrementBy As Label
    Friend WithEvents lblStartWithNumber As Label
    Friend WithEvents ImageList1 As ImageList

End Class
