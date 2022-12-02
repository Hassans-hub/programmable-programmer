Module Module1

    Sub Main()
        Dim str As String
        Dim char1 As String
        Dim newstr As String
        Dim pos As Integer

        Console.Write("Enter a string: ")
        str = Console.ReadLine
        Console.Write("Enter the position of the character you wish to replace: ")
        pos = Console.ReadLine

        If pos > Len(str) Then
            Console.Write("You entered an invalid positon that doesnt exist")
        End If

        Console.Write("Which character you want to replace it with: ")
        char1 = Console.ReadLine

        For i = 1 To Len(str)
            If i <> pos Then
                newstr = newstr & Mid(str, i, 1)
            Else
                newstr = newstr & char1
            End If
        Next

        Console.Write("Your modified string: " & newstr)
        Console.ReadKey()

    End Sub

End Module
