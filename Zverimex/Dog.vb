Public Class Dog : Inherits Animal

    Public Sub New(name As String)
        Me.Name = name
    End Sub

    Public Overrides ReadOnly Property LegCount As Integer
        Get
            Return 4
        End Get
    End Property

    Public Overrides Function Reply() As String
        Return "Bark!"
    End Function

    Public Overrides Function ToString() As String
        Return $"Dog {Name}"
    End Function

End Class
