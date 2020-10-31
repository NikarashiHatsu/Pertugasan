Public Class ClassSegitiga

    'Properties
    Private _sisiA As Integer
    Private _sisiB As Integer
    Private _sisiC As Integer
    Private _alas As Integer
    Private _tinggi As Integer
    Private _keliling As Single
    Private _luas As Single

    'Getter and setter Sisi A
    Public Property SisiA() As Integer
        Get
            Return _sisiA
        End Get
        Set(ByVal value As Integer)
            _sisiA = value
        End Set
    End Property

    'Getter and setter Sisi B
    Public Property SisiB() As Integer
        Get
            Return _sisiB
        End Get
        Set(ByVal value As Integer)
            _sisiB = value
        End Set
    End Property

    'Getter and setter Sisi C
    Public Property SisiC() As Integer
        Get
            Return _sisiC
        End Get
        Set(ByVal value As Integer)
            _sisiC = value
        End Set
    End Property

    'Getter and setter Alas
    Public Property Alas() As Integer
        Get
            Return _alas
        End Get
        Set(ByVal value As Integer)
            _alas = value
        End Set
    End Property

    'Getter and setter Tinggi
    Public Property Tinggi() As Integer
        Get
            Return _tinggi
        End Get
        Set(ByVal value As Integer)
            _tinggi = value
        End Set
    End Property

    'Set keliling
    Public Function Keliling() As Single
        Return _sisiA + _sisiB + _sisiC
    End Function

    'Set luas
    Public Function Luas() As Single
        Return (1 / 2) * _alas * _tinggi
    End Function

End Class
