using System;
using System.Windows;

class Program
{
    static void Main(string[] args)
    {
        double[] vector2d = {98, 972};
        double[] vector3d = {0, -16, 31};
        double scalar = 0.5;
        double scalar2 = 4;
        double [] res2d;
        double [] res3d;

        res2d = VectorMath.Multiply(vector2d, scalar);
        res3d = VectorMath.Multiply(vector3d, scalar2);

        Console.WriteLine("(" + res2d[0] + ", " + res2d[1] + ")");
        Console.WriteLine("(" + res3d[0] + ", " + res3d[1] + ", " + res3d[2] + ")");
    }
}
