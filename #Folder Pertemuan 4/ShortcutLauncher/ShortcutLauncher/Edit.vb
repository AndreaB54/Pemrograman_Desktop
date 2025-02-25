Public Class Edit
    Public PrimaryKey As String

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim myinifile As IniFile = New IniFile()
        myinifile.Load(Application.StartupPath & "\ShortcutLauncher.ini", True)
        myinifile.AddSection(txtPath.Text)
        myinifile.SetKeyValue(txtPath.Text, "Name", txtName.Text)
        myinifile.SetKeyValue(txtPath.Text, "Path", txtPath.Text)
        myinifile.SetKeyValue(txtPath.Text, "Desc", txtDesc.Text)
        myinifile.Save(Application.StartupPath & "\ShortcutLauncher.ini")
        AddNew.RefreshSemua()
        Form1.Refresh()
        Me.Hide()
    End Sub

    Private Sub Edit_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Dim myinifile As IniFile = New IniFile()
        myinifile.Load(Application.StartupPath & "\ShortcutLauncher.ini", True)
        Dim hasil As IniFile.IniSection = myinifile.GetSection(PrimaryKey)
        txtName.Text = hasil.GetKey("Name").Value
        txtPath.Text = PrimaryKey
        txtDesc.Text = hasil.GetKey("Desc").Value
        PictureBox1.Image = System.Drawing.Icon.ExtractAssociatedIcon(txtPath.Text).ToBitmap
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtPath.Text = OpenFileDialog1.FileName
        End If
    End Sub
End Class