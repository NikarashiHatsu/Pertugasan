Public Class Form1

    Private Function HitungLuas(ByVal Panjang As Single, ByVal Lebar As Single) As Single
        Dim Luas As Single
        Luas = Panjang * Lebar
        Return Luas
    End Function

    Private Function HitungKeliling(ByVal Panjang As Single, ByVal Lebar As Single) As Single
        Dim Keliling As Single
        Keliling = 2 * (Panjang + Lebar)
        Return Keliling
    End Function

    Private Sub BtnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHitung.Click
        TxtKeliling.Text = HitungKeliling(
            CDec(TxtPanjang.Text),
            CDec(TxtLebar.Text)
        )

        TxtLuas.Text = HitungLuas(
            CDec(TxtPanjang.Text),
            CDec(TxtLebar.Text)
        )
    End Sub
End Class
