namespace ArrayQuiz
{
    // Online C# Editor for free
    // Write, Edit and Run your C# code using C# Online Compiler

    using System;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            string[,] table = new string[,]
            {
            {"1", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"}
            };
            SetField(table);
            Player1(table);
            Player2(table);
            Game(table);
        }

        public static void SetField(string[,] array2D)
        {
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", array2D[0, 0], array2D[0, 1], array2D[0, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", array2D[1, 0], array2D[1, 1], array2D[1, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", array2D[2, 0], array2D[2, 1], array2D[2, 2]);
        }
        public static void Player1(string[,] array2D)
        {
            Console.WriteLine("Player 1: Please Enter a Number from 1 to 9");
            var player1 = Console.ReadLine();
            while (!int.TryParse(player1, out _))
            {
                Console.Clear();
                SetField(array2D);
                Console.WriteLine("Only Numbers are allowed. Please Enter only number");
                Console.WriteLine("Player 1: Please Enter a Number from 1 to 9");
                player1 = Console.ReadLine();
            }
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; array2D.GetLength(1); j++)
                {

                }
            }
            switch(player1)
            {
                case "1":
                    array2D[0, 0] = "X";
                    break;
                case "2":
                    array2D[0, 1] = "X";
                    break;
                case "3":
                    array2D[0, 2] = "X";
                    break;
                case "4":
                    array2D[1, 0] = "X";
                    break;
                case "5":
                    array2D[1, 1] = "X";
                    break;
                case "6":
                    array2D[1, 2] = "X";
                    break;
                case "7":
                    array2D[2, 0] = "X";
                    break;
                case "8":
                    array2D[2, 1] = "X";
                    break;
                case "9":
                    array2D[2, 2] = "X";
                    break;
            }
            Console.Clear();
            SetField(array2D);
        }
        public static void Player2(string[,] array2D)
        {
            Console.WriteLine("Player 2: Please Enter a Number from 1 to 9");
            var player2 = Console.ReadLine();
            while (!int.TryParse(player2, out _))
            {
                Console.Clear();
                SetField(array2D);
                Console.WriteLine("Only Numbers are allowed. Please Enter only number");
                Console.WriteLine("Player 1: Please Enter a Number from 1 to 9");
                player2 = Console.ReadLine();
            }
            switch (player2)
            {
                case "1":
                    array2D[0, 0] = "O";
                    break;
                case "2":
                    array2D[0, 1] = "O";
                    break;
                case "3":
                    array2D[0, 2] = "O";
                    break;
                case "4":
                    array2D[1, 0] = "O";
                    break;
                case "5":
                    array2D[1, 1] = "O";
                    break;
                case "6":
                    array2D[1, 2] = "O";
                    break;
                case "7":
                    array2D[2, 0] = "O";
                    break;
                case "8":
                    array2D[2, 1] = "O";
                    break;
                case "9":
                    array2D[2, 2] = "O";
                    break;
            }
            Console.Clear();
            SetField(array2D);
        }

        public static void Game(string[,] array2D)
        {
            for(int i = 0; i < 9; i++) 
            {
                while ((array2D[i, 0] != array2D[i, 1] && array2D[i, 0] != array2D[i, 2]) || (array2D[0, i] != array2D[1, i] && array2D[0, i] != array2D[2, i]) || (array2D[0, i] != array2D[1, 1] && array2D[0, i] != array2D[2, 2]) || (array2D[0, 2] != array2D[1, 1] && array2D[0, 2] != array2D[0, 0]))
                {
                    Player1(array2D);
                    Player2(array2D);
                }
            }
        }

    }
}
