using NUnit.Framework;
using Libraries;
using System;

namespace LibraryTests
{
    public class MultiDimensionalArrayHelperTests
    {
        public static object[] TestCaseWhenArrayIsEmpty =
{
            new object[]
            {
                new int [0, 0]
            },
        };

        public static object[] TestCaseForFindTheMinimumElementOfTheArray =
{
            new object[]
            {
                new[,]
                {
                    { 0, 28 },
                    { 28, 0 }
                },
                0
            },

            new object[]
            {
                new[,]
                {
                    { 19, -9, 105 },
                    { 0, 1236, -16 }
                },
                -16
            },

            new object[]
            {
                new[,]
                {
                    { 0 },
                },
                0
            },

            new object[]
            {
                new[,]
                {
                    { -1, -1, -1 },
                    { -2, -2, -2 },
                    { -3, -3, -3 },
                    { -3, -3, -3 },
                    { -2, -2, -2 },
                    { -1, -1, -1 }
                },
                -3
            },

            new object[]
            {
                new[,]
                {
                    { 0, 1, 0, 1 },
                    { -8, 12, 47, -5 },
                    { 0, 0, 0, 0 },
                    { -1, -2, -3, -2 }
                },
                -8
            },

            new object[]
            {
                new[,]
                {
                    { 1, 7, -18, 0, 0, -18, 52, -20, -1 }
                },
                -20
            },

            new object[]
            {
                new[,]
                {
                    { 7 },
                    { 4 },
                    { -10 },
                    { 105 },
                    { 125 },
                    { -89 },
                    { 56 },
                    { -64 },
                    { 0 }
                },
                -89
            },

            new object[]
            {
                new[,]
                {
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 }
                },
                0
            },

            new object[]
            {
                new[,]
                {
                    { 13, 60, 69, -60, 77, 92, -44, -49, 56 },
                    { 66, 15, -95, -94, 70, 65, 43, -17, 66  },
                    { 9, 40, 12, -82, -17, -42, -56, -12, 20  },
                    { -36, 25, 59, -64, 72, -66, 0, 63, 38  },
                    { -7, 70, 46, -93, 42, -7, -46, 28, -73  },
                    { 23, -14, 44, -97, 73, -91, 10, -75, 7  },
                    { 98, -5, -24, 11, 95, -11, -28, 91, 25  },
                    { 96, 30, 42, 71, 5, -93, -74, -50, 13  },
                    { -81, 1, 97, -81, 64, 55, -70, 21, -99  },
                    { 75, -40, 52, 49, 25, 47, 26, 1, -32  }
                },
                -99
            },
        };

        [TestCaseSource(nameof(TestCaseForFindTheMinimumElementOfTheArray))]
        public void FindTheMinimumElementOfTheArray_WhenArrayIsNotEmptyOrNull_ShouldGetMinimumValue(int[,] matrix, int expected)
        {
            int actual = MultiDimensionalArrayHelper.FindTheMinimumElementOfTheArray(matrix);

            Assert.AreEqual(expected, actual);
        }

        public static object[] TestCaseForFindTheMaximumElementOfTheArray =
{
            new object[]
            {
                new[,]
                {
                    { 0, 28 },
                    { 28, 0 }
                },
                28
            },

            new object[]
            {
                new[,]
                {
                    { 19, -9, 105 },
                    { 0, 1236, -16 }
                },
                1236
            },

            new object[]
            {
                new[,]
                {
                    { 0 },
                },
                0
            },

            new object[]
            {
                new[,]
                {
                    { -1, -1, -1 },
                    { -2, -2, -2 },
                    { -3, -3, -3 },
                    { -3, -3, -3 },
                    { -2, -2, -2 },
                    { -1, -1, -1 }
                },
                -1
            },

            new object[]
            {
                new[,]
                {
                    { 0, 1, 0, 1 },
                    { -8, 12, 47, -5 },
                    { 0, 0, 0, 0 },
                    { -1, -2, -3, -2 }
                },
                47
            },

            new object[]
            {
                new[,]
                {
                    { 1, 7, -18, 0, 0, -18, 52, -20, -1 }
                },
                52
            },

