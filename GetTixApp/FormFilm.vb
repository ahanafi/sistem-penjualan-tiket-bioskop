Imports System.IO

Public Class FormFilm
    Dim path_file As Byte()

    Private Sub FormFilm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.ControlBox = False
        Me.Text = ""
        Preview.BorderStyle = BorderStyle.FixedSingle
        txtKode.Text = getKode("film", "FL")
        txtKode.Focus()
        txtTahunRilis.Text = Date.Now.Year
        ReloadData()
        If (logged_in_level = False) Then
            btnHapus.Visible = False
        End If
    End Sub

    Private Sub btnGoBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoBack.Click
        Dashboard.Show()
        Me.Close()
    End Sub

    Private Sub btnSelectFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectFile.Click
        On Error Resume Next
        OpenFilePicture.Filter = "JPG Files(*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|*.gif|PNG Files(*.png)|*.png"
        OpenFilePicture.FileName = ""
        If (OpenFilePicture.ShowDialog = Windows.Forms.DialogResult.OK) Then
            Dim img As Image = Image.FromFile(OpenFilePicture.FileName)
            Dim bArr As Byte() = imgToByteArray(img)
            path_file = bArr
            Dim imgSource As Image = byteArrayToImage(bArr)
            Preview.SizeMode = PictureBoxSizeMode.StretchImage
            Preview.Image = imgSource
        End If
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Dim kode As String = txtKode.Text
        If (kode.Length < 7 Or kode.Length > 7) Then
            MsgBox("Panjang kode film tidak valid! Panjang kode adalah 7 karakter", MsgBoxStyle.Critical, "Error!")
        Else
            If (kode <> "") Then
                oFilm.Carifilm(kode)
                If (cn.RecordFound = True) Then
                    getFilm(kode)
                    film_baru = False
                Else
                    ResetForm()
                    film_baru = True
                    txtJudul.Focus()
                End If
            Else
                MessageBox.Show("Masukkan kode film!", "ERROR!", MessageBoxButtons.OK)
            End If
        End If
    End Sub
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ResetForm()
    End Sub
    Public Sub ResetForm()
        txtKode.Clear()
        txtJudul.Clear()
        txtDurasi.Clear()
        txtSinopsis.Clear()
        txtTahunRilis.Text = Date.Now.Year
        txtPathFile.Clear()
        txtKode.Text = getKode("film", "FL")
        txtKode.Focus()
        txtHarga.Clear()
        Preview.Image = New Bitmap(GetTixApp.My.Resources.Resources.No_Image_Available)
    End Sub
    Private Sub TampilkanDatafilm()
        txtKode.Text = oFilm.kode
        txtJudul.Text = oFilm.judul
        txtDurasi.Text = oFilm.durasi
        txtSinopsis.Text = oFilm.sinopsis
        txtTahunRilis.Text = oFilm.tahun_rilis
        txtPathFile.Text = ""
        Preview.Image = oFilm.foto
        txtHarga.Text = oFilm.harga
    End Sub
    Private Sub SimpanDatafilm()
        oFilm.kode = txtKode.Text
        oFilm.judul = txtJudul.Text
        oFilm.durasi = Val(txtDurasi.Text)
        oFilm.sinopsis = txtSinopsis.Text
        oFilm.tahun_rilis = txtTahunRilis.Text
        oFilm.foto = path_file
        oFilm.harga = Val(txtHarga.Text)
        oFilm.SimpanFilm()
    End Sub
    Private Sub ReloadData()
        oFilm.getAllData(DataListFilm)
    End Sub
    Private Sub HapusFilm()
        If (film_baru = False And txtKode.Text <> "") Then
            oFilm.Hapus(txtKode.Text)
            ResetForm()
            ReloadData()
        End If
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If (txtKode.Text <> "" And txtJudul.Text <> "" And txtSinopsis.Text <> "" And txtDurasi.Text <> "" And txtHarga.Text <> "") Then
            SimpanDatafilm()
            ReloadData()
            ResetForm()
        Else
            MsgBox("Form tidak boleh ada yang kosong!", MsgBoxStyle.Critical, "Error!")
        End If
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If (logged_in_level = True) Then
            If (txtKode.Text <> "" And txtJudul.Text <> "" And film_baru = False) Then
                Dim jawab As Integer
                jawab = MessageBox.Show("Apakah Anda yakin akan menghapus data ini?", "Confirm", MessageBoxButtons.YesNo)
                If (jawab = vbYes) Then
                    HapusFilm()
                Else
                    MsgBox("Data batal dihapus", MsgBoxStyle.Information, "Notifikasi")
                End If
            Else
                MsgBox("Data film tidak boleh kosong!", MsgBoxStyle.Critical, "Error!")
                txtKode.Focus()
            End If
        Else
            MsgBox("Anda tidak memiliki akses untuk menghapus data!", MsgBoxStyle.Critical, "Error!")
            btnHapus.Enabled = False
            ResetForm()
        End If
    End Sub

    Public Sub getFilm(ByVal kode As String)
        DBConnect()
        SQL = "SELECT * FROM film JOIN tiket ON film.kode = tiket.kode_film WHERE kode='" & kode & "'"
        cn.DataReader = cn.searchone(SQL)
        If (cn.RecordFound = True) Then
            film_baru = False
            cn.DataReader.Read()
            txtKode.Text = Convert.ToString((cn.DataReader("kode")))
            txtJudul.Text = Convert.ToString((cn.DataReader("judul")))
            txtDurasi.Text = Convert.ToString(cn.DataReader("durasi"))
            txtSinopsis.Text = Convert.ToString((cn.DataReader("sinopsis")))
            txtTahunRilis.Text = Convert.ToString((cn.DataReader("tahun_rilis")))
            txtHarga.Text = Convert.ToString(cn.DataReader("harga"))
            Dim srcFoto As Array = cn.DataReader("foto")

            If (srcFoto.Length = 0) Then
                Preview.Image = New Bitmap(GetTixApp.My.Resources.Resources.No_Image_Available)
            Else
                Preview.Image = byteArrayToImage(srcFoto)
            End If
            Preview.SizeMode = PictureBoxSizeMode.StretchImage

        End If
    End Sub
End Class