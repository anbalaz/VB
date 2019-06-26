Public MustInherit Class Animal : Implements IComparable(Of Animal)

    Public Property Name As String

    Public MustOverride ReadOnly Property LegCount As Integer

    Public MustOverride Function Reply() As String

    Public Property TimeAdded As DateTime

    Public Function CompareTo(other As Animal) As Integer Implements IComparable(Of Animal).CompareTo
        Return LegCount.CompareTo(other.LegCount)
    End Function

End Class
