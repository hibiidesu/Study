Public Class FormOnline

    Public totalAddPemain As Integer = 0

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblJumlah.Text = FormPendaftaran.Online.ToString()
        txtValue.Text = totalAddPemain

        If totalAddPemain < 1 Then
            btnMin.Enabled = False
        End If
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        totalAddPemain = totalAddPemain - 1
        txtValue.Text = totalAddPemain

        If totalAddPemain < 1 Then
            btnMin.Enabled = False
        End If
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        totalAddPemain = totalAddPemain + 1
        txtValue.Text = totalAddPemain

        If totalAddPemain >= 1 Then
            btnMin.Enabled = True
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        FormPendaftaran.Online += txtValue.Text

        Me.Close()
    End Sub
End Class