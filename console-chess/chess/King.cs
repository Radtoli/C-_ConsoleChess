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
    }
}
