using System;
using System.Collections.Generic;

/// <summary>Public MatrixMath class.</summary>
class MatrixMath
{
    /// <summary>Calculates the inverse of a 2D matrix.</summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        double[,] old = new double[,] {{-1}};
        double res;

        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            res = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
            if (res == 0)
                return (old);
            double[,] inv = new double[,] {
                {(1 / res) * matrix[1, 1], (1 / res) * -matrix[0, 1]},
                {(1 / res) * -matrix[1, 0], (1 / res) * matrix[0, 0]}
            };
            return (inv);
        }
        return (old);
    }
}
