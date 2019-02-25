Public Class SplashScreen

    Private Sub SplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Me.Text = ""
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Loading.ForeColor = Color.White
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Loading.Value += 5
        If (Loading.Value = 100) Then
            Timer1.Dispose()
            Me.Visible = False
            Dashboard.Show()
        End If
    End Sub
End Class