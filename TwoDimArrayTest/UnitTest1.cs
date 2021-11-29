using NUnit.Framework;
using System;
using TwoDimArrayHWLib;

namespace TwoDimArray_UnitTests
{
    public class Tests
    {
        [Test]
        public void GetMinElementIndex_WhenEmptyArrayPass_ShouldTrowArgumentException()
        {
            try
            {
                TDATaskLib.GetMinElementIndex(new int[,] { });
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void GetMinElementIndex_WhenNullArrayPass_ShouldTrowArgumentException()
        {
            try
            {
                TDATaskLib.GetMinElementIndex(null);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCaseSource(nameof(GetMinElementIndexCases))]
        public void GetMinElementIndex_ShouldGetMinIndexes(int[,] array, (int, int) expectedResult)
        {
            var actualResult = TDATaskLib.GetMinElementIndex(array);
            Assert.AreEqual(expectedResult, actualResult);
        }
        static object[] GetMinElementIndexCases =
        {
            new object [] {
                new int[,] {{ 1 },{ 2 } },
                (0,0)
            },
            new object [] {
                new int[,] { { 2 }, { 1}, { 3 } },
                (1,0)
            },
            new object [] {
                new int[,] { {  2, 3 , 1}, { 4, 5, 6 }, { 7, 8, 9 } },
                (0,2)
            },
            new object [] {
                new int[,] { { -3, 2, -4}, {6, 1, 5 }, { 7, -8, 9 } },
                (2,1)
            }
        };

        [Test]
        public void GetMaxElementIndex_WhenEmptyArrayPass_ShouldTrowArgumentException()
        {
            try
            {
                TDATaskLib.GetMaxElementIndex(new int[,] { });
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void GetMaxElementIndex_WhenNullArrayPass_ShouldTrowArgumentException()
        {
            try
            {
                TDATaskLib.GetMaxElementIndex(null);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCaseSource(nameof(GetMaxElementIndexCases))]
        public void GetMaxElementIndex_IfFilledArrayPassed_ShouldGetMaxIndexes(int[,] array, (int, int) expectedResult)
        {
            var actualResult = TDATaskLib.GetMaxElementIndex(array);
            Assert.AreEqual(expectedResult, actualResult);
        }
        static object[] GetMaxElementIndexCases =
        {
            new object [] {
                new int[,] { { 1 }, { 0 } },
                (0,0)
            },
            new object [] {
                new int[,] { { 2 }, { 1}, { 3 } },
                (2,0)
            },
            new object [] {
                new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
                (2,2)
            },
            new object [] {
                new int[,] { { -3, -2, 4}, {16, -1, 5 }, { 7, 8, -9 } },
                (1,0)
            }
        };

        [Test]
        public void GetMinElement_WhenEmptyArrayPass_ShouldTrowArgumentException()
        {
            try
            {
                TDATaskLib.GetMinElement(new int[,] { });
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void GetMinElement_WhenNullArrayPass_ShouldTrowArgumentException()
        {
            try
            {
                TDATaskLib.GetMinElement(null);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCaseSource(nameof(GetMinElementCases))]
        public void GetMinElement_ShouldGetMinElement(int[,] array, int expectedResult)
        {
            var actualResult = TDATaskLib.GetMinElement(array);
            Assert.AreEqual(expectedResult, actualResult);
        }
        static object[] GetMinElementCases =
        {
            new object [] {
                new int[,] {{ 1 }},
                1
            },
            new object [] {
                new int[,] { { 12 }, {6}, { 2 } },
                2
            },
            new object [] {
                new int[,] { { 12, 22, 23 }, { 41, 51, 61 }, { 7, 8, 9 } },
                7
            },
            new object [] {
                new int[,] { { -3, 2, -4}, {6, 1, 5 }, { 7, -8, 9 } },
                -8
            }
        };

        [Test]
        public void GetMaxElement_WhenNullArrayPass_SouldThrowArgumentException()
        {
            try
            {
                TDATaskLib.GetMaxElement(null);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void GetMaxElement_WhenEmptyArrayPassed_ShouldThrowArgumentException()
        {
            try
            {
                TDATaskLib.GetMaxElement(new int[,] { });
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCaseSource(nameof(GetMaxElementCases))]
        public void GetMaxElement_ShouldGetMaxElement(int[,] array, int expectedResult)
        {
            var actualResult = TDATaskLib.GetMaxElement(array);
            Assert.AreEqual(expectedResult, actualResult);
        }
        static object[] GetMaxElementCases =
        {
            new object [] {
                new int[,] {{ 1 }},
                1
            },
            new object [] {
                new int[,] { { 2 }, { 1}, { 3 } },
                3
            },
            new object [] {
                new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
                9
            },
            new object [] {
                new int[,] { { -3, 2, -4}, {6, 1, 15 }, { 7, -8, 9 } },
                15
            }
        };

        [Test]
        public void MainDiagonalSwap_WhenNullArrayPass_SouldThrowArgumentException()
        {
            try
            {
                TDATaskLib.MainDiagonalSwap(null);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCaseSource(nameof(MainDiagonalSwapCasesArgumentException))]
        public void MainDiagonalSwap_WhenEmptyArrayPassed_ShouldThrowArgumentException(int[,] array, string ex)
        {
            try
            {
                TDATaskLib.MainDiagonalSwap(array);
            }
            catch (ArgumentException ex1)
            {
                Assert.AreEqual(ex, ex1.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }
        static object[] MainDiagonalSwapCasesArgumentException =
        {
            new object[] {
                new int[,] { { 1}, { 2 }, { 3 } },
                "Array is not square. Diagonal Swap impossible"
            },
            new object[] {
                new int[,] { { 1, 2 }, { 2, 3}, { 3, 4 } },
                "Array is not square. Diagonal Swap impossible"
            }
        };

        [TestCaseSource(nameof(MainDiagonalSwapCases))]
        public void MainDiagonalSwap_ShouldReturnMainDiagonalSwap(int[,] array, int[,] expectedResult)
        {
            TDATaskLib.MainDiagonalSwap(array);
            Assert.AreEqual(expectedResult, array);
        }
        static object[] MainDiagonalSwapCases =
        {
            new object [] {
                new int[,] {{ 1 }},
              new int[,] {{ 1 }}
            },
            new object [] {
                new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
                new int[,] { { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 } },
            },
            new object [] {
                new int[,] { { 1, 0, 0}, {0, 1, 0 }, { 0, 0, 1 } },
                new int[,] { { 1, 0, 0}, {0, 1, 0 }, { 0, 0, 1 } },
            },
                new object [] {
                new int[,] { { 1, -1, 0}, {0, 1, -1 }, { -1, 0, 1 } },
                new int[,] { { 1, 0, -1}, {-1, 1, 0 }, { 0, -1, 1 } },
            }
        };

        [Test]
        public void NumMaxInNeighbourElements_WhenNullArrayPass_SouldThrowArgumentException()
        {
            try
            {
                TDATaskLib.NumMaxInNeighbourElements(null);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void NumMaxInNeighbourElements_WhenEmptyArrayPass_SouldThrowArgumentException()
        {
            try
            {
                TDATaskLib.NumMaxInNeighbourElements(new int[,] { });
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Array is empty", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCaseSource(nameof(NumMaxInNeighbourElementsCases))]
        public void NumMaxInNeighbourElements_ShouldReturnNumMaxInNeighbourElements(int[,] array, int expectedResult)
        {
            var actualResult = TDATaskLib.NumMaxInNeighbourElements(array);
            Assert.AreEqual(expectedResult, actualResult);
        }
        static object[] NumMaxInNeighbourElementsCases =
        {
            new object [] {
                new int[,] {{ 1 }},
                1
            },
            new object [] {
                new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
                1
            },
            new object [] {
                new int[,] { { 1, 0, 0}, {0, 1, 0 }, { 0, 0, 1 } },
                3
            },
                new object [] {
                new int[,] { { 4, -1, 0}, {0, 1, 5 }, { -1,7, 1 } },
                3
            }
        };
    }
}