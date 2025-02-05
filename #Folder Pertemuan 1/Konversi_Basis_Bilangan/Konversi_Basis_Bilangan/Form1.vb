Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBasis2.ReadOnly = True
        txtBasis8.ReadOnly = True
        txtBasis16.ReadOnly = True
        txtDecimal.ReadOnly = True
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim inputDecimal As Integer
        If Integer.TryParse(txtBasis10.Text, inputDecimal) Then
            txtBasis2.Text = Convert.ToString(inputDecimal, 2).PadLeft(4, "0"c)
            txtBasis8.Text = Convert.ToString(inputDecimal, 8)
            txtBasis16.Text = Convert.ToString(inputDecimal, 16).ToUpper()
            txtDecimal.Text = inputDecimal.ToString()
        Else
            MessageBox.Show("Input harus berupa angka desimal yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class