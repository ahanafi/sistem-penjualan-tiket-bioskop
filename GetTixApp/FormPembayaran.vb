Public Class FormPembayaran
    Dim kembalian As String
    Dim TOTAL_BAYAR As String
    Dim btnKursi(6) As Button
    Public KODE_BELI As String

    Private Sub FormPembayaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = ""
        Me.ControlBox = False
        txtKodeBeli.Focus()
        If (logged_in_level = False) Then
            btnHapus.Visible = False
        End If
        txtJamTayang.Text = "00:00"
    End Sub

    Private Sub btnGoBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoBack.Click
        Me.Close()
        Dashboard.Show()
    End Sub

    Public Sub showInvoiceData()
        Dim kode_pembelian As String = KODE_BELI
        oPembelian.Caripembelian(kode_pembelian)
        'Cek data pembelian
        If (cn.RecordFound = True) Then
            cn.DataReader.read()
            txtKodeBeli.Text = Convert.ToString(cn.DataReader("kode"))
            txtKodePembelian.Text = Convert.ToString(cn.DataReader("kode"))
            txtTanggalBeli.Text = Convert.ToString(cn.DataReader("tanggal_beli"))
            txtTotalBayar.Text = Format(Val(cn.DataReader("total_bayar")), "###,###") & ",-"
            txtJamTayang.Text = Convert.ToString(cn.DataReader("jam"))

            oFilm.Carifilm(cn.DataReader("kode_film").ToString())
            cn.DataReader.read()
            txtJudulFilm.Text = cn.DataReader("judul")

            drawButton(kode_pembelian)

            btnSimpan.Enabled = True
            txtJumlahUang.Clear()
            txtJumlahUang.ReadOnly = False
            txtKembalian.Text = "0,-"
            txtJumlahUang.Focus()
            TOTAL_BAYAR = Val(txtTotalBayar.Text)
            pembayaran_baru = True
        End If
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Dim kode_pembelian As String = txtKodeBeli.Text
        If (kode_pembelian <> "") Then
            oPembelian.Caripembelian(kode_pembelian)
            'Cek data pembelian
            If (cn.RecordFound = True) Then
                cn.DataReader.read()
                txtKodeBeli.Text = Convert.ToString(cn.DataReader("kode"))
                txtKodePembelian.Text = Convert.ToString(cn.DataReader("kode"))
                txtTanggalBeli.Text = Convert.ToString(cn.DataReader("tanggal_beli"))
                txtTotalBayar.Text = Format(Val(cn.DataReader("total_bayar")), "###,###") & ",-"
                txtTotalBayar.SelectionStart = Len(txtTotalBayar.Text)
                txtJamTayang.Text = Convert.ToString(cn.DataReader("jam"))

                oFilm.Carifilm(cn.DataReader("kode_film").ToString())
                cn.DataReader.read()
                txtJudulFilm.Text = cn.DataReader("judul")

                drawButton(kode_pembelian)

                'Cek data pembayaran
                oPembayaran.cekPembayaran(kode_pembelian)
                If (cn.RecordFound = True) Then

                    oPembayaran.Caripembayaran(kode_pembelian)
                    txtJumlahUang.Text = oPembayaran.jumlah_bayar
                    txtTanggalBayar.Text = oPembayaran.tanggal
                    txtJumlahUang.ReadOnly = True
                    btnSimpan.Enabled = False
                    Dim total_bayar As Integer = oPembelian.getTotalBayar(kode_pembelian)
                    Dim jumlah_uang As Integer = Val(Format(txtJumlahUang.Text, "General Number"))
                    Dim kembalian As Integer = jumlah_uang - Val(total_bayar)
                    If (kembalian = 0) Then
                        txtKembalian.Text = "0,-"
                    Else
                        txtKembalian.Text = Format(kembalian, "###,###") & ",-"
                    End If
                Else
                    btnSimpan.Enabled = True
                    txtJumlahUang.Clear()
                    txtJumlahUang.ReadOnly = False
                    txtKembalian.Text = "0,-"
                    txtJumlahUang.Focus()
                    TOTAL_BAYAR = Val(txtTotalBayar.Text)
                    pembayaran_baru = True
                End If
            Else
                txtKodeBeli.Focus()
            End If
        Else
            MsgBox("Masukkan kode pembelian!", MsgBoxStyle.Critical, "Error!")
            txtKodeBeli.Focus()
        End If
    End Sub

    Public Sub ResetAllForm()
        txtKodeBeli.Clear()
        txtKodeBeli.Focus()
        txtJumlahUang.Clear()
        txtTanggalBayar.Value = Date.Now
        txtKodePembelian.Clear()
        txtTanggalBeli.Value = Date.Now
        txtTotalBayar.Text = "0,-"
        txtKodeBeli.Text = "INV-0000"
        txtKembalian.Text = "0,-"
        txtJumlahUang.ReadOnly = False
        GbKursi.Controls.Clear()
        txtJamTayang.Text = "00:00"
        txtKodeBeli.ReadOnly = False
        btnCari.Enabled = True
    End Sub

    Private Sub SimpanDatapembayaran()
        oPembayaran.kode_pembelian = txtKodeBeli.Text
        oPembayaran.jumlah_bayar = txtJumlahUang.Text
        oPembayaran.tanggal = txtTanggalBayar.Text
        oPembayaran.Simpan()
    End Sub

    Private Sub HapusPembayaran()
        If (txtKodePembelian.Text <> "" And pembayaran_baru = False) Then
            oPembayaran.Hapus(txtKodePembelian.Text)
            ResetAllForm()
        End If
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Dim kode_pembelian As String = txtKodeBeli.Text
        Dim jumlah_bayar As Double = Val(txtJumlahUang.Text)
        Dim tanggal_bayar As String = txtTanggalBayar.Text
        If (kode_pembelian <> "" And jumlah_bayar > 0) Then
            SimpanDatapembayaran()
            oPembelian.Bayar(kode_pembelian)
            ResetAllForm()
            Me.Close()
            Dashboard.Show()
        Else
            MsgBox("Form pembayaran tidak boleh kosong!", MsgBoxStyle.Critical, "Error!")
            txtKodeBeli.Focus()
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ResetAllForm()
    End Sub

    Private Sub txtJumlahUang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJumlahUang.TextChanged
        Dim kode_pembelian As String = txtKodePembelian.Text
        If (kode_pembelian <> "") Then
            Dim total_bayar As Integer = oPembelian.getTotalBayar(kode_pembelian)
            Dim kembali As Integer = Val(Format(txtJumlahUang.Text, "General Number")) - Val(total_bayar)
            If (kembali = 0) Then
                txtKembalian.Text = "0,-"
            Else
                txtKembalian.Text = Format(kembali, "###,###") & ",-"
            End If
        End If
        If (txtJumlahUang.Text <> "") Then
            txtJumlahUang.Text = FormatNumber((txtJumlahUang.Text), 0)
            txtJumlahUang.SelectionStart = Len(txtJumlahUang.Text)
        End If
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Dim kode_pembelian As String = txtKodePembelian.Text
        If (kode_pembelian <> "" And pembayaran_baru = False) Then
            Dim jawab As Integer
            jawab = MessageBox.Show("Apakah Anda yakin akan menghapus data ini?", "Confirm", MessageBoxButtons.YesNo)
            If (jawab = vbYes) Then
                HapusPembayaran()
            Else
                MsgBox("Data batal dihapus", MsgBoxStyle.Information, "Notifikasi")
            End If
        Else
            MsgBox("Masukkan kode pembelian!", MsgBoxStyle.Critical, "Error!")
            ResetAllForm()
        End If
    End Sub

    Private Sub drawButton(ByVal kode_pembelian As String)
        Dim n As Integer = 0
        Dim xPos As Integer = 20
        Dim yPos As Integer = 43

        'Get Kursi
        DBConnect()
        SQL = "SELECT nomor_kursi as kursi FROM detail_pembelian WHERE kode_pembelian = '" & kode_pembelian & "'"
        cn.DataReader = cn.searchone(SQL)

        While (cn.DataReader.Read())
            btnKursi(n) = New System.Windows.Forms.Button
            With (btnKursi(n))
                .Text = cn.DataReader("kursi")
                .Width = 100
                .Height = 60
                .BackColor = Color.White
                .Enabled = False
                .FlatStyle = FlatStyle.Flat
                .Left = xPos
                .Top = yPos
                GbKursi.Controls.Add(btnKursi(n))
                xPos = xPos + .Width + 10
                n += 1
            End With
        End While
    End Sub
End Class