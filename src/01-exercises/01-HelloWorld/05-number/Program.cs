using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ma valin välja ühe suvalise numbri ([0-100]. Proovi see ära arvata :)");

            int magicNumber = 33;

            Console.Write(Environment.NewLine);
            Console.Write("Sina pakud: ");

            string input = Console.ReadLine();
            int value = int.Parse(input);

            if (value > magicNumber)
            {
                Console.WriteLine("Minu valitud number on väiksem");
            }

            else
            {
                Console.Write("Minu valitud number on suurem");
            }

            Console.Write(Environment.NewLine);
            Console.WriteLine("Press any key to continue..");

            Console.ReadLine();
        }
    }
}
