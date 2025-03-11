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
        lblUsername = New Label()
        lblPassword = New Label()
        tbUsername = New TextBox()
        tbPassword = New TextBox()
        btnLogin = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 12F)
        lblUsername.Location = New Point(52, 82)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(99, 28)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 12F)
        lblPassword.Location = New Point(52, 136)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(93, 28)
        lblPassword.TabIndex = 1
        lblPassword.Text = "Password"
        ' 
        ' tbUsername
        ' 
        tbUsername.Location = New Point(178, 83)
        tbUsername.Name = "tbUsername"
        tbUsername.Size = New Size(264, 27)
        tbUsername.TabIndex = 2
        ' 
        ' tbPassword
        ' 
        tbPassword.Location = New Point(178, 140)
        tbPassword.Name = "tbPassword"
        tbPassword.Size = New Size(264, 27)
        tbPassword.TabIndex = 3
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.SkyBlue
        btnLogin.Location = New Point(250, 191)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 29)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnKeluar
        ' 
        btnKeluar.BackColor = Color.SkyBlue
        btnKeluar.Location = New Point(350, 191)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(94, 29)
        btnKeluar.TabIndex = 5
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCoral
        ClientSize = New Size(509, 284)
        Controls.Add(btnKeluar)
        Controls.Add(btnLogin)
        Controls.Add(tbPassword)
        Controls.Add(tbUsername)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Name = "Form1"
        Text = "SIParkir - Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnKeluar As Button

End Class
