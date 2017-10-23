using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09__excuses_a
{
    class Program
    {
        static void Main(string[] args)
        {
            var excuses = new[] { "Koer sõi kodutöö ära", "Ema ei luba arvutis tiksuda" };

            int i = 0;
            foreach (var excuse in excuses)
            {
                Console.WriteLine($"{i + 1}. {excuses[i]}");
                i++;
            }

            Console.ReadLine();
        }
    }
}
