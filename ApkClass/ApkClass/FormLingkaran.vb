Public Class FormLingkaran
    Private Lin As New ClassLingkaran

    Private Sub BtnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHitung.Click
        Lin.Radius = CDec(TxtRadius.Text)

        TxtKeliling.Text = Lin.Keliling
        TxtLuas.Text = Lin.Luas
    End Sub
End Class