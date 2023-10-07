using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#1 Create a program that will display the first 10 natural numbers.");

            Console.WriteLine();

            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
