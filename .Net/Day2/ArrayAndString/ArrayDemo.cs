using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndString
{
    internal class ArrayDemo
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int[,] arr2 = { { 10, 20 }, { 30, 40 }, { 50, 60 } };
            int[,] arr3 = new int[3, 2];

            Console.WriteLine(arr.Length);
            Console.WriteLine(arr2.Length);
            Console.WriteLine(arr3.Length);
            Console.WriteLine("Rank of Array:");
            Console.WriteLine(arr.Rank);
            Console.WriteLine(arr2.Rank);
            Console.WriteLine(arr3.Rank);
            Console.WriteLine();
            foreach (var item in arr)
            {
                Console.Write(item + " \t");
            }
            Console.WriteLine();

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write(arr2[i, j] + "\t");
                }
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine("Enter value for arr");
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLength(1); j++)
                {
                    arr3[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();

            }

            DisplayArray(arr3);

            Console.WriteLine();
            int[] arr5 = { 2, 5, 3, 78, 90, 23, 20 };
            Console.WriteLine("Array Orignal .....\n");
            foreach (var item in arr5)
            {
                Console.WriteLine(item);
            }

            //Copy Array
            int[] arr6 = new int[arr5.Length];
            Array.Copy(arr5, arr6, arr5.Length);

            Console.WriteLine("Array Sort .....\n");
            Array.Sort(arr5);
            foreach (var item in arr5)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Array Reverse.....\n");
            Array.Reverse(arr5);
            foreach (var item in arr5)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Array Orignal .....\n");
            foreach (var item in arr6)
            {
                Console.WriteLine(item);
            }

        }

        private static void DisplayArray(int[,] arr3)
        {
            Console.WriteLine();
            Console.WriteLine("Displaying Array: ");
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLength(1); j++)
                {
                    Console.Write(arr3[i, j] + "\t");
                }
                Console.WriteLine();

            }
        }
    }
}
