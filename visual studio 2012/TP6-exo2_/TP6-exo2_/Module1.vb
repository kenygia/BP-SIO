Module Module1

    Sub Main()

        Dim nom, avis As String
        Dim moye, c As Integer
        For c = 1 To 10
        
            Console.Write("nom")
            nom = Console.ReadLine()
            Console.Write("moy")
            moye = Console.ReadLine()
            Select Case moye
                Case 0 To 5
                    avis = "des"
                Case 6, 7
                    avis = "t inu"
                Case 8, 9
                    avis = "inu"
                Case 10, 11
                    avis = "moy"
                Case 12, 13
                    avis = "as"
                Case 14 To 16
                    avis = "b"
                Case 17 To 20
                    avis = "tb"
            End Select

        Next
        Console.WriteLine("nom=" & nom & "moy=" & moye & "avis=" & avis)
        Console.Read()


    End Sub

End Module
