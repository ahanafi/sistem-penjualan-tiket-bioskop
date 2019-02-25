Public Class Film
   Dim strsql As String
   Dim info As String
   Private _id As Integer
   Private _kode As String
   Private _judul As String
   Private _sinopsi As String
   Private _tahun_rilis As Integer
   Private _foto As String
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
   Public Property sinopsi()
       Get 
           Return _sinopsi
       End Get 
       Set(ByVal value) 
           _sinopsi = value 
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
   Public Sub Simpan()
       Dim info As String 
       DBConnect()
       If (film_baru = True) Then 
           SQL = "Insert into film(kode,judul,sinopsi,tahun_rilis,foto) values ('" & _kode & "','"  & _judul & "','"  & _sinopsi & "','"  & _tahun_rilis & "','"  & _foto & "')"
           info = "Data berhasil disimpan"
       Else
           SQL = "update film set kode='" & _kode & "', judul='" & _judul & "', sinopsi='" & _sinopsi & "', tahun_rilis='" & _tahun_rilis & "', foto='" & _foto & "' where kode='" & _kode & "'"
           info = "Data berhasil diperbarui"
       End If
       cn.ExecuteSQL(SQL, info)
   End Sub
   Public Sub Carifilm(ByVal skode As String)
       DBConnect()
       SQL ="SELECT * FROM film WHERE kode='" & skode & "'"
       cn.DataReader = cn.searchone(SQL)
       If (cn.RecordFound = True) Then
           film_baru= False
           cn.DataReader.Read()
           kode= Convert.ToString((cn.DataReader("kode")))
           judul= Convert.ToString((cn.DataReader("judul")))
           sinopsi= Convert.ToString((cn.DataReader("sinopsi")))
           tahun_rilis= Convert.ToString((cn.DataReader("tahun_rilis")))
           foto= Convert.ToString((cn.DataReader("foto")))
       Else
           MessageBox.Show("Data Tidak Ditemukan.")
           film_baru = True
       End If
   End Sub
   Public Sub Hapus(ByVal skode As String)
       Dim info As String
       DBConnect()
       SQL ="DELETE FROM film WHERE kode='" & skode & "'"
       info = "Data berhasil dihapus"
       Try
           cn.ExecuteSQL(SQL, info)
       Catch ex As Exception
           MessageBox.Show(ex.ToString)
       End Try
   End Sub
   Public Sub getAllData(ByVal dg As DataGridView)
       DBConnect()
       dg.DataSource = cn.Data_Record("SELECT * FROM film","film")
   End Sub
End Class
