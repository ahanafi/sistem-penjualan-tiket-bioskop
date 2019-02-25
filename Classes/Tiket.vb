Public Class Tiket
   Dim strsql As String
   Dim info As String
   Private _id As Integer
   Private _kode As String
   Private _kode_film As String
   Private _stok_awal As Integer
   Private _stok_terjual As Integer
   Private _stok_sisa As Integer
   Private _harga As System.Double
   Public Property kode()
       Get 
           Return _kode
       End Get 
       Set(ByVal value) 
           _kode = value 
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
   Public Property stok_awal()
       Get 
           Return _stok_awal
       End Get 
       Set(ByVal value) 
           _stok_awal = value 
       End Set 
   End Property 
   Public Property stok_terjual()
       Get 
           Return _stok_terjual
       End Get 
       Set(ByVal value) 
           _stok_terjual = value 
       End Set 
   End Property 
   Public Property stok_sisa()
       Get 
           Return _stok_sisa
       End Get 
       Set(ByVal value) 
           _stok_sisa = value 
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
       If (tiket_baru = True) Then 
           SQL = "Insert into tiket(kode,kode_film,stok_awal,stok_terjual,stok_sisa,harga) values ('" & _kode & "','"  & _kode_film & "','"  & _stok_awal & "','"  & _stok_terjual & "','"  & _stok_sisa & "','"  & _harga & "')"
           info = "Data berhasil disimpan"
       Else
           SQL = "update tiket set kode='" & _kode & "', kode_film='" & _kode_film & "', stok_awal='" & _stok_awal & "', stok_terjual='" & _stok_terjual & "', stok_sisa='" & _stok_sisa & "', harga='" & _harga & "' where kode='" & _kode & "'"
           info = "Data berhasil diperbarui"
       End If
       cn.ExecuteSQL(SQL, info)
   End Sub
   Public Sub Caritiket(ByVal skode As String)
       DBConnect()
       SQL ="SELECT * FROM tiket WHERE kode='" & skode & "'"
       cn.DataReader = cn.searchone(SQL)
       If (cn.RecordFound = True) Then
           tiket_baru= False
           cn.DataReader.Read()
           kode= Convert.ToString((cn.DataReader("kode")))
           kode_film= Convert.ToString((cn.DataReader("kode_film")))
           stok_awal= Convert.ToString((cn.DataReader("stok_awal")))
           stok_terjual= Convert.ToString((cn.DataReader("stok_terjual")))
           stok_sisa= Convert.ToString((cn.DataReader("stok_sisa")))
           harga= Convert.ToString((cn.DataReader("harga")))
       Else
           MessageBox.Show("Data Tidak Ditemukan.")
           tiket_baru = True
       End If
   End Sub
   Public Sub Hapus(ByVal skode As String)
       Dim info As String
       DBConnect()
       SQL ="DELETE FROM tiket WHERE kode='" & skode & "'"
       info = "Data berhasil dihapus"
       Try
           cn.ExecuteSQL(SQL, info)
       Catch ex As Exception
           MessageBox.Show(ex.ToString)
       End Try
   End Sub
   Public Sub getAllData(ByVal dg As DataGridView)
       DBConnect()
       dg.DataSource = cn.Data_Record("SELECT * FROM tiket","tiket")
   End Sub
End Class
