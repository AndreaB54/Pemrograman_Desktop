Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        Dim celcius, fahrenheit, reamur, kelvin As Double
        celcius = Val(txtCelcius.Text)
        fahrenheit = 9 / 5 * (celcius) + 32
        reamur = 4 / 5 * (celcius)
        kelvin = celcius + 273

        MsgBox("Fahrenheit = " & fahrenheit & vbCrLf & "Reamur = " & reamur & vbCrLf & "Kelvin = " & kelvin)


        lblFahrenheit.Text = CStr(fahrenheit)
        lblReamur.Text = CStr(reamur)
        lblKelvin.Text = CStr(kelvin)

        txtFahrenheit.Text = CStr(fahrenheit)
        txtReamur.Text = CStr(reamur)
        txtKelvin.Text = CStr(kelvin)
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFahrenheit.ReadOnly = True
        txtReamur.ReadOnly = True
        txtKelvin.ReadOnly = True
    End Sub
End Class
