using System;

namespace WorkingWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 6;

            Console.WriteLine(19);
            Console.WriteLine(1 + 2);
            Console.WriteLine(2 - 1);
            Console.WriteLine(8 / 2);
            Console.WriteLine(2 * 3);
            Console.WriteLine(5 % 2);
            Console.WriteLine(4 + 2 * 3);
            Console.WriteLine((4 + 2) * 3);
            Console.WriteLine(8.1 + 5.0); // double + double = double
            Console.WriteLine(5 + 8.1); // int + double = double
            Console.WriteLine(5 / 2); // 2 integers
            Console.WriteLine(num1);

            num1++;
            Console.WriteLine(num1);

            num1--;
            Console.WriteLine(num1);

            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(3, 2));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(4, 90));
            Console.WriteLine(Math.Min(4, 90));
            Console.WriteLine(Math.Round(4.6));

            Console.ReadLine();
        }
    }
}
