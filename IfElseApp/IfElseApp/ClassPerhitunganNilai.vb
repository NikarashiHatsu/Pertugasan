Public Class PerhitunganNilai

    'Properties
    Private _nilaiKehadiran As Single
    Private _nilaiTugas As Single
    Private _nilaiUTS As Single
    Private _nilaiUAS As Single
    Private _nilaiAkhir As Single
    Private _keterangan As String
    Private _nilaiMutu As String

    'Getter and setter _nilaiKehadiran
    Public Property NilaiKehadiran() As Single
        Get
            Return _nilaiKehadiran
        End Get
        Set(ByVal value As Single)
            _nilaiKehadiran = value
        End Set
    End Property

    'Getter and setter _nilaiTugas
    Public Property NilaiTugas() As Single
        Get
            Return _nilaiTugas
        End Get
        Set(ByVal value As Single)
            _nilaiTugas = value
        End Set
    End Property

    'Getter and setter _nilaiUTS
    Public Property NilaiUTS() As Single
        Get
            Return _nilaiUTS
        End Get
        Set(ByVal value As Single)
            _nilaiUTS = value
        End Set
    End Property

    'Getter and setter _nilaiUAS
    Public Property NilaiUAS() As Single
        Get
            Return _nilaiUAS
        End Get
        Set(ByVal value As Single)
            _nilaiUAS = value
        End Set
    End Property

    'Hitung nilai akhir
    Public Function HitungNilaiAkhir() As Single
        _nilaiAkhir = (_nilaiKehadiran * 0.1) + (_nilaiTugas * 0.2) + (_nilaiUTS * 0.3) + (_nilaiUAS * 0.4)
        Return _nilaiAkhir
    End Function

    'Hitung keterangan
    Public Function HitungKeterangan() As String
        If (_nilaiAkhir >= 60) Then
            _keterangan = "Lulus"
        Else
            _keterangan = "Gagal"
        End If

        Return _keterangan
    End Function

    'Hitung nilai mutu
    Public Function HitungNilaiMutu() As String
        If (_nilaiAkhir >= 85) Then
            _nilaiMutu = "A"
        ElseIf (_nilaiAkhir >= 75) Then
            _nilaiMutu = "B"
        ElseIf (_nilaiAkhir >= 55) Then
            _nilaiMutu = "C"
        ElseIf (_nilaiAkhir >= 40) Then
            _nilaiMutu = "D"
        Else
            _nilaiMutu = "E"
        End If

        Return _nilaiMutu
    End Function

End Class
