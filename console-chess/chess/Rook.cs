using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using console_chess.BoardElements;

namespace console_chess.chess
{
    internal class Rook : Piece
    {
        public Rook(Board board, Color color) : base(board, color)
        {

        }

        public override string ToString()
        {
            return "R";
        }

        private bool canMove(Position pos)
        {
            Piece p = board.piece(pos);
            return p == null || p.color != color;
        }

        public override bool[,] possibleMovements()
        {
            bool[,] mat = new bool[board.row, board.col];

            Position pos = new Position(0, 0);

            //above
            pos.defineValues(pos.row - 1, pos.column);
            while (board.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
                if(board.piece(pos) != null && board.piece(pos).color != color)
                {
                    break;
                }

                pos.row = pos.row - 1;
            }

            //below
            pos.defineValues(pos.row + 1, pos.column);
            while (board.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
                if (board.piece(pos) != null && board.piece(pos).color != color)
                {
                    break;
                }

                pos.row = pos.row + 1;
            }

            //right
            pos.defineValues(pos.row, pos.column + 1);
            while (board.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
                if (board.piece(pos) != null && board.piece(pos).color != color)
                {
                    break;
                }

                pos.row = pos.column + 1;
            }

            //left
            pos.defineValues(pos.row, pos.column - 1);
            while (board.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
                if (board.piece(pos) != null && board.piece(pos).color != color)
                {
                    break;
                }

                pos.row = pos.column - 1;
            }

            return mat;
        }
    }
}
