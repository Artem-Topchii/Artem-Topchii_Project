using System;
using Libraries;

namespace Artem_Topchii_Project_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[,] matrix = new[,] { { 1, 7, -18, 0, 0, -18, 52, -20, -1 },
                                     { 1, 7, -18, 0, 0, -18, 52, -20, -1 }};

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0}\t", matrix[i, j]));
                }

                Console.WriteLine(Environment.NewLine);
            }

            MultiDimensionalArrayHelper.FlipAnArrayAboutItsMainDiagonal(matrix);

            Console.WriteLine(Environment.NewLine);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0}\t", matrix[i, j]));
                }

                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}
