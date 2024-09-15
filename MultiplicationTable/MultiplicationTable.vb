'Justin Bell
'RCET0265
'Fall 2024
'Multiplication Table
' link

Option Compare Text
Option Explicit On
Option Strict On

Module MultiplicationTable

    Sub Main()
        Dim userInput As String
        Dim size As Integer

        Console.WriteLine("Enter multiplication table size")
        Console.WriteLine("Press ""Q"" to quit.")

        'reads input and ensures input is an integer

        Do
            userInput = (Console.ReadLine())
            If userInput = "q" Then
                Exit Do
            End If

            Try
                size = CInt(userInput)
                Exit Do
            Catch ex As Exception
                Console.WriteLine("Please enter a whole number.")
            End Try

        Loop

        'cleans up the terminal for better usability

        Console.Clear()
        Console.WriteLine($"You have selected a table size of: {userInput}x{userInput}")
        Console.WriteLine()

        'creates the table based off of the size indicated by the user

        For i As Integer = 1 To size
            For j As Integer = 1 To size
                Console.Write((i * j).ToString().PadLeft(2) & " | ")
            Next
            Console.WriteLine()
            Console.WriteLine(StrDup(5 * size, "_"))

        Next

        Console.WriteLine()
        Console.WriteLine("Press enter to close window.")
        Console.ReadLine()

    End Sub

End Module