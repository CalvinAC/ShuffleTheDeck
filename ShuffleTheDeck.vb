﻿'Calvin Coxen
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
        Dim randomCard(row, column) As Boolean
        Dim randomColumn As Integer
        Dim randomRow As Integer
        Dim goodData As Boolean
        Dim suite As String
        Dim cardNumber As String
        Dim cardValue As String
        Dim cardsDealt As Integer
        Randomize()


        Console.WriteLine("Press Enter to draw a card, or Q to quit. ")


        Do
            'Counts the amount of cards that have been dealt
            cardsDealt += 1
            Console.WriteLine(StrDup(4, vbTab) & "Cards Dealt: " & cardsDealt)
            goodData = False

            'Creates a randomized multidimensional array that wont repeat the same output value
            Do Until goodData = True
                randomColumn = CInt(Int((4 * Rnd())))
                randomRow = CInt(Int((13 * Rnd())))

                If Not randomCard(randomRow, randomColumn) = True Then
                    randomCard(randomRow, randomColumn) = True
                    goodData = True
                ElseIf goodData = False Then

                End If
            Loop

            'Changes any card number that is 11,12,13,or 1 to its face value
            cardNumber = CStr(randomRow + 1)
            If cardNumber = "11" Then
                cardValue = "Jack"
            ElseIf cardNumber = "12" Then
                cardValue = "Queen"
            ElseIf cardNumber = "13" Then
                cardValue = "King"
            ElseIf cardNumber = "1" Then
                cardValue = "Ace"
            Else cardValue = cardNumber

            End If

            'Displays the cards quite in reference to the coloumn of the integer
            If randomColumn = 0 Then
                suite = "Hearts"
            ElseIf randomColumn = 1 Then
                suite = "Diamonds"
            ElseIf randomColumn = 2 Then
                suite = "Spades"
            ElseIf randomColumn = 3 Then
                suite = "Clubs"
            End If

            Console.WriteLine(cardValue & " Of " & suite)

            'Reshuffles the deck
            If cardsDealt = 52 Then
                Console.WriteLine(StrDup(4, vbTab) & "Cards Shuffled")
                For row = 0 To 12
                    For column = 0 To 3
                        randomCard(row, column) = False
                    Next
                    cardsDealt = 0
                Next
            Else
            End If

            'Exits the program when Q is selected
            If Console.ReadKey().Key = ConsoleKey.Q Then
                Exit Sub
            End If

        Loop

    End Sub

End Module
