Public Class Dashboard

    Private PreviewFilm(10) As PictureBox
    Private sourceImg(10) As String
    Private btnBuyTicket(10) As Button

    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.ControlBox = False
        Me.Text = ""
        loggedInName.Text = logged_in_name
        'logged_in_level = True
        If (logged_in_level = True) Then
            LoggedInLevel.Text = "( Administrator )"
        Else
            LoggedInLevel.Text = "( Operator )"
            btnUser.Visible = False
        End If
        getFilmShowsToday()
        SplashScreen.Close()
    End Sub

    Private Sub btnFilm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilm.Click
        FormFilm.Show()
    End Sub
    Private Sub btnUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUser.Click
        FormUser.Show()
        Me.Hide()
    End Sub

    Private Sub btnPembelian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPembelian.Click
        'FormSelectFilm.ShowDialog()
        FormPembelian.Show()
        Me.Hide()
    End Sub

    Private Sub btnPembayaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPembayaran.Click
        FormPembayaran.txtKodeBeli.Text = "INV-0000"
        FormPembayaran.Show()
        Me.Hide()
    End Sub

    Private Sub btnJadwal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJadwal.Click
        FormJadwal.Show()
        Me.Close()
    End Sub

    Public Sub getFilmShowsToday()
        Dim today As String = changeDateToDBFormat(Date.Now.Date)
        DBConnect()
        Dim SQL_Count = "SELECT COUNT(DISTINCT(kode_film)) as total FROM `jadwal` WHERE tanggal = '" & today & "'"
        cn.DataReader = cn.searchone(SQL_Count)
        cn.DataReader.read()
        Dim total = cn.DataReader("total")
        Dim xPos As Integer = 40
        Dim yPos As Integer = 55
        Dim n As Integer = 0

        Dim SQL = "SELECT DISTINCT(kode_film) FROM jadwal WHERE tanggal = '" & today & "'"
        cn.DataReader = cn.searchone(SQL)
        Dim x As Integer = 0
        While cn.DataReader.read()
            sourceImg(x) = Convert.ToString(cn.DataReader("kode_film"))
            x += 1
        End While

        While (n < total)
            PreviewFilm(n) = New PictureBox
            btnBuyTicket(n) = New Button

            With (PreviewFilm(n))

                If (n = 5) Then
                    xPos = 40
                    yPos = 490
                End If

                .Image = byteArrayToImage(oFilm.getCover(sourceImg(n)))
                .Height = 315 '350
                .Width = 235  '300
                .SizeMode = PictureBoxSizeMode.StretchImage
                .Left = xPos
                .Top = yPos
                .BorderStyle = BorderStyle.FixedSingle
                GbShowsToday.Controls.Add(PreviewFilm(n))
            End With

            With (btnBuyTicket(n))
                .Name = sourceImg(n)
                .BackColor = Color.SteelBlue
                .ForeColor = Color.White
                .Text = "BELI TIKET"
                .Height = 50 '60
                .Width = 235 '300
                .Left = xPos
                .Top = yPos + PreviewFilm(n).Height + 20
                .FlatStyle = FlatStyle.Flat
                GbShowsToday.Controls.Add(btnBuyTicket(n))
                xPos = xPos + PreviewFilm(n).Width + 50
                AddHandler .Click, AddressOf FormSelectFilm.beliTiket
            End With
            n += 1
        End While
    End Sub

    Private Sub btnStudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudio.Click
        FormStudio.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Dim jawab As Integer
        jawab = MessageBox.Show("Apakah Anda yakin akan keluar ?", "Konfirmasi", MessageBoxButtons.YesNo)
        If (jawab = vbYes) Then
            Me.Close()
            Login.ResetForm()
            Login.Show()
        End If
    End Sub
End Class