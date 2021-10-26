using System;
using System.Windows;
class Program
{
    static void Main(string[] args)
    {
        double[] vectorOne2d = {1, 3};
        double[] vectorTwo2d = {-2, 5};
        double[] vectorOne3d = {-4, 0, 10};
        double[] vectorTwo3d = {3, 7, -9};
        Console.WriteLine(VectorMath.DotProduct(vectorOne2d, vectorTwo2d));
        Console.WriteLine(VectorMath.DotProduct(vectorOne3d, vectorTwo3d));
    }
}
