using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using console_chess.BoardElements;

namespace console_chess
{
    internal class Screen
    {
        public static void printBoard(Board board)
        {
            for (int i = 0; i <board.row;  i++)
            {
                for(int j = 0; j <board.col; j++)
                {
                    if (board.piece(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else { 
                    Console.Write(board.piece(i, j) + "");
                    }
                    
                }
                Console.WriteLine();

            }
        }
    }
}
