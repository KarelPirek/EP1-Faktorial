Imports System

Module Program
    Sub Main(args As String())
        Dim cislo As Integer
        Dim faktorial As Integer = 1

        Console.Write("Zadej cel� ��slo: ")
        If Integer.TryParse(Console.ReadLine, cislo) Then
            For i = 1 To cislo
                faktorial = faktorial * i
            Next i
            Console.WriteLine($"Faktori�1 ��sla {cislo} je {faktorial}")
        Else
            Console.WriteLine("Zadejte cel� ��slo.")
        End If

    End Sub
End Module
