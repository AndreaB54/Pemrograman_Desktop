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
        Button1 = New Button()
        lblSatu = New Label()
        lblDua = New Label()
        lblTiga = New Label()
        lblStatus = New Label()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        Timer3 = New Timer(components)
        Timer4 = New Timer(components)
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(29, 33)
        Button1.Name = "Button1"
        Button1.Size = New Size(110, 36)
        Button1.TabIndex = 0
        Button1.Text = "Spin!"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' lblSatu
        ' 
        lblSatu.BorderStyle = BorderStyle.Fixed3D
        lblSatu.Font = New Font("Segoe UI", 24F)
        lblSatu.Location = New Point(37, 106)
        lblSatu.Name = "lblSatu"
        lblSatu.Size = New Size(149, 143)
        lblSatu.TabIndex = 1
        lblSatu.Text = "A"
        lblSatu.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDua
        ' 
        lblDua.BorderStyle = BorderStyle.Fixed3D
        lblDua.Font = New Font("Segoe UI", 24F)
        lblDua.Location = New Point(203, 106)
        lblDua.Name = "lblDua"
        lblDua.Size = New Size(149, 143)
        lblDua.TabIndex = 2
        lblDua.Text = "A"
        lblDua.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTiga
        ' 
        lblTiga.BorderStyle = BorderStyle.Fixed3D
        lblTiga.Font = New Font("Segoe UI", 24F)
        lblTiga.Location = New Point(370, 106)
        lblTiga.Name = "lblTiga"
        lblTiga.Size = New Size(149, 143)
        lblTiga.TabIndex = 3
        lblTiga.Text = "A"
        lblTiga.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblStatus
        ' 
        lblStatus.Font = New Font("Segoe UI", 12F)
        lblStatus.Location = New Point(37, 304)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(97, 29)
        lblStatus.TabIndex = 4
        lblStatus.Text = "Status"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 10
        ' 
        ' Timer2
        ' 
        Timer2.Interval = 9
        ' 
        ' Timer3
        ' 
        Timer3.Interval = 11
        ' 
        ' Timer4
        ' 
        Timer4.Interval = 1000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 354)
        Controls.Add(lblStatus)
        Controls.Add(lblTiga)
        Controls.Add(lblDua)
        Controls.Add(lblSatu)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Jackpot"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lblSatu As Label
    Friend WithEvents lblDua As Label
    Friend WithEvents lblTiga As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer

End Class
