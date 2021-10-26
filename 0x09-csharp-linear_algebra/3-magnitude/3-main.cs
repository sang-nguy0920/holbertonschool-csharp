using System;
using System.Windows;

class Program
{
    static void Main(string[] args)
    {
        double[] vector2d = {3, 9};
        double[] vector3d = {7, -3, -9};

        Console.WriteLine(VectorMath.Magnitude(vector2d));
        Console.WriteLine(VectorMath.Magnitude(vector3d));
    }
}
