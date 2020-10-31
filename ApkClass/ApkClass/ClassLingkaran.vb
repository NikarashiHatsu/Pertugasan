Public Class ClassLingkaran

    'Properties
    Private _radius As Single
    Private _keliling As Single
    Private _luas As Single

    'Getter and setter Radius
    Public Property Radius() As Single
        Get
            Return _radius
        End Get
        Set(ByVal value As Single)
            _radius = value
        End Set
    End Property

    'Hitung keliling Lingkaran
    Public Function Keliling() As Single
        _keliling = 2 * Math.PI * _radius
        Return _keliling
    End Function

    'Hitung luas lingkaran
    Public Function Luas() As Single
        _luas = Math.PI * Math.Pow(_radius, 2)
        Return _luas
    End Function

End Class
