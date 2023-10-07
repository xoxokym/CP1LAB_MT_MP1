using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#5 Create a program that will display the fibonacci sequence. User will input how many numbers will be generated.");

            Console.WriteLine();

            int fnum = 0, snum = 1, num;

            Console.Write("Enter a number for a program to generate: ");
            int input = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            if (input == 0)
            {
                Console.WriteLine("");
            }

            else if (input == 1)
            {
                for (int x = 1; x <= input; x++)
                {
                    num = fnum + snum;
                    Console.WriteLine(num);
                    fnum = snum;
                    snum = num;
                }
            }

            else
            {
                Console.WriteLine(1);
                
                for (int x = 2; x <= input; x++)
                {
                    num = fnum + snum;
                    Console.WriteLine(num);
                    fnum = snum;
                    snum = num;
                }
            }
            Console.ReadKey();
        }
    }
}
