Public Class Pembayaran
   Dim strsql As String
   Dim info As String
   Private _id As Integer
   Private _kode_pembelian As String
   Private _jumlah_bayar As System.Double
   Private _tanggal As String
   Public Property kode_pembelian()
       Get 
           Return _kode_pembelian
       End Get 
       Set(ByVal value) 
           _kode_pembelian = value 
       End Set 
   End Property 
   Public Property jumlah_bayar()
       Get 
           Return _jumlah_bayar
       End Get 
       Set(ByVal value) 
           _jumlah_bayar = value 
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
   Public Sub Simpan()
       Dim info As String 
       DBConnect()
       If (pembayaran_baru = True) Then 
           SQL = "Insert into pembayaran(kode_pembelian,jumlah_bayar,tanggal) values ('" & _kode_pembelian & "','"  & _jumlah_bayar & "','"  & _tanggal & "')"
           info = "Data berhasil disimpan"
       Else
           SQL = "update pembayaran set kode_pembelian='" & _kode_pembelian & "', jumlah_bayar='" & _jumlah_bayar & "', tanggal='" & _tanggal & "' where kode_pembelian='" & _kode_pembelian & "'"
           info = "Data berhasil diperbarui"
       End If
       cn.ExecuteSQL(SQL, info)
   End Sub
   Public Sub Caripembayaran(ByVal skode_pembelian As String)
       DBConnect()
       SQL ="SELECT * FROM pembayaran WHERE kode_pembelian='" & skode_pembelian & "'"
       cn.DataReader = cn.searchone(SQL)
       If (cn.RecordFound = True) Then
           pembayaran_baru= False
           cn.DataReader.Read()
           kode_pembelian= Convert.ToString((cn.DataReader("kode_pembelian")))
           jumlah_bayar= Convert.ToString((cn.DataReader("jumlah_bayar")))
           tanggal= Convert.ToString((cn.DataReader("tanggal")))
       Else
           MessageBox.Show("Data Tidak Ditemukan.")
           pembayaran_baru = True
       End If
   End Sub
   Public Sub Hapus(ByVal skode_pembelian As String)
       Dim info As String
       DBConnect()
       SQL ="DELETE FROM pembayaran WHERE kode_pembelian='" & skode_pembelian & "'"
       info = "Data berhasil dihapus"
       Try
           cn.ExecuteSQL(SQL, info)
       Catch ex As Exception
           MessageBox.Show(ex.ToString)
       End Try
   End Sub
   Public Sub getAllData(ByVal dg As DataGridView)
       DBConnect()
       dg.DataSource = cn.Data_Record("SELECT * FROM pembayaran","pembayaran")
    End Sub
    Public Function cekPembayaran(ByVal kode_pembelian As String)
        DBConnect()
        SQL = "SELECT * FROM pembayaran WHERE kode_pembelian = '" & kode_pembelian & "'"
        cn.DataReader = cn.searchone(SQL)
        dim is_bayar as Boolean
        If (cn.RecordFound = True) Then
            is_bayar = True
        Else
            is_bayar = False
        End If
        Return is_bayar
    End Function
End Class
