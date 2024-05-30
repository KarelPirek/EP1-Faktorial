Imports System

Module Program
    Sub Main(args As String())
        Dim cislo As Integer
        Dim faktorial As Integer = 1

        Console.Write("Zadej celé èíslo: ")
        If Integer.TryParse(Console.ReadLine, cislo) Then
            For i = 1 To cislo
                faktorial = faktorial * i
            Next i
            Console.WriteLine($"Faktoriá1 èísla {cislo} je {faktorial}")
        Else
            Console.WriteLine("Zadejte celé èíslo.")
        End If

    End Sub
End Module
