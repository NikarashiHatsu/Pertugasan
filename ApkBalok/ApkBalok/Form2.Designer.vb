<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtVolume = New System.Windows.Forms.TextBox()
        Me.LblVolume = New System.Windows.Forms.Label()
        Me.TxtLuasPermukaan = New System.Windows.Forms.TextBox()
        Me.LblLuasPermukaan = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtTinggi = New System.Windows.Forms.TextBox()
        Me.LblTinggi = New System.Windows.Forms.Label()
        Me.TxtLebar = New System.Windows.Forms.TextBox()
        Me.LblLebar = New System.Windows.Forms.Label()
        Me.TxtPanjang = New System.Windows.Forms.TextBox()
        Me.LblPanjang = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(167, 239)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Aghits Nidallah"
        '
        'TxtVolume
        '
        Me.TxtVolume.Location = New System.Drawing.Point(144, 184)
        Me.TxtVolume.Name = "TxtVolume"
        Me.TxtVolume.Size = New System.Drawing.Size(100, 20)
        Me.TxtVolume.TabIndex = 22
        '
        'LblVolume
        '
        Me.LblVolume.AutoSize = True
        Me.LblVolume.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVolume.Location = New System.Drawing.Point(9, 184)
        Me.LblVolume.Name = "LblVolume"
        Me.LblVolume.Size = New System.Drawing.Size(63, 20)
        Me.LblVolume.TabIndex = 21
        Me.LblVolume.Text = "Volume"
        '
        'TxtLuasPermukaan
        '
        Me.TxtLuasPermukaan.Location = New System.Drawing.Point(144, 151)
        Me.TxtLuasPermukaan.Name = "TxtLuasPermukaan"
        Me.TxtLuasPermukaan.Size = New System.Drawing.Size(100, 20)
        Me.TxtLuasPermukaan.TabIndex = 20
        '
        'LblLuasPermukaan
        '
        Me.LblLuasPermukaan.AutoSize = True
        Me.LblLuasPermukaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLuasPermukaan.Location = New System.Drawing.Point(9, 151)
        Me.LblLuasPermukaan.Name = "LblLuasPermukaan"
        Me.LblLuasPermukaan.Size = New System.Drawing.Size(129, 20)
        Me.LblLuasPermukaan.TabIndex = 19
        Me.LblLuasPermukaan.Text = "Luas Permukaan"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(144, 111)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Hitung"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtTinggi
        '
        Me.TxtTinggi.Location = New System.Drawing.Point(144, 73)
        Me.TxtTinggi.Name = "TxtTinggi"
        Me.TxtTinggi.Size = New System.Drawing.Size(100, 20)
        Me.TxtTinggi.TabIndex = 17
        '
        'LblTinggi
        '
        Me.LblTinggi.AutoSize = True
        Me.LblTinggi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTinggi.Location = New System.Drawing.Point(9, 73)
        Me.LblTinggi.Name = "LblTinggi"
        Me.LblTinggi.Size = New System.Drawing.Size(51, 20)
        Me.LblTinggi.TabIndex = 16
        Me.LblTinggi.Text = "Tinggi"
        '
        'TxtLebar
        '
        Me.TxtLebar.Location = New System.Drawing.Point(144, 43)
        Me.TxtLebar.Name = "TxtLebar"
        Me.TxtLebar.Size = New System.Drawing.Size(100, 20)
        Me.TxtLebar.TabIndex = 15
        '
        'LblLebar
        '
        Me.LblLebar.AutoSize = True
        Me.LblLebar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLebar.Location = New System.Drawing.Point(9, 43)
        Me.LblLebar.Name = "LblLebar"
        Me.LblLebar.Size = New System.Drawing.Size(50, 20)
        Me.LblLebar.TabIndex = 14
        Me.LblLebar.Text = "Lebar"
        '
        'TxtPanjang
        '
        Me.TxtPanjang.Location = New System.Drawing.Point(144, 13)
        Me.TxtPanjang.Name = "TxtPanjang"
        Me.TxtPanjang.Size = New System.Drawing.Size(100, 20)
        Me.TxtPanjang.TabIndex = 13
        '
        'LblPanjang
        '
        Me.LblPanjang.AutoSize = True
        Me.LblPanjang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPanjang.Location = New System.Drawing.Point(9, 13)
        Me.LblPanjang.Name = "LblPanjang"
        Me.LblPanjang.Size = New System.Drawing.Size(67, 20)
        Me.LblPanjang.TabIndex = 12
        Me.LblPanjang.Text = "Panjang"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtVolume)
        Me.Controls.Add(Me.LblVolume)
        Me.Controls.Add(Me.TxtLuasPermukaan)
        Me.Controls.Add(Me.LblLuasPermukaan)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtTinggi)
        Me.Controls.Add(Me.LblTinggi)
        Me.Controls.Add(Me.TxtLebar)
        Me.Controls.Add(Me.LblLebar)
        Me.Controls.Add(Me.TxtPanjang)
        Me.Controls.Add(Me.LblPanjang)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtVolume As System.Windows.Forms.TextBox
    Friend WithEvents LblVolume As System.Windows.Forms.Label
    Friend WithEvents TxtLuasPermukaan As System.Windows.Forms.TextBox
    Friend WithEvents LblLuasPermukaan As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtTinggi As System.Windows.Forms.TextBox
    Friend WithEvents LblTinggi As System.Windows.Forms.Label
    Friend WithEvents TxtLebar As System.Windows.Forms.TextBox
    Friend WithEvents LblLebar As System.Windows.Forms.Label
    Friend WithEvents TxtPanjang As System.Windows.Forms.TextBox
    Friend WithEvents LblPanjang As System.Windows.Forms.Label
End Class
