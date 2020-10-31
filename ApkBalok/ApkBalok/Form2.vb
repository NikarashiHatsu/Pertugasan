Public Class Form2
    Private Function HitungLuasPermukaan(ByVal Panjang As Single, ByVal Lebar As Single, ByVal Tinggi As Single) As Single
        Dim LuasPermukaan As Single
        LuasPermukaan = 2 * ((Panjang * Lebar) + (Lebar * Tinggi) + (Tinggi * Panjang))
        Return LuasPermukaan
    End Function

    Private Function HitungVolume(ByVal Panjang As Single, ByVal Lebar As Single, ByVal Tinggi As Single) As Single
        Dim Volume As Single
        Volume = Panjang * Tinggi * Lebar
        Return Volume
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TxtLuasPermukaan.Text = HitungLuasPermukaan(
            CDec(TxtPanjang.Text),
            CDec(TxtLebar.Text),
            CDec(TxtTinggi.Text)
        )

        TxtVolume.Text = HitungVolume(
            CDec(TxtPanjang.Text),
            CDec(TxtLebar.Text),
            CDec(TxtTinggi.Text)
        )
    End Sub
End Class