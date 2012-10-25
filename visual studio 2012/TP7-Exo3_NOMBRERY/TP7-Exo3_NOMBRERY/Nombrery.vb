Module Nombrery

    Sub Main()
        Dim ns, np, c As Integer
        Randomize()
        ns = Int(Rnd() * 100 + 1)

        Do
            Console.WriteLine("Nombre ?")
            np = Console.ReadLine()
            If np < ns Then
                Console.WriteLine("Plus ")
                c = c + 1
            ElseIf np > ns Then
                Console.WriteLine("Moins")
                c = c + 1
            ElseIf np = ns Then
                Console.WriteLine("Bravo!")
            End If

        Loop Until c = 8 Or np = ns
        If c = 8 Then
            Console.WriteLine("Perdu")
        End If

        Console.Read()
    End Sub

End Module
