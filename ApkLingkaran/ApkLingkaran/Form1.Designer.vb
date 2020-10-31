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
        Me.LblJariJari = New System.Windows.Forms.Label()
        Me.TxtJariJari = New System.Windows.Forms.TextBox()
        Me.TxtLuas = New System.Windows.Forms.TextBox()
        Me.LblLuas = New System.Windows.Forms.Label()
        Me.TxtKeliling = New System.Windows.Forms.TextBox()
        Me.LblKeliling = New System.Windows.Forms.Label()
        Me.BtnHitung = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblJariJari
        '
        Me.LblJariJari.AutoSize = True
        Me.LblJariJari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJariJari.Location = New System.Drawing.Point(13, 13)
        Me.LblJariJari.Name = "LblJariJari"
        Me.LblJariJari.Size = New System.Drawing.Size(63, 20)
        Me.LblJariJari.TabIndex = 0
        Me.LblJariJari.Text = "Jari Jari"
        '
        'TxtJariJari
        '
        Me.TxtJariJari.Location = New System.Drawing.Point(98, 15)
        Me.TxtJariJari.Name = "TxtJariJari"
        Me.TxtJariJari.Size = New System.Drawing.Size(100, 20)
        Me.TxtJariJari.TabIndex = 1
        '
        'TxtLuas
        '
        Me.TxtLuas.Location = New System.Drawing.Point(97, 136)
        Me.TxtLuas.Name = "TxtLuas"
        Me.TxtLuas.Size = New System.Drawing.Size(100, 20)
        Me.TxtLuas.TabIndex = 3
        '
        'LblLuas
        '
        Me.LblLuas.AutoSize = True
        Me.LblLuas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLuas.Location = New System.Drawing.Point(12, 134)
        Me.LblLuas.Name = "LblLuas"
        Me.LblLuas.Size = New System.Drawing.Size(44, 20)
        Me.LblLuas.TabIndex = 2
        Me.LblLuas.Text = "Luas"
        '
        'TxtKeliling
        '
        Me.TxtKeliling.Location = New System.Drawing.Point(97, 98)
        Me.TxtKeliling.Name = "TxtKeliling"
        Me.TxtKeliling.Size = New System.Drawing.Size(100, 20)
        Me.TxtKeliling.TabIndex = 5
        '
        'LblKeliling
        '
        Me.LblKeliling.AutoSize = True
        Me.LblKeliling.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKeliling.Location = New System.Drawing.Point(12, 96)
        Me.LblKeliling.Name = "LblKeliling"
        Me.LblKeliling.Size = New System.Drawing.Size(58, 20)
        Me.LblKeliling.TabIndex = 4
        Me.LblKeliling.Text = "Keliling"
        '
        'BtnHitung
        '
        Me.BtnHitung.Location = New System.Drawing.Point(98, 54)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(100, 23)
        Me.BtnHitung.TabIndex = 6
        Me.BtnHitung.Text = "Hitung"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Aghits Nidallah"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(204, 210)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnHitung)
        Me.Controls.Add(Me.TxtKeliling)
        Me.Controls.Add(Me.LblKeliling)
        Me.Controls.Add(Me.TxtLuas)
        Me.Controls.Add(Me.LblLuas)
        Me.Controls.Add(Me.TxtJariJari)
        Me.Controls.Add(Me.LblJariJari)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblJariJari As System.Windows.Forms.Label
    Friend WithEvents TxtJariJari As System.Windows.Forms.TextBox
    Friend WithEvents TxtLuas As System.Windows.Forms.TextBox
    Friend WithEvents LblLuas As System.Windows.Forms.Label
    Friend WithEvents TxtKeliling As System.Windows.Forms.TextBox
    Friend WithEvents LblKeliling As System.Windows.Forms.Label
    Friend WithEvents BtnHitung As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
