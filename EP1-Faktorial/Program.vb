Imports System

Module Program
    Sub Main(args As String())

        Console.Write("Zadej celé èíslo: ")
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
                        Console.WriteLine($"Faktoriá1 èísla {cislo} je {faktorial}")
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
    End Sub

End Module
