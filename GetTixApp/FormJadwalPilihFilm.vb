Public Class FormJadwalPilihFilm

    Private Sub FormJadwalPilihFilm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = ""
        Me.ControlBox = False
        showAllFilms()
    End Sub

    Private Sub btnGoBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoBack.Click
        Me.Close()
        FormJadwal.Show()
    End Sub

    Public Sub showAllFilms()
        DBConnect()
        SQL = "SELECT id as ID, kode as 'Kode Film', judul as 'Judul', durasi as 'Durasi (Menit) ', tahun_rilis as 'Tahun Rilis' FROM film"
        DataFilm.DataSource = cn.Data_Record(SQL, "film")
    End Sub

    Private Sub DataFilm_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataFilm.CellContentClick
        Dim indexRow As Integer = DataFilm.CurrentRow.Index
        Dim kode_film As String = DataFilm.Rows(indexRow).Cells(1).Value
        oFilm.Carifilm(kode_film)
        If (cn.RecordFound = True) Then
            cn.DataReader.read()
            FormJadwal.txtKodeFilm.Text = kode_film
            FormJadwal.txtJudul.Text = Convert.ToString(cn.DataReader("judul"))
            FormJadwal.txtDurasi.Text = Convert.ToString(cn.DataReader("durasi"))
            FormJadwal.Preview.Image = byteArrayToImage(cn.DataReader("foto"))
            FormJadwal.Show()
            FormJadwal.btnCari.Enabled = False
            Me.Close()
        End If
    End Sub
End Class