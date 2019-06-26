Public Class Parrot : Inherits Animal

    Public Sub New(name As String)
        Me.Name = name
    End Sub

    Public Overrides ReadOnly Property LegCount As Integer
        Get
            Return 2
        End Get
    End Property

    Public Overrides Function Reply() As String
        Return $"{Name} is a good boy!"
    End Function

    Public Overrides Function ToString() As String
        Return $"Parrot {Name}"
    End Function

End Class
