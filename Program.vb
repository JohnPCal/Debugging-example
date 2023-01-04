Imports System
Class ArrayExample
    Public Shared Sub Main()
        Dim letters As Char() = {"f"c, "r"c, "e"c, "d"c, " "c, "s"c, "m"c, "i"c, "t"c, "h"c}
        Dim name As String = ""
        Dim a As Integer() = New Integer(9) {}



        For i As Integer = 0 To letters.Length - 1
            name += letters(i)
            a(i) = i + 1
            SendMessage(name, a(i))

        Next

        Console.ReadKey()
    End Sub
    Private Shared Sub SendMessage(ByVal name As String, ByVal msg As Integer)

        Console.WriteLine("Hello, " & name & "! Count to " & msg)

    End Sub
End Class
