using System;
using System.Collections.Generic;
using System.Text;

namespace Libraries
{
    public class CyclesHelper
    {
        public static int NumberAtoThePowerOfB(int a, int b)
        {
            if (b < 0 || a == 0 && b == 0)
            {
                throw new ArgumentException();
            }

            int result = 1;

            for (int i = 0; i < b; i++)
            {
                result *= a;
            }

            if (a < 0 && b == 0)
            {
                result = -1;
            }

            return result;
        }

        public static int FindTheNumberOfPositiveIntegersWhoseSquareIsLessThanA(int a)
        {
            int result = default;

            for (int i = 1; i * i < a; i++)
            {
                result++;
            }

            return result;
        }

        public static int PrintTheLargestDivisorOfTheNumberA(int a)
        {
            if (a == 0)
            {
                throw new DivideByZeroException();
            }

            int i = Math.Abs(a);

            if (a < -1 || a > 1)
            {
                for (i--; a % i != 0; i--) ;
            }

            return i;
        }

        public static int SumOfAllNumberThatAreDivisibleBy7(int a, int b)
        {
            const int constant = 7;

            if (a > b)
            {
                Swap(ref a, ref b);
            }

            int sum = 0;

            for (; a <= b; a++)
            {
                if (a % constant == 0)
                {
                    sum += a;
                }
            }

            return sum;
        }

        public static int FindFibonacciNumber(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException();
            }

            int FibonacciNumber = 0;
            int x1 = 0;
            int x2 = 1;
            int i = 2;
            if (n >= 0 && n <= 1)
            {
                FibonacciNumber = n;
            }

            for (; i <= n; i++)
            {
                if (x1 + x2 < 0)
                {
                    throw new ArgumentOutOfRangeException("Max index for this type: " + Convert.ToString(--i));
                }

                FibonacciNumber = x1 + x2;
                x1 = x2;
                x2 = FibonacciNumber;
            }

            return FibonacciNumber;
        }

        public static int FindGreatestCommonDivisor(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                throw new ArgumentException();
            }

            int greatestCommonDivisor = default;
            int absValueOfa = Math.Abs(a);
            int absValueOfb = Math.Abs(b);

            if (absValueOfa < absValueOfb)
            {
                Swap(ref absValueOfa, ref absValueOfb);
            }

            if (absValueOfb == 0)
            {
                greatestCommonDivisor = absValueOfa;
            }
            else
            {
                while (absValueOfa % absValueOfb != 0)
                {
                    int remainder = absValueOfa % absValueOfb;
                    absValueOfa = absValueOfb;
                    absValueOfb = remainder;
                }

                greatestCommonDivisor = absValueOfb;
            }

            return greatestCommonDivisor;
        }

        public static int FindTheNumberUsingBinarySearchAlgorithm(int a)
        {
            int result = 0;

            if ( a >= 0)
            {
                for (int i = 0; i <= a; i++)
                {
                    if (i * i * i == a)
                    {
                        result = i;
                    }
                }
            }
            else
            {
                for (int i = 0; i >= a; i--)
                {
                    if (i * i * i == a)
                    {
                        result = i;
                    }
                }
            }


            if (result * result * result != a)
            {
                throw new ArgumentException();
            }

            return result;
        }

        public static int FindTheNumberOfOddDigitsInThisNumber(int a)
        {
            int result = 0;

            if (a > 0)
            {
                for (int i = 1; i <= a; i += 2)
                {
                    result++;
                }
            }
            else
            {
                for (int i = -1; i >= a; i -= 2)
                {
                    result++;
                }
            }

            return result;
        }

        public static int ReverseNumber(int a)
        {
            int reversedNumber = 0;

            while (a > 0 || a < 0)
            {
                reversedNumber = reversedNumber * 10 + a % 10;
                a /= 10;
            }

            return reversedNumber;
        }

        public static string CheckRepeatedDigits(int a, int b)
        {
            string checking = "NO";
            char[] arrayA = a.ToString().ToCharArray();
            char[] arrayB = b.ToString().ToCharArray();

            for (int i = 0; i < arrayA.Length; i++)
            {
                for (int j = 0; j < arrayB.Length; j++)
                {
                    if (arrayA[i] == arrayB[j])
                    {
                        checking = "YES";
                    }
                }
            }

            return checking;
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
