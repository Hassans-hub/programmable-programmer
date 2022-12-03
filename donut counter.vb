Module Module1

    Sub Main()
        Dim donuts As Integer
        Dim stp As Integer

        Do While stp <> 1

            Console.Write("Enter number of donuts: ")
            donuts = Console.ReadLine


            If donuts < 10 Then
                Console.Write("Number of Donuts: " & donuts & vbCrLf)
            ElseIf donuts >= 100 Then
                Console.Write("Thats alot of donuts man" & vbCrLf)
            Else
                Console.Write("Number of Donuts: many" & vbCrLf)
            End If


            Console.Write("Enter 1 to stop counting donuts, any other number to count more" & vbCrLf)
            stp = Console.ReadLine

        Loop




    End Sub

End Module
