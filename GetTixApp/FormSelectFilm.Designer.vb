<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSelectFilm
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.GbShowsToday = New System.Windows.Forms.GroupBox
        Me.btnGoBack = New System.Windows.Forms.Button
        Me.Header = New System.Windows.Forms.Panel
        Me.Header.SuspendLayout()
        Me.SuspendLayout()
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
        'GbShowsToday
        '
        Me.GbShowsToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbShowsToday.Location = New System.Drawing.Point(25, 112)
        Me.GbShowsToday.Margin = New System.Windows.Forms.Padding(0)
        Me.GbShowsToday.Name = "GbShowsToday"
        Me.GbShowsToday.Size = New System.Drawing.Size(1455, 905)
        Me.GbShowsToday.TabIndex = 15
        Me.GbShowsToday.TabStop = False
        Me.GbShowsToday.Text = "TAYANG HARI INI"
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
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Header.Controls.Add(Me.btnGoBack)
        Me.Header.Controls.Add(Me.Label1)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1518, 82)
        Me.Header.TabIndex = 14
        '
        'FormSelectFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1518, 1053)
        Me.Controls.Add(Me.GbShowsToday)
        Me.Controls.Add(Me.Header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSelectFilm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSelectFilm"
        Me.Header.ResumeLayout(False)
        Me.Header.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GbShowsToday As System.Windows.Forms.GroupBox
    Friend WithEvents btnGoBack As System.Windows.Forms.Button
    Friend WithEvents Header As System.Windows.Forms.Panel
End Class
