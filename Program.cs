using System;

namespace TikTakToe
{
    class Program
    {
        static void Main(string[] args)
        {
            EmptyBoard();
        }
        public static void EmptyBoard()
        {
            char[] board = new char[10] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        }
    }
}
