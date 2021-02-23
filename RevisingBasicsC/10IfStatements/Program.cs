using System;

namespace _10IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMonke = true;
            bool isSmart = true;

            if (isMonke && isSmart)
            {
                Console.WriteLine("You are smart  M O N K E");
            }
            else if (isMonke && !isSmart)
            {
                Console.WriteLine("Silly Monke");
            }
            else if (!isMonke && isSmart)
            {
                Console.WriteLine("How can be smart if not Monke?");
            }
            else
            {
                Console.WriteLine("You are not Monke and not smart");
            }

            Console.ReadLine();
        }
    }
}
