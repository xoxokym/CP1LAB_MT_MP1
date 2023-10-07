using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("#3 Create a program that will display the average of the generated numbers.");
            Console.WriteLine("   User must enter the quantity of numbers to be generated");

            Console.WriteLine();

            int sum = 0;

            Console.Write("Enter a number for a program to generate: ");
            int num = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int x = 1; x <= num; x++)
            {
                sum += x;
                Console.WriteLine(x);
            }

            Console.WriteLine();

            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine();

            Console.WriteLine("The inputted number is: " + num);
            Console.WriteLine();

            float ave = (float)sum / (float)num;
            Console.WriteLine("The average of sum of inputted number is: " + ave);
            
            Console.ReadKey();
        }
    }
}
