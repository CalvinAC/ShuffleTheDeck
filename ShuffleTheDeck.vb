'Calvin Coxen
'RCET0265
'Fall 2020
'Shuffle The Deck
'https://github.com/CalvinAC/ShuffleTheDeck

Option Strict On
Option Explicit On


Module ShuffleTheDeck

    Sub Main()
        Dim row As Integer = 12
        Dim column As Integer = 3

        Console.WriteLine("Press Enter to draw a card")
        RandomCard()



    End Sub



    Sub RandomCard()
        Dim row As Integer = 12
        Dim column As Integer = 3
        Dim randomRow As Integer
        Dim randomColumn As Integer
        Dim randomCard(row, column) As Boolean
        Dim formattedString As String

        Randomize()
        For i = 1 To 104
            randomRow = CInt(Int((13 * Rnd())))
            randomColumn = CInt(Int((4 * Rnd())))

            If Not randomCard(randomRow, randomColumn) Then
                randomCard(randomRow, randomColumn) = True
            Else
                Console.WriteLine($"Row {randomRow}, column {randomColumn}")
            End If
        Next

        Console.WriteLine(randomCard)
        Console.ReadLine()

        For i = 0 To row
            For j = 0 To column
                formattedString = $" {i},{j}"
                Console.Write(formattedString)
                If randomCard(i, j) Then
                    Console.WriteLine(" T ")
                Else
                    Console.WriteLine(" F ")
                End If

            Next
            Console.WriteLine()
        Next
        Console.Read()
    End Sub


End Module
