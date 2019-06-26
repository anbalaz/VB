Module Module1

    Sub Main()
        Console.Write("Number: ")
        Dim number As Integer = Integer.Parse(Console.ReadLine())

        For divider = 2 To Math.Sqrt(number)
            If number Mod divider = 0 Then
                Console.WriteLine(divider)

                If (number / divider <> Math.Sqrt(number)) Then
                    Console.WriteLine(number / divider)
                End If
            End If
        Next

        Console.ReadKey()
    End Sub

End Module
