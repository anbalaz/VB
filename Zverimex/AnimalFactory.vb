Public NotInheritable Class AnimalFactory

    Private Sub New()

    End Sub

    Public Shared Function CreateAnimal(animalKind As String, name As String) As Animal
        Select Case animalKind
            Case "Dog"
                Return New Dog(name) With {.TimeAdded = DateTime.Now}

            Case "Parrot"
                Return New Parrot(name) With {.TimeAdded = DateTime.Now}

            Case "Snake"
                Return New Snake(name) With {.TimeAdded = DateTime.Now}

            Case Else
                Return Nothing

        End Select
    End Function

End Class
