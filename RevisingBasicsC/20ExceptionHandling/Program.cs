using System;

namespace _20ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch(DivideByZeroException e) // can use Execption in place of DivideByZeroException
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // anything in here WILL get exceuted
            }

            Console.ReadLine();
        }
    }
}
