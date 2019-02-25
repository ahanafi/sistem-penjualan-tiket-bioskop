Public Class Pembelian
    Dim strsql As String
    Dim info As String
    Private _id As Integer
    Private _kode As String
    Private _total_bayar As System.Double
    Private _is_lunas As Integer
    Private _tanggal_beli As String
    Private _jam As String
    Private _kode_pembelian As String
    Private _kode_film As String
    Private _nomor_kursi As String
    Public Property kode()
        Get
            Return _kode
        End Get
        Set(ByVal value)
            _kode = value
        End Set
    End Property
    Public Property total_bayar()
        Get
            Return _total_bayar
        End Get
        Set(ByVal value)
            _total_bayar = value
        End Set
    End Property
    Public Property is_lunas()
        Get
            Return _is_lunas
        End Get
        Set(ByVal value)
            _is_lunas = 0
        End Set
    End Property
    Public Property tanggal_beli()
        Get
            Return _tanggal_beli
        End Get
        Set(ByVal value)
            _tanggal_beli = value
        End Set
    End Property
    Public Property jam()
        Get
            Return _jam
        End Get
        Set(ByVal value)
            _jam = value
        End Set
    End Property
    Public Property kode_pembelian()
        Get
            Return _kode_pembelian
        End Get
        Set(ByVal value)
            _kode_pembelian = value
        End Set
    End Property
    Public Property kode_film()
        Get
            Return _kode_film
        End Get
        Set(ByVal value)
            _kode_film = value
        End Set
    End Property
    Public Property nomor_kursi()
        Get
            Return _nomor_kursi
        End Get
        Set(ByVal value)
            _nomor_kursi = value
        End Set
    End Property
    Public Sub Simpan()
        Dim info As String
        DBConnect()
        If (pembelian_baru = True) Then
            SQL = "Insert into pembelian(kode, kode_film, total_bayar,is_lunas,tanggal_beli, jam) values ('" & _kode & "','" & _kode_film & "','" & _total_bayar & "','" & _is_lunas & "','" & _tanggal_beli & "','" & _jam & "')"
            info = "Data berhasil disimpan"
        Else
            SQL = "update pembelian set kode='" & _kode & "', kode_film = '" & _kode_film & "', total_bayar='" & _total_bayar & "', is_lunas='" & _is_lunas & "', tanggal_beli='" & _tanggal_beli & "', jam = '" & _jam & "' where kode='" & _kode & "'"
            info = "Data berhasil diperbarui"
        End If
        'MessageBox.Show(SQL)
        cn.ExecuteSQL(SQL, info)
    End Sub
    Public Sub SimpanDetail()
        Dim info As String
        DBConnect()
        If (detail_pembelian_baru = True) Then
            SQL = "Insert into detail_pembelian(kode_pembelian, nomor_kursi, tanggal) values ('" & _kode_pembelian & "','" & _nomor_kursi & "', '" & _tanggal_beli & "')"
            info = "Data berhasil disimpan"
        Else
            SQL = "update pembelian set kode_pembelian='" & _kode_pembelian & "', nomor_kursi='" & _nomor_kursi & "', tanggal = '" & _tanggal_beli & "' where kode='" & _kode & "'"
            info = "Data berhasil diperbarui"
        End If
        cn.ExecuteSQL(SQL, info)
    End Sub
    Public Sub Caripembelian(ByVal skode As String)
        DBConnect()
        SQL = "SELECT * FROM pembelian WHERE kode='" & skode & "'"
        cn.DataReader = cn.searchone(SQL)
        If (cn.RecordFound = True) Then
            pembelian_baru = False
            cn.DataReader.Read()
            kode = Convert.ToString((cn.DataReader("kode")))
            total_bayar = Convert.ToString((cn.DataReader("total_bayar")))
            is_lunas = Convert.ToString((cn.DataReader("is_lunas")))
            tanggal_beli = Convert.ToString((cn.DataReader("tanggal_beli")))
        Else
            MessageBox.Show("Data Tidak Ditemukan.")
            pembelian_baru = True
        End If
    End Sub
    Public Sub Hapus(ByVal skode As String)
        Dim info As String
        DBConnect()
        SQL = "DELETE FROM pembelian WHERE kode='" & skode & "'"
        info = "Data berhasil dihapus"
        Try
            cn.ExecuteSQL(SQL, info)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub HapusDetail(ByVal skode As String)
        Dim info As String
        DBConnect()
        SQL = "DELETE FROM detail_pembelian WHERE kode='" & skode & "'"
        info = "Data berhasil dihapus"
        Try
            cn.ExecuteSQL(SQL, info)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub getAllDataDetail(ByVal dg As DataGridView, ByVal skode As String)
        DBConnect()
        SQL = "SELECT  detail_pembelian.nomor_kursi as 'Nomor Kursi' FROM film JOIN tiket ON tiket.kode_film = film.kode JOIN detail_pembelian ON detail_pembelian.kode_tiket = tiket.kode WHERE detail_pembelian.kode_pembelian = '" & skode & "' "
        dg.DataSource = cn.Data_Record(SQL, "film")
    End Sub
    Public Sub getAllData(ByVal dg As DataGridView)
        DBConnect()
        dg.DataSource = cn.Data_Record("SELECT * FROM pembelian", "pembelian")
    End Sub
    Public Function cekPembelian(ByVal kode_pembelian As String)
        Dim found As Boolean
        DBConnect()
        SQL = "SELECT * FROM pembelian WHERE kode = '" & kode_pembelian & "'"
        cn.DataReader = cn.searchone(SQL)
        If (cn.RecordFound = True) Then
            found = True
        Else
            found = False
        End If
        Return found
    End Function
    Public Function getTotalBayar(ByVal kode_pembelian)
        DBConnect()

        'Menghitung kursi berdasarkan kode pembelian
        Dim SQL_Count_Kursi As String = "SELECT COUNT(*) as jumlah, kode_film FROM pembelian JOIN detail_pembelian ON pembelian.kode = detail_pembelian.kode_pembelian WHERE kode_pembelian = '" & kode_pembelian & "'"
        cn.DataReader = cn.searchone(SQL_Count_Kursi)
        cn.DataReader.Read()

        Dim kodeFilm As String = cn.DataReader("kode_film")
        Dim jumlahKursi As Integer = cn.DataReader("jumlah")

        'Get harga berdasarkan kode_film
        SQL = "SELECT harga FROM tiket WHERE kode_film = '" & kodeFilm & "'"
        cn.DataReader = cn.searchone(SQL)
        cn.DataReader.read()
        Dim harga As Integer = cn.DataReader("harga").ToString()
        Dim total As Double = jumlahKursi * harga
        Return total
    End Function

    Public Sub updateTotal(ByVal kode_pembelian As String, ByVal total_Bayar As Double)
        DBConnect()
        SQL = "UPDATE pembelian SET total_bayar = '" & total_Bayar & "' WHERE kode = '" & kode_pembelian & "'"
        cn.ExecuteSQL(SQL, "Data berhasil disimpan! Silahkan lakukan pembayaran!")
    End Sub

    Public Sub Bayar(ByVal kode_pembelian As String)
        DBConnect()
        SQL = "UPDATE pembelian SET is_lunas = 1 WHERE kode = '" & kode_pembelian & "'"
        cn.ExecuteSQL(SQL, "Pembayaran berhasil dilakukan!")
    End Sub
    Public Function cekKursi(ByVal no_kursi As String, ByVal tanggal As String, ByVal jam As String, ByVal kode_film As String)
        DBConnect()
        SQL = "SELECT * FROM pembelian JOIN detail_pembelian ON pembelian.kode = detail_pembelian.kode_pembelian WHERE nomor_kursi='" & no_kursi & "' AND tanggal = '" & tanggal & "' AND jam = '" & jam & "' AND kode_film = '" & kode_film & "'"
        cn.DataReader = cn.searchone(SQL)
        'MsgBox(SQL, MsgBoxStyle.Information, "cek")
        Dim callback As Boolean
        If (cn.RecordFound = True) Then
            callback = True
        Else
            callback = False
        End If
        Return callback
    End Function
    Public Sub getByDate(ByVal tanggal_awal As String, ByVal tanggal_akhir As String, ByVal dg As DataGridView)
        DBConnect()
        SQL = "SELECT pembelian.id as ID, pembelian.kode as 'Kode Pembelian', judul AS Judul, tanggal_beli AS 'Tanggal', total_bayar AS Total FROM pembelian JOIN film ON pembelian.kode_film = film.kode WHERE tanggal_beli BETWEEN '" & tanggal_awal & "' AND '" & tanggal_akhir & "'"
        cn.DataReader = cn.searchone(SQL)
        If (cn.RecordFound = True) Then
            dg.DataSource = cn.Data_Record(SQL, "pembelian")
        Else
            alert("info", "Data tidak ditemukan!", False)
            dg.DataSource = DBNull.Value
        End If
    End Sub

    Public Function CheckIsFull(ByVal jam_tayang As String)
        DBConnect()
        SQL = "SELECT COUNT(*) as total FROM pembelian JOIN detail_pembelian ON pembelian.kode = detail_pembelian.kode_pembelian WHERE jam = '" & jam_tayang & "'"
        cn.DataReader = cn.searchone(SQL)
        cn.DataReader.Read()
        Dim total_data As Integer = cn.DataReader("total")
        If (total_data = 50) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
