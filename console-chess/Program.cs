using console_chess.BoardElements;


namespace console_chess
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Board board = new Board(8, 8);



            Screen.printBoard(board);


        }
    }
}