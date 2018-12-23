using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            int input;
            int remove;
            Random rand = new Random();
            List<int> nums = new List<int>();
            Functions funct = new Functions();
            List<int> sorted = new List<int>();
            List<int> easy = new List<int>();
            List<int> easynums = new List<int>();
            for (int i = 1; i < 5; i++)
            {
                easy.Add(i);
            }
            //for (int j = 0; j < 4; j++)
            //{
            //    remove = rand.Next(0, easy.Count);
            //    easynums.Add(easy[remove]);
            //    easy.RemoveAt(remove);
            //}
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Recursive Sorting\n1. Add a random number\n2. MergeSort\n3. QuickSort\n4. Quit");
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        nums.Add(rand.Next(1, 100));
                        break;
                    case 2:
                        sorted = funct.MergeSort(nums);
                        break;
                    case 3:
                        sorted = funct.QuickSort(nums);
                        break;
                    case 4:
                        running = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }

    class Functions
    {
        public List<int> MergeSort(List<int> input)
        {
            List<int> firstHalf = new List<int>();
            List<int> secondHalf = new List<int>();
            if (input.Count == 1)
            {
                return input;
            }
            for (int i = 0; i < input.Count; i++)
            {
                if (i < input.Count / 2)
                {
                    firstHalf.Add(input[i]);
                }
                if (i >= input.Count / 2)
                {
                    secondHalf.Add(input[i]);
                }
            }
            MergeSort(firstHalf);
            MergeSort(secondHalf);
            return Merge(firstHalf, secondHalf);
        }
        public List<int> Merge(List<int> firstInput, List<int> secondInput)
        {
            List<int> output = new List<int>();
            if (secondInput.Count == 0)
            {
                return null;
            }
            while (firstInput.Count > 0 || secondInput.Count > 0)
            {
                if (firstInput.Count > 0)
                {
                    int item = firstInput[0];
                    firstInput.RemoveAt(0);
                    int i = 0;
                    for (; i < output.Count && item > output[i]; i++) ;
                    output.Insert(i, item);

                }
                if (secondInput.Count > 0)
                {
                    int item = secondInput[0];
                    secondInput.RemoveAt(0);
                    int i = 0;
                    for (; i < output.Count && item > output[i]; i++) ;
                    output.Insert(i, item);
                }
            }
            return output;
        }

        public List<int> QuickSort(List<int> input)
        {
            if (input.Count > 2)
            {
                List<int> output = new List<int>();
                List<int> leftHalf = new List<int>();
                List<int> rightHalf = new List<int>();
                int leftIndex = 0;
                int rightIndex = input.Count - 2;
                int pivot = input[input.Count - 1];

                while (leftIndex < rightIndex)
                {
                    if (input[leftIndex] < pivot)
                    {
                        leftIndex++;
                    }
                    if (input[rightIndex] > pivot)
                    {
                        rightIndex--;
                    }
                    if (input[leftIndex] >= pivot && input[rightIndex] <= pivot)
                    {
                        var temp = input[leftIndex];
                        input[leftIndex] = input[rightIndex];
                        input[rightIndex] = temp;
                        leftIndex++;
                        rightIndex--;
                    }
                }
                input.Insert(leftIndex + 1, pivot);
                input.RemoveAt(input.Count - 1);
                for (int i = 0; i < leftIndex + 1; i++)
                {
                    leftHalf.Add(input[i]);
                }
                for (int j = leftIndex + 1; j < input.Count; j++)
                {
                    rightHalf.Add(input[j]);
                }
                output.AddRange(QuickSort(leftHalf));
                output.AddRange(QuickSort(rightHalf));
                return output;
            }
            if (input.Count > 1)
            {
                if (input[0] > input[1])
                {
                    var temp = input[0];
                    input[0] = input[1];
                    input[1] = temp;
                }
            }
            return input;
        }
    }
}