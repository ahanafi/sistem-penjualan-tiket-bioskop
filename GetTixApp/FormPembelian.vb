Public Class FormPembelian

    Private btnKursi(6) As Button
    Private Sub FormPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = ""
        Me.ControlBox = False
        txtJamTayang.Text = "00:00"
        DataPembelian.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Regular)
    End Sub

    Private Sub btnGoBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoBack.Click
        Dashboard.Show()
        Me.Close()
    End Sub

    Private Sub ResetForm()
        txtJamTayang.Text = "00:00"
        txtKodePembelian.Clear()
        txtTanggalBeli.Value = Date.Today
        txtTotalBayar.Clear()
        txtJudulFilm.Clear()
        GbKursi.Controls.Clear()
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim tanggal_awal As String = txtTanggalAwal.Text
        Dim tanggal_akhir As String = txtTanggalAkhir.Text

        If (tanggal_awal <> "" And tanggal_akhir <> "") Then
            oPembelian.getByDate(tanggal_awal, tanggal_akhir, DataPembelian)
            ResetForm()
            Dim totalItem As Integer = DataPembelian.Rows.Count
            keteranganCari.Text = "Total data pembelian dari tanggal " & tanggal_awal & " sampai dengan tanggal " & tanggal_akhir & " adalah " & totalItem & " buah data"
        Else
            alert("warning", "Silahkan pilih tanggal terlebih dahulu!", False)
            txtTanggalAwal.Focus()
        End If
    End Sub

    Private Sub DataPembelian_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataPembelian.CellContentClick
        Dim indexRow As Integer = DataPembelian.CurrentRow.Index
        Dim KODE_PEMBELIAN As String = DataPembelian.Rows(indexRow).Cells(1).Value
        GbKursi.Controls.Clear()

        oPembelian.Caripembelian(KODE_PEMBELIAN)
        'Cek data pembelian
        If (cn.RecordFound = True) Then
            cn.DataReader.read()
            txtKodePembelian.Text = Convert.ToString(cn.DataReader("kode"))
            txtTanggalBeli.Text = Convert.ToString(cn.DataReader("tanggal_beli"))
            txtTotalBayar.Text = FormatNumber(Convert.ToString(cn.DataReader("total_bayar")), 0)
            txtJamTayang.Text = Convert.ToString(cn.DataReader("jam"))

            oFilm.Carifilm(cn.DataReader("kode_film").ToString())
            cn.DataReader.read()
            txtJudulFilm.Text = cn.DataReader("judul")

            drawButton(KODE_PEMBELIAN)
        Else
            alert("error", "Data pembelian tidak ditemukan!", True)
            ResetForm()
            DataPembelian.DataSource = DBNull.Value
            DataPembelian.DataSource = Nothing
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