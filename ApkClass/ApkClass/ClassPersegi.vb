Public Class ClassPersegi

    'Properties
    Private _panjang As Integer
    Private _lebar As Integer
    Private _keliling As Integer
    Private _luas As Integer

    'Getter and setter Panjang
    Public Property Panjang() As Integer
        Get
            Return _panjang
        End Get
        Set(ByVal value As Integer)
            _panjang = value
        End Set
    End Property

    'Getter and setter Lebar
    Public Property Lebar() As Integer
        Get
            Return _lebar
        End Get
        Set(ByVal value As Integer)
            _lebar = value
        End Set
    End Property

    'Get luas
    Public Function Luas() As Integer
        _luas = _panjang * _lebar
        Return _luas
    End Function

    'Get keliling
    Public Function Keliling() As Integer
        _keliling = 2 * (_panjang + _lebar)
        Return _keliling
    End Function

End Class
