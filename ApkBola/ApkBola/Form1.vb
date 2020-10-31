Public Class Form1

    Private Function HitungLuasPermukaan(ByVal Radius As Single) As Single
        Dim LuasPermukaan As Single
        LuasPermukaan = 4 * Math.PI * Math.Pow(Radius, 2)
        Return LuasPermukaan
    End Function

    Private Function HitungVolume(ByVal Radius As Single) As Single
        Dim Volume As Single
        Volume = (4 / 3) * Math.PI * Math.Pow(Radius, 3)
        Return Volume
    End Function

    Private Sub BtnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHitung.Click
        TxtLuasPermukaan.Text = HitungLuasPermukaan(CDec(TxtRadius.Text))
        TxtVolume.Text = HitungVolume(CDec(TxtRadius.Text))
    End Sub
End Class
