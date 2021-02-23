using System;

namespace _7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            string[] friends = new string[6];
            friends[0] = "Joey";
            friends[1] = "Chandler";
            friends[2] = "Ross";
            friends[3] = "Fibi";
            friends[4] = "Monica";
            friends[5] = "Racheal";

            luckyNumbers[1] = 900;

            Console.WriteLine(luckyNumbers[1]);
            Console.WriteLine(friends[3]);

            Console.ReadLine();
        }
    }
}
