Imports System

Module Program
    Sub Main(args As String())
        Dim cislo As Integer
        Dim faktorial As Integer = 1

        Console.Write("Zadej cel� ��slo: ")
        If Integer.TryParse(Console.ReadLine, cislo) Then
            If cislo < 13 Then
                For i = 1 To cislo
                    faktorial = faktorial * i
                Next i
                Console.WriteLine($"Faktori�1 ��sla {cislo} je {faktorial}")
            Else
                Console.WriteLine("Faktori�l ��sel 13 a v�ce je v�t��, ne� nejv�t�� ��slo, kter� spad� do cel�ch ��sel.")
            End If
        Else
            Console.WriteLine("Zadejte cel� ��slo.")
        End If

    End Sub
End Module
