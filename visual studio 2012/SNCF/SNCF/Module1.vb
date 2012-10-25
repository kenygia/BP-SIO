Module Module1

    Sub Main()
        Try


            Dim en As Integer


            Console.WriteLine("nombre enfants")
            en = Console.ReadLine()
            If en = 2 Then
                Console.WriteLine("reduc 10%")
            ElseIf en = 3 Then
                Console.WriteLine("reduc 15%")
            ElseIf en = 4 Then
                Console.WriteLine("reduc 18%")
            ElseIf en > 4 Then
                Console.WriteLine("reduc 25%")

            End If

            Console.Read()

        Catch ex As Exception

        End Try

    End Sub

End Module
