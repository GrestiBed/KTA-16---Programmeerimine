using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace täring
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Roll 3d6 2d8");
            Random rnd = new Random();

            Dice d6 = new Dice(6);

            var total = 0;

            for (int i = 0; i < 3; i++)
            {
                var roll = d6.Roll();
                Console.WriteLine($"1d6: { roll }");
                total += roll;
            }
            Dice d8 = new Dice(8);
            for (int i = 0; i < 2; i++)
            {
                var roll = d8.Roll();
                Console.WriteLine($"1d8: { roll}");
                total += roll;
            }

            //Console.WriteLine("Roll 3d6 2db");
            //Console.WriteLine("1d6: " + rnd.Next(1, 6));
            //Console.WriteLine("1d6: " + rnd.Next(1, 6));
            //Console.WriteLine("1d6: " + rnd.Next(1, 6));
            //Console.WriteLine("1d8: " + rnd.Next(1, 8));
            //Console.WriteLine("1d8: " + rnd.Next(1, 8));

            Console.Write(Environment.NewLine);
            Console.WriteLine("Roll total: " + total);



            Console.ReadLine();


        }
    }
}
