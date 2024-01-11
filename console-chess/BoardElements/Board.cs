using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_chess.BoardElements
{
    internal class Board
    {
        public int row { get; set; }
        public int col { get; set; }
        private Piece[,] pieces;


        public Board(int row, int col)
        {
            this.row = row;
            this.col = col;
            pieces = new Piece[row, col];
        }

        public Piece piece(int row, int col)
        {
            return pieces[row, col];
        }

        public Piece piece(Position pos) 
        {
            return pieces[pos.row, pos.column];
        }

        public bool hasPiece(Position pos)
        {
            validatePosition(pos);
            return piece(pos) != null;  
        }

        public void putPiece(Piece p, Position pos)
        {
            if (hasPiece(pos))
            {
                throw new BoardException("This position already has a piece");
            }
            pieces[pos.row, pos.column] = p;
            p.position = pos;
        }

        public Piece takePiece(Position pos)
        {
            if (piece(pos) == null)
            {
                return null;
            }

            Piece aux = piece(pos);
            aux.position = null;
            pieces[pos.row, pos.column] = null;

            return aux;
        }


        public bool validPosition(Position pos)
        {
            if (pos.row < 0 || pos.row >= row || pos.column <0 || pos.column >= col)
            {
                return false;
            }
            return true;
        }

        public void validatePosition(Position pos)
        {
            if (!validPosition(pos))
            {
                throw new BoardException("Invalid Position");
            }
        }

    }
}
