Public Class FormStudio

    Private Sub FormStudio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = ""
        Me.ControlBox = False
        ReloadData()
        txtKode.Text = getKode("studio", "ST")
        txtKode.Focus()
    End Sub

    Private Sub ReloadData()
        oStudio.getAllData(DataListStudio)
    End Sub

    Private Sub TampilkanDatastudio()
        txtkode.Text = ostudio.kode
        txtnama.Text = ostudio.nama_studio
        txtjumlah.Text = oStudio.jumlah_kursi
    End Sub

    Private Sub ClearData()
        txtkode.Clear()
        txtnama.Clear()
        txtJumlah.Clear()
        txtKode.Text = getKode("studio", "ST")
        txtKode.Focus()
    End Sub

    Private Sub SimpanDatastudio()
        oStudio.kode = txtKode.Text
        oStudio.nama_studio = txtNama.Text
        oStudio.jumlah_kursi = txtJumlah.Text
        oStudio.Simpan()
    End Sub

    Private Sub Hapus()
        If (studio_baru = False And txtkode.Text <> "") Then
            ostudio.Hapus(txtkode.Text)
            ClearData()
            ReloadData()
        End If
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Dim jumlah_kursi As Integer = Val(txtJumlah.Text)
        If (txtKode.Text <> "" And txtNama.Text <> "" And jumlah_kursi <> 0) Then
            If (jumlah_kursi > 50) Then
                alert("error", "Maaf! Jumlah maksimal kursi adalah 50!", True)
                txtJumlah.Focus()
            Else
                SimpanDatastudio()
                ClearData()
                ReloadData()
            End If
        Else
            alert("error", "Kode, nama, dan jumlah kursi tidak boleh kosong!", True)
        End If
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Dim jawab As Integer
        jawab = MessageBox.Show("Apakah Data akan dihapus", "Confirm", MessageBoxButtons.YesNo)
        If (jawab = vbYes) Then
            Hapus()
        Else
            alert("info", "Data batal dihapus", False)
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ClearData()
        txtkode.Focus()
    End Sub

    Private Sub btnGoBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoBack.Click
        Me.Close()
        Dashboard.Show()
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Dim kode As String = txtKode.Text
        If (kode <> "") Then
            oStudio.Caristudio(kode)
            If (cn.RecordFound = True) Then
                TampilkanDatastudio()
                studio_baru = False
            Else
                txtNama.Clear()
                txtJumlah.Clear()
                txtNama.Focus()
                studio_baru = True
            End If
        Else
            MsgBox("Masukkan kode studio!", MsgBoxStyle.Critical, "Error!")
            txtKode.Focus()
        End If
    End Sub
End Class
