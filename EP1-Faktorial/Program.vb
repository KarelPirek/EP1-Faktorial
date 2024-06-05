Imports System

Module Program
    Sub Main(args As String())

        Console.Write("Zadej celé èíslo: ")
        Dim Vysledek As Integer
        Vysledek = FaktorialVypocet()
        Console.WriteLine($"Faktoriá1 zadaného èísla je {Vysledek}")
    End Sub
    Function FaktorialVypocet(cislo As Integer)


        Do
            Dim faktorial As Integer = 1

            If Integer.TryParse(Console.ReadLine, cislo) Then
                If cislo < 13 Then
                    If cislo > -1 Then
                        For i = 1 To cislo
                            faktorial = faktorial * i
                        Next i

                    Else
                        Console.WriteLine("Faktoriál záporného èísla nelze vypoèítat.")
                    End If
                Else
                    Console.WriteLine("Faktoriál èísel 13 a více je vìtší, než nejvìtší èíslo, které spadá do celých èísel.")
                End If
            Else
                Console.WriteLine("Zadejte celé èíslo.")
            End If
        Loop
        Return 0
    End Function

End Module
