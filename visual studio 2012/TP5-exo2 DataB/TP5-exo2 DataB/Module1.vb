Module Module1

    Sub Main()
        Try
            Dim code, d, q, a As Integer
            Dim pre, no, CodeServ As String

            Console.WriteLine("pre")
            no = Console.ReadLine()
            Console.WriteLine("no")
            pre = Console.ReadLine()
            Console.WriteLine("7")
            code = Console.ReadLine()
            d = code Mod 10
            q = code / 10
            a = q Mod 10
            Console.WriteLine(a & "nom : " & no & "  prenom : " & pre  CodServ)
            Console.Read()
        Catch ex As Exception

        End Try

    End Sub

End Module
