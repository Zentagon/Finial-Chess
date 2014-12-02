using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameLogic
{
    public class TurnOrder
    {
        // Ett tappert försök att använda enum på. :)
        public enum TurnInfo
        {
            End,
            New,
            Thinking,
            Choose,
            Win,
        };
        // Använder 
        public void TurnCheck(TurnInfo turnInfo)
        {
            switch (turnInfo)
            {
                case TurnInfo.New:
                    Console.WriteLine("Next player is beginning their turn!" + Environment.NewLine);
                    break;
                case TurnInfo.Thinking:
                    Console.WriteLine("Player is thinking!" + Environment.NewLine);
                    Thread.Sleep(2000);
                    break;
                case TurnInfo.Choose:
                    Console.WriteLine("Player have choosen a piece to move and moves it." + Environment.NewLine);
                    break;
                case TurnInfo.End:
                    Console.WriteLine("Player have finished his turn." + Environment.NewLine);
                    break;
            }
        }

        // Lägger till 2 nya spelare till spelet.
        public Player player1 = new Player();
        public Player player2 = new Player();
        // För att hålla koll på vems tur det är.
        private bool player1Turn = true;
        // Använder metoden TurnCheck tillsammans med enum för att få en händelse rapport.
        public void NewTurn()
        {
            if (player1Turn == true)
            {
                TurnCheck(TurnInfo.New);
                Thread.Sleep(2000);
                TurnCheck(TurnInfo.Thinking);
                Console.WriteLine(player1.RandomNumber());
                Console.WriteLine();
                Thread.Sleep(2500);
                TurnCheck(TurnInfo.Choose);
                Thread.Sleep(2000);
                TurnCheck(TurnInfo.End);
                player1Turn = false;
                Console.Clear();
            }
            else
            {
                TurnCheck(TurnInfo.New);
                Thread.Sleep(2000);
                TurnCheck(TurnInfo.Thinking);
                Console.WriteLine(player2.RandomNumber());
                Console.WriteLine();
                Thread.Sleep(2500);
                TurnCheck(TurnInfo.Choose);
                Thread.Sleep(2000);
                TurnCheck(TurnInfo.End);
                player1Turn = true;
                Console.Clear();
            }
        }
    }
}
