using System;

namespace Goto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("******Checkers******");
            int[,] checkers = new int[4, 4];
            bool squareValue = true;

            for (int i = 0; i < 4; i++)
            {
                PopulateCheckerRow(ref checkers, i, squareValue);
                squareValue = !squareValue;
            }

            PrintCheckers(checkers);
        }

        static void PopulateCheckerRow(ref int[,] checks, int row, bool sv)
        {
            for (int col = 0; col < 4; col++)
            {
                checks[row, col] = Convert.ToInt32(sv);
                sv = !sv;
            }
        }

        static void PrintCheckers(int[,] checks)
        {
            for (int r = 0; r < 4; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write($"{checks[r, c]}");
                }
                Console.WriteLine("");
            }
        }
    }
}