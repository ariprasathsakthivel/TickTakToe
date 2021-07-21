using System;
using System.Collections.Generic;

namespace TikTakToe
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayBoard(EmptyBoard());
            //LetterSelection();

        }
        public static char[] EmptyBoard()
        {
            char[] board = new char[9] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
            return board;
        }
        public static void LetterSelection()
        {
            char player;
            char computer;
            Console.WriteLine("Enter the letter yo want to choose 'X' and 'O'");
            player = Convert.ToChar(Console.ReadLine());
            if (player!='X' && player!='O')
            {
                Console.WriteLine("Please enter a valid input; Either 'X' or 'O'");
                LetterSelection();
            }
            if (player == 'X')
            {
                computer = 'O';
            }
            else
            {
                computer = 'X';
            }
        }
        public static void DisplayBoard(char[] board)
        {
            int i = 0;
            while (i <9)
            {
                if (i != 6)
                {
                    Console.WriteLine(board[i] + "  |" + board[i + 1] + "  |" + board[i + 2]);
                    Console.WriteLine("---|---|---");
                    i = i + 3;
                }
                else
                {
                    Console.WriteLine(board[i] + "  |" + board[i + 1] + "  |" + board[i + 2]);
                    i = i + 3;
                }
            }
        }
    }
}
