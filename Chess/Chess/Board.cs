using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Board
    {
        // Antal platser på brädet.
        private const int X = 8, Y = 8;
        // En bool variable för att stänga av spelet!
        public bool Game = false;
        // Själva brädet, som använder de ovanstående variablerna.
        public string[,] ChessBoard = new string[X,Y];
        // En metod för att kunna skriva ut brädet på skärmen.
        public void PrintBoard()
        {
            Console.WriteLine("     A     B     C     D     E     F     G     H");
            Console.WriteLine(" 8 [{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", ChessBoard[7, 0], ChessBoard[7, 1], ChessBoard[7, 2], ChessBoard[7, 3], ChessBoard[7, 4], ChessBoard[7, 5], ChessBoard[7, 6], ChessBoard[7, 7]);
            Console.WriteLine();
            Console.WriteLine(" 7 [{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", ChessBoard[6, 0], ChessBoard[6, 1], ChessBoard[6, 2], ChessBoard[6, 3], ChessBoard[6, 4], ChessBoard[6, 5], ChessBoard[6, 6], ChessBoard[6, 7]);
            Console.WriteLine();
            Console.WriteLine(" 6 [{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", ChessBoard[5, 0], ChessBoard[5, 1], ChessBoard[5, 2], ChessBoard[5, 3], ChessBoard[5, 4], ChessBoard[5, 5], ChessBoard[5, 6], ChessBoard[5, 7]);
            Console.WriteLine();
            Console.WriteLine(" 5 [{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", ChessBoard[4, 0], ChessBoard[4, 1], ChessBoard[4, 2], ChessBoard[4, 3], ChessBoard[4, 4], ChessBoard[4, 5], ChessBoard[4, 6], ChessBoard[4, 7]);
            Console.WriteLine();
            Console.WriteLine(" 4 [{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", ChessBoard[3, 0], ChessBoard[3, 1], ChessBoard[3, 2], ChessBoard[3, 3], ChessBoard[3, 4], ChessBoard[3, 5], ChessBoard[3, 6], ChessBoard[3, 7]);
            Console.WriteLine();
            Console.WriteLine(" 3 [{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", ChessBoard[2, 0], ChessBoard[2, 1], ChessBoard[2, 2], ChessBoard[2, 3], ChessBoard[2, 4], ChessBoard[2, 5], ChessBoard[2, 6], ChessBoard[2, 7]);
            Console.WriteLine();
            Console.WriteLine(" 2 [{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", ChessBoard[1, 0], ChessBoard[1, 1], ChessBoard[1, 2], ChessBoard[1, 3], ChessBoard[1, 4], ChessBoard[1, 5], ChessBoard[1, 6], ChessBoard[1, 7]);
            Console.WriteLine();
            Console.WriteLine(" 1 [{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", ChessBoard[0, 0], ChessBoard[0, 1], ChessBoard[0, 2], ChessBoard[0, 3], ChessBoard[0, 4], ChessBoard[0, 5], ChessBoard[0, 6], ChessBoard[0, 7]);
        }
        // En metod som gör att alla fält blir tomma.
        public void EmptySlots()
        {
            for (int x = 0; x < X; x++)
            {
                for (int y = 0; y < Y; y++)
                {
                    ChessBoard[x, y] = "   ";
                }
            }
        }
}
