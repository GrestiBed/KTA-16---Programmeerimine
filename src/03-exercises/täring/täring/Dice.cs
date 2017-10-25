using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace täring
{
    class Dice
    {
        private Random Random { get; }

        private int Sides { get; }

        public Dice(int sides)
        {
            this.Sides = sides;
            this.Random = new Random();
        }
        public int Roll()
        {
            //Random rnd = new Random();
            //var roll = rnd.Next(1, sides);
            return this.Random.Next(1, this.Sides + 1);

        }

    }
}

