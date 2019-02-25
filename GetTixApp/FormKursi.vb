Public Class FormKursi

    Private btnKursi(25) As Button

    Private Sub FormKursi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = ""
        'Me.ControlBox = False
    End Sub

    Public Sub GenerateButton()
        Dim n As Integer = 0
        Dim xPos As Integer = 40
        Dim yPos As Integer = 54
        For i As Integer = 0 To 24
            btnKursi(i) = New System.Windows.Forms.Button
        Next i

        While (n < 25)
            With (btnKursi(n))
                .Text = "Kursi " & n + 1
                .Width = 122 '100
                .Height = 80 '50

                Dim cek As Boolean = oPembelian.cekKursi(n + 1, TANGGAL, "", KODE_TIKET)
                If (cek = True) Then
                    .BackColor = Color.Red
                    .ForeColor = Color.White
                    .FlatStyle = FlatStyle.Flat
                    .Enabled = False
                End If
                .FlatStyle = FlatStyle.Flat

                If (n = 5) Then
                    xPos = 40
                    yPos = 156
                ElseIf (n = 10) Then
                    xPos = 40
                    yPos = 258
                ElseIf (n = 15) Then
                    xPos = 40
                    yPos = 360
                ElseIf (n = 20) Then
                    xPos = 40
                    yPos = 462
                End If

                .Left = xPos
                .Top = yPos

                PanelKursi.Controls.Add(btnKursi(n))
                xPos = xPos + .Width + 20
                AddHandler .Click, AddressOf Me.pilihKursi
                n += 1
            End With
        End While
    End Sub

    Public Sub pilihKursi(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Dim btn As Button = sender
        Dim text() As String = btn.Text.Split(" ")
        Dim index As Integer = text(1) - 1
        
        btnKursi(index).BackColor = Color.DodgerBlue
        btnKursi(index).ForeColor = Color.White
        SELECTED_KURSI.Add(index)
    End Sub

    Public Function removeStyle(ByVal index As Integer)
        btnKursi(index).BackColor = Color.White
        btnKursi(index).ForeColor = Color.Black
        Return 0
    End Function

    Private Sub btnGoBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoBack.Click
        Me.Close()
        PanelKursi.Controls.Clear()
    End Sub
End Class