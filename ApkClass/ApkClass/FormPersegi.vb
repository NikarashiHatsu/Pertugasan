Public Class FormPersegi
    Private Per As New ClassPersegi

    Private Sub BtnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHitung.Click
        Per.Panjang = CDec(TxtPanjang.Text)
        Per.Lebar = CDec(TxtLebar.Text)

        TxtKeliling.Text = Per.Keliling
        TxtLuas.Text = Per.Luas
    End Sub
End Class
