using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Parrot_Repeat_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            string myVariable;

            Console.WriteLine("See on papagoi programm. Mina ütlen sulle ja sina kordad mulle selle tagasi..");
            Console.Write(Environment.NewLine);
            Console.Write("Sina ütled: ");
            myVariable = Console.ReadLine();
            Console.Write("Mina ütlen: ");
            Console.WriteLine(myVariable);
            Console.ReadLine();
        }
    }
}
