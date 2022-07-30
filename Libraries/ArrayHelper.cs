using System;
using System.Collections.Generic;
using System.Text;

namespace Libraries
{
    public class ArrayHelper
    {
        public static int FindTheMinimumValue(int[] array)
        {
            int minValue = array[FindTheMinimumValueIndex(array)];

            return minValue;
        }

        public static int FindTheMaximumValue(int[] array)
        {
            int maxValue = array[FindTheMaximumValueIndex(array)];

            return maxValue;
        }

        public static int FindTheMinimumValueIndex(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Empty or null array");
            }

            int minValueIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[minValueIndex] > array[i])
                {
                    minValueIndex = i;
                }
            }

            return minValueIndex;
        }

        public static int FindTheMaximumValueIndex(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Empty or null array");
            }

            int maxValueIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[maxValueIndex] < array[i])
                {
                    maxValueIndex = i;
                }
            }

            return maxValueIndex;
        }

        public static int SumOfArrayElementsWithOddIndices(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Null array");
            }

            int result = 0;

            for (int i = 1; i < array.Length; i += 2)
            {
                result += array[i];
            }

            return result;
        }

        public static int[] ReverseArray(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Null array");
            }

            for (int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--)
            {
                Swap(ref array[j], ref array[i]);
            }

            return array;
        }

        public static int CountOfOddArrayElements(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Null array");
            }

            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }

        public static int[] SwapTheFirstAndSecondHalfOfTheArray(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Null array");
            }

            for (int i = 0, j = (array.Length - array.Length / 2); i < array.Length / 2; i++, j++)
            {
                Swap(ref array[i], ref array[j]);
            }

            return array;
        }

        public static int[] SortTheArrayInAscendingOrder(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Null array");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }

            return array;
        }

        public static int[] SortTheArrayInDescendingOrder(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Null array");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                int maxIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[maxIndex])
                    {
                        maxIndex = j;
                    }
                }

                if (maxIndex != i)
                {
                    Swap(ref array[i], ref array[maxIndex]);
                }
            }

            return array;
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