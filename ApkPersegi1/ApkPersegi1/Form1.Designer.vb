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
        Me.BtnHitung = New System.Windows.Forms.Button()
        Me.LblPanjang = New System.Windows.Forms.Label()
        Me.TxtPanjang = New System.Windows.Forms.TextBox()
        Me.TxtLebar = New System.Windows.Forms.TextBox()
        Me.LblLebar = New System.Windows.Forms.Label()
        Me.TxtKeliling = New System.Windows.Forms.TextBox()
        Me.LblKeliling = New System.Windows.Forms.Label()
        Me.TxtLuas = New System.Windows.Forms.TextBox()
        Me.LblLuas = New System.Windows.Forms.Label()
        Me.LblNama = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnHitung
        '
        Me.BtnHitung.Location = New System.Drawing.Point(96, 102)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(100, 28)
        Me.BtnHitung.TabIndex = 0
        Me.BtnHitung.Text = "Hitung"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'LblPanjang
        '
        Me.LblPanjang.AutoSize = True
        Me.LblPanjang.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPanjang.Location = New System.Drawing.Point(5, 8)
        Me.LblPanjang.Name = "LblPanjang"
        Me.LblPanjang.Size = New System.Drawing.Size(79, 24)
        Me.LblPanjang.TabIndex = 1
        Me.LblPanjang.Text = "Panjang"
        '
        'TxtPanjang
        '
        Me.TxtPanjang.Location = New System.Drawing.Point(96, 12)
        Me.TxtPanjang.Name = "TxtPanjang"
        Me.TxtPanjang.Size = New System.Drawing.Size(100, 20)
        Me.TxtPanjang.TabIndex = 2
        '
        'TxtLebar
        '
        Me.TxtLebar.Location = New System.Drawing.Point(96, 52)
        Me.TxtLebar.Name = "TxtLebar"
        Me.TxtLebar.Size = New System.Drawing.Size(100, 20)
        Me.TxtLebar.TabIndex = 4
        '
        'LblLebar
        '
        Me.LblLebar.AutoSize = True
        Me.LblLebar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLebar.Location = New System.Drawing.Point(5, 48)
        Me.LblLebar.Name = "LblLebar"
        Me.LblLebar.Size = New System.Drawing.Size(58, 24)
        Me.LblLebar.TabIndex = 3
        Me.LblLebar.Text = "Lebar"
        '
        'TxtKeliling
        '
        Me.TxtKeliling.Location = New System.Drawing.Point(96, 198)
        Me.TxtKeliling.Name = "TxtKeliling"
        Me.TxtKeliling.Size = New System.Drawing.Size(100, 20)
        Me.TxtKeliling.TabIndex = 8
        '
        'LblKeliling
        '
        Me.LblKeliling.AutoSize = True
        Me.LblKeliling.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKeliling.Location = New System.Drawing.Point(5, 194)
        Me.LblKeliling.Name = "LblKeliling"
        Me.LblKeliling.Size = New System.Drawing.Size(71, 24)
        Me.LblKeliling.TabIndex = 7
        Me.LblKeliling.Text = "Keliling"
        '
        'TxtLuas
        '
        Me.TxtLuas.Location = New System.Drawing.Point(96, 158)
        Me.TxtLuas.Name = "TxtLuas"
        Me.TxtLuas.Size = New System.Drawing.Size(100, 20)
        Me.TxtLuas.TabIndex = 6
        '
        'LblLuas
        '
        Me.LblLuas.AutoSize = True
        Me.LblLuas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLuas.Location = New System.Drawing.Point(5, 154)
        Me.LblLuas.Name = "LblLuas"
        Me.LblLuas.Size = New System.Drawing.Size(50, 24)
        Me.LblLuas.TabIndex = 5
        Me.LblLuas.Text = "Luas"
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Location = New System.Drawing.Point(119, 232)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(77, 13)
        Me.LblNama.TabIndex = 9
        Me.LblNama.Text = "Aghits Nidallah"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(208, 256)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.TxtKeliling)
        Me.Controls.Add(Me.LblKeliling)
        Me.Controls.Add(Me.TxtLuas)
        Me.Controls.Add(Me.LblLuas)
        Me.Controls.Add(Me.TxtLebar)
        Me.Controls.Add(Me.LblLebar)
        Me.Controls.Add(Me.TxtPanjang)
        Me.Controls.Add(Me.LblPanjang)
        Me.Controls.Add(Me.BtnHitung)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnHitung As System.Windows.Forms.Button
    Friend WithEvents LblPanjang As System.Windows.Forms.Label
    Friend WithEvents TxtPanjang As System.Windows.Forms.TextBox
    Friend WithEvents TxtLebar As System.Windows.Forms.TextBox
    Friend WithEvents LblLebar As System.Windows.Forms.Label
    Friend WithEvents TxtKeliling As System.Windows.Forms.TextBox
    Friend WithEvents LblKeliling As System.Windows.Forms.Label
    Friend WithEvents TxtLuas As System.Windows.Forms.TextBox
    Friend WithEvents LblLuas As System.Windows.Forms.Label
    Friend WithEvents LblNama As System.Windows.Forms.Label

End Class