            new object[]
            {
                new[,]
                {
                    { 7 },
                    { 4 },
                    { -10 },
                    { 105 },
                    { 125 },
                    { -89 },
                    { 56 },
                    { -64 },
                    { 0 }
                },
                125
            },

            new object[]
            {
                new[,]
                {
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 }
                },
                0
            },

            new object[]
            {
                new[,]
                {
                    { 13, 60, 69, -60, 77, 92, -44, -49, 56 },
                    { 66, 15, -95, -94, 70, 65, 43, -17, 66  },
                    { 9, 40, 12, -82, -17, -42, -56, -12, 20  },
                    { -36, 25, 59, -64, 72, -66, 0, 63, 38  },
                    { -7, 70, 46, -93, 42, -7, -46, 28, -73  },
                    { 23, -14, 44, -97, 73, -91, 10, -75, 7  },
                    { 98, -5, -24, 11, 95, -11, -28, 91, 25  },
                    { 96, 30, 42, 71, 5, -93, -74, -50, 13  },
                    { -81, 1, 97, -81, 64, 55, -70, 21, -99  },
                    { 75, -40, 52, 49, 25, 47, 26, 1, -32  }
                },
                98
            },
        };

        [TestCaseSource(nameof(TestCaseForFindTheMaximumElementOfTheArray))]
        public void FindTheMinimumElementOfTheArray_WhenArrayIsNotEmptyOrNull_ShouldGetMaximumValue(int[,] matrix, int expected)
        {
            int actual = MultiDimensionalArrayHelper.FindTheMaximumElementOfTheArray(matrix);

            Assert.AreEqual(expected, actual);
        }

        public static object[] TestCaseForFindTheIndexOfTheMinimumElementOfTheArray =
        {
            new object[]
            {
                new[,]
                {
                    { 0, 28 },
                    { 28, 0 }
                },
                0, 0
            },

            new object[]
            {
                new[,]
                {
                    { 19, -9, 105 },
                    { 0, 1236, -16 }
                },
                1, 2
            },

            new object[]
            {
                new[,]
                {
                    { 0 },
                },
                0, 0
            },

            new object[]
            {
                new[,]
                {
                    { -1, -1, -1 },
                    { -2, -2, -2 },
                    { -3, -3, -3 },
                    { -3, -3, -3 },
                    { -2, -2, -2 },
                    { -1, -1, -1 }
                },
                2, 0
            },

            new object[]
            {
                new[,]
                {
                    { 0, 1, 0, 1 },
                    { -8, 12, 47, -5 },
                    { 0, 0, 0, 0 },
                    { -1, -2, -3, -2 }
                },
                1, 0
            },

            new object[]
            {
                new[,]
                {
                    { 1, 7, -18, 0, 0, -18, 52, -20, -1 }
                },
                0, 7
            },

            new object[]
            {
                new[,]
                {
                    { 7 },
                    { 4 },
                    { -10 },
                    { 105 },
                    { 125 },
                    { -89 },
                    { 56 },
                    { -64 },
                    { 0 }
                },
                5, 0
            },

            new object[]
            {
                new[,]
                {
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 }
                },
                0, 0
            },

            new object[]
            {
                new[,]
                {
                    { 13, 60, 69, -60, 77, 92, -44, -49, 56 },
                    { 66, 15, -95, -94, 70, 65, 43, -17, 66  },
                    { 9, 40, 12, -82, -17, -42, -56, -12, 20  },
                    { -36, 25, 59, -64, 72, -66, 0, 63, 38  },
                    { -7, 70, 46, -93, 42, -7, -46, 28, -73  },
                    { 23, -14, 44, -97, 73, -91, 10, -75, 7  },
                    { 98, -5, -24, 11, 95, -11, -28, 91, 25  },
                    { 96, 30, 42, 71, 5, -93, -74, -50, 13  },
                    { -81, 1, 97, -81, 64, 55, -70, 21, -99  },
                    { 75, -40, 52, 49, 25, 47, 26, 1, -32  }
                },
                8, 8
            },
        };

        [TestCaseSource(nameof(TestCaseForFindTheIndexOfTheMinimumElementOfTheArray))]
        public void FindTheIndexOfTheMinimumElementOfTheArray_WhenArrayIsNotEmptyOrNull_ShouldGetMinimumValueIndex(int [,] matrix, int expectedA, int expectedB)
        {
            var actual = MultiDimensionalArrayHelper.FindTheIndexOfTheMinimumElementOfTheArray(matrix);
            var expected = (expectedA, expectedB);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        [TestCaseSource(nameof(TestCaseWhenArrayIsEmpty))]
        public void FindTheIndexOfTheMinimumElementOfTheArray_WhenArrayIsEmptyOrNull_ShouldThrowArgumentException(int[,] matrix)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                MultiDimensionalArrayHelper.FindTheIndexOfTheMinimumElementOfTheArray(matrix);
            });
        }

        public static object[] TestCaseForFindTheIndexOfTheMaximumElementOfTheArray =
{
            new object[]
            {
                new[,]
                {
                    { 0, 28 },
                    { 28, 0 }
                },
                0, 1
            },

