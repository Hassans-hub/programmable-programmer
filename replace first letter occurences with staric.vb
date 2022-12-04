Module Module1

    Sub Main()
        Dim s As String
        Dim char1 As Char
        Dim char2 As Char
        Dim newstr As String

        Console.Write("Enter a string: ")
        s = Console.ReadLine

        s = UCase(s)
        char1 = Mid(s, 1, 1)
        newstr = newstr & char1

        For i = 2 To Len(s)
            char2 = Mid(s, i, 1)
            If char2 = char1 Then
                newstr = newstr & "*"
            Else
                newstr = newstr & char2
            End If
        Next

        Console.Write("Your new string is: " & newstr)

        Console.ReadKey()

    End Sub

End Module
