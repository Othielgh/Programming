using System;

namespace TicTacToe
{
    internal class Program
    {
        static char[,] board =
        {
            {'1', '2', '3' },
            {'4', '5', '6' },
            {'7', '8', '9' }
        };

        static int rounds = 0;

        public static void Main(string[] args)
        {

            int player = 2;
            int input = 0;
            int winner = 0;
            bool inputCorrect = true;
            


            do
            {
                if (player == 2)
                {
                    player = 1;
                    EnterChoice(player, input);                   
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterChoice(player, input);                    
                }

                DrawBoard();

                do
                {
                    Console.WriteLine("Player {0}: Choose a field", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a correct number");
                    }

                    if ((input == 1) && (board[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (board[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (board[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (board[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (board[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (board[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (board[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (board[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (board[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("\n Incorrect input, please choose again");
                        inputCorrect = false;
                    }
                    
                } while (!inputCorrect);




            } while (true);

        }

        public static void DrawBoard()
        {
            Console.Clear();
            Console.WriteLine("*---------------------*");
            Console.WriteLine("       |       |");
            Console.WriteLine("   {0}   |   {1}   |   {2}", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine("_______|_______|______");
            Console.WriteLine("       |       |");
            Console.WriteLine("   {0}   |   {1}   |   {2}", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("_______|_______|______");
            Console.WriteLine("       |       |");
            Console.WriteLine("   {0}   |   {1}   |   {2}", board[2, 0], board[2, 1], board[2, 2]);
            Console.WriteLine("       |       |");
            Console.WriteLine("*---------------------*");
            rounds++;

        }

        public static void EnterChoice(int player, int input)
        {
            char playerSign = ' ';

            if (player == 1)
                playerSign = 'X';
            else if (player == 2)
                playerSign = 'O';

            switch (input)
            {
                case 1: board[0, 0] = playerSign; break;
                case 2: board[0, 1] = playerSign; break;
                case 3: board[0, 2] = playerSign; break;
                case 4: board[1, 0] = playerSign; break;
                case 5: board[1, 1] = playerSign; break;
                case 6: board[1, 2] = playerSign; break;
                case 7: board[2, 0] = playerSign; break;
                case 8: board[2, 1] = playerSign; break;
                case 9: board[2, 2] = playerSign; break;
            }
        }

    }
}