            new object[]
            {
                new[,]
                {
                    { 19, -9, 105 },
                    { 0, 1236, -16 }
                },
                1, 1
            },

            new object[]
            {
                new[,]
                {
                    { 0 },
                },
                0, 0
            },

            new object[]
            {
                new[,]
                {
                    { -1, -1, -1 },
                    { -2, -2, -2 },
                    { -3, -3, -3 },
                    { -3, -3, -3 },
                    { -2, -2, -2 },
                    { -1, -1, -1 }
                },
                0, 0
            },

            new object[]
            {
                new[,]
                {
                    { 0, 1, 0, 1 },
                    { -8, 12, 47, -5 },
                    { 0, 0, 0, 0 },
                    { -1, -2, -3, -2 }
                },
                1, 2
            },

            new object[]
            {
                new[,]
                {
                    { 1, 7, -18, 0, 0, -18, 52, -20, -1 }
                },
                0, 6
            },

            new object[]
            {
                new[,]
                {
                    { 7 },
                    { 4 },
                    { -10 },
                    { 105 },
                    { 125 },
                    { -89 },
                    { 56 },
                    { -64 },
                    { 0 }
                },
                4, 0
            },

            new object[]
            {
                new[,]
                {
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 }
                },
                0, 0
            },

            new object[]
            {
                new[,]
                {
                    { 13, 60, 69, -60, 77, 92, -44, -49, 56 },
                    { 66, 15, -95, -94, 70, 65, 43, -17, 66  },
                    { 9, 40, 12, -82, -17, -42, -56, -12, 20  },
                    { -36, 25, 59, -64, 72, -66, 0, 63, 38  },
                    { -7, 70, 46, -93, 42, -7, -46, 28, -73  },
                    { 23, -14, 44, -97, 73, -91, 10, -75, 7  },
                    { 98, -5, -24, 11, 95, -11, -28, 91, 25  },
                    { 96, 30, 42, 71, 5, -93, -74, -50, 13  },
                    { -81, 1, 97, -81, 64, 55, -70, 21, -99  },
                    { 75, -40, 52, 49, 25, 47, 26, 1, -32  }
                },
                6,0
            },
        };

        [TestCaseSource(nameof(TestCaseForFindTheIndexOfTheMaximumElementOfTheArray))]
        public void FindTheIndexOfTheMaximumElementOfTheArray_WhenArrayIsNotEmptyOrNull_ShouldGetMaximumValueIndex(int[,] matrix, int expectedA, int expectedB)
        {
            var actual = MultiDimensionalArrayHelper.FindTheIndexOfTheMaximumElementOfTheArray(matrix);
            var expected = (expectedA, expectedB);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        [TestCaseSource(nameof(TestCaseWhenArrayIsEmpty))]
        public void FindTheIndexOfTheMaximumElementOfTheArray_WhenArrayIsEmptyOrNull_ShouldThrowArgumentException(int[,] matrix)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                MultiDimensionalArrayHelper.FindTheIndexOfTheMaximumElementOfTheArray(matrix);
            });
        }

        public static object[] TestCaseForFindTheNumberOfElementsThatAreGreaterThanAllTheirNeighbors =
{
            new object[]
            {
                new int [0, 0],
                0
            },

