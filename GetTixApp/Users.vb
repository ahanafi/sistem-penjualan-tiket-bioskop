Public Class Users
   Dim strsql As String
   Dim info As String
   Private _id As Integer
   Private _nama As String
   Private _username As String
   Private _password As String
    Private _level As Integer
   Public Property nama()
       Get 
           Return _nama
       End Get 
       Set(ByVal value) 
           _nama = value 
       End Set 
   End Property 
   Public Property username()
       Get 
           Return _username
       End Get 
       Set(ByVal value) 
           _username = value 
       End Set 
   End Property 
   Public Property password()
       Get 
           Return _password
       End Get 
       Set(ByVal value) 
           _password = value 
       End Set 
   End Property 
   Public Property level()
       Get 
           Return _level
       End Get 
       Set(ByVal value) 
           _level = value 
       End Set 
   End Property 
   Public Sub Simpan()
       Dim info As String 
       DBConnect()
       If (users_baru = True) Then 
            SQL = "Insert into users(nama,username,password,level) values ('" & _nama & "','" & _username & "',MD5('" & _password & "'),'" & _level & "')"
           info = "Data berhasil disimpan"
       Else
            SQL = "update users set nama='" & _nama & "', username='" & _username & "', password=MD5('" & _password & "'), level='" & _level & "' where username='" & _username & "'"
           info = "Data berhasil diperbarui"
       End If
       cn.ExecuteSQL(SQL, info)
   End Sub
   Public Sub Cariusers(ByVal snama As String)
        DBConnect()
        SQL = "SELECT * FROM users WHERE username ='" & snama & "'"
       cn.DataReader = cn.searchone(SQL)
       If (cn.RecordFound = True) Then
            users_baru = False
            cn.DataReader.Read()
           nama= Convert.ToString((cn.DataReader("nama")))
           username= Convert.ToString((cn.DataReader("username")))
           password= Convert.ToString((cn.DataReader("password")))
            level = cn.DataReader("level")
       Else
           MessageBox.Show("Data Tidak Ditemukan.")
           users_baru = True
       End If
   End Sub
   Public Sub Hapus(ByVal snama As String)
       Dim info As String
       DBConnect()
        SQL = "DELETE FROM users WHERE username='" & snama & "'"
       info = "Data berhasil dihapus"
       Try
           cn.ExecuteSQL(SQL, info)
       Catch ex As Exception
           MessageBox.Show(ex.ToString)
       End Try
   End Sub
   Public Sub getAllData(ByVal dg As DataGridView)
       DBConnect()
        dg.DataSource = cn.Data_Record("SELECT id as ID, nama as 'Nama Asli', username as 'Username', level as 'Is Admin' FROM users", "users")
    End Sub
    Public Function Login(ByVal uname As String, ByVal pwd As String) As Boolean
        DBConnect()
        SQL = "SELECT * FROM users WHERE username='" & uname & "' and password =MD5('" & pwd & "')"
        cn.DataReader = cn.searchone(SQL)
        If (cn.RecordFound = True) Then
            login_valid = True
            cn.DataReader.read()
            logged_in_name = Convert.ToString(cn.DataReader("nama"))
            logged_in_level = cn.DataReader("level")
        Else
            login_valid = False
        End If
        Return login_valid
    End Function
End Class
