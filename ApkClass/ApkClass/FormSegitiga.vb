Public Class FormSegitiga
    Private Seg As New ClassSegitiga

    Private Sub BtnKeliling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeliling.Click
        Seg.SisiA = CDec(TxtPanjangA.Text)
        Seg.SisiB = CDec(TxtPanjangB.Text)
        Seg.SisiC = CDec(TxtPanjangC.Text)

        TxtKeliling.Text = Seg.Keliling
    End Sub

    Private Sub BtnLuas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLuas.Click
        Seg.Alas = CDec(TxtAlas.Text)
        Seg.Tinggi = CDec(TxtAlas.Text)

        TxtLuas.Text = Seg.Luas
    End Sub
End Class