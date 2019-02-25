<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembelian
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataPembelian = New System.Windows.Forms.DataGridView
        Me.btnShow = New System.Windows.Forms.Button
        Me.txtTanggalAkhir = New System.Windows.Forms.DateTimePicker
        Me.txtTanggalAwal = New System.Windows.Forms.DateTimePicker
        Me.keteranganCari = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnGoBack = New System.Windows.Forms.Button
        Me.Header = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtJamTayang = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.GbKursi = New System.Windows.Forms.GroupBox
        Me.txtJudulFilm = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtTotalBayar = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtTanggalBeli = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtKodePembelian = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Header.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataPembelian)
        Me.GroupBox1.Controls.Add(Me.btnShow)
        Me.GroupBox1.Controls.Add(Me.txtTanggalAkhir)
        Me.GroupBox1.Controls.Add(Me.txtTanggalAwal)
        Me.GroupBox1.Controls.Add(Me.keteranganCari)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 116)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 632)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA PEMBELIAN"
        '
        'DataPembelian
        '
        Me.DataPembelian.AllowUserToAddRows = False
        Me.DataPembelian.AllowUserToDeleteRows = False
        Me.DataPembelian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataPembelian.Location = New System.Drawing.Point(25, 86)
        Me.DataPembelian.Name = "DataPembelian"
        Me.DataPembelian.ReadOnly = True
        Me.DataPembelian.RowTemplate.Height = 24
        Me.DataPembelian.Size = New System.Drawing.Size(941, 392)
        Me.DataPembelian.TabIndex = 23
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Location = New System.Drawing.Point(825, 41)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(141, 34)
        Me.btnShow.TabIndex = 22
        Me.btnShow.Text = "TAMPILKAN"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'txtTanggalAkhir
        '
        Me.txtTanggalAkhir.CustomFormat = "yyyy-MM-dd"
        Me.txtTanggalAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTanggalAkhir.Location = New System.Drawing.Point(574, 38)
        Me.txtTanggalAkhir.Name = "txtTanggalAkhir"
        Me.txtTanggalAkhir.Size = New System.Drawing.Size(210, 34)
        Me.txtTanggalAkhir.TabIndex = 21
        '
        'txtTanggalAwal
        '
        Me.txtTanggalAwal.CustomFormat = "yyyy-MM-dd"
        Me.txtTanggalAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTanggalAwal.Location = New System.Drawing.Point(314, 38)
        Me.txtTanggalAwal.Name = "txtTanggalAwal"
        Me.txtTanggalAwal.Size = New System.Drawing.Size(210, 34)
        Me.txtTanggalAwal.TabIndex = 21
        '
        'keteranganCari
        '
        Me.keteranganCari.AutoSize = True
        Me.keteranganCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keteranganCari.Location = New System.Drawing.Point(20, 490)
        Me.keteranganCari.Name = "keteranganCari"
        Me.keteranganCari.Size = New System.Drawing.Size(0, 25)
        Me.keteranganCari.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 520)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(677, 26)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "* NOTE :  Klik Data Pembelian untuk melihat detail pembelian."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 29)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Pilih Range Tanggal"
        '
        'btnGoBack
        '
        Me.btnGoBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoBack.Location = New System.Drawing.Point(403, 18)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(120, 41)
        Me.btnGoBack.TabIndex = 1
        Me.btnGoBack.Text = "Kembali"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Header.Controls.Add(Me.btnGoBack)
        Me.Header.Controls.Add(Me.Label1)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1803, 82)
        Me.Header.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data Pembelian Tiket"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtJamTayang)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.GbKursi)
        Me.GroupBox3.Controls.Add(Me.txtJudulFilm)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtTotalBayar)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtTanggalBeli)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtKodePembelian)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(1065, 116)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(830, 478)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DETAIL PEMBELIAN"
        '
        'txtJamTayang
        '
        Me.txtJamTayang.CustomFormat = "HH:mm"
        Me.txtJamTayang.Enabled = False
        Me.txtJamTayang.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtJamTayang.Location = New System.Drawing.Point(652, 111)
        Me.txtJamTayang.Name = "txtJamTayang"
        Me.txtJamTayang.Size = New System.Drawing.Size(137, 34)
        Me.txtJamTayang.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(463, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 29)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Jam Tayang"
        '
        'GbKursi
        '
        Me.GbKursi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbKursi.Location = New System.Drawing.Point(34, 290)
        Me.GbKursi.Name = "GbKursi"
        Me.GbKursi.Size = New System.Drawing.Size(755, 130)
        Me.GbKursi.TabIndex = 25
        Me.GbKursi.TabStop = False
        Me.GbKursi.Text = "Nomor Kursi"
        '
        'txtJudulFilm
        '
        Me.txtJudulFilm.Location = New System.Drawing.Point(228, 227)
        Me.txtJudulFilm.Name = "txtJudulFilm"
        Me.txtJudulFilm.ReadOnly = True
        Me.txtJudulFilm.Size = New System.Drawing.Size(561, 34)
        Me.txtJudulFilm.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 29)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Judul Film"
        '
        'txtTotalBayar
        '
        Me.txtTotalBayar.Location = New System.Drawing.Point(228, 170)
        Me.txtTotalBayar.Name = "txtTotalBayar"
        Me.txtTotalBayar.ReadOnly = True
        Me.txtTotalBayar.Size = New System.Drawing.Size(561, 34)
        Me.txtTotalBayar.TabIndex = 22
        Me.txtTotalBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 29)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Total Bayar"
        '
        'txtTanggalBeli
        '
        Me.txtTanggalBeli.CustomFormat = "yyyy-MM-dd"
        Me.txtTanggalBeli.Enabled = False
        Me.txtTanggalBeli.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTanggalBeli.Location = New System.Drawing.Point(228, 111)
        Me.txtTanggalBeli.Name = "txtTanggalBeli"
        Me.txtTanggalBeli.Size = New System.Drawing.Size(180, 34)
        Me.txtTanggalBeli.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 29)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Tanggal Beli"
        '
        'txtKodePembelian
        '
        Me.txtKodePembelian.Location = New System.Drawing.Point(228, 54)
        Me.txtKodePembelian.Name = "txtKodePembelian"
        Me.txtKodePembelian.ReadOnly = True
        Me.txtKodePembelian.Size = New System.Drawing.Size(561, 34)
        Me.txtKodePembelian.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(193, 29)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Kode Pembelian"
        '
        'FormPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1803, 829)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPembelian"
        Me.Text = "FormPembelian"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Header.ResumeLayout(False)
        Me.Header.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGoBack As System.Windows.Forms.Button
    Friend WithEvents Header As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtJamTayang As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GbKursi As System.Windows.Forms.GroupBox
    Friend WithEvents txtJudulFilm As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotalBayar As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTanggalBeli As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtKodePembelian As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents txtTanggalAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTanggalAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataPembelian As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents keteranganCari As System.Windows.Forms.Label
End Class
