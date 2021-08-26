using System;
using System.Collections.Generic;

/// <summary>Public MatrixMath class.</summary>
class MatrixMath
{
    /// <summary>rotates a square 2D matrix by a given angle</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] old = new double[,] {{-1}};
        double[,] twoD = new double [2,2];
        double[,] rotate = new double[2, 2] {{Math.Cos(angle), Math.Sin(angle)}, {-1 * Math.Sin(angle), Math.Cos(angle)}}; 
        int r = matrix.GetLength(0);
        int c = matrix.GetLength(1);

        if (r != 2 || c != 2)
        {
           return old;
        }
        for (int x = 0; x < r; x++)
        {
            for (int y = 0; y < c; y++)
            {
                for (int z = 0; z < 2; z++)
                {
                    twoD[x, y] = Math.Round(twoD[x, y] + (matrix[x, z] * rotate[z, y]), 2);
                }
            }
        }
        return twoD;
    }
}
