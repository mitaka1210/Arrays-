using System;
using System.Linq;

namespace _03.doubleArrys
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] number = Console.ReadLine()
               .Split()
               .Select(double.Parse)
               .ToArray();
            for (int i = 0; i < number.Length; i++)
            {
                double originalNUmber = number[i];
                int roundNUmber = (int)Math.Round(originalNUmber, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{originalNUmber} => {roundNUmber}");
            }
        }
    }
}
