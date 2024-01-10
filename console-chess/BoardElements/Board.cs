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

    }
}
