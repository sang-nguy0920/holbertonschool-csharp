﻿using System;
using System.Collections.Generic;

/// <summary>Public VectorMath class.</summary>
class VectorMath
{
    /// <summary>Calculates cross product of two 3D vectors.</summary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        double[] vector3;

        if (vector1.Length == 3 && vector2.Length == 3)
        {
            vector3 = new double[3] {
                (vector1[1] * vector2[2]) - (vector1[2] * vector2[1]),
                (vector1[2] * vector2[0]) - (vector1[0] * vector2[2]),
                (vector1[0] * vector2[1]) - (vector1[1] * vector2[0])
            };
            return (vector3);
        }
        return (new double[] {-1});
    }
}
