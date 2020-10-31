Public Class Form1
    Private Nilai As New PerhitunganNilai

    Private Sub BtnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProses.Click
        Nilai.NilaiKehadiran = CDec(TxtNilaiKehadiran.Text)
        Nilai.NilaiTugas = CDec(TxtNilaiTugas.Text)
        Nilai.NilaiUTS = CDec(TxtNilaiUTS.Text)
        Nilai.NilaiUAS = CDec(TxtNilaiUAS.Text)

        TxtNilaiAkhir.Text = Nilai.HitungNilaiAkhir
        TxtKeterangan.Text = Nilai.HitungKeterangan
        TxtNilaiMutu.Text = Nilai.HitungNilaiMutu
    End Sub
End Class
