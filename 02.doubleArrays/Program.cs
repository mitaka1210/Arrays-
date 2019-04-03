using System;
using System.Linq;
namespace _02.doubleArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();

            for (int i = 0; i < text.Length / 2; i++)
            {
                string firstText = text[i];
                int indexOfRevercedCell = text.Length - i - 1;
                text[i] = text[indexOfRevercedCell];
                text[indexOfRevercedCell] = firstText;
            }
        }
    }
}
