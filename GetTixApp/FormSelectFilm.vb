Public Class FormSelectFilm

    Private PreviewFilm(10) As PictureBox
    Private sourceImg(10) As String
    Private btnBuyTicket(10) As Button

    Private Sub FormSelectFilm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = ""
        Me.ControlBox = False
        getFilmShowsToday()
    End Sub

    Private Sub btnGoBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoBack.Click
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
                .Height = 50
                .Width = 235
                .Left = xPos
                .Top = yPos + PreviewFilm(n).Height + 20
                .FlatStyle = FlatStyle.Flat
                GbShowsToday.Controls.Add(btnBuyTicket(n))
                xPos = xPos + PreviewFilm(n).Width + 50
                AddHandler .Click, AddressOf Me.beliTiket
            End With
            n += 1
        End While
    End Sub

    Public Sub beliTiket(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Me.Close()
        Dim btn As Button = sender
        Dim kode_film As String = btn.Name
        'FormPembelian.GenerateButton(True)
        FormSelectJadwal.KODE_FILM = kode_film
        FormSelectJadwal.Show()
        FormInputPembelian.Hide()
        Dashboard.Hide()
    End Sub
End Class