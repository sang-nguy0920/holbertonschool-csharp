using System;
using System.Collections.Generic;

/// <summary>Public MatrixMath class.</summary>
class MatrixMath
{
    /// <summary>Adds two matrices and returns the resulting matrix.</summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] oldMatrix = new double[,] {{-1}};
        double[,] result;
        if (matrix1.GetLength(0) == 2 && matrix1.GetLength(1) == 2 && matrix2.GetLength(0) == 2 && matrix2.GetLength(1) == 2)
        {
            result = new double[2,2];
        }
        else if (matrix1.GetLength(0) == 3 && matrix1.GetLength(1) == 3 && matrix2.GetLength(0) == 3 && matrix2.GetLength(1) == 3)
        {
            result = new double[3,3];
        }
        else
        {
            return oldMatrix;
        }
        for (int x = 0; x < matrix1.GetLength(0); x++)
        {
            for (int y = 0; y < matrix1.GetLength(1); y++)
            {
                result[x, y] = matrix1[x, y] + matrix2[x, y]; 
            }
        }
        return result;
    }
}
