using Boards;

namespace Checkerboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Boards.Board chessBoard = new() { Rows = 8, Columns = 8 };
            // chessBoard.Setup();
            chessBoard.Print();
        }
    }
}