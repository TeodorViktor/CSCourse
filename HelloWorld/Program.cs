// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            string test1;
            Console.WriteLine("Enter your name: ");
            test1 = Console.ReadLine();
            Console.WriteLine(test1.ToUpper());
            Console.WriteLine(string.Format("Your Name is {0} ", test1.ToUpper()));
            Console.ReadKey();

        }


    }
}
