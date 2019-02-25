Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Film
    Dim strsql As String
    Dim info As String
    Private _id As Integer
    Private _kode As String
    Private _judul As String
    Private _durasi As Integer
    Private _sinopsis As String
    Private _tahun_rilis As String
    Private _foto As System.Byte()
    Private _harga As Double
    Public Property kode()
        Get
            Return _kode
        End Get
        Set(ByVal value)
            _kode = value
        End Set
    End Property
    Public Property judul()
        Get
            Return _judul
        End Get
        Set(ByVal value)
            _judul = value
        End Set
    End Property
    Public Property durasi()
        Get
            Return _durasi
        End Get
        Set(ByVal value)
            _durasi = value
        End Set
    End Property
    Public Property sinopsis()
        Get
            Return _sinopsis
        End Get
        Set(ByVal value)
            _sinopsis = value
        End Set
    End Property
    Public Property tahun_rilis()
        Get
            Return _tahun_rilis
        End Get
        Set(ByVal value)
            _tahun_rilis = value
        End Set
    End Property
    Public Property foto()
        Get
            Return _foto
        End Get
        Set(ByVal value)
            _foto = value
        End Set
    End Property
    Public Property harga()
        Get
            Return _harga
        End Get
        Set(ByVal value)
            _harga = value
        End Set
    End Property
    Public Sub Simpan()
        Dim info As String
        DBConnect()
        If (film_baru = True) Then
            SQL = "Insert into film(kode,judul,sinopsis,tahun_rilis,foto) values ('" & _kode & "','" & _judul & "','" & _sinopsis & "','" & _tahun_rilis & "', @FOTO"
            info = "Data berhasil disimpan"
        Else
            SQL = "update film set kode='" & _kode & "', judul='" & _judul & "', sinopsis='" & _sinopsis & "', tahun_rilis='" & _tahun_rilis & "', foto= @FOTO where kode='" & _kode & "'"
            info = "Data berhasil diperbarui"
        End If
        cn.ExecuteSQL(SQL, info)
    End Sub

    Public Sub SimpanTiket()
        Dim info As String
        DBConnect()
        If (film_baru = True) Then
            SQL = "Insert into tiket(kode_film,harga) values ('" & _kode & "','" & _harga & "')"
            info = "Data berhasil disimpan"
        Else
            SQL = "update tiket set kode_film ='" & _kode & "', harga ='" & _harga & "'where kode_film ='" & _kode & "'"
            info = "Data berhasil diperbarui"
        End If
        cn.ExecuteSQL(SQL, info)
    End Sub

    Public Sub Carifilm(ByVal skode As String)
        DBConnect()
        SQL = "SELECT * FROM film WHERE kode='" & skode & "'"
        cn.DataReader = cn.searchone(SQL)
        If (cn.RecordFound = True) Then
            film_baru = False
        Else
            MessageBox.Show("Data Tidak Ditemukan.")
            film_baru = True
        End If
    End Sub
    Public Sub Hapus(ByVal skode As String)
        Dim info As String
        DBConnect()
        SQL = "DELETE FROM film WHERE kode='" & skode & "'"
        info = "Data berhasil dihapus"
        Try
            cn.ExecuteSQL(SQL, info)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub getAllData(ByVal dg As DataGridView)
        DBConnect()
        dg.DataSource = cn.Data_Record("SELECT id, kode, judul, durasi as 'Durasi (menit)', sinopsis, tahun_rilis as 'Tahun Rilis' FROM film", "film")
    End Sub
    Public Sub SimpanFilm()
        Dim conStr = "server=" & cn.Host & ";userid=" & cn.DBUsername & ";password=" & cn.DBPassword & ";database=" & cn.DBName & ""
        Dim connect As New MySqlConnection(conStr)
        If (connect.State = ConnectionState.Closed) Then
            connect.Open()
            Dim queryStr, SQL_tiket As String
            If (film_baru = True) Then
                queryStr = "INSERT INTO film (kode, judul, durasi, sinopsis, tahun_rilis, foto) VALUES (@KODE, @JUDUL, @DURASI, @SINOPSIS, @TAHUN_RILIS, @FOTO)"
                SQL_tiket = "Insert into tiket(kode_film,harga) values ('" & _kode & "','" & _harga & "')"
            Else
                If (_foto IsNot Nothing) AndAlso (_foto.Length >= 100) Then
                    queryStr = "UPDATE film SET kode = @KODE, judul = @JUDUL, durasi = @DURASI, sinopsis = @SINOPSIS, tahun_rilis = @TAHUN_RILIS, foto = @FOTO WHERE kode = @KODE"
                Else
                    queryStr = "UPDATE film SET kode = @KODE, judul = @JUDUL, durasi = @DURASI, sinopsis = @SINOPSIS, tahun_rilis = @TAHUN_RILIS WHERE kode = @KODE"
                End If
                SQL_tiket = "update film set kode='" & _kode & "', judul='" & _judul & "', sinopsis='" & _sinopsis & "', tahun_rilis='" & _tahun_rilis & "', foto= @FOTO where kode='" & _kode & "'"
            End If

            Dim SQL As New MySqlCommand(queryStr, connect)

            With SQL
                .Parameters.AddWithValue("@KODE", _kode)
                .Parameters.AddWithValue("@JUDUL", _judul)
                .Parameters.AddWithValue("@DURASI", _durasi)
                .Parameters.AddWithValue("@SINOPSIS", _sinopsis)
                .Parameters.AddWithValue("@TAHUN_RILIS", _tahun_rilis)

                If (_foto IsNot Nothing) AndAlso (_foto.Length >= 100) Then
                    .Parameters.AddWithValue("@FOTO", _foto)
                End If

            End With

            Dim SQLtiket As New MySqlCommand(SQL_tiket, connect)
            If (SQL.ExecuteNonQuery() And SQLtiket.ExecuteNonQuery()) Then
                MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information, "Info")
            End If
        End If
    End Sub
    Public Function getCover(ByVal kode_film As String)
        DBConnect()
        Dim SQL = "SELECT foto FROM film WHERE kode = '" & kode_film & "'"
        cn.DataReader = cn.searchone(SQL)
        If (cn.RecordFound = True) Then
            cn.DataReader.read()
            Return cn.DataReader("foto")
        Else
            Return Nothing
        End If
    End Function
    Public Function getHarga(ByVal kode_film As String)
        DBConnect()
        Dim harga As Integer
        SQL = "SELECT harga FROM tiket WHERE kode_film = '" & kode_film & "'"
        cn.DataReader = cn.searchone(SQL)
        If (cn.RecordFound = True) Then
            cn.DataReader.Read()
            harga = cn.DataReader("harga").ToString()
        Else
            harga = 0
        End If
        Return harga
    End Function
End Class
