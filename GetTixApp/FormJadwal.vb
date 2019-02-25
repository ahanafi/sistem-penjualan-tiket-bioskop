Public Class FormJadwal
    Private Sub FormJadwal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = ""
        Me.ControlBox = False
        txtKode.Text = getKode("jadwal", "JD")
        txtKode.Focus()
        txtJam.Text = "00:00"
        fillCombo()
        fillComboShowBy()
        valTanggal.Visible = False
        DataListJadwal.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Regular)
    End Sub

    Private Sub ReloadData(ByVal kode_jadwal As String)
        oJadwal.getAllDataDetail(DataListJadwal, kode_jadwal)
    End Sub

    Private Sub ResetAll()
        txtKode.Clear()
        txtTanggal.Value = Date.Now
        txtKodeFilm.Clear()
        txtJudul.Clear()
        txtKode.Text = getKode("jadwal", "JD")
        txtKode.Focus()
        Preview.Image = New Bitmap(GetTixApp.My.Resources.Resources.No_Image_Available)
        txtJam.Text = "00:00"
        cbStudio.SelectedIndex = -1
        cbStudio.SelectedText = "-- Pilih Studio --"
        txtDurasi.Clear()
        txtKodeFilm.Text = "FL-0000"
        txtTanggal.Enabled = True
        DataListJadwal.DataSource = Nothing
        btnCari.Enabled = True
    End Sub

    Private Sub setFormInput(ByVal isEnabled As Boolean)
        txtKode.Enabled = isEnabled
        cbStudio.Enabled = isEnabled
        txtKodeFilm.Enabled = isEnabled
        txtJudul.Enabled = isEnabled
        txtDurasi.Enabled = isEnabled
        btnCari.Enabled = isEnabled
        btnCariFilm.Enabled = isEnabled
        btnSet.Enabled = isEnabled
    End Sub

    Private Sub Hapus()
        If (jadwal_baru = False And txtKode.Text <> "") Then
            oJadwal.Hapus(txtKode.Text)
            ResetAll()
        End If
    End Sub


    Private Sub SimpanDataJadwal()
        oJadwal.kode = txtKode.Text
        oJadwal.kode_studio = cbStudio.SelectedItem("kode")
        oJadwal.tanggal = txtTanggal.Text
        oJadwal.kode_film = txtKodeFilm.Text
        oJadwal.Simpan()
    End Sub

    Private Sub SimpanDetailJadwal()
        oJadwal.kode_jadwal = txtKode.Text
        oJadwal.tanggal = txtTanggal.Text
        oJadwal.jam_tayang = txtJam.Text
        oJadwal.SimpanDetail()
    End Sub

    Private Sub btnGoBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoBack.Click
        Me.Close()
        Dashboard.Refresh()
        Dashboard.Show()
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Dim kode_jadwal As String = txtKode.Text
        If (kode_jadwal <> "") Then
            oJadwal.Carijadwal(kode_jadwal)
            If (cn.RecordFound = True) Then
                txtKodeFilm.Text = oJadwal.kode_film
                oFilm.Carifilm(oJadwal.kode_film)
                cn.DataReader.Read()
                txtJudul.Text = Convert.ToString(cn.DataReader("judul"))
                txtDurasi.Text = Convert.ToString(cn.DataReader("durasi"))
                Preview.Image = byteArrayToImage(cn.DataReader("foto"))
                cbStudio.SelectedValue = oJadwal.kode_studio
                setFormInput(False)
                txtTanggal.Enabled = False
                ReloadData(kode_jadwal)
                txtJam.Focus()
            Else
                cbStudio.Focus()
                txtKodeFilm.Text = "FL-0000"
            End If
        Else
            MsgBox("Masukkan kode jadwal!", MsgBoxStyle.Critical, "Error!")
            txtKode.Focus()
        End If
    End Sub

    Public Sub fillCombo()
        DBConnect()
        SQL = "SELECT kode, nama_studio FROM studio"
        cn.DataReader = cn.searchone(SQL)
        cn.Data_Combo(cbStudio, "studio", "kode", "nama_studio")
        cbStudio.SelectedIndex = -1
        cbStudio.DisplayMember = "-- Pilih Studio --"
    End Sub

    Private Sub btnCariFilm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariFilm.Click
        'Dim kode_film As String = txtKodeFilm.Text
        'If (kode_film <> "") Then
        'oFilm.Carifilm(kode_film)
        'If (cn.RecordFound = True) Then
        'cn.DataReader.read()
        'txtJudul.Text = Convert.ToString(cn.DataReader("judul"))
        'txtDurasi.Text = Convert.ToString(cn.DataReader("durasi"))
        'Preview.Image = byteArrayToImage(cn.DataReader("foto"))
        'Else
        'txtKodeFilm.Focus()
        'End If
        'Else
        'alert("error", "Masukkan kode film!", True)
        'txtKodeFilm.Text = "FL-0000"
        'txtKodeFilm.Focus()
        'End If
        FormJadwalPilihFilm.ShowDialog()
    End Sub

    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet.Click
        Dim kode_jadwal As String = txtKode.Text
        Dim kode_film As String = txtKodeFilm.Text
        Dim jam_tayang As String = txtJam.Text
        Dim nama_studio As String = cbStudio.Text
        Dim kode_studio As String = cbStudio.SelectedValue

        If (kode_jadwal <> "" And kode_film <> "") Then
            Dim TayangHariIni As Integer = oJadwal.cekShowsToday()
            If (TayangHariIni = 10) Then
                alert("info", "Jadwal tayang film Maksimal 10.                                                        Anda tidak dapat membuat jadwal baru!", False)
            Else
                Dim validasi = oJadwal.validate(kode_studio, kode_film)
                If (validasi = True) Then
                    alert("info", "Jadwal tayang film tersebut pada studio " & nama_studio & " telah tersedia! Silahkan update jadwal!", False)
                Else
                    setFormInput(False)
                    jadwal_baru = True
                    SimpanDataJadwal()
                    txtTanggal.Enabled = False
                    ReloadData(kode_jadwal)
                End If
            End If
        Else
            alert("info", "Form inputan tidak boleh ada yang kosong!", False)
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ResetAll()
        setFormInput(True)
        txtTanggal.Focus()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Dim kode_jadwal As String = txtKode.Text
        Dim tanggal As String = txtTanggal.Text
        Dim jam_tayang As String = txtJam.Text
        Dim kode_studio As String = cbStudio.SelectedValue
        Dim nama_Studio As String = cbStudio.Text
        Dim kode_film As String = txtKodeFilm.Text

        If (kode_jadwal <> "" And tanggal <> "" And jam_tayang <> "") Then
            Dim cekJadwal As Boolean = oJadwal.validateByTime(tanggal, jam_tayang, kode_studio)
            If (cekJadwal = False) Then
                detail_jadwal_baru = True
                SimpanDetailJadwal()
                txtJam.Text = "00:00"
                ReloadData(kode_jadwal)
            Else
                alert("info", "Jam tayang " & jam_tayang & " pada studio " & nama_Studio & " telah tersedia!", False)
            End If
        Else
            alert("info", "Form inputan tidak boleh ada yang kosong!", False)
        End If
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Dim kode_jadwal As String = txtKode.Text
        If (kode_jadwal <> "") Then
            Dim jawab As Integer
            jawab = MessageBox.Show("Apakah Data akan dihapus", "Confirm", MessageBoxButtons.YesNo)
            If (jawab = vbYes) Then
                Hapus()
                ResetAll()
                setFormInput(True)
            Else
                alert("info", "Data batal dihapus", False)
            End If
        Else
            alert("info", "Masukkan kode jadwal!", False)
            txtKode.Focus()
        End If
    End Sub

    Private Sub fillComboShowBy()
        cbShowBy.Items.Add("Kode Jadwal")
        cbShowBy.Items.Add("Kode Film")
        cbShowBy.Items.Add("Tanggal")
    End Sub

    Private Sub btnShowJadwal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowJadwal.Click
        Dim showby As String = cbShowBy.SelectedItem
        Dim valueby As String = txtBy.Text
        Dim columnText, valueText As String
        If (showby <> "" Or valTanggal.Text <> "") Then
            If (showby = "Tanggal") Then
                columnText = "jadwal.tanggal"
                valueText = valTanggal.Text
            Else
                columnText = showby.Replace(" ", "_").ToLower()
                valueText = valueby
            End If
            oJadwal.showJadwal(columnText, valueText, DataListJadwal)
        Else
            alert("error", "Silahkan pilih combobox disamping dan masukkan kirteria untuk menampilkan jadwal", True)
            cbShowBy.Focus()
        End If
    End Sub

    Private Sub cbShowBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbShowBy.SelectedIndexChanged
        Dim showby As String = cbShowBy.SelectedItem
        If (showby <> "") Then
            If (showby = "Tanggal") Then
                txtBy.Visible = False
                valTanggal.Visible = True
                valTanggal.Focus()
            Else
                txtBy.Visible = True
                valTanggal.Visible = False
                If (showby = "Kode Film") Then
                    txtBy.Text = "FL-0000"
                ElseIf (showby = "Kode Jadwal") Then
                    txtBy.Text = "JD-0000"
                End If
                txtBy.Focus()
            End If
        Else
            alert("error", "Silahkan pilih combobox disamping dan masukkan kirteria! Untuk menampilkan jadwal", True)
        End If
    End Sub
End Class