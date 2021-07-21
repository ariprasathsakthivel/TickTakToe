using System;

namespace TikTakToe
{
    class Program
    {
        static void Main(string[] args)
        {
            //EmptyBoard();
            LetterSelection();
        }
        public static void EmptyBoard()
        {
            char[] board = new char[10] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
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
    }
}
