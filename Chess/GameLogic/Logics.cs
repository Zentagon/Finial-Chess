using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class Logics
    {
        // Tar emot det tal som dator spelarna genererar och skickar vidare det till de olika metoderna.
        public void UnitSelect(int number)
           {
            if (number <= 8)
            {
                PeasantSelector(number);
            }
            else
            {
                RoyalSelector(number);
            }
        }
        // Om talet som UnitSelect får in är 9 eller större så skickar den vidare talet till RoyalSelector.
        public void RoyalSelector(int number)
        {
            Console.WriteLine("Its 9 or more! " + number);
        }
        // Om talet är 8 eller mindre skickas den till PeasantSelector. Där får den välja vilken peasant
        // Som ska flyttas.
        public void PeasantSelector(int number)
        {
            Console.WriteLine("Its either 8 or less! " + number);
        }
    }
}
