using System;
using System.Collections.Generic;

/// <summary>Public VectorMath class.</summary>
class VectorMath
{
    /// <summary>Multiplies a vector/scalar, returns the resulting vector.</summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] res_vec = new double[1] {-1};
        if (vector.Length == 2)
        {
            res_vec = new double[2] {vector[0] * scalar, vector[1] * scalar};
        }
        else if (vector.Length == 3)
        {
            res_vec = new double[3] {vector[0] * scalar, vector[1] * scalar, vector[2] * scalar};
        }
        return (res_vec);
    }
}
