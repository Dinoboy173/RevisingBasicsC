using System;

namespace _8Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi();
            SayName("Charlie", 20);
            Console.ReadLine();
        }

        static void SayHi()
        {
            Console.WriteLine("Hello User");
        }

        static void SayName(string name, int age)
        {
            Console.WriteLine(name + " is " + age);
        }
    }
}
