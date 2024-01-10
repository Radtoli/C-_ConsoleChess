using console_chess.BoardElements;


namespace console_chess
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Board board = new Board(8,8);

            Position P;

            P = new Position(3, 4);

            Console.WriteLine("Position:" + P);
        }
    }
} 