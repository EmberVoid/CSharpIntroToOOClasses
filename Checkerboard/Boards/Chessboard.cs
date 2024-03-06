namespace Boards
{
    class Chessboard : Board
    {
        public override int Rows { get { return 8; } set { } }
        public override int Columns { get { return 8; } set { } }

        //Chessboard constructor calling parent constructor with matchin parameters 
        //Parent constructor will be called before the child's constructor allowing for further modifications on the child.
        public Chessboard() : base(8, 8)
        {
        }
    }
}