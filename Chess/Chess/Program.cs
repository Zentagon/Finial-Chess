using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chess
{
    public class Menu : Board
    {
        // Active gör så att om användaren skriver fel så stängs inte spelet av.
        public bool Active = true;
        // När programmet startar så körs en liten menu som be användaren att starta spelet med kommandot "Begin". om användaren skriver fel så händer inget.
        public void Start()
        { 
            Console.WriteLine("Type Begin to start the automated chess game!");
            string input = Console.ReadLine();
            if (input == "Begin")
            {
                Thread.Sleep(1000);
                Console.Clear();
                Game = true;
                EmptySlots();
            }
            else
            {
                Console.Clear();
                Start();
            }
        }
    }
    public class Player
    {
        
    }
    public class Board
    {
        // Antal platser på brädet.
        private const int X = 8, Y = 8;
        // En bool variable för att stänga av spelet!
        public bool Game = false;
        // Själva brädet, som använder de ovanstående variablerna.
        public string[,] Bräde = new string[X,Y];
        // En metod för att kunna skriva ut brädet på skärmen.
        public void PrintBoard()
        {
            Console.WriteLine("     A     B     C     D     E     F     G     H");
            Console.WriteLine(" 8 [{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", Bräde[7, 0], Bräde[7, 1], Bräde[7, 2], Bräde[7, 3], Bräde[7, 4], Bräde[7, 5], Bräde[7, 6], Bräde[7, 7]);
            Console.WriteLine();
            Console.WriteLine(" 7 [{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", Bräde[6, 0], Bräde[6, 1], Bräde[6, 2], Bräde[6, 3], Bräde[6, 4], Bräde[6, 5], Bräde[6, 6], Bräde[6, 7]);
            Console.WriteLine();
            Console.WriteLine(" 6 [{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", Bräde[5, 0], Bräde[5, 1], Bräde[5, 2], Bräde[5, 3], Bräde[5, 4], Bräde[5, 5], Bräde[5, 6], Bräde[5, 7]);
            Console.WriteLine();
            Console.WriteLine(" 5 [{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", Bräde[4, 0], Bräde[4, 1], Bräde[4, 2], Bräde[4, 3], Bräde[4, 4], Bräde[4, 5], Bräde[4, 6], Bräde[4, 7]);
            Console.WriteLine();
            Console.WriteLine(" 4 [{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", Bräde[3, 0], Bräde[3, 1], Bräde[3, 2], Bräde[3, 3], Bräde[3, 4], Bräde[3, 5], Bräde[3, 6], Bräde[3, 7]);
            Console.WriteLine();
            Console.WriteLine(" 3 [{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", Bräde[2, 0], Bräde[2, 1], Bräde[2, 2], Bräde[2, 3], Bräde[2, 4], Bräde[2, 5], Bräde[2, 6], Bräde[2, 7]);
            Console.WriteLine();
            Console.WriteLine(" 2 [{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", Bräde[1, 0], Bräde[1, 1], Bräde[1, 2], Bräde[1, 3], Bräde[1, 4], Bräde[1, 5], Bräde[1, 6], Bräde[1, 7]);
            Console.WriteLine();
            Console.WriteLine(" 1 [{0}] [{1}] [{2}] [{3}] [{4}] [{5}] [{6}] [{7}]", Bräde[0, 0], Bräde[0, 1], Bräde[0, 2], Bräde[0, 3], Bräde[0, 4], Bräde[0, 5], Bräde[0, 6], Bräde[0, 7]);
        }
        // En metod som gör att alla fält blir tomma.
        public void EmptySlots()
        {
            for (int x = 0; x < X; x++)
            {
                for (int y = 0; y < Y; y++)
                {
                    Bräde[x, y] = "   ";
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            while (menu.Active == true)
            {
                menu.Start();
                while (menu.Game == true)
                {
                    menu.PrintBoard();
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
            Thread.Sleep(2000);
        }
    }
}
