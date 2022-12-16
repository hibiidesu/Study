Public Class FormPerhitungan
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim nilai1 = txtBox1.Text
        Dim nilai2 = txtBox2.Text

        If nilai1 IsNot "" And nilai2 IsNot "" Then
            Dim hasil = Integer.Parse(nilai1) + Integer.Parse(nilai2)
            MessageBox.Show("Hasilnya = " + hasil.ToString())
        Else
            MessageBox.Show("Lengkapi Input")
        End If

        Dim variable1 = "TI"
        Dim variable2 = "B"

        MessageBox.Show(variable1 + "-" + variable2)
    End Sub
End Class
