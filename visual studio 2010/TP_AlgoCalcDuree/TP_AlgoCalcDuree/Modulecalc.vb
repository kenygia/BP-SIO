Module Modulecalc

    Sub Main()
        Dim sth, stm, sts As Integer
        Dim fih, fim, fis As Integer

        Console.WriteLine(" Quel Heure de Debut...")
        sth = Console.ReadLine()
        Console.WriteLine("Minute...")
        stm = Console.ReadLine()
        Console.WriteLine("Seconde ?")
        sts = Console.ReadLine()
        Console.WriteLine(".")

        Console.WriteLine(sth & "H " & stm & "M " & sts & "s")
        Console.Read()
    End Sub

End Module
