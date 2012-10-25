Module ModuleCalcDuree

    Sub Main()
        Dim duree As Integer
        Dim nbhour As Integer
        Dim nbmin As Integer
        Dim nbsec As Integer
        Dim reste As Integer


        Console.WriteLine("Entrer une durée en seconde ?")
        duree = Console.ReadLine()
        nbhour = duree \ 3600
        reste = duree Mod 3600
        nbmin = reste \ 60
        nbsec = reste Mod 60
        Console.WriteLine("La durée est " & nbhour & " Heure " & nbmin & " Minute " & nbsec & " Seconde.")
        Console.Read()
    End Sub

End Module
