Imports System.IO
Imports System.Drawing.Imaging
Imports gma.Drawing.ImageInfo
Imports System.Net.Mime.MediaTypeNames

Public Class Form1

    ' Format ukuran file menjadi string yang lebih mudah dibaca
    Private Function FormatFileSize(ByVal FileSizeBytes As Long) As String
        Dim sizeTypes() As String = {"b", "Kb", "Mb", "Gb"}
        Dim Len As Decimal = FileSizeBytes
        Dim sizeType As Integer = 0

        Do While Len > 1024
            Len = Decimal.Round(Len / 1024, 2)
            sizeType += 1
            If sizeType >= sizeTypes.Length - 1 Then Exit Do
        Loop

        Return Len.ToString() & " " & sizeTypes(sizeType)
    End Function

    ' Mengambil file dari direktori yang ditentukan
    Private Sub GetFiles(ByVal PathName As String)
        Dim LItem As ListViewItem
        lvlmage.Items.Clear()
        lvlmage.BeginUpdate()

        For Each nFile As String In Directory.GetFiles(PathName)
            Dim sExtension As String = Path.GetExtension(nFile).ToLower()
            Dim f As FileInfo = New FileInfo(nFile)

            If (sExtension = ".bmp" Or sExtension = ".jpg" Or sExtension = ".jpeg" Or sExtension = ".gif" Or sExtension = ".png") Then
                LItem = New ListViewItem()
                Dim iconForFile As Icon = SystemIcons.WinLogo

                ' Menambahkan ikon file ke ImageList jika belum ada
                If Not (imageList1.Images.ContainsKey(sExtension)) Then
                    iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(nFile)
                    imageList1.Images.Add(sExtension, iconForFile)
                End If

                With LItem
                    .Text = Path.GetFileNameWithoutExtension(nFile)
                    .SubItems.Add(sExtension)
                    .SubItems.Add(FormatFileSize(f.Length))
                    .SubItems.Add(f.LastWriteTime.ToString())
                    .SubItems.Add(f.LastAccessTime.ToString())
                    .SubItems.Add(f.CreationTime.ToString())
                    .SubItems.Add(f.Attributes.ToString())
                    .ImageKey = sExtension
                    .Tag = Path.Combine(PathName, nFile)
                End With

                lvlmage.Items.Add(LItem)
            End If
        Next

        lvlmage.EndUpdate()
        lvlmage.Columns(0).Width = -2
    End Sub

    ' Mengambil folder dari direktori yang ditentukan
    Private Sub GetFolders(ByVal PathName As TreeNode)
        Dim di As DirectoryInfo
        PathName.Nodes.Clear()
        di = New DirectoryInfo(PathName.Tag)

        Try
            For Each nFolder In di.GetDirectories()
                Dim tNode As New TreeNode()
                With tNode
                    .ImageIndex = 1
                    .SelectedImageIndex = 1
                    .Tag = nFolder.FullName
                    .Text = nFolder.Name
                    .Nodes.Add("") ' Placeholder untuk node anak
                End With

                ' Hanya tambahkan folder jika tidak tersembunyi
                If (di.Attributes And FileAttributes.Hidden) = False Then
                    PathName.Nodes.Add(tNode)
                End If
            Next
        Catch ex As Exception
            ' Tangani kesalahan jika perlu
        End Try
    End Sub

    ' Mengambil semua drive yang tersedia
    Private Sub GetDrives()
        For Each Drive In DriveInfo.GetDrives()
            If (Drive.IsReady) Then
                Dim dName As String = Drive.VolumeLabel
                If String.IsNullOrEmpty(dName) Then
                    dName = Drive.Name
                End If

                Dim tNode As New TreeNode()
                With tNode
                    .ImageIndex = 0
                    .SelectedImageIndex = 0
                    .Text = dName
                    .Nodes.Add("") ' Placeholder untuk node anak
                    .Tag = Drive.Name
                End With

                tvDrive.Nodes.Add(tNode)
            End If
        Next
    End Sub

    ' Mendapatkan format raw dari gambar
    Function GetRaw(ByVal imgf As ImageFormat) As String
        If imgf.Equals(ImageFormat.Bmp) Then
            Return "Bitmap"
        ElseIf imgf.Equals(ImageFormat.Jpeg) Then
            Return "Jpeg"
        ElseIf imgf.Equals(ImageFormat.Png) Then
            Return "PNG"
        ElseIf imgf.Equals(ImageFormat.Tiff) Then
            Return "TIFF"
        ElseIf imgf.Equals(ImageFormat.Gif) Then
            Return "GIF"
        ElseIf imgf.Equals(ImageFormat.Icon) Then
            Return "ICON"
        End If
        Return "Unknown"
    End Function

    ' Event saat form dimuat
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GetDrives()
        lvlmage.Columns(0).Width = -2
        SplitContainerBawah2.Panel2.VerticalScroll.Visible = True
        SplitContainerBawah2.Panel2.HorizontalScroll.Visible = True
    End Sub

    ' Event saat node tree view sebelum diperluas
    Private Sub tvDrive_BeforeExpand(sender As System.Object, e As System.Windows.Forms.TreeViewCancelEventArgs) Handles tvDrive.BeforeExpand
        GetFolders(e.Node)
    End Sub

    ' Event saat node tree view dipilih
    Private Sub tvDrive_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles tvDrive.AfterSelect
        GetFiles(e.Node.Tag)
    End Sub

    ' Event saat item list view dipilih
    Private Sub lvlmage_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvlmage.SelectedIndexChanged
        Dim _exif As Info
        lvExif.Items.Clear()

        If lvlmage.SelectedItems.Count > 0 Then
            PictureBox1.Image = Bitmap.FromFile(lvlmage.SelectedItems(0).Tag.ToString())
            toolStripStatusReady.Text = lvlmage.SelectedItems(0).Tag.ToString()
            toolStripStatusDimension.Text = "Dimension: " & PictureBox1.Image.Size.Width.ToString() & " px X " & PictureBox1.Image.Size.Height.ToString() & " px"
            toolStripStatusBits.Text = "Depth: " & PictureBox1.Image.PixelFormat.ToString()
            toolStripStatusResolution.Text = "Resolution: " & PictureBox1.Image.HorizontalResolution.ToString() & " dpi X " & PictureBox1.Image.VerticalResolution.ToString() & " dpi"
            toolStripStatusRawFormat.Text = "Compression: " & GetRaw(PictureBox1.Image.RawFormat)

            _exif = New Info(lvlmage.SelectedItems(0).Tag.ToString())
            PropertyGrid1.SelectedObject = _exif

            For Each propertyName As String In _exif.PropertyItems.Keys
                Try
                    Dim LItem As ListViewItem = New ListViewItem()
                    LItem.SubItems(0).Text = propertyName
                    LItem.SubItems.Add(_exif.PropertyItems(propertyName).ToString())
                    lvExif.Items.Add(LItem)
                Catch eks As Exception
                    ' Tangani kesalahan jika perlu
                End Try
            Next
        End If

        lvlmage.Columns(0).Width = -2
        lvExif.Columns(0).Width = -2
    End Sub

    ' Event saat item list view di-double click
    Private Sub lvlmage_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvlmage.DoubleClick
        Process.Start(lvlmage.SelectedItems(0).Tag.ToString())
    End Sub

    ' Event saat PictureBox di-double click
    Private Sub PictureBox1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles PictureBox1.DoubleClick
        Dim pb As New PictureBox
        pb.Image = System.Drawing.Image.FromFile(toolStripStatusReady.Text) ' Fully qualify Image
        pb.SizeMode = PictureBoxSizeMode.AutoSize

        Dim pnl As New Panel
        pnl.AutoScroll = True
        pnl.Dock = DockStyle.Fill
        pnl.Controls.Add(pb)

        Dim f As New Form
        f.WindowState = FormWindowState.Maximized
        f.Controls.Add(pnl)
        f.Show()
    End Sub

End Class