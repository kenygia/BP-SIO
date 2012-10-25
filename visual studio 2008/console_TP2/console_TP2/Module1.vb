Imports System.Math
Module Module1

    Sub Main()
        Try
            Dim nombre, racine As Single

            Console.WriteLine("Veuillez sasir un nombre")
            nombre = Console.ReadLine()
            If nombre < 0 Then
                Console.Write("La racine carré de " & nombre & " ne peut être négatif")
                Console.Read()

            Else

                racine = Sqrt(nombre)

                Console.WriteLine("La racine carré du nombre " & nombre & " est " & racine)
                Console.ReadLine()
            End If
        Catch ex As Exception
            Console.Write(ex)
            Console.Read()

        End Try


    End Sub

End Module
