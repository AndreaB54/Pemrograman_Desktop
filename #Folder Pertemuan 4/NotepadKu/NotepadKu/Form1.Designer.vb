﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        menuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        newToolStripMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        SaveAsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        PageSetupToolStripMenuItem = New ToolStripMenuItem()
        PrintToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        CloseToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        UndoToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        CutToolStripMenuItem = New ToolStripMenuItem()
        CopyToolStripMenuItem = New ToolStripMenuItem()
        PasteToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator4 = New ToolStripSeparator()
        FindToolStripMenuItem = New ToolStripMenuItem()
        FindNextToolStripMenuItem = New ToolStripMenuItem()
        ReplaceToolStripMenuItem = New ToolStripMenuItem()
        GoToToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator5 = New ToolStripSeparator()
        SelectAllToolStripMenuItem = New ToolStripMenuItem()
        InsertDateTimeToolStripMenuItem = New ToolStripMenuItem()
        FormatToolStripMenuItem = New ToolStripMenuItem()
        WordWrapToolStripMenuItem = New ToolStripMenuItem()
        FontToolStripMenuItem = New ToolStripMenuItem()
        ViewToolStripMenuItem = New ToolStripMenuItem()
        StatusBarToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator6 = New ToolStripSeparator()
        AboutNotepadKuToolStripMenuItem = New ToolStripMenuItem()
        statusStrip1 = New StatusStrip()
        toolStripStatusReady = New ToolStripStatusLabel()
        toolStripStatusLine = New ToolStripStatusLabel()
        insertStripStatus = New ToolStripStatusLabel()
        capsStripStatus = New ToolStripStatusLabel()
        numStripStatus = New ToolStripStatusLabel()
        openFileDialog1 = New OpenFileDialog()
        fontDialog1 = New FontDialog()
        printDialog1 = New PrintDialog()
        pageSetupDialog1 = New PageSetupDialog()
        saveFileDialog1 = New SaveFileDialog()
        PrintDocument1 = New Printing.PrintDocument()
        txtNotepad = New TextBox()
        menuStrip1.SuspendLayout()
        statusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' menuStrip1
        ' 
        menuStrip1.ImageScalingSize = New Size(20, 20)
        menuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, FormatToolStripMenuItem, ViewToolStripMenuItem, AboutToolStripMenuItem})
        menuStrip1.Location = New Point(0, 0)
        menuStrip1.Name = "menuStrip1"
        menuStrip1.Size = New Size(800, 28)
        menuStrip1.TabIndex = 0
        menuStrip1.Text = "menuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {newToolStripMenuItem, OpenToolStripMenuItem, SaveToolStripMenuItem, SaveAsToolStripMenuItem, ToolStripSeparator1, PageSetupToolStripMenuItem, PrintToolStripMenuItem, ToolStripSeparator2, CloseToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' newToolStripMenuItem
        ' 
        newToolStripMenuItem.Name = "newToolStripMenuItem"
        newToolStripMenuItem.Size = New Size(224, 26)
        newToolStripMenuItem.Text = "&New"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.Size = New Size(224, 26)
        OpenToolStripMenuItem.Text = "&Open"
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.Size = New Size(224, 26)
        SaveToolStripMenuItem.Text = "&Save"
        ' 
        ' SaveAsToolStripMenuItem
        ' 
        SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        SaveAsToolStripMenuItem.Size = New Size(224, 26)
        SaveAsToolStripMenuItem.Text = "Save &as..."
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(221, 6)
        ' 
        ' PageSetupToolStripMenuItem
        ' 
        PageSetupToolStripMenuItem.Name = "PageSetupToolStripMenuItem"
        PageSetupToolStripMenuItem.Size = New Size(224, 26)
        PageSetupToolStripMenuItem.Text = "&Page Setup"
        ' 
        ' PrintToolStripMenuItem
        ' 
        PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        PrintToolStripMenuItem.Size = New Size(224, 26)
        PrintToolStripMenuItem.Text = "P&rint"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(221, 6)
        ' 
        ' CloseToolStripMenuItem
        ' 
        CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        CloseToolStripMenuItem.Size = New Size(224, 26)
        CloseToolStripMenuItem.Text = "&Close"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(224, 26)
        ExitToolStripMenuItem.Text = "E&xit"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {UndoToolStripMenuItem, ToolStripSeparator3, CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, ToolStripSeparator4, FindToolStripMenuItem, FindNextToolStripMenuItem, ReplaceToolStripMenuItem, GoToToolStripMenuItem, ToolStripSeparator5, SelectAllToolStripMenuItem, InsertDateTimeToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(49, 24)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' UndoToolStripMenuItem
        ' 
        UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        UndoToolStripMenuItem.Size = New Size(201, 26)
        UndoToolStripMenuItem.Text = "Undo"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(198, 6)
        ' 
        ' CutToolStripMenuItem
        ' 
        CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        CutToolStripMenuItem.Size = New Size(201, 26)
        CutToolStripMenuItem.Text = "&Cut"
        ' 
        ' CopyToolStripMenuItem
        ' 
        CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        CopyToolStripMenuItem.Size = New Size(201, 26)
        CopyToolStripMenuItem.Text = "C&opy"
        ' 
        ' PasteToolStripMenuItem
        ' 
        PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        PasteToolStripMenuItem.Size = New Size(201, 26)
        PasteToolStripMenuItem.Text = "&Paste"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(198, 6)
        ' 
        ' FindToolStripMenuItem
        ' 
        FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        FindToolStripMenuItem.Size = New Size(201, 26)
        FindToolStripMenuItem.Text = "&Find..."
        ' 
        ' FindNextToolStripMenuItem
        ' 
        FindNextToolStripMenuItem.Name = "FindNextToolStripMenuItem"
        FindNextToolStripMenuItem.Size = New Size(201, 26)
        FindNextToolStripMenuItem.Text = "Find &Next"
        ' 
        ' ReplaceToolStripMenuItem
        ' 
        ReplaceToolStripMenuItem.Name = "ReplaceToolStripMenuItem"
        ReplaceToolStripMenuItem.Size = New Size(201, 26)
        ReplaceToolStripMenuItem.Text = "&Replace..."
        ' 
        ' GoToToolStripMenuItem
        ' 
        GoToToolStripMenuItem.Name = "GoToToolStripMenuItem"
        GoToToolStripMenuItem.Size = New Size(201, 26)
        GoToToolStripMenuItem.Text = "&Go To..."
        ' 
        ' ToolStripSeparator5
        ' 
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ToolStripSeparator5.Size = New Size(198, 6)
        ' 
        ' SelectAllToolStripMenuItem
        ' 
        SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        SelectAllToolStripMenuItem.Size = New Size(201, 26)
        SelectAllToolStripMenuItem.Text = "&Select All"
        ' 
        ' InsertDateTimeToolStripMenuItem
        ' 
        InsertDateTimeToolStripMenuItem.Name = "InsertDateTimeToolStripMenuItem"
        InsertDateTimeToolStripMenuItem.Size = New Size(201, 26)
        InsertDateTimeToolStripMenuItem.Text = "Insert Date &Time"
        ' 
        ' FormatToolStripMenuItem
        ' 
        FormatToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {WordWrapToolStripMenuItem, FontToolStripMenuItem})
        FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        FormatToolStripMenuItem.Size = New Size(70, 24)
        FormatToolStripMenuItem.Text = "Format"
        ' 
        ' WordWrapToolStripMenuItem
        ' 
        WordWrapToolStripMenuItem.Checked = True
        WordWrapToolStripMenuItem.CheckState = CheckState.Checked
        WordWrapToolStripMenuItem.Name = "WordWrapToolStripMenuItem"
        WordWrapToolStripMenuItem.Size = New Size(165, 26)
        WordWrapToolStripMenuItem.Text = "&Word wrap"
        ' 
        ' FontToolStripMenuItem
        ' 
        FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        FontToolStripMenuItem.Size = New Size(165, 26)
        FontToolStripMenuItem.Text = "F&ont"
        ' 
        ' ViewToolStripMenuItem
        ' 
        ViewToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {StatusBarToolStripMenuItem})
        ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        ViewToolStripMenuItem.Size = New Size(55, 24)
        ViewToolStripMenuItem.Text = "View"
        ' 
        ' StatusBarToolStripMenuItem
        ' 
        StatusBarToolStripMenuItem.Checked = True
        StatusBarToolStripMenuItem.CheckState = CheckState.Checked
        StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        StatusBarToolStripMenuItem.Size = New Size(158, 26)
        StatusBarToolStripMenuItem.Text = "&Status bar"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HelpToolStripMenuItem, ToolStripSeparator6, AboutNotepadKuToolStripMenuItem})
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(64, 24)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(213, 26)
        HelpToolStripMenuItem.Text = "&Help..."
        ' 
        ' ToolStripSeparator6
        ' 
        ToolStripSeparator6.Name = "ToolStripSeparator6"
        ToolStripSeparator6.Size = New Size(210, 6)
        ' 
        ' AboutNotepadKuToolStripMenuItem
        ' 
        AboutNotepadKuToolStripMenuItem.Name = "AboutNotepadKuToolStripMenuItem"
        AboutNotepadKuToolStripMenuItem.Size = New Size(213, 26)
        AboutNotepadKuToolStripMenuItem.Text = "About NotepadKu"
        ' 
        ' statusStrip1
        ' 
        statusStrip1.ImageScalingSize = New Size(20, 20)
        statusStrip1.Items.AddRange(New ToolStripItem() {toolStripStatusReady, toolStripStatusLine, insertStripStatus, capsStripStatus, numStripStatus})
        statusStrip1.Location = New Point(0, 420)
        statusStrip1.Name = "statusStrip1"
        statusStrip1.Size = New Size(800, 30)
        statusStrip1.TabIndex = 1
        statusStrip1.Text = "StatusStrip1"
        ' 
        ' toolStripStatusReady
        ' 
        toolStripStatusReady.Name = "toolStripStatusReady"
        toolStripStatusReady.Size = New Size(53, 24)
        toolStripStatusReady.Text = "Ready."
        ' 
        ' toolStripStatusLine
        ' 
        toolStripStatusLine.BorderSides = ToolStripStatusLabelBorderSides.Left Or ToolStripStatusLabelBorderSides.Right
        toolStripStatusLine.BorderStyle = Border3DStyle.Etched
        toolStripStatusLine.Name = "toolStripStatusLine"
        toolStripStatusLine.Size = New Size(55, 24)
        toolStripStatusLine.Text = "Line: 1"
        ' 
        ' insertStripStatus
        ' 
        insertStripStatus.BorderSides = ToolStripStatusLabelBorderSides.Right
        insertStripStatus.BorderStyle = Border3DStyle.Etched
        insertStripStatus.Enabled = False
        insertStripStatus.Name = "insertStripStatus"
        insertStripStatus.Size = New Size(36, 24)
        insertStripStatus.Text = "INS"
        ' 
        ' capsStripStatus
        ' 
        capsStripStatus.BorderSides = ToolStripStatusLabelBorderSides.Right
        capsStripStatus.BorderStyle = Border3DStyle.Etched
        capsStripStatus.Enabled = False
        capsStripStatus.Name = "capsStripStatus"
        capsStripStatus.Size = New Size(48, 24)
        capsStripStatus.Text = "CAPS"
        ' 
        ' numStripStatus
        ' 
        numStripStatus.BorderSides = ToolStripStatusLabelBorderSides.Right
        numStripStatus.BorderStyle = Border3DStyle.Etched
        numStripStatus.Enabled = False
        numStripStatus.Name = "numStripStatus"
        numStripStatus.Size = New Size(47, 24)
        numStripStatus.Text = "NUM"
        ' 
        ' openFileDialog1
        ' 
        openFileDialog1.DefaultExt = "*.txt"
        openFileDialog1.FileName = "Untitled"
        openFileDialog1.Filter = "Text File | *.txt | All Files | *.*"
        openFileDialog1.Title = "Open File Text"
        ' 
        ' printDialog1
        ' 
        printDialog1.UseEXDialog = True
        ' 
        ' pageSetupDialog1
        ' 
        pageSetupDialog1.EnableMetric = True
        ' 
        ' saveFileDialog1
        ' 
        saveFileDialog1.DefaultExt = "*.txt"
        saveFileDialog1.FileName = "Untitled.txt"
        saveFileDialog1.Filter = "Text File | *.txt | All Files | *.*"
        saveFileDialog1.Title = "Save File Text as"
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' txtNotepad
        ' 
        txtNotepad.AcceptsReturn = True
        txtNotepad.AcceptsTab = True
        txtNotepad.AllowDrop = True
        txtNotepad.Dock = DockStyle.Fill
        txtNotepad.Location = New Point(0, 28)
        txtNotepad.Multiline = True
        txtNotepad.Name = "txtNotepad"
        txtNotepad.ScrollBars = ScrollBars.Both
        txtNotepad.Size = New Size(800, 392)
        txtNotepad.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtNotepad)
        Controls.Add(statusStrip1)
        Controls.Add(menuStrip1)
        KeyPreview = True
        MainMenuStrip = menuStrip1
        Name = "Form1"
        Text = "NotepadKu"
        menuStrip1.ResumeLayout(False)
        menuStrip1.PerformLayout()
        statusStrip1.ResumeLayout(False)
        statusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents menuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents statusStrip1 As StatusStrip
    Friend WithEvents toolStripStatusReady As ToolStripStatusLabel
    Friend WithEvents openFileDialog1 As OpenFileDialog
    Friend WithEvents fontDialog1 As FontDialog
    Friend WithEvents printDialog1 As PrintDialog
    Friend WithEvents pageSetupDialog1 As PageSetupDialog
    Friend WithEvents saveFileDialog1 As SaveFileDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents toolStripStatusLine As ToolStripStatusLabel
    Friend WithEvents insertStripStatus As ToolStripStatusLabel
    Friend WithEvents capsStripStatus As ToolStripStatusLabel
    Friend WithEvents numStripStatus As ToolStripStatusLabel
    Friend WithEvents newToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PageSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindNextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReplaceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GoToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertDateTimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordWrapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutNotepadKuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents txtNotepad As TextBox

End Class
