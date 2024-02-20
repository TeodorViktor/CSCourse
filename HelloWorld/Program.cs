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
            GreetFriend("Lukas");
            Console.ReadKey();

            // If else and TryParse 
            Console.WriteLine("Please enter the temperature");
            string temp1 = Console.ReadLine();

            int parsedValue;
            if (int.TryParse(temp1, out parsedValue))
            {
                CheckTemp(parsedValue);
            }
            else
            {
                Console.WriteLine("Not a valid Temperature");
            }
        }


        public static void GreetFriend(string friend)
        {
            Console.WriteLine("Hi {0}", friend);
        }

        public static void StateOfMatter()
        {
            int temp = -5;
            string matter;
            // 3 if condition ways
            // 1
            if (temp < 0)
            {
                matter = "Solid";
            }
            else
            {
                matter = "Liquid";
            }

            // 2

            if (temp < 0)
                matter = "Solid";
            else
                matter = "Liquid";


            // 3 
            if (temp < 0) matter = "Solid";
            else matter = "Liquid";

            // 4
            matter = temp < 0 ? "Solid" : "Liquid";
        }

        public static void CheckTemp(int parsedValue)
        {
            if (parsedValue <= 15)
                Console.WriteLine("it is too cold here");
            else if (parsedValue >= 16 && parsedValue <= 28)
                Console.WriteLine("it is ok");
            else
                Console.WriteLine("it is hot here");
        }
    }
}
