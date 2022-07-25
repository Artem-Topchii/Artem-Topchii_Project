using Libraries;
using NUnit.Framework;
using System;

namespace LibraryTests
{
    public class VariableHelperTests
    {
        [TestCase(1, 60)]
        [TestCase(5, 300)]
        [TestCase(0, 0)]
        public void ConvertHoursToMinutes_WhenInputIsPositive_ShouldGetNumberOfMinuts(int a, int expected)
        {
            int actual = VariableHelper.ConvertHoursToMinutes(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-10)]
        [TestCase(-1)]
        public void ConvertHoursToMinutes_WhenInputIsNegative_ShouldThrowArgumentException(int a)
        {
            try
            {
                VariableHelper.ConvertHoursToMinutes(a);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(3, 5, 20)]
        [TestCase(-3, 7, 3.4f)]
        [TestCase(8, 2, -7.33f)]
        [TestCase(0, -5, -5)]
        [TestCase(8, 0, -5)]
        [TestCase(-4, -3, -11)]
        public void SolveTheTask_WhenABAreNotEqual_ShouldGetResult(float a, float b, float expected)
        {
            float actual = VariableHelper.SolveTheTask(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(5, 5)]
        [TestCase(-8, -8)]
        public void SolveTheTask_WhenABAreEqual_ShouldThrowDivideByZeroException(float a, float b)
        {
            try
            {
                VariableHelper.SolveTheTask(a, b);
            }
            catch (DivideByZeroException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(1, 60, 60, 1)]
        [TestCase(-5, 15, 15, -5)]
        [TestCase(0, 0, 0, 0)]
        [TestCase(-5, -10, -10, -5)]
        [TestCase(2, -4, -4, 2)]
        public void Swap_WhenInputsAreInteger_ShouldGetSwappedNumbers(int a, int b, int expectedA, int expectedB)
        {
            var actual  = VariableHelper.Swap(a, b);
            var expected = (expectedA, expectedB);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 3, 3, 1)]
        [TestCase(12, 4, 3, 0)]
        [TestCase(0, -2, 0, 0)]
        [TestCase(-5, -10, 0, -5)]
        [TestCase(10, 15, 0, 10)]
        [TestCase(18, 18, 1, 0)]
        [TestCase(18, -4, -4, 2)]
        public void DividingWithRemainder_WhenBIsNotEqual0_ShouldGetSwappedNumbers(int a, int b, int expectedResult, int expectedDivision_Remainder)
        {
            var actual = VariableHelper.DividingWithRemainder(a, b);
            var expected = (expectedResult, expectedDivision_Remainder);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-10, 0)]
        [TestCase(12, 0)]
        [TestCase(0, 0)]
        public void DividingWithRemainder_WhenBIsEqual0_ShouldThrowDivideByZeroException(int a, int b)
        {
            try
            {
                VariableHelper.DividingWithRemainder(a, b);
            }
            catch (DivideByZeroException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(4, 5, 1, -1)]
        [TestCase(-5, 1, 7, -1.2f)]
        [TestCase(2, 0, 0, 0)]
        [TestCase(-5, -2, -8, 1.2f)]
        [TestCase(1.5f, 3.2f, 7, 2.53f)]
        public void SolveTheEquation_WhenAIsNotEqual0_ShouldGetResult(float a, float b, float c, float expected)
        {
            float actual = VariableHelper.SolveTheEquation(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, -7, -4)]
        [TestCase(0, 18, -8)]
        [TestCase(0, 0, 0)]
        public void SolveTheEquation_WhenAIsEqual0_ShouldThrowDivideByZeroException(float a, float b, float c)
        {
            try
            {
                VariableHelper.SolveTheEquation(a, b, c);
            }
            catch (DivideByZeroException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(3, 7, -1, -2, - 0.25f, -0.25f)]
        [TestCase(18, -2, 4, 8, 7.6f, -0.2f)]
        [TestCase(18, 10, 5, 7, 9.5f, -0.25f)]
        [TestCase(-8, 15, -7, -7, -7, 0)]
        public void SolveTheEquationOfStraightLine_WhenX1IsNotEqualX2_ShouldGetResult(float x1, float x2, float y1, float y2, float expectedA, float expectedB)
        {
            {
                var actual = VariableHelper.SolveTheEquationOfStraightLine(x1, x2, y1, y2);
                var expected = (expectedA, expectedB);

                Assert.AreEqual(expected, actual);
            }
        }

        [TestCase(1, 1, 7, -4)]
        [TestCase(18, 18, -8, 8)]
        [TestCase(0, 0, 1, 0)]
        [TestCase(-8, -8, -7, -7)]
        public void SolveTheEquationOfStraightLine_WhenX1IsEqualX2_ShouldThrowDivideByZeroException(float x1, float x2, float y1, float y2)
        {
            try
            {
                VariableHelper.SolveTheEquationOfStraightLine(x1, x2, y1, y2);
            }
            catch (DivideByZeroException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(23, 5)]
        [TestCase(5, 5)]
        [TestCase(-78, -15)]
        [TestCase(0, 0)]
        [TestCase(99, 18)]
        [TestCase(-1, -1)]
        public void CalculateSumOfDigits_WhenValueDoesNotHaveMoreThanTwoDigits_ShouldGetSumOfDigits(int a, int expected)
        {
            int actual = VariableHelper.CalculateSumOfDigits(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(127)]
        [TestCase(-567)]
        public void CalculateSumOfDigits_WhenValueHasMoreThanTwoDigits_ShouldThrowArgumentException(int a)
        {
            try
            {
                VariableHelper.CalculateSumOfDigits(a);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}
