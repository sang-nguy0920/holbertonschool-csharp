using System;
using System.Windows;
class Program
{
    static void Main(string[] args)
    {
        double[,] matrix2d1 = { { 2, 3 }, { -1, 0 } };
        double[,] matrix2d2 = { { 1, 7 }, { -8, -2 } };
        double[,] matrix3d1 = { { 14, -3, 0 }, { -11, -5, 3 }, { 2, -9, 13 } };
        double[,] matrix3d2 = { { 6, 16, 21 }, { 5, 2, 0 }, { 1, 3, 7 } };
        double[,] result2d;
        double[,] result3d;

        result2d = MatrixMath.Add(matrix2d1, matrix2d2);
        result3d = MatrixMath.Add(matrix3d1, matrix3d2);

        for (int i = 0; i < result2d.GetLength(0); i++)
        {
            for (int j = 0; j < result2d.GetLength(1); j++)
            {
                Console.Write(result2d[i, j]);
                if (j != result2d.GetLength(1) - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < result3d.GetLength(0); i++)
        {
            for (int j = 0; j < result3d.GetLength(1); j++)
            {
                Console.Write(result3d[i, j]);
                if (j != result3d.GetLength(1) - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
