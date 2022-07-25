using System;
using System.Collections.Generic;
using System.Text;

namespace Libraries
{
    public class MultiDimensionalArrayHelper
    {
        public static int FindTheMinimumElementOfTheArray(int[,] matrix)
        {
            (int minI, int minJ) = FindTheIndexOfTheMinimumElementOfTheArray(matrix);
            int minValue = matrix[minI, minJ];

            return minValue;
        }

        public static int FindTheMaximumElementOfTheArray(int[,] matrix)
        {
            (int maxI, int maxJ) = FindTheIndexOfTheMaximumElementOfTheArray(matrix);
            int maxValue = matrix[maxI, maxJ];

            return maxValue;
        }

        public static (int, int) FindTheIndexOfTheMinimumElementOfTheArray(int[,] matrix)
        {
            if (matrix == null || matrix.Length == 0)
            {
                throw new ArgumentException("Empty or null matrix");
            }

            int minI = 0;
            int minJ = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[minI, minJ] > matrix[i, j])
                    {
                        minI = i;
                        minJ = j;
                    }
                }
            }

            return (minI, minJ);
        }

        public static (int, int) FindTheIndexOfTheMaximumElementOfTheArray(int[,] matrix)
        {
            if (matrix == null || matrix.Length == 0)
            {
                throw new ArgumentException("Empty or null matrix");
            }

            int maxI = 0;
            int maxJ = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[maxI, maxJ] < matrix[i, j])
                    {
                        maxI = i;
                        maxJ = j;
                    }
                }
            }

            return (maxI, maxJ);
        }

        public static int FindTheNumberOfElementsThatAreGreaterThanAllTheirNeighbors(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentException("Null matrix");
            }

            int maxValue = 0;

            if (matrix.Length <= 1)
            {
                maxValue = 0;
            }
            else
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        int temp = int.MinValue;

                        for (int k = i - 1; k <= i + 1; k++)
                        {
                            if (k >= 0 && k <= matrix.GetLength(0) - 1)
                            {
                                for (int o = j - 1; o <= j + 1; o++)
                                {
                                    if (o >= 0 && o <= matrix.GetLength(1) - 1 && (k != i || o != j))
                                    {
                                        if (temp < matrix[k, o])
                                        {
                                            temp = matrix[k, o];
                                        }
                                    }
                                }
                            }
                        }

                        if (matrix[i, j] > temp)
                        {
                            maxValue++;
                        }
                    }
                }
            }

            return maxValue;
        }

        public static int[,] FlipAnArrayAboutItsMainDiagonal(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentException("Null matrix");
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i; j < matrix.GetLength(1); j++)
                {
                    Swap(ref matrix[i, j], ref matrix[j, i]);

                    if (j == matrix.GetLength(0) - 1)
                    {
                        break;
                    }
                }
            }

            return matrix;
        }

        private static (int, int) Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            return (a, b);
        }
    }
}