using System;
using System.Collections.Generic;
using System.Linq;
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
}
