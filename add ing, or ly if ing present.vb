Module Module1

    Sub Main()
        Dim str As String
        Dim ing As String
        Dim char1 As Char
        Dim char2 As Char
        Dim c As Integer
        Dim flag As Boolean

        ing = "ing"
        Console.Write("Enter a string: ")
        str = Console.ReadLine

        If Len(str) <= 3 Then
            Console.Write("Your entered string should be at least 3 characters in length" & vbCrLf)
            Console.Write(str)
            Console.ReadKey()
        Else

            For i = (Len(str) - 2) To Len(str)
                c = c + 1
                char1 = Mid(str, i, 1)
                char2 = Mid(ing, c, 1)

                If char1 <> char2 Then
                    flag = False
                Else
                    flag = True
                End If

            Next

            If flag = False Then
                str = str & "ing"
            Else
                str = str & "ly"
            End If

            Console.Write("Your new string is: " & str)

            Console.ReadKey()

        End If

    End Sub

End Module
