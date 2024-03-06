namespace Boards
{
    class Board
    {
        private int[,] checkers;
        private int rows;
        private int columns;

        public int Rows { get { return rows; } set { rows = value; } }
        public int Columns { get { return Columns; } set { IsColumnsValid(value); } }

        //Constructors
        public Board()
        {
            rows = 0;
            rows = 0;
        }

        public Board(int r, int c)
        {
            rows = r;
            IsColumnsValid(c);
            Setup();
        }

        //Methods
        private void IsColumnsValid(int value)
        {
            if (value < 1)
            {
                Console.WriteLine($"Columns must be an even positive number.");
                Environment.Exit(0);
            }
            else if (value % 2 == 1)
            {
                Console.WriteLine($"Columns must be even, value {value} is an invalid number of columns.");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Valid Size");
                SetColumns(value);
            }
        }



        private void SetColumns(int value)
        {
            columns = value;
        }

        public void Setup()
        {
            checkers = new int[rows, columns];

            bool squareValue = true;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    checkers[r, c] = Convert.ToInt32(squareValue);
                    squareValue = !squareValue;
                }
                squareValue = !squareValue;
            }
        }

        public void Print()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    Console.Write($"{checkers[r, c]}");
                }
                Console.WriteLine("");
            }
        }
    }
}