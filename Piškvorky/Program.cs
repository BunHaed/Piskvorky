using System;
using System.IO;
using System.Threading;

internal class Program
{
    private static void Main(string[] args)
    {
        char[] field = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        int Player = 1;

        Console.Clear();
        Console.WriteLine("Welcome to Piškovrky!");
        Console.WriteLine(" ");
        Console.WriteLine("Player 1 = X      Player 2 = O");
        Console.WriteLine(" ");
        Console.WriteLine("Press ENTER to start");
        Console.ReadKey();

        //test na line 20 :).... uuuu asi to konečně funguje :DD

        while (true)
        {
            bool UsIn = true;
            Console.Clear();
            Console.WriteLine("Player " + Player + "'s turn, pick a position:");
            Board();

            int UserInput = 0;

            while(UsIn)
            {
                while (!int.TryParse(Console.ReadLine(), out UserInput) || UserInput > 9 || UserInput < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Player " + Player + "'s turn, pick a position:");
                    Board();
                    Console.WriteLine("Invalid input, please pick a position from 1 to 9");
                }


                if (field[UserInput] == 'X' || field[UserInput] == 'O')
                {
                    Console.WriteLine("Sorry, this field is already marked with {0}, please try again", field[UserInput]);
                    Console.WriteLine("Please wait, console is loading....");
                    Thread.Sleep(3500);
                    UsIn = false;
                }
                else



                if (UserInput < 10 && UserInput > 0)
                {
                    if (Player == 1)
                    {
                        field[Convert.ToInt32(UserInput)] = 'X';
                        Player = 2;
                        UsIn = false;
                    }
                    else
                    {
                        field[Convert.ToInt32(UserInput)] = 'O';
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
            Console.WriteLine("  {0}  |  {1}  |  {2}", field[1], field[2], field[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", field[4], field[5], field[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", field[7], field[8], field[9]);
            Console.WriteLine("     |     |      ");
        }







    }
}

