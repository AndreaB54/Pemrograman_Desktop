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
        Label1 = New Label()
        txtBasis10 = New TextBox()
        btnConvert = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtBasis2 = New TextBox()
        txtBasis8 = New TextBox()
        txtBasis16 = New TextBox()
        txtDecimal = New TextBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(114, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 20)
        Label1.TabIndex = 0
        Label1.Text = "Konversi Basis Bilangan 10"
        ' 
        ' txtBasis10
        ' 
        txtBasis10.Location = New Point(122, 60)
        txtBasis10.Margin = New Padding(3, 4, 3, 4)
        txtBasis10.Name = "txtBasis10"
        txtBasis10.Size = New Size(153, 27)
        txtBasis10.TabIndex = 1
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(137, 119)
        btnConvert.Margin = New Padding(3, 4, 3, 4)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(123, 35)
        btnConvert.TabIndex = 2
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(38, 207)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 20)
        Label2.TabIndex = 3
        Label2.Text = "Biner (Basis 2)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(38, 265)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 20)
        Label3.TabIndex = 4
        Label3.Text = "Octal (Basis 8)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(38, 380)
        Label4.Name = "Label4"
        Label4.Size = New Size(163, 20)
        Label4.TabIndex = 5
        Label4.Text = "Hexadecimal (Basis 16)"
        ' 
        ' txtBasis2
        ' 
        txtBasis2.Location = New Point(211, 199)
        txtBasis2.Margin = New Padding(3, 4, 3, 4)
        txtBasis2.Name = "txtBasis2"
        txtBasis2.Size = New Size(137, 27)
        txtBasis2.TabIndex = 6
        ' 
        ' txtBasis8
        ' 
        txtBasis8.Location = New Point(213, 257)
        txtBasis8.Margin = New Padding(3, 4, 3, 4)
        txtBasis8.Name = "txtBasis8"
        txtBasis8.Size = New Size(137, 27)
        txtBasis8.TabIndex = 7
        ' 
        ' txtBasis16
        ' 
        txtBasis16.Location = New Point(213, 373)
        txtBasis16.Margin = New Padding(3, 4, 3, 4)
        txtBasis16.Name = "txtBasis16"
        txtBasis16.Size = New Size(137, 27)
        txtBasis16.TabIndex = 8
        ' 
        ' txtDecimal
        ' 
        txtDecimal.Location = New Point(211, 317)
        txtDecimal.Margin = New Padding(3, 4, 3, 4)
        txtDecimal.Name = "txtDecimal"
        txtDecimal.Size = New Size(137, 27)
        txtDecimal.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(36, 324)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 20)
        Label5.TabIndex = 9
        Label5.Text = "Decimal (Basis 10)"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(413, 422)
        Controls.Add(txtDecimal)
        Controls.Add(Label5)
        Controls.Add(txtBasis16)
        Controls.Add(txtBasis8)
        Controls.Add(txtBasis2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnConvert)
        Controls.Add(txtBasis10)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Konversi Basis Bilangan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBasis10 As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBasis2 As TextBox
    Friend WithEvents txtBasis8 As TextBox
    Friend WithEvents txtBasis16 As TextBox
    Friend WithEvents txtDecimal As TextBox
    Friend WithEvents Label5 As Label

End Class
