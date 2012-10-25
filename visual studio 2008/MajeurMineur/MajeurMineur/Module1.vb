Module Module1

    Sub Main()
        Try

            Dim years, age As Integer

            Console.WriteLine("Veuillez sasir votre année de naissance.")
            years = Console.ReadLine()
            age = 2012 - years
            If age > 17 Then
                Console.Write("Majeur")
                Console.Read()

            Else
                Console.WriteLine("Mineur")
                Console.ReadLine()
            End If

        Catch ex As Exception

        End Try
    End Sub

End Module
