using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace täring
{
    class Dice
    {
        public string Description { get; }

        private static readonly Random Random = new Random();

        private int Sides { get; }

        private Dice(int sides, string description)
        {
            this.Sides = sides;
            this.Description = description;
            this.Random = new Random();
        }
        public static Dice D6 => new Dice(6, "d6");
        public static Dice D8 => new Dice(8, "d8");

        public int Roll()
        {
            return this.Random.Next(1, this.Sides + 1);
            //Random rnd = new Random();
            //var roll = rnd.Next(1, sides);
        }

    }
}

