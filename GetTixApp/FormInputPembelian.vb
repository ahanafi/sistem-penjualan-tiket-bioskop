Public Class FormInputPembelian

    Private btnKursi(60) As Button
    Private btnSelectedKursi(6) As Button
    Public TGL_SKRG As String = cn.VBNetDateToMySQLDate(Date.Now)
    Public KodeFilm As String
    Public JUMLAH_KURSI As Integer
    Private ListKursi As List(Of String) = New List(Of String)
    Public JAM_TAYANG As String
    Public HARGA_TIKET As Integer

    Private Sub FormPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = ""
        Me.ControlBox = False
        txtKodePembelian.Text = getKode("pembelian", "INV")
        'txtKodePembelian.Focus()
        logged_in_level = True
        If (logged_in_level = False) Then
            btnHapus.Visible = False
        End If

        'Generate button without valdate
        'GenerateButton(False, 60)

        If (KodeFilm = "") Then
            btnResetKursi.Enabled = False
        End If
    End Sub

    Private Sub btnGoBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoBack.Click
        Me.Close()
        Dashboard.Show()
    End Sub

    Private Sub btnCariPembelian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariPembelian.Click
        Dim kode_pembelian As String = txtKodePembelian.Text
        If (kode_pembelian <> "") Then
            oPembelian.Caripembelian(kode_pembelian)
            If (cn.RecordFound = True) Then
                pembelian_baru = False
                TampilkanDataPembelian()
            Else
                ClearData()
                PanelSelectedKursi.Controls.Clear()
                pembelian_baru = True
                txtKodeFilm.Text = "FL-0000"
            End If
        Else
            MsgBox("Masukkan kode pembelian!", MsgBoxStyle.Critical, "Error!")
        End If
    End Sub

    Private Sub TampilkanDataPembelian()
        Dim kode As String = txtKodePembelian.Text
        oPembelian.Caripembelian(kode)
        cn.DataReader.Read()
        txtTanggalBeli.Text = cn.DataReader("tanggal_beli").ToString()
        Dim kode_film As String = cn.DataReader("kode_film").ToString()
        txtKodeFilm.Text = kode_film
        labelTotal.Text = FormatNumber(cn.DataReader("total_bayar").ToString(), 0)
        Dim jam_tayang As String = cn.DataReader("jam").ToString()

        btnPilihFilm.Enabled = False

        oFilm.Carifilm(kode_film)
        cn.DataReader.Read()

        'Mengiisi kolom judul
        txtJudulFilm.Text = cn.DataReader("judul").ToString()
        Preview.Image = byteArrayToImage(cn.DataReader("foto"))

        Dim today As String = changeDateToDBFormat(Date.Now.Date)
        DBConnect()
        SQL = "SELECT jam_tayang,kode_studio FROM jadwal JOIN detail_jadwal ON jadwal.kode = detail_jadwal.kode_jadwal WHERE jadwal.kode_film = '" & kode_film & "' AND jadwal.tanggal = '" & today & "'"
        cn.DataReader = cn.searchone(SQL)
        Dim kode_studio As String = ""
        Dim jamSkrg As Integer = Date.Now.Hour

        oStudio.Caristudio(kode_studio)
        cn.DataReader.read()
        txtStudio.Text = cn.DataReader("nama_studio").ToString()
        GenerateButton(False, 60)
        drawButton(kode)
        btnSimpan.Enabled = False

    End Sub

    Private Sub ClearData()
        txtKodePembelian.Clear()
        txtTanggalBeli.Value = Date.Now
        txtKodePembelian.Text = getKode("pembelian", "INV")
        txtKodeFilm.Text = "FL-0000"
        txtJudulFilm.Clear()
        txtStudio.Clear()
        txtKodePembelian.Focus()
        txtKodePembelian.Enabled = True
        btnCariPembelian.Enabled = True
        txtKodeFilm.Enabled = True
        btnPilihFilm.Enabled = True
        Preview.Image = New Bitmap(GetTixApp.My.Resources.Resources.No_Image_Available)
        labelTotal.Text = "0,-"
        txtJamTayang.Clear()
        ListKursi.Clear()
    End Sub

    Private Sub SimpanDatapembelian()
        oPembelian.kode = txtKodePembelian.Text
        oPembelian.kode_film = txtKodeFilm.Text
        oPembelian.total_bayar = 0
        oPembelian.tanggal_beli = txtTanggalBeli.Text
        oPembelian.jam = txtJamTayang.Text
        oPembelian.Simpan()
    End Sub

    Private Sub SimpanDetailPembelian()
        Dim totalKursi As Integer = ListKursi.Count
        Dim idx As Integer = 0
        If (totalKursi <> 0) Then
            If (idx < 6) Then
                For Each kursi As String In ListKursi
                    oPembelian.kode_pembelian = txtKodePembelian.Text
                    oPembelian.nomor_kursi = kursi
                    oPembelian.SimpanDetail()
                Next
                idx = idx + 1
            End If
        End If
    End Sub

    Private Sub HapusPembelian()
        If (pembelian_baru = False And txtKodePembelian.Text <> "") Then
            oPembelian.Hapus(txtKodePembelian.Text)
            ClearData()
        End If
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Dim kode_pembelian As String = txtKodePembelian.Text
        Dim kode_film As String = txtKodeFilm.Text
        Dim tanggal_beli As String = txtTanggalBeli.Text
        Dim jam As String = txtJamTayang.Text
        Dim cek_pembelian As Boolean = oPembelian.cekPembelian(kode_pembelian)

        If (kode_pembelian <> "" And kode_film <> "" And tanggal_beli <> "" And jam <> "" And ListKursi.Count > 0) Then
            Dim totalKursi As Integer = ListKursi.Count
            Dim lebihKursi As Integer
            If (totalKursi > 6) Then
                lebihKursi = totalKursi - 6
                ListKursi.RemoveRange(6, lebihKursi)
            End If

            If (cek_pembelian = False) Then
                pembelian_baru = True
                SimpanDatapembelian()
            End If

            detail_pembelian_baru = True
            SimpanDetailPembelian()

            Dim total_bayar = oPembelian.getTotalBayar(kode_pembelian)
            oPembelian.updateTotal(txtKodePembelian.Text, total_bayar)

            Me.Refresh()
            Me.Close()
            FormPembayaran.KODE_BELI = kode_pembelian
            FormPembayaran.txtKodeBeli.ReadOnly = True
            FormPembayaran.btnCari.Enabled = False
            FormPembayaran.showInvoiceData()
            FormPembayaran.Show()

            ClearData()
            For i As Integer = 0 To 59
                addStyle(i, False)
            Next
            PanelSelectedKursi.Controls.Clear()

            'Generate button without validate
            GenerateButton(False, 60)
        Else
            MsgBox("Form tidak boleh ada yang kosong!", MsgBoxStyle.Information, "Informasi!")
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ClearData()
        For i As Integer = 0 To 59
            addStyle(i, False)
        Next
        PanelSelectedKursi.Controls.Clear()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Dim kode_pembelian As String = txtKodePembelian.Text
        If (kode_pembelian <> "") Then
            oPembelian.Caripembelian(kode_pembelian)
            If (cn.RecordFound = True) Then
                Dim jawab As Integer
                jawab = MessageBox.Show("Apakah Anda yakin akan menghapus data ini?", "Confirm", MessageBoxButtons.YesNo)
                If (jawab = vbYes) Then
                    HapusPembelian()
                Else
                    MsgBox("Data batal dihapus", MsgBoxStyle.Information, "Notifikasi")
                End If
            End If
        Else
            MsgBox("Masukkan kode pembelian!", MsgBoxStyle.Information, "Informasi")
            txtKodePembelian.Focus()
        End If
    End Sub

    Private Sub btnPilihFilm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPilihFilm.Click
        FormSelectFilm.Show()
        Me.Close()
        'Dashboard.Show()
    End Sub

    Public Sub GenerateButton(ByVal validate As Boolean, ByVal totalKursi As Integer)
        Dim n As Integer = 0
        Dim xPos As Integer = 30
        Dim yPos As Integer = 114
        For i As Integer = 0 To totalKursi - 1
            btnKursi(i) = New System.Windows.Forms.Button
        Next i

        While (n < totalKursi)
            With (btnKursi(n))
                .Name = n + 1
                .Text = "A" & n + 1
                .Font = New Font("Microsoft Sans Serif", 11, FontStyle.Regular)

                If (n > 9) And (n < 20) Then
                    .Text = "B" & (n - 9)
                ElseIf (n > 19) And (n < 30) Then
                    .Text = "C" & (n - 19)
                ElseIf (n > 29) And (n < 40) Then
                    .Text = "D" & (n - 29)
                ElseIf (n > 39) And (n < 50) Then
                    .Text = "E" & (n - 39)
                ElseIf (n > 49) Then
                    .Text = "F" & (n - 49)
                End If

                .Width = 61 '122
                .Height = 40 '80
                .BackColor = Color.White

                If (validate = True) Then
                    Dim jamTayang As String = txtJamTayang.Text
                    Dim cek As Boolean = oPembelian.cekKursi(.Text, TGL_SKRG, JAM_TAYANG, KodeFilm)
                    If (cek = True) Then
                        .BackColor = Color.Red
                        .ForeColor = Color.White
                        .FlatStyle = FlatStyle.Flat
                        .Enabled = False
                    End If
                Else
                    .Enabled = False
                End If

                .FlatStyle = FlatStyle.Flat

                'Buat sekat
                If (n = 3) Or (n = 13) Or (n = 23) Or (n = 33) Or (n = 43) Or (n = 53) Or (n = 7) Or (n = 17) Or (n = 27) Or (n = 37) Or (n = 47) Or (n = 57) Then
                    xPos = xPos + 20
                End If

                If (n = 10) Then
                    xPos = 30
                    yPos = 165 ' 61 + 44
                ElseIf (n = 20) Then
                    xPos = 30
                    yPos = 216 ' 105 + 44
                ElseIf (n = 30) Then
                    xPos = 30
                    yPos = 268
                ElseIf (n = 40) Then
                    xPos = 30
                    yPos = 320
                ElseIf (n = 50) Then
                    xPos = 30
                    yPos = 372
                End If

                .Left = xPos
                .Top = yPos

                PanelKursi.Controls.Add(btnKursi(n))
                xPos = xPos + .Width + 12
                AddHandler .Click, AddressOf Me.pilihKursi
                n += 1


            End With
        End While
    End Sub

    Public Sub pilihKursi(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        If TypeOf sender Is Button Then
            If (txtKodeFilm.Text = "FL-0000" Or txtKodeFilm.Text = "") Then
                alert("warning", "Silahkan pilih film terlebih dahulu!", False)
            Else
                Dim btn As Button = sender
                Dim index As Integer = btn.Name - 1 'Index button Array
                Dim nomor_kursi As String = btn.Text

                'Masukkan text button ke list
                ListKursi.Add(nomor_kursi)

                'Convert list ke array
                Dim ArrayListKursi() As String = ListKursi.ToArray()

                Dim xPos As Integer = 0, yPos As Integer = 0
                Dim lengthArr = ArrayListKursi.Length
                Dim countList = ListKursi.Count
                Dim msg As String = "List ada " & countList & " & array ada " & lengthArr
                'MsgBox(msg)

                'Tambahkan Style
                addStyle(index, True)

                If (countList = 1 And lengthArr = 1) Then
                    btnSelectedKursi(1) = New Button
                    With (btnSelectedKursi(1))
                        .Text = nomor_kursi
                        .Width = 61
                        .Height = 34
                        .Left = xPos
                        .Top = yPos
                        .Enabled = False
                        .BackColor = Color.White
                        .ForeColor = Color.Black

                        PanelSelectedKursi.Controls.Add(btnSelectedKursi(1))
                        xPos = xPos + .Width + 15
                    End With
                    labelTotal.Text = FormatNumber(HARGA_TIKET, 0) & ",-"
                Else
                    If (lengthArr <= 6) Then
                        For idx As Integer = 1 To lengthArr
                            btnSelectedKursi(idx) = New Button
                            With (btnSelectedKursi(idx))
                                .Text = nomor_kursi
                                .Width = 61
                                .Height = 34
                                .Left = xPos
                                .Top = yPos
                                .Enabled = False
                                .BackColor = Color.White
                                .ForeColor = Color.Black

                                PanelSelectedKursi.Controls.Add(btnSelectedKursi(idx))
                                xPos = xPos + .Width + 15
                            End With
                        Next
                        labelTotal.Text = FormatNumber(HARGA_TIKET * lengthArr, 0) & ",-"
                    Else
                        alert("warning", "Maksimal pembelian tiket adalah 6!", False)
                        addStyle(index, False)
                    End If
                End If
            End If
        End If
    End Sub

    'Untuk memberikan style pada kursi
    Public Sub addStyle(ByVal index As Integer, ByVal isSelect As Boolean)
        If (isSelect = True) Then
            btnKursi(index).BackColor = Color.DodgerBlue
            btnKursi(index).ForeColor = Color.White
            btnKursi(index).Enabled = False
        Else
            btnKursi(index).BackColor = Color.White
            btnKursi(index).ForeColor = Color.Black
            btnKursi(index).Enabled = True
        End If
    End Sub

    'Untuk me-reset kursi yang dipilih
    Private Sub btnResetKursi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetKursi.Click
        For i As Integer = 0 To 59
            If (KodeFilm <> "" And JAM_TAYANG <> "") Then
                Dim no_kursi As String = "A" & i + 1
                If (i > 9) And (i < 20) Then
                    no_kursi = "B" & (i - 9)
                ElseIf (i > 19) And (i < 30) Then
                    no_kursi = "C" & (i - 19)
                ElseIf (i > 29) And (i < 40) Then
                    no_kursi = "D" & (i - 29)
                ElseIf (i > 39) And (i < 50) Then
                    no_kursi = "E" & (i - 39)
                ElseIf (i > 49) Then
                    no_kursi = "F" & (i - 49)
                End If

                Dim cek As Boolean = oPembelian.cekKursi(no_kursi, TGL_SKRG, JAM_TAYANG, KodeFilm)
                If (cek = False) Then
                    addStyle(i, False)
                End If
            End If
        Next
        PanelSelectedKursi.Controls.Clear()
        ListKursi.Clear()
        labelTotal.Text = "0,-"
    End Sub

    'DrawButton
    Private Sub drawButton(ByVal kode_pembelian As String)
        Dim n As Integer = 0
        Dim xPos As Integer = 0
        Dim yPos As Integer = 3

        'Get Kursi
        DBConnect()
        SQL = "SELECT nomor_kursi as kursi FROM detail_pembelian WHERE kode_pembelian = '" & kode_pembelian & "'"
        cn.DataReader = cn.searchone(SQL)

        While (cn.DataReader.Read())
            btnSelectedKursi(n) = New System.Windows.Forms.Button
            With (btnSelectedKursi(n))
                .Text = cn.DataReader("kursi")
                .Width = 61
                .Height = 34
                .BackColor = Color.White
                .Enabled = False
                .FlatStyle = FlatStyle.Flat
                .Left = xPos
                .Top = yPos
                PanelSelectedKursi.Controls.Add(btnSelectedKursi(n))
                xPos = xPos + .Width + 15
                n += 1
            End With
        End While
    End Sub
End Class