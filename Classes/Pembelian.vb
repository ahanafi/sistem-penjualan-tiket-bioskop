Public Class Pembelian
   Dim strsql As String
   Dim info As String
   Private _id As Integer
   Private _kode As String
   Private _nama As String
   Private _total_bayar As System.Double
   Private _is_lunas As System.Boolean
   Private _tanggal_beli As String
   Private _kode_pembelian As String
   Private _kode_tiket As String
   Private _stok As Integer
   Public Property kode()
       Get 
           Return _kode
       End Get 
       Set(ByVal value) 
           _kode = value 
       End Set 
   End Property 
   Public Property nama()
       Get 
           Return _nama
       End Get 
       Set(ByVal value) 
           _nama = value 
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
           _is_lunas = value 
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
   Public Property kode_pembelian()
       Get 
           Return _kode_pembelian
       End Get 
       Set(ByVal value) 
           _kode_pembelian = value 
       End Set 
   End Property 
   Public Property kode_tiket()
       Get 
           Return _kode_tiket
       End Get 
       Set(ByVal value) 
           _kode_tiket = value 
       End Set 
   End Property 
   Public Property stok()
       Get 
           Return _stok
       End Get 
       Set(ByVal value) 
           _stok = value 
       End Set 
   End Property 
   Public Sub Simpan()
       Dim info As String 
       DBConnect()
       If (pembelian_baru = True) Then 
           SQL = "Insert into pembelian(kode,nama,total_bayar,is_lunas,tanggal_beli) values ('" & _kode & "','"  & _nama & "','"  & _total_bayar & "','"  & _is_lunas & "','"  & _tanggal_beli & "')"
           info = "Data berhasil disimpan"
       Else
           SQL = "update pembelian set kode='" & _kode & "', nama='" & _nama & "', total_bayar='" & _total_bayar & "', is_lunas='" & _is_lunas & "', tanggal_beli='" & _tanggal_beli & "' where kode='" & _kode & "'"
           info = "Data berhasil diperbarui"
       End If
       cn.ExecuteSQL(SQL, info)
   End Sub
   Public Sub SimpanDetail()
       Dim info As String 
       DBConnect()
       If (detail_pembelian_baru = True) Then 
           SQL = "Insert into detail_pembelian(kode_pembelian,kode_tiket,stok) values ('" & _kode_pembelian & "','"  & _kode_tiket & "','"  & _stok & "')"
           info = "Data berhasil disimpan"
       Else
           SQL = "update pembelian set kode_pembelian='" & _kode_pembelian & "', kode_tiket='" & _kode_tiket & "', stok='" & _stok & "' where kode='" & _kode & "'"
           info = "Data berhasil diperbarui"
       End If
       cn.ExecuteSQL(SQL, info)
   End Sub
   Public Sub Caripembelian(ByVal skode As String)
       DBConnect()
       SQL ="SELECT * FROM pembelian WHERE kode='" & skode & "'"
       cn.DataReader = cn.searchone(SQL)
       If (cn.RecordFound = True) Then
           pembelian_baru= False
           cn.DataReader.Read()
           kode= Convert.ToString((cn.DataReader("kode")))
           nama= Convert.ToString((cn.DataReader("nama")))
           total_bayar= Convert.ToString((cn.DataReader("total_bayar")))
           is_lunas= Convert.ToString((cn.DataReader("is_lunas")))
           tanggal_beli= Convert.ToString((cn.DataReader("tanggal_beli")))
       Else
           MessageBox.Show("Data Tidak Ditemukan.")
           pembelian_baru = True
       End If
   End Sub
   Public Sub Hapus(ByVal skode As String)
       Dim info As String
       DBConnect()
       SQL ="DELETE FROM pembelian WHERE kode='" & skode & "'"
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
       SQL ="DELETE FROM detail_pembelian WHERE kode='" & skode & "'"
       info = "Data berhasil dihapus"
       Try
           cn.ExecuteSQL(SQL, info)
       Catch ex As Exception
           MessageBox.Show(ex.ToString)
       End Try
   End Sub
   Public Sub getAllDataDetail(ByVal dg As DataGridView, ByVal skode as string)
       DBConnect()
       dg.DataSource = cn.Data_Record("SELECT * FROM detail_pembelian WHERE kode='" & skode & "'","pembelian")
   End Sub
   Public Sub getAllData(ByVal dg As DataGridView)
       DBConnect()
       dg.DataSource = cn.Data_Record("SELECT * FROM pembelian","pembelian")
   End Sub
End Class