            new object[]
            {
                new[,]
                {
                    { 0, 28 },
                    { 28, 0 }
                },
                0
            },

            new object[]
            {
                new[,]
                {
                    { 19, -9, 105 },
                    { 0, 1236, -16 }
                },
                1
            },

            new object[]
            {
                new[,]
                {
                    { 0 },
                },
                0
            },

            new object[]
            {
                new[,]
                {
                    { -1, -1, -1 },
                    { -2, -2, -2 },
                    { -3, -3, -3 },
                    { -3, -3, -3 },
                    { -2, -2, -2 },
                    { -1, -1, -1 }
                },
                0
            },

            new object[]
            {
                new[,]
                {
                    { 0, 1, 0, 1 },
                    { -8, 12, 47, -5 },
                    { 0, 0, 0, 0 },
                    { -1, -2, -3, -2 }
                },
                1
            },

            new object[]
            {
                new[,]
                {
                    { 1, 7, -18, 0, 0, -18, 52, -20, -1 }
                },
                3
            },

            new object[]
            {
                new[,]
                {
                    { 7 },
                    { 4 },
                    { -10 },
                    { 105 },
                    { 125 },
                    { -89 },
                    { 56 },
                    { -64 },
                    { 0 }
                },
                4
            },

            new object[]
            {
                new[,]
                {
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 }
                },
                0
            },

            new object[]
            {
                new[,]
                {
                    { 13, 60, 69, -60, 77, 92, -44, -49, 56 },
                    { 66, 15, -95, -94, 70, 65, 43, -17, 66  },
                    { 9, 40, 12, -82, -17, -42, -56, -12, 20  },
                    { -36, 25, 59, -64, 72, -66, 0, 63, 38  },
                    { -7, 70, 46, -93, 42, -7, -46, 28, -73  },
                    { 23, -14, 44, -97, 73, -91, 10, -75, 7  },
                    { 98, -5, -24, 11, 95, -11, -28, 91, 25  },
                    { 96, 30, 42, 71, 5, -93, -74, -50, 13  },
                    { -81, 1, 97, -81, 64, 55, -70, 21, -99  },
                    { 75, -40, 52, 49, 25, 47, 26, 1, -32  }
                },
                12
            },
        };

        [TestCaseSource(nameof(TestCaseForFindTheNumberOfElementsThatAreGreaterThanAllTheirNeighbors))]
        public void FindTheNumberOfElementsThatAreGreaterThanAllTheirNeighbors_WhenArrayIsNotNull_ShouldGetNumberOfElement(int[,] matrix, int expected)
        {
            int actual = MultiDimensionalArrayHelper.FindTheNumberOfElementsThatAreGreaterThanAllTheirNeighbors(matrix);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void FindTheNumberOfElementsThatAreGreaterThanAllTheirNeighbors_WhenArrayIsNull_ShouldThrowArgumentException(int[,] matrix)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                MultiDimensionalArrayHelper.FindTheNumberOfElementsThatAreGreaterThanAllTheirNeighbors(matrix);
            });
        }

        public static object[] TestCaseForFlipAnArrayAboutItsMainDiagonal =
{
            new object[]
            {
                new int [0, 0],
                new int [0, 0],
            },

            new object[]
            {
                new[,]
                {
                    { 0, 28 },
                    { 28, 0 }
                },
                new[,]
                {
                    { 0, 28 },
                    { 28, 0 }
                },
            },

            new object[]
            {
                new[,]
                {
                    { 19, -9, 105 },
                    { 0, 1236, -16 }
                },
                new[,]
                {
                    { 19, 0, 105 },
                    { -9, 1236, -16 }
                },
            },

            new object[]
            {
                new[,]
                {
                    { 0 },
                },
                new[,]
                {
                    { 0 },
                },
            },

