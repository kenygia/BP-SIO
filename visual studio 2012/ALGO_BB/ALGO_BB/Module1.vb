Module Module1

    Sub Main()
        Dim var1, var2, var3 As Integer
        Console.WriteLine("3 nombre")
        var1 = Console.ReadLine()
        var2 = Console.ReadLine()
        var3 = Console.ReadLine()

        If var1 = var2 And var2 = var3 Then
            Console.WriteLine("3")
        ElseIf var1 = var2 Or var2 = var3 Or var1 = var3 Then
            Console.WriteLine("2")
        ElseIf var1 <> var2 And var2 <> var3 And var3 <> var2 Then
            Console.WriteLine("0")
        End If
        Console.Read()

    End Sub

End Module
