using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using console_chess.BoardElements;

namespace console_chess.chess
{
    internal class King : Piece
    {
        public King(Board board, Color color) : base(board, color) 
        {
        
        }

        public override string ToString()
        {
            return "K";
        }


        private bool canMove(Position pos)
        {
            Piece p = board.piece(pos);
            return p == null || p.color != color;
        }

        public override bool[,] possibleMovements()
        {
            bool[,] mat = new bool[board.row, board.col];

            Position pos = new Position(0,0);

            //Above
            pos.defineValues(pos.row - 1, pos.column + 1);
            if (board.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }
            //Northeast
            pos.defineValues(pos.row - 1, pos.column);
            if (board.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }
            //right
            pos.defineValues(pos.row, pos.column);
            if (board.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }
            //SouthEast
            pos.defineValues(pos.row + 1, pos.column + 1);
            if (board.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }
            //Below
            pos.defineValues(pos.row + 1, pos.column);
            if (board.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }
            //SouthWest
            pos.defineValues(pos.row + 1, pos.column -1 );
            if (board.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }
            //Left
            pos.defineValues(pos.row, pos.column - 1);
            if (board.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }
            //NorthWest
            pos.defineValues(pos.row + 1, pos.column - 1);
            if (board.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }
            return mat;
        }
    }
}
