Module Module1

    Sub Main()

        Try
            Dim fact, remi As Single
            remi = 5%
            Console.WriteLine(" entrer le montant de facture")
            fact = Console.ReadLine()
            If fact < 500 Then
                Console.WriteLine("Votre facture n'a pas besoin de remise elle reste donc a : " & fact)
            Else
            End If
            If fact > 500 Then
                fact = fact - remi
                Console.WriteLine("facture+remise : " & fact)
            End If
            Console.Read()
        Catch ex As Exception

        End Try


    End Sub

End Module
