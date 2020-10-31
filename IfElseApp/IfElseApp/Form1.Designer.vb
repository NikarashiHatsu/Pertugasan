<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblNilaiKehadiran = New System.Windows.Forms.Label()
        Me.TxtNilaiKehadiran = New System.Windows.Forms.TextBox()
        Me.TxtNilaiTugas = New System.Windows.Forms.TextBox()
        Me.LblNilaiTugas = New System.Windows.Forms.Label()
        Me.TxtNilaiUTS = New System.Windows.Forms.TextBox()
        Me.LblNilaiUTS = New System.Windows.Forms.Label()
        Me.TxtNilaiUAS = New System.Windows.Forms.TextBox()
        Me.LblNilaiUAS = New System.Windows.Forms.Label()
        Me.BtnProses = New System.Windows.Forms.Button()
        Me.TxtNilaiAkhir = New System.Windows.Forms.TextBox()
        Me.LblNilaiAkhir = New System.Windows.Forms.Label()
        Me.TxtKeterangan = New System.Windows.Forms.TextBox()
        Me.LblKeterangan = New System.Windows.Forms.Label()
        Me.TxtNilaiMutu = New System.Windows.Forms.TextBox()
        Me.LblNilaiMutu = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblNilaiKehadiran
        '
        Me.LblNilaiKehadiran.AutoSize = True
        Me.LblNilaiKehadiran.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNilaiKehadiran.Location = New System.Drawing.Point(13, 13)
        Me.LblNilaiKehadiran.Name = "LblNilaiKehadiran"
        Me.LblNilaiKehadiran.Size = New System.Drawing.Size(114, 20)
        Me.LblNilaiKehadiran.TabIndex = 0
        Me.LblNilaiKehadiran.Text = "Nilai Kehadiran"
        '
        'TxtNilaiKehadiran
        '
        Me.TxtNilaiKehadiran.Location = New System.Drawing.Point(172, 13)
        Me.TxtNilaiKehadiran.Name = "TxtNilaiKehadiran"
        Me.TxtNilaiKehadiran.Size = New System.Drawing.Size(100, 20)
        Me.TxtNilaiKehadiran.TabIndex = 1
        '
        'TxtNilaiTugas
        '
        Me.TxtNilaiTugas.Location = New System.Drawing.Point(172, 49)
        Me.TxtNilaiTugas.Name = "TxtNilaiTugas"
        Me.TxtNilaiTugas.Size = New System.Drawing.Size(100, 20)
        Me.TxtNilaiTugas.TabIndex = 3
        '
        'LblNilaiTugas
        '
        Me.LblNilaiTugas.AutoSize = True
        Me.LblNilaiTugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNilaiTugas.Location = New System.Drawing.Point(13, 49)
        Me.LblNilaiTugas.Name = "LblNilaiTugas"
        Me.LblNilaiTugas.Size = New System.Drawing.Size(86, 20)
        Me.LblNilaiTugas.TabIndex = 2
        Me.LblNilaiTugas.Text = "Nilai Tugas"
        '
        'TxtNilaiUTS
        '
        Me.TxtNilaiUTS.Location = New System.Drawing.Point(171, 85)
        Me.TxtNilaiUTS.Name = "TxtNilaiUTS"
        Me.TxtNilaiUTS.Size = New System.Drawing.Size(100, 20)
        Me.TxtNilaiUTS.TabIndex = 5
        '
        'LblNilaiUTS
        '
        Me.LblNilaiUTS.AutoSize = True
        Me.LblNilaiUTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNilaiUTS.Location = New System.Drawing.Point(12, 85)
        Me.LblNilaiUTS.Name = "LblNilaiUTS"
        Me.LblNilaiUTS.Size = New System.Drawing.Size(74, 20)
        Me.LblNilaiUTS.TabIndex = 4
        Me.LblNilaiUTS.Text = "Nilai UTS"
        '
        'TxtNilaiUAS
        '
        Me.TxtNilaiUAS.Location = New System.Drawing.Point(171, 121)
        Me.TxtNilaiUAS.Name = "TxtNilaiUAS"
        Me.TxtNilaiUAS.Size = New System.Drawing.Size(100, 20)
        Me.TxtNilaiUAS.TabIndex = 7
        '
        'LblNilaiUAS
        '
        Me.LblNilaiUAS.AutoSize = True
        Me.LblNilaiUAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNilaiUAS.Location = New System.Drawing.Point(12, 121)
        Me.LblNilaiUAS.Name = "LblNilaiUAS"
        Me.LblNilaiUAS.Size = New System.Drawing.Size(76, 20)
        Me.LblNilaiUAS.TabIndex = 6
        Me.LblNilaiUAS.Text = "Nilai UAS"
        '
        'BtnProses
        '
        Me.BtnProses.Location = New System.Drawing.Point(110, 163)
        Me.BtnProses.Name = "BtnProses"
        Me.BtnProses.Size = New System.Drawing.Size(75, 23)
        Me.BtnProses.TabIndex = 8
        Me.BtnProses.Text = "Proses"
        Me.BtnProses.UseVisualStyleBackColor = True
        '
        'TxtNilaiAkhir
        '
        Me.TxtNilaiAkhir.Enabled = False
        Me.TxtNilaiAkhir.Location = New System.Drawing.Point(172, 201)
        Me.TxtNilaiAkhir.Name = "TxtNilaiAkhir"
        Me.TxtNilaiAkhir.Size = New System.Drawing.Size(100, 20)
        Me.TxtNilaiAkhir.TabIndex = 10
        '
        'LblNilaiAkhir
        '
        Me.LblNilaiAkhir.AutoSize = True
        Me.LblNilaiAkhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNilaiAkhir.Location = New System.Drawing.Point(13, 201)
        Me.LblNilaiAkhir.Name = "LblNilaiAkhir"
        Me.LblNilaiAkhir.Size = New System.Drawing.Size(78, 20)
        Me.LblNilaiAkhir.TabIndex = 9
        Me.LblNilaiAkhir.Text = "Nilai Akhir"
        '
        'TxtKeterangan
        '
        Me.TxtKeterangan.Enabled = False
        Me.TxtKeterangan.Location = New System.Drawing.Point(171, 237)
        Me.TxtKeterangan.Name = "TxtKeterangan"
        Me.TxtKeterangan.Size = New System.Drawing.Size(100, 20)
        Me.TxtKeterangan.TabIndex = 12
        '
        'LblKeterangan
        '
        Me.LblKeterangan.AutoSize = True
        Me.LblKeterangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKeterangan.Location = New System.Drawing.Point(12, 237)
        Me.LblKeterangan.Name = "LblKeterangan"
        Me.LblKeterangan.Size = New System.Drawing.Size(92, 20)
        Me.LblKeterangan.TabIndex = 11
        Me.LblKeterangan.Text = "Keterangan"
        '
        'TxtNilaiMutu
        '
        Me.TxtNilaiMutu.Enabled = False
        Me.TxtNilaiMutu.Location = New System.Drawing.Point(171, 273)
        Me.TxtNilaiMutu.Name = "TxtNilaiMutu"
        Me.TxtNilaiMutu.Size = New System.Drawing.Size(100, 20)
        Me.TxtNilaiMutu.TabIndex = 14
        '
        'LblNilaiMutu
        '
        Me.LblNilaiMutu.AutoSize = True
        Me.LblNilaiMutu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNilaiMutu.Location = New System.Drawing.Point(12, 273)
        Me.LblNilaiMutu.Name = "LblNilaiMutu"
        Me.LblNilaiMutu.Size = New System.Drawing.Size(78, 20)
        Me.LblNilaiMutu.TabIndex = 13
        Me.LblNilaiMutu.Text = "Nilai Mutu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 325)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Aghits Nidallah - 190511038 K1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 347)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNilaiMutu)
        Me.Controls.Add(Me.LblNilaiMutu)
        Me.Controls.Add(Me.TxtKeterangan)
        Me.Controls.Add(Me.LblKeterangan)
        Me.Controls.Add(Me.TxtNilaiAkhir)
        Me.Controls.Add(Me.LblNilaiAkhir)
        Me.Controls.Add(Me.BtnProses)
        Me.Controls.Add(Me.TxtNilaiUAS)
        Me.Controls.Add(Me.LblNilaiUAS)
        Me.Controls.Add(Me.TxtNilaiUTS)
        Me.Controls.Add(Me.LblNilaiUTS)
        Me.Controls.Add(Me.TxtNilaiTugas)
        Me.Controls.Add(Me.LblNilaiTugas)
        Me.Controls.Add(Me.TxtNilaiKehadiran)
        Me.Controls.Add(Me.LblNilaiKehadiran)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblNilaiKehadiran As System.Windows.Forms.Label
    Friend WithEvents TxtNilaiKehadiran As System.Windows.Forms.TextBox
    Friend WithEvents TxtNilaiTugas As System.Windows.Forms.TextBox
    Friend WithEvents LblNilaiTugas As System.Windows.Forms.Label
    Friend WithEvents TxtNilaiUTS As System.Windows.Forms.TextBox
    Friend WithEvents LblNilaiUTS As System.Windows.Forms.Label
    Friend WithEvents TxtNilaiUAS As System.Windows.Forms.TextBox
    Friend WithEvents LblNilaiUAS As System.Windows.Forms.Label
    Friend WithEvents BtnProses As System.Windows.Forms.Button
    Friend WithEvents TxtNilaiAkhir As System.Windows.Forms.TextBox
    Friend WithEvents LblNilaiAkhir As System.Windows.Forms.Label
    Friend WithEvents TxtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents LblKeterangan As System.Windows.Forms.Label
    Friend WithEvents TxtNilaiMutu As System.Windows.Forms.TextBox
    Friend WithEvents LblNilaiMutu As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
