using System;
using System.Collections.Generic;

/// <summary>Public MatrixMath class.</summary>
class MatrixMath
{
    /// <summary>Shears a square 2D matrix by a given shear factor.</summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] old = new double[,] {{-1}};
        double[,] twoD = new double[2, 2];
        double[,] res = new double[2, 2] {{1, 0}, {0, 1}};

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return old;
        }
        if (direction == 'x')
        {
            res[1, 0] = factor;
        }
        else if (direction == 'y')
        {
            res[0, 1] = factor;
        }
        else
        {
            return old;
        }
        for (int x = 0; x < 2; x++)
        {
            for (int y = 0; y < 2; y++)
            {
              for (int z = 0; z < 2; z++)  
                {
                    twoD[x, y] = twoD[x, y] + (matrix[x, z] * res[z, y]);
                }
            }
        }
        return twoD;
    }
}
