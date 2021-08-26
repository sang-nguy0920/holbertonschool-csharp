using System;
using System.Windows;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrixOne2d =  { { 1, 2 }, { 3, 4 } };
        // radians? degrees? how?
        double angle = -1.57;
        double[,] res2d;

        res2d = MatrixMath.Rotate2D(matrixOne2d, angle);

        for (int i = 0; i < res2d.GetLength(0); i++)
        {
            for (int j = 0; j < res2d.GetLength(1); j++)
            {
                Console.Write(res2d[i, j]);
                if (j != res2d.GetLength(1) - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
