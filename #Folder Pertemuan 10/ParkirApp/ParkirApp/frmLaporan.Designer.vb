<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaporan
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
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'btnLaporan
        '
        Me.btnLaporan.Location = New System.Drawing.Point(72, 418)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(75, 30)
        Me.btnLaporan.TabIndex = 1
        Me.btnLaporan.Text = "Laporan"
        Me.btnLaporan.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(820, 418)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(75, 30)
        Me.btnTutup.TabIndex = 2
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ParkirApp.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(949, 411)
        Me.ReportViewer1.TabIndex = 3
        '
        'frmLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnLaporan)
        Me.Name = "frmLaporan"
        Me.Text = "Form Laporan"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLaporan As Button
    Friend WithEvents btnTutup As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
