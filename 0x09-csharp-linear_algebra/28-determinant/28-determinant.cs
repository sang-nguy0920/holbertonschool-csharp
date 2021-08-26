﻿using System;
using System.Collections.Generic;

/// <summary>Public MatrixMath class.</summary>
class MatrixMath
{
    /// <summary>Calculates the determinant of a matrix.</summary>
    public static double Determinant(double[,] matrix)
    {
        double res = 0;
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            res = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
        }
        else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
        {
            res = Math.Round(
                (matrix[0, 0] * matrix[1, 1] * matrix[2, 2]) +
                (matrix[1, 0] * matrix[2, 1] * matrix[0, 2]) +
                (matrix[2, 0] * matrix[0, 1] * matrix[1, 2]) -
                (matrix[0, 0] * matrix[2, 1] * matrix[1, 2]) -
                (matrix[2, 0] * matrix[1, 1] * matrix[0, 2]) -
                (matrix[1, 0] * matrix[0, 1] * matrix[2, 2]), 2);
        }
        else
        {
            return (-1);
        }
        return (res);
    }
}
