using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class Player
    {
        public int RandomNumber()
        {
            Random random = new Random();
            int number = random.Next(1, 16);
            return number;
        }
    }
}
