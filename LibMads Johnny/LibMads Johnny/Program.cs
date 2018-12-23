using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // int variables only hold integers (whole numbers)
            // string variables hold multiple letters (words)
                //strings must have quotation marks around them

            string noun;
            string adjective;
            string verb;
            string noun1;
            string verb1;

            
            Console.WriteLine("WELCOME TO THE WORST LIBMADS IN THE WORLD");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            Console.WriteLine("Write an adjective");
            adjective = Console.ReadLine();
            Console.WriteLine("Write a noun");
            noun = Console.ReadLine();
            Console.WriteLine("Write a past tense verb");
            verb = Console.ReadLine();
            Console.WriteLine("Write a noun");
            noun1 = Console.ReadLine();
            Console.WriteLine("Write a past tense verb");
            verb1 = Console.ReadLine();

            Console.WriteLine("Once upon a time there was a very {1} person. He/She had a pet {0}. He/She {2}. He/She liked {3}. He/She {4} 5 days ago. That person is you.",noun,adjective,verb,noun1,verb1);

            Console.ReadKey();
        }
    }
}
