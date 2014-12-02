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
using GameLogic;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu menu = new Menu();
            //while (menu.Active == true)
            //{
            //    menu.Start();
            //    while (menu.Game == true)
            //    {
            //        menu.PrintBoard();
            //        Thread.Sleep(2000);
            //        Console.Clear();
            //    }
            //}
            Player player1 = new Player();
            Console.WriteLine(player1.RandomNumber());
            Thread.Sleep(1000);
            Console.WriteLine(player1.RandomNumber());
            Thread.Sleep(1000);
            Console.WriteLine(player1.RandomNumber());
            Thread.Sleep(1000);
            Console.WriteLine(player1.RandomNumber());
            Thread.Sleep(1000);
            Console.WriteLine(player1.RandomNumber());
            Thread.Sleep(1000);

        }
    }
}
