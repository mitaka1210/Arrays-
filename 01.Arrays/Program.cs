using System;
using System.Linq;

namespace _01.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //3 10 20 30 
            //5 99 20 -1


            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
