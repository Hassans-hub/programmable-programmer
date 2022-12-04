Module Module1

    Sub Main()
        Dim a As String
        Dim b As String
        Dim newstra As String
        Dim newstrb As String
        Dim newstr As String
        Dim chara As Char
        Dim charb As Char
        Dim char1a As String
        Dim char2a As String
        Dim char1b As String
        Dim char2b As String

        Console.Write("Enter the first string: ")
        a = Console.ReadLine
        Console.Write("Enter the second string: ")
        b = Console.ReadLine

        char1a = Mid(a, 1, 1)
        char2a = Mid(a, Len(a), 1)
        char2b = Mid(b, Len(b), 1)
        char1b = Mid(b, 1, 1)

        For i = 2 To (Len(a) - 1)
            chara = Mid(a, i, 1)
            newstra = newstra & chara
        Next


        For i = 2 To (Len(b) - 1)
            charb = Mid(b, i, 1)
            newstrb = newstrb & charb
        Next

        newstra = char2a & newstra & char1a
        newstrb = char2b & newstrb & char1b
        newstr = newstra & " " & newstrb

        Console.Write("The new string is: " & newstr)

        Console.ReadKey()
    End Sub

End Module
