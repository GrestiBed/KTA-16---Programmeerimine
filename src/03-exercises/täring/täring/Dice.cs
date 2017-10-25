using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace täring
{
    class Dice
    {
        public int Roll(int sides)
        {
            //Random rnd = new Random();
            //var roll = rnd.Next(1, sides);
            return new Random().Next(1, sides + 1);

        }

    }
}

