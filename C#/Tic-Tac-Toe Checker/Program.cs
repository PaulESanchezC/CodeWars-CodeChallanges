using System;

namespace Tic_Tac_Toe_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] board = new int[,] { { 1, 2, 1 }, { 1, 1, 2 }, { 2, 2, 0 } };
            TicTacToe tictactoe = new TicTacToe();
            Console.WriteLine(tictactoe.IsSolved(board));

        }
    }

    public class TicTacToe
    {
        public int IsSolved(int[,] board)
        {
            bool noWinner = false;

            //Winning conditions
            if ((board[0, 0] == board[0, 1]) && (board[0, 0] == board[0, 2]))       //Top Row
                if (board[0, 0] != 0) return board[0, 0];
                else noWinner = true;

            if ((board[0, 0] == board[1, 0]) && (board[0, 0] == board[2, 0]))      //Left Column
                if (board[0, 0] != 0) return board[0, 0];
                else noWinner = true;

            if ((board[0, 0] == board[1, 1]) && (board[0, 0] == board[2, 2]))        //Backwards Diagonal 
                if (board[0, 0] != 0) return board[0, 0];
                else noWinner = true;

            if ((board[0, 1] == board[1, 1]) && (board[0, 1] == board[2, 1]))        //Middle Column
                if (board[0, 1] != 0) return board[0, 1];
                else noWinner = true;

            if ((board[0, 2] == board[1, 2]) && (board[0, 2] == board[2, 2]))       //Right Column 
                if (board[0, 2] != 0) return board[0, 2];
                else noWinner = true;
            
            if ((board[0, 2] == board[1, 1]) && (board[0, 2] == board[2, 0]))       //Forward Diagonal
                if (board[0, 2] != 0) return board[0, 2];
                else noWinner = true;

            if ((board[1, 0] == board[1, 1]) && (board[1, 0] == board[1, 2]) )      //Middle Row
                if (board[1, 0] != 0) return board[1, 0];
                else noWinner = true;

            if ((board[2, 0] == board[2, 1]) && (board[2, 0] == board[2, 2]))       //Bottom Row
                if (board[2, 0] != 0) return board[2, 0];
                else noWinner = true;

            //Because in the Winning conditions logic only checks for equality in arrays
            foreach (var value in board)
            {
                if (value == 0)
                {
                    return -1;
                }
            }

            //Conditional equality for not played spaces
            if (noWinner)
            {
                return -1;
            }

            //Cat's game
            return 0;
        }
    }
}
