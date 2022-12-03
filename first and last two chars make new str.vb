Module Module1

    Sub Main()
        Dim s As String
        Dim newstr As String
        Dim leftside As String
        Dim rightside As String

        Console.Write("Enter a string: ")
        s = Console.ReadLine
        If Len(s) <= 2 Then
            Console.Write("Your string length was too short" & vbCrLf & s)
            Console.ReadKey()
        Else
            leftside = Left(s, 2)
            rightside = Right(s, 2)
            newstr = leftside & rightside
            Console.Write("Your new string is: " & newstr)
            Console.ReadKey()

        End If
    End Sub

End Module
