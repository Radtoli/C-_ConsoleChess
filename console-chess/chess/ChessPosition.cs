using System;
using console_chess.BoardElements;
namespace console_chess.chess
{
    internal class ChessPosition
    {
        public char column {  get; set; }
        public char row { get; set; }


        public ChessPosition(char column, char row)
        {
            this.column = column;
            this.row = row;
        }

        public override string ToString()
        {
            return "" + column + row;
        }

        public Position toPosition()
        {
            return new Position(8 - column, row - 'a');
        }


    }
}
