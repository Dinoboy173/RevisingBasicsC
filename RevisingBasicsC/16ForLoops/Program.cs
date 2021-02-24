using System;

namespace _16ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // int i = 1;
            // while (i <= 5)
            // {
            //     Console.WriteLine(i);
            //     i++;
            // }

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("");

            int[] luckyNumbers = { 4, 5, 6, 7, 12, 23 };

            for (int j = 0; j < luckyNumbers.Length; j++)
            {
                Console.WriteLine(luckyNumbers[j]);
            }

            Console.ReadLine();
        }
    }
}
