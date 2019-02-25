Public Class Login

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Me.Text = ""
        txtUsername.Focus()
    End Sub

    Private Sub Login(ByVal user As String, ByVal pass As String)
        Dim Login = oUsers.Login(user, pass)
        If (login_valid = True) Then
            Me.Hide()
            'Dashboard.Show()
            SplashScreen.Show()
            oUsers.Cariusers(user)
        Else
            MsgBox("Login Gagal!. Username/Password Anda salah!", MsgBoxStyle.Critical, "Error!")
            ResetForm()
        End If
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim username = txtUsername.Text
        Dim password = txtPassword.Text
        If (username <> "" And password <> "") Then
            Login(username, password)
        Else
            MsgBox("Username dan Password tidak boleh kosong!", MsgBoxStyle.Critical, "Error!")
            ResetForm()
        End If
    End Sub

    Public Sub ResetForm()
        txtUsername.Clear()
        txtPassword.Clear()
        txtUsername.Focus()
    End Sub

    Private Sub btnCloseApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseApp.Click
        Application.Exit()
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If (e.KeyCode = 13) Then
            Dim username = txtUsername.Text
            Dim password = txtPassword.Text
            If (username <> "" And password <> "") Then
                Login(username, password)
            Else
                MsgBox("Username dan Password tidak boleh kosong!", MsgBoxStyle.Critical, "Error!")
                ResetForm()
            End If
        End If
    End Sub
End Class
