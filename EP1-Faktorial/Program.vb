Imports System

Module Program
    Sub Main(args As String())

        Console.Write("Zadej cel� ��slo: ")
        Faktorial()
    End Sub
    Sub Faktorial()
        Dim cislo As Integer

        Do
            Dim faktorial As Integer = 1

            If Integer.TryParse(Console.ReadLine, cislo) Then
                If cislo < 13 Then
                    If cislo > -1 Then
                        For i = 1 To cislo
                            faktorial = faktorial * i
                        Next i
                        Console.WriteLine($"Faktori�1 ��sla {cislo} je {faktorial}")
                    Else
                        Console.WriteLine("Faktori�l z�porn�ho ��sla nelze vypo��tat.")
                    End If
                Else
                    Console.WriteLine("Faktori�l ��sel 13 a v�ce je v�t��, ne� nejv�t�� ��slo, kter� spad� do cel�ch ��sel.")
                End If
            Else
                Console.WriteLine("Zadejte cel� ��slo.")
            End If
        Loop
    End Sub

End Module
