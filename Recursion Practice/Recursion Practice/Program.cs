using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(factorial(11));
            //Console.WriteLine(fibonacci(13));
            //troll();
            Console.WriteLine(GCD(124, 27));
            //Console.WriteLine(multiplication(4, 7));
            Console.ReadKey();
        }

        static int factorial(int value)
        {
            if (value < 1)
            {
                throw new ArgumentException("You're dumb");
            }
            else if (value == 1)
            {
                return value;
            } 

            return value * factorial(value - 1);
        }

        static int fibonacci(int value)
        {
            if (value == 0)
            {
                return 0;
            }
            else if (value == 1)
            {
                return 1;
            }
            else
            {
                return fibonacci(value - 1) + fibonacci(value - 2);
            }
        }
        static void troll()
        {
            Console.WriteLine("Do you want to exit the program?");
            string answer = Console.ReadLine();
            if (answer == "Yes" || answer == "yes")
            {
                return;
            }
            else if (answer == "No" || answer == "no")
            {
                troll();
            }
            else
            {
                Console.WriteLine("Please enter a valid answer.");
                troll();
            }
        }
        static int GCD(int value, int value2)
        {
            // incomplete
            if (value == 0 || value2 == 0)
            {
                return 0;
            }
            else if (value == 1 || value2 == 0)
            {
                return 1;
            }
            else if (value % (value - 1) == 0 && value2 % (value2 - 1) == 0)
            {
                return value - 1;
            }
            else
            {
                return GCD(value - 1, value2 - 1);
            }
        }
        static int multiplication(int value, int value2)
        {
            if (value == 0 || value2 == 0)
            {
                return 0;
            }
            else if (value == 1 || value2 == 1)
            {
                if (value < value2)
                {
                    return value2;
                }
                return value;
            }
            else
            {
                return multiplication(value, value2 - 1) + value;
            }
        }
    }
}
