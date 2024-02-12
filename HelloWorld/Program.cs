// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            string myname = "Denis";
            string message = "My name is " + myname;
            string capsMessage = message.ToUpper();
            string lowerCaseMessage = message.ToLower();
            string name = "Teodor";
            //Console.WriteLine(name.ToUpper());
            //Console.WriteLine(lowerCaseMessage);
            //Console.Read();
            Console.WriteLine("Enter Something");
            string userInput = Console.ReadLine();
            Console.WriteLine("You have entered {0}", userInput);
            Console.WriteLine("Enter a string: ");
            int asciiVallue = Console.Read();
            Console.WriteLine("Ascii {0}", asciiVallue);
            Console.ReadKey();
        }


    }
}
