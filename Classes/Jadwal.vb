Public Class Jadwal
   Dim strsql As String
   Dim info As String
   Private _id As Integer
   Private _kode As String
   Private _tanggal As String
   Private _kode_film As String
   Private _kode_jadwal As String
   Private _jam_tayang As System.TimeSpan
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
   Public Property kode_film()
       Get 
           Return _kode_film
       End Get 
       Set(ByVal value) 
           _kode_film = value 
       End Set 
   End Property 
   Public Property kode_jadwal()
       Get 
           Return _kode_jadwal
       End Get 
       Set(ByVal value) 
           _kode_jadwal = value 
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
   Public Sub Simpan()
       Dim info As String 
       DBConnect()
       If (jadwal_baru = True) Then 
           SQL = "Insert into jadwal(kode,tanggal,kode_film) values ('" & _kode & "','"  & _tanggal & "','"  & _kode_film & "')"
           info = "Data berhasil disimpan"
       Else
           SQL = "update jadwal set kode='" & _kode & "', tanggal='" & _tanggal & "', kode_film='" & _kode_film & "' where kode='" & _kode & "'"
           info = "Data berhasil diperbarui"
       End If
       cn.ExecuteSQL(SQL, info)
   End Sub
   Public Sub SimpanDetail()
       Dim info As String 
       DBConnect()
       If (detail_jadwal_baru = True) Then 
           SQL = "Insert into detail_jadwal(kode_jadwal,jam_tayang) values ('" & _kode_jadwal & "','"  & _jam_tayang & "')"
           info = "Data berhasil disimpan"
       Else
           SQL = "update jadwal set kode_jadwal='" & _kode_jadwal & "', jam_tayang='" & _jam_tayang & "' where kode='" & _kode & "'"
           info = "Data berhasil diperbarui"
       End If
       cn.ExecuteSQL(SQL, info)
   End Sub
   Public Sub Carijadwal(ByVal skode As String)
       DBConnect()
       SQL ="SELECT * FROM jadwal WHERE kode='" & skode & "'"
       cn.DataReader = cn.searchone(SQL)
       If (cn.RecordFound = True) Then
           jadwal_baru= False
           cn.DataReader.Read()
           kode= Convert.ToString((cn.DataReader("kode")))
           tanggal= Convert.ToString((cn.DataReader("tanggal")))
           kode_film= Convert.ToString((cn.DataReader("kode_film")))
       Else
           MessageBox.Show("Data Tidak Ditemukan.")
           jadwal_baru = True
       End If
   End Sub
   Public Sub Hapus(ByVal skode As String)
       Dim info As String
       DBConnect()
       SQL ="DELETE FROM jadwal WHERE kode='" & skode & "'"
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
       SQL ="DELETE FROM detail_jadwal WHERE kode='" & skode & "'"
       info = "Data berhasil dihapus"
       Try
           cn.ExecuteSQL(SQL, info)
       Catch ex As Exception
           MessageBox.Show(ex.ToString)
       End Try
   End Sub
   Public Sub getAllDataDetail(ByVal dg As DataGridView, ByVal skode as string)
       DBConnect()
       dg.DataSource = cn.Data_Record("SELECT * FROM detail_jadwal WHERE kode='" & skode & "'","jadwal")
   End Sub
   Public Sub getAllData(ByVal dg As DataGridView)
       DBConnect()
       dg.DataSource = cn.Data_Record("SELECT * FROM jadwal","jadwal")
   End Sub
End Class
Public Class Jadwal
   Dim strsql As String
   Dim info As String
   Private _id As Integer
   Private _kode As String
   Private _kode_studio As String
   Private _tanggal As String
   Private _kode_film As String
   Private _kode_jadwal As String
   Private _jam_tayang As System.TimeSpan
   Public Property kode()
       Get 
           Return _kode
       End Get 
       Set(ByVal value) 
           _kode = value 
       End Set 
   End Property 
   Public Property kode_studio()
       Get 
           Return _kode_studio
       End Get 
       Set(ByVal value) 
           _kode_studio = value 
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
   Public Property kode_film()
       Get 
           Return _kode_film
       End Get 
       Set(ByVal value) 
           _kode_film = value 
       End Set 
   End Property 
   Public Property kode_jadwal()
       Get 
           Return _kode_jadwal
       End Get 
       Set(ByVal value) 
           _kode_jadwal = value 
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
   Public Sub Simpan()
       Dim info As String 
       DBConnect()
       If (jadwal_baru = True) Then 
           SQL = "Insert into jadwal(kode,kode_studio,tanggal,kode_film) values ('" & _kode & "','"  & _kode_studio & "','"  & _tanggal & "','"  & _kode_film & "')"
           info = "Data berhasil disimpan"
       Else
           SQL = "update jadwal set kode='" & _kode & "', kode_studio='" & _kode_studio & "', tanggal='" & _tanggal & "', kode_film='" & _kode_film & "' where kode='" & _kode & "'"
           info = "Data berhasil diperbarui"
       End If
       cn.ExecuteSQL(SQL, info)
   End Sub
   Public Sub SimpanDetail()
       Dim info As String 
       DBConnect()
       If (detail_jadwal_baru = True) Then 
           SQL = "Insert into detail_jadwal(kode_jadwal,tanggal,jam_tayang) values ('" & _kode_jadwal & "','"  & _tanggal & "','"  & _jam_tayang & "')"
           info = "Data berhasil disimpan"
       Else
           SQL = "update jadwal set kode_jadwal='" & _kode_jadwal & "', tanggal='" & _tanggal & "', jam_tayang='" & _jam_tayang & "' where kode='" & _kode & "'"
           info = "Data berhasil diperbarui"
       End If
       cn.ExecuteSQL(SQL, info)
   End Sub
   Public Sub Carijadwal(ByVal skode As String)
       DBConnect()
       SQL ="SELECT * FROM jadwal WHERE kode='" & skode & "'"
       cn.DataReader = cn.searchone(SQL)
       If (cn.RecordFound = True) Then
           jadwal_baru= False
           cn.DataReader.Read()
           kode= Convert.ToString((cn.DataReader("kode")))
           kode_studio= Convert.ToString((cn.DataReader("kode_studio")))
           tanggal= Convert.ToString((cn.DataReader("tanggal")))
           kode_film= Convert.ToString((cn.DataReader("kode_film")))
       Else
           MessageBox.Show("Data Tidak Ditemukan.")
           jadwal_baru = True
       End If
   End Sub
   Public Sub Hapus(ByVal skode As String)
       Dim info As String
       DBConnect()
       SQL ="DELETE FROM jadwal WHERE kode='" & skode & "'"
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
       SQL ="DELETE FROM detail_jadwal WHERE kode='" & skode & "'"
       info = "Data berhasil dihapus"
       Try
           cn.ExecuteSQL(SQL, info)
       Catch ex As Exception
           MessageBox.Show(ex.ToString)
       End Try
   End Sub
   Public Sub getAllDataDetail(ByVal dg As DataGridView, ByVal skode as string)
       DBConnect()
       dg.DataSource = cn.Data_Record("SELECT * FROM detail_jadwal WHERE kode='" & skode & "'","jadwal")
   End Sub
   Public Sub getAllData(ByVal dg As DataGridView)
       DBConnect()
       dg.DataSource = cn.Data_Record("SELECT * FROM jadwal","jadwal")
   End Sub
End Class
