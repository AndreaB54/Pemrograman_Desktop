Imports System.Reflection

Public Class AddNew
    Public Sub RefreshSemua()
        Dim myinifile2 As IniFile = New IniFile()
        myinifile2.Load(Application.StartupPath & "\ShortcutLauncher.ini")
        Dim i As Integer = -1
        Dim j As Integer = 0
        For Each ctl As Control In Form1.Controls
            If TypeOf (ctl) Is Button Then
                Form1.Controls.Remove(ctl)
            End If
        Next
        For Each satuan As IniFile.IniSection In myinifile2.Sections
            i = i + 1
            If i = 3 Then
                j = j + 1
                i = 0
            End If
            Dim btn As New Button
            Form1.Controls.Add(btn)
            btn.Width = 100
            btn.Height = 100
            btn.TextImageRelation = TextImageRelation.ImageAboveText
            btn.Location = New Point(32 + i * 115, 50 + j * 120)
            btn.Name = "Btn" & (i + j).ToString
            btn.Visible = True
            btn.Image = System.Drawing.Icon.ExtractAssociatedIcon(satuan.GetKey("Path").Value).ToBitmap
            btn.Text = satuan.GetKey("Name").Value
            ToolTip1.SetToolTip(btn, satuan.GetKey("Path").Value & vbCrLf & satuan.GetKey("Desc").Value)
            ToolTip1.ToolTipTitle = "Information"
            btn.ContextMenuStrip = ContextMenuStrip1
            btn.Tag = satuan.GetKey("Path").Value
            AddHandler btn.Click, AddressOf btnClick
        Next
    End Sub


    Private Sub AddNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim myinifile As IniFile = New IniFile()
        myinifile.Load(Application.StartupPath & "\ShortcutLauncher.ini", True)
        myinifile.AddSection(txtPath.Text)
        myinifile.SetKeyValue(txtPath.Text, "Name", txtName.Text)
        myinifile.SetKeyValue(txtPath.Text, "Path", txtPath.Text)
        myinifile.SetKeyValue(txtPath.Text, "Desc", txtDesc.Text)
        myinifile.Save(Application.StartupPath & "\ShortcutLauncher.ini")
        RefreshSemua()
        Form1.Refresh()
        Me.Hide()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtPath.Text = OpenFileDialog1.FileName
            PictureBox1.Image = System.Drawing.Icon.ExtractAssociatedIcon(txtPath.Text).ToBitmap
        End If
    End Sub

    Private Sub btnClick(sender As Object, e As EventArgs)
        Process.Start(sender.tag)
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim menuItem As ToolStripItem = TryCast(sender, ToolStripItem)
        If menuItem IsNot Nothing Then
            Dim owner As ContextMenuStrip = TryCast(menuItem.Owner, ContextMenuStrip)
            If owner IsNot Nothing Then
                Dim sourceControl As Control = owner.SourceControl
                Edit.PrimaryKey = sourceControl.Tag
                Edit.ShowDialog()
            End If
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim menuItem As ToolStripItem = TryCast(sender, ToolStripItem)
        If menuItem IsNot Nothing Then
            Dim owner As ContextMenuStrip = TryCast(menuItem.Owner, ContextMenuStrip)
            If owner IsNot Nothing Then
                Dim sourceControl As Control = owner.SourceControl
                Dim myinifile3 As IniFile = New IniFile()
                myinifile3.Load(Application.StartupPath & "\ShortcutLauncher.ini")
                myinifile3.RemoveSection(sourceControl.Tag)
                myinifile3.Save(Application.StartupPath & "\ShortcutLauncher.ini")
                RefreshSemua()
            End If
        End If
    End Sub
End Class