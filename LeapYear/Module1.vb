Module Module1

    Sub Main()
        Console.Write("Start year: ")
        Dim startYear As Integer = Integer.Parse(Console.ReadLine())

        Console.Write("End year: ")
        Dim endYear As Integer = Integer.Parse(Console.ReadLine())

        Console.WriteLine()
        Console.WriteLine("Leap years:")
        For y = startYear To endYear
            If y Mod 4 = 0 AndAlso (y Mod 100 <> 0 OrElse y Mod 400 = 0) Then
                Console.WriteLine(y)
            End If
        Next

        Console.Read()
    End Sub

End Module