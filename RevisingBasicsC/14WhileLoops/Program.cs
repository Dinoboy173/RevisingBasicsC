using System;

namespace _14WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;

            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);

            Console.ReadLine();
        }
    }
}
