Public Class Form1
    'Pemrograman tidak terstruktur

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Deklarasi variabel
        Dim Panjang As Single
        Dim Lebar As Single
        Dim Tinggi As Single
        Dim LuasKeliling As Single
        Dim Volume As Single

        'Konversi ke desimal
        Panjang = CDec(TxtPanjang.Text)
        Lebar = CDec(TxtLebar.Text)
        Tinggi = CDec(TxtTinggi.Text)

        'Hitung
        LuasKeliling = 2 * ((Panjang * Lebar) + (Lebar * Tinggi) + (Tinggi * Panjang))
        Volume = Panjang * Lebar * Tinggi

        'Tampilkan ke Textbox
        TxtLuasPermukaan.Text = LuasKeliling
        TxtVolume.Text = Volume

    End Sub
End Class
