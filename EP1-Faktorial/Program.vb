Imports System

Module Program
    Sub Main(args As String())
        Dim Vysledek As Integer
        Dim vstup As Integer
        Do
            Console.Write("Zadej celé èíslo: ")
            If Integer.TryParse(Console.ReadLine, vstup) Then
                If vstup < 13 Then
                    If vstup > -1 Then
                        Vysledek = FaktorialVypocet(vstup)
                    Else
                        Console.WriteLine("Faktoriál záporného èísla nelze vypoèítat.")
                    End If
                Else
                    Console.WriteLine("Faktoriál èísel 13 a více je vìtší, než nejvìtší èíslo, které spadá do celých èísel.")
                End If

                Console.WriteLine($"Faktoriá1 zadaného èísla je {Vysledek}")
                    Else
                        Console.WriteLine("Zadejte celé èíslo.")
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
