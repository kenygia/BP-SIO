Module Module1

    Sub Main()
        Dim HTT As Single
        Dim TTC As Single
        Console.WriteLine("Quel est le Prix Hors Taxe ?")
        HTT = Console.ReadLine()
        TTC = HTT + (HTT * (19.6 / 100))
        Console.WriteLine(HTT & " + 19.6% TVA = " & TTC)
        Console.Read()

    End Sub

End Module
