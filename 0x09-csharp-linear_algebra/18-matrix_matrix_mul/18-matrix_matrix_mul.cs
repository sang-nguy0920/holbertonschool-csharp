using System;
using System.Collections.Generic;

/// <summary>Public MatrixMath class.</summary>
class MatrixMath
{
    /// <summary>Multiplies two matrices and returns the resulting matrix.</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] old = new double[,] {{-1}};
        double[,] res;
        int matrixLen = matrix1.GetLength(1);
        double temp;

        if (matrixLen == matrix2.GetLength(0))
            res = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
        else
            return (old);
        for (int x = 0; x < res.GetLength(0); x++)
        {
            for (int y = 0; y < res.GetLength(1); y++)
            {
                temp = 0;
                for (int z = 0; z < matrixLen; z++)
                {
                    temp += matrix1[x, z] * matrix2[z, y];
                }
                res[x, y] = temp;
            }
        }
        return (res);
    }
}

