Imports System

Module Program
    Sub Main(args As String())
        Dim Vysledek As Integer
        Dim vstup As Integer
        Do
            Console.Write("Zadej cel� ��slo: ")
            If Integer.TryParse(Console.ReadLine, vstup) Then
                If vstup < 13 Then
                    If vstup > -1 Then
                        Vysledek = FaktorialVypocet(vstup)
                    Else
                        Console.WriteLine("Faktori�l z�porn�ho ��sla nelze vypo��tat.")
                    End If
                Else
                    Console.WriteLine("Faktori�l ��sel 13 a v�ce je v�t��, ne� nejv�t�� ��slo, kter� spad� do cel�ch ��sel.")
                End If

                Console.WriteLine($"Faktori�1 zadan�ho ��sla je {Vysledek}")
                    Else
                        Console.WriteLine("Zadejte cel� ��slo.")
            End If
        Loop
    End Sub
    Function FaktorialVypocet(cislo As Integer)



        Dim faktorial As Integer = 1



        For i = 1 To cislo
            faktorial = faktorial * i
        Next





        Return faktorial
    End Function

End Module
