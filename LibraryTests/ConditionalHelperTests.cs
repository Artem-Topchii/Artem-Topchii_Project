using Libraries;
using NUnit.Framework;
using System;

namespace LibraryTests
{
    public class ConditionalHelperTests
    {
        [TestCase(5, 2, 7)]
        [TestCase(-2, -2, 4)]
        [TestCase(-5, 18, -23)]
        [TestCase(7, 7, 49)]
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 1)]
        [TestCase(8, 9, -1)]
        public void CompareTwoNumbers_WhenAandBAreIntegers_ShouldGetResult(int a, int b, int expected)
        {
            int actual = ConditionalHelper.CompareTwoNumbers(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1, 1)]
        [TestCase(-2, 8, 2)]
        [TestCase(-12, -20, 3)]
        [TestCase(4, -15, 4)]

        public void DetermineQuater_WhenAorBAreNotEqualNull_ShouldGetQuater(int x, int y, int expected)
        {
            int actual = ConditionalHelper.DetermineQuater(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 0)]
        [TestCase(0, 8)]
        [TestCase(-14, 0)]
        [TestCase(0, -10)]
        [TestCase(0, 0)]
        public void DetermineQuater_WhenAorBAreEqualNull_ShouldThrowArgumentException(int x, int y)
        {
            try
            {
                ConditionalHelper.DetermineQuater(x, y);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(-8, 14, 5, -8, 5, 14)]
        [TestCase(0, -12, 4, -12, 0, 4)]
        [TestCase(8, 8, 4, 4, 8, 8)]
        [TestCase(-1, 0, 1, -1, 0, 1)]
        [TestCase(-10, -20, -5, -20, -10, -5)]
        [TestCase(3, 2, 0, 0, 2, 3)]
        [TestCase(15, 15, 15, 15, 15, 15)]
        public void SortAscending_WhenAandBAndCAreIntegers_ShouldGetSortedList(int a, int b, int c, int expectedA, int expectedB, int expectedC)
        {
            var actual = ConditionalHelper.SortAscending(a, b, c);
            var expected = (expectedA, expectedB, expectedC);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-8, 15, -7, 0.88f, 1)]
        [TestCase(2, 10, 2, -0.21f, -4.79f)]
        [TestCase(-4, 2, 0, 0, 0.5f)]
        [TestCase(1, 2, 1, -1, - 1)]
        [TestCase(1.25f, -5, 5, 2, 2)]
        [TestCase(15, -16, 4, 0.67f, 0.4f)]
        public void SolveQaudraticEquation_WhenDiscriminantIsNotNegative_ShouldGetResult(float a, float b, float c, float expectedX1, float expectedX2)
        {
            var actual = ConditionalHelper.SolveQaudraticEquation(a, b, c);
            var expected = (expectedX1, expectedX2);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-8, 0, -7)]
        [TestCase(2, 2, 2)]
        [TestCase(-10, 7, -8)]
        [TestCase(-1, -1, -1)]
        public void SolveQaudraticEquation_WhenDiscriminantIsNegative_ShouldThrowArgumentException(float a, float b, float c)
        {
            try
            {
                ConditionalHelper.SolveQaudraticEquation(a, b, c);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(10, "Ten")]
        [TestCase(11, "Eleven")]
        [TestCase(12, "Twelve")]
        [TestCase(13, "Thirteen")]
        [TestCase(14, "Fourteen")]
        [TestCase(15, "Fifteen")]
        [TestCase(16, "Sixteen")]
        [TestCase(17, "Seventeen")]
        [TestCase(18, "Eighteen")]
        [TestCase(19, "Nineteen")]
        [TestCase(20, "Twenty")]
        [TestCase(30, "Thirty")]
        [TestCase(40, "Fourty")]
        [TestCase(50, "Fifty")]
        [TestCase(60, "Sixty")]
        [TestCase(70, "Seventy")]
        [TestCase(80, "Eighty")]
        [TestCase(90, "Ninety")]
        [TestCase(24, "Twenty four")]
        [TestCase(52, "Fifty two")]
        [TestCase(49, "Fourty nine")]
        [TestCase(81, "Eighty one")]
        [TestCase(37, "Thirty seven")]
        [TestCase(73, "Seventy three")]
        [TestCase(96, "Ninety six")]
        [TestCase(68, "Sixty eight")]
        [TestCase(55, "Fifty five")]
        public void CapitalizateNumber_WhenNumberIsBetween10And99_ShouldGetLiteralValue(int number, string expected)
        {
            string actual = ConditionalHelper.CapitalizateNumber(number);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-8)]
        [TestCase(100)]
        [TestCase(0)]
        [TestCase(-50)]
        public void CapitalizateNumber_WhenNumberIsNotBetween10And99_ShouldThrowArgumentException(int number)
        {
            try
            {
                ConditionalHelper.CapitalizateNumber(number);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}