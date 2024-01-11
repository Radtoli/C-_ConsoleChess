using console_chess;
using console_chess.BoardElements;
using console_chess.chess;

internal class Program
{
    static void Main(string[] args)
    {

        try 
        { 
       
        ChessMatch match = new ChessMatch();

            while (!match.finished)
            {
                Console.Clear();
                Screen.printBoard(match.board);


                Console.WriteLine();
                Console.WriteLine("Origin: ");
                Position origin = Screen.readChessPosition().toPosition();
                Console.WriteLine("Destiny: ");
                Position destiny = Screen.readChessPosition().toPosition();


                match.makeMovement(origin, destiny);
            }
           
        }
        catch (BoardException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
