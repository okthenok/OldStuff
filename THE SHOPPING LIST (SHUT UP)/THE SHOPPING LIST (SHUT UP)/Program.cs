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
            
            Console.WriteLine("SHOPPING LIST");
            int Choices;
            int length =0; 
            Console.WriteLine("How many items do you want in your list?");
            length = int.Parse(Console.ReadLine());
            string[] STUFF = new string[length];
            for (int a = 0; a < STUFF.Length; a++)
            {
                Console.WriteLine("Item {0}", a+1);
                STUFF[a] = Console.ReadLine();
                
            }
            Console.ReadLine();
            
            bool TeemoIsAwesome = true;
            while (TeemoIsAwesome)
            {
                Console.Clear();
                Console.WriteLine("Choice 1- Add an item");
                Console.WriteLine("Choice 2- Take away an item");
                Console.WriteLine("Choice 3- View list");
                Console.WriteLine("Choice 4- Exit");
                Choices = int.Parse(Console.ReadLine());
                if (Choices == 1)
                {
                    length++;
                    string[] TempArray = new string[STUFF.Length + 1];
                    for (int c = 0; c < STUFF.Length; c++)
                    {
                        TempArray[c] = STUFF[c];
                    }
                    STUFF = TempArray;

                    Console.WriteLine("Item {0}", TempArray.Length);
                    TempArray[TempArray.Length - 1] = Console.ReadLine();
                    


                }
                else if (Choices == 2)
                {
                    length--;
                    string[] TempArray2 = new string[STUFF.Length - 1];
                    Console.WriteLine("What item do you want to delete?");
                    int remove = int.Parse(Console.ReadLine());
                    for (int d = 0,e=0;  d < STUFF.Length; d++,e++)
                    {
                        if (remove == d)
                        {
                            e--;
                        }
                        else
                        {
                            TempArray2[e] = STUFF[d];
                        }
                    }
                    
                    STUFF = TempArray2;
                    //we are done :)

                }
                else if (Choices == 3)
                {
                    for (int b = 0; b < STUFF.Length; b++)
                    {
                        Console.WriteLine("Item {0}: {1}", b + 1, STUFF[b]);
                    }

                    Console.ReadLine();
                }

                else
                {
                    TeemoIsAwesome = false;
                }
                
            }
            
        }
    }
}
