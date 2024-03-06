using System.Xml;
using Boards;

namespace Checkerboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nChessboard 8x8");
            Board chessBoard = new Chessboard();//Chessboard class construct already defines (8, 8)
            chessBoard.Print();

            Console.WriteLine("\ngameBoard 5x4");
            Board gameBoard = new Board(5, 4);//Testing Parent board construct
            // Board gameBoard = new Board() { Rows = 5, Columns = 4 };
            gameBoard.Print();

            /*
            Important
            These are 2 different ways to instanciate:
            Board gameBoard = new Board(5, 4); This will call the class construct
            Board gameBoard = new Board() { Rows = 5, Columns = 4 }; This will NOT call the class construct, this will call the setter and getter of the class
            */

            Console.WriteLine("\nerrorBoard 5x3");
            Board errorBoard = new Board() { Rows = 5, Columns = 3 };//Testing error IsColumnsValid
            errorBoard.Print();

        }
    }
}