using System;

namespace TwoDimArrayHWLib
{
    public class TDATaskLib
    {
        
        public static (int, int) GetMinElementIndex(int[,] array)
        {
            if (array == null || array.GetLength(0) == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int ind1 = 0;
            int ind2 = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[ind1, ind2] > array[i, j])
                    {
                        ind1 = i;
                        ind2 = j;
                    }
                }
            }

            return (ind1, ind2);
        }

        public static (int, int) GetMaxElementIndex(int[,] array)
        {
            if (array == null || array.GetLength(0) == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int ind1 = 0;
            int ind2 = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[ind1, ind2] < array[i, j])
                    {
                        ind1 = i;
                        ind2 = j;
                    }
                }
            }

            return (ind1, ind2);
        }

        public static int GetMinElement(int[,] array)
        {
            if (array == null || array.GetLength(0) == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            var Index = GetMinElementIndex(array);
            return array[Index.Item1, Index.Item2];
        }

        public static int GetMaxElement(int[,] array)
        {
            if (array == null || array.GetLength(0) == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            var Index = GetMaxElementIndex(array);
            return array[Index.Item1, Index.Item2];
        }

        public static void MainDiagonalSwap(int[,] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Array is empty");
            }
            if (array.GetLength(0) != array.GetLength(1))
            {
                throw new ArgumentException("Array is not square. Diagonal Swap impossible");
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = i + 1; j < array.GetLength(1); j++)
                {
                    Swap(ref array[i, j], ref array[j, i]);
                }
            }
        }

        public static int NumMaxInNeighbourElements(int[,] array)
        {
            if (array == null || array.GetLength(0) == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int result = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    bool ind = true;
                    if (i > 0)
                    {
                        ind = (array[i, j] > array[i - 1, j]);
                    }
                    if (i + 1 < array.GetLength(0))
                    {
                        ind = ind && (array[i, j] > array[i + 1, j]);
                    }
                    if (j > 0)
                    {
                        ind = ind && (array[i, j] > array[i, j - 1]);
                    }
                    if (j + 1 < array.GetLength(1))
                    {
                        ind = ind && (array[i, j] > array[i, j + 1]);
                    }

                    if (ind)
                    {
                        ++result;
                        Console.WriteLine($"{i} , { j}");
                    }
                }
            }
            return result;

        }
        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}