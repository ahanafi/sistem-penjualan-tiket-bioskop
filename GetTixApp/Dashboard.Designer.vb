<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Header = New System.Windows.Forms.Panel
        Me.loggedInName = New System.Windows.Forms.Label
        Me.LoggedInLevel = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Sidebar = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.GbShowsToday = New System.Windows.Forms.GroupBox
        Me.btnFilm = New System.Windows.Forms.Button
        Me.btnStudio = New System.Windows.Forms.Button
        Me.btnJadwal = New System.Windows.Forms.Button
        Me.btnPembayaran = New System.Windows.Forms.Button
        Me.btnPembelian = New System.Windows.Forms.Button
        Me.btnUser = New System.Windows.Forms.Button
        Me.btnLogout = New System.Windows.Forms.Button
        Me.Header.SuspendLayout()
        Me.Sidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Header.Controls.Add(Me.btnLogout)
        Me.Header.Controls.Add(Me.loggedInName)
        Me.Header.Controls.Add(Me.LoggedInLevel)
        Me.Header.Controls.Add(Me.Label2)
        Me.Header.Controls.Add(Me.Label1)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1928, 82)
        Me.Header.TabIndex = 0
        '
        'loggedInName
        '
        Me.loggedInName.AutoSize = True
        Me.loggedInName.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.loggedInName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loggedInName.ForeColor = System.Drawing.Color.White
        Me.loggedInName.Location = New System.Drawing.Point(700, 24)
        Me.loggedInName.Name = "loggedInName"
        Me.loggedInName.Size = New System.Drawing.Size(0, 36)
        Me.loggedInName.TabIndex = 3
        '
        'LoggedInLevel
        '
        Me.LoggedInLevel.AutoSize = True
        Me.LoggedInLevel.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.LoggedInLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoggedInLevel.ForeColor = System.Drawing.Color.Black
        Me.LoggedInLevel.Location = New System.Drawing.Point(1000, 23)
        Me.LoggedInLevel.Name = "LoggedInLevel"
        Me.LoggedInLevel.Size = New System.Drawing.Size(0, 36)
        Me.LoggedInLevel.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(670, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 39)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "|"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(604, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Aplikasi Sistem Penjualan Tiket Film"
        '
        'Sidebar
        '
        Me.Sidebar.BackColor = System.Drawing.Color.SteelBlue
        Me.Sidebar.Controls.Add(Me.btnStudio)
        Me.Sidebar.Controls.Add(Me.btnJadwal)
        Me.Sidebar.Controls.Add(Me.btnPembayaran)
        Me.Sidebar.Controls.Add(Me.btnPembelian)
        Me.Sidebar.Controls.Add(Me.btnUser)
        Me.Sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.Sidebar.Location = New System.Drawing.Point(0, 82)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.Size = New System.Drawing.Size(400, 985)
        Me.Sidebar.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(429, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1220, 31)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Selamat datang di Aplikasi Penjualan Tiket Film, Silahkan pilih daftar film yang " & _
            "akan dipesan."
        '
        'GbShowsToday
        '
        Me.GbShowsToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GbShowsToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbShowsToday.Location = New System.Drawing.Point(435, 150)
        Me.GbShowsToday.Name = "GbShowsToday"
        Me.GbShowsToday.Size = New System.Drawing.Size(1455, 905)
        Me.GbShowsToday.TabIndex = 5
        Me.GbShowsToday.TabStop = False
        Me.GbShowsToday.Text = "TAYANG HARI INI"
        '
        'btnFilm
        '
        Me.btnFilm.BackColor = System.Drawing.Color.SteelBlue
        Me.btnFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilm.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilm.ForeColor = System.Drawing.Color.White
        Me.btnFilm.Image = Global.GetTixApp.My.Resources.Resources.Film_Strip
        Me.btnFilm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFilm.Location = New System.Drawing.Point(0, 81)
        Me.btnFilm.Name = "btnFilm"
        Me.btnFilm.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnFilm.Size = New System.Drawing.Size(400, 70)
        Me.btnFilm.TabIndex = 1
        Me.btnFilm.Text = "DATA FILM               "
        Me.btnFilm.UseVisualStyleBackColor = False
        '
        'btnStudio
        '
        Me.btnStudio.BackColor = System.Drawing.Color.SteelBlue
        Me.btnStudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudio.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudio.ForeColor = System.Drawing.Color.White
        Me.btnStudio.Image = Global.GetTixApp.My.Resources.Resources.Film_Projector
        Me.btnStudio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudio.Location = New System.Drawing.Point(0, 68)
        Me.btnStudio.Name = "btnStudio"
        Me.btnStudio.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnStudio.Size = New System.Drawing.Size(400, 70)
        Me.btnStudio.TabIndex = 6
        Me.btnStudio.Text = "DATA STUDIO          "
        Me.btnStudio.UseVisualStyleBackColor = False
        '
        'btnJadwal
        '
        Me.btnJadwal.BackColor = System.Drawing.Color.SteelBlue
        Me.btnJadwal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJadwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJadwal.ForeColor = System.Drawing.Color.White
        Me.btnJadwal.Image = Global.GetTixApp.My.Resources.Resources.Calendar_Day
        Me.btnJadwal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnJadwal.Location = New System.Drawing.Point(0, 137)
        Me.btnJadwal.Name = "btnJadwal"
        Me.btnJadwal.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnJadwal.Size = New System.Drawing.Size(400, 70)
        Me.btnJadwal.TabIndex = 5
        Me.btnJadwal.Text = "DATA JADWAL         "
        Me.btnJadwal.UseVisualStyleBackColor = False
        '
        'btnPembayaran
        '
        Me.btnPembayaran.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPembayaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPembayaran.ForeColor = System.Drawing.Color.White
        Me.btnPembayaran.Image = CType(resources.GetObject("btnPembayaran.Image"), System.Drawing.Image)
        Me.btnPembayaran.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPembayaran.Location = New System.Drawing.Point(0, 275)
        Me.btnPembayaran.Name = "btnPembayaran"
        Me.btnPembayaran.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnPembayaran.Size = New System.Drawing.Size(400, 70)
        Me.btnPembayaran.TabIndex = 4
        Me.btnPembayaran.Text = "  DATA PEMBAYARAN"
        Me.btnPembayaran.UseVisualStyleBackColor = False
        '
        'btnPembelian
        '
        Me.btnPembelian.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPembelian.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPembelian.ForeColor = System.Drawing.Color.White
        Me.btnPembelian.Image = CType(resources.GetObject("btnPembelian.Image"), System.Drawing.Image)
        Me.btnPembelian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPembelian.Location = New System.Drawing.Point(0, 206)
        Me.btnPembelian.Name = "btnPembelian"
        Me.btnPembelian.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnPembelian.Size = New System.Drawing.Size(400, 70)
        Me.btnPembelian.TabIndex = 2
        Me.btnPembelian.Text = "DATA PEMBELIAN   "
        Me.btnPembelian.UseVisualStyleBackColor = False
        '
        'btnUser
        '
        Me.btnUser.BackColor = System.Drawing.Color.SteelBlue
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.White
        Me.btnUser.Image = CType(resources.GetObject("btnUser.Image"), System.Drawing.Image)
        Me.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.Location = New System.Drawing.Point(0, 344)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnUser.Size = New System.Drawing.Size(400, 70)
        Me.btnUser.TabIndex = 1
        Me.btnUser.Text = "DATA USER             "
        Me.btnUser.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Transparent
        Me.btnLogout.Image = Global.GetTixApp.My.Resources.Resources.Untitled_2
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(1710, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(218, 82)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "  LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1928, 1067)
        Me.Controls.Add(Me.GbShowsToday)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnFilm)
        Me.Controls.Add(Me.Sidebar)
        Me.Controls.Add(Me.Header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.Header.ResumeLayout(False)
        Me.Header.PerformLayout()
        Me.Sidebar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Header As System.Windows.Forms.Panel
    Friend WithEvents Sidebar As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnFilm As System.Windows.Forms.Button
    Friend WithEvents btnPembelian As System.Windows.Forms.Button
    Friend WithEvents btnUser As System.Windows.Forms.Button
    Friend WithEvents loggedInName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LoggedInLevel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnPembayaran As System.Windows.Forms.Button
    Friend WithEvents btnJadwal As System.Windows.Forms.Button
    Friend WithEvents GbShowsToday As System.Windows.Forms.GroupBox
    Friend WithEvents btnStudio As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
End Class
