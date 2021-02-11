/*
 Author: Shanaya Soans 
 Date: 02/10/20
 Comments: This C# console application code demonstartes the use of arrays
*/

using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            foreach (int i in array)
            {
                Console.Write("Element Value = " + i + "\n");
            }
            Console.ReadKey(true);
        }
    }
}
