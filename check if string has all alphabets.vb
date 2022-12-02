Module Module1

    Sub Main()
        Dim str As String
        Dim Alpha As String
        Dim Flag1 As Boolean
        Dim chaar As String
        Dim char2 As String

        Flag1 = True
        Console.Write("Enter a sentence: ")
        str = Console.ReadLine

        Alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        str = UCase(str)

        For i = 1 To Len(Alpha)
            chaar = Mid(Alpha, i, 1)
            char2 = InStr(str, chaar)
            If char2 < 1 Then Flag1 = False
        Next
        If Flag1 = True Then
            Console.Write("Your string contains all alphabets")
        Else
            Console.Write("Your string does not contain all alphabets")
        End If
        Console.ReadKey()
    End Sub

End Module
