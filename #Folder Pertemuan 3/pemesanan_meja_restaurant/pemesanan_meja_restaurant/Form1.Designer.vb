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
        Label2 = New Label()
        TextBox1 = New RoundedTextBox()
        TextBox2 = New RoundedTextBox()
        Label3 = New Label()
        Label4 = New Label()
        NumericUpDown1 = New NumericUpDown()
        Label5 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label6 = New Label()
        ComboBoxTime = New ComboBox()
        Label7 = New Label()
        TextBoxSpecialRequest = New RoundedTextBox()
        ButtonSubmit = New Button()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 16.0F, FontStyle.Bold)
        Label1.Location = New Point(20, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 32)
        Label1.TabIndex = 0
        Label1.Text = "Welcome,"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12.0F, FontStyle.Bold)
        Label2.Location = New Point(20, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(174, 24)
        Label2.TabIndex = 1
        Label2.Text = "Customer Name :"
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Arial", 12.0F)
        TextBox1.Location = New Point(20, 100)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(267, 30)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Arial", 12.0F)
        TextBox2.Location = New Point(20, 184)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(267, 30)
        TextBox2.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12.0F, FontStyle.Bold)
        Label3.Location = New Point(20, 154)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 24)
        Label3.TabIndex = 3
        Label3.Text = "Contact :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12.0F, FontStyle.Bold)
        Label4.Location = New Point(20, 243)
        Label4.Name = "Label4"
        Label4.Size = New Size(160, 24)
        Label4.TabIndex = 5
        Label4.Text = "Guest Number :"
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Font = New Font("Arial", 12.0F)
        NumericUpDown1.Location = New Point(20, 273)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(267, 30)
        NumericUpDown1.TabIndex = 7
        NumericUpDown1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 12.0F, FontStyle.Bold)
        Label5.Location = New Point(20, 313)
        Label5.Name = "Label5"
        Label5.Size = New Size(179, 24)
        Label5.TabIndex = 8
        Label5.Text = "Reservation Date:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Arial", 12.0F)
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(20, 343)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(267, 30)
        DateTimePicker1.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 12.0F, FontStyle.Bold)
        Label6.Location = New Point(20, 383)
        Label6.Name = "Label6"
        Label6.Size = New Size(182, 24)
        Label6.TabIndex = 10
        Label6.Text = "Reservation Time:"
        ' 
        ' ComboBoxTime
        ' 
        ComboBoxTime.Font = New Font("Arial", 12.0F)
        ComboBoxTime.FormattingEnabled = True
        ComboBoxTime.Items.AddRange(New Object() {"12:00 PM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM", "7:00 PM", "8:00 PM"})
        ComboBoxTime.Location = New Point(20, 413)
        ComboBoxTime.Name = "ComboBoxTime"
        ComboBoxTime.Size = New Size(267, 31)
        ComboBoxTime.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 12.0F, FontStyle.Bold)
        Label7.Location = New Point(20, 453)
        Label7.Name = "Label7"
        Label7.Size = New Size(169, 24)
        Label7.TabIndex = 12
        Label7.Text = "Special Request:"
        ' 
        ' TextBoxSpecialRequest
        ' 
        TextBoxSpecialRequest.BorderStyle = BorderStyle.FixedSingle
        TextBoxSpecialRequest.Font = New Font("Arial", 12.0F)
        TextBoxSpecialRequest.Location = New Point(20, 483)
        TextBoxSpecialRequest.Multiline = True
        TextBoxSpecialRequest.Name = "TextBoxSpecialRequest"
        TextBoxSpecialRequest.Size = New Size(267, 60)
        TextBoxSpecialRequest.TabIndex = 13
        ' 
        ' ButtonSubmit
        ' 
        ButtonSubmit.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        ButtonSubmit.Font = New Font("Arial", 12.0F, FontStyle.Bold)
        ButtonSubmit.Location = New Point(20, 553)
        ButtonSubmit.Name = "ButtonSubmit"
        ButtonSubmit.Size = New Size(267, 40)
        ButtonSubmit.TabIndex = 14
        ButtonSubmit.Text = "Submit Reservation"
        ButtonSubmit.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(245), CByte(255))
        ClientSize = New Size(334, 613)
        Controls.Add(ButtonSubmit)
        Controls.Add(TextBoxSpecialRequest)
        Controls.Add(Label7)
        Controls.Add(ComboBoxTime)
        Controls.Add(Label6)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label5)
        Controls.Add(NumericUpDown1)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Restaurant Reservation"
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    ' Event handler for the Submit button
    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs)
        ' Logic to handle the reservation submission
        Dim customerName As String = TextBox1.Text
        Dim contact As String = TextBox2.Text
        Dim guestNumber As Integer = CInt(NumericUpDown1.Value)
        Dim reservationDate As DateTime = DateTimePicker1.Value
        Dim reservationTime As String = ComboBoxTime.SelectedItem.ToString()
        Dim specialRequest As String = TextBoxSpecialRequest.Text

        ' Here you can add code to save the reservation details to a database or display a confirmation message
        MessageBox.Show($"Reservation for {customerName} has been made for {guestNumber} guests on {reservationDate.ToShortDateString()} at {reservationTime}." &
                        $"{Environment.NewLine}Special Request: {specialRequest}", "Reservation Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Custom TextBox with Rounded Corners
    Public Class RoundedTextBox
        Inherits TextBox

        Protected Overrides Sub OnPaint(pe As PaintEventArgs)
            Dim path As New Drawing2D.GraphicsPath()
            path.AddArc(0, 0, 20, 20, 180, 90) ' Top left corner
            path.AddArc(Width - 20, 0, 20, 20, 270, 90) ' Top right corner
            path.AddArc(0, Height - 20, 20, 20, 90, 90) ' Bottom left corner
            path.CloseFigure()
            Me.Region = New Region(path)
            MyBase.OnPaint(pe)
        End Sub
    End Class

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As RoundedTextBox
    Friend WithEvents TextBox2 As RoundedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBoxTime As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxSpecialRequest As RoundedTextBox
    Friend WithEvents ButtonSubmit As Button

End Class