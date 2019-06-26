Module Module1

    Sub Main()
        Console.Write("Word 1: ")
        Dim word1 As String = Console.ReadLine()

        Console.Write("Word 2: ")
        Dim word2 As String = Console.ReadLine()

        If word1.OrderBy(Function(c) c).
                 Except(word2.OrderBy(Function(c) c)).
                 Any() Then
            Console.WriteLine("Words are not anagrams.")

        Else
            Console.WriteLine("Words are anagrams.")

        End If

        Console.ReadKey()
    End Sub

End Module
