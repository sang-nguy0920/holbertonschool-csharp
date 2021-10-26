using System;
using System.Collections.Generic;

/// <summary>Public MatrixMath class.</summary>
class MatrixMath
{
    /// <summary>Transpose a matrix and return the resulting matrix.</summary>
    public static double[,] Transpose(double[,] matrix)
    {
        int wid = matrix.GetLength(1);
        int hei = matrix.GetLength(0);
        double[,] matrix3 = new double[wid, hei];

        for (int i = 0; i < wid; i++)
        {
            for (int j = 0; j < hei; j++)
            {
                matrix3[i, j] = matrix[j, i];
            }
        }
        return (matrix3);
    }
}

