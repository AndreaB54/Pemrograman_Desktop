<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddNew
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        lblName = New Label()
        lblPath = New Label()
        lblDesc = New Label()
        txtName = New TextBox()
        txtPath = New TextBox()
        txtDesc = New TextBox()
        btnBrowse = New Button()
        btnSave = New Button()
        PictureBox1 = New PictureBox()
        ToolTip1 = New ToolTip(components)
        ContextMenuStrip1 = New ContextMenuStrip(components)
        EditToolStripMenuItem = New ToolStripMenuItem()
        DeleteToolStripMenuItem = New ToolStripMenuItem()
        OpenFileDialog1 = New OpenFileDialog()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        ContextMenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 12.0F)
        lblName.Location = New Point(58, 41)
        lblName.Name = "lblName"
        lblName.Size = New Size(73, 28)
        lblName.TabIndex = 0
        lblName.Text = "Name :"
        ' 
        ' lblPath
        ' 
        lblPath.AutoSize = True
        lblPath.Font = New Font("Segoe UI", 12.0F)
        lblPath.Location = New Point(58, 105)
        lblPath.Name = "lblPath"
        lblPath.Size = New Size(59, 28)
        lblPath.TabIndex = 1
        lblPath.Text = "Path :"
        ' 
        ' lblDesc
        ' 
        lblDesc.AutoSize = True
        lblDesc.Font = New Font("Segoe UI", 12.0F)
        lblDesc.Location = New Point(58, 170)
        lblDesc.Name = "lblDesc"
        lblDesc.Size = New Size(121, 28)
        lblDesc.TabIndex = 2
        lblDesc.Text = "Description :"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(197, 41)
        txtName.Name = "txtName"
        txtName.Size = New Size(450, 27)
        txtName.TabIndex = 3
        ' 
        ' txtPath
        ' 
        txtPath.Location = New Point(197, 109)
        txtPath.Name = "txtPath"
        txtPath.Size = New Size(450, 27)
        txtPath.TabIndex = 4
        ' 
        ' txtDesc
        ' 
        txtDesc.Location = New Point(197, 171)
        txtDesc.Multiline = True
        txtDesc.Name = "txtDesc"
        txtDesc.Size = New Size(450, 200)
        txtDesc.TabIndex = 5
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(671, 109)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(85, 27)
        btnBrowse.TabIndex = 6
        btnBrowse.Text = "..."
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(562, 388)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(85, 27)
        btnSave.TabIndex = 7
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(664, 171)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(124, 108)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' ToolTip1
        ' 
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {EditToolStripMenuItem, DeleteToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(123, 52)
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(122, 24)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' DeleteToolStripMenuItem
        ' 
        DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        DeleteToolStripMenuItem.Size = New Size(122, 24)
        DeleteToolStripMenuItem.Text = "Delete"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.DefaultExt = "exe"
        OpenFileDialog1.FileName = "Executable Program"
        OpenFileDialog1.Filter = "EXE Files|*.exe"
        OpenFileDialog1.Title = "Open Exe File"
        ' 
        ' AddNew
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(btnSave)
        Controls.Add(btnBrowse)
        Controls.Add(txtDesc)
        Controls.Add(txtPath)
        Controls.Add(txtName)
        Controls.Add(lblDesc)
        Controls.Add(lblPath)
        Controls.Add(lblName)
        Name = "AddNew"
        Text = "Add New"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ContextMenuStrip1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblPath As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPath As TextBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
End Class