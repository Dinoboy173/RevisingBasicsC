using System;

namespace _21ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);

            Book book2 = new Book("Lord Of The Rings", "Tolkein", 700);

            Console.WriteLine(book2.title);

            Console.ReadLine();
        }
    }
}
