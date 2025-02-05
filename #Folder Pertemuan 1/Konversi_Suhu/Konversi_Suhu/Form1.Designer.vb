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
        btnConvert = New Button()
        lblCelcius = New Label()
        txtCelcius = New TextBox()
        btnKeluar = New Button()
        lblFahrenheit = New Label()
        lblReamur = New Label()
        lblKelvin = New Label()
        txtFahrenheit = New TextBox()
        txtReamur = New TextBox()
        txtKelvin = New TextBox()
        SuspendLayout()
        ' 
        ' btnConvert
        ' 
        btnConvert.Font = New Font("Segoe UI", 12.0F)
        btnConvert.Location = New Point(390, 57)
        btnConvert.Margin = New Padding(3, 4, 3, 4)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(101, 39)
        btnConvert.TabIndex = 0
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' lblCelcius
        ' 
        lblCelcius.AutoSize = True
        lblCelcius.Font = New Font("Segoe UI", 12.0F)
        lblCelcius.Location = New Point(14, 60)
        lblCelcius.Name = "lblCelcius"
        lblCelcius.Size = New Size(72, 28)
        lblCelcius.TabIndex = 1
        lblCelcius.Text = "Celcius"
        ' 
        ' txtCelcius
        ' 
        txtCelcius.Font = New Font("Segoe UI", 12.0F)
        txtCelcius.Location = New Point(98, 57)
        txtCelcius.Margin = New Padding(3, 4, 3, 4)
        txtCelcius.Name = "txtCelcius"
        txtCelcius.Size = New Size(262, 34)
        txtCelcius.TabIndex = 2
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Font = New Font("Segoe UI", 12.0F)
        btnKeluar.Location = New Point(506, 57)
        btnKeluar.Margin = New Padding(3, 4, 3, 4)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(101, 39)
        btnKeluar.TabIndex = 3
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' lblFahrenheit
        ' 
        lblFahrenheit.AutoSize = True
        lblFahrenheit.Font = New Font("Segoe UI", 12.0F)
        lblFahrenheit.Location = New Point(27, 163)
        lblFahrenheit.Name = "lblFahrenheit"
        lblFahrenheit.Size = New Size(103, 28)
        lblFahrenheit.TabIndex = 4
        lblFahrenheit.Text = "Fahrenheit"
        ' 
        ' lblReamur
        ' 
        lblReamur.AutoSize = True
        lblReamur.Font = New Font("Segoe UI", 12.0F)
        lblReamur.Location = New Point(162, 163)
        lblReamur.Name = "lblReamur"
        lblReamur.Size = New Size(78, 28)
        lblReamur.TabIndex = 5
        lblReamur.Text = "Reamur"
        ' 
        ' lblKelvin
        ' 
        lblKelvin.AutoSize = True
        lblKelvin.Font = New Font("Segoe UI", 12.0F)
        lblKelvin.Location = New Point(416, 163)
        lblKelvin.Name = "lblKelvin"
        lblKelvin.Size = New Size(65, 28)
        lblKelvin.TabIndex = 6
        lblKelvin.Text = "Kelvin"
        ' 
        ' txtFahrenheit
        ' 
        txtFahrenheit.Font = New Font("Segoe UI", 12.0F)
        txtFahrenheit.Location = New Point(27, 224)
        txtFahrenheit.Margin = New Padding(3, 4, 3, 4)
        txtFahrenheit.Name = "txtFahrenheit"
        txtFahrenheit.Size = New Size(94, 34)
        txtFahrenheit.TabIndex = 7
        ' 
        ' txtReamur
        ' 
        txtReamur.Font = New Font("Segoe UI", 12.0F)
        txtReamur.Location = New Point(151, 224)
        txtReamur.Margin = New Padding(3, 4, 3, 4)
        txtReamur.Name = "txtReamur"
        txtReamur.Size = New Size(197, 34)
        txtReamur.TabIndex = 8
        ' 
        ' txtKelvin
        ' 
        txtKelvin.Font = New Font("Segoe UI", 12.0F)
        txtKelvin.Location = New Point(395, 224)
        txtKelvin.Margin = New Padding(3, 4, 3, 4)
        txtKelvin.Name = "txtKelvin"
        txtKelvin.Size = New Size(94, 34)
        txtKelvin.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(619, 367)
        Controls.Add(txtKelvin)
        Controls.Add(txtReamur)
        Controls.Add(txtFahrenheit)
        Controls.Add(lblKelvin)
        Controls.Add(lblReamur)
        Controls.Add(lblFahrenheit)
        Controls.Add(btnKeluar)
        Controls.Add(txtCelcius)
        Controls.Add(lblCelcius)
        Controls.Add(btnConvert)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Temperature Converter"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnConvert As Button
    Friend WithEvents lblCelcius As Label
    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents btnKeluar As Button
    Friend WithEvents lblFahrenheit As Label
    Friend WithEvents lblReamur As Label
    Friend WithEvents lblKelvin As Label
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents txtReamur As TextBox
    Friend WithEvents txtKelvin As TextBox

End Class
