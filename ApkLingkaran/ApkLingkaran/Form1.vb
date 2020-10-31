Public Class Form1

    Private Function HitungKeliling(ByVal JariJari As Single) As Single
        Dim Keliling As Single
        Keliling = 2 * Math.PI * JariJari
        Return Keliling
    End Function

    Private Function HitungLuas(ByVal JariJari As Single) As Single
        Dim Luas As Single
        Luas = Math.PI * Math.Pow(JariJari, 2)
        Return Luas
    End Function

    Private Sub BtnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHitung.Click
        TxtKeliling.Text = HitungKeliling(CDec(TxtJariJari.Text))
        TxtLuas.Text = HitungLuas(CDec(TxtJariJari.Text))
    End Sub
End Class
