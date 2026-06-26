using System;

namespace MyMath
{
    public class Matrix
    {
        public static int[,]? Divide(int[,]? matrix, int num)
        {
            // 1. Handle null matrix
            if (matrix == null)
                return null;

            // 2. Get dimensions
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // 3. Create the result matrix (same size)
            int[,] result = new int[rows, cols];

            // 4. Loop through each element and divide
            try
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        result[i, j] = matrix[i, j] / num;   // integer division
                    }
                }
                return result;
            }
            catch (DivideByZeroException)
            {
                // 5. If num is 0, print the message and return null
                Console.WriteLine("Num cannot be 0");
                return null;
            }
        }
    }
}
