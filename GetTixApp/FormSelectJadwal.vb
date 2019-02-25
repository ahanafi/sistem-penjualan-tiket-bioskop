Public Class FormSelectJadwal

    Public KODE_FILM As String '= "FL-0005"
    Private gbStudio(3) As GroupBox
    Private btnJamTayang(10) As Button
    Private arrKodeJadwal(3) As String
    Private arrNamaJadwal(3) As String
    Private StudioSelected As String
    'Private arrStudio(3) as String

    Private Sub showFilmDetail(ByVal kode_film As String)
        oFilm.Carifilm(kode_film)
        If (cn.RecordFound = True) Then
            cn.DataReader.Read()
            txtKodeFilm.Text = cn.DataReader("kode").ToString()
            txtJudul.Text = cn.DataReader("judul").ToString()
            txtDurasi.Text = cn.DataReader("durasi").ToString()
            txtSinopsis.Text = cn.DataReader("sinopsis").ToString()
            Preview.Image = byteArrayToImage(cn.DataReader("foto"))

            Dim harga As Integer = oFilm.getHarga(kode_film)
            txtHarga.Text = FormatNumber(harga, 0) & ",-"
        End If
    End Sub


    Private Sub FormSelectJadwal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = ""
        Me.ControlBox = False
        If (KODE_FILM <> "") Then
            showFilmDetail(KODE_FILM)
            createBoxStudio()
        Else
            alert("error", "Silahkan pilih film dulu!", True)
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Dashboard.Show()
    End Sub

    Public Function cekJadwal(ByVal jam_tayang As String)
        Dim cek As Boolean = oPembelian.CheckIsFull(jam_tayang)
        Return cek
    End Function

    Public Sub createBoxStudio()
        Dim n As Integer = 0
        Dim xPos As Integer = 25
        Dim yPos As Integer = 45
        Dim x As Integer = 0
        Dim tanggal As String = cn.VBNetDateToMySQLDate(Date.Now.Date)

        DBConnect()
        SQL = "SELECT * FROM jadwal JOIN studio ON jadwal.kode_studio = studio.kode  WHERE kode_film = '" & KODE_FILM & "' AND jadwal.tanggal = '" & tanggal & "'"
        cn.DataReader = cn.searchone(SQL)
        'Put data to Array
        While (cn.DataReader.Read())
            arrKodeJadwal(n) = cn.DataReader("kode").ToString()
            arrNamaJadwal(n) = cn.DataReader("nama_studio").ToString()
            n += 1
        End While

        'Create groupBox Componenets
        For idx As Integer = 0 To n - 1
            gbStudio(idx) = New GroupBox
            With (gbStudio(idx))
                .Text = arrNamaJadwal(idx)
                .Left = xPos
                .Top = yPos
                .Width = 710
                .Height = 140
                yPos = yPos + .Height + 25
                GbListStudio.Controls.Add(gbStudio(idx))
            End With

            'Panggil data jam tayang
            DBConnect()
            Dim SQL_Jam As String = "SELECT DATE_FORMAT(jam_tayang, '%H:%i')  as jam, kode_jadwal FROM detail_jadwal WHERE kode_jadwal = '" & arrKodeJadwal(idx) & "'"
            cn.DataReader = cn.searchone(SQL_Jam)

            Dim btnXpos As Integer = 17
            Dim btnYpos As Integer = 55

            Dim minuteNow As Integer = Date.Now.Minute
            Dim hourNow As Integer = Date.Now.Hour

            'Read data
            While (cn.DataReader.Read())
                Dim jamTayang As String = cn.DataReader("jam").ToString()
                Dim kode_jadwal As String = cn.DataReader("kode_jadwal").ToString()
                Dim waktuTayang() = jamTayang.Split(":")
                Dim menitTyg As Integer = waktuTayang(1)
                Dim jamTyg As Integer = waktuTayang(0)

                btnJamTayang(x) = New Button
                With (btnJamTayang(x))
                    If (hourNow > jamTyg) Then
                        'If (minuteNow > menitTyg) Then
                        '.Enabled = False
                        'End If
                        'Else If (hourNow > jamTyg) Then
                        .Enabled = False
                    End If

                    .Name = kode_jadwal & x
                    .Text = jamTayang
                    .Width = 82
                    .Height = 48
                    .Left = btnXpos
                    .Top = btnYpos
                    .FlatStyle = FlatStyle.Flat
                    .ForeColor = Color.White
                    .BackColor = Color.SteelBlue
                    gbStudio(idx).Controls.Add(btnJamTayang(x))
                    btnXpos = btnXpos + .Width + 10
                    AddHandler .Click, AddressOf Me.selectJamTayang
                End With
                x += 1
            End While
        Next
    End Sub

    Public Sub selectJamTayang(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        If TypeOf sender Is Button Then
            Dim btn As Button = sender
            Dim namaStudio As String = btn.Parent.Text

            pembelian_baru = True
            oFilm.Carifilm(KODE_FILM)
            cn.DataReader.read()
            FormInputPembelian.txtKodeFilm.Text = KODE_FILM
            FormInputPembelian.txtJudulFilm.Text = cn.DataReader("judul").ToString()
            FormInputPembelian.Preview.Image = byteArrayToImage(cn.DataReader("foto"))
            FormInputPembelian.txtKodePembelian.Enabled = False
            FormInputPembelian.btnCariPembelian.Enabled = False
            FormInputPembelian.txtKodeFilm.Enabled = False
            FormInputPembelian.btnPilihFilm.Enabled = False
            FormInputPembelian.txtJamTayang.Text = btn.Text
            FormInputPembelian.txtStudio.Text = namaStudio
            FormInputPembelian.KodeFilm = KODE_FILM
            FormInputPembelian.JAM_TAYANG = btn.Text
            Dim harga As Integer = oFilm.getHarga(KODE_FILM)
            FormInputPembelian.HARGA_TIKET = harga
            FormPembayaran.GbKursi.Controls.Clear()
            FormInputPembelian.GenerateButton(True, 60)
            FormInputPembelian.Show()
            Me.Close()
        End If
    End Sub
End Class