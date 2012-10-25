Module Module1

    Sub Main()
        Dim nombre As Integer
        Console.WriteLine("+ non nul")
        nombre = Console.ReadLine()
        While nombre <> 1
            If nombre Mod 2 = 0 Then
                nombre = nombre / 2

            Else

                nombre = 3 * nombre + 1
            End If
            Console.WriteLine(nombre)
        End While


        Console.Read()
    End Sub

End Module
