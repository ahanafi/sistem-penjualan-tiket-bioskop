Public Class Studio
   Dim strsql As String
   Dim info As String
    Private _id As Integer
    Private _kode As String
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
        Dim SQL = "SELECT kode as 'Kode Studio', nama_studio as 'Nama Studio', jumlah_kursi as 'Jumlah Kursi' FROM studio"
        dg.DataSource = cn.Data_Record(SQL, "studio")
    End Sub
    Public Function getJumlahKursi(ByVal kode_studio As String)
        DBConnect()
        SQL = "SELECT jumlah_kursi as jumlah FROM studio WHERE kode = '" & kode_studio & "'"
        cn.DataReader = cn.searchone(SQL)
        Dim jumlah As Integer
        If (cn.RecordFound = True) Then
            cn.DataReader.READ()
            jumlah = cn.DataReader("jumlah").ToString()
        Else
            jumlah = 0
        End If
        Return jumlah
    End Function
    Public Function getNamaStudio(ByVal kode_studio As String)
        DBConnect()
        SQL = "SELECT nama_studio as nama FROM studio WHERE kode = '" & kode_studio & "'"
        cn.DataReader = cn.searchone(SQL)
        Dim nama As String
        If (cn.RecordFound = True) Then
            cn.DataReader.READ()
            nama = cn.DataReader("nama").ToString()
        Else
            nama = "Unknown Studio"
        End If
        Return nama
        cn.Disconnect()
    End Function
End Class
