Public Class Studio
   Dim strsql As String
   Dim info As String
   Private _id As Integer
   Private _kode As Integer
   Private _nama_studio As String
   Private _jumlah_kursi As Integer
   Public Property kode()
       Get 
           Return _kode
       End Get 
       Set(ByVal value) 
           _kode = value 
       End Set 
   End Property 
   Public Property nama_studio()
       Get 
           Return _nama_studio
       End Get 
       Set(ByVal value) 
           _nama_studio = value 
       End Set 
   End Property 
   Public Property jumlah_kursi()
       Get 
           Return _jumlah_kursi
       End Get 
       Set(ByVal value) 
           _jumlah_kursi = value 
       End Set 
   End Property 
   Public Sub Simpan()
       Dim info As String 
       DBConnect()
       If (studio_baru = True) Then 
           SQL = "Insert into studio(kode,nama_studio,jumlah_kursi) values ('" & _kode & "','"  & _nama_studio & "','"  & _jumlah_kursi & "')"
           info = "Data berhasil disimpan"
       Else
           SQL = "update studio set kode='" & _kode & "', nama_studio='" & _nama_studio & "', jumlah_kursi='" & _jumlah_kursi & "' where kode='" & _kode & "'"
           info = "Data berhasil diperbarui"
       End If
       cn.ExecuteSQL(SQL, info)
   End Sub
   Public Sub Caristudio(ByVal skode As String)
       DBConnect()
       SQL ="SELECT * FROM studio WHERE kode='" & skode & "'"
       cn.DataReader = cn.searchone(SQL)
       If (cn.RecordFound = True) Then
           studio_baru= False
           cn.DataReader.Read()
           kode= Convert.ToString((cn.DataReader("kode")))
           nama_studio= Convert.ToString((cn.DataReader("nama_studio")))
           jumlah_kursi= Convert.ToString((cn.DataReader("jumlah_kursi")))
       Else
           MessageBox.Show("Data Tidak Ditemukan.")
           studio_baru = True
       End If
   End Sub
   Public Sub Hapus(ByVal skode As String)
       Dim info As String
       DBConnect()
       SQL ="DELETE FROM studio WHERE kode='" & skode & "'"
       info = "Data berhasil dihapus"
       Try
           cn.ExecuteSQL(SQL, info)
       Catch ex As Exception
           MessageBox.Show(ex.ToString)
       End Try
   End Sub
   Public Sub getAllData(ByVal dg As DataGridView)
       DBConnect()
       dg.DataSource = cn.Data_Record("SELECT * FROM studio","studio")
   End Sub
End Class
