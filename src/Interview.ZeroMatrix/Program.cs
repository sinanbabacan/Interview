using System;

namespace Interview.ZeroMatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] list1 = new int[4] { 1, 2, 3, 4 };
            int[] list2 = new int[4] { 5, 6, 0, 8 };
            int[] list3 = new int[4] { 0, 10, 11, 12 };

            int[][] matrix = new int[][] { list1, list2, list3 };

            ZeroReplacement(matrix);
        }

        private static void ZeroReplacement(int[][] matrix)
        {
            int[] rows = new int[matrix.Length];
            int[] columns = new int[matrix[0].Length];

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        rows[i] = 1;
                        columns[j] = 1;
                    }
                }
            }

            for (int i = 0; i < rows.Length; i++)
            {
                if (rows[i] == 1)
                {
                    for (int j = 0; j < columns.Length; j++)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            for (int j = 0; j < columns.Length; j++)
            {
                if (columns[j] == 1)
                {
                    for (int i = 0; i < rows.Length; i++)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
        }
    }
}
