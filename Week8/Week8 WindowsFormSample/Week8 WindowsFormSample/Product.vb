Public Class Product
    Private _id, _name As String
    Private _item As Integer
    Private _price As Double

    Public Sub New()
        _id = "P-000"
        _name = "XXX"
        _item = 999
        _price = 999
    End Sub

    Public Sub New(id As String, name As String, item As Integer, price As Double)
        _id = id
        _name = name
        _item = item
        _price = price
    End Sub

    Public Property ID As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property item As Integer
        Get
            Return _item
        End Get
        Set(value As Integer)
            _item = value
        End Set
    End Property

    Public Property Price As Double
        Get
            Return _price
        End Get
        Set(value As Double)
            _price = value
        End Set
    End Property

    '----------------------------------------------------------------------------------------'
    '----------------------------------------------------------------------------------------'
    '----------------------------------------------------------------------------------------'
    Public Function CheckItem() As Boolean
        If _item <= 0 Then
            Return True
        End If
        Return False
        'return _item <=0 ได้เหมือนกัน'

    End Function

    Public Function checkPrice() As Boolean
        Return _price <= 0
    End Function

    Public Function calculate() As Double
        Return _item * _price
    End Function


End Class
