using System;

namespace Interview.RotateMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list1 = new int[4] { 1, 2, 3, 4 };
            int[] list2 = new int[4] { 5, 6, 7, 8 };
            int[] list3 = new int[4] { 9, 10, 11, 12 };
            int[] list4 = new int[4] { 13, 14, 15, 16 };

            int[][] matrix = new int[][] { list1, list2, list3, list4 };

            RotateLeft(matrix);

            RotateRight(matrix);
        }


        private static void RotateLeft(int[][] matrix)
        {
            int n = matrix.Length;

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = i; j < n - 1 - i; j++)
                {
                    int temp = matrix[i][j];

                    matrix[i][j] = matrix[j][n - 1 - i];

                    matrix[j][n - 1 - i] = matrix[n - 1 - i][n - 1 - j];

                    matrix[n - 1 - i][n - 1 - j] = matrix[n - 1 - j][i];

                    matrix[n - 1 - j][i] = temp;
                }
            }
        }

        private static void RotateRight(int[][] matrix)
        {
            int n = matrix.Length;

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = i; j < n - 1 - i; j++)
                {
                    int temp = matrix[i][j];

                    matrix[i][j] = matrix[n - 1 - j][i];

                    matrix[n - 1 - j][i] = matrix[n - 1 - i][n - 1 - j];

                    matrix[n - 1 - i][n - 1 - j] = matrix[j][n - 1 - i];

                    matrix[j][n - 1 - i] = temp;
                }
            }
        }
    }
}
