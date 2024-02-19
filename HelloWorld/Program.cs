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

    }
}
