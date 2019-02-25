Public Class Jadwal_Tayang
   Dim strsql As String
   Dim info As String
   Private _id As Integer
   Private _kode As String
   Private _tanggal As String
   Private _jam_tayang As System.TimeSpan
   Private _kode_film As String
   Public Property kode()
       Get 
           Return _kode
       End Get 
       Set(ByVal value) 
           _kode = value 
       End Set 
   End Property 
   Public Property tanggal()
       Get 
           Return _tanggal
       End Get 
       Set(ByVal value) 
           _tanggal = value 
       End Set 
   End Property 
   Public Property jam_tayang()
       Get 
           Return _jam_tayang
       End Get 
       Set(ByVal value) 
           _jam_tayang = value 
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
   Public Sub Simpan()
       Dim info As String 
       DBConnect()
       If (jadwal_tayang_baru = True) Then 
           SQL = "Insert into jadwal_tayang(kode,tanggal,jam_tayang,kode_film) values ('" & _kode & "','"  & _tanggal & "','"  & _jam_tayang & "','"  & _kode_film & "')"
           info = "Data berhasil disimpan"
       Else
           SQL = "update jadwal_tayang set kode='" & _kode & "', tanggal='" & _tanggal & "', jam_tayang='" & _jam_tayang & "', kode_film='" & _kode_film & "' where kode='" & _kode & "'"
           info = "Data berhasil diperbarui"
       End If
       cn.ExecuteSQL(SQL, info)
   End Sub
   Public Sub Carijadwal_tayang(ByVal skode As String)
       DBConnect()
       SQL ="SELECT * FROM jadwal_tayang WHERE kode='" & skode & "'"
       cn.DataReader = cn.searchone(SQL)
       If (cn.RecordFound = True) Then
           jadwal_tayang_baru= False
           cn.DataReader.Read()
           kode= Convert.ToString((cn.DataReader("kode")))
           tanggal= Convert.ToString((cn.DataReader("tanggal")))
           jam_tayang= Convert.ToString((cn.DataReader("jam_tayang")))
           kode_film= Convert.ToString((cn.DataReader("kode_film")))
       Else
           MessageBox.Show("Data Tidak Ditemukan.")
           jadwal_tayang_baru = True
       End If
   End Sub
   Public Sub Hapus(ByVal skode As String)
       Dim info As String
       DBConnect()
       SQL ="DELETE FROM jadwal_tayang WHERE kode='" & skode & "'"
       info = "Data berhasil dihapus"
       Try
           cn.ExecuteSQL(SQL, info)
       Catch ex As Exception
           MessageBox.Show(ex.ToString)
       End Try
   End Sub
   Public Sub getAllData(ByVal dg As DataGridView)
       DBConnect()
       dg.DataSource = cn.Data_Record("SELECT * FROM jadwal_tayang","jadwal_tayang")
   End Sub
End Class
