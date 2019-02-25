<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJadwal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormJadwal))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnHapus = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.btnSet = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtDurasi = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtJudul = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnCariFilm = New System.Windows.Forms.Button
        Me.txtKodeFilm = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbStudio = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Preview = New System.Windows.Forms.PictureBox
        Me.btnCari = New System.Windows.Forms.Button
        Me.txtKode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Header = New System.Windows.Forms.Panel
        Me.btnGoBack = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.txtJam = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtTanggal = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.gbDaftarJadwal = New System.Windows.Forms.GroupBox
        Me.btnShowJadwal = New System.Windows.Forms.Button
        Me.txtBy = New System.Windows.Forms.TextBox
        Me.cbShowBy = New System.Windows.Forms.ComboBox
        Me.DataListJadwal = New System.Windows.Forms.DataGridView
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.valTanggal = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1.SuspendLayout()
        CType(Me.Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Header.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbDaftarJadwal.SuspendLayout()
        CType(Me.DataListJadwal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data Jadwal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 422)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 29)
        Me.Label6.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.btnSet)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtDurasi)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtJudul)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnCariFilm)
        Me.GroupBox1.Controls.Add(Me.txtKodeFilm)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbStudio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Preview)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnCari)
        Me.GroupBox1.Controls.Add(Me.txtKode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 114)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1010, 440)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FORM INPUT DATA"
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.Red
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(494, 341)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(137, 59)
        Me.btnHapus.TabIndex = 33
        Me.btnHapus.Text = "HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.Control
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(343, 341)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(137, 59)
        Me.btnReset.TabIndex = 32
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnSet
        '
        Me.btnSet.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSet.ForeColor = System.Drawing.Color.White
        Me.btnSet.Location = New System.Drawing.Point(190, 341)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(137, 59)
        Me.btnSet.TabIndex = 31
        Me.btnSet.Text = "SET"
        Me.btnSet.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(504, 286)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 31)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "M E N I T"
        '
        'txtDurasi
        '
        Me.txtDurasi.Location = New System.Drawing.Point(190, 283)
        Me.txtDurasi.Name = "txtDurasi"
        Me.txtDurasi.ReadOnly = True
        Me.txtDurasi.Size = New System.Drawing.Size(295, 34)
        Me.txtDurasi.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 29)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Durasi"
        '
        'txtJudul
        '
        Me.txtJudul.Location = New System.Drawing.Point(190, 223)
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.ReadOnly = True
        Me.txtJudul.Size = New System.Drawing.Size(441, 34)
        Me.txtJudul.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 29)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Judul Film"
        '
        'btnCariFilm
        '
        Me.btnCariFilm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCariFilm.Location = New System.Drawing.Point(506, 165)
        Me.btnCariFilm.Name = "btnCariFilm"
        Me.btnCariFilm.Size = New System.Drawing.Size(125, 34)
        Me.btnCariFilm.TabIndex = 25
        Me.btnCariFilm.Text = "PILIH FILM"
        Me.btnCariFilm.UseVisualStyleBackColor = True
        '
        'txtKodeFilm
        '
        Me.txtKodeFilm.Location = New System.Drawing.Point(190, 165)
        Me.txtKodeFilm.Name = "txtKodeFilm"
        Me.txtKodeFilm.Size = New System.Drawing.Size(295, 34)
        Me.txtKodeFilm.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 29)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Kode Film"
        '
        'cbStudio
        '
        Me.cbStudio.AccessibleName = ""
        Me.cbStudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStudio.FormattingEnabled = True
        Me.cbStudio.Location = New System.Drawing.Point(190, 107)
        Me.cbStudio.Name = "cbStudio"
        Me.cbStudio.Size = New System.Drawing.Size(441, 37)
        Me.cbStudio.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 29)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Studio"
        '
        'Preview
        '
        Me.Preview.Image = CType(resources.GetObject("Preview.Image"), System.Drawing.Image)
        Me.Preview.InitialImage = Global.GetTixApp.My.Resources.Resources.No_Image_Available
        Me.Preview.Location = New System.Drawing.Point(673, 54)
        Me.Preview.Name = "Preview"
        Me.Preview.Size = New System.Drawing.Size(292, 346)
        Me.Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Preview.TabIndex = 12
        Me.Preview.TabStop = False
        '
        'btnCari
        '
        Me.btnCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCari.Location = New System.Drawing.Point(506, 51)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(125, 34)
        Me.btnCari.TabIndex = 2
        Me.btnCari.Text = "CARI"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(190, 51)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(295, 34)
        Me.txtKode.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kode Jadwal"
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Header.Controls.Add(Me.btnGoBack)
        Me.Header.Controls.Add(Me.Label1)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1904, 82)
        Me.Header.TabIndex = 5
        '
        'btnGoBack
        '
        Me.btnGoBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoBack.Location = New System.Drawing.Point(257, 20)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(120, 41)
        Me.btnGoBack.TabIndex = 1
        Me.btnGoBack.Text = "Kembali"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnSimpan)
        Me.GroupBox4.Controls.Add(Me.txtJam)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtTanggal)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(26, 584)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1010, 255)
        Me.GroupBox4.TabIndex = 32
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "FORM JADWAL TAYANG"
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(190, 159)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(441, 59)
        Me.btnSimpan.TabIndex = 33
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'txtJam
        '
        Me.txtJam.CustomFormat = "HH:mm"
        Me.txtJam.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtJam.Location = New System.Drawing.Point(190, 101)
        Me.txtJam.Name = "txtJam"
        Me.txtJam.Size = New System.Drawing.Size(441, 34)
        Me.txtJam.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 29)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Jam"
        '
        'txtTanggal
        '
        Me.txtTanggal.CustomFormat = "yyyy-MM-dd"
        Me.txtTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTanggal.Location = New System.Drawing.Point(190, 45)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Size = New System.Drawing.Size(441, 34)
        Me.txtTanggal.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 29)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Tanggal"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(29, 422)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 29)
        Me.Label11.TabIndex = 10
        '
        'gbDaftarJadwal
        '
        Me.gbDaftarJadwal.Controls.Add(Me.btnShowJadwal)
        Me.gbDaftarJadwal.Controls.Add(Me.txtBy)
        Me.gbDaftarJadwal.Controls.Add(Me.cbShowBy)
        Me.gbDaftarJadwal.Controls.Add(Me.DataListJadwal)
        Me.gbDaftarJadwal.Controls.Add(Me.Label13)
        Me.gbDaftarJadwal.Controls.Add(Me.Label14)
        Me.gbDaftarJadwal.Controls.Add(Me.valTanggal)
        Me.gbDaftarJadwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDaftarJadwal.Location = New System.Drawing.Point(1069, 114)
        Me.gbDaftarJadwal.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.gbDaftarJadwal.Name = "gbDaftarJadwal"
        Me.gbDaftarJadwal.Size = New System.Drawing.Size(830, 725)
        Me.gbDaftarJadwal.TabIndex = 34
        Me.gbDaftarJadwal.TabStop = False
        Me.gbDaftarJadwal.Text = "DAFTAR JADWAL"
        '
        'btnShowJadwal
        '
        Me.btnShowJadwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowJadwal.Location = New System.Drawing.Point(636, 40)
        Me.btnShowJadwal.Name = "btnShowJadwal"
        Me.btnShowJadwal.Size = New System.Drawing.Size(158, 37)
        Me.btnShowJadwal.TabIndex = 34
        Me.btnShowJadwal.Text = "TAMPILKAN"
        Me.btnShowJadwal.UseVisualStyleBackColor = True
        '
        'txtBy
        '
        Me.txtBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBy.Location = New System.Drawing.Point(453, 40)
        Me.txtBy.Name = "txtBy"
        Me.txtBy.Size = New System.Drawing.Size(164, 36)
        Me.txtBy.TabIndex = 33
        '
        'cbShowBy
        '
        Me.cbShowBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbShowBy.FormattingEnabled = True
        Me.cbShowBy.Location = New System.Drawing.Point(263, 40)
        Me.cbShowBy.Name = "cbShowBy"
        Me.cbShowBy.Size = New System.Drawing.Size(176, 37)
        Me.cbShowBy.TabIndex = 32
        '
        'DataListJadwal
        '
        Me.DataListJadwal.AllowUserToAddRows = False
        Me.DataListJadwal.AllowUserToDeleteRows = False
        Me.DataListJadwal.AllowUserToResizeColumns = False
        Me.DataListJadwal.AllowUserToResizeRows = False
        Me.DataListJadwal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataListJadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListJadwal.Location = New System.Drawing.Point(34, 97)
        Me.DataListJadwal.Name = "DataListJadwal"
        Me.DataListJadwal.RowTemplate.Height = 24
        Me.DataListJadwal.Size = New System.Drawing.Size(760, 591)
        Me.DataListJadwal.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(29, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(228, 29)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Tampil berdasarkan"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(29, 422)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 29)
        Me.Label14.TabIndex = 10
        '
        'valTanggal
        '
        Me.valTanggal.CustomFormat = "yyyy-MM-dd"
        Me.valTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.valTanggal.Location = New System.Drawing.Point(453, 41)
        Me.valTanggal.Name = "valTanggal"
        Me.valTanggal.Size = New System.Drawing.Size(164, 36)
        Me.valTanggal.TabIndex = 34
        '
        'FormJadwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 896)
        Me.Controls.Add(Me.gbDaftarJadwal)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormJadwal"
        Me.Text = "FormJadwal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Preview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Header.ResumeLayout(False)
        Me.Header.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.gbDaftarJadwal.ResumeLayout(False)
        Me.gbDaftarJadwal.PerformLayout()
        CType(Me.DataListJadwal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Preview As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents txtKode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Header As System.Windows.Forms.Panel
    Friend WithEvents btnGoBack As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCariFilm As System.Windows.Forms.Button
    Friend WithEvents txtKodeFilm As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbStudio As System.Windows.Forms.ComboBox
    Friend WithEvents txtJudul As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDurasi As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents txtJam As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents gbDaftarJadwal As System.Windows.Forms.GroupBox
    Friend WithEvents DataListJadwal As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbShowBy As System.Windows.Forms.ComboBox
    Friend WithEvents txtBy As System.Windows.Forms.TextBox
    Friend WithEvents btnShowJadwal As System.Windows.Forms.Button
    Friend WithEvents valTanggal As System.Windows.Forms.DateTimePicker
End Class
