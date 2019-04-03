using System;
using System.Linq;


namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            //Горените редове са съкратен вариянт на долните;
            for (int i = 0; i < numbers.Length; i++)
            {
                var number = numbers[i];
                Console.WriteLine(number);
            }
        }
    }
}
