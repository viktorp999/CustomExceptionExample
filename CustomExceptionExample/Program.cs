using System;
using System.Linq;

namespace CustomExceptionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";

            try
            {
                Console.WriteLine("Enter your name");
                name = Console.ReadLine();

                while (name.Any(c => char.IsDigit(c)) || String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name))
                {
                    throw new ExceptionExampleClass();
                }

                Console.WriteLine("Your name is:{0} ", name);
            }

            catch(ExceptionExampleClass ex)
            {
                Console.WriteLine(ex.InvalidName());
            }

            Console.Read();
        }
    }
}
