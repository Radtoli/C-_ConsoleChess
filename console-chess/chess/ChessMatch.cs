using System;
using System.Security.Cryptography.X509Certificates;
using console_chess.BoardElements;
namespace console_chess.chess
{
    internal class ChessMatch
    {

        public Board board { get; private set; }
        private int turn;
        private Color currentPlayer;
        public bool finished { get; private set; }


        public ChessMatch()
        {
            board = new Board(8,8);
            turn = 1;
            currentPlayer = Color.White;
            putPieces();
            finished = false;
        }

        private void putPieces()
        {
            board.putPiece(new Rook(board, Color.White), new ChessPosition('a', 1).toPosition());
            board.putPiece(new King(board, Color.White), new ChessPosition('d', 1).toPosition());
            board.putPiece(new King(board, Color.Black), new ChessPosition('d', 8).toPosition());
            board.putPiece(new Rook(board, Color.Black), new ChessPosition('a', 8).toPosition());

        }


        public void makeMovement(Position origin, Position target)
        {
            Piece p = board.takePiece(origin);
            p.increaseMovementAmount();
            Piece capturedPiece = board.takePiece(target);
            board.putPiece(p, target);
        }
    }
}
