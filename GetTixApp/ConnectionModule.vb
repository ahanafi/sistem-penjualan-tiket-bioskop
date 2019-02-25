Imports libmysqlcic.Client
Imports MySql.Data.MySqlClient
Imports System.IO

Module ConnectionModule
    Public cn As New libmysqlcic.Client
    Public SQL As String
    Public login_valid As Boolean
    Public logged_in_name As String
    Public logged_in_level As String

    Public SELECTED_KURSI As New List(Of Integer)
    Public KODE_TIKET As String
    Public TANGGAL As String

    Public detail_pembelian_baru As Boolean
    'Public oDetail_Pembelian As New Detail_Pembelian

    Public film_baru As Boolean
    Public oFilm As New Film

    Public pembayaran_baru As Boolean
    Public oPembayaran As New Pembayaran

    Public pembelian_baru As Boolean
    Public oPembelian As New Pembelian

    Public users_baru As Boolean
    Public oUsers As New Users

    Public jadwal_baru As Boolean
    Public detail_jadwal_baru As Boolean
    Public oJadwal As New Jadwal

    Public studio_baru As Boolean
    Public oStudio As New Studio

    Public Sub DBConnect()
        cn.Host = "localhost"
        cn.DBUsername = "root"
        cn.DBPassword = ""
        cn.DBName = "db_gettix_app"
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
        Dim strResult As String = ""
        Dim b As Byte
        For Each b In bytesToHash
            strResult += b.ToString("x2")
        Next
        Return strResult
    End Function

    Public Function getKode(ByVal Table As String, ByVal firstCode As String)
        Dim zero As String
        Dim new_kode As String
        DBConnect()
        SQL = "SELECT MAX(kode) AS kode FROM " & Table
        cn.DataReader = cn.searchone(SQL)
        If (cn.RecordFound = True) Then
            cn.DataReader.Read()
            Dim kode = Convert.ToString(cn.DataReader("kode"))
            Dim arrStr As String = kode.substring(kode.lastindexof("-") + 1)
            Dim kode_int As Integer = Val(arrStr) + 1
            Dim lengthStr As Integer = kode_int.ToString.Length

            If (lengthStr = 1) Then
                zero = "000"
            ElseIf (lengthStr = 2) Then
                zero = "00"
            ElseIf (lengthStr = 3) Then
                zero = "0"
            Else
                zero = ""
            End If

            new_kode = firstCode & "-" & zero & kode_int
        Else
            new_kode = ""
        End If
        Return new_kode
    End Function

    'convert image to bytearray
    Public Function imgToByteArray(ByVal img As Image) As Byte()
        Using mStream As New MemoryStream()
            img.Save(mStream, img.RawFormat)
            Return mStream.ToArray()
        End Using
    End Function
    'convert bytearray to image
    Public Function byteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Using mStream As New MemoryStream(byteArrayIn)
            Return Image.FromStream(mStream)
        End Using
    End Function
    'another easy way to convert image to bytearray
    Public Function imgToByteConverter(ByVal inImg As Image) As Byte()
        Dim imgCon As New ImageConverter()
        Return DirectCast(imgCon.ConvertTo(inImg, GetType(Byte())), Byte())
    End Function

    Public Function changeDateToDBFormat(ByVal tanggal As String)
        Dim tgl = tanggal.Split("/")
        Dim hari As String = tgl(0)
        Dim bulan As String = tgl(1)
        Dim tahun As String = tgl(2)
        Dim tanggal_db As String = tahun & "-" & bulan & "-" & hari
        Return tanggal_db
    End Function

    Public Sub alert(ByVal type As String, ByVal msg As String, ByVal isError As Boolean)
        Dim msgType As MsgBoxStyle
        If (type = "error") Then
            msgType = MsgBoxStyle.Information
        ElseIf (type = "info") Then
            msgtype = MsgBoxStyle.Information
        ElseIf (type = "warning") Then
            msgtype = MsgBoxStyle.Exclamation
        End If

        Dim msgHeader As String
        If (isError = True) Then
            msgHeader = "Informasi"
        Else
            msgHeader = "Info"
        End If

        MsgBox(msg, msgType, msgHeader)
    End Sub
End Module
