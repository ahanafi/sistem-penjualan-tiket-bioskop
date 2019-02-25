<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJadwalPilihFilm
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
        Me.btnGoBack = New System.Windows.Forms.Button
        Me.GbShowsToday = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DataFilm = New System.Windows.Forms.DataGridView
        Me.Header = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.GbShowsToday.SuspendLayout()
        CType(Me.DataFilm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Header.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGoBack
        '
        Me.btnGoBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoBack.Location = New System.Drawing.Point(234, 20)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(120, 41)
        Me.btnGoBack.TabIndex = 16
        Me.btnGoBack.Text = "Close"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'GbShowsToday
        '
        Me.GbShowsToday.Controls.Add(Me.Label3)
        Me.GbShowsToday.Controls.Add(Me.Label2)
        Me.GbShowsToday.Controls.Add(Me.DataFilm)
        Me.GbShowsToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbShowsToday.Location = New System.Drawing.Point(25, 114)
        Me.GbShowsToday.Margin = New System.Windows.Forms.Padding(0)
        Me.GbShowsToday.Name = "GbShowsToday"
        Me.GbShowsToday.Size = New System.Drawing.Size(1336, 586)
        Me.GbShowsToday.TabIndex = 17
        Me.GbShowsToday.TabStop = False
        Me.GbShowsToday.Text = "DAFTAR FILM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(150, 523)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(513, 29)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Untuk memilih film silahkan klik pada judul film."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 522)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 29)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "* NOTE :"
        '
        'DataFilm
        '
        Me.DataFilm.AllowUserToAddRows = False
        Me.DataFilm.AllowUserToDeleteRows = False
        Me.DataFilm.AllowUserToResizeColumns = False
        Me.DataFilm.AllowUserToResizeRows = False
        Me.DataFilm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataFilm.Location = New System.Drawing.Point(28, 44)
        Me.DataFilm.MultiSelect = False
        Me.DataFilm.Name = "DataFilm"
        Me.DataFilm.RowTemplate.Height = 24
        Me.DataFilm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataFilm.Size = New System.Drawing.Size(1277, 453)
        Me.DataFilm.TabIndex = 17
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Header.Controls.Add(Me.btnGoBack)
        Me.Header.Controls.Add(Me.Label1)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1399, 82)
        Me.Header.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pilih Film"
        '
        'FormJadwalPilihFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1399, 717)
        Me.Controls.Add(Me.GbShowsToday)
        Me.Controls.Add(Me.Header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormJadwalPilihFilm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormJadwalPilihFilm"
        Me.GbShowsToday.ResumeLayout(False)
        Me.GbShowsToday.PerformLayout()
        CType(Me.DataFilm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Header.ResumeLayout(False)
        Me.Header.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGoBack As System.Windows.Forms.Button
    Friend WithEvents GbShowsToday As System.Windows.Forms.GroupBox
    Friend WithEvents Header As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataFilm As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
