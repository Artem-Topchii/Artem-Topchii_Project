using System;
using System.Collections.Generic;
using System.Text;

namespace Libraries
{
    public class VariableHelper
    {
        public static int ConvertHoursToMinutes(int hours)
        {
            if (hours < 0)
            {
                throw new ArgumentException();
            }

            return hours * 60;
        }

        public static float SolveTheTask(float a, float b)
        {
            if (a == b)
            {
                throw new DivideByZeroException();
            }

            return (float)Math.Round((5 * a + b * b) / (b - a), 2);
        }

        public static (int, int) Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;

            return (a, b);
        }

        public static (int, int) DividingWithRemainder(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }

            int result = a / b;
            int division_Remainder = a % b;

            return (result, division_Remainder);
        }

        public static float SolveTheEquation(float a, float b, float c)
        {
            if (a == 0)
            {
                throw new DivideByZeroException();
            }

            float x = (float)Math.Round((c - b) / a, 2);

            return x;
        }

        public static (float, float) SolveTheEquationOfStraightLine(float x1, float x2, float y1, float y2)
        {
            if (x1 == x2)
            {
                throw new DivideByZeroException();
            }

            float b = (y1 - y2) / (x1 - x2);
            float a = y2 - b * x2;

            return (a, b);
        }

        public static int CalculateSumOfDigits(int n)
        {
            if (n < -100 || n > 100)
            {
                throw new ArgumentException();
            }

            return n / 10 + n % 10;
        }
    }
}