Public Class Snake : Inherits Animal

    Public Sub New(name As String)
        Me.Name = name
    End Sub

    Public Overrides ReadOnly Property LegCount As Integer
        Get
            Return 0
        End Get
    End Property

    Public Overrides Function Reply() As String
        Return $"Hisss!"
    End Function

    Public Overrides Function ToString() As String
        Return $"Snake {Name}"
    End Function

End Class
