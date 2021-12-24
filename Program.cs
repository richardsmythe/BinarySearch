using System;
using System.Security.Cryptography;

namespace BinarySearch
{
    class Program
    {

        static Boolean BinarySearch(int[] inputArray, int item)
        {
            int min = 0;
            int max = inputArray.Length - 1;

            //Sorted array
            Array.Sort(inputArray);
            Console.WriteLine("Sorted array:");
            foreach (int i in inputArray)
            {
                Console.Write(i);
                
            }

            //Apply binary search
            while (min <= max)
            {
                int mid = (min + max) / 2;

                if (item == inputArray[mid])
                {
                    Console.WriteLine();
                    Console.WriteLine(item + " is found at index "+mid);
                    Console.ReadLine();
                    
                }
                else if (item < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine(item + " is not found.");
            return false;
        }

        static void Main(string[] args)
        {
            int[] arr = {5,2,1,6,3,4,9,10 };
            Console.WriteLine(BinarySearch(arr,9));
            Console.ReadLine();
        }
    }
}
