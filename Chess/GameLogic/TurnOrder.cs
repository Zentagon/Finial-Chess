using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameLogic
{
    public class TurnOrder : Logics
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
    
        // Kolla vilken enum som skickas in. Därefter skriver den olika på skärmen beroende på
        // enumet.
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
        // Använder metoden TurnCheck tillsammans med enum. Genom att skicka ett enum till TurnCheck, så skriver den ut
        // Lite text på skärmen om vad som händer. Tanken är att använda ett slumpmässigt tal för att göra så att datorn kan
        // Flytta pjäserna... Just nu står dom i en "CW" för att vi ska kunna se att den generar ett "Random" tal.
        public void NewTurn()
        {
            if (player1Turn == true)
            {
                TurnCheck(TurnInfo.New);
                Thread.Sleep(2000);
                TurnCheck(TurnInfo.Thinking);
                UnitSelect(player1.RandomNumber()); // Viktig!
                Console.WriteLine();
                Thread.Sleep(2500);
                TurnCheck(TurnInfo.Choose);
                Thread.Sleep(2000);
                TurnCheck(TurnInfo.End);
                Thread.Sleep(1500);
                player1Turn = false;
            }
            else
            {
                TurnCheck(TurnInfo.New);
                Thread.Sleep(2000);
                TurnCheck(TurnInfo.Thinking);
                UnitSelect(player2.RandomNumber()); // Viktig!
                Console.WriteLine();
                Thread.Sleep(2500);
                TurnCheck(TurnInfo.Choose);
                Thread.Sleep(2000);
                TurnCheck(TurnInfo.End);
                Thread.Sleep(1500);
                player1Turn = true;
            }
        }
    }
}
