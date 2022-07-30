using Libraries;
using NUnit.Framework;
using System;

namespace LibraryTests
{
    public class CyclesHelperTests
    {
        [TestCase(1, 0, 1)]
        [TestCase(-52, 0, -1)]
        [TestCase(123, 0, 1)]
        [TestCase(1, 1, 1)]
        [TestCase(12, 1, 12)]
        [TestCase(-42, 1, -42)]
        [TestCase(4, 4, 256)]
        [TestCase(0, 15, 0)]
        [TestCase(3, 3, 27)]
        [TestCase(15, 2, 225)]
        public void NumberAtoThePowerOfB_WhenAandBAreNotEqual0OrBIsGreaterOrEqual0_ShouldGetResult(int a, int b, int expected)
        {
            int actual = CyclesHelper.NumberAtoThePowerOfB(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(0, -8)]
        [TestCase(-14, -2)]
        [TestCase(8, -3)]
        public void NumberAtoThePowerOfB_WhenAandBAreEqual0OrBIsLessThan0_ShouldThrowArgumentException(int a, int b)
        {
            try
            {
                CyclesHelper.NumberAtoThePowerOfB(a, b);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(25, 4)]
        [TestCase(0, 0)]
        [TestCase(-10, 0)]
        [TestCase(100, 9)]
        [TestCase(1000, 31)]
        public void FindTheNumberOfPositiveIntegersWhoseSquareIsLessThanA_WhenAIsInteger_ShouldGetResult(int a, int expected)
        {
            int actual = CyclesHelper.FindTheNumberOfPositiveIntegersWhoseSquareIsLessThanA(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(25, 5)]
        [TestCase(12, 6)]
        [TestCase(-10, 5)]
        [TestCase(73, 1)]
        [TestCase(1000, 500)]
        [TestCase(-27, 9)]
        [TestCase(971, 1)]
        public void PrintTheLargestDivisorOfTheNumberA_WhenAIsNotEqual0_ShouldGetResult(int a, int expected)
        {
            int actual = CyclesHelper.PrintTheLargestDivisorOfTheNumberA(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void PrintTheLargestDivisorOfTheNumberA_WhenAIsEqual0_ShouldThrowDivideByZeroException(int a)
        {
            try
            {
                CyclesHelper.PrintTheLargestDivisorOfTheNumberA(a);
            }
            catch (DivideByZeroException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(7, 7, 7)]
        [TestCase(-10, 10, 0)]
        [TestCase(20, 10, 14)]
        [TestCase(21, 9, 35)]
        [TestCase(-30, -8, -63)]
        [TestCase(-15, 34, 49)]
        [TestCase(0, 0, 0)]
        [TestCase(-2, 5, 0)]
        [TestCase(0, 10, 7)]
        public void SumOfAllNumberThatAreDivisibleBy7_WhenAAndBIsIntegerRange_ShouldGetResult(int a, int b, int expected)
        {
            int actual = CyclesHelper.SumOfAllNumberThatAreDivisibleBy7(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(0, 0)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(10, 55)]
        [TestCase(11, 89)]
        public void FindFibonacciNumber_WhenNIsNotLessThan0AndFibonacciNumberIsNotOutOfTheRange_ShouldGetFibonacciNumber(int a, int expected)
        {
            int actual = CyclesHelper.FindFibonacciNumber(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-15)]
        [TestCase(-1)]
        public void FindFibonacciNumber_WhenNIsLessThan0_ShouldThrowArgumentException(int a)
        {
            try
            {
                CyclesHelper.FindFibonacciNumber(a);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(47)]
        [TestCase(100)]
        public void FindFibonacciNumber_WhenFibonacciNumberIsOutOfTheRange_ShouldThrowArgumentOutOfRangeException(int a)
        {
            try
            {
                CyclesHelper.FindFibonacciNumber(a);
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(7, 7, 7)]
        [TestCase(28, 7, 7)]
        [TestCase(33, 10, 1)]
        [TestCase(-28, -14, 14)]
        [TestCase(-30, 20, 10)]
        [TestCase(121, 15, 1)]
        public void FindGreatestCommonDivisor_WhenAorBAreNotEqual0_ShouldGetResult(int a, int b, int expected)
        {
            int actual = CyclesHelper.FindGreatestCommonDivisor(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-15, 0)]
        [TestCase(0, 10)]
        [TestCase(0, 0)]
        public void FindGreatestCommonDivisor_WhenAOrBAreEqual0_ShouldThrowArgumentException(int a, int b)
        {
            try
            {
                CyclesHelper.FindGreatestCommonDivisor(a, b);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(-27, -3)]
        [TestCase(-125, -5)]
        [TestCase(64, 4)]
        [TestCase(1, 1)]
        [TestCase(0, 0)]
        [TestCase(216, 6)]
        public void FindTheNumberUsingBinarySearchAlgorithm_WhenAIsCubeOfAnyInteger_ShouldGetResult(int a, int expected)
        {
            int actual = CyclesHelper.FindTheNumberUsingBinarySearchAlgorithm(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(12)]
        [TestCase(17)]
        [TestCase(-20)]
        [TestCase(-4)]
        public void FindTheNumberUsingBinarySearchAlgorithm_WhenAIsNotCubeOfAnyInteger_ShouldThrowArgumentException(int a)
        {
            try
            {
                CyclesHelper.FindTheNumberUsingBinarySearchAlgorithm(a);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(-25, 13)]
        [TestCase(14, 7)]
        [TestCase(64, 32)]
        [TestCase(1, 1)]
        [TestCase(0, 0)]
        [TestCase(-9, 5)]
        public void FindTheNumberOfOddDigitsInThisNumber_WhenAIsInteger_ShouldGetResult(int a, int expected)
        {
            int actual = CyclesHelper.FindTheNumberOfOddDigitsInThisNumber(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-25, -52)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(123456, 654321)]
        [TestCase(10101, 10101)]
        [TestCase(-273, -372)]
        [TestCase(-100, -1)]
        public void ReverseNumber_WhenNumberIsInteger_ShouldGetReversedNumber(int a, int expected)
        {
            int actual = CyclesHelper.ReverseNumber(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-25, -165, "YES")]
        [TestCase(0, 123, "NO")]
        [TestCase(1, 1, "YES")]
        [TestCase(1879, 2659, "YES")]
        [TestCase(1379, 2468, "NO")]
        [TestCase(-432, -273, "YES")]
        [TestCase(0, 0, "YES")]
        public void CheckRepeatedDigits_WhenNumberIsInteger_ShouldGetReversedNumber(int a, int b, string expected)
        {
            string actual = CyclesHelper.CheckRepeatedDigits(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}