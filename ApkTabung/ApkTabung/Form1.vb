Public Class Form1

    Private Function HitungLuasPermukaan(ByVal JariJari As Single, ByVal Tinggi As Single) As Single
        Dim LuasAlas As Single
        Dim KelilingAlas As Single
        Dim LuasPermukaan As Single

        LuasAlas = Math.PI * Math.Pow(JariJari, 2)
        KelilingAlas = 2 * Math.PI * JariJari
        LuasPermukaan = (2 * LuasAlas) + (KelilingAlas * Tinggi)

        Return LuasPermukaan
    End Function

    Private Function HitungVolume(ByVal JariJari As Single, ByVal Tinggi As Single) As Single
        Dim Volume As Single
        Volume = Math.PI * Math.Pow(JariJari, 2) * Tinggi
        Return Volume
    End Function

    Private Sub BtnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHitung.Click
        TxtLuasPermukaan.Text = HitungLuasPermukaan(
            CDec(TxtJariJari.Text),
            CDec(TxtTinggi.Text)
        )

        TxtVolume.Text = HitungVolume(
            CDec(TxtJariJari.Text),
            CDec(TxtTinggi.Text)
        )
    End Sub
End Class
