    Imports libmysqlcic.Client 
    Imports System.Text 
    Imports System.Security.Cryptography 
    Module ConnectionModule
       Public cn As New libmysqlcic.Client
       Public SQL As String

       Public detail_pembelian_baru As Boolean
       Public oDetail_Pembelian As New Detail_Pembelian

       Public film_baru As Boolean
       Public oFilm As New Film

       Public pembayaran_baru As Boolean
       Public oPembayaran As New Pembayaran

       Public pembelian_baru As Boolean
       Public oPembelian As New Pembelian

       Public tiket_baru As Boolean
       Public oTiket As New Tiket

       Public users_baru As Boolean
       Public oUsers As New Users

       Public Sub DBConnect()
           cn.Host ="localhost"
           cn.DBUsername ="root"
           cn.DBPassword =""
           cn.DBName ="db_ticketing"
           cn.Connect()
       End Sub

       Public Sub ClearTextBox(ByVal root As Control)

           For Each ctrl As Control In root.Controls

           ClearTextBox(ctrl)

           If TypeOf ctrl Is TextBox Then

               CType(ctrl, TextBox).Text = String.Empty

           End If

           Next ctrl

       End Sub

       Public Function getMD5Hash(ByVal strToHash As String) As String

           Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider()

           Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

           bytesToHash = md5Obj.ComputeHash(bytesToHash)

           Dim strResult As String = "

           Dim b As Byte

           For Each b In bytesToHash

               strResult += b.ToString("x2")

           Next

           Return strResult

       End Function

    End Module
