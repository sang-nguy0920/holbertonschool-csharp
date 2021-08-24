using System;
using System.Collections.Generic;

/// <summary>Public MatrixMath class.</summary>
class MatrixMath
{
    /// <summary>Multiplies a matrix and a scalar and returns the resulting matrix.</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] old = new double[,] {{-1}};
        int height = matrix.GetLength(0);
        int width = matrix.GetLength(1);
        double[,] res;

        if (height == 2 && width == 2)
                res = new double[2, 2];
        else if (height == 3 && width == 3)
                res = new double[3, 3];
        else
            return (old);
        for (int x = 0; x < height; x++)
        {
            for (int y = 0; y < width; y++)
            {
                res[x, y] = matrix[x, y] * scalar;
            }
        }
        return (res);
    }
}
