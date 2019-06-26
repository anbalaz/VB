Module Module1

    Const BOT_DEAFNESS_LEVEL = 0.68

    Sub Main()
        Dim r As Random = New Random(Environment.TickCount)
        Dim goodBye As Boolean = False
        Dim byeCounter As Integer = 0

        While Not goodBye
            Console.Write("Message: ")
            Dim message As String = Console.ReadLine()

            If message = "AHOJ" Then
                If byeCounter = 0 Then
                    goodBye = (r.NextDouble() > BOT_DEAFNESS_LEVEL)
                    If Not goodBye Then
                        byeCounter += 1
                    End If

                Else
                    byeCounter += 1
                    goodBye = (byeCounter = 3)

                End If

            Else
                byeCounter = 0

            End If

            If Not goodBye Then
                Dim reply As String
                If message = message.ToUpper() Then
                    If message.EndsWith("?") Then
                        reply = "NECHALA SOM TI ICH NA STOLE!"
                    Else
                        reply = $"NIE, NAPOSLEDY V ROKU {r.Next(1900, 2000)}!"
                    End If

                Else
                    reply = "ČO?! HOVOR HLASNEJŠIE!"

                End If

                Console.WriteLine($"Bot: {reply}")
            End If
        End While

        Console.WriteLine("Chat ended.")
        Console.ReadLine()
    End Sub

End Module