            new object[]
            {
                new[,]
                {
                    { -1, -1, -1 },
                    { -2, -2, -2 },
                    { -3, -3, -3 },
                    { -3, -3, -3 },
                    { -2, -2, -2 },
                    { -1, -1, -1 }
                },
                new[,]
                {
                    { -1, -2, -3 },
                    { -1, -2, -3 },
                    { -1, -2, -3 },
                    { -3, -3, -3 },
                    { -2, -2, -2 },
                    { -1, -1, -1 }
                },
            },

            new object[]
            {
                new[,]
                {
                    { 0, 1, 0, 1 },
                    { -8, 12, 47, -5 },
                    { 0, 0, 0, 0 },
                    { -1, -2, -3, -2 }
                },
                new[,]
                {
                    { 0, -8, 0, -1 },
                    { 1, 12, 0, -2 },
                    { 0, 47, 0, -3 },
                    { 1, -5, 0, -2 }
                },
            },

            new object[]
            {
                new[,]
                {
                    { 1, 7, -18, 0, 0, -18, 52, -20, -1 }
                },
                new[,]
                {
                    { 1, 7, -18, 0, 0, -18, 52, -20, -1 }
                },
            },

            new object[]
            {
                new[,]
                {
                    { 7 },
                    { 4 },
                    { -10 },
                    { 105 },
                    { 125 },
                    { -89 },
                    { 56 },
                    { -64 },
                    { 0 }
                },
                new[,]
                {
                    { 7 },
                    { 4 },
                    { -10 },
                    { 105 },
                    { 125 },
                    { -89 },
                    { 56 },
                    { -64 },
                    { 0 }
                },
            },

            new object[]
            {
                new[,]
                {
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 }
                },
                new[,]
                {
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 }
                },
            },

            new object[]
            {
                new[,]
                {
                    { 13, 60, 69, -60, 77, 92, -44, -49, 56 },
                    { 66, 15, -95, -94, 70, 65, 43, -17, 66  },
                    { 9, 40, 12, -82, -17, -42, -56, -12, 20  },
                    { -36, 25, 59, -64, 72, -66, 0, 63, 38  },
                    { -7, 70, 46, -93, 42, -7, -46, 28, -73  },
                    { 23, -14, 44, -97, 73, -91, 10, -75, 7  },
                    { 98, -5, -24, 11, 95, -11, -28, 91, 25  },
                    { 96, 30, 42, 71, 5, -93, -74, -50, 13  },
                    { -81, 1, 97, -81, 64, 55, -70, 21, -99  },
                    { 75, -40, 52, 49, 25, 47, 26, 1, -32  }
                },
                new[,]
                {
                    { 13, 66, 9, -36, -7, 23, 98, 96, -81 },
                    { 60, 15, 40, 25, 70, -14, -5, 30, 1  },
                    { 69, -95, 12, 59, 46, 44, -24, 42, 97  },
                    { -60, -94, -82, -64, -93, -97, 11, 71, -81  },
                    { 77, 70, -17, 72, 42, 73, 95, 5, 64  },
                    { 92, 65, -42, -66, -7, -91, -11, -93, 55  },
                    { -44, 43, -56, 0, -46, 10, -28, -74, -70  },
                    { -49, -17, -12, 63, 28, -75, 91, -50, 21  },
                    { 56, 66, 20, 38, -73, 7, 25, 13, -99  },
                    { 75, -40, 52, 49, 25, 47, 26, 1, -32  }
                },
            },
        };

        [TestCaseSource(nameof(TestCaseForFlipAnArrayAboutItsMainDiagonal))]
        public void FlipAnArrayAboutItsMainDiagonal_WhenArrayIsNotNull_ShoulFlippedMatrix(int[,] matrix, int[,] expected)
        {
            var actual = MultiDimensionalArrayHelper.FlipAnArrayAboutItsMainDiagonal(matrix);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void FlipAnArrayAboutItsMainDiagonal_WhenArrayIsNull_ShouldThrowArgumentException(int[,] matrix)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                MultiDimensionalArrayHelper.FlipAnArrayAboutItsMainDiagonal(matrix);
            });
        }
    }
}