using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#2 Create a program that will display the first 20 odd natural numbers.");

            Console.WriteLine();

            for (int x = 1; x <= 40; x+=2)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
