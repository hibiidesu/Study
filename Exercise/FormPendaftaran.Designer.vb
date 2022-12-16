<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPendaftaran
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPendaftaran))
        Me.lblNama = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnDaftar = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.logoBA = New System.Windows.Forms.Panel()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.rbLaki = New System.Windows.Forms.RadioButton()
        Me.rbPerempuan = New System.Windows.Forms.RadioButton()
        Me.grpKelamin = New System.Windows.Forms.GroupBox()
        Me.lblOnline = New System.Windows.Forms.Label()
        Me.lblJumlah = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnTampil = New System.Windows.Forms.Button()
        Me.rtbDesc = New System.Windows.Forms.RichTextBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblLimit = New System.Windows.Forms.Label()
        Me.btnLaki = New System.Windows.Forms.Button()
        Me.chkYuuka = New System.Windows.Forms.CheckBox()
        Me.chkNatsu = New System.Windows.Forms.CheckBox()
        Me.chkHaruka = New System.Windows.Forms.CheckBox()
        Me.btnOutput = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPerempuan = New System.Windows.Forms.Button()
        Me.lbSecretary = New System.Windows.Forms.ListBox()
        Me.txtAddItem = New System.Windows.Forms.TextBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.clbSecretary = New System.Windows.Forms.CheckedListBox()
        Me.btnCLB = New System.Windows.Forms.Button()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.cbMap = New System.Windows.Forms.ComboBox()
        Me.btnShowCB = New System.Windows.Forms.Button()
        Me.lblStudents = New System.Windows.Forms.Label()
        Me.lblMap = New System.Windows.Forms.Label()
        Me.dtPickBdate = New System.Windows.Forms.DateTimePicker()
        Me.btnDate = New System.Windows.Forms.Button()
        Me.dtPickTime = New System.Windows.Forms.DateTimePicker()
        Me.btnTime = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KamarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahPemainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.rtbCatatan = New System.Windows.Forms.RichTextBox()
        Me.btnCatatan = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.btnOpenPic = New System.Windows.Forms.Button()
        Me.btnChangeColor = New System.Windows.Forms.Button()
        Me.lblColorChange = New System.Windows.Forms.Label()
        Me.lblColorCode = New System.Windows.Forms.Label()
        Me.txtColorCode = New System.Windows.Forms.TextBox()
        Me.pnlColorChange = New System.Windows.Forms.Panel()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.btnChangeGreen = New System.Windows.Forms.Button()
        Me.grpKelamin.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNama
        '
        Me.lblNama.Location = New System.Drawing.Point(12, 190)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(48, 23)
        Me.lblNama.TabIndex = 0
        Me.lblNama.Text = "Nama"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(66, 154)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(410, 23)
        Me.txtID.TabIndex = 1
        '
        'btnDaftar
        '
        Me.btnDaftar.Location = New System.Drawing.Point(514, 484)
        Me.btnDaftar.Name = "btnDaftar"
        Me.btnDaftar.Size = New System.Drawing.Size(75, 23)
        Me.btnDaftar.TabIndex = 2
        Me.btnDaftar.Text = "Daftar"
        Me.btnDaftar.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.Location = New System.Drawing.Point(12, 154)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(48, 23)
        Me.lblID.TabIndex = 4
        Me.lblID.Text = "ID"
        '
        'logoBA
        '
        Me.logoBA.BackgroundImage = CType(resources.GetObject("logoBA.BackgroundImage"), System.Drawing.Image)
        Me.logoBA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.logoBA.Location = New System.Drawing.Point(549, 255)
        Me.logoBA.Name = "logoBA"
        Me.logoBA.Size = New System.Drawing.Size(288, 118)
        Me.logoBA.TabIndex = 5
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(66, 190)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(410, 23)
        Me.txtNama.TabIndex = 7
        '
        'rbLaki
        '
        Me.rbLaki.AutoSize = True
        Me.rbLaki.Location = New System.Drawing.Point(6, 22)
        Me.rbLaki.Name = "rbLaki"
        Me.rbLaki.Size = New System.Drawing.Size(69, 19)
        Me.rbLaki.TabIndex = 8
        Me.rbLaki.TabStop = True
        Me.rbLaki.Text = "Laki-laki"
        Me.rbLaki.UseVisualStyleBackColor = True
        '
        'rbPerempuan
        '
        Me.rbPerempuan.AutoSize = True
        Me.rbPerempuan.Location = New System.Drawing.Point(6, 47)
        Me.rbPerempuan.Name = "rbPerempuan"
        Me.rbPerempuan.Size = New System.Drawing.Size(86, 19)
        Me.rbPerempuan.TabIndex = 9
        Me.rbPerempuan.TabStop = True
        Me.rbPerempuan.Text = "Perempuan"
        Me.rbPerempuan.UseVisualStyleBackColor = True
        '
        'grpKelamin
        '
        Me.grpKelamin.Controls.Add(Me.rbPerempuan)
        Me.grpKelamin.Controls.Add(Me.rbLaki)
        Me.grpKelamin.Location = New System.Drawing.Point(12, 225)
        Me.grpKelamin.Name = "grpKelamin"
        Me.grpKelamin.Size = New System.Drawing.Size(110, 78)
        Me.grpKelamin.TabIndex = 11
        Me.grpKelamin.TabStop = False
        Me.grpKelamin.Text = "Jenis Kelamin"
        '
        'lblOnline
        '
        Me.lblOnline.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblOnline.Location = New System.Drawing.Point(351, 46)
        Me.lblOnline.Name = "lblOnline"
        Me.lblOnline.Size = New System.Drawing.Size(62, 23)
        Me.lblOnline.TabIndex = 13
        Me.lblOnline.Text = "Online"
        '
        'lblJumlah
        '
        Me.lblJumlah.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblJumlah.Location = New System.Drawing.Point(419, 46)
        Me.lblJumlah.Name = "lblJumlah"
        Me.lblJumlah.Size = New System.Drawing.Size(62, 23)
        Me.lblJumlah.TabIndex = 14
        Me.lblJumlah.Text = "10"
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(373, 72)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 15
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnTampil
        '
        Me.btnTampil.Location = New System.Drawing.Point(12, 309)
        Me.btnTampil.Name = "btnTampil"
        Me.btnTampil.Size = New System.Drawing.Size(110, 23)
        Me.btnTampil.TabIndex = 16
        Me.btnTampil.Text = "Tampilkan"
        Me.btnTampil.UseVisualStyleBackColor = True
        '
        'rtbDesc
        '
        Me.rtbDesc.Location = New System.Drawing.Point(78, 349)
        Me.rtbDesc.Name = "rtbDesc"
        Me.rtbDesc.Size = New System.Drawing.Size(172, 157)
        Me.rtbDesc.TabIndex = 17
        Me.rtbDesc.Text = ""
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(12, 417)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(54, 15)
        Me.lblDesc.TabIndex = 18
        Me.lblDesc.Text = "Deskripsi"
        '
        'lblLimit
        '
        Me.lblLimit.AutoSize = True
        Me.lblLimit.Location = New System.Drawing.Point(41, 484)
        Me.lblLimit.Name = "lblLimit"
        Me.lblLimit.Size = New System.Drawing.Size(19, 15)
        Me.lblLimit.TabIndex = 19
        Me.lblLimit.Text = "10"
        '
        'btnLaki
        '
        Me.btnLaki.Location = New System.Drawing.Point(128, 243)
        Me.btnLaki.Name = "btnLaki"
        Me.btnLaki.Size = New System.Drawing.Size(115, 23)
        Me.btnLaki.TabIndex = 20
        Me.btnLaki.Text = "Pilih Laki-laki"
        Me.btnLaki.UseVisualStyleBackColor = True
        '
        'chkYuuka
        '
        Me.chkYuuka.AutoSize = True
        Me.chkYuuka.Location = New System.Drawing.Point(295, 248)
        Me.chkYuuka.Name = "chkYuuka"
        Me.chkYuuka.Size = New System.Drawing.Size(59, 19)
        Me.chkYuuka.TabIndex = 22
        Me.chkYuuka.Text = "Yuuka"
        Me.chkYuuka.UseVisualStyleBackColor = True
        '
        'chkNatsu
        '
        Me.chkNatsu.AutoSize = True
        Me.chkNatsu.Location = New System.Drawing.Point(295, 295)
        Me.chkNatsu.Name = "chkNatsu"
        Me.chkNatsu.Size = New System.Drawing.Size(57, 19)
        Me.chkNatsu.TabIndex = 23
        Me.chkNatsu.Text = "Natsu"
        Me.chkNatsu.UseVisualStyleBackColor = True
        '
        'chkHaruka
        '
        Me.chkHaruka.AutoSize = True
        Me.chkHaruka.Location = New System.Drawing.Point(295, 272)
        Me.chkHaruka.Name = "chkHaruka"
        Me.chkHaruka.Size = New System.Drawing.Size(64, 19)
        Me.chkHaruka.TabIndex = 24
        Me.chkHaruka.Text = "Haruka"
        Me.chkHaruka.UseVisualStyleBackColor = True
        '
        'btnOutput
        '
        Me.btnOutput.Location = New System.Drawing.Point(284, 318)
        Me.btnOutput.Name = "btnOutput"
        Me.btnOutput.Size = New System.Drawing.Size(75, 23)
        Me.btnOutput.TabIndex = 25
        Me.btnOutput.Text = "Hasil"
        Me.btnOutput.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(375, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Sekretaris"
        '
        'btnPerempuan
        '
        Me.btnPerempuan.Location = New System.Drawing.Point(128, 272)
        Me.btnPerempuan.Name = "btnPerempuan"
        Me.btnPerempuan.Size = New System.Drawing.Size(115, 23)
        Me.btnPerempuan.TabIndex = 27
        Me.btnPerempuan.Text = "Pilih Perempuan"
        Me.btnPerempuan.UseVisualStyleBackColor = True
        '
        'lbSecretary
        '
        Me.lbSecretary.FormattingEnabled = True
        Me.lbSecretary.ItemHeight = 15
        Me.lbSecretary.Location = New System.Drawing.Point(271, 442)
        Me.lbSecretary.Name = "lbSecretary"
        Me.lbSecretary.Size = New System.Drawing.Size(100, 64)
        Me.lbSecretary.TabIndex = 28
        '
        'txtAddItem
        '
        Me.txtAddItem.Location = New System.Drawing.Point(271, 384)
        Me.txtAddItem.Name = "txtAddItem"
        Me.txtAddItem.Size = New System.Drawing.Size(100, 23)
        Me.txtAddItem.TabIndex = 29
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(282, 413)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(75, 23)
        Me.btnAddItem.TabIndex = 30
        Me.btnAddItem.Text = "Tambah"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'clbSecretary
        '
        Me.clbSecretary.FormattingEnabled = True
        Me.clbSecretary.Items.AddRange(New Object() {"Yuuka", "Haruka", "Natsu"})
        Me.clbSecretary.Location = New System.Drawing.Point(452, 248)
        Me.clbSecretary.Name = "clbSecretary"
        Me.clbSecretary.Size = New System.Drawing.Size(74, 58)
        Me.clbSecretary.TabIndex = 31
        '
        'btnCLB
        '
        Me.btnCLB.Location = New System.Drawing.Point(452, 312)
        Me.btnCLB.Name = "btnCLB"
        Me.btnCLB.Size = New System.Drawing.Size(75, 23)
        Me.btnCLB.TabIndex = 32
        Me.btnCLB.Text = "Hasil"
        Me.btnCLB.UseVisualStyleBackColor = True
        '
        'btnTransfer
        '
        Me.btnTransfer.Location = New System.Drawing.Point(359, 270)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(87, 23)
        Me.btnTransfer.TabIndex = 33
        Me.btnTransfer.Text = "Pindah Hasil"
        Me.btnTransfer.UseVisualStyleBackColor = True
        '
        'cbMap
        '
        Me.cbMap.FormattingEnabled = True
        Me.cbMap.Items.AddRange(New Object() {"Urban", "Field", "Indoor"})
        Me.cbMap.Location = New System.Drawing.Point(431, 384)
        Me.cbMap.Name = "cbMap"
        Me.cbMap.Size = New System.Drawing.Size(121, 23)
        Me.cbMap.TabIndex = 34
        '
        'btnShowCB
        '
        Me.btnShowCB.Location = New System.Drawing.Point(452, 413)
        Me.btnShowCB.Name = "btnShowCB"
        Me.btnShowCB.Size = New System.Drawing.Size(75, 23)
        Me.btnShowCB.TabIndex = 35
        Me.btnShowCB.Text = "Lihat"
        Me.btnShowCB.UseVisualStyleBackColor = True
        '
        'lblStudents
        '
        Me.lblStudents.AutoSize = True
        Me.lblStudents.Location = New System.Drawing.Point(294, 358)
        Me.lblStudents.Name = "lblStudents"
        Me.lblStudents.Size = New System.Drawing.Size(53, 15)
        Me.lblStudents.TabIndex = 36
        Me.lblStudents.Text = "Students"
        '
        'lblMap
        '
        Me.lblMap.AutoSize = True
        Me.lblMap.Location = New System.Drawing.Point(473, 358)
        Me.lblMap.Name = "lblMap"
        Me.lblMap.Size = New System.Drawing.Size(31, 15)
        Me.lblMap.TabIndex = 37
        Me.lblMap.Text = "Map"
        '
        'dtPickBdate
        '
        Me.dtPickBdate.Location = New System.Drawing.Point(549, 72)
        Me.dtPickBdate.Name = "dtPickBdate"
        Me.dtPickBdate.Size = New System.Drawing.Size(200, 23)
        Me.dtPickBdate.TabIndex = 38
        '
        'btnDate
        '
        Me.btnDate.Location = New System.Drawing.Point(628, 107)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(75, 23)
        Me.btnDate.TabIndex = 39
        Me.btnDate.Text = "Lihat"
        Me.btnDate.UseVisualStyleBackColor = True
        '
        'dtPickTime
        '
        Me.dtPickTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtPickTime.Location = New System.Drawing.Point(549, 154)
        Me.dtPickTime.Name = "dtPickTime"
        Me.dtPickTime.Size = New System.Drawing.Size(200, 23)
        Me.dtPickTime.TabIndex = 40
        '
        'btnTime
        '
        Me.btnTime.Location = New System.Drawing.Point(628, 190)
        Me.btnTime.Name = "btnTime"
        Me.btnTime.Size = New System.Drawing.Size(75, 23)
        Me.btnTime.TabIndex = 41
        Me.btnTime.Text = "Lihat"
        Me.btnTime.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KamarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1045, 24)
        Me.MenuStrip1.TabIndex = 42
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KamarToolStripMenuItem
        '
        Me.KamarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahPemainToolStripMenuItem})
        Me.KamarToolStripMenuItem.Name = "KamarToolStripMenuItem"
        Me.KamarToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.KamarToolStripMenuItem.Text = "Pemain"
        '
        'TambahPemainToolStripMenuItem
        '
        Me.TambahPemainToolStripMenuItem.Name = "TambahPemainToolStripMenuItem"
        Me.TambahPemainToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.TambahPemainToolStripMenuItem.Text = "Tambah Pemain"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1045, 25)
        Me.ToolStrip1.TabIndex = 43
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'rtbCatatan
        '
        Me.rtbCatatan.Location = New System.Drawing.Point(649, 384)
        Me.rtbCatatan.Name = "rtbCatatan"
        Me.rtbCatatan.Size = New System.Drawing.Size(100, 96)
        Me.rtbCatatan.TabIndex = 44
        Me.rtbCatatan.Text = ""
        '
        'btnCatatan
        '
        Me.btnCatatan.Location = New System.Drawing.Point(663, 486)
        Me.btnCatatan.Name = "btnCatatan"
        Me.btnCatatan.Size = New System.Drawing.Size(86, 23)
        Me.btnCatatan.TabIndex = 45
        Me.btnCatatan.Text = "Buka Catatan"
        Me.btnCatatan.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'pbFoto
        '
        Me.pbFoto.Location = New System.Drawing.Point(844, 133)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(119, 96)
        Me.pbFoto.TabIndex = 46
        Me.pbFoto.TabStop = False
        '
        'btnOpenPic
        '
        Me.btnOpenPic.Location = New System.Drawing.Point(867, 235)
        Me.btnOpenPic.Name = "btnOpenPic"
        Me.btnOpenPic.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenPic.TabIndex = 47
        Me.btnOpenPic.Text = "Buka Foto"
        Me.btnOpenPic.UseVisualStyleBackColor = True
        '
        'btnChangeColor
        '
        Me.btnChangeColor.Location = New System.Drawing.Point(844, 379)
        Me.btnChangeColor.Name = "btnChangeColor"
        Me.btnChangeColor.Size = New System.Drawing.Size(83, 23)
        Me.btnChangeColor.TabIndex = 48
        Me.btnChangeColor.Text = "Ubah Warna"
        Me.btnChangeColor.UseVisualStyleBackColor = True
        '
        'lblColorChange
        '
        Me.lblColorChange.AutoSize = True
        Me.lblColorChange.Location = New System.Drawing.Point(851, 413)
        Me.lblColorChange.Name = "lblColorChange"
        Me.lblColorChange.Size = New System.Drawing.Size(60, 15)
        Me.lblColorChange.TabIndex = 49
        Me.lblColorChange.Text = "Text Color"
        '
        'lblColorCode
        '
        Me.lblColorCode.AutoSize = True
        Me.lblColorCode.Location = New System.Drawing.Point(851, 442)
        Me.lblColorCode.Name = "lblColorCode"
        Me.lblColorCode.Size = New System.Drawing.Size(67, 15)
        Me.lblColorCode.TabIndex = 50
        Me.lblColorCode.Text = "Color Code"
        '
        'txtColorCode
        '
        Me.txtColorCode.Location = New System.Drawing.Point(827, 476)
        Me.txtColorCode.Name = "txtColorCode"
        Me.txtColorCode.Size = New System.Drawing.Size(100, 23)
        Me.txtColorCode.TabIndex = 51
        '
        'pnlColorChange
        '
        Me.pnlColorChange.Location = New System.Drawing.Point(827, 505)
        Me.pnlColorChange.Name = "pnlColorChange"
        Me.pnlColorChange.Size = New System.Drawing.Size(107, 48)
        Me.pnlColorChange.TabIndex = 52
        '
        'btnChangeGreen
        '
        Me.btnChangeGreen.Location = New System.Drawing.Point(938, 418)
        Me.btnChangeGreen.Name = "btnChangeGreen"
        Me.btnChangeGreen.Size = New System.Drawing.Size(95, 39)
        Me.btnChangeGreen.TabIndex = 53
        Me.btnChangeGreen.Text = "Ubah menjadi Hijau"
        Me.btnChangeGreen.UseVisualStyleBackColor = True
        '
        'FormPendaftaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 581)
        Me.Controls.Add(Me.btnChangeGreen)
        Me.Controls.Add(Me.pnlColorChange)
        Me.Controls.Add(Me.txtColorCode)
        Me.Controls.Add(Me.lblColorCode)
        Me.Controls.Add(Me.lblColorChange)
        Me.Controls.Add(Me.btnChangeColor)
        Me.Controls.Add(Me.btnOpenPic)
        Me.Controls.Add(Me.pbFoto)
        Me.Controls.Add(Me.btnCatatan)
        Me.Controls.Add(Me.rtbCatatan)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnTime)
        Me.Controls.Add(Me.dtPickTime)
        Me.Controls.Add(Me.btnDate)
        Me.Controls.Add(Me.dtPickBdate)
        Me.Controls.Add(Me.lblMap)
        Me.Controls.Add(Me.lblStudents)
        Me.Controls.Add(Me.btnShowCB)
        Me.Controls.Add(Me.cbMap)
        Me.Controls.Add(Me.btnTransfer)
        Me.Controls.Add(Me.btnCLB)
        Me.Controls.Add(Me.clbSecretary)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.txtAddItem)
        Me.Controls.Add(Me.lbSecretary)
        Me.Controls.Add(Me.btnPerempuan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOutput)
        Me.Controls.Add(Me.chkHaruka)
        Me.Controls.Add(Me.chkNatsu)
        Me.Controls.Add(Me.chkYuuka)
        Me.Controls.Add(Me.btnLaki)
        Me.Controls.Add(Me.lblLimit)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.rtbDesc)
        Me.Controls.Add(Me.btnTampil)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.lblJumlah)
        Me.Controls.Add(Me.lblOnline)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.logoBA)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnDaftar)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.grpKelamin)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormPendaftaran"
        Me.Text = "Pendaftaran"
        Me.grpKelamin.ResumeLayout(False)
        Me.grpKelamin.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnDaftar As Button
    Friend WithEvents lblID As Label
    Friend WithEvents logoBA As Panel
    Friend WithEvents txtNama As TextBox
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents grpKelamin As GroupBox
    Friend WithEvents lblOnline As Label
    Friend WithEvents lblJumlah As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnTampil As Button
    Friend WithEvents rtbDesc As RichTextBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblLimit As Label
    Friend WithEvents btnLaki As Button
    Friend WithEvents chkYuuka As CheckBox
    Friend WithEvents chkNatsu As CheckBox
    Friend WithEvents chkHaruka As CheckBox
    Friend WithEvents btnOutput As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPerempuan As Button
    Friend WithEvents lbSecretary As ListBox
    Friend WithEvents txtAddItem As TextBox
    Friend WithEvents btnAddItem As Button
    Friend WithEvents clbSecretary As CheckedListBox
    Friend WithEvents btnCLB As Button
    Friend WithEvents btnTransfer As Button
    Friend WithEvents cbMap As ComboBox
    Friend WithEvents btnShowCB As Button
    Friend WithEvents lblStudents As Label
    Friend WithEvents lblMap As Label
    Friend WithEvents dtPickBdate As DateTimePicker
    Friend WithEvents btnDate As Button
    Friend WithEvents dtPickTime As DateTimePicker
    Friend WithEvents btnTime As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KamarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahPemainToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents rtbCatatan As RichTextBox
    Friend WithEvents btnCatatan As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents btnOpenPic As Button
    Friend WithEvents btnChangeColor As Button
    Friend WithEvents lblColorChange As Label
    Friend WithEvents lblColorCode As Label
    Friend WithEvents txtColorCode As TextBox
    Friend WithEvents pnlColorChange As Panel
    Friend WithEvents ColorDialog1 As Windows.Forms.ColorDialog
    Friend WithEvents btnChangeGreen As Button
End Class
