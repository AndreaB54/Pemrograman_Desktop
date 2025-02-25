<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        btnSave = New Button()
        btnBrowse = New Button()
        txtDesc = New TextBox()
        txtPath = New TextBox()
        txtName = New TextBox()
        lblDesc = New Label()
        lblPath = New Label()
        lblName = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(641, 168)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(124, 108)
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(539, 385)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(85, 27)
        btnSave.TabIndex = 16
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(648, 106)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(85, 27)
        btnBrowse.TabIndex = 15
        btnBrowse.Text = "..."
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' txtDesc
        ' 
        txtDesc.Location = New Point(174, 168)
        txtDesc.Multiline = True
        txtDesc.Name = "txtDesc"
        txtDesc.Size = New Size(450, 200)
        txtDesc.TabIndex = 14
        ' 
        ' txtPath
        ' 
        txtPath.Location = New Point(174, 106)
        txtPath.Name = "txtPath"
        txtPath.Size = New Size(450, 27)
        txtPath.TabIndex = 13
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(174, 38)
        txtName.Name = "txtName"
        txtName.Size = New Size(450, 27)
        txtName.TabIndex = 12
        ' 
        ' lblDesc
        ' 
        lblDesc.AutoSize = True
        lblDesc.Font = New Font("Segoe UI", 12F)
        lblDesc.Location = New Point(35, 167)
        lblDesc.Name = "lblDesc"
        lblDesc.Size = New Size(121, 28)
        lblDesc.TabIndex = 11
        lblDesc.Text = "Description :"
        ' 
        ' lblPath
        ' 
        lblPath.AutoSize = True
        lblPath.Font = New Font("Segoe UI", 12F)
        lblPath.Location = New Point(35, 102)
        lblPath.Name = "lblPath"
        lblPath.Size = New Size(59, 28)
        lblPath.TabIndex = 10
        lblPath.Text = "Path :"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 12F)
        lblName.Location = New Point(35, 38)
        lblName.Name = "lblName"
        lblName.Size = New Size(73, 28)
        lblName.TabIndex = 9
        lblName.Text = "Name :"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.DefaultExt = "exe"
        OpenFileDialog1.FileName = "Executable Program"
        OpenFileDialog1.Filter = "EXE|*.exe"
        OpenFileDialog1.Title = "Open Exe File"
        ' 
        ' Edit
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
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
        Name = "Edit"
        Text = "Edit"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtPath As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblPath As Label
    Friend WithEvents lblName As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
