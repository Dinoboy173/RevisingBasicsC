using System;

namespace _11MoreIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax1(20, 10));
            Console.WriteLine(GetMax2(20, 41, 4));

            Console.ReadLine();
        }

        static int GetMax1(int num1, int num2)
        {
            int result;

            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }

            return result;
        }

        static int GetMax2(int num1, int num2, int num3)
        {
            int result;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }
            return result;
        }
    }
}
