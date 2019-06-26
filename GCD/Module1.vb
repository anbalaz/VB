Module Module1

    Sub Main()
        Console.Write("A: ")
        Dim A As Integer = Integer.Parse(Console.ReadLine())

        Console.Write("B: ")
        Dim B As Integer = Integer.Parse(Console.ReadLine())

        If (Math.Max(A, B) Mod Math.Min(A, B) = 0) Then
            Console.WriteLine(Math.Min(A, B))

        Else
            For divider = Math.Min(A, B) \ 2 To 2 Step -1
                If A Mod divider = 0 AndAlso B Mod divider = 0 Then
                    Console.WriteLine(divider)
                    Exit For
                End If
            Next

        End If

        Console.ReadKey()
    End Sub

End Module
