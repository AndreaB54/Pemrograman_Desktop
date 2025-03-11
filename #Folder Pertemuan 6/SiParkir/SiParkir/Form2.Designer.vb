<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        lblUsername = New Label()
        lblNewPass = New Label()
        tbUsername = New TextBox()
        tbNewPassword = New TextBox()
        btnSimpan = New Button()
        btnTutup = New Button()
        tbConfirmPass = New TextBox()
        lblConfirmPass = New Label()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 12F)
        lblUsername.Location = New Point(52, 51)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(99, 28)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username"
        ' 
        ' lblNewPass
        ' 
        lblNewPass.AutoSize = True
        lblNewPass.Font = New Font("Segoe UI", 12F)
        lblNewPass.Location = New Point(52, 105)
        lblNewPass.Name = "lblNewPass"
        lblNewPass.Size = New Size(137, 28)
        lblNewPass.TabIndex = 1
        lblNewPass.Text = "Password Baru"
        ' 
        ' tbUsername
        ' 
        tbUsername.Location = New Point(195, 52)
        tbUsername.Name = "tbUsername"
        tbUsername.ReadOnly = True
        tbUsername.Size = New Size(247, 27)
        tbUsername.TabIndex = 2
        ' 
        ' tbNewPassword
        ' 
        tbNewPassword.Location = New Point(195, 109)
        tbNewPassword.Name = "tbNewPassword"
        tbNewPassword.Size = New Size(247, 27)
        tbNewPassword.TabIndex = 3
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.SkyBlue
        btnSimpan.Location = New Point(250, 191)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 4
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnTutup
        ' 
        btnTutup.BackColor = Color.SkyBlue
        btnTutup.Location = New Point(350, 191)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(94, 29)
        btnTutup.TabIndex = 5
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = False
        ' 
        ' tbConfirmPass
        ' 
        tbConfirmPass.Location = New Point(195, 158)
        tbConfirmPass.Name = "tbConfirmPass"
        tbConfirmPass.Size = New Size(247, 27)
        tbConfirmPass.TabIndex = 7
        ' 
        ' lblConfirmPass
        ' 
        lblConfirmPass.AutoSize = True
        lblConfirmPass.Font = New Font("Segoe UI", 12F)
        lblConfirmPass.Location = New Point(52, 154)
        lblConfirmPass.Name = "lblConfirmPass"
        lblConfirmPass.Size = New Size(93, 28)
        lblConfirmPass.TabIndex = 6
        lblConfirmPass.Text = "Ketik lagi"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCoral
        ClientSize = New Size(509, 284)
        Controls.Add(tbConfirmPass)
        Controls.Add(lblConfirmPass)
        Controls.Add(btnTutup)
        Controls.Add(btnSimpan)
        Controls.Add(tbNewPassword)
        Controls.Add(tbUsername)
        Controls.Add(lblNewPass)
        Controls.Add(lblUsername)
        Name = "Form2"
        Text = "SIParkir - Ubah Profil"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblNewPass As Label
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents tbNewPassword As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnTutup As Button
    Friend WithEvents tbConfirmPass As TextBox
    Friend WithEvents lblConfirmPass As Label

End Class
