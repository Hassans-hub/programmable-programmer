Module Module1

    Sub Main()
        Dim str As String
        Dim vowels As String
        Dim char1 As Char
        Dim nofA As Integer
        Dim nofE As Integer
        Dim nofI As Integer
        Dim nofO As Integer
        Dim nofU As Integer

        vowels = "AEIOU"

        Console.Write("Enter a sentence to check: ")
        str = Console.ReadLine

        str = UCase(str)

        For i = 1 To Len(str)
            char1 = Mid(str, i, 1)
            If char1 = "A" Then
                nofA = nofA + 1
            ElseIf char1 = "E" Then
                nofE = nofE + 1
            ElseIf char1 = "I" Then
                nofI = nofI + 1
            ElseIf char1 = "O" Then
                nofO = nofO + 1
            ElseIf char1 = "U" Then
                nofU = nofU + 1
            End If
        Next

        Console.Write("Number of A: " & nofA & vbCrLf & "Number of E: " & nofE & vbCrLf)
        Console.Write("Number of I: " & nofI & vbCrLf & "Number of O: " & nofO & vbCrLf)
        Console.Write("Number of U: " & nofU)

        Console.ReadKey()

    End Sub

End Module
