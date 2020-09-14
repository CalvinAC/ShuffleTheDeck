'Calvin Coxen
'RCET0265
'Fall 2020
'Shuffle The Deck

Option Strict On
Option Explicit On


Module ShuffleTheDeck

    Sub Main()
        'CardsArray()
        DisplayArray()


    End Sub
    Sub CardsArray()
        Dim cardTable(13, 4) As String
        Dim row As Integer
        Dim column As Integer

        cardTable(1, 2) = "Bob"
        cardTable(1, 3) = "timmothy"
        cardTable(1, 1) = "jameison"

        For row = 1 To 13
            For column = 0 To 4
                Console.Write(cardTable(row, column) & vbTab)
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()

    End Sub

    Sub DisplayArray()
        Dim row As Integer = 12
        Dim column As Integer = 3
        Dim thisArray(row, column) As Double
        Dim formattedString As String

        thisArray(0, 1) = 6
        thisArray(1, 1) = 5
        thisArray(0, 0) = 4
        thisArray(0, 2) = 3




        For row = 0 To row - 1
            For column = 0 To column - 1
                formattedString = $"{row}, {column}"
                Console.Write(formattedString.PadRight(8))

                'Console.Write($"{row}, {column}")

                'Console.Write(thisArray(row, column) & vbTab)
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()

    End Sub
End Module
