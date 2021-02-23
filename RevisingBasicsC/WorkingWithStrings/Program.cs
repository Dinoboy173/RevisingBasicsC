using System;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase1 = "Working Strings";
            string phrase2 = "Working" + "Strings";

            Console.WriteLine("Working\nStrings");
            Console.WriteLine("Working\"Strings");
            Console.WriteLine(phrase1);
            Console.WriteLine(phrase2);
            Console.WriteLine(phrase1.Length);
            Console.WriteLine(phrase1.ToUpper());
            Console.WriteLine(phrase1.ToLower());
            Console.WriteLine(phrase1.Contains("Strings"));
            Console.WriteLine(phrase1[3]);
            Console.WriteLine(phrase1.IndexOf("Strings"));
            Console.WriteLine(phrase1.Substring(8, 3));

            Console.ReadLine();
        }
    }
}
