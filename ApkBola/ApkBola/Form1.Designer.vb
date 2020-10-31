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
        Me.LblRadius = New System.Windows.Forms.Label()
        Me.TxtRadius = New System.Windows.Forms.TextBox()
        Me.BtnHitung = New System.Windows.Forms.Button()
        Me.TxtLuasPermukaan = New System.Windows.Forms.TextBox()
        Me.LblLuasPermukaan = New System.Windows.Forms.Label()
        Me.TxtVolume = New System.Windows.Forms.TextBox()
        Me.LblVolume = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblRadius
        '
        Me.LblRadius.AutoSize = True
        Me.LblRadius.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRadius.Location = New System.Drawing.Point(13, 13)
        Me.LblRadius.Name = "LblRadius"
        Me.LblRadius.Size = New System.Drawing.Size(59, 20)
        Me.LblRadius.TabIndex = 0
        Me.LblRadius.Text = "Radius"
        '
        'TxtRadius
        '
        Me.TxtRadius.Location = New System.Drawing.Point(148, 13)
        Me.TxtRadius.Name = "TxtRadius"
        Me.TxtRadius.Size = New System.Drawing.Size(100, 20)
        Me.TxtRadius.TabIndex = 1
        '
        'BtnHitung
        '
        Me.BtnHitung.Location = New System.Drawing.Point(148, 50)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(100, 23)
        Me.BtnHitung.TabIndex = 2
        Me.BtnHitung.Text = "Hitung"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'TxtLuasPermukaan
        '
        Me.TxtLuasPermukaan.Location = New System.Drawing.Point(148, 91)
        Me.TxtLuasPermukaan.Name = "TxtLuasPermukaan"
        Me.TxtLuasPermukaan.Size = New System.Drawing.Size(100, 20)
        Me.TxtLuasPermukaan.TabIndex = 4
        '
        'LblLuasPermukaan
        '
        Me.LblLuasPermukaan.AutoSize = True
        Me.LblLuasPermukaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLuasPermukaan.Location = New System.Drawing.Point(13, 91)
        Me.LblLuasPermukaan.Name = "LblLuasPermukaan"
        Me.LblLuasPermukaan.Size = New System.Drawing.Size(129, 20)
        Me.LblLuasPermukaan.TabIndex = 3
        Me.LblLuasPermukaan.Text = "Luas Permukaan"
        '
        'TxtVolume
        '
        Me.TxtVolume.Location = New System.Drawing.Point(147, 126)
        Me.TxtVolume.Name = "TxtVolume"
        Me.TxtVolume.Size = New System.Drawing.Size(100, 20)
        Me.TxtVolume.TabIndex = 6
        '
        'LblVolume
        '
        Me.LblVolume.AutoSize = True
        Me.LblVolume.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVolume.Location = New System.Drawing.Point(12, 126)
        Me.LblVolume.Name = "LblVolume"
        Me.LblVolume.Size = New System.Drawing.Size(63, 20)
        Me.LblVolume.TabIndex = 5
        Me.LblVolume.Text = "Volume"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(171, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Aghits Nidallah"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 191)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtVolume)
        Me.Controls.Add(Me.LblVolume)
        Me.Controls.Add(Me.TxtLuasPermukaan)
        Me.Controls.Add(Me.LblLuasPermukaan)
        Me.Controls.Add(Me.BtnHitung)
        Me.Controls.Add(Me.TxtRadius)
        Me.Controls.Add(Me.LblRadius)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblRadius As System.Windows.Forms.Label
    Friend WithEvents TxtRadius As System.Windows.Forms.TextBox
    Friend WithEvents BtnHitung As System.Windows.Forms.Button
    Friend WithEvents TxtLuasPermukaan As System.Windows.Forms.TextBox
    Friend WithEvents LblLuasPermukaan As System.Windows.Forms.Label
    Friend WithEvents TxtVolume As System.Windows.Forms.TextBox
    Friend WithEvents LblVolume As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
