Module Module1

    Sub Main()
        Try
            Dim Cal As String
            Dim day, mo, ye, bis As Integer

            Console.WriteLine("saissez date dans l'ordre : jj/mm/aaaa ")
            day = Console.ReadLine()
            mo = Console.ReadLine()
            ye = Console.ReadLine()

            If ye Mod 4 = 0 Then
                bis = 1 'bis'

            Else
                bis = 0 'nobis'
            End If

                Select Case mo

                    Case 1, 3, 5, 7, 8, 10, 12

                        If day < 31 Then
                            day = day + 1
                        Else
                        day = 1
                        mo = mo + 1
                        End If

                    Case 4, 6, 9, 11
                        If day < 30 Then
                            day = day + 1
                        Else
                        day = 1
                        mo = mo + 1
                        End If

                    Case 2
                    If day < (28 + bis) Then
                        day = day + 1
                    Else
                        day = 1
                        mo = mo + 1
                    End If

            End Select
            If mo = 13 Then
                mo = 1
                ye = ye + 1
            End If

                Cal = day & "/" & mo & "/" & ye

                Console.WriteLine("Demain : " & Cal)

                Console.Read()
        Catch ex As Exception

        End Try


    End Sub

End Module
