Module Module1

    Sub Main()

        Try
            Dim div1, div2, div3, div4 As Single
            Dim casea As String
            Console.WriteLine("saisir 1st nbr")
            div1 = Console.ReadLine()
            Console.WriteLine("saisir 2st nbr")
            div2 = Console.ReadLine()
            div3 = div1 \ div2
            div4 = div1 Mod div2
            Console.WriteLine("saisir d pour mod ou r for entier")
            casea = Console.ReadLine()
            If casea = "r" Then
                Console.WriteLine(" rest " & div1 & "/" & div2 & " egale " & div4)

            Else
            End If
            If casea = "d" Then
                Console.WriteLine(" entier" & div1 & "/" & div2 & " egale " & div3)


            End If
          

            Console.Read()
        Catch ex As Exception

        End Try
    End Sub

End Module
