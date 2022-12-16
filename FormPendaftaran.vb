Imports System.IO

Public Class FormPendaftaran

    Public Shared Online As Integer = 9235

    Public Shared id As String
    Public Shared nama As String
    Public Shared jenis_kelamin As String

    Dim max_char_desc = 50
    Dim id_awal = 123
    Dim secretary As String = "Menu anda terdapat"
    Dim secretary_arrlist As New List(Of String)
    Dim secretary_arrlist_id As New List(Of String)
    Dim map As New List(Of String) From {"Urban", "Field", "Indoor"}
    Dim colors As DialogResult

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtNama.Select()
        lblJumlah.Text = Online.ToString()
        lblLimit.Text = max_char_desc.ToString()
        cbMap.DataSource = map
        My.Computer.Audio.Play("D:\Visual Basic Nabil Falih TI2B\Pertemuan1lagi\title_screen.wav", AudioPlayMode.BackgroundLoop)
        'wav filenya kegedean pak jadi gak diupload

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim tambah_pemain = New FormOnline()
        FormOnline.Show()
    End Sub

    Private Sub FormPendaftaran_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        id = id_awal + 1
        id_awal = id
        txtID.Text = id
        lblJumlah.Text = Online
    End Sub

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        Dim daftar = New imfeelinglucky()
        daftar.Show()
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If

    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert String Only")
        End If
    End Sub

    Private Sub txtID_Leave(sender As Object, e As EventArgs) Handles txtID.Leave
        If txtNama.Text.Length < 1 Then
            txtNama.Select()
            MessageBox.Show("Please add at least 1 Number")
        End If
    End Sub

    Private Sub txtNama_Leave(sender As Object, e As EventArgs) Handles txtNama.Leave
        If txtNama.Text.Length < 1 Then
            txtNama.Select()
            MessageBox.Show("Please add at least 1 Letter")
        End If
    End Sub

    Private Sub RichTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rtbDesc.KeyPress
        If rtbDesc.Text.Length >= max_char_desc Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Max Length")
            End If
        End If
        'Dim charLimit = max_char_desc - rtbDesc.Text.Length - 1
        'lblLimit.Text = charLimit.ToString()
    End Sub

    Private Sub rtbDesc_TextChanged(sender As Object, e As EventArgs) Handles rtbDesc.TextChanged
        Dim charLimit = max_char_desc - rtbDesc.Text.Length
        lblLimit.Text = charLimit.ToString()
    End Sub

    Private Sub rbLaki_CheckedChanged(sender As Object, e As EventArgs) Handles rbLaki.CheckedChanged
        jenis_kelamin = "Laki-laki"
    End Sub

    Private Sub rbPerempuan_CheckedChanged(sender As Object, e As EventArgs) Handles rbPerempuan.CheckedChanged
        jenis_kelamin = "Perempuan"
    End Sub

    Private Sub btnTampil_Click(sender As Object, e As EventArgs) Handles btnTampil.Click
        MessageBox.Show("Jenis Kelamin " + jenis_kelamin + " Terpilih")
    End Sub

    'Private Sub btnLock_Click(sender As Object, e As EventArgs) Handles btnLaki.Click
    '    Dim lockOpt As String
    '    If rbLaki.Checked = True Then
    '        lockOpt = "Kunci " + jenis_kelamin
    '        lockOpt = btnLaki.ToString()
    '    End If

    '    If rbPerempuan.Checked = True Then
    '        lockOpt = "Kunci " + jenis_kelamin
    '        lockOpt = btnLaki.ToString()
    '    End If
    'End Sub

    Private Sub btnLaki_Click(sender As Object, e As EventArgs) Handles btnLaki.Click
        rbLaki.Checked = True
    End Sub

    Private Sub btnPerempuan_Click(sender As Object, e As EventArgs) Handles btnPerempuan.Click
        rbPerempuan.Checked = True
    End Sub

    Private Sub btnOutput_Click(sender As Object, e As EventArgs) Handles btnOutput.Click
        'If chkHaruka.Checked() Then
        '    secretary += " Haruka, "
        'End If
        'If chkNatsu.Checked() Then
        '    secretary += " Natsu, "
        'End If
        'If chkYuuka.Checked() Then
        '    secretary += " Yuuka, "
        'End If

        'MessageBox.Show(secretary + "sebagai sekretaris anda")

        'secretary = "Menu anda terdapat"

        If chkYuuka.Checked() Then
            secretary_arrlist.Add("Yuuka")
        End If

        If chkHaruka.Checked() Then
            secretary_arrlist.Add("Haruka")
        End If

        If chkNatsu.Checked() Then
            secretary_arrlist.Add("Natsu")
        End If


        Dim secretary_str = String.Join(", ", secretary_arrlist.ToArray)
        MessageBox.Show("Sekretaris anda saat ini adalah " + secretary_str)

        secretary_arrlist.Clear()
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim add_item = txtAddItem.Text
        lbSecretary.Items.Add(add_item)
    End Sub

    Private Sub btnCLB_Click(sender As Object, e As EventArgs) Handles btnCLB.Click
        For i = 0 To clbSecretary.Items.Count - 1
            Dim Item As Object = clbSecretary.Items(i)

            If clbSecretary.GetItemChecked(i) Then
                secretary_arrlist.Add(clbSecretary.Items(i))
            End If
        Next

        Dim secretary_str = String.Join(", ", secretary_arrlist.ToArray)
        MessageBox.Show("Sekretaris anda saat ini adalah " + secretary_str)
        secretary_arrlist.Clear()
    End Sub

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        For i As Integer = 0 To clbSecretary.Items.Count - 1
            clbSecretary.SetItemChecked(i, False)
        Next

        If chkYuuka.Checked() Then
            secretary_arrlist_id.Add(0)
            secretary_arrlist.Add("Yuuka")
        End If

        If chkHaruka.Checked() Then
            secretary_arrlist_id.Add(1)
            secretary_arrlist.Add("Haruka")
        End If

        If chkNatsu.Checked() Then
            secretary_arrlist_id.Add(2)
            secretary_arrlist.Add("Natsu")
        End If

        For Each sec In secretary_arrlist_id
            clbSecretary.SetItemChecked(sec, True)
        Next

        For Each stud In secretary_arrlist
            lbSecretary.Items.Add(stud)
        Next

        secretary_arrlist_id.Clear()
    End Sub

    Private Sub btnShowCB_Click(sender As Object, e As EventArgs) Handles btnShowCB.Click
        Dim map_item = cbMap.SelectedItem()
        MessageBox.Show("Map anda saat ini " + map_item)
    End Sub

    Private Sub lblID_Click(sender As Object, e As EventArgs) Handles lblID.Click

    End Sub


    Private Sub txtAddItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddItem.KeyPress

        If e.KeyChar = Chr(Keys.Enter) Then

            Dim add_item = txtAddItem.Text
            lbSecretary.Items.Add(add_item)

        End If
    End Sub

    Private Sub btnDate_Click(sender As Object, e As EventArgs) Handles btnDate.Click
        MessageBox.Show(dtPickBdate.Value.ToString("dd/MM/yyyy"))
    End Sub

    Private Sub btnTime_Click(sender As Object, e As EventArgs) Handles btnTime.Click
        Dim current_time = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        MessageBox.Show(current_time)
    End Sub

    Private Sub TambahPemainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahPemainToolStripMenuItem.Click
        Dim tambah_pemain = New FormOnline()
        tambah_pemain.Show()
    End Sub

    Private Sub btnCatatan_Click(sender As Object, e As EventArgs) Handles btnCatatan.Click
        Dim fileReader As System.IO.StreamReader
        OpenFileDialog1.InitialDirectory = "~\Documents"
        OpenFileDialog1.Title = "Buka Catatan Sensei"
        OpenFileDialog1.Filter = "Text File [*.txt]|*.txt|All Files [*.*]|*.*"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            OpenFileDialog1.OpenFile()
            fileReader = File.OpenText(OpenFileDialog1.FileName)
            rtbCatatan.Text = fileReader.ReadToEnd()
            fileReader.Close()
        End If
    End Sub

    Private Sub btnOpenPic_Click(sender As Object, e As EventArgs) Handles btnOpenPic.Click
        OpenFileDialog1.Title = "Buka Foto"
        OpenFileDialog1.Filter = "All Format|*.*|Image|*.bmp|Image JPG|*jpg|Image JPEG|*jpeg|Image PNG|*.png|Image GIF|*gif"

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbFoto.Load(OpenFileDialog1.FileName)
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub btnChangeColor_Click(sender As Object, e As EventArgs) Handles btnChangeColor.Click
        colors = ColorDialog1.ShowDialog()

        If colors = Windows.Forms.DialogResult.OK Then
            lblColorChange.ForeColor = ColorDialog1.Color
            lblColorCode.Text = ColorDialog1.Color.ToArgb
            txtColorCode.Text = ColorDialog1.Color.ToArgb
            pnlColorChange.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub btnChangeGreen_Click(sender As Object, e As EventArgs) Handles btnChangeGreen.Click
        lblColorChange.ForeColor = Color.FromArgb("-16711808")
        lblColorCode.Text = "-16711808"
        txtColorCode.Text = "-16711808"
        pnlColorChange.BackColor = Color.FromArgb("-16711808")
    End Sub
End Class
