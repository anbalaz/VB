Module Module1

    Const SECONDS_IN_YEAR As Long = 31557600

    Const MERCURY_YEAR As Double = 0.2408467
    Const VENUS_YEAR As Double = 0.61519726
    Const MARS_YEAR As Double = 1.8808158
    Const JUPITER_YEAR As Double = 11.862615
    Const SATURN_YEAR As Double = 29.447498
    Const URANUS_YEAR As Double = 84.016846
    Const NEPTUNE_YEAR As Double = 164.79132

    Sub Main()
        Console.Write("Day of birth: ")
        Dim day As Integer = Integer.Parse(Console.ReadLine())

        Console.Write("Month of birth: ")
        Dim month As Integer = Integer.Parse(Console.ReadLine())

        Console.Write("Year of birth: ")
        Dim year As Integer = Integer.Parse(Console.ReadLine())

        Dim birthDate As Date = New Date(year, month, day)
        Dim seconds As Double = (Date.Now - birthDate).TotalSeconds
        Dim earthYears As Double = seconds / SECONDS_IN_YEAR

        Console.WriteLine()

        Console.WriteLine($"You have {earthYears / MERCURY_YEAR:0.00} years on Mercury.")
        Console.WriteLine($"You have {earthYears / VENUS_YEAR:0.00} years on Venus.")
        Console.WriteLine($"You have {earthYears:0.00} years on Earth.")
        Console.WriteLine($"You have {earthYears / MARS_YEAR:0.00} years on Mars.")
        Console.WriteLine($"You have {earthYears / JUPITER_YEAR:0.00} years on Jupiter.")
        Console.WriteLine($"You have {earthYears / SATURN_YEAR:0.00} years on Saturn.")
        Console.WriteLine($"You have {earthYears / URANUS_YEAR:0.00} years on Uranus.")
        Console.WriteLine($"You have {earthYears / NEPTUNE_YEAR:0.00} years on Neptune.")

        Console.ReadKey()
    End Sub

End Module
