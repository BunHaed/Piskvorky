using System;
using System.IO;
using System.Threading;

internal class Program
{
    private static void Main(string[] args)
    {
        char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        int Player = 1;

        Console.Clear();
        Console.WriteLine("Welcome to Piškovrky!");
        Console.WriteLine(" ");
        Console.WriteLine("Player 1 = X      Player 2 = O");
        Console.WriteLine(" ");
        Console.WriteLine("Press ENTER to start");
        Console.ReadKey();



        while (true)
        {
            bool UsIn = true;
            Console.Clear();
            Console.WriteLine("Player " + Player + "'s turn, pick a position:");
            Board();

            int UserInput = 0;

            while(UsIn)
            {
                while (!int.TryParse(Console.ReadLine(), out UserInput))
                    Console.WriteLine("Invalid input, please pick a position from 1 to 9");

                if (UserInput < 10 && UserInput > 0)
                {
                    if (Player == 1)
                    {
                        arr[Convert.ToInt32(UserInput)] = 'X';
                        Player = 2;
                        UsIn = false;
                    }
                    else
                    {
                        arr[Convert.ToInt32(UserInput)] = 'O';
                        Player = 1;
                        UsIn = false;
                    }
                }
                else
                {
                    break;
                }

            }

        }

        void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }







    }
}

