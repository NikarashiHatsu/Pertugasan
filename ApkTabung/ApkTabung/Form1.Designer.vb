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
        Me.LblTabung = New System.Windows.Forms.Label()
        Me.LblTinggi = New System.Windows.Forms.Label()
        Me.TxtJariJari = New System.Windows.Forms.TextBox()
        Me.TxtTinggi = New System.Windows.Forms.TextBox()
        Me.BtnHitung = New System.Windows.Forms.Button()
        Me.TxtVolume = New System.Windows.Forms.TextBox()
        Me.TxtLuasPermukaan = New System.Windows.Forms.TextBox()
        Me.LblVolume = New System.Windows.Forms.Label()
        Me.LblLuasPermukaan = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTabung
        '
        Me.LblTabung.AutoSize = True
        Me.LblTabung.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTabung.Location = New System.Drawing.Point(13, 13)
        Me.LblTabung.Name = "LblTabung"
        Me.LblTabung.Size = New System.Drawing.Size(59, 20)
        Me.LblTabung.TabIndex = 0
        Me.LblTabung.Text = "Jari-jari"
        '
        'LblTinggi
        '
        Me.LblTinggi.AutoSize = True
        Me.LblTinggi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTinggi.Location = New System.Drawing.Point(13, 45)
        Me.LblTinggi.Name = "LblTinggi"
        Me.LblTinggi.Size = New System.Drawing.Size(51, 20)
        Me.LblTinggi.TabIndex = 1
        Me.LblTinggi.Text = "Tinggi"
        '
        'TxtJariJari
        '
        Me.TxtJariJari.Location = New System.Drawing.Point(148, 13)
        Me.TxtJariJari.Name = "TxtJariJari"
        Me.TxtJariJari.Size = New System.Drawing.Size(100, 20)
        Me.TxtJariJari.TabIndex = 2
        '
        'TxtTinggi
        '
        Me.TxtTinggi.Location = New System.Drawing.Point(148, 45)
        Me.TxtTinggi.Name = "TxtTinggi"
        Me.TxtTinggi.Size = New System.Drawing.Size(100, 20)
        Me.TxtTinggi.TabIndex = 3
        '
        'BtnHitung
        '
        Me.BtnHitung.Location = New System.Drawing.Point(148, 83)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(100, 23)
        Me.BtnHitung.TabIndex = 4
        Me.BtnHitung.Text = "Hitung"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'TxtVolume
        '
        Me.TxtVolume.Location = New System.Drawing.Point(148, 156)
        Me.TxtVolume.Name = "TxtVolume"
        Me.TxtVolume.Size = New System.Drawing.Size(100, 20)
        Me.TxtVolume.TabIndex = 8
        '
        'TxtLuasPermukaan
        '
        Me.TxtLuasPermukaan.AcceptsReturn = True
        Me.TxtLuasPermukaan.Location = New System.Drawing.Point(148, 124)
        Me.TxtLuasPermukaan.Name = "TxtLuasPermukaan"
        Me.TxtLuasPermukaan.Size = New System.Drawing.Size(100, 20)
        Me.TxtLuasPermukaan.TabIndex = 7
        '
        'LblVolume
        '
        Me.LblVolume.AutoSize = True
        Me.LblVolume.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVolume.Location = New System.Drawing.Point(13, 156)
        Me.LblVolume.Name = "LblVolume"
        Me.LblVolume.Size = New System.Drawing.Size(63, 20)
        Me.LblVolume.TabIndex = 6
        Me.LblVolume.Text = "Volume"
        '
        'LblLuasPermukaan
        '
        Me.LblLuasPermukaan.AutoSize = True
        Me.LblLuasPermukaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLuasPermukaan.Location = New System.Drawing.Point(13, 124)
        Me.LblLuasPermukaan.Name = "LblLuasPermukaan"
        Me.LblLuasPermukaan.Size = New System.Drawing.Size(129, 20)
        Me.LblLuasPermukaan.TabIndex = 5
        Me.LblLuasPermukaan.Text = "Luas Permukaan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(171, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Aghits Nidallah"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 219)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtVolume)
        Me.Controls.Add(Me.TxtLuasPermukaan)
        Me.Controls.Add(Me.LblVolume)
        Me.Controls.Add(Me.LblLuasPermukaan)
        Me.Controls.Add(Me.BtnHitung)
        Me.Controls.Add(Me.TxtTinggi)
        Me.Controls.Add(Me.TxtJariJari)
        Me.Controls.Add(Me.LblTinggi)
        Me.Controls.Add(Me.LblTabung)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTabung As System.Windows.Forms.Label
    Friend WithEvents LblTinggi As System.Windows.Forms.Label
    Friend WithEvents TxtJariJari As System.Windows.Forms.TextBox
    Friend WithEvents TxtTinggi As System.Windows.Forms.TextBox
    Friend WithEvents BtnHitung As System.Windows.Forms.Button
    Friend WithEvents TxtVolume As System.Windows.Forms.TextBox
    Friend WithEvents TxtLuasPermukaan As System.Windows.Forms.TextBox
    Friend WithEvents LblVolume As System.Windows.Forms.Label
    Friend WithEvents LblLuasPermukaan As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
