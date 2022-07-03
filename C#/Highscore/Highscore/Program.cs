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

        int player = 1;
        static int choice;
        static int winner = 0;
        bool inputCorrect = true;

        public static void Main(string[] args)
        {
            Console.WriteLine("Player 1 : X \n Player 2 : O");



           // choice = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (player == 1)
                {
                    player = 1;
                    EnterChoice(player, input);
                }
                else if (player == 2)
                {
                    player = 2;
                    EnterChoice(player, input)
                }

                DrawBoard();
            }

  
        }

        public static void DrawBoard()
        {

            Console.WriteLine("*---------------------*");
            Console.WriteLine("       |       |");
            Console.WriteLine("   {0}   |   {1}   |   {2}", board[0,0], board[0,1], board[0,2]);
            Console.WriteLine("_______|_______|______");
            Console.WriteLine("       |       |");
            Console.WriteLine("   {0}   |   {1}   |   {2}", board[1,0], board[1,1], board[1,2]);
            Console.WriteLine("_______|_______|______");
            Console.WriteLine("       |       |");
            Console.WriteLine("   {0}   |   {1}   |   {2}", board[2,0], board[2,1], board[2,2]);
            Console.WriteLine("       |       |");
            Console.WriteLine("*---------------------*");

           
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
                case 1: board[0,0] = playerSign; break;
                case 2: board[0,1] = playerSign; break;
                case 3: board[0,2] = playerSign; break;
                case 4: board[1,0] = playerSign; break;
                case 5: board[1,1] = playerSign; break;
                case 6: board[1,2] = playerSign; break;
                case 7: board[2,0] = playerSign; break;
                case 8: board[2,1] = playerSign; break;
                case 9: board[2,2] = playerSign; break;
            }
        }

    }
}
