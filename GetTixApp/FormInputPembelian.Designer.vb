<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInputPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInputPembelian))
        Me.btnHapus = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtJamTayang = New System.Windows.Forms.TextBox
        Me.GbTotal = New System.Windows.Forms.GroupBox
        Me.labelTotal = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtStudio = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.PanelSelectedKursi = New System.Windows.Forms.Panel
        Me.Preview = New System.Windows.Forms.PictureBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtJudulFilm = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnPilihFilm = New System.Windows.Forms.Button
        Me.txtKodeFilm = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtTanggalBeli = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnCariPembelian = New System.Windows.Forms.Button
        Me.txtKodePembelian = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Header = New System.Windows.Forms.Panel
        Me.btnGoBack = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.PanelKursi = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label14 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label13 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnResetKursi = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GbTotal.SuspendLayout()
        CType(Me.Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Header.SuspendLayout()
        Me.PanelKursi.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.Red
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(532, 465)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(137, 59)
        Me.btnHapus.TabIndex = 17
        Me.btnHapus.Text = "HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.Control
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(381, 465)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(137, 59)
        Me.btnReset.TabIndex = 16
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(228, 465)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(137, 59)
        Me.btnSimpan.TabIndex = 15
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtJamTayang)
        Me.GroupBox1.Controls.Add(Me.GbTotal)
        Me.GroupBox1.Controls.Add(Me.txtStudio)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.PanelSelectedKursi)
        Me.GroupBox1.Controls.Add(Me.Preview)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtJudulFilm)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnPilihFilm)
        Me.GroupBox1.Controls.Add(Me.txtKodeFilm)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtTanggalBeli)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.btnSimpan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnCariPembelian)
        Me.GroupBox1.Controls.Add(Me.txtKodePembelian)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 114)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1031, 611)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FORM INPUT DATA"
        '
        'txtJamTayang
        '
        Me.txtJamTayang.Location = New System.Drawing.Point(228, 286)
        Me.txtJamTayang.Name = "txtJamTayang"
        Me.txtJamTayang.ReadOnly = True
        Me.txtJamTayang.Size = New System.Drawing.Size(441, 34)
        Me.txtJamTayang.TabIndex = 35
        '
        'GbTotal
        '
        Me.GbTotal.Controls.Add(Me.labelTotal)
        Me.GbTotal.Controls.Add(Me.Label11)
        Me.GbTotal.Location = New System.Drawing.Point(708, 399)
        Me.GbTotal.Name = "GbTotal"
        Me.GbTotal.Size = New System.Drawing.Size(269, 100)
        Me.GbTotal.TabIndex = 34
        Me.GbTotal.TabStop = False
        Me.GbTotal.Text = "TOTAL"
        '
        'labelTotal
        '
        Me.labelTotal.BackColor = System.Drawing.SystemColors.Control
        Me.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.labelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelTotal.Location = New System.Drawing.Point(79, 41)
        Me.labelTotal.Name = "labelTotal"
        Me.labelTotal.ReadOnly = True
        Me.labelTotal.Size = New System.Drawing.Size(169, 33)
        Me.labelTotal.TabIndex = 1
        Me.labelTotal.Text = "0,-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(23, 41)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 33)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Rp."
        '
        'txtStudio
        '
        Me.txtStudio.Location = New System.Drawing.Point(228, 344)
        Me.txtStudio.Name = "txtStudio"
        Me.txtStudio.ReadOnly = True
        Me.txtStudio.Size = New System.Drawing.Size(441, 34)
        Me.txtStudio.TabIndex = 33
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 344)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 29)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Studio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 283)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 29)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Jam Tayang"
        '
        'PanelSelectedKursi
        '
        Me.PanelSelectedKursi.Location = New System.Drawing.Point(228, 404)
        Me.PanelSelectedKursi.Name = "PanelSelectedKursi"
        Me.PanelSelectedKursi.Size = New System.Drawing.Size(441, 52)
        Me.PanelSelectedKursi.TabIndex = 29
        '
        'Preview
        '
        Me.Preview.Image = CType(resources.GetObject("Preview.Image"), System.Drawing.Image)
        Me.Preview.InitialImage = Global.GetTixApp.My.Resources.Resources.No_Image_Available
        Me.Preview.Location = New System.Drawing.Point(708, 54)
        Me.Preview.Name = "Preview"
        Me.Preview.Size = New System.Drawing.Size(269, 321)
        Me.Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Preview.TabIndex = 28
        Me.Preview.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 404)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 29)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "No. Kursi"
        '
        'txtJudulFilm
        '
        Me.txtJudulFilm.Location = New System.Drawing.Point(228, 225)
        Me.txtJudulFilm.Name = "txtJudulFilm"
        Me.txtJudulFilm.ReadOnly = True
        Me.txtJudulFilm.Size = New System.Drawing.Size(441, 34)
        Me.txtJudulFilm.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 29)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Judul Film"
        '
        'btnPilihFilm
        '
        Me.btnPilihFilm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPilihFilm.Location = New System.Drawing.Point(544, 168)
        Me.btnPilihFilm.Name = "btnPilihFilm"
        Me.btnPilihFilm.Size = New System.Drawing.Size(125, 34)
        Me.btnPilihFilm.TabIndex = 22
        Me.btnPilihFilm.Text = "Pilih Film"
        Me.btnPilihFilm.UseVisualStyleBackColor = True
        '
        'txtKodeFilm
        '
        Me.txtKodeFilm.Location = New System.Drawing.Point(228, 168)
        Me.txtKodeFilm.Name = "txtKodeFilm"
        Me.txtKodeFilm.ReadOnly = True
        Me.txtKodeFilm.Size = New System.Drawing.Size(295, 34)
        Me.txtKodeFilm.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 29)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Kode Film"
        '
        'txtTanggalBeli
        '
        Me.txtTanggalBeli.CustomFormat = "yyyy-MM-dd"
        Me.txtTanggalBeli.Enabled = False
        Me.txtTanggalBeli.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTanggalBeli.Location = New System.Drawing.Point(228, 111)
        Me.txtTanggalBeli.Name = "txtTanggalBeli"
        Me.txtTanggalBeli.Size = New System.Drawing.Size(441, 34)
        Me.txtTanggalBeli.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tanggal Beli"
        '
        'btnCariPembelian
        '
        Me.btnCariPembelian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCariPembelian.Location = New System.Drawing.Point(544, 54)
        Me.btnCariPembelian.Name = "btnCariPembelian"
        Me.btnCariPembelian.Size = New System.Drawing.Size(125, 34)
        Me.btnCariPembelian.TabIndex = 2
        Me.btnCariPembelian.Text = "CARI"
        Me.btnCariPembelian.UseVisualStyleBackColor = True
        '
        'txtKodePembelian
        '
        Me.txtKodePembelian.Location = New System.Drawing.Point(228, 54)
        Me.txtKodePembelian.Name = "txtKodePembelian"
        Me.txtKodePembelian.Size = New System.Drawing.Size(295, 34)
        Me.txtKodePembelian.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kode Pembelian"
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Header.Controls.Add(Me.btnGoBack)
        Me.Header.Controls.Add(Me.Label1)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1933, 82)
        Me.Header.TabIndex = 5
        '
        'btnGoBack
        '
        Me.btnGoBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoBack.Location = New System.Drawing.Point(343, 20)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(120, 41)
        Me.btnGoBack.TabIndex = 1
        Me.btnGoBack.Text = "Kembali"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data Pembelian"
        '
        'PanelKursi
        '
        Me.PanelKursi.Controls.Add(Me.Panel1)
        Me.PanelKursi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelKursi.Location = New System.Drawing.Point(1088, 114)
        Me.PanelKursi.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.PanelKursi.Name = "PanelKursi"
        Me.PanelKursi.Size = New System.Drawing.Size(816, 457)
        Me.PanelKursi.TabIndex = 14
        Me.PanelKursi.TabStop = False
        Me.PanelKursi.Text = "PILIH KURSI"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(30, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(761, 40)
        Me.Panel1.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(300, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 29)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "LAYAR"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel4)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(1361, 596)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(540, 129)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Keterangan Kursi"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Location = New System.Drawing.Point(338, 43)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(120, 55)
        Me.Panel4.TabIndex = 33
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(6, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 26)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "TERPILIH"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Location = New System.Drawing.Point(186, 43)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(120, 55)
        Me.Panel3.TabIndex = 33
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(7, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 26)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "KOSONG"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(34, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(120, 55)
        Me.Panel2.TabIndex = 32
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(18, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 26)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "TERISI"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnResetKursi)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(1088, 596)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(234, 129)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Aksi"
        '
        'btnResetKursi
        '
        Me.btnResetKursi.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnResetKursi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetKursi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetKursi.ForeColor = System.Drawing.Color.White
        Me.btnResetKursi.Location = New System.Drawing.Point(34, 43)
        Me.btnResetKursi.Name = "btnResetKursi"
        Me.btnResetKursi.Size = New System.Drawing.Size(157, 55)
        Me.btnResetKursi.TabIndex = 30
        Me.btnResetKursi.Text = "BATAL PILIH"
        Me.btnResetKursi.UseVisualStyleBackColor = False
        '
        'FormInputPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1933, 822)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PanelKursi)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormInputPembelian"
        Me.Text = "FormPembelian"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GbTotal.ResumeLayout(False)
        Me.GbTotal.PerformLayout()
        CType(Me.Preview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Header.ResumeLayout(False)
        Me.Header.PerformLayout()
        Me.PanelKursi.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCariPembelian As System.Windows.Forms.Button
    Friend WithEvents txtKodePembelian As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Header As System.Windows.Forms.Panel
    Friend WithEvents btnGoBack As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTanggalBeli As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtJudulFilm As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtKodeFilm As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Preview As System.Windows.Forms.PictureBox
    Friend WithEvents btnPilihFilm As System.Windows.Forms.Button
    Friend WithEvents PanelKursi As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnResetKursi As System.Windows.Forms.Button
    Friend WithEvents PanelSelectedKursi As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtStudio As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GbTotal As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents labelTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtJamTayang As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
