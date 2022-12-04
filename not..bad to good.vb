Module Module1

    Sub Main()
        Dim str As String
        Dim notnum As Integer
        Dim badnum As Integer
        Dim char1 As Char
        Dim newstr As String


        Console.Write("Enter a string: ")
        str = Console.ReadLine

        notnum = InStr(str, "not")
        badnum = InStr(str, "bad")

        If notnum > 0 And badnum > 0 And notnum < badnum Then

            For i = 1 To notnum - 1
                char1 = Mid(str, i, 1)
                newstr = newstr & char1
            Next

            newstr = newstr & "good"
            Console.Write(newstr)
            Console.ReadKey()

        Else

            Console.Write(str)
            Console.ReadKey()

        End If




    End Sub

End Module
