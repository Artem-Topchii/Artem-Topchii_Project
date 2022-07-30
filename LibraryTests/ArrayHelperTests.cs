using NUnit.Framework;
using Libraries;
using System;

namespace LibraryTests
{
    public class ArrayHelperTests
    {
        [TestCase(new[] { 17, -4, 0, 1236 }, -4)]
        [TestCase(new[] { 0 }, 0)]
        [TestCase(new[] { -1, -1, 0, 1 }, -1)]
        [TestCase(new[] { -18, -20, -1, 0, -18, -49, 57 }, -49)]
        [TestCase(new[] { 1, 1, 1 }, 1)]
        [TestCase(new[] { 13, 7, 105, 28, 34, 5, 1, 1, 48 }, 1)]
        [TestCase(new[] { -1, 1, 0, -5, -48, 125, 0, 0, 0, 86, 100 }, -48)]
        [TestCase(new[] { 0, 0, 0 }, 0)]
        [TestCase(new[] { -2, 2, -1, 1, 0 }, -2)]
        [TestCase(new[] { 100 }, 100)]
        public void FindTheMinimumValue_WhenArrayIsNotEmptyOrNull_ShouldGetMinimunValue(int [] array, int expected)
        {
            int actual = ArrayHelper.FindTheMinimumValue(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 17, -4, 0, 1236 }, 1236)]
        [TestCase(new[] { 0 }, 0)]
        [TestCase(new[] { -1, -1, 0, 1 }, 1)]
        [TestCase(new[] { -18, -20, -1, 0, -18, -49, 57 }, 57)]
        [TestCase(new[] { 1, 1, 1 }, 1)]
        [TestCase(new[] { 13, 7, 105, 28, 34, 5, 1, 1, 48 }, 105)]
        [TestCase(new[] { -1, 1, 0, -5, -48, 125, 0, 0, 0, 86, 100 }, 125)]
        [TestCase(new[] { 0, 0, 0 }, 0)]
        [TestCase(new[] { -2, 2, -1, 1, 0 }, 2)]
        [TestCase(new[] { 100 }, 100)]
        public void FindTheMaximumValue_WhenArrayIsNotEmptyOrNull_ShouldGetMaximumValue(int[] array, int expected)
        {
            int actual = ArrayHelper.FindTheMaximumValue(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 17, -4, 0, 1236 }, 1)]
        [TestCase(new[] { 0 }, 0)]
        [TestCase(new[] { -1, -1, 0, 1 }, 0)]
        [TestCase(new[] { -18, -20, -1, 0, -18, -49, 57 }, 5)]
        [TestCase(new[] { 1, 1, 1 }, 0)]
        [TestCase(new[] { 13, 7, 105, 28, 34, 5, 1, 1, 48 }, 6)]
        [TestCase(new[] { -1, 1, 0, -5, -48, 125, 0, 0, 0, 86, 100 }, 4)]
        [TestCase(new[] { 0, 0, 0 }, 0)]
        [TestCase(new[] { -2, 2, -1, 1, 0 }, 0)]
        [TestCase(new[] { 100 }, 0)]
        public void FindTheMinimumValueIndex_WhenArrayIsNotEmptyOrNull_ShouldGetMinimumValueIndex(int[] array, int expected)
        {
            int actual = ArrayHelper.FindTheMinimumValueIndex(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        [TestCase(new int [0] { })]
        public void FindTheMinimumValueIndex_WhenArrayIsEmptyOrNull_ShouldThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ArrayHelper.FindTheMinimumValueIndex(array);
            });
        }

        [TestCase(new[] { 17, -4, 0, 1236 }, 3)]
        [TestCase(new[] { 0 }, 0)]
        [TestCase(new[] { -1, -1, 0, 1 }, 3)]
        [TestCase(new[] { -18, -20, -1, 0, -18, -49, 57 }, 6)]
        [TestCase(new[] { 1, 1, 1 }, 0)]
        [TestCase(new[] { 13, 7, 105, 28, 34, 5, 1, 1, 48 }, 2)]
        [TestCase(new[] { -1, 1, 0, -5, -48, 125, 0, 0, 0, 86, 100 }, 5)]
        [TestCase(new[] { 0, 0, 0 }, 0)]
        [TestCase(new[] { -2, 2, -1, 1, 0 }, 1)]
        [TestCase(new[] { 100 }, 0)]
        public void FindTheMaximumValueIndex_WhenArrayIsNotEmptyOrNull_ShouldGetMaximumValueIndex(int[] array, int expected)
        {
            int actual = ArrayHelper.FindTheMaximumValueIndex(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        [TestCase(new int[0] { })]
        public void FindTheMaximumValueIndex_WhenArrayIsEmptyOrNull_ShouldThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ArrayHelper.FindTheMaximumValueIndex(array);
            });
        }

        [TestCase(new int[0] { }, 0)]
        [TestCase(new[] { 0, -28 }, -28)]
        [TestCase(new[] { 17, -4, 0, 1236 }, 1232)]
        [TestCase(new[] { 0 }, 0)]
        [TestCase(new[] { -1, -1, 0, 1 }, 0)]
        [TestCase(new[] { -18, -20, -1, 0, -18, -49, 57 }, -69)]
        [TestCase(new[] { 1, 1, 1 }, 1)]
        [TestCase(new[] { 13, 7, 105, 28, 34, 5, 1, 1, 48 }, 41)]
        [TestCase(new[] { -1, 1, 0, -5, -48, 125, 0, 0, 0, 86, 100 }, 207)]
        [TestCase(new[] { 0, 0, 0 }, 0)]
        [TestCase(new[] { -2, 2, -1, 1, 0 }, 3)]
        [TestCase(new[] { 100 }, 0)]
        public void SumOfArrayElementsWithOddIndices_WhenArrayIsNotNull_ShouldGetSumOfElementsWithOddIndices(int[] array, int expected)
        {
            int actual = ArrayHelper.SumOfArrayElementsWithOddIndices(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void SumOfArrayElementsWithOddIndices_WhenArrayIsNull_ShouldThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ArrayHelper.SumOfArrayElementsWithOddIndices(array);
            });
        }

        [TestCase(new int[0] { }, new int[0] { })]
        [TestCase(new[] { 0, -28 }, new[] { -28, 0 })]
        [TestCase(new[] { 17, -4, 0, 1236 }, new[] { 1236, 0, -4, 17 })]
        [TestCase(new[] { 0 }, new[] { 0 })]
        [TestCase(new[] { -1, -1, 0, 1 }, new[] { 1, 0, -1, -1 })]
        [TestCase(new[] { -18, -20, -1, 0, -18, -49, 57 }, new[] { 57, -49, -18, 0, -1, -20, -18 })]
        [TestCase(new[] { 1, 1, 1 }, new[] { 1, 1, 1 })]
        [TestCase(new[] { 13, 7, 105, 28, 34, 5, 1, 1, 48 }, new[] { 48, 1, 1, 5, 34, 28, 105, 7, 13 })]
        [TestCase(new[] { -1, 1, 0, -5, -48, 125, 0, 0, 0, 86, 100 }, new[] { 100, 86, 0, 0, 0, 125, -48, -5, 0, 1, -1 })]
        [TestCase(new[] { 0, 0, 0 }, new[] { 0, 0, 0 })]
        [TestCase(new[] { -2, 2, -1, 1, 0 }, new[] { 0, 1, -1, 2, -2 })]
        [TestCase(new[] { 100 }, new[] { 100 })]
        public void ReverseArray_WhenArrayIsNotNull_ShouldGetReversedArray(int[] array, int [] expected)
        {
            var actual = ArrayHelper.ReverseArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void ReverseArray_WhenArrayIsNull_ShouldThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ArrayHelper.ReverseArray(array);
            });
        }

        [TestCase(new int[0] { }, 0)]
        [TestCase(new[] { 0, -28 }, 0)]
        [TestCase(new[] { 17, -4, 0, 1236 }, 1)]
        [TestCase(new[] { 0 }, 0)]
        [TestCase(new[] { -1, -1, 0, 1 }, 3)]
        [TestCase(new[] { -18, -20, -1, 0, -18, -49, 57 }, 3)]
        [TestCase(new[] { 1, 1, 1 }, 3)]
        [TestCase(new[] { 13, 7, 105, 28, 34, 5, 1, 1, 48 }, 6)]
        [TestCase(new[] { -1, 1, 0, -5, -48, 125, 0, 0, 0, 86, 100 }, 4)]
        [TestCase(new[] { 0, 0, 0 }, 0)]
        [TestCase(new[] { -2, 2, -1, 1, 0 }, 2)]
        [TestCase(new[] { 100 }, 0)]
        public void CountOfOddArrayElements_WhenArrayIsNotNull_CountOfOddElements(int[] array, int expected)
        {
            int actual = ArrayHelper.CountOfOddArrayElements(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void CountOfOddArrayElements_WhenArrayIsNull_ShouldThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ArrayHelper.CountOfOddArrayElements(array);
            });
        }

        [TestCase(new int[0] { }, new int[0] { })]
        [TestCase(new[] { 0, -28 }, new[] { -28, 0 })]
        [TestCase(new[] { 17, -4, 0, 1236 }, new[] { 0, 1236, 17, -4 })]
        [TestCase(new[] { 0 }, new[] { 0 })]
        [TestCase(new[] { -1, -1, 0, 1 }, new[] { 0, 1, -1, -1 })]
        [TestCase(new[] { -18, -20, -1, 0, -18, -49, 57 }, new[] { -18, -49, 57, 0, -18, -20, -1 })]
        [TestCase(new[] { 1, 1, 1 }, new[] { 1, 1, 1 })]
        [TestCase(new[] { 13, 7, 105, 28, 34, 5, 1, 1, 48 }, new[] { 5, 1, 1, 48, 34, 13, 7, 105, 28 })]
        [TestCase(new[] { -1, 1, 0, -5, -48, 125, 0, 0, 0, 86, 100 }, new[] { 0, 0, 0, 86, 100, 125, -1, 1, 0, -5, -48 })]
        [TestCase(new[] { 0, 0, 0 }, new[] { 0, 0, 0 })]
        [TestCase(new[] { -2, 2, -1, 1, 0 }, new[] { 1, 0, -1, -2, 2 })]
        [TestCase(new[] { 100 }, new[] { 100 })]
        public void SwapTheFirstAndSecondHalfOfTheArray_WhenArrayIsNotNull_ShouldGetSwappedArray(int[] array, int[] expected)
        {
            var actual = ArrayHelper.SwapTheFirstAndSecondHalfOfTheArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void SwapTheFirstAndSecondHalfOfTheArray_WhenArrayIsNull_ShouldThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ArrayHelper.SwapTheFirstAndSecondHalfOfTheArray(array);
            });
        }

        [TestCase(new int[0] { }, new int[0] { })]
        [TestCase(new[] { 0, -28 }, new[] { -28, 0 })]
        [TestCase(new[] { 17, -4, 0, 1236 }, new[] { -4, 0, 17, 1236 })]
        [TestCase(new[] { 0 }, new[] { 0 })]
        [TestCase(new[] { -1, -1, 0, 1 }, new[] { -1, -1, 0, 1 })]
        [TestCase(new[] { -18, -20, -1, 0, -18, -49, 57 }, new[] { -49, -20, -18, -18, -1, 0, 57 })]
        [TestCase(new[] { 1, 1, 1 }, new[] { 1, 1, 1 })]
        [TestCase(new[] { 13, 7, 105, 28, 34, 5, 1, 1, 48 }, new[] { 1, 1, 5, 7, 13, 28, 34, 48, 105 })]
        [TestCase(new[] { -1, 1, 0, -5, -48, 125, 0, 0, 0, 86, 100 }, new[] { -48, -5, -1, 0, 0, 0, 0, 1, 86, 100, 125 })]
        [TestCase(new[] { 0, 0, 0 }, new[] { 0, 0, 0 })]
        [TestCase(new[] { -2, 2, -1, 1, 0 }, new[] { -2, -1, 0, 1, 2 })]
        [TestCase(new[] { 100 }, new[] { 100 })]
        public void SortTheArrayInAscendingOrder_WhenArrayIsNotNull_ShouldGetSortedArray(int[] array, int[] expected)
        {
            var actual = ArrayHelper.SortTheArrayInAscendingOrder(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void SortTheArrayInAscendingOrder_WhenArrayIsNull_ShouldThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ArrayHelper.SortTheArrayInAscendingOrder(array);
            });
        }

        [TestCase(new int[0] { }, new int[0] { })]
        [TestCase(new[] { 0, -28 }, new[] { 0, -28 })]
        [TestCase(new[] { 17, -4, 0, 1236 }, new[] { 1236, 17, 0, -4 })]
        [TestCase(new[] { 0 }, new[] { 0 })]
        [TestCase(new[] { -1, -1, 0, 1 }, new[] { 1, 0, -1, -1 })]
        [TestCase(new[] { -18, -20, -1, 0, -18, -49, 57 }, new[] { 57, 0, -1, -18, -18, -20, -49 })]
        [TestCase(new[] { 1, 1, 1 }, new[] { 1, 1, 1 })]
        [TestCase(new[] { 13, 7, 105, 28, 34, 5, 1, 1, 48 }, new[] { 105, 48, 34, 28, 13, 7, 5, 1, 1 })]
        [TestCase(new[] { -1, 1, 0, -5, -48, 125, 0, 0, 0, 86, 100 }, new[] { 125, 100, 86, 1, 0, 0, 0, 0, -1, -5, -48 })]
        [TestCase(new[] { 0, 0, 0 }, new[] { 0, 0, 0 })]
        [TestCase(new[] { -2, 2, -1, 1, 0 }, new[] { 2, 1, 0, -1, -2 })]
        [TestCase(new[] { 100 }, new[] { 100 })]
        public void SortTheArrayInDescendingOrder_WhenArrayIsNotNull_ShouldGetSortedArray(int[] array, int[] expected)
        {
            var actual = ArrayHelper.SortTheArrayInDescendingOrder(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void SortTheArrayInDescendingOrder_WhenArrayIsNull_ShouldThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ArrayHelper.SortTheArrayInDescendingOrder(array);
            });
        }
    }
}