using console_chess;
using console_chess.BoardElements;
using console_chess.chess;

internal class Program
{
    static void Main(string[] args)
    {

        try { 
       
        ChessMatch match = new ChessMatch();

            Screen.printBoard(match.board);
        }
        catch (BoardException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
