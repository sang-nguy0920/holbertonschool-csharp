using System;

namespace MyMath
{
    /// <summary>Public Matrix class.</summary>
    public class Matrix
    {
        /// <summary>Public constructor for Matrix class.</summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
            {
                return null;
            }

            int [,] temp = matrix;
            int row = temp.GetLength(0);
            int col = temp.GetLength(1);

            try
            {
                for (int x = 0; x < row; x++)
                {
                    for (int y = 0; y < col; y++)
                    {
                        temp[x, y] /= num;
                    }
                }

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            return (temp);
        }
    }
}
