Module Module1

    Sub Main()
        Dim str As String
        Dim char1 As String
        Dim char2 As String
        Dim nofchar1 As Integer
        Dim nofalpha As Integer
        Dim nofdigit As Integer
        Dim nofotherchar As Integer
        Dim consent As Char

        Console.Write("Enter a string: ")
        str = Console.ReadLine
        str = LCase(str)

        Console.Write("Which character do you want to search in this string: ")
        char1 = Console.ReadLine
        char1 = LCase(char1)
        char1 = Asc(char1)

        For i = 1 To Len(str)
            char2 = Mid(str, i, 1)
            char2 = Asc(char2)

            If char1 = char2 Then
                nofchar1 = nofchar1 + 1
            End If

            If char2 >= 65 And char2 <= 90 Or char2 >= 97 And char2 <= 122 Then
                nofalpha = nofalpha + 1
            ElseIf char2 >= 48 And char2 <= 57 Then
                nofdigit = nofdigit + 1
            Else
                nofotherchar = nofotherchar + 1
            End If

        Next
        char1 = Chr(char1)
        Console.Write("Number of " & char1 & "'s: " & nofchar1 & vbCrLf)
        Console.Write("Do you want the number of alphabets, digits and other characters" & vbCrLf)
        Console.Write("Press Y for Yes or any other key for No: ")
        consent = Console.ReadLine

        If consent = "Y" Or consent = "y" Then
            Console.Write("Number of Alphabets: " & nofalpha & vbCrLf)
            Console.Write("Number of Digits: " & nofdigit & vbCrLf)
            Console.Write("Number of other characters: " & nofotherchar & vbCrLf)
        End If
        Console.ReadKey()

    End Sub

End Module
