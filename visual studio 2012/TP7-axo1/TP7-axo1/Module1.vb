Module Module1

    Sub Main()
        Dim n, i, c As Integer
        n = Console.ReadLine()
        For i = 1 To n
            For c = 1 To i
                Console.Write("*")
            Next
            Console.WriteLine("")
        Next
        Console.Read()
    End Sub

End Module
