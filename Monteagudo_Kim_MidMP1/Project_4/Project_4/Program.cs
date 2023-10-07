using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#4 Create a program that display the cube of an integer up to the inputted number.");

            Console.WriteLine();

            Console.Write("Enter a number for a program to generate in cube: ");
            int num = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int x = 1; x <= num; x++)
            {
                int cube = x * x * x;
                Console.WriteLine("The cube of " + x + " is " + cube + ".");

                
            }
            Console.ReadKey();
        }
    }
}
