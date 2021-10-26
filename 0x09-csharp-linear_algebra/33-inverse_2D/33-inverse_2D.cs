using System;
using System.Collections.Generic;

/// <summary>Public MatrixMath class.</summary>
class MatrixMath
{
    /// <summary>Calculates the inverse of a 2D matrix.</summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        int row = matrix.GetLength(0);
        int column = matrix.GetLength(1);
        
        if (row != 2 && column != 2)
        {
            return new double[,] {{-1}};
        }
        double res = (matrix[0,0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
        if (res == 0)
        {
            return new double[,] {{-1}};
        }
        double[,] inverse = new double[,] {{Math.Round((1 / res) * matrix[1, 1], 2), Math.Round((1 / res) * -matrix[0, 1], 2)}, {Math.Round((1 / res) * -matrix[1, 0], 2), Math.Round((1 / res) * matrix[0, 0],2)}};
        return inverse;
    }
}
