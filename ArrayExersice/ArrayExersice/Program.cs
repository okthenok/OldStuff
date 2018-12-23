using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayExersice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();
            int[] Number = new int[5];

            for (int i = 0; i < Number.Length; i++)
            {
                Number[i] = random.Next(10);
                Console.WriteLine("Number {1}: {0}", Number[i], i + 1); 
            }

            //int min = Number[0];
            //int max = Number[0];

            //for (int a = 1; a < Number.Length; a++)
            //{
            //    if (min > Number[a])
            //    {
            //        //we have a new min number
            //        min = Number[a];
            //    }
            //    if (max < Number[a])
            //    {
            //        //we have a new max number
            //        max = Number[a];
            //    }
            //}

            //Console.WriteLine("Min: {0}", min);
            //Console.WriteLine("Max: {0}", max);

            Console.WriteLine("----------------------------------------------------------------------");

            bool isSorted = true;
            do
            {
                isSorted = true;


                for (int i = 0; i < Number.Length - 1; i++)
                {
                    if (Number[i] > Number[i + 1])
                    {
                        int temp = Number[i];
                        Number[i] = Number[i + 1];
                        Number[i + 1] = temp;
                        
                        isSorted = false;
                    }
                }


            } while (!isSorted);



            for (int i = 0; i < Number.Length; i++)
            {
                Console.WriteLine("Number {1}: {0}", Number[i], i + 1);
            }


            
            //display these numbers on the screen...
            //display the lowest number on the screen
            //display the highest number on the screen
            //make a min and max
            // replace the max with the highest number and the min with the lowest
            // then display
            //EXPLAIN SORT SOMEBODY!!!!!!!!!!!!!!!!!!!
            Console.ReadLine();
        }
    }
}
