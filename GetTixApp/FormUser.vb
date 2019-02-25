Public Class FormUser
    Dim level_user As Integer
    Private Sub FormUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = ""
        Me.WindowState = FormWindowState.Maximized
        Me.ControlBox = False
        txtUsername.Focus()
        ReloadData()
        DataListUsers.Width = 860
        If (logged_in_level = False) Then
            btnHapus.Visible = False
        End If
    End Sub

    Private Sub btnGoBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoBack.Click
        Dashboard.Show()
        Me.Close()
    End Sub

    Private Sub btnCariTiket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariTiket.Click
        Dim username As String = txtUsername.Text
        If (username <> "") Then
            oUsers.Cariusers(username)
            If (cn.RecordFound = True) Then
                users_baru = False
                TampilkanDatausers()
            Else
                users_baru = True
                txtPassword.Focus()
            End If
        Else
            MsgBox("Username tidak boleh kosong!", MsgBoxStyle.Critical, "Error!")
            txtUsername.Focus()
        End If
    End Sub
    Private Sub ReloadData()
        oUsers.getAllData(DataListUsers)
    End Sub
    Private Sub TampilkanDatausers()
        Dim level As String
        txtNama.Text = oUsers.nama
        txtUsername.Text = oUsers.username
        txtPassword.Text = oUsers.password
        If (oUsers.level = -1) Then
            level = "Administrator"
        Else
            level = "Operator"
        End If
        cbLevel.SelectedItem = level
    End Sub

    Private Sub ClearData()
        txtNama.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        If (cbLevel.SelectedItem = "Administrator" Or cbLevel.SelectedItem = "Operator") Then
            cbLevel.SelectedIndex = -1
            cbLevel.SelectedText = "-- Pilih Level User --"
        End If
        txtUsername.Focus()
    End Sub

    Private Sub SimpanDatausers()
        oUsers.nama = txtNama.Text
        oUsers.username = txtUsername.Text
        oUsers.password = txtPassword.Text
        oUsers.level = level_user
        oUsers.Simpan()
    End Sub

    Private Sub HapusUser()
        If (users_baru = False And txtUsername.Text <> "") Then
            oUsers.Hapus(txtUsername.Text)
            ClearData()
            ReloadData()
        End If
    End Sub

    Private Sub cbLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbLevel.SelectedIndexChanged
        If (cbLevel.SelectedItem = "Administrator") Then
            level_user = 1
        Else
            level_user = 0
        End If
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If (txtUsername.Text <> "" And txtPassword.Text <> "" And txtNama.Text <> "") Then
            SimpanDatausers()
            ReloadData()
            ClearData()
        Else
            MsgBox("Form tidak boleh ada yang kosong!", MsgBoxStyle.Critical, "Error!")
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ClearData()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If (logged_in_level = True) Then
            If (txtUsername.Text <> "" And txtNama.Text <> "" And users_baru = False) Then
                Dim jawab As Integer
                jawab = MessageBox.Show("Apakah Data akan dihapus", "Confirm", MessageBoxButtons.YesNo)
                If (jawab = vbYes) Then
                    HapusUser()
                Else
                    MsgBox("Data batal dihapus", MsgBoxStyle.Information, "Notifikasi")
                End If
            Else
                MsgBox("Data user tidak boleh kosong!", MsgBoxStyle.Critical, "Error!")
                txtUsername.Focus()
            End If
        Else
            MsgBox("Anda tidak memiliki akses untuk menghapus data!", MsgBoxStyle.Critical, "Error!")
            btnHapus.Enabled = False
            ClearData()
        End If
    End Sub
End Class