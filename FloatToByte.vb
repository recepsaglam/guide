Public Class FloatToByte
    Private _value As Single = 0F

    Public Property Value As Single
        Get
            Return _value
        End Get
        Set(ByVal value As Single)
            value = _value
        End Set
    End Property

    Public ReadOnly Property ByteValues As Byte()
        Get
            Return BitConverter.GetBytes(_value)
        End Get
    End Property

    Public Sub New(ByVal value As Single)
        _value = value
    End Sub
End Class
